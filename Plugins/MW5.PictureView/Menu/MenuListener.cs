// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuListener.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015-2019
// </copyright>
// <summary>
//   The menu listener.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MW5.Plugins.Interfaces;
using MW5.Plugins.PictureView.Properties;
using MW5.Plugins.PictureView.Views;
using MW5.Plugins.Enums;
using MW5.Plugins.Events;
using MW5.Api.Enums;
using MW5.UI.Menu;
using System.IO;

namespace MW5.Plugins.PictureView.Menu
{

    /// <summary>
    ///     The menu listener.
    /// </summary>
    public class MenuListener : MenuServiceBase
    {
        #region Constants

        /// <summary>
        ///     The key to identify the dock panel
        /// </summary>
        /// <remarks>Change it to fit your plug-in</remarks>
        //private const string DOCKPANELKEY = "PictureViewDockPanel";

        #endregion

        #region Fields

        /// <summary>
        ///     The application context.
        /// </summary>
        private readonly IAppContext _context;

        /// <summary>
        ///     A user control as a sample for a dockable window.
        /// </summary>
        //private readonly SampleDockWindow _sampleDockWindow;

        /// <summary>
        /// The _plugin.
        /// </summary>
        private readonly PictureView _plugin;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuListener" /> class.
        /// </summary>
        /// <param name="context">The application context.</param>
        /// <param name="plugin">The plugin.</param>
        /// <param name="sampleDockWindow">The sample dock wi</param>
        public MenuListener(IAppContext context, PictureView plugin)
            : base(context, plugin.Identity) //, SampleDockWindow sampleDockWindow)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            //if (sampleDockWindow == null)
            //{
            //    throw new ArgumentNullException("sampleDockWindow");
            //}

            // Save to local properties:
            _context = context;
            //_sampleDockWindow = sampleDockWindow;
            _plugin = plugin;

            // Create event handlers:
            plugin.ItemClicked += Plugin_ItemClicked;
            plugin.ViewUpdating += Plugin_ViewUpdating;
        }

        private void Plugin_ViewUpdating(object sender, EventArgs e)
        {
            var item = FindToolbarItem(MenuKeys.PictureViewer);
            if (item != null)
            {
                item.Checked = _context.Map.MapCursor == MapCursor.ShowPolygonPicture;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add a dockable window to the panels
        /// </summary>
        //private void AddDockWindowToPanels()
        //{
        //    var panels = _context.DockPanels;

        //    // Check if the panel not already exists:
        //    var myPanel = panels.Find(DOCKPANELKEY);
        //    if (myPanel != null)
        //    {
        //        myPanel.Visible = true;
        //        return;
        //    }

        //    // Panel is not yet loaded:
        //    panels.Lock();
        //    var panel = panels.Add(_sampleDockWindow, DOCKPANELKEY, _plugin.Identity);
        //    panel.Caption = "模板窗口";
        //    panel.SetIcon(Resources.ico_template);

        //    // TODO: Read configuration setting to show the window like the last time:
        //    var preview = panels.Preview;
        //    if (preview != null && preview.Visible)
        //    {
        //        panel.DockTo(preview, DockPanelState.Tabbed, 150);
        //    }

        //    panels.Unlock();

        //    _sampleDockWindow.Write("AddDockWindowToPanels", "Add to panel");
        //}

        /// <summary>
        /// The toolbar button clicked event handler
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The menu item event arguments</param>
        private void Plugin_ItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.PictureViewSetting:
                case MenuKeys.PictureViewer:
                    // Clicked on the toolbar button
                    //MessageService.Current.Info("欢迎打开模板插件。");
                    //_context.Container.Run<PolygonPicturePresenter>();
                    if (_context.Legend.SelectedLayer != null)
                    {
                        var sourceName = _context.Legend.SelectedLayer.Filename;
                        var layerName = _context.Legend.SelectedLayer.Name;
                        if (string.IsNullOrEmpty(sourceName))
                            sourceName = _context.Legend.SelectedLayer.FeatureSet?.UnProjectedFilename;
                        if (Path.GetExtension(sourceName).ToLower() != ".shp")
                            return;
                        if (!string.IsNullOrEmpty(sourceName) && !string.IsNullOrEmpty(layerName))
                        {
                            string configFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(sourceName), "picture_info.xml");
                            string picturePath = string.Empty;
                            string KeyField = string.Empty;
                            if (System.IO.File.Exists(configFile))
                            {
                                var xml = new System.Xml.XmlDocument();
                                xml.Load(configFile);
                                var elem = xml.GetElementsByTagName("PictureInfo");
                                var node = (System.Xml.XmlElement)elem[0];
                                var filePath = node.GetAttribute("FilePath");
                                picturePath = node.GetAttribute("PicturePath");
                                if (node.FirstChild?.Name.ToUpper() == "LAYERS")
                                {
                                    foreach (System.Xml.XmlNode lyrNode in node.FirstChild.ChildNodes)
                                    {
                                        if (lyrNode.Attributes["LayerName"].Value == layerName)
                                        {
                                            KeyField = lyrNode.Attributes["KeyField"].Value;
                                            break;
                                        }
                                    }
                                }
                                if (e.ItemKey == MenuKeys.PictureViewer
                                    && filePath.Length > 0 && picturePath.Length > 0
                                    && System.IO.Directory.Exists(picturePath) && System.IO.File.Exists(filePath))
                                {
                                    _context.Map.MapCursor = MapCursor.ShowPolygonPicture;
                                    return;
                                }
                            }
                            
                            PolygonPictureView picpathform = new PolygonPictureView(sourceName, _context.Legend.Layers, layerName, picturePath, KeyField);
                            if (picpathform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                _context.Map.MapCursor = MapCursor.ShowPolygonPicture;
                            }
                            //AddDockWindowToPanels();

                        }
                    }
                    break;
            }
        }

        #endregion
    }
}