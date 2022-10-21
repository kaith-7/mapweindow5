using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Concrete;
using MW5.Plugins.Symbology.Properties;

namespace MW5.Plugins.Symbology.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity) : base(identity)
        {
        }

        protected override void AssignShortcutKeys()
        {
            Commands[MenuKeys.QueryBuilder].ShortcutKeys = Keys.Control | Keys.Q;
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                new MenuCommand(Resources.sy_QueryBuilder, MenuKeys.QueryBuilder, Resources.img_database_search32,
                "书写SQL条件选择要素。"),
                new MenuCommand(Resources.sy_Categories, MenuKeys.Categories, Resources.img_categories32,
                "通过属性分类渲染要素。"),
                new MenuCommand(Resources.sy_LabelMover, MenuKeys.LabelMover, Resources.label_mover,
                "通过拖动，平移改变标签位置。"),
                new MenuCommand(Resources.sy_SymbolRotator, MenuKeys.SymbolRotator, Resources.symbol_rotator,
                "通过单击，使地图符号旋转。"),
                new MenuCommand(Resources.sy_Labels, MenuKeys.Labels, Resources.img_label24),
                new MenuCommand(Resources.sy_Charts, MenuKeys.Charts, Resources.img_chart24),
                new MenuCommand(Resources.sy_LayerProperties, MenuKeys.LayerProperties, Resources.img_properties24)
            };
        }
    }
}
