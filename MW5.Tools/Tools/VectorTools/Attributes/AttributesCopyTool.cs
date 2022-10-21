// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DissolveTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015-2019
// </copyright>
// <summary>
//   Defines the DissolveTool tool.
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
    [GisTool(GroupKeys.Attributes, parentGroupKey: GroupKeys.VectorTools)]
    public class AttributesCopyTool : GisTool
    {
        [Input("输入图层(面)", 0)]
        public IVectorInput InputPoly { get; set; }

        //[Input("字段索引", 1)]
        //[ControlHint(ControlHint.Field)]
        //public int FieldIndex { get; set; }

        [Input("输入图层(点)", 1)]
        public IVectorInput InputPoint { get; set; }

        //[Output("保存结果到")]
        //[OutputLayer(@"{input}_dissolve.shp", LayerType.Shapefile)]
        //public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            //configuration.Get<AttributesCopyTool>()
            //    .AddField(t => t.InputPoint, t => t.FieldIndex)
            //    .AddField(t => t.InputPoly, t => t.GroupOperations);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "属性提取";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "将面要素属性按照空间关系赋给点要素。";

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
        /// <returns></returns>
        protected override bool BeforeRun()
        {
            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            //Log.Info("指定组操作数: " + GroupOperations.Count);
            
            InputPoint.Datasource.AttributeCopy(InputPoly.Datasource);
            return true;
        }
    }
}
