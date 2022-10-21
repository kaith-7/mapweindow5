// -------------------------------------------------------------------------------------------
// <copyright file="TableEditorPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Api.Legend.Abstract;
using MW5.Attributes.Helpers;
using MW5.Attributes.Views;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.TableEditor.Helpers;
using MW5.Plugins.TableEditor.Model;
using MW5.Plugins.TableEditor.Views.Abstract;
using MW5.Shared;

namespace MW5.Plugins.TableEditor.Views
{
    [LayoutWithRegions]
    internal class TableEditorPresenter : CommandDispatcher<ITableEditorView, TableEditorCommand>, IDockPanelPresenter
    {
        private readonly IAppContext _context;
        private readonly IFileDialogService _dialogService;
        private readonly ILayerService _layerService;
        private readonly Dictionary<int, TablePanelInfo> _tables;
        private bool isShowSelected = false;

        #region Constructors

        public TableEditorPresenter(IAppContext context, ITableEditorView view, IFileDialogService dialogService, ILayerService layerService)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (dialogService == null) throw new ArgumentNullException("dialogService");
            if (layerService == null) throw new ArgumentNullException("layerService");

            _context = context;
            _dialogService = dialogService;
            _layerService = layerService;

            _tables = new Dictionary<int, TablePanelInfo>();

            View.Initialize(context);

            View.Panels.BeforePanelClosed += (s, e) => CloseTable(e.LayerHandle);
            View.Panels.PanelActivated += (s, e) => View.OnActivateDockingPanel();
        }

        #endregion

        #region Properties

        public IAttributeTable ActiveTable
        {
            get
            {
                var fs = FeatureSet;

                if (fs == null)
                {
                    return null;
                }

                return fs.Table;
            }
        }

        public IFeatureSet FeatureSet
        {
            get { return View.ActiveFeatureSet; }
        }

        #endregion

        #region Public Methods

        public bool CheckAndSaveChanges(int layerHandle, bool withCancel)
        {
            var layer = _context.Legend.Layers.ItemByHandle(layerHandle);

            if (layer == null)
            {
                return true;
            }

            var fs = layer.FeatureSet;

            if (fs == null || !fs.CanEditTable())
            {
                return true; // nothing to save
            }

            var result = PromptSaveChanges(withCancel, layer.Name);

            switch (result)
            {
                case DialogResult.Cancel:
                    return false;
                case DialogResult.Yes:
                    RunCommand(TableEditorCommand.SaveChanges);
                    break;
            }

            return true;
        }

        public void CloseTable(int layerHandle)
        {
            if (_tables.ContainsKey(layerHandle))
            {
                var info = _tables[layerHandle];

                View.Panels.Remove(info.Panel);
                _tables.Remove(layerHandle);

                if (info.FindReplace != null)
                {
                    info.FindReplace.View.ForceClose();
                }
            }

            View.UpdateView();
        }

        public Control GetInternalObject()
        {
            return View as Control;
        }

        public bool HasLayer(int layerHandle)
        {
            return _tables.ContainsKey(layerHandle);
        }

        public void OnViewSelectionChanged(int layerHandle)
        {
            UpdateSelection(layerHandle);

            _context.Map.Redraw();
        }

        public void OpenTable(ILegendLayer layer)
        {
            if (layer == null) throw new ArgumentNullException("layer");

            if (_tables.ContainsKey(layer.Handle))
            {
                View.Panels.ActivatePanel(layer.Handle);
                return;
            }

            CreateNewTable(layer);

            View.UpdateView();
        }

        private bool ValidateColumnIndex(TableEditorCommand command)
        {
            switch (command)
            {
                case TableEditorCommand.FieldSortAsc:
                case TableEditorCommand.FieldSortDesc:
                case TableEditorCommand.FieldStats:
                case TableEditorCommand.FieldProperties:
                case TableEditorCommand.CalculateField:
                case TableEditorCommand.RemoveField:
                case TableEditorCommand.FieldHide:
                    if (View.ActiveColumnIndex == -1)
                    {
                        MessageService.Current.Info("Active column is expected for this command");
                        return false;
                    }
                    break;
            }

            return true;
        }

