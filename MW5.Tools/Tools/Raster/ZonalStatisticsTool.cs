// -------------------------------------------------------------------------------------------
// <copyright file="ZonalStatisticsTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Static;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Tools.Enums;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.Raster
{
    [GisTool(GroupKeys.Raster)]
    public class ZonalStatisticsTool: GisTool
    {
        [Input("输入栅格数据", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Raster)]
        public string GridFilename { get; set; }

        [Output("将结果写入矢量到")]
        public IVectorInput Vector { get; set; }

        [Output("覆盖属性字段", 1)]
        public bool OverwriteFields { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "区域叠加统计";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "统计shapefile的每个要素对应的栅格信息，填入属性字段中。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            if (Vector.Datasource.GeometryType == GeometryType.Polygon) return true;

            MessageService.Current.Info("输入矢量图层必须是面矢量。");
            return false;

        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var grid = new GridSource(GridFilename);

            bool result;
            try
            {
                result = GisUtils.Instance.GridStatisticsToShapefile(grid, Vector.Datasource, Vector.SelectedOnly,
                    OverwriteFields);
            }
            catch (Exception)
            {
                grid.Dispose();
                throw;
            }

            return result;
        }
    }
}
