// -------------------------------------------------------------------------------------------
// <copyright file="ValidateShapefileTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Helpers;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using System.Collections.Generic;
using System.Linq;

namespace MW5.Plugins.ShapeEditor.Tools.VectorTools.DataProcess
{
    [CustomLayout]
    [GisTool(GroupKeys.DataProcess, parentGroupKey: GroupKeys.VectorTools)]
    public class CombineLayersTool : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Input("输入图层", 1)]
        public IVectorInput Input2 { get; set; }

        [Output("输出图层")]
        [OutputLayer("{input}_合并.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, MW5.Tools.Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<CombineLayersTool>();
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "合并图层";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description =>
            "合并图形类型相同的图层。 ";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        public override bool SupportsCancel => true;

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName => $"合并 {Input.Name} 与 {Input2.Name}.";

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var ds = Input.Datasource;
            var ds2 = Input2.Datasource;

            if (ds == ds2)
            {
                MessageService.Current.Info("不能合并同一个图层!!!");
                return false;
            }

            if (ds.GeometryType != ds2.GeometryType
                || ds.ZValueType != ds2.ZValueType
                || !ds.Projection.IsSame(ds2.Projection))
            {
                MessageService.Current.Info("请输图层类型不一致!!!");
                return false;
            }

            var featureSet = ds.Union(false, ds2, false);

            Output.Result = featureSet;

            return true;
        }

        public int GetFieldByName(string dsName, string fieldName)
        {
            return -1;
        }

        /// <summary>
        /// Saves the output.
        /// </summary>
        public override bool AfterRun()
        {
            if (Output.Result == null)
                return false;

            if (!OutputManager.Save(Output.Result, Output))
            {
                Log.Error("输出文件保存失败: {0}", null, Output.Filename);
            }

            // false since there are invalid shapes, i.e. validation failed
            return true;
        }
    }
}
