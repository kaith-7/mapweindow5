// -------------------------------------------------------------------------------------------
// <copyright file="MenuCommands.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MW5.Plugins.Concrete;
using MW5.Plugins.Printing.Properties;

namespace MW5.Plugins.Printing.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>
                       {
                           new MenuCommand(Resources.Print, MenuKeys.Print, Resources.img_printer24,
                           "打印当前地图文档。"),
                           new MenuCommand(Resources.SelectPrintArea, MenuKeys.SelectPrintArea, Resources.img_select_print_area24,
                           "拖拽矩形，选择当前地图文档需要打印的区域。")
                       };
        }
    }
}