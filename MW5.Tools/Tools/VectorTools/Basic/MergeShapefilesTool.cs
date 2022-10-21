// -------------------------------------------------------------------------------------------
// <copyright file="MergeShapefilesTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Tools.Helpers;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Basic
{
    [GisTool(GroupKeys.Basic, parentGroupKey: GroupKeys.VectorTools)]
    public class MergeShapefilesTool: GisTool
    {
        [Input("第一个图层", 0)]
        public IVectorInput Input { get; set; }

        [Input("第二个图层", 1)]
        public IVectorInput Input2 { get; set; }

        [Output("保存结果到")]
        [OutputLayer("{input}_merge.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "合并矢量";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description =>
            "将两个shapefile合并为一个，同时复制两个shapefile的所有属性字段。" + 
            "输入的shapefile必须是相同的类型。";

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
            if (InputHelper.InputsAreEqual(Input, Input2))
            {
                MessageService.Current.Info("两个输入参数的数据源相同。");
                return false;
            }

            if (Input.Datasource.GeometryType == Input2.Datasource.GeometryType) return true;

            MessageService.Current.Info("输入的shapefile必须是相同的类型。");
            return false;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var result = Input.Datasource.Merge(Input.SelectedOnly, Input2.Datasource, Input2.SelectedOnly);

            Log.Info("第一个输入参数的要素数量: " + Input.Datasource.NumFeatures);
            Log.Info("第二个输入参数的要素数量: " + Input2.Datasource.NumFeatures);
            Log.Info("输出结果的要素数量: " + result);

            Output.Result = result;
            return true;
        }
    }
}