        private bool RequestEditSession(TableEditorCommand command)
        {
            switch (command)
            {
                case TableEditorCommand.CalculateField:
                case TableEditorCommand.AddField:
                case TableEditorCommand.RemoveField:
                case TableEditorCommand.ImportFieldDefinitions:
                case TableEditorCommand.UpdateMeasurements:
                case TableEditorCommand.Replace:
                case TableEditorCommand.RemoveFields:
                case TableEditorCommand.RecalculateFields:
                    {
                        if (FeatureSet.CanEditTable())
                        {
                            return true;
                        }

                        if (!CanStartEditingDirectly())
                        {
                            return false;
                        }

                        string msg = "此操作需要更改数据。" + Environment.NewLine;
                        msg += "是否开始编辑会话?";

                        if (MessageService.Current.Ask(msg))
                        {
                            return StartEditing();
                        }

                        return false;
                    }
            }

            return true;
        }

        private bool CanStartEditingDirectly()
        {
            var fs = FeatureSet;
            if (fs != null && fs.SourceType == Api.Enums.FeatureSourceType.InMemory)
            {
                MessageService.Current.Info("请使用编辑矢量插件来启动或停止对于内存或数据库层的编辑。");
                return false;
            }

            return true;
        }

        private bool IsAvailableForMemoryLayer(TableEditorCommand command)
        {
            switch (command)
            {
                case TableEditorCommand.StartEdit:
                case TableEditorCommand.DiscardChanges:
                case TableEditorCommand.SaveChanges:
                    return CanStartEditingDirectly();
            }

            return true;
        }

        private void UpdataDatasourceAndUI()
        {
            View.UpdateDatasource();
            _context.View.Update();
        }

        private IGeoprocessingService GeoProcessingService
        {
            get
            {
                try
                {
                    return _context.Container.Resolve<IGeoprocessingService>();
                }
                catch (Exception ex)
                {
                    MessageService.Current.Info(String.Format("编辑矢量插件未加载。%s", ex.Message));
                }

                return null;
            }
        }

        private void OnZoomToSelected()
        {
            _context.Map.ZoomToSelected(_context.Map.Legend.SelectedLayerHandle);
            //_context.Map.ZoomToSelected(View.ActiveLayerHandle);
            var grid = View.ActiveGrid;
            if (grid != null)
            {
                grid.Focus();
            }
        }

