// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapListener.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015 - 2019
// </copyright>
// <summary>
//   The map listener.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MW5.Plugins.PictureView
{
    #region

    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using MW5.Api.Enums;
    using MW5.Api.Events;
    using MW5.Api.Interfaces;
    using MW5.Api.Legend.Abstract;
    using MW5.Api.Legend.Events;
    using MW5.Plugins.Interfaces;
    using MW5.Plugins.PictureView.Views;
    using MW5.Views;

    #endregion

    /// <summary>
    /// The map listener.
    /// </summary>
    public class MapListener
    {
        #region Fields

        /// <summary>
        /// The context of the application, holding the menu, layers, project, etc.
        /// </summary>
        private readonly IAppContext _context;

        private LookPicture lookform;

        /// <summary>
        /// The _sample dock window.
        /// </summary>
        //private readonly SampleDockWindow _sampleDockWindow;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapListener" /> class.
        /// </summary>
        /// <param name="context">The application context.</param>
        /// <param name="plugin">The plugin.</param>
        /// <param name="sampleDockWindow">Reference to the sample dock window</param>
        public MapListener(IAppContext context, PictureView plugin) //, SampleDockWindow sampleDockWindow)
        {
            // Check input:
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");
            //if (sampleDockWindow == null) throw new ArgumentNullException("sampleDockWindow");

            // Save local references:
            _context = context;
            //_sampleDockWindow = sampleDockWindow;

            // As show case:
            //Debug.WriteLine("加载图层数量; " + _context.Layers.Count);

            // Create event handlers:
            //plugin.ExtentsChanged += PluginOnExtentsChanged;
            //plugin.ChooseLayer += PluginOnChooseLayer;
            plugin.ShapeIdentified += PluginOnChooseFeature;
            //plugin.LayerSelected += PluginOnLayerSelected;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The plugin on choose layer.
        /// </summary>
        /// <param name="map">The map.</param>
        /// <param name="e">The ChooseLayer EventArgs.</param>
        //private void PluginOnChooseLayer(IMuteMap map, ChooseLayerEventArgs e)
        //{
        //    if (e.LayerHandle == -1)
        //    {
        //        return;
        //    }

        //    _sampleDockWindow.Write(
        //        "MapListener.PluginOnChooseLayer", 
        //        "已选择图层: " + Path.GetFileName(_context.Layers.ItemByHandle(e.LayerHandle).Filename));
        //}

        /// <summary>
        /// The extents changed event handler
        /// </summary>
        /// <param name="map">The map.</param>
        /// <param name="e">The event arguments</param>
        //private void PluginOnExtentsChanged(IMuteMap map, EventArgs e)
        //{
        //    _sampleDockWindow.Write("MapListener.PluginOnExtentsChanged", map.Extents.ToString());
        //}

        /// <summary>
        /// The layer selected event handler
        /// </summary>
        /// <param name="legend">The legend.</param>
        /// <param name="e">The layer event arguments</param>
        //private void PluginOnLayerSelected(IMuteLegend legend, LayerEventArgs e)
        //{
        //    if (e.LayerHandle == -1)
        //    {
        //        return;
        //    }

        //    var filename = _context.Layers.ItemByHandle(e.LayerHandle).Filename;
        //    if (File.Exists(filename))
        //    {
        //        filename = Path.GetFileName(filename);
        //    }

        //    _sampleDockWindow.Write("MapListener.PluginOnLayerSelected", "已选择图层: " + filename);
        //}

        //小班索引index
        private void PluginOnChooseFeature(IMuteMap map, ShapeIdentifiedEventArgs e)
        {
            if (_context.Map.MapCursor != MapCursor.ShowPolygonPicture)
                return;
            //读取临时文件
            string CurrentlogPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + "fields_pic.log";
            var sourceName = _context.Legend.SelectedLayer.Filename;
            if (string.IsNullOrEmpty(sourceName))
                sourceName = _context.Legend.SelectedLayer.FeatureSet?.UnProjectedFilename;
            if (Path.GetExtension(sourceName).ToLower() != ".shp")
                return;
            var layerName = _context.Legend.SelectedLayer.Name;
            string configFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(sourceName), "picture_info.xml");
            if (System.IO.File.Exists(configFile))
            {
                var xml = new System.Xml.XmlDocument();
                xml.Load(configFile);
                var elem = xml.GetElementsByTagName("PictureInfo");
                var node = (System.Xml.XmlElement)elem[0];
                var filePath = node.GetAttribute("FilePath");
                var picturePath = node.GetAttribute("PicturePath");

                //var lyrName = ((System.Xml.XmlElement)node.FirstChild).GetAttribute("LayerName");
                System.Xml.XmlElement nodeLayer = (System.Xml.XmlElement)((System.Xml.XmlElement)node.FirstChild).FirstChild;
                var keyField = nodeLayer.GetAttribute("KeyField");
                //var keyField = "pk_uid";
                if (filePath.Length > 0 && picturePath.Length > 0)
                {
                    var fs = _context.Legend.SelectedLayer.FeatureSet;
                    var fieldIndex = fs.Table.Fields.IndexByName(keyField);
                    
                    var shape = _context.Map.IdentifiedShapes.Where(item => item.LayerHandle == _context.Legend.SelectedLayerHandle).FirstOrDefault();
                    if (shape != null)
                    {
                        var fieldValue = fs.Table.CellValue(fieldIndex, shape.ShapeIndex);
                        string picturePathShape = picturePath; // System.IO.Path.Combine(picturePath, layerName);
                        picturePathShape = System.IO.Path.Combine(picturePathShape, fieldValue.ToString());
                        //if (System.IO.Directory.Exists(picturePathShape))
                        {
                            if (lookform == null)
                            {
                                lookform = new LookPicture(picturePathShape);
                                lookform.TopMost = true;
                            }
                            //var view = _context.Container.GetInstance<MainView>();
                            //lookform.Show(view);
                            lookform.SetPicturePath(picturePathShape);
                            lookform.Show();
                        }
                    }
                    else if (lookform != null)
                    {
                        lookform.Hide();
                    }

                }
            }
        }


        #endregion
    }
}