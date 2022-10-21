// -------------------------------------------------------------------------------------------
// <copyright file="AttributeCheckerPlugin.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Plugins.Concrete;
using MW5.Plugins.AttributeChecker.Menu;
using MW5.Plugins.AttributeChecker.Services;
using MW5.Plugins.AttributeChecker.Views;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mef;
using MW5.Plugins.Mvp;

namespace MW5.Plugins.AttributeChecker
{
    /// <summary>
    /// The attribute checker plugin.
    /// </summary>
    [MapWindowPlugin(loadOnStartUp: true)]
    public class AttributeCheckerPlugin : BasePlugin
    {
        private IAppContext _context;
        private DockPanelService _dockPanelService;
        private CheckResultPresenter _presenter;
        //private StatusBarListener _statusBarListener;
        private MenuListener _menuListener;

        /// <summary>
        /// The initialize method, called when the plug-in is loaded
        /// </summary>
        public override void Initialize(IAppContext context)
        {
            _context = context;

            _presenter = context.Container.GetInstance<CheckResultPresenter>();
            _dockPanelService = context.Container.GetInstance<DockPanelService>();
            //_statusBarListener = context.Container.GetInstance<StatusBarListener>();
            _menuListener = context.Container.GetInstance<MenuListener>();
        }

        /// <summary>
        /// Set up container for dependency injection:
        /// </summary>
        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }
    }
}