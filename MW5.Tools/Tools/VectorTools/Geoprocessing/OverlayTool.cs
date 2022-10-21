// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OverlayTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015-2019
// </copyright>
// <summary>
//   Defines the Intersection Tool.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MW5.Api.Enums;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Helpers;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Geoprocessing
{
    [CustomLayout]
    [GisTool(GroupKeys.Geoprocessing, ToolIcon.Hammer, parentGroupKey: GroupKeys.VectorTools)]
    public class OverlayTool : GisTool
    {
        [Input("第一个图层", 0)]
        public IVectorInput InputLayer { get; set; }

        [Input("第二个图层", 1)]
        public IVectorInput InputLayer2 { get; set; }

        [Input("分析方法", 2)]
        [ControlHint(ControlHint.Combo)]
        public ClipOperation Operation { get; set; }

        [Output("保存结果到")]
        [OutputLayer("{input}_overlay.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var operations = EnumHelper.GetValues<ClipOperation>();

            configuration.Get<OverlayTool>()
                .AddComboList(t => t.Operation, operations)
                .SetDefault(t => t.Operation, ClipOperation.Intersection);
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description =>
            "对两个矢量层执行叠加操作。 " +
            "可用的方法：裁剪，擦除，交集，交集取反，并集。";

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name => "叠加分析"; 

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName => InputLayer.Name + ": " + GetShortOperationString(Operation);

        public override bool SupportsCancel => true;

        /// <summary>
        /// Gets a value indicating whether the tool supports batch execution.
        /// </summary>
        public override bool SupportsBatchExecution => false;

        /// <summary>
        /// Gets the short operation string.
        /// </summary>
        private string GetShortOperationString(ClipOperation operation)
        {
            switch (operation)
            {
                case ClipOperation.Difference:
                    return "差集";
                case ClipOperation.Intersection:
                    return "交集";
                case ClipOperation.SymDifference:
                    return "对称差集";
                case ClipOperation.Union:
                    return "并集";
                case ClipOperation.Clip:
                    return "剪集";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            if (!InputHelper.InputsAreEqual(InputLayer, InputLayer2)) return true;

            var msg = "两个输入参数使用相同的数据源。 "; 
            msg += "此操作没有意义。";
            MessageService.Current.Info(msg);
            return false;
        }

        /// <summary>
        /// Provide execution logic for the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var fs = InputLayer.Datasource;
            var fs2 = InputLayer2.Datasource;

            switch (Operation)
            {
                case ClipOperation.Difference:
                    Output.Result = fs.Difference(InputLayer.SelectedOnly, fs2, InputLayer2.SelectedOnly);
                    break;
                case ClipOperation.Intersection:
                    Output.Result = fs.Intersection(InputLayer.SelectedOnly, fs2, InputLayer2.SelectedOnly, GeometryType.None);
                    break;
                case ClipOperation.SymDifference:
                    Output.Result = fs.SymmDifference(InputLayer.SelectedOnly, fs2, InputLayer2.SelectedOnly);
                    break;
                case ClipOperation.Union:
                    Output.Result = fs.Union(InputLayer.SelectedOnly, fs2, InputLayer2.SelectedOnly);
                    break;
                case ClipOperation.Clip:
                    Output.Result = fs.Clip(InputLayer.SelectedOnly, fs2, InputLayer2.SelectedOnly);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            return true;
        }
    }
}