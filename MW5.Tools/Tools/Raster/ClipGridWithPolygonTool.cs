// -------------------------------------------------------------------------------------------
// <copyright file="ClipGridWithPolygonTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using System.IO;
using System.Linq;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Static;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.Raster
{
    [GisTool(GroupKeys.Raster)]
    public class ClipGridWithPolygonTool: GisTool
    {
        [Input("输入栅格图层", 0)]
        [DataTypeHint(DataSourceType.Raster)]
        public IRasterInput Input { get; set; }

        [Input("输入矢量图层", 1)]
        public IVectorInput Vector { get; set; }

        //[Input("保持栅格图层范围", 2)]
        //public bool KeepExtents { get; set; }

        [Output("输出图层", 0)]
        [OutputLayer("{input}_clipped.{ext}", LayerType.Image, false)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "使用矢量裁剪栅格";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description =>
            "使用一个矢量面去裁剪栅格要素。删除面范围之外的行和列，将值设置为NoData。 ";

        protected override bool BeforeRun()
        {
            if (Vector.Datasource.GeometryType != GeometryType.Polygon)
            {
                MessageService.Current.Info("无效的矢量图层，必须是面图层。");
                return false;
            }

            if (Vector.Datasource.NumFeatures == 1 || Vector.Datasource.NumSelected == 1) return true;

            MessageService.Current.Info("面矢量有多个要素时，只能选中一个要素做裁剪。");
            return false;

        }

        public override bool SupportsBatchExecution => false;

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        private IGeometry GetPolygon()
        {
            if (Vector.Datasource.NumFeatures == 1)
            {
                return Vector.Datasource.GetGeometry(0);
            }

            if (Vector.Datasource.NumSelected != 1) return null;

            var ft = Vector.Datasource.Features.FirstOrDefault(f => f.Selected);
            return ft?.Geometry;

        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var poly = GetPolygon();
            if (poly == null)
            {
                Log.Warn("无法使用矢量面裁剪。", null);
                return false;
            }

            // ReSharper disable once InvertIf
            if (Output.Overwrite && !GeoSource.Remove(Output.Filename))
            {
                Log.Warn("删除失败的文件: " + Output.Filename, null);
                return false;
            }

            string[] options = new string[] {
                $"-cutline",
                $"{this.Vector.Filename}"
            };
            return GdalUtils.Instance.WarpRaster(Input.Datasource.Filename, Output.Filename, options);
            //return GisUtils.Instance.ClipGridWithPolygon(Input.Datasource.Filename, poly, Output.Filename, KeepExtents);
        }

        /// <summary>
        /// A method called after the main IGisTool.Run method is successfully finished.
        /// Is executed on the UI thread. Typically used to save output datasources.
        /// Default implementation automatically handles values assigned to OutputLayerInfo.Result.
        /// </summary>
        public override bool AfterRun()
        {
            if (!Output.AddToMap || !File.Exists(Output.Filename)) return true;

            Log.Info("添加处理结果到当前地图文档");

            var raster = BitmapSource.Open(Output.Filename, true);

            OutputManager.AddToMap(raster);

            return true;
        }
    }
}
