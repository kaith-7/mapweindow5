using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MW5.Api;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Api.Legend;
using MW5.Api.Legend.Events;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Services.Serialization;
using MW5.Services.Views;
using MW5.Shared;
using MW5.UI.Helpers;
using LayerCancelEventArgs = MW5.Plugins.Events.LayerCancelEventArgs;

namespace MW5.Plugins.ShapeEditor.Services
{
    public class LayerEditingService: ILayerEditingService
    {
        private readonly IAppContext _context;
        private readonly ILayerService _layerService;
        private readonly IFileDialogService _dialogService;
        private readonly IBroadcasterService _broadcaster;

        public LayerEditingService(IAppContext context, ILayerService layerService, IFileDialogService dialogService,
                                   IBroadcasterService _broadcaster)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (layerService == null) throw new ArgumentNullException("layerService");
            if (dialogService == null) throw new ArgumentNullException("dialogService");
            if (_broadcaster == null) throw new ArgumentNullException("_broadcaster");

            _context = context;
            _layerService = layerService;
            _dialogService = dialogService;
            this._broadcaster = _broadcaster;
        }

        /// <summary>
        /// Toggles interactive editing state for vector layer.
        /// </summary>
        public void ToggleVectorLayerEditing()
        {
            // perhaps better to allow setting state explicitly as parameter
            int handle = _context.Legend.SelectedLayerHandle;
            var fs = _context.Layers.GetFeatureSet(handle);
            var ogrLayer = _context.Layers.GetVectorLayer(handle);

            var args = new LayerCancelEventArgs(handle);
            _broadcaster.BroadcastEvent(p => p.BeforeLayerEditingChanged_, _context.Legend, args);
            if (args.Cancel)
                return;

            if (fs == null)
            {
                return;
            }

            var lyr = _context.Layers.Current.Filename;
            if (lyr == "")
            {
                lyr = _context.Layers.Current.Identity.Connection;
            }
            System.IO.FileInfo shpInfo = null;
            System.IO.FileInfo shxInfo = null;
            if (!string.IsNullOrEmpty(lyr))
            {
                shpInfo = new System.IO.FileInfo(lyr);
                shxInfo = new System.IO.FileInfo(System.IO.Path.ChangeExtension(lyr, "shx"));
            }

            var identity = _context.Layers.Current.Identity;
            //identity.Connection;
            
            if (fs.InteractiveEditing)
            {
                if (!SaveLayerChanges(handle))
                {
                    return;
                }
            }
            else
            {
                if (ogrLayer != null)
                {
                    /*if (ogrLayer.DynamicLoading)
                    {
                        MessageService.Current.Info("Editing of dynamically loaded OGR layers isn't allowed.");
                        return;
                    }*/
                    if (!ogrLayer.get_SupportsEditing(SaveType.SaveAll))
                    {
                        MessageService.Current.Info("OGR layer doesn't support editing: " + ogrLayer.LastError);
                        return;
                    }
                }

                if (identity.IdentityType == LayerIdentityType.File && ((shpInfo != null && shpInfo.IsReadOnly) || (shxInfo != null && shxInfo.IsReadOnly)))
                    MessageService.Current.Info("图层不支持编辑,文件只读."); // "Layer doesn't support editing, file read only."
                else
                    fs.InteractiveEditing = true;
            }
            if (identity.IdentityType == LayerIdentityType.OgrDatasource && !(shpInfo.IsReadOnly || shxInfo.IsReadOnly))
            {
                _broadcaster.BroadcastEvent(p => p.LayerEditingChanged_, _context.Legend, new LayerEventArgs(handle));
                _context.Legend.Redraw(LegendRedraw.LegendAndMap);
            }
        }

        /// <summary>
        /// Saves changes for the layer with specified handle.
        /// </summary>
        public bool SaveLayerChanges(int layerHandle)
            => ProcessDiscardOrSave(layerHandle, SaveLayerChangesCore);

        /// <summary>
        /// Discard changes for the layer with the specfied handle
        /// </summary>
        public bool DiscardLayerChanges(int layerHandle)
            => ProcessDiscardOrSave(layerHandle, DiscardChangesCore);

        private bool ProcessDiscardOrSave(int layerHandle, Func<int, bool> action)
        {
            if (!_context.Map.GeometryEditor.SaveChanges())
            {
                return false;
            }

            bool success = action(layerHandle);

            if (success)
            {
                // clear the current editing tool if there are no more layers in edit mode
                if (!_context.Layers.Any(l => l.IsVector && l.FeatureSet.InteractiveEditing))
                {
                    _context.Map.MapCursor = MapCursor.ZoomIn;
                }
            }

            _broadcaster.BroadcastEvent(p => p.LayerEditingChanged_, _context.Legend, new LayerEventArgs(layerHandle));
            return success;
        }


        private bool SaveLayerChangesCore(int layerHandle)
        {
            string layerName = _context.Layers.ItemByHandle(layerHandle).Name;

            string prompt = string.Format("保存此图层的修改: {0}?", layerName);
            var result = MessageService.Current.AskWithCancel(prompt);

            switch (result)
            {
                case DialogResult.Yes:
                    SaveChangesCore(layerHandle);
                    break;
                case DialogResult.No:
                    DiscardChangesCore(layerHandle);
                    break;
                default:
                    return false;
            }

            _broadcaster.BroadcastEvent(p => p.LayerEditingChanged_, _context.Legend, new LayerEventArgs(layerHandle));
            return true;
        }

        /// <summary>
        /// Saves changes for shapefile or OGR layer.
        /// </summary>
        private bool SaveChangesCore(int layerHandle)
        {
            var layer = _context.Layers.ItemByHandle(layerHandle);
            var ogrLayer = layer.VectorSource;

            bool success = ogrLayer != null ? SaveOgrLayer(ogrLayer) : SaveFeatureSet(layer);

            if (success)
            {
                CloseEditing(layerHandle);
            }

            return success;
        }

        private bool SaveFeatureSet(ILayer layer)
        {
            var fs = layer.FeatureSet;

            if (fs.SourceType == FeatureSourceType.InMemory)
            {
                if (!string.IsNullOrEmpty(fs.UnProjectedFilename))
                {
                    var savefile = fs.UnProjectedFilename;

                    var srcFS = new FeatureSet(savefile);

                    if (!fs.StopEditingShapes())
                        return false;

                    srcFS.StartEditingShapes();
                    // Clear All // 这里全部清理了，所以不需要删除操作
                    srcFS.Features.EditClear(); 
                    for (int i = srcFS.Table.NumRows - 1; i >= 0; i--)
                    {
                        srcFS.Table.EditDeleteRow(i);
                    }

                    // 重投影并添加到原始文件
                    int reprojectedCount = 0;
                    var projFS = fs.Reproject(srcFS.Projection, null, out reprojectedCount);

                    // 重新添加字段，按字段个数判断不准确
                    // TODO: 记录字段是否被修改，并判断是否需要重新添加字段
                    //if (srcFS.Table.Fields.Count != projFS.Fields.Count)
                    {
                        srcFS.Table.Fields.Clear();
                        for (int i = 0; i < projFS.Fields.Count; i++)
                        {
                            srcFS.Table.Fields.Add(projFS.Fields[i]);
                        }
                    }
                    foreach (var feat in projFS.Features)
                    {
                        //var idOrg = fs.UnProjectedID(feat.Index);
                        //var isModify = feat.Modified;
                        //var isDeleted = fs.Deleted(feat.Index);

                        int idx = srcFS.Features.EditAdd(feat.Geometry);
                        // Table
                        for (int i = 0; i < feat.NumFields; i++)
                        {
                            var val = feat.GetValue(i);
                            srcFS.Table.EditCellValue(i, idx, val);
                        }
                    }
                    var ok = srcFS.StopEditingShapes();

                    var saveFS1 = new FeatureSet(savefile);

                    return ok;
                }
                string filename = layer.Name;
                if (_dialogService.SaveFile(FeatureSet.OpenDialogFilter, ref filename))
                {
                    return fs.SaveAsEx(filename, true);
                }

                return false;
            }

            return fs.StopEditingShapes();
        }

        private bool SaveOgrLayer(VectorLayer ogrLayer)
        {
            int savedCount;
            SaveResult saveResult = ogrLayer.SaveChanges(out savedCount);
            bool success = saveResult == SaveResult.AllSaved || saveResult == SaveResult.NoChanges;

            if (!success)
            {
                // TODO: display them in a dialog when the command was called from toolbar for a single layer
                Logger.Current.Warn("Failed to save OGR layer changes: " + ogrLayer.Filename);
                DisplayOgrErrors(ogrLayer);
            }
            else
            {
                string msg = string.Format("{0}: {1}; features: {2}", saveResult.EnumToString(), ogrLayer.Name, savedCount);
                MessageService.Current.Info(msg);

                // reload from datasource to be sure that there is no stale data
                ogrLayer.ReloadFromSource(true);
            }

            return success;
        }

        /// <summary>
        /// Discards changes for the layer.
        /// </summary>
        private bool DiscardChangesCore(int layerHandle)
        {
            var fs = _context.Layers.GetFeatureSet(layerHandle);
            if (fs == null)
            {
                throw new ApplicationException("Invalid layer handle on trying to close editing mode.");
            }

            string xmlState = fs.Serialize();

            var ogrLayer = _context.Layers.GetVectorLayer(layerHandle);
            
            if (ogrLayer != null)
            {
                ogrLayer.ReloadFromSource(true);
                fs = ogrLayer.Data;
            }
            else
            {
                fs.StopEditingShapes(false, true);
            }

            if (fs != null)
            {
                fs.Deserialize(xmlState);
            }

            CloseEditing(layerHandle);

            return true;
        }

        /// <summary>
        /// Closes editing session for layer (changes should be saved or discarded prior to this call).
        /// </summary>
        private void CloseEditing(int layerHandle)
        {
            var sf = _context.Layers.GetFeatureSet(layerHandle);
            sf.InteractiveEditing = false;
            _context.Map.GeometryEditor.Clear();
            _context.Map.History.ClearForLayer(layerHandle);
            _context.Map.Redraw();
        }

        private void DisplayOgrErrors(IVectorLayer layer)
        {
            var logger = Logger.Current;
            for (int i = 0; i < layer.UpdateSourceErrorCount; i++)
            {
                logger.Warn("Failed to save feature {0}: {1}", null, layer.get_UpdateSourceErrorGeometryIndex(i),
                    layer.get_UpdateSourceErrorMsg(i));
            }
        }

        public void CreateLayer()
        {
            var model = new CreateLayerModel
            {
                SR = _context.Map.Projection
            };

            if (_context.Container.Run<CreateLayerPresenter, CreateLayerModel>(model))
            {
                var fs = new FeatureSet(model.GeometryType, model.ZValueType);
                //fs.Projection.CopyFrom(_context.Map.Projection);
                fs.Projection.CopyFrom(model.SR);
                InitialFields(fs, model.DataDictionaryName);

                if (!model.MemoryLayer)
                {
                    fs.SaveAsEx(model.Filename, false);
                }

                fs.InteractiveEditing = true;

                _layerService.AddDatasource(fs, model.LayerName);
            }
        }

        private static void InitialFields(FeatureSet fs, string xmlName)
        {
            XmlDocument doc = new XmlDocument();
            var s = new StreamReader(xmlName, Encoding.GetEncoding("GB2312"));
            s.ReadLine();
            s.ReadLine();
            var data = s.ReadToEnd();
            doc.LoadXml(data);

            var list = doc.GetElementsByTagName("EMTabsDefine");
            var node = (XmlElement)list[0];
            if (node.FirstChild?.Name == "EMTable")
            {
                foreach (var attr in node.FirstChild.Attributes)
                {

                }

                if (node.FirstChild.ChildNodes != null)
                {
                    foreach (XmlNode item in node.FirstChild.ChildNodes)
                    {
                        if (item.NodeType == XmlNodeType.Element && item.Name == "EMField")
                        {
                            var field = new AttributeField();
                            foreach (XmlAttribute attr in item?.Attributes)
                            {
                                switch (attr.Name)
                                {
                                    case "Name":
                                        field.Name = attr.Value;
                                        break;
                                    case "AliasName":
                                        field.Alias = attr.Value;
                                        break;
                                    case "IsShow":
                                        field.Visible = bool.TryParse(attr.Value, out bool isshow) ? isshow : true;
                                        break;
                                    case "Type":
                                        switch (attr.Value)
                                        {
                                            default:
                                            case "字符":
                                                field.Type = AttributeType.String;
                                                break;
                                            case "整数":
                                                field.Type = AttributeType.Integer;
                                                break;
                                            case "浮点":
                                                field.Type = AttributeType.Double;
                                                break;
                                        }
                                        break;
                                    case "Length":
                                        field.Width = int.TryParse(attr.Value, out int length) ? length : 32;
                                        break;
                                    case "Decimal":
                                        field.Precision = int.TryParse(attr.Value, out int precision) ? precision : 4;
                                        break;
                                }
                            }
                            fs.Fields.Add(field);
                        }
                    }
                }
            }
        }

        public void ToggleSnapToActiveLayer()
        {
            if (_context.Map.GeometryEditor.SnapBehavior == LayerSelectionMode.ActiveLayer)
                _context.Map.GeometryEditor.SnapBehavior = LayerSelectionMode.NoLayer;
            else
                _context.Map.GeometryEditor.SnapBehavior = LayerSelectionMode.ActiveLayer;
        }

        public void ToggleSnapToAllLayers()
        {
            if (_context.Map.GeometryEditor.SnapBehavior == LayerSelectionMode.AllLayers)
                _context.Map.GeometryEditor.SnapBehavior = LayerSelectionMode.NoLayer;
            else
                _context.Map.GeometryEditor.SnapBehavior = LayerSelectionMode.AllLayers;
        }

        public void ToggleSnapToSegments()
        {
            if (_context.Map.GeometryEditor.SnapMode == SnapMode.Vertices)
                _context.Map.GeometryEditor.SnapMode = SnapMode.VerticesAndLines;
            else
                _context.Map.GeometryEditor.SnapMode = SnapMode.Vertices;
        }

        public void ToggleSnapToVertices()
        {
            if (_context.Map.GeometryEditor.SnapMode == SnapMode.Lines)
                _context.Map.GeometryEditor.SnapMode = SnapMode.VerticesAndLines;
            else
                _context.Map.GeometryEditor.SnapMode = SnapMode.Lines;

        }
    }
}
