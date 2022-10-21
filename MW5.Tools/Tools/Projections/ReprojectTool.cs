// -------------------------------------------------------------------------------------------
// <copyright file="ReprojectTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Interfaces;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using MW5.Tools.Model.Parameters;
using MW5.Tools.Services;
using System.Collections.Generic;

namespace MW5.Tools.Tools.Projections
{
    [GisTool(GroupKeys.Projections, groupDescription: "用于处理坐标系和投影的工具。")]
    public class ReprojectTool : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Input("新投影", 1)]
        public ISpatialReference NewProjection { get; set; }

        [Input("转换参数", 2)]
        [ControlHint(Enums.ControlHint.GeoTransParams)]
        public GeographicTransformation TransformType { get; set; }

        [Output("输出图层", 0)]
        [OutputLayer("{input}_reprojected.shp", Api.Enums.LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "矢量重投影";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "将矢量数据重新投影。";

        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);
            //var listGeoTrans = new List<string>();
            //listGeoTrans.AddRange(new string[] { "Beijing54_to_WGS84_1", "Beijing54_to_WGS84_2", "Xian80_to_WGS84_1" });
            //configuration.Get<ReprojectTool>()
            //    .AddComboList(t => t.GeographicTransformation, listGeoTrans);
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        public override bool Validate()
        {
            foreach (var p in Parameters)
            {
                if (p is OutputLayerParameter outputParameter)
                {
                    Output = outputParameter.GetValue();
                    if (Output != null)
                    {
                        if (!Output.MemoryLayer && !System.IO.Path.IsPathRooted(Output.Filename))
                        {
                            var dir = "";
                            foreach (var p1 in Parameters)
                            {
                                if (p1.IsInput)
                                {
                                    if (p1 is Model.Parameters.Layers.VectorLayerParameter veclayer)
                                    {
                                        if (veclayer.Datasource is IFeatureSet fs)
                                        {
                                            dir = System.IO.Path.GetDirectoryName(fs.UnProjectedFilename);
                                            break;
                                        }
                                    }
                                }
                            }
                            Output.Filename = System.IO.Path.Combine(dir, Output.Filename);
                            outputParameter.SetFileName(Output.Filename);
                        }
                    }
                }
            }
            return base.Validate();
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var fs = Input.Datasource;
            if(!string.IsNullOrEmpty(fs.UnProjectedFilename))
            {
                fs = new MW5.Api.Concrete.FeatureSet(fs.UnProjectedFilename);
            }

            var transType = TransformType.TransType;
            var paramArray = TransformType.ParamArray;

            if (fs.Projection.IsSame(NewProjection))
            {
                string msg = "源数据和目标投影是相同的。";
                Log.Info(msg, null);
                return false;
            }


            //var options = new string[]
            //{
            //    "-t_srs",
            //    $"EPSG:{this.NewProjection.GetEpsgCode()}",
            //    "-towgs84",
            //    paramArray.JoinToString(),
            //};

            // return MW5.Api.Static.GdalUtils.Instance.VectorTranslate(Input.Filename, Output.Filename, options);
            var newFs = fs.Reproject(NewProjection, paramArray.ToArray(), out var count);
            if (newFs == null || count == 0)
            {
                Log.Warn("没有要素被重投影。", null);
                return false;
            }

            if (count != fs.NumFeatures)
            {
                Log.Warn("部分要素没有重投影: {0} from {1}", null, count, fs.NumFeatures);
            }

            Output.Result = newFs;
            return true;
        }

        public override bool AfterRun()
        {
            return base.AfterRun(); // TODO：Add to map like ClipGridWithPolygonTool
        }
    }
}
