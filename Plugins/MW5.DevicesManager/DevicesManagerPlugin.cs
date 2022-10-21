﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InitPlugin.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015 - 2019
// </copyright>
// <summary>
//   The initialization of the plugin.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using MW5.Plugins.Mvp;
using MW5.Tools.Helpers;
using System.Diagnostics;

namespace MW5.Plugins.DevicesManager
{
    #region

    using System.Diagnostics;
    using System.Linq;

    using MW5.Plugins.Concrete;
    using MW5.Plugins.Interfaces;
    using MW5.Plugins.Mef;
    using MW5.Plugins.DevicesManager.Menu;

    #endregion

    /// <summary>
    /// The template plugin.
    /// </summary>
    /// <seealso cref="MW5.Plugins.Concrete.BasePlugin" />
    [MapWindowPlugin(loadOnStartUp: true)]
    public class DevicesManagerPlugin : BasePlugin
    {
        #region Fields

        /// <summary>
        /// The context of the application, holding the menu, layers, project, etc.
        /// </summary>
        private IAppContext _context;

        /// <summary>
        /// The reference to the map listener class, is used in the constructor
        /// </summary>
        private MapListener _mapListener;

        /// <summary>
        /// The reference to the menu generator class, is used in the constructor
        /// </summary>
        private MenuGenerator _menuGenerator;

        /// <summary>
        /// The reference to the menu listener class, is used in the constructor
        /// </summary>
        private MenuListener _menuListener;

        /// <summary>
        /// The reference to the sample dock user control, is used in the constructor
        /// </summary>
        private DevicesForm _deviceForm;

        /// <summary>
        /// The reference to the sample dock user control, is used in the constructor
        /// </summary>
        private CsvToShp _csvToShp ;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Set up container for dependency injection:
        /// </summary>
        /// <param name="container">The container.</param>
        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }

        /// <summary>
        /// The initialize method, called when the plug-in is loaded
        /// </summary>
        /// <param name="context">The application context.</param>
        public override void Initialize(IAppContext context)
        {
            // Save to local properties:
            _context = context;

            // Will better to preserve state if plugin is unloaded, therefore singleton
            // Because SampleDockWindow is injected in MenuListener and MapListener it should be call before them:
            //_sampleDockWindow = context.Container.GetSingleton<SampleDockWindow>();   

            _menuGenerator = context.Container.GetInstance<MenuGenerator>();
            _menuListener = context.Container.GetInstance<MenuListener>();
            //_mapListener = context.Container.GetInstance<MapListener>();

            // Event handlers are in the MapListener class:

            // Just to show case:
            Debug.WriteLine("Number of layers loaded" + _context.Layers.Count());

            // adding all the available tools in the toolbox
            _context.Toolbox.AddTools(GetType().Assembly.GetTools());
        }

        #endregion
    }
}