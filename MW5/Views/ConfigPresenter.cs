﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MW5.Api.Interfaces;
using MW5.Configuration;
using MW5.Helpers;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Helpers;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Services.Helpers;
using MW5.Shared;
using MW5.UI.Helpers;
using MW5.UI.Style;
using MW5.Views.Abstract;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace MW5.Views
{
    internal class ConfigPresenter: ComplexPresenter<IConfigView, ConfigCommand, ConfigViewModel>
    {
        private readonly IAppContext _context;
        private readonly IConfigService _configService;
        private readonly IStyleService _styleService;
        private readonly IPluginManager _pluginManger;
        private readonly IMuteMap _map;

        public ConfigPresenter( IAppContext context, IConfigView view, IConfigService configService, 
        IStyleService styleService, IPluginManager pluginManger, IMuteMap map)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (view == null) throw new ArgumentNullException("view");
            if (configService == null) throw new ArgumentNullException("configService");
            if (styleService == null) throw new ArgumentNullException("styleService");
            if (pluginManger == null) throw new ArgumentNullException("pluginManger");
            if (map == null) throw new ArgumentNullException("map");

            _context = context;
            _configService = configService;
            _styleService = styleService;
            _pluginManger = pluginManger;
            _map = map;

            view.PageShown += OnPageShown;
        }

        public override void RunCommand(ConfigCommand command)
        {
            switch (command)
            {
                case ConfigCommand.RestoreToolbars:
                    if (MessageService.Current.Ask("是否要恢复工具栏的默认位置？"))
                    {
                        var view = _context.Container.Resolve<IMainView>();
                        var manager = view.MenuManager as MainFrameBarManager;
                        if (manager != null)
                        {
                            manager.RestoreLayout(MainView.SerializationKey, true);
                        }
                    }
                    break;
                case ConfigCommand.RestorePlugins:
                    RestorePlugins();
                    break;
                case ConfigCommand.Save:
                    ApplySettings();

                    bool result = _configService.SaveConfig();
                    if (result)
                    {
                        MessageService.Current.Info("配置已成功保存。");
                    }
                    break;
                case ConfigCommand.SetDefaults:
                    if (MessageService.Current.Ask("是否要重置所有设置的默认值？"))
                    {
                        _configService.Config.SetDefaults();
                        foreach (var page in Model.Pages)
                        {
                            page.Initialize();
                        }
                    }

                    ApplySettings();

                    break;
                case ConfigCommand.OpenFolder:
                    string path = _configService.ConfigPath;
                    PathHelper.OpenFolderWithExplorer(path);
                    break;
            }
        }

        private void RestorePlugins()
        {
            if (!MessageService.Current.Ask("是否要恢复插件及其布局的默认位置？"))
            {
                return;
            }

            try
            {
                var guids = AppConfig.Instance.DefaultApplicationPlugins;
                _pluginManger.RestoreApplicationPlugins(guids, _context);
                Model.ReloadPage(ConfigPageType.Plugins);

                // restoring layout
                var view = _context.Container.Resolve<IMainView>();
                var manager = view.DockingManager as DockingManager;
                manager.RestoreLayout(MainView.SerializationKey, true);
            }
            catch (Exception ex)
            {
                Logger.Current.Error("无法还原扩展窗口的布局。", ex);
            }
        }

        private void OnPageShown()
        {
            _styleService.ApplyStyle(View as Form);
        }

        private void ApplySettings()
        {
            foreach (var page in Model.Pages)
            {
                page.Save();
            }

            _map.ApplyConfig(_configService);
        }

        public override bool ViewOkClicked()
        {
            ApplySettings();
            _configService.SaveAll();
            return true;
        }
    }
}
