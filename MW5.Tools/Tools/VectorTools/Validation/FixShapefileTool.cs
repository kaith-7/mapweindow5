// -------------------------------------------------------------------------------------------
// <copyright file="FixShapefileTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Api.Static;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Validation
{
    [GisTool(GroupKeys.Validation, parentGroupKey: GroupKeys.VectorTools)]
    public class FixShapefileTool : AppendModeGisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Output("输出图层")]
        [OutputLayer("{input}_fix.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "修复矢量";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "通过修复当前矢量无效的要素，来创建新的shapefile。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            if (Input.Datasource.HasInvalidShapes()) return true;

            MessageService.Current.Info("输入矢量未发现无效的要素。");
            return false;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            bool success;

            if (Output.MemoryLayer)
            {
                Output.Result = Input.Datasource.FixUpShapes(Input.SelectedOnly);
                success = true;
            }
            else
            {
                success = GisUtils.Instance.FixUpShapes(Input.Datasource, Input.SelectedOnly, Output.Filename, Output.Overwrite);
            }

            if (!success)
            {
                Log.Info("修复矢量失败。");
            }

            return success;
        }
    }
}
