// -------------------------------------------------------------------------------------------
// <copyright file="SpatialQueryTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Linq;
using MW5.Api.Enums;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Selection
{
    [GisTool(GroupKeys.Selection, parentGroupKey: GroupKeys.VectorTools)]
    public class SpatialQueryTool: GisTool
    {
        // TODO: disable the selection of datasources from disk
        [Input("选择要素", 0)]
        public IVectorInput Input { get; set; }

        [Input("关联要素", 2)]
        public IVectorInput Input2 { get; set; }

        [Input("关联方法", 1)]
        [ControlHint(ControlHint.Combo)]
        public SpatialRelation Relation { get; set; }

        [Output("处理选择要素方法", 0)]
        [ControlHint(ControlHint.Combo)]
        public SelectionOperation SelectionOperation { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<SpatialQueryTool>()
                .AddComboList(t => t.Relation, EnumHelper.GetValues<SpatialRelation>())
                .AddComboList(t => t.SelectionOperation, EnumHelper.GetValues<SelectionOperation>())
                .SetDefault(t => t.Relation, SpatialRelation.Intersects)
                .SetDefault(t => t.SelectionOperation, SelectionOperation.New);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "空间查询";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "选择图层与关联图层在空间上的关系。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Gets a value indicating whether the tool supports batch execution.
        /// </summary>
        public override bool SupportsBatchExecution => false;

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            if (Input.Datasource.SelectByShapefile(Input2.Datasource, Relation, Input2.SelectedOnly, out var result))
            {
                var layer = _context.Layers.FirstOrDefault(l => l.Handle == Input.LayerHandle);
                if (layer == null) return false;

                layer.UpdateSelection(result, SelectionOperation);
                MessageService.Current.Info("已选择的要素数量: " + result.Length);
            }
            else
            {
                MessageService.Current.Info("没有发现要素。");
            }

            // we don't want to run in as a task, so return false in all cases
            return false;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            // implement the run part as well, although it won't be called from UI,
            // to make the core MapWinGIS method testable
            if (Input.Datasource.SelectByShapefile(Input2.Datasource, Relation, Input2.SelectedOnly, out var result))
            {
                Log.Info("已选择的要素数量: " + result.Length);
            }
            else
            {
                Log.Info("没有选择要素。");
            }

            return true;
        }
    }
}
