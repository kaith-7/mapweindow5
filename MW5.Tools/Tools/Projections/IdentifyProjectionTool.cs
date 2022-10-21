// -------------------------------------------------------------------------------------------
// <copyright file="IdentifyProjectionTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Plugins.Concrete;
using MW5.Projections.Forms;
using MW5.Plugins.Enums;
using MW5.Shared;
using MW5.Tools.Model;

namespace MW5.Tools.Tools.Projections
{
    [CustomLayout]
    [GisTool(GroupKeys.Projections, groupDescription: "用于处理坐标系和投影的工具。")]
    public class IdentifyProjectionTool : ToolBase
    {
        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "识别投影";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "从用户提供的投影字符串中，将投影标识为一种众所周知的投影。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run()
        {
            using (var form = new IdentifyProjectionForm(_context))
            {
                return _context.View.ShowChildView(form);
            }
        }
    }
}
