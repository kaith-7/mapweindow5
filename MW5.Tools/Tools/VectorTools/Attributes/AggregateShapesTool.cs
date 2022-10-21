// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AggregateShapesTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015-2019
// </copyright>
// <summary>
//   Defines the AggregateShapes tool.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Helpers;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using MW5.Tools.Services;

namespace MW5.Tools.Tools.VectorTools.Attributes
{
    [CustomLayout]
    [GisTool(GroupKeys.Attributes, icon: ToolIcon.Hammer, parentGroupKey: GroupKeys.VectorTools)]
    public class AggregateShapesTool : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput InputLayer { get; set; }

        [Input("字段", 1, false)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndex { get; set; }

        [Input("操作组", 0, true)]
        public FieldOperationList GroupOperations { get; set; }

        [Output("保存结果到")]
        [OutputLayer(@"{input}_aggregate.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<AggregateShapesTool>()
                .AddField(t => t.InputLayer, t => t.FieldIndex)
                .AddField(t => t.InputLayer, t => t.GroupOperations);
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "按属性统计"; }
        }

        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "通过提取具有相同指定属性的要素，组成一个新的shapefile。"; }
        }

        /// <summary>
        /// Gets a value indicating whether the tool supports batch execution.
        /// </summary>
        public override bool SupportsBatchExecution
        {
            get { return false; }
        }

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        /// <returns></returns>
        protected override bool BeforeRun()
        {
            return GroupOperations.ValidateWithMessage(InputLayer.Datasource);
        }

        /// <summary>
        /// Provide execution logic for the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            Log.Info("指定操作组数量: " + GroupOperations.Count);

            Output.Result = InputLayer.Datasource.AggregateShapesWithStats(InputLayer.SelectedOnly, FieldIndex, GroupOperations);
            return true;
        }
    }
}