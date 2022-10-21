using System.Collections.Generic;
using MW5.Plugins.Concrete;
using MW5.Plugins.Identifier.Properties;

namespace MW5.Plugins.Identifier.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity) : base(identity)
        {
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>
            {
                new MenuCommand("要素识别", MenuKeys.IdentifyTool, Resources.icon_identify,
                "单击获取矢量要素的属性和栅格图斑的值。")
            };
        }
    }
}
