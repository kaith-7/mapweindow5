﻿using System;
using System.Diagnostics;
using System.IO;
using MW5.Api;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Api.Static;
using MW5.Plugins.Services;
using MW5.Projections.Enums;
using MW5.Projections.Forms;
using MW5.Projections.Helpers;
using MW5.Projections.Services.Abstract;
using MW5.Shared;

namespace MW5.Projections.Services
{
    /// <summary>
    /// Reprojects shapefiles, images and grids from one coordinate system to another.
    /// </summary>
    public class ReprojectingService: IReprojectingService
    {
        /// <summary>
        /// Reprojects layer source, including shapefiles, images and grids.
        /// </summary>
        public TestingResult Reproject(ILayerSource layer, out ILayerSource newLayer, ISpatialReference projection, TesterReportForm report)
        {
            if (layer.SeekSubstituteFile(projection, out newLayer))
            {
                return TestingResult.Substituted;
            }

            string newFilename = GetSafeNewName(layer, projection);
            
            switch(layer.LayerType)
            {
                case LayerType.VectorLayer:
                    newFilename = System.IO.Path.ChangeExtension(newFilename, ".shp");
                    newLayer = Reproject(((VectorLayer)layer).Data as IFeatureSet, projection, "");
                    break;
                case LayerType.Shapefile:
                    newLayer = Reproject(layer as IFeatureSet, projection, "");
                    break;
                case LayerType.Grid:
                    newLayer = Reproject(layer as GridSource, projection, newFilename);
                    break;
                case LayerType.Image:
                    newLayer = Reproject(layer as BitmapSource, projection, newFilename);
                    break;
            }
            return newLayer != null ? TestingResult.Ok : TestingResult.Error;
        }

        /// <summary>
        /// Reprojects the specified vector layer.
        /// </summary>
        private IFeatureSet Reproject(IFeatureSet fsSource, ISpatialReference newProjection, string saveAsFilename)
        {
            int count;
            if (fsSource == null)
            {
                Logger.Current.Warn("Invalid vector datasource.");
                return null;
            }

            var fs = fsSource.Reproject(newProjection, null, out count);

            if (fs == null)
            {
                Logger.Current.Warn("Failed to reproject vector datasource: " + fsSource.LastError);
                return null;
            }

            if (count == fsSource.Features.Count)
            {
                if (!string.IsNullOrEmpty(saveAsFilename))
                {
                    bool result = fs.SaveAs(saveAsFilename);
                    if (!result)
                    {
                        Logger.Current.Warn("Failed to save reprojected shapefile: " + fs.LastError);
                        fs.Close();
                        return null;
                    }

                    Logger.Current.Info("Vector datasource is reprojected: " + saveAsFilename); 
                }
                return fs;
            }

            Logger.Current.Warn("Not all features of the datasource were reprojected. The results are discarded.");

            fs.Close();
            return null;
        }

        /// <summary>
        /// Reprojects a grid
        /// </summary>
        public GridSource Reproject(GridSource grid, ISpatialReference newProjection, string saveAsFilename)
        {
            string[] options = { "-t_srs", newProjection.ExportToProj4() };
            //if (GdalUtils.Instance.WarpRaster(grid.Filename, saveAsFilename, newProjection))
            if (GdalUtils.Instance.WarpRaster(grid.Filename, saveAsFilename, options))
            {
                //gridNew.AssignNewProjection(newProjection.ExportToProj4());
                return new GridSource(saveAsFilename);
            }

            Logger.Current.Warn("Failed to warp raster datasource: " + grid.Filename);
            return null;
        }
        
        /// <summary>
        /// Reprojects image
        /// </summary>
        public IImageSource Reproject(IImageSource image, ISpatialReference projection, string saveFilename)
        {   string[] options = new string[] {
            "-s_srs",
            image.Projection.ExportToWkt(),
            "-t_srs",
            projection.ExportToWkt(),
            "-of",
            "VRT"};

            string name = System.IO.Path.GetFileName(saveFilename);
            string saveAsFilename = @"/vsimem/" + name;
            if (GdalUtils.Instance.WarpRaster(image.Filename, saveAsFilename, options))
            {
                var bmp = BitmapSource.Open(saveAsFilename, false);
                return bmp;
            }

            Logger.Current.Warn(string.Format("影像重投影失败: {0}\n{1}\n{2}", image.Filename, GdalUtils.Instance.LastErrorMessage(), saveAsFilename));
            return null;
        }

        /// <summary>
        /// Returns new filename and ensures that such file doesn't exist. Adds postfix if necessary.
        /// </summary>
        public static string GetSafeNewName(ILayerSource layer, ISpatialReference projection)
        {
            string filename = ProjectionHelper.FilenameWithProjectionSuffix(layer.Filename, layer.Projection, projection);
            if (layer.LayerType == LayerType.Image)
            {
                //filename = System.IO.Path.GetTempFileName() + System.IO.Path.GetFileNameWithoutExtension(filename) + ".vrt";
                filename = System.IO.Path.GetTempFileName() + ".vrt";
            }

            int index = 0;
            string testName = filename;

            while (File.Exists(testName))
            {
                testName = Path.GetFileNameWithoutExtension(filename) + "_" + index + Path.GetExtension(filename);
                index++;
            }

            return testName;
        }
    }
}
