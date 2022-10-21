using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.AttributeChecker.Properties;
using MW5.Plugins.AttributeChecker.Views;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.UI.Docking;

namespace MW5.Plugins.AttributeChecker.Services
{
    public class DockPanelService
    {
        public const string DockPanelKey = DockPanelKeys.CheckAttrsResult;

        public DockPanelService(IAppContext context, AttributeCheckerPlugin plugin, CheckResultPresenter presenter)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");
            if (presenter == null) throw new ArgumentNullException("presenter");

            var panels = context.DockPanels;

            panels.Lock();

            try
            {
                var panel = panels.Add(presenter.GetInternalObject(), DockPanelKey, plugin.Identity);
                panel.Caption = "属性检查";
                panel.SetIcon(Resources.ico_bug24);
                panel.DockTo(DockPanelState.Bottom, 300);
                panel.Visible = false;
            }
            finally
            {
                panels.Unlock();
            }
        }
    }
}
