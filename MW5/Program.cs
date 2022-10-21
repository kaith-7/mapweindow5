// -------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using emlic;
using MW5.DI.Castle;
using MW5.Helpers;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Services.Concrete;
using MW5.Shared;
using MW5.Views;
using Syncfusion.HighContrastTheme.WinForms;
using Syncfusion.Windows.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MW5
{
    internal static class Program
    {
        public static Stopwatch Timer = new Stopwatch();
        public static string ProjectFileName { get; private set; }

        private static IApplicationContainer CreateContainer()
        {
            // Switch the class here and change the using directive above to use another one
            // Also switch references.

            // LightInjectContainer
            // NinjectContainer
            // UnityApplicationContainer
            // return  new NinjectContainer();
            return new WindsorCastleContainer();
        }

        //private static void DumpFormats()
        //{
        //    var manager = new DriverManager();
        //    manager.DumpExtensions(true);

        //    manager.DumpExtensions(false);
        //}

        private static void LoadConfig(IApplicationContainer container)
        {
            Logger.Current.Trace("开始加载配置");
            MapInitializer.InitMapConfig();

            //Logger.Current.Trace("Before container.GetSingleton");
            var configService = container.GetSingleton<IConfigService>();
            //Logger.Current.Trace("After container.GetSingleton");

            configService.LoadAll();
            Logger.Current.Trace("配置加载完毕");
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            ExceptionHandler.Attach();

            SplashView.Instance.ShowStatus("应用启动.");

            //if (System.Diagnostics.Debugger.IsAttached)
            //{
            //    Application.Run(new WFPhoneTree.DevicesForm());
            //    return;
            //}

            var appPath = Application.StartupPath;
            // 环境变量设置已支持GDAL plugins
            // GDAL_DRIVER_PATH
            var gdal_driver_path = System.IO.Path.Combine(appPath, @"MapWinGIS\gdalplugins");
            if (System.Diagnostics.Debugger.IsAttached)
                gdal_driver_path = @"D:\Code\trunk\MapWinGIS\MapWinGIS-5.2.4\src\bin\Win32\gdalplugins";
            System.Environment.SetEnvironmentVariable("GDAL_DRIVER_PATH", gdal_driver_path);
            // PATH
            var env_path_add = System.IO.Path.Combine(appPath, @"MapWinGIS\gdalplugins");
            if (System.Diagnostics.Debugger.IsAttached)
                env_path_add = @"D:\Code\trunk\MapWinGIS\MapWinGIS-5.2.4\src\bin\Win32\gdalplugins";
            var env_path = System.Environment.GetEnvironmentVariable("PATH");
            System.Environment.SetEnvironmentVariable("PATH", env_path + ";" + env_path_add);

            // 启动时注册 MapWinGIS.ocx 控件
            var ocxPath = System.IO.Path.Combine(appPath, "MapWinGIS\\MapWinGIS.ocx");
            if (System.Diagnostics.Debugger.IsAttached) // 调试版
            {
                ocxPath = @"D:\Code\trunk\MapWinGIS\MapWinGIS-5.2.4\src\bin\Win32\MapWinGIS.ocx";
            }
            if (System.IO.File.Exists(ocxPath))
            {
                var proc = Process.Start("regsvr32", string.Format("/s {0}", ocxPath));
            }

            ProjectFileName = string.Empty;
            if (args.Length > 0) // 支持双击 *.mwproj 文件启动
            {
                ProjectFileName = args[0].ToString();
            }
            //正式版本检测license
            if(!Debugger.IsAttached )
            {
                if (!CheckLisence())
                {
                    return;
                }
            }
           

            var logger = new LoggingService();
            var service = new CheckAttributesService();

            logger.Info("应用启动");

            ShowSplashScreen();

            Timer.Start();

            var container = CreateContainer();
            CompositionRoot.Compose(container);

            SplashView.Instance.ShowStatus("配置加载中");
            LoadConfig(container);

            SplashView.Instance.ShowStatus("应用运行中");

            container.Run<MainPresenter>();
        }

        private static void ShowSplashScreen()
        {
            var splashScreen = SplashView.Instance;
            splashScreen.ShowStatus("开始构建");
            splashScreen.Show();
            Application.DoEvents();
        }

        private static bool CheckLisence()
        {
            while (true) // 检查授权
            {
                string options = string.Format("?serialNumber={0}" +
                    "&serialNumber2=" +
                    "&serialNumber3=" +
                    "&deviceId=" +
                    "&blueToothAddress=" +
                    "&deviceSerial=" +
                    "&androidID=" +
                    "&versionIdentity={1}", CheckPassIm.Diskserial, "suntoon.desktop");
                var req = System.Net.WebRequest.Create("http://www.linwutong.com/PermissionManager/PermissionAction_activate" + options);
                req.Method = "GET";

                System.Net.WebResponse response = null;
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        response = req.GetResponse();
                        break;
                    }
                    catch (Exception ex)
                    {
                        SplashView.Instance.ShowStatus("连接授权服务器失败," + ex.Message);
                    }
                }
                if (response != null)
                {
                    var stream = response.GetResponseStream();
                    var streamReader = new System.IO.StreamReader(stream);
                    var code = streamReader.ReadToEnd();
                    var decodeRes = AesCBC.decrypt(code);

                    var obj = Newtonsoft.Json.Linq.JObject.Parse(decodeRes.ToLower());
                    if (obj.TryGetValue("code", out Newtonsoft.Json.Linq.JToken value))
                    {
                        var val = value.ToString();
                        if (val == "100")
                        {
                            SplashView.Instance.ShowStatus("网路授权验证成功.");
                            break;
                        }
                    }
                }
                SplashView.Instance.ShowStatus("网路授权验证失败,检查本地授权.");

                var msg = CheckPassIm.getisok();
                if (msg != string.Empty)
                {
                    Clipboard.SetText(CheckPassIm.Diskserial);
                    var licenseView = new SetLicenseForm(CheckPassIm.Diskserial, msg);
                    licenseView.StartPosition = FormStartPosition.CenterScreen;
                    if (licenseView.ShowDialog() != DialogResult.OK)
                        return false;
                }
                else
                {
                    break;
                }
            }
            return true;
        }
    }
}