        public override void RunCommand(TableEditorCommand command)
        {
            if (HandleLayout(command))
            {
                return;
            }

            var table = ActiveTable;
            if (table == null)
            {
                return;
            }

            if (!ValidateColumnIndex(command))
            {
                return;
            }

            if (!RequestEditSession(command))
            {
                return;
            }

            if (!IsAvailableForMemoryLayer(command))
            {
                return;
            }

            switch (command)
            {
                case TableEditorCommand.RemoveSelected:
                    var gp = GeoProcessingService;
                    if (gp != null)
                    {
                        gp.RemoveSelectedShapes(View.ActiveLayerHandle, true);
                        View.UpdateView();
                    }
                    break;
                case TableEditorCommand.FormatValues:
                    AppConfig.Instance.TableEditorFormatValues = !AppConfig.Instance.TableEditorFormatValues;
                    UpdataDatasourceAndUI();
                    break;
                case TableEditorCommand.RecalculateFields:
                    if (!table.Fields.Any(f => string.IsNullOrWhiteSpace(f.Expression)))
                    {
                        MessageService.Current.Info("没有计算表达式中的字段。");
                        return;
                    }

                    if (_context.Container.Run<RecalculateFieldsPresenter, IAttributeTable>(table))
                    {
                        UpdataDatasourceAndUI();
                    }
                    break;
                case TableEditorCommand.ClearSorting:
                    {
                        var grid = View.ActiveGrid;
                        if (grid != null)
                        {
                            grid.ClearSorting();
                        }
                    }
                    break;
                case TableEditorCommand.AttributeExplorer:
                    {
                        var layer = _context.Layers.ItemByHandle(View.ActiveLayerHandle);
                        if (layer != null)
                        {
                            _context.Container.Run<AttributeExplorerPresenter, ILayer>(layer);
                        }
                    }
                    break;
                case TableEditorCommand.Query:
                    {
                        var layer = _context.Layers.ItemByHandle(View.ActiveLayerHandle);
                        if (layer != null)
                        {
                            var model = new QueryBuilderModel(layer, string.Empty);
                            _context.Container.Run<QueryBuilderPresenter, QueryBuilderModel>(model);
                        }
                    }
                    break;
                case TableEditorCommand.ExportSelected:
                    var fs = View.ActiveFeatureSet;
                    if (fs != null)
                    {
                        fs.ExportSelected(_dialogService, _layerService);
                    }
                    break;
                case TableEditorCommand.StopJoins:
                    if (!table.Joins.Any())
                    {
                        MessageService.Current.Info("没有连接去移除。");
                        return;
                    }

                    if (MessageService.Current.Ask("要移除该表的所有连接吗?"))
                    {
                        table.StopAllJoins();
                        UpdataDatasourceAndUI();
                    }
                    break;
                case TableEditorCommand.ImportFieldDefinitions:
                    if (DbfImportHelper.ImportFieldsFromDbf(_dialogService, table))
                    {
                        UpdataDatasourceAndUI();
                    }
                    break;
                case TableEditorCommand.ReloadTable:
                    View.UpdateDatasource();
                    break;
                case TableEditorCommand.ShowAliases:
                    AppConfig.Instance.TableEditorShowAliases = !AppConfig.Instance.TableEditorShowAliases;
                    View.UpdateDatasource();
                    break;
                case TableEditorCommand.ShowAllFields:
                    if (table.Fields.Any(f => !f.Visible))
                    {
                        if (MessageService.Current.Ask("要显示隐藏字段吗?"))
                        {
                            foreach (var fld in table.Fields)
                            {
                                fld.Visible = true;
                            }

                            View.UpdateDatasource();
                        }
                    }
                    else
                    {
                        MessageService.Current.Info("所有字段已显示。");
                    }
                    break;
                case TableEditorCommand.FieldSortAsc:
                case TableEditorCommand.FieldSortDesc:
                    {
                        var grid = View.ActiveGrid;
                        if (grid != null)
                        {
                            grid.SortByColumn(View.ActiveColumnIndex, command == TableEditorCommand.FieldSortAsc);
                        }
                    }
                    break;
                case TableEditorCommand.FieldHide:
                    {
                        var grid = View.ActiveGrid;
                        if (grid != null)
                        {
                            var fld = grid.GetField(View.ActiveColumnIndex);
                            var cmn = grid.Columns[View.ActiveColumnIndex];
                            if (fld != null && cmn != null)
                            {
                                cmn.Visible = false;
                                fld.Visible = false;
                            }
                        }
                    }
                    break;
                case TableEditorCommand.RemoveField:
                    {
                        var grid = View.ActiveGrid;
                        if (grid != null)
                        {
                            var fld = grid.GetField(View.ActiveColumnIndex);

                            if (MessageService.Current.Ask("要删除字段: " + fld.Name + "?"))
                            {
                                var fields = table.Fields;
                                int index = fields.IndexOf(fld);

                                if (fields.Remove(index))
                                {
                                    UpdataDatasourceAndUI();
                                }
                            }
                        }
                    }
                    break;
                case TableEditorCommand.FieldProperties:
                case TableEditorCommand.AddField:
                    {
                        var grid = View.ActiveGrid;
                        if (grid != null)
                        {
                            bool newField = command == TableEditorCommand.AddField;
                            var fld = newField ? null : grid.GetField(View.ActiveColumnIndex);

                            bool allowEditing = FeatureSet.CanEditTable();
                            var model = new FieldPropertiesModel(table, fld, newField, allowEditing);

                            if (_context.Container.Run<FieldPropertiesPresenter, FieldPropertiesModel>(model))
                            {
                                if (allowEditing || newField)
                                {
                                    model.Field.Modified = true;
                                    UpdataDatasourceAndUI();
                                }
                            }
                        }
                    }
                    break;
                case TableEditorCommand.FieldStats:
                    {
                        var grid = View.ActiveGrid;
                        if (grid != null)
                        {
                            var fld = grid.GetField(View.ActiveColumnIndex);
                            if (fld.Type == Api.Enums.AttributeType.String)
                            {
                                MessageService.Current.Info("统计信息不适用于text字段。");
                                return;
                            }

                            var model = new FieldStatsModel(table, fld.Index);
                            _context.Container.Run<FieldStatsPresenter, FieldStatsModel>(model);
                        }
                    }
                    break;
                case TableEditorCommand.UpdateMeasurements:
                    if (_context.Container.Run<UpdateMeasurementsPresenter, IFeatureSet>(View.ActiveFeatureSet))
                    {
                        UpdataDatasourceAndUI();
                    }
                    break;
                case TableEditorCommand.Join:
                    _context.Container.Run<JoinsPresenter, IAttributeTable>(table);
                    UpdataDatasourceAndUI();
                    break;
                case TableEditorCommand.StartEdit:
                    StartEditing();
                    break;
                case TableEditorCommand.DiscardChanges:
                    StopEditing(FeatureSet, false);
                    break;
                case TableEditorCommand.SaveChanges:
                    StopEditing(FeatureSet, true);
                    break;
                case TableEditorCommand.CalculateField:
                    {
                        var model = new FieldCalculatorModel(table, table.Fields[View.ActiveColumnIndex]);
                        if (_context.Container.Run<FieldCalculatorPresenter, FieldCalculatorModel>(model))
                        {
                            UpdataDatasourceAndUI();
                        }
                    }
                    break;

                case TableEditorCommand.RemoveFields:
                    if (_context.Container.Run<DeleteFieldsPresenter, IAttributeTable>(table))
                    {
                        UpdataDatasourceAndUI();
                    }
                    break;
                case TableEditorCommand.ShowSelected:
                    isShowSelected = !isShowSelected;
                    ShowSelected();
                    break;
                case TableEditorCommand.ZoomToCurrentCell:
                    {
                        var grid = View.ActiveGrid;
                        if (grid != null && grid.CurrentCell != null)
                        {
                            int rowIndex = grid.CurrentCell.RowIndex;
                            if (rowIndex != -1)
                            {
                                int shapeIndex = grid.RowManager.RealIndex(rowIndex);
                                _context.Map.ZoomToShape(View.ActiveLayerHandle, shapeIndex);
                                grid.Focus();
                            }
                        }
                        else
                        {
                            MessageService.Current.Info("目前未编辑任何要素。");
                        }
                    }
                    break;
                case TableEditorCommand.ZoomToSelected:
                    OnZoomToSelected();
                    break;
                case TableEditorCommand.SelectAll:
                    FeatureSet.SelectAll();
                    OnViewSelectionChanged(View.ActiveLayerHandle);
                    break;

                case TableEditorCommand.ClearSelection:
                    FeatureSet.ClearSelection();
                    OnViewSelectionChanged(View.ActiveLayerHandle);
                    break;

                case TableEditorCommand.InvertSelection:
                    FeatureSet.InvertSelection();
                    OnViewSelectionChanged(View.ActiveLayerHandle);
                    break;
                case TableEditorCommand.Find:
                    Find(false);
                    break;
                case TableEditorCommand.Replace:
                    Find(true);
                    break;
            }
        }

