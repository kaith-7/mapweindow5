// -------------------------------------------------------------------------------------------
// <copyright file="VectorToolsGroup.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Model;

namespace MW5.Tools.Tools.VectorTools
{
    [CustomLayout]
    [GisTool(GroupKeys.VectorTools, groupName: "矢量处理工具", groupDescription: "对于矢量数据的地理处理工具。", icon: ToolIcon.Hammer, onlyGroup: true)]
    public class VectorToolsGroup : GisTool
    {
        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description => "对于矢量数据的地理处理工具。";

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name => "Vector Tools";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Provide execution logic for the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            return true;
        }
    }
}