// -------------------------------------------------------------------------------------------
// <copyright file="ImportLayerTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using MW5.Tools.Services;

namespace MW5.Tools.Tools.Database
{
    [CustomLayout]
    [GisTool(GroupKeys.GeoDatabases, groupDescription:"本工具使用空间数据库，例如：PostGIS, SpatialLite, MS SQL Spatial等。", icon: ToolIcon.Database)]
    public class ImportLayerTool : GisTool
    {
        [Output("数据库")]
        [ControlHint(ControlHint.Combo)]
        public DatabaseConnection Database { get; set; }

        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description => "将图层导入空间数据库。";

        [Input("输入图层", 0)]
        public IVectorInput InputLayer { get; set; }

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name => "导入图层";

        [Output("新图层名称", 2)]
        [ControlHint(ControlHint.OutputName)]
        public string NewLayerName { get; set; }

        [Output("覆盖", 3)]
        public bool Overwrite { get; set; }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        [Output("模式", 1)]
        public string Schema { get; set; }

        /// <summary>
        /// Gets a value indicating whether tasks should be executed
        /// in sequence rather than in parallel when running in batch mode.
        /// </summary>
        public override bool SequentialBatchExecution => true;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var options = PrepareOptions();

            var ds = new VectorDatasource();

            if (!ds.Open(Database.ConnectionString)) return false;

            if (InputLayer.Datasource.HasInvalidShapes())
            {
                Log.Warn("无效数据源，请在导入之前运行修复工具。", null);
                return false;
            }

            if (!ds.ImportLayer(InputLayer.Datasource, NewLayerName, options, ValidationMode.NoValidation))
            {
                Log.Warn("shapefile导入失败: " + ds.GdalLastErrorMsg, null);
                return false;
            }

            Log.Info("已导入图层: " + NewLayerName);
            return true;

        }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<ImportLayerTool>()
                .AddComboList(t => t.Database, context.Repository.Connections)
                .SetDefault(t => t.NewLayerName, "{input}_imported");
        }

        /// <summary>
        /// Preparing format specific options.
        /// </summary>
        private string PrepareOptions()
        {
            var list = new List<string>();

            if (!string.IsNullOrWhiteSpace(Schema))
            {
                list.Add("SCHEMA=" + Schema);
            }

            if (Database != null && Database.DatabaseType == GeoDatabaseType.MySql)
            {
                list.Add("ENGINE=MyISAM ");
                    // Spatial indexes aren't supported otherwise http ://stackoverflow.com/questions/18379808/the-used-table-type-doesnt-support-spatial-indexes
            }

            if (Overwrite)
            {
                list.Add("OVERWRITE=TRUE");
            }

            var s = string.Empty;
            foreach (var item in list)
            {
                s += item + ";";
            }

            return s;
        }
    }
}