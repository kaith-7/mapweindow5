﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MW5.Api.Legend;
using MW5.Plugins;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Helpers;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Properties;
using MW5.Services.Helpers;
using MW5.Services.Serialization;
using MW5.Shared;
using MW5.Tools.Views;
using MW5.UI.Docking;
using MW5.UI.Helpers;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Helpers
{
    internal static class DockPanelHelper
    {
        private const int PanelSize = 300;

        public static void InitDocking(this ISecureContext context)
        {
            var panels = context.DockPanels;
            panels.Lock();

            InitLegend(context);

            InitLocator(context);

            InitToolbox(context);

            InitTasks(context);
            
            context.DockPanels.Legend.TabPosition = 0;
        }

        private static void InitTasks(ISecureContext context)
        {
            var presenter = context.Container.Resolve<TasksPresenter>();
            var tasks = context.DockPanels.Add(presenter.View, DockPanelKeys.Tasks, PluginIdentity.Default);
            tasks.Caption = "任务";
            var toolbox = context.DockPanels.Toolbox;
            tasks.DockTo(toolbox, DockPanelState.Tabbed, PanelSize);
            tasks.SetIcon(Resources.ico_tasks);
            tasks.TabPosition = toolbox.TabPosition;
        }

        private static void InitLegend(ISecureContext context)
        {
            var legendControl = context.GetDockPanelObject(DefaultDockPanel.Legend);
            var legend = context.DockPanels.Add(legendControl, DockPanelKeys.Legend, PluginIdentity.Default);
            legend.Caption = "内容列表";
            legend.DockTo(null, DockPanelState.Left, PanelSize);
            legend.SetIcon(Resources.ico_legend);
        }

        private static void InitToolbox(ISecureContext context)
        {
            var toolboxControl = context.GetDockPanelObject(DefaultDockPanel.Toolbox);

            var toolbox = context.DockPanels.Add(toolboxControl, DockPanelKeys.Toolbox, PluginIdentity.Default);
            toolbox.Caption = "工具箱";
            toolbox.DockTo(null, DockPanelState.Right, PanelSize);
            toolbox.SetIcon(Resources.工具箱);
        }

        private static void InitLocator(ISecureContext context)
        {
            var locatorControl = context.GetDockPanelObject(DefaultDockPanel.Locator);
            if (locatorControl == null)
            {
                return;
            }

            var locator = context.DockPanels.Add(locatorControl, DockPanelKeys.Preview, PluginIdentity.Default);
            locator.Caption = "缩略图";
            locator.SetIcon(Resources.缩略图);
            locator.DockTo(context.DockPanels.Legend, DockPanelState.Bottom, PanelSize);

            var size = locator.Size;
            locator.Size = new Size(size.Width, 250);
        }

        public static void ClosePanel(IAppContext context, string dockPanelKey)
        {
            var panel = context.DockPanels.Find(dockPanelKey);
            if (panel != null)
            {
                panel.Visible = false;
            }
        }

        public static void ShowPanel(IAppContext context, string dockPanelKey)
        {
            var panel = context.DockPanels.Find(dockPanelKey);
            if (panel != null)
            {
                panel.Visible = true;
                panel.Activate();
                panel.Focus();
            }
        }

        public static void SerializeDockState(IAppContext context)
        {
            var panels = context.DockPanels;
            panels.Lock();

            foreach (var panel in panels)
            {
                Debug.Print(panel.Caption);
                Debug.Print("Hidden: " + panel.AutoHidden);
                Debug.Print("Visible: " + panel.Visible);
                Debug.Print("Style: " + panel.DockState);

                //bool hidden = panel.AutoHidden;
                //if (hidden)
                //{
                //    panel.AutoHidden = false;
                //}

                //bool visible = panel.Visible;
                //if (!visible)
                //{
                //    panel.Visible = true;
                //}

                var host = panel.Control.Parent as DockHost;
                if (host != null)
                {


                    var dhc = host.InternalController as DockHostController;
                    if (dhc != null)
                    {
                        DockInfo di = dhc.GetSerCurrentDI();
                        if (di != null)
                        {

                            Rectangle r;

                            if (dhc.bInAutoHide)
                            {
                                r = dhc.DINew.rcDockArea;
                            }
                            else
                            {
                                r = dhc.LayoutRect;
                            }

                            Debug.Print("Child host count: " + dhc.ChildHostCount);

                            Debug.Print("Controller name: " + di.ControlleName);
                            Debug.Print("Style: " + di.dStyle);
                            Debug.Print("x: {0}; y: {1}; w: {2}; h: {3}", r.X, r.Y, r.Width, r.Height);
                            //Debug.Print("x: {0}; y: {1}; w: {2}; h: {3}", r2.X, r2.Y, r2.Width, r2.Height);
                            Debug.Print("Priority: " + di.nPriority);
                            Debug.Print("DockIndex: " + di.nDockIndex);
                        }
                    }
                }

                //if (!visible)
                //{
                //    panel.Visible = false;
                //}

                //if (hidden)
                //{
                //    panel.AutoHidden = true;
                //}

                Debug.Print("--------------");
            }

            panels.Unlock();
        }
    }
}
