﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuGenerator.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015 - 2019
// </copyright>
// <summary>
//   The menu generator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using MW5.Plugins.Enums;
using MW5.Plugins.DevicesManager.Properties;

namespace MW5.Plugins.DevicesManager.Menu
{
    #region

    using MW5.Plugins.Concrete;
    using MW5.Plugins.Interfaces;

    #endregion

    /// <summary>
    /// The menu generator.
    /// </summary>
    public class MenuGenerator
    {
        #region Fields

        /// <summary>
        /// The menu commands.
        /// </summary>
        private readonly MenuCommands _commands;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuGenerator" /> class.
        /// </summary>
        /// <param name="context">The application context.</param>
        /// <param name="plugin">The plugin.</param>
        public MenuGenerator(IAppContext context, DevicesManagerPlugin plugin)
        {
            _commands = new MenuCommands(plugin.Identity);

            // Create the toolbar:
            InitToolbar(context, plugin.Identity);

            // Create new top-level menu:
            InitMenu(context, plugin.Identity);
        }
        #endregion

        #region Methods

        /// <summary>
        /// Initialize the new menu.
        /// </summary>
        /// <param name="context">The application context.</param>
        /// <param name="identity">The plug-in identity.</param>
        private static  void InitMenu(IAppContext context, PluginIdentity identity)
        {
            //var items = context.Menu.Items;
            //items.AddButton(_commands[MenuKeys.CsvToShp]);
            //items.AddButton(_commands[MenuKeys.ShowDeviceManager]);
            //var menu = context.Menu.Items.AddDropDown("Template", "_", identity);
            //menu.Icon = new MenuIcon(Resources.template_icon); // template by LAFS from the Noun Project
            //menu.SubItems.AddButton("Info", MenuKeys.ShowDockableWindow, identity);

            //var submenu = menu.SubItems.AddDropDown("SubMenu", MenuKeys.SubMenu, identity);
            //var btn = submenu.SubItems.AddButton("Foo", MenuKeys.Foo, identity);
            //btn.Icon = new MenuIcon(Resources.hello_icon); // hello by Deemak Daksina from the Noun Project
            //submenu.SubItems.AddButton("Bar", MenuKeys.Bar, identity);
        }

        /// <summary>
        /// Initialize the toolbar.
        /// </summary>
        /// <param name="context">The application context.</param>
        /// <param name="identity">The plug-in identity.</param>
        private void InitToolbar(IAppContext context, PluginIdentity identity)
        {
            var items = context.Toolbars.FileToolbar.Items;
            items.AddButton(_commands[MenuKeys.ShowDeviceManager]);
            items.AddButton(_commands[MenuKeys.CsvToShp]);
        }

        #endregion
    }
}