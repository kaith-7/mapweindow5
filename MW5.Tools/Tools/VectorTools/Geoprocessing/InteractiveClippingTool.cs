// -------------------------------------------------------------------------------------------
// <copyright file="InteractiveClippingTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Geoprocessing
{
    [GisTool(GroupKeys.Geoprocessing, parentGroupKey: GroupKeys.VectorTools)]
    public class InteractiveClippingTool: GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Input("地图范围", -1)]
        public IEnvelope Extents { get; set; }

        [Output("输出图层", 0)]
        [OutputLayer("{input}_clip.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "矢量裁剪";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "使用当前地图范围裁剪输入数据。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            Extents = Context.Map.Extents;
            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var g = Extents.ToGeometry();
            var fs = new FeatureSet(GeometryType.Polygon);
            fs.Features.EditAdd(g);

            var result = Input.Datasource.Clip(Input.SelectedOnly, fs, false);

            if (result != null)
            {
                Log.Info("输出要素数量: " + result.NumFeatures);
            }

            Output.Result = result;
            return true;
        }
    }
}