        private void StopEditing(IFeatureSet fs, bool saveChanges)
        {
            if (fs == null) return;

            var table = fs.Table;

            if (!table.EditMode)
            {
                return;
            }

            if (fs.InteractiveEditing)
            {
                MessageService.Current.Info("编辑要素形状时无法停止对属性表的编辑，请使用编辑矢量插件来操作。");
                return;
            }

            string msg = "停止编辑同时";
            msg += saveChanges ? "保存更改?" : "放弃更改?";

            if (!MessageService.Current.Ask(msg))
            {
                return;
            }

            table.StopEditing(saveChanges);

            var grid = View.ActiveGrid;
            if (grid != null)
            {
                grid.ReadOnly = !table.EditMode;
                View.UpdateDatasource();
            }

            ShowSelected();
        }

        private bool StartEditing()
        {
            var table = ActiveTable;

            if (table != null && !table.EditMode)
            {
                if (!table.StartEditing())
                {
                    MessageService.Current.Warn("无法开始编辑属性表的会话。");
                    return false;
                }

                var grid = View.ActiveGrid;
                if (grid != null)
                {
                    grid.ReadOnly = !table.EditMode;
                }

                View.UpdateView();
            }

            return true;
        }

        public void RebuildTableIndex(int layerHandle)
        {
            var info = GetTableInfo(layerHandle);
            if (info == null) return;

            var fs = _context.Layers.GetFeatureSet(layerHandle);
            if (fs == null) return;

            View.ClearCurrentCell();

            var manager = info.Grid.RowManager;

            int cmnIndex = manager.SortColumnIndex;
            bool ascending = manager.SortAscending;
            bool filtered = manager.Filtered;

            manager.Reset(fs);

            if (cmnIndex != -1)
            {
                info.Grid.SortByColumn(cmnIndex, ascending);
            }

            if (filtered)
            {
                manager.FilterSelected(fs);
            }

            info.Grid.RowCount = 0;
            info.Grid.RowCount = manager.Count;
            info.Grid.Invalidate();

            View.UpdateView();
        }

        public void UpdateSelection(int layerHandle)
        {
            switch (_context.Map.MapCursor)
            {
                case Api.Enums.MapCursor.None:
                    OnZoomToSelected(); // NOTE: 需不需要判断其它操作类型
                    break;
                default:
                    break;
            }

            var info = GetTableInfo(layerHandle);
            if (info == null) return;

            info.Grid.Invalidate();

            View.UpdatePanelCaption(layerHandle);

            View.OnSelectionChanged();

            _context.View.Update();
            ShowSelected();
        }

        #endregion

        #region Methods

        private void CreateNewTable(ILegendLayer layer)
        {
            var info = View.CreateTablePanel(layer);
            info.Grid.CellValueEdited += GridCellValueEdited;

            _tables.Add(layer.Handle, info);

            // TODO: shouldn't we remove these handlers on closing the layer
            info.Grid.SelectionChanged += (s, e) => OnViewSelectionChanged(layer.Handle);
            info.Grid.KeyDown += OnGridKeyDown;
            View.ActiveGrid.RowHeaderMouseDoubleClick += GridRowHeaderMouseDoubleClick;
        }

        private void OnGridKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RunCommand(TableEditorCommand.RemoveSelected);
            }
        }

        private void GridCellValueEdited(object sender, EventArgs e)
        {
            // to show the number of modified records
            View.UpdateView();
            _context.View.Update(false);
        }

        private void Find(bool replace)
        {
            var info = GetTableInfo(View.ActiveLayerHandle);
            if (info == null) return;

            if (info.FindReplace != null && info.FindReplace.Model.Replace != replace)
            {
                info.FindReplace.View.Close();
                info.FindReplace = null;
            }

            if (info.FindReplace == null)
            {
                info.FindReplace = _context.Container.GetInstance<FindReplacePresenter>();
            }

            var model = new FindReplaceModel(info.Grid, info.Layer, replace);

            info.FindReplace.Run(model);
        }

        private TablePanelInfo GetTableInfo(int layerHandle)
        {
            TablePanelInfo info;
            _tables.TryGetValue(layerHandle, out info);

            return info;
        }

        private bool HandleLayout(TableEditorCommand command)
        {
            if (command != TableEditorCommand.LayoutHorizontal && command != TableEditorCommand.LayoutVertical
                && command != TableEditorCommand.LayoutTabbed)
            {
                return false;
            }

            SaveLayoutOption(command);

            int size;
            DockPanelState state;

            View.GetLayoutSpecs(AppConfig.Instance.TableEditorLayout, out size, out state);

            var list = View.Panels.ToList().OrderBy(p => p.Caption);
            if (list.Count() < 2)
            {
                return true;
            }

            var panel = list.FirstOrDefault();

            foreach (var p in list.Where(p => p != panel))
            {
                p.DockTo(panel, state, size);
            }

            return true;
        }

        private DialogResult PromptSaveChanges(bool withCancel, string layerName)
        {
            var msg = "保存属性表更改的图层: " + layerName + "?";

            if (withCancel)
            {
                return MessageService.Current.AskWithCancel(msg);
            }

            return MessageService.Current.Ask(msg) ? DialogResult.Yes : DialogResult.No;
        }

        private void SaveLayoutOption(TableEditorCommand command)
        {
            switch (command)
            {
                case TableEditorCommand.LayoutTabbed:
                    AppConfig.Instance.TableEditorLayout = TableEditorLayout.Tabbed;
                    break;
                case TableEditorCommand.LayoutHorizontal:
                    AppConfig.Instance.TableEditorLayout = TableEditorLayout.Horizontal;
                    break;
                case TableEditorCommand.LayoutVertical:
                    AppConfig.Instance.TableEditorLayout = TableEditorLayout.Vertical;
                    break;
            }
        }

        private void ShowSelected()
        {
            var grid = View.ActiveGrid;
            if (grid == null)
            {
                return;
            }

            var manager = grid.RowManager;

            if (!isShowSelected && manager.Filtered)
            {
                manager.ClearFilter();
            }
            else if (isShowSelected)
            {
                View.ClearCurrentCell();
                manager.FilterSelected(FeatureSet);
            }

            //grid.RowCount = 0; // NOTE: 去掉这一行可以解决"点击属性表行头时自动滚动到开头的问题",暂未发现导致其它问题
            grid.RowCount = manager.Count;
            if (FeatureSet.SelectedIndices.Count == 1)
            {
                int idx = manager.RowIndex(FeatureSet.SelectedIndices[0]);
                if (idx >=0 && idx< FeatureSet.NumFeatures)
                    grid.CurrentCell = grid.Rows[idx].Cells[0];
            }
            grid.Invalidate();

            View.UpdateView();
        }

        private void GridRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnZoomToSelected();
        }

        #endregion
    }
}