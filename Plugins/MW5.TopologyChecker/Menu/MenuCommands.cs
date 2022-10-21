using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Concrete;
using MW5.Plugins.TopologyChecker.Properties;

namespace MW5.Plugins.TopologyChecker.Menu
{
    public class MenuCommands: CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        protected override void AssignShortcutKeys()
        {
            // it overrides copy command in panels, Debug window for example
            // so let's comment for the time being
            //Commands[MenuKeys.Copy].ShortcutKeys = Keys.Control | Keys.C;
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                new MenuCommand(Resources.TopologyCheckerView, MenuKeys.ShowTopologyRulesWindow, Resources.img_info,
                "设置拓扑规则。"),
            };
        }
    }
}
