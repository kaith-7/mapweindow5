using System.Collections.Generic;
using MW5.Plugins.Concrete;
using MW5.Plugins.TableEditor.Properties;

namespace MW5.Plugins.TableEditor.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(TableEditorPlugin plugin)
            : base(plugin.Identity)
        {
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                new MenuCommand(Resources.te_ShowTable, MenuKeys.ShowTable, Resources.table_editor,
                "打开所选图层的属性表。"),
            };
        }
    }
}
