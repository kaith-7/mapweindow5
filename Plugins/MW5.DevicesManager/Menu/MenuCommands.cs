﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuCommands.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015 - 2019
// </copyright>
// <summary>
//   The menu commands.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MW5.Plugins.DevicesManager.Menu
{
    #region

    using System.Collections.Generic;

    using MW5.Plugins.Concrete;
    using MW5.Plugins.DevicesManager.Properties;

    #endregion

    /// <summary>
    /// The menu commands.
    /// </summary>
    public class MenuCommands : CommandProviderBase
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuCommands" /> class.
        /// </summary>
        /// <param name="identity">The identity.</param>
        public MenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The commands of the toolbar buttons.
        /// </summary>
        /// <returns>
        /// The <see cref="MenuCommand" /> as an IEnumerable
        /// </returns>
        public override IEnumerable<MenuCommand> GetCommands()
        {
            // Create a list of MenuCommands for every toolbar button created in MenuGenerator:
            return new List<MenuCommand>
                       {
                           //new MenuCommand("Show Dialog", MenuKeys.ShowDockableWindow, Resources.monitor)
                           new MenuCommand(Resources.PictureOfDeviceManager, MenuKeys.ShowDeviceManager, Resources.img_server32),
                           new MenuCommand(Resources.PictureOfDeviceManager, MenuKeys.CsvToShp , Resources.img_server32)
                       };
        }

        #endregion
    }
}