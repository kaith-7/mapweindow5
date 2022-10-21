﻿// -------------------------------------------------------------------------------------------
// <copyright file="RepositoryPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Api.Static;
using MW5.Data.Enums;
using MW5.Data.Repository;
using MW5.Data.Views;
using MW5.Plugins.Concrete;
using MW5.Plugins.Helpers;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Model;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Tiles.Services;
using MW5.Tiles.Views;

namespace MW5.Plugins.Repository.Views
{
    public class RepositoryPresenter : CommandDispatcher<RepositoryDockPanel, RepositoryCommand>, IDockPanelPresenter
    {
        private readonly IAppContext _context;
        private readonly ILayerService _layerService;
        private readonly IRepository _repository;
        private readonly RepositoryDockPanel _view;
        private readonly TmsImporter _tmsImporter;

        public RepositoryPresenter(
            IAppContext context,
            RepositoryDockPanel view,
            TmsImporter tmsImporter,
            ILayerService layerService,
            IRepository repository,
            MainPlugin plugin)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (tmsImporter == null) throw new ArgumentNullException("tmsImporter");
            if (layerService == null) throw new ArgumentNullException("layerService");
            if (repository == null) throw new ArgumentNullException("repository");
            if (plugin == null) throw new ArgumentNullException("plugin");

            _context = context;
            _layerService = layerService;
            _repository = repository;
            _view = view;
            _tmsImporter = tmsImporter;

            _view.ItemDoubleClicked += ViewItemDoubleClicked;
            _view.RepositoryKeyDown += OnRepositoryKeyDown;
            view.Tree.UpdateTmsState(_context.Map.Tiles.ProviderId);

            plugin.TmsProviderChanged += OnTmsProviderChanged;
        }

        private void OnTmsProviderChanged(Api.Interfaces.IMuteMap map, EventArgs e)
        {
            View.Tree.UpdateTmsState(map.Tiles.ProviderId);
        }

        public Control GetInternalObject()
        {
            return _view;
        }

        public override void RunCommand(RepositoryCommand command)
        {
            switch (command)
            {
                case RepositoryCommand.Help:
                    var item = GetSelectedItem<IRepositoryItem>();
                    if (item != null && item.Type == RepositoryItemType.TmsRoot)
                    {
                        MessageService.Current.Info(
                            "可以将https://josm.openstreetmap.de/wiki/Maps上可用的XML导入为TMS向导。 " +
                            "导入之前，应将XML文档保存到磁盘。");
                    }
                    else
                    {
                        MessageService.Current.Info("无帮助。");
                    }
                    break;
                case RepositoryCommand.ClearTms:
                    if (MessageService.Current.Ask("要删除所有的TMS向导吗?"))
                    {
                        _repository.TmsProviders.Clear();
                    }
                    break;
                case RepositoryCommand.ImportTms:
                    _tmsImporter.ImportTms();
                    break;
                case RepositoryCommand.AddTms:
                    AddTmsProvider();
                    break;
                case RepositoryCommand.RemoveTms:
                    RemoveTmsProvider();
                    break;
                case RepositoryCommand.Properties:
                    EditTmsProvider();
                    break;
                case RepositoryCommand.AddFolder:
                    _repository.AddFolderLink();
                    break;
                case RepositoryCommand.RemoveFolder:
                    RemoveFolder();
                    break;
                case RepositoryCommand.AddToMap:
                    AddToMap();
                    break;
                case RepositoryCommand.RemoveFile:
                    RemoveFile();
                    break;
                case RepositoryCommand.OpenLocation:
                    OpenFileLocation();
                    break;
                case RepositoryCommand.GdalInfo:
                    ShowGdalInfo();
                    break;
                case RepositoryCommand.AddFolderToMap:
                    AddFolderToMap();
                    break;
                case RepositoryCommand.Refresh:
                    RefreshItem();
                    break;
                case RepositoryCommand.AddConnection:
                    AddConnection();
                    break;
                case RepositoryCommand.RemoveConnection:
                    RemoveConnection();
                    break;
                case RepositoryCommand.RemoveLayer:
                    RemoveDatabaseLayer();
                    break;
                case RepositoryCommand.CreateOgrLayer:
                    CreateOgrLayer();
                    break;
            }

            _context.View.Update();
        }

        private void EditTmsProvider()
        {
            var item = GetSelectedItem<ITmsItem>();
            if (item == null) return;

            var provider = item.Provider;

            // it's currently displayed, so let's update it
            bool needUpdate = _context.Map.Tiles.ProviderId == item.Provider.Id;

            if (_context.Container.Run<TmsProviderPresenter, TmsProvider>(provider))
            {
                _repository.TmsProviders.Update(provider);
                if (needUpdate)
                {
                    AddTmsProviderToMap(true);
                }
            }
        }

        private void AddTmsProvider()
        {
            var item = GetSelectedItem<IRepositoryItem>();

            if (item == null || item.Type != RepositoryItemType.TmsRoot) return;

            var provider = new TmsProvider();
            if (_context.Container.Run<TmsProviderPresenter, TmsProvider>(provider))
            {
                _repository.TmsProviders.Add(provider);
            }
        }

        private void RemoveTmsProvider()
        {
            var item = GetSelectedItem<ITmsItem>();
            if (item == null) return;

            string msg = string.Format("删除TMS向导: {0}?", item.Provider.Name);
            
            if (MessageService.Current.Ask(msg))
            {
                _repository.TmsProviders.Remove(item.Provider);
            }
        }

        private void AddConnection()
        {
            var item = GetSelectedItem<IRepositoryItem>() as IServerItem;
            if (item != null)
            {
                _repository.AddConnectionWithPrompt(item.DatabaseType);
            }
        }

        private void AddFolderToMap()
        {
            var folder = GetSelectedItem<IFolderItem>();
            if (folder != null)
            {
                _layerService.BeginBatch();

                try
                {
                    foreach (var item in folder.SubItems)
                    {
                        var file = item as IFileItem;
                        if (file != null)
                        {
                            _layerService.AddLayersFromFilename(file.Filename);
                        }
                    }
                }
                finally
                {
                    _layerService.EndBatch();
                }
            }
        }

        private void AddToMap()
        {
            var item = GetSelectedItem<IRepositoryItem>();

            if (item is ILayerItem)
            {
                AddLayerToMap(item as ILayerItem);
                return;
            }

            if (item is ITmsItem)
            {
                AddTmsProviderToMap(false);
            }
        }

        private void AddTmsProviderToMap(bool update)
        {
            //int srsCode = _context.Map.Projection.GetEpsgCode();
            //int[] validCodes = { 4326, 3857 };
            //if (_context.Map.Layers.Count > 0 && !_context.Map.Projection.Name.Contains("Mercator"))
            //{
            //    MessageService.Current.Warn("底图当前只支持墨卡托投影，请先添加底图，再加载其它图层。"); // TODO:这里可以支持转换已加载的图层
            //    return;
            //}
            
            var tms = GetSelectedItem<ITmsItem>();
            if (tms == null) return;

            var provider = tms.Provider;

            if (provider.IsCustom)
            {
                // in case of custom provider we need to add definition to the list
                if (!_context.SetCustomTileProvider(provider))
                {
                    MessageService.Current.Info("添加自定义TMS向导失败。");
                    return;
                }
            }

            UpdateTmsBounds(provider, update);

            _context.Map.SetTileProvider(provider.Id);

            _context.Map.Redraw(RedrawType.Minimal, true);

            if (!update && provider.Name != "无地图切片")
            {
                var msg = "TMS已做为一个图层添加到地图: " + Environment.NewLine + provider.Name;
                Logger.Current.Info(msg);
            }
        }

        private void UpdateTmsBounds(TmsProvider provider, bool update)
        {
            bool projectionIsEmpty = _context.Map.Projection.IsEmpty; 

            if (projectionIsEmpty)
            {
                _context.Map.SetGoogleMercatorProjection();
            }

            var mapProvider = _context.Map.Tiles.Providers.FirstOrDefault(p => p.Id == provider.Id);
            if (mapProvider != null)
            {
                mapProvider.GeographicBounds = provider.UseBounds ? provider.Bounds : TmsProvider.DefaultBounds;

                if (!update && !_context.Map.Layers.Any() && (provider.UseBounds || projectionIsEmpty))
                {
                    _context.Map.SetGeographicExtents(mapProvider.GeographicBounds);
                }
            }
        }

        private void AddLayerToMap(ILayerItem layer)
        {
            if (layer.AddedToMap)
            {
                _layerService.RemoveLayer(layer.Identity);
            }
            else
            {
                if (layer is IDatabaseLayerItem)
                {
                    var item = layer as IDatabaseLayerItem;
                    
                    if (item.Loading)
                    {
                        MessageService.Current.Info("This layer is being added to the map.");
                        return;
                    }

                    AddLayerToMapAsync(layer as IDatabaseLayerItem);
                }
                else
                {
                    if (_layerService.AddLayerIdentity(layer.Identity))
                    {
                        int handle = _layerService.LastLayerHandle;
                        _context.Map.ZoomToLayer(handle);
                    }
                }
            }
        }

        private void AddLayerToMapAsync(IDatabaseLayerItem item)
        {
            item.ShowLoadingIndicator();

            Task<IDatasource>.Factory.StartNew(() =>
            {
                var timer = new Stopwatch();
                timer.Start();

                var ds = GeoSource.OpenFromIdentity(item.Identity) as IVectorLayer;

                if (ds != null)
                {
                    var data = ds.Data;
                }

                return ds;       
            }).ContinueWith(t =>
            {
                if (t.Result != null)
                {
                    if (_layerService.AddDatasource(t.Result))
                    {
                        int handle = _layerService.LastLayerHandle;
                        _context.Map.ZoomToLayer(handle);
                    }
                }

                item.HideLoadingIndicator();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private T GetSelectedItem<T>() where T : class, IRepositoryItem
        {
            var item = _view.Tree.SelectedItem as T;
            if (item == null)
            {
                throw new InvalidCastException("Invalid type of the selected item.");
            }

            return item;
        }

        private void OnRepositoryKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    RemoveSelectedItem();
                    break;
                case Keys.Enter:
                    AddToMap();
                    break;
            }
        }

        private void RemoveSelectedItem()
        {
            var item = _view.Tree.SelectedItem;
            if (item != null)
            {
                if (item is IFileItem)
                {
                    RunCommand(RepositoryCommand.RemoveFile);
                }
                else if (item is IFolderItem)
                {
                    RunCommand(RepositoryCommand.RemoveFolder);
                }
                else if (item is IDatabaseItem)
                {
                    RunCommand(RepositoryCommand.RemoveConnection);
                }
                else if (item is IDatabaseLayerItem)
                {
                    RunCommand(RepositoryCommand.RemoveLayer);
                }
            }
        }

        private void OpenFileLocation()
        {
            var item = GetSelectedItem<IRepositoryItem>();
            string path = string.Empty;
            var folder = item as IFolderItem;
            if (folder != null)
            {
                path = folder.GetPath();
            }

            var vector = item as IFileItem;
            if (vector != null)
            {
                path = vector.Filename;
            }

            PathHelper.OpenFolderWithExplorer(path);
        }

        private void RefreshItem()
        {
            var item = GetSelectedItem<IRepositoryItem>();
            if (item is IFolderItem || item is IDatabaseItem)
            {
                RefreshItem(item);
            }
        }

        private void RefreshItem(IRepositoryItem item)
        {
            item.Refresh();
            View.Tree.UpdateState(item);
        }

        private void RemoveConnection()
        {
            var item = GetSelectedItem<IDatabaseItem>();
            if (item != null)
            {
                _repository.RemoveConnection(item.Connection, false);
            }
        }

        private void CreateOgrLayer()
        {
            var db = GetSelectedItem<IDatabaseItem>();
            if (db != null)
            {
                using (var ds = new VectorDatasource())
                {
                    if (ds.Open(db.Connection.ConnectionString))
                    {
                        var model = new CreateLayerModel();
                        if (_context.Container.Run<CreateLayerPresenter, CreateLayerModel>(model))
                        {
                            var projection = _context.Map.Projection.Clone();
                            if (projection.IsEmpty)
                            {
                                int EPSG = MW5.Projections.Helpers.ProjectionHelper.ChooseEpsgProjection(_context);
                                bool ok = projection.ImportFromEpsg(EPSG);
                            }
                            if (ds.CreateLayer(model.LayerName, model.GeometryType, projection))
                            //if (ds.CreateLayer("Test", GeometryType.Polyline, projection))
                            {
                                RefreshItem();
                            }
                        }
                    }
                }
            }
        }

        private void RemoveDatabaseLayer()
        {
            var layer = GetSelectedItem<IDatabaseLayerItem>();
            if (layer != null)
            {
                var db = layer.Parent as IDatabaseItem;
                if (db != null)
                {
                    var ds = new VectorDatasource();
                    if (ds.Open(db.Connection.ConnectionString))
                    {
                        int layerIndex = ds.LayerIndexByName(layer.Name);
                        if (MessageService.Current.Ask("移除数据库图层: " + layer.Name + "?"))
                        {
                            if (!ds.DeleteLayer(layerIndex))
                            {
                                MessageService.Current.Warn("删除图层失败。");
                            }

                            RefreshItem(db);
                        }
                    }
                }
            }
        }

        private void RemoveFile()
        {
            var item = GetSelectedItem<IFileItem>();

            if (item == null)
            {
                MessageService.Current.Info("未选择文件名。");
                return;
            }

            if (_context.Layers.Select(l => l.Identity).Contains(item.Identity))
            {
                MessageService.Current.Info("无法删除当前打开的数据源。");
                return;
            }

            if (
                MessageService.Current.Ask("删除数据源: " + Environment.NewLine +
                                           item.Filename + "?"))
            {
                try
                {
                    var folder = item.Folder;
                    GeoSource.Remove(item.Filename);
                    RefreshItem(folder);
                }
                catch (Exception ex)
                {
                    MessageService.Current.Warn("删除文件失败: " + ex.Message);
                }
            }
        }

        private void RemoveFolder()
        {
            var item = View.Tree.SelectedItem as IFolderItem;
            if (item != null && item.Root)
            {
                _repository.RemoveFolderLink(item.GetPath(), false);
            }
        }

        private void ShowGdalInfo()
        {
            var item = GetSelectedItem<IFileItem>();
            if (item != null)
            {
                var model = new GdalInfoModel(item);
                _context.Container.Run<GdalInfoPresenter, GdalInfoModel>(model);
            }
        }

        private void ViewItemDoubleClicked(object sender, RepositoryEventArgs e)
        {
            if (e.Item is IFileItem || e.Item is IDatabaseLayerItem || e.Item is ITmsItem)
            {
                RunCommand(RepositoryCommand.AddToMap);
            }
            else if (e.Item is IServerItem)
            {
                RunCommand(RepositoryCommand.AddConnection);
            }
            else if (e.Item.Type == RepositoryItemType.TmsRoot)
            {
                RunCommand(RepositoryCommand.AddTms);
            }
            else if (e.Item.Type == RepositoryItemType.FileSystem)
            {
                RunCommand(RepositoryCommand.AddFolder);
            }
        }
    }
}