using System;
using System.Collections.Generic;
using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using MW5.Plugins.Events;
using MW5.Plugins.Interfaces;
using MW5.Plugins.AttributeChecker.Views;
using MW5.UI.Docking;
using MW5.UI.Menu;
using MW5.Plugins.AttributeChecker.Views.Abstract;
using MW5.Shared.CheckResult;

namespace MW5.Plugins.AttributeChecker.Menu
{
    internal class MenuListener : MenuServiceBase
    {
        private readonly CheckResultPresenter _presenter;

        public MenuListener(IAppContext context, AttributeCheckerPlugin plugin, CheckResultPresenter presenter)
            : base(context, plugin.Identity)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (presenter == null) throw new ArgumentNullException("presenter");

            _presenter = presenter;

            //plugin.ItemClicked += PluginItemClicked;
            //plugin.ViewUpdating += ViewUpdating;
            plugin.MessageBroadcasted += OnPluginMessageBroadcasted;
        }

        private void OnPluginMessageBroadcasted(object sender, PluginMessageEventArgs e)
        {
            if (e.Message == PluginMessages.ShowAttributeCheckResult)
            {
                // TODO: Show attribute check result view
                var layer = _context.Legend.Layers.Current;

                var form = Views.CheckLayerAttributes.CheckLayerAttributes.GetInstance(layer);
                if (form.ShowDialog(_context.View.MainForm) == System.Windows.Forms.DialogResult.OK)
                {
                    MW5.Shared.AttributeChecker.Current.Init(_context, layer, form.Rules);

                    ShowPanel();
                    new System.Threading.Tasks.Task(() => MW5.Shared.AttributeChecker.Current.Run()).Start();
                    //ShowCheckAttrsResult(resList);
                }

            }
        }

        //private void ViewUpdating(object sender, EventArgs e)
        //{
        //    bool visible = _context.Map.SelectedFeatureSet != null;
        //    FindToolbarItem(MenuKeys.ShowTable).Enabled = visible;
        //    FindMenuItem(MenuKeys.ShowTable).Enabled = visible;
        //}

        //private void PluginItemClicked(object sender, MenuItemEventArgs e)
        //{
        //    switch (e.ItemKey)
        //    {
        //        case MenuKeys.ShowTable:
        //            ShowTableEditor();
        //            break;
        //    }
        //}

        //private void ShowTableEditor()
        //{
        //    var layer = _context.Legend.SelectedLayer;
        //    if (layer.IsVector)
        //    {
        //        _presenter.OpenTable(layer);
        //    }

        //    var panel = _context.DockPanels.Find(DockPanelKeys.TableEditor);
        //    if (panel != null && !panel.Visible)
        //    {
        //        panel.Visible = true;
        //    }
        //}

        private void ShowCheckAttrsResult(IList<ILayerCheckResult> resList)
        {
            var layer = _context.Legend.SelectedLayer;
            if (layer.IsVector)
            {
                //_presenter.OpenTable(layer);
                //_checkPresenter.View.ActiveGrid.RowCount = 0;
                //_presenter.View.ActiveGrid.DataSource = resList;
                //_checkPresenter.View.ActiveGrid.RowCount = resList.Count;
                (_presenter.View as CheckResultView).EntryAddRange(resList);
            }

            ShowPanel();
        }

        private void ShowPanel()
        {
            var panel = _context.DockPanels.Find(DockPanelKeys.CheckAttrsResult);
            if (panel != null && !panel.Visible)
            {
                panel.Visible = true;
            }
        }
    }
}
