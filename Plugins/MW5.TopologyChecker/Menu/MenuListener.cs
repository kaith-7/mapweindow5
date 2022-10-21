using System;
using System.Collections.Generic;
using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using MW5.Plugins.Events;
using MW5.Plugins.Interfaces;
using MW5.Plugins.TopologyChecker.Views;
using MW5.UI.Docking;
using MW5.UI.Menu;
using MW5.Plugins.TopologyChecker.Views.Abstract;
using MW5.Shared;
using MW5.Shared.CheckResult;
using MW5.Plugins.Services;

namespace MW5.Plugins.TopologyChecker.Menu
{
    internal class MenuListener : MenuServiceBase
    {
        private readonly ILayerService _layerService;

        public MenuListener(IAppContext context, ILayerService layerService, TopologyCheckerPlugin plugin/*, CheckResultPresenter presenter*/)
            : base(context, plugin.Identity)
        {
            _layerService = layerService ?? throw new ArgumentNullException();

            plugin.ItemClicked += PluginItemClicked;
            plugin.MessageBroadcasted += OnPluginMessageBroadcasted;
        }

        private void OnPluginMessageBroadcasted(object sender, PluginMessageEventArgs e)
        {
            if (e.Message == PluginMessages.ShowTopologyCheckResult)
            {
                // TODO: Show attribute check result view
                var layers = _context.Map.Layers;

                var form = Views.CheckLayerAttributes.TopologyRulesView.GetInstance(_context, layers);
                if (form.ShowDialog(_context.View.MainForm) == System.Windows.Forms.DialogResult.OK)
                {
                    //MW5.Shared.TopologyChecker.Current.Init(_context, layer, form.Rules);

                    ShowPanel();
                    //new System.Threading.Tasks.Task(() => MW5.Shared.TopologyChecker.Current.Run()).Start();
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

        private void PluginItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.ShowTopologyRulesWindow:
                    CheckTopology();
                    break;
            }
        }

        private void CheckTopology()
        {
            if (Services.TopologyCheckService.GetInstance().Busy)
            {
                System.Windows.Forms.MessageBox.Show("正在进行拓扑检查...", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            var layers = _context.Map.Layers;
            var layerNames = new List<string>();
            foreach (var lyr in layers)
            {
                if (!layerNames.Contains(lyr.Name))
                    layerNames.Add(lyr.Name);
                else
                {
                    System.Windows.Forms.MessageBox.Show($"重复的图层名:{lyr.Name}");
                    return;
                }
                if (!lyr.Projection.IsSame(_context.Map.Projection))
                {
                    System.Windows.Forms.MessageBox.Show($@"图层投影不一致:
图层投影({lyr.Name}:{lyr.Projection.Name})
地图投影({_context.Map.Projection})");
                    return;
                }
            }
            var form = Views.CheckLayerAttributes.TopologyRulesView.GetInstance(_context, layers);
            if (form.ShowDialog(_context.View.MainForm) == System.Windows.Forms.DialogResult.OK)
            {
                var rules = form.Rules;
                foreach (var r in rules)
                {
                    Console.WriteLine($"{r.Layer}, {r.Rule.EnumToString()}, {r.BaseLayer}");
                }
                //new System.Threading.Tasks
                //    .Task(() => Services.TopologyCheckService.GetInstance().Run(_context, _layerService, rules))
                //    .Start();

                var thread = new System.Threading.Thread(() => Services.TopologyCheckService.GetInstance().Run(_context, _layerService, rules));
                thread.Start();

                ShowPanel();
            }
            return;
        }

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
                //(_presenter.View as CheckResultView).EntryAddRange(resList);
            }

            ShowPanel();
        }

        private void ShowPanel()
        {
            var panel = _context.DockPanels.Find(DockPanelKeys.TopologyCheckResult);
            if (panel != null && !panel.Visible)
            {
                panel.Visible = true;
            }
        }
    }
}
