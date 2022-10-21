// -------------------------------------------------------------------------------------------
// <copyright file="PolygonizeGridTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using System.IO;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Static;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Tools.Enums;
using MW5.Tools.Model;

namespace MW5.Tools.Tools.Raster
{
    [GisTool(GroupKeys.Raster)]
    public class PolygonizeGridTool: GisTool
    {
        [Input("输入栅格图层", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Raster)]
        public string GridFilename { get; set; }

        // TODO: dedicated band index parameter is needed
        [Input("波段", 1)]                
        public int BandIndex { get; set; }

        [Output("输出图层", 0)]
        [OutputLayer("{input}_poly.shp", LayerType.Shapefile, false)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<PolygonizeGridTool>()
                .SetDefault(t => t.BandIndex, 1);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "栅格转多边形";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "将栅格数据按照像素值，将具有空间上连续的相同像素值的栅格构建为一个多边形要素，从而得到对应的面矢量。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            // ReSharper disable once InvertIf
            if (Output.Overwrite && !GeoSource.Remove(Output.Filename))
            {
                Log.Warn("移除失败的文件: " + Output.Filename, null);
                return false;
            }

            return GisUtils.Instance.Polygonize(GridFilename, Output.Filename, BandIndex, false, null, GdalFormats.Shapefile);
        }

        /// <summary>
        /// A method called after the main IGisTool.Run method is successfully finished.
        /// Is executed on the UI thread. Typically used to save output datasources.
        /// Default implementation automatically handles values assigned to OutputLayerInfo.Result.
        /// </summary>
        public override bool AfterRun()
        {
            if (!Output.AddToMap || !File.Exists(Output.Filename)) return false;

            Log.Info("添加处理结果到当前地图文档");

            var fs = new FeatureSet(Output.Filename);

            OutputManager.AddToMap(fs);

            return true;
        }
    }
}
