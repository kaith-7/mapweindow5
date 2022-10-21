// -------------------------------------------------------------------------------------------
// <copyright file="MainView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Helpers;
using MW5.Menu;
using MW5.Plugins.Concrete;
using MW5.Plugins.Events;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Properties;
using MW5.Shared;
using MW5.UI.Docking;
using MW5.UI.Forms;
using MW5.UI.Helpers;
using MW5.UI.Menu;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MW5.Views
{
    /// <summary>
    /// Represents the main view of the application with the map, docking windows, toolbars and menu.
    /// </summary>
    public partial class MainView : MapWindowViewMain, IMainView
    {
        public const string SerializationKey = ""; // intentionally empty
        private const string WindowTitle = "SunToon GIS";
        private readonly IAppContext _context;
        private bool _locked;
        private bool _rendered;
        private Process procDataDict = null;

        private static IList<string> _toolbarsName = new List<string>() {
                            "文件",
                            "地图",
                            "编辑矢量",
                        };
        private static IList<string> _dockPanelsName = new List<string>() {
                            "编辑属性表",
                            "存储库",
                            "日志",
                            "工具箱",
                            "内容列表",
                            "任务",
                            "识别",
                            "缩略图",
                            "属性检查",
                            };

        private IList<ToolStripItem> _EditorButtons;

        //#region Ribbon UI
        //private Syncfusion.Windows.Forms.Tools.ToolStripTabItem homeTabItem;
        //private Syncfusion.Windows.Forms.Tools.ToolStripTabItem sendTabItem;
        //private Syncfusion.Windows.Forms.Tools.ToolStripTabItem folderTabItem;
        //private Syncfusion.Windows.Forms.Tools.ToolStripTabItem viewTabItem;

        //private Syncfusion.Windows.Forms.Tools.ToolStripEx newToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx deleteToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx respondToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx moveToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx tagsToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx colorSchemeToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx quickstepsToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx currentViewToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx messagesToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx layoutToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx peopleToolStripEx;
        //private Syncfusion.Windows.Forms.Tools.ToolStripEx windowToolStripEx;
        //#endregion

        public MainView(IAppContext context)
        {
            Logger.Current.Trace("Start MainView");
            _context = context;

            Logger.Current.Trace("Start MainView.InitializeComponent");
            InitializeComponent();
            Logger.Current.Trace("End MainView.InitializeComponent");

            statusStripEx1.Items.Clear();
            statusStripEx1.Refresh();

            ToolTipHelper.Init(superToolTip1);

            FormClosing += MainView_FormClosing;
            Map.MapCursorChanged += Map_MapCursorChanged;

            // setting bar item text before form is shown results in creation of duplicated bar item;
            // it seems it's a bug in Syncfusion's XpMenus
            Shown += (s, e) =>
                {
                    _rendered = true;

                    UpdateView();

                    ForceTaskBarDisplay();
                };

            Logger.Current.Trace("End MainView");

            this.ribbonControlAdv_Main.ShowRibbonDisplayOptionButton = false;
            //this.ribbonControlAdv_Main.SelectedTab = this.toolStripTabItem_Edit;
            this.ribbonControlAdv_Main.SelectedTab = this.toolStripTabItem_Map;
            this._dockingManager1.AnimateAutoHiddenWindow = false;
            //toolStripTabItem_Map.Panel.AutoSize = true;
            var dpi = this.GetScreenDpi();
            //var dpiY = this.CreateGraphics().DpiY;
            if (dpi > 96f) // NOTE: 默认 DPI 按 96 计算，有很多文章都是按96算的，需要确定是不是一般的显示器分辨率都是96
            {
                this.ribbonControlAdv_Main.Height = (int)(this.ribbonControlAdv_Main.Height * (dpi / 96.0));
            }
            //Logger.Current.Debug($"DPI {dpi}, dpiY {dpiY}, Height {this.ribbonControlAdv_Main.Height}");

            //ribbonControlAdv_Main.EnableHighContrastTheme

            ribbonControlAdv_Main.MenuColor = System.Drawing.Color.Green;
            //ribbonControlAdv_Main.SelectedTab.BackColor = System.Drawing.Color.Green;
            //ribbonControlAdv_Main.SelectedTab.ForeColor = System.Drawing.Color.White;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00040000; // Turn on WS_EX_APPWINDOW
                return cp;
            }
        }

        public event EventHandler<CancelEventArgs> ViewClosing;

        public event EventHandler<RenderedEventArgs> ViewUpdating;

        public event System.Action BeforeShow;

        public void Lock()
        {
            _locked = true;
        }

        public void Unlock()
        {
            _locked = false;
            UpdateView();
        }

        private bool FireViewClosing()
        {
            var handler = ViewClosing;
            if (handler != null)
            {
                var args = new CancelEventArgs();
                handler(this, args);
                if (args.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        private void FireViewUpdating(bool rendered)
        {
            var handler = ViewUpdating;
            if (handler != null)
            {
                handler(this, new RenderedEventArgs { Rendered = rendered });
            }
        }

        private void ForceTaskBarDisplay()
        {
            // I found no better solution. There several similar issues reported 
            // but no explanation as to why it happens or any clean way to fix it.
            // http ://stackoverflow.com/questions/18701186/form-is-not-visible-on-taskbar
            // http ://stackoverflow.com/questions/6937183/application-not-visible-in-taskbar-when-using-application-run
            // http ://stackoverflow.com/questions/4183809/main-form-not-shown-in-taskbar
            // In theory form should appear in task bar when WS_EX_APPWINDOW is set or it's top level unowned form plus ShowInTaskBar 
            // is not set to false manually. All these conditions are met in our case.
            // http ://stackoverflow.com/questions/8204397/what-does-ws-ex-appwindow-do
            using (
                var form = new Form
                {
                    Width = 0,
                    Height = 0,
                    Left = -500,
                    Top = 0,
                    StartPosition = FormStartPosition.Manual
                })
            {
                form.Show(this);
                form.Close();
            }
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //checkLicThread.Abort();
            // if there are hidden child forms which override FormClosing
            // the initial value is set to true: https ://msdn.microsoft.com/en-us/library/system.windows.forms.form.formclosing%28v=vs.110%29.aspx
            // currently it may be the case with non-modal Find / Replace form in the table editor
            e.Cancel = false;

            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                return;
            }

            if (!FireViewClosing())
            {
                e.Cancel = true;
            }
            else
            {
                StoreCurrentState();
                try
                {
                    //DeviceManagerForm?.Close();
                    procDataDict?.Kill();
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }
        }

        private void StoreCurrentState()
        {
            _dockingManager1.SaveLayout(SerializationKey, false);
            _mainFrameBarManager1.SaveLayout(SerializationKey, false);
        }

        #region IView implementation

        private void RestorePreviousState()
        {
            _dockingManager1.TryRestoreLayout(SerializationKey);
            _mainFrameBarManager1.TryRestoreLayout(SerializationKey);
        }

        public override void ShowView(IWin32Window parent = null)
        {
            RestorePreviousState();

            DockPanelHelper.ClosePanel(_context, DockPanelKeys.TableEditor);
            DockPanelHelper.ClosePanel(_context, DockPanelKeys.Tasks);

            Program.Timer.Stop();
            Logger.Current.Info("Loading time: " + Program.Timer.Elapsed);

            SplashView.Instance.Close();

            _context.DockPanels.Unlock();

            // don't set it initially or it will cause a lot of resizing
            // with reallocation of buffer when panels / toolbars are loaded
            _mapControl1.Dock = DockStyle.Fill;
            
            statusStripEx1.ContextMenuStrip.Opening += OnStatusBarCustomizationMenuOpening;

            Invoke(BeforeShow);

            AppConfig.Instance.FirstRun = false;

            Show();

            Activate();

            Application.Run(this);
        }

        private void UpdateStatusBarCustomizationMenu()
        {
            var hash = new HashSet<string>
                           {
                               StatusBarKeys.TileProvider,
                               StatusBarKeys.MapScale,
                               StatusBarKeys.MapUnits,
                               StatusBarKeys.ProjectionDropDown
                           };
            try
            {
                statusStripEx1.ContextMenuStrip.Text = "自定义状态栏";
                foreach (ToolStripItem item in statusStripEx1.ContextMenuStrip.Items)
                {
                    var status = ReflectionHelper.GetInstanceField(item, "m_item") as ToolStripItem;
                    if (status == null)
                    {
                        item.Visible = false;
                        continue;
                    }

                    var metadata = status.Tag as MenuItemMetadata;

                    if (metadata != null && hash.Contains(metadata.Key))
                    {
                        item.Text = StatusBarKeys.GetStatusItemName(metadata.Key);
                        item.Visible = true;
                        continue;
                    }

                    item.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("Failed to update status bar customization menu.", ex);
            }
        }

        private void OnStatusBarCustomizationMenuOpening(object sender, CancelEventArgs e)
        {
            UpdateStatusBarCustomizationMenu();
        }

        private string GetCaption()
        {
            string caption = WindowTitle;

            if (!_context.Project.IsEmpty)
            {
                caption += @" - " + _context.Project.Filename;
            }

            return caption;
        }

        public void DoUpdateView(bool focusMap = true)
        {
            if (_locked) return;

            Text = GetCaption();

            // broadcast to plugins
            if (_rendered)
            {
                FireViewUpdating(_rendered);
            }

            if (ActiveForm == _mapControl1.ParentForm && focusMap)
            {
                _mapControl1.Focus();
            }
        }

        public override void UpdateUI()
        {
            btnViewZoomIn.Checked = _context.Map.MapCursor == MapCursor.ZoomIn;
            btnZoomOut.Checked = _context.Map.MapCursor == MapCursor.ZoomOut;
            btnPan.Checked = _context.Map.MapCursor == MapCursor.Pan;

            btnZoomPrev.Enabled = _context.Map.ExtentHistoryUndoCount > 0;
            btnZoomNext.Enabled = _context.Map.ExtentHistoryRedoCount > 0;

            btnShowZoombar.Checked = _context.Config.ShowZoombar;
            btnShowScalebar.Checked = _context.Config.ShowScalebar;
            btnShowCoordinates.Checked = _context.Config.ShowCoordinates;
            btnShowRedrawTime.Checked = _context.Config.ShowRedrawTime;

            var panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewPropertiesTable.Text);
            this.btnViewPropertiesTable.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewContents.Text);
            this.btnViewContents.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewDebugger.Text);
            this.btnViewDebugger.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewIdentity.Text);
            this.btnViewIdentity.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewRepository.Text);
            this.btnViewRepository.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewTasks.Text);
            this.btnViewTasks.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewToolbox.Text);
            this.btnViewToolbox.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewTheme.Text);
            this.btnViewTheme.Checked = panel != null ? panel.Visible : false;

            panel = _context.DockPanels.FirstOrDefault(i => i.Caption == this.btnViewAttributeChecker.Text);
            this.btnViewAttributeChecker.Checked = panel != null ? panel.Visible : false;

            var _map = _context.Map;
            //bool selection = _map.MapCursor == MapCursor.Selection && !_map.IsCustomSelectionMode;
            //btnSelectByPolygon.Checked = _map.MapCursor == MapCursor.SelectByPolygon;

            bool distance = _map.Measuring.Type == MeasuringType.Distance;
            btnMeasureArea.Checked = _map.MapCursor == MapCursor.Measure && !distance;
            btnMeasureDistance.Checked = _map.MapCursor == MapCursor.Measure && distance;

            this.btnip_IdentifyTool.Checked = _map.MapCursor == MapCursor.Identify;
            this.btnPictureViewer.Enabled = _map.Layers.Count > 0;

            bool hasImageLayer = _map.Layers.Any(l => l != null && l.IsRaster);
            this.btnSwipeTool.Enabled = hasImageLayer;

            this.btnSwitchFill.Enabled = _map.Layers.Any(l => l != null && l.IsVector && l.FeatureSet.GeometryType == GeometryType.Polygon);
            //this.btnSwitchFill.Image = _map.ShapeLayerDrawFill ? Resources.red_no_fill : Resources.red_fill;
            this.btnSwitchFill.Checked = !_map.ShapeLayerDrawFill;

            this.btnShowTiles.Checked = _map.TileProvider != TileProvider.None;

            // Editor
            UpdateEditor();
        }

        private void UpdateEditor()
        {
            IFeatureSet fs = null;
            var layer = _context.Map.Layers.Current;
            if (layer != null)
            {
                fs = layer.FeatureSet;
            }
            bool editing = fs != null && fs.InteractiveEditing;

            ((List<ToolStripItem>)_EditorButtons).ForEach(item => item.Enabled = editing);

            var editLayerItem = btnSE_LayerEdit;
            editLayerItem.Enabled = fs != null;
            editLayerItem.Image = editing ? Resources.保存编辑 : Resources.开始编辑;
            editLayerItem.Text = editing ? "保存编辑" : "开始编辑";
            editLayerItem.AccessibleDescription = editing ? "保存自上次保存起所做的所有编辑。保存后，无法撤销之前的编辑。" : "开始编辑会话以编辑要素或属性。";

            var text = string.Format("{0}\\{1}", _context.Map.History.UndoCount, _context.Map.History.TotalLength);
            this.txtHistoryLength.Text = text;

            int selectedCount = editing ? fs.NumSelected : 0;
            this.btnSE_MergeShapes.Enabled = selectedCount > 1;
            this.btnSE_SplitShapes.Enabled = selectedCount > 0;
            this.btnSE_MoveShapes.Enabled = selectedCount > 0;
            this.btnSE_RotateShapes.Enabled = selectedCount > 0;
            this.btnSE_CopyAttributes.Enabled = selectedCount == 1;


            if (editing)
                UpdateSnapStates();
            UpdateCopyPaste();
        }

        private void UpdateCopyPaste()
        {
            var list = new List<ToolStripItem>()
            {
                btnSE_Copy, btnSE_Paste, btnSE_Cut, btnSE_Undo, btnSE_Redo, btnSE_DeleteSelected
            };

            list.ForEach(item => item.Enabled = GetEnabled(item.Name));
        }

        private bool GetEnabled(string itemKey)
        {
            var map = _context.Map;
            var layer = _context.Map.Layers.Current;
            if (layer == null)
            {
                return false;
            }

            var fs = layer.FeatureSet;
            if (fs == null)
            {
                return false;
            }

            if (itemKey == btnSE_DeleteSelected.Name)
                return fs.NumSelected > 0 && fs.InteractiveEditing;
            else if (itemKey == btnSE_Undo.Name)
                return map.History.UndoCount > 0;
            else if (itemKey == btnSE_Redo.Name)
                return map.History.RedoCount > 0;
            else if (itemKey == btnSE_Copy.Name)
                return fs.NumSelected > 0;
            else if (itemKey == btnSE_CopyAttributes.Name)
                return fs.NumSelected == 1 && fs.InteractiveEditing;
            else if (itemKey == btnSE_Cut.Name)
                return fs.NumSelected > 0 && fs.InteractiveEditing;
            else if (itemKey == btnSE_Paste.Name)
                //return !_geoprocessingService.BufferIsEmpty && fs.InteractiveEditing;
                return fs.InteractiveEditing;
            return false;
        }

        internal void UpdateSnapStates()
        {
            var map = _context.Map;
            var editor = map.GeometryEditor;

            btnSE_SnapToActiveLayer.Checked = editor.SnapBehavior == LayerSelectionMode.ActiveLayer;
            btnSE_SnapToAllLayers.Checked = editor.SnapBehavior == LayerSelectionMode.AllLayers;
            btnSE_SnapToSegments.Checked = editor.SnapMode != SnapMode.Vertices;
            btnSE_SnapToVertices.Checked = editor.SnapMode != SnapMode.Lines;

            bool snapEditing = (
                map.MapCursor == MapCursor.MoveShapes ||
                map.MapCursor == MapCursor.RotateShapes ||
                map.MapCursor == MapCursor.AddShape ||
                map.MapCursor == MapCursor.EditShape
            );

            btnSE_SnapToActiveLayer.Enabled = snapEditing;
            btnSE_SnapToAllLayers.Enabled = snapEditing;
            btnSE_SnapToSegments.Enabled = snapEditing;
            btnSE_SnapToVertices.Enabled = snapEditing;
        }


        public override void UpdateView()
        {
            DoUpdateView();
        }

        public ButtonBase OkButton
        {
            get { return null; }
        }

        #endregion

        #region IMainView implementation

        public object DockingManager
        {
            get { return _dockingManager1; }
        }

        public object MenuManager
        {
            get { return _mainFrameBarManager1; }
        }

        public object RibbonControl
        {
            get { return this.ribbonControlAdv_Main; }
        }

        public object StatusBar
        {
            get { return statusStripEx1; }
        }

        public IMap Map
        {
            get { return _mapControl1; }
        }

        public IView View
        {
            get { return this; }
        }

        #endregion
        private MapCursor _oldCursor;
        //System.Threading.Thread checkLicThread;

        private void MainView_Load(object sender, EventArgs e)
        {
            #region Ribbon UI
            this._EditorButtons = new List<ToolStripItem>() {
                this.btnSE_LayerEdit,
                this.btnSE_GeometryCreate,
                this.btnSE_VertexEditor,
                this.btnSE_SplitShapes,
                this.btnSE_MergeShapes,
                this.btnSE_MoveShapes,
                this.btnSE_RotateShapes,
                this.btnSE_CopyAttributes,
                this.btnSE_PasteAttributes,
                this.btnSE_Copy,
                this.btnSE_Paste,
                this.btnSE_Cut,
                this.btnSE_DeleteSelected,
                this.btnSE_SplitByPolygon,
                this.btnSE_ClipByPolygon,
                this.btnSE_EraseByPolygon,
                this.btnSE_SplitByPolyline,
                this.btnSE_Undo,
                this.btnSE_Redo,

                this.btnSE_SnapToActiveLayer,
                this.btnSE_SnapToAllLayers,
                this.btnSE_SnapToSegments,
                this.btnSE_SnapToVertices,
            };

            var Buttons = new List<IComponent>() {
                // File
                this.btnFileNewMap,
                this.btnFileOpenProject,
                this.btnFileSaveProject,
                this.btnFileSaveProjectAs,
                this.btnppPrint,
                this.btnFileSettings,
                this.btnFileQuit,
                
                // Layer
                this.btnSE_CreateLayer,
                this.btnLayerAddLayer,
                this.btnLayerAddVectorLayer,
                this.btnLayerAddRasterLayer,
                this.btnLayerAddDatabaseLayer,
                this.btnLayerAddWmsLayer,
                //
                this.btnLayerRemoveLayer,
                this.btnLayerClearLayers,
                this.btnTP_ShowTopologyRulesWindow,
                //
                this.btnSetScale,
                this.btnSetProjection,
                this.btnSY_Categories,
                this.btnSY_Charts,
                this.btnSY_Labels,
                //
                this.tsbppPrint,
                this.btnppSelectPrintArea,

                // Map
                this.btnViewZoomIn,
                this.btnZoomOut,
                this.btnZoomMax,
                this.btnZoomPrev,
                this.btnZoomNext,
                //this.btnZoomToLayer,
                //this.btnViewZoomToBaseLayer,
                this.btnPan,
                //
                this.btnSelectionByAttribute,
                this.btnSelectionByLocation,
                this.btnSelectFeature,
                this.btnSelectByRectangle,
                this.btnSelectByPolygon,
                this.btnZoomToSelected,
                this.btnClearSelection,
                //
                this.btnMeasureDistance,
                this,btnMeasureArea,
                //
                this.btnip_IdentifyTool,
                this.btnPictureViewer,
                this.btnPictureViewSetting,
                this.btnGoToXY,
                this.btnSwipeTool,
                this.btnSwitchFill,
                this.btnSY_LabelMover,
                this.btnSY_SymbolRotator,

                // Edit

                // ViewTools
                this.btnShowZoombar,
                this.btnShowScalebar,
                this.btnShowCoordinates,
                this.btnShowRedrawTime,
                
                //this.btnFileToolbar,
                //this.btnMapToolbar,
                //this.btnEditToolbar,
                this.btnViewPropertiesTable,
                this.btnViewRepository,
                this.btnViewDebugger,
                this.btnViewAttributeChecker,
                this.btnViewToolbox,
                this.btnViewContents,
                this.btnViewTasks,
                this.btnViewIdentity,
                this.btnViewTheme,
                //this.btnShowTiles,
                this.btnShowDeviceManager,
                this.btnShowCsvToShp,

                // Help
                this.btnHelpWelcome,
                this.btnHelpGuide,
                this.btnHelpAbout,
            };

            // Tools
            Buttons.AddRange(
                new List<IComponent> {
                    this.btn_XBPHTool,
                    this.btn_ImageRegistrationTool,
                    this.btn_TranslateRasterTool,
                    this.btn_Ogr2OgrTool,
                    this.btn_RasterReprojectTool,
                    this.btn_ReprojectTool,
                    this.btn_AttributesCopyTool,
                    this.btn_DissolveTool,
                    this.btn_AggregateShapesTool,
                    this.btn_LineToPolygonTool,
                    this.btn_AreaMergeTool,
                    this.btn_PolyToLineTool,
                    this.btn_PolygonizeGridTool, 
                });

            this.toolStripEx16.Visible = false;
            this.btnShowTiles.Visible = false; // REMOVE:菜单已支持None Provider
            btnSE_CopyAttributes.DoubleClickEnabled = true;

            Buttons.AddRange(_EditorButtons);

            foreach (var item in Buttons)
            {
                switch (item)
                {
                    case ToolStripItem _:
                        {
                            if (item is ToolStripCheckBox checker)
                            {
                                if (_toolbarsName.Contains(checker.Tag.ToString())
                                    || _dockPanelsName.Contains(checker.Text)
                                    || checker.Text == "加载底图")
                                {
                                    checker.Click += Checker_Click;
                                }
                                else
                                    checker.Click += Button_Click;
                            }
                            else if (item is ToolStripItem btn)
                            {
                                btn.Click += Button_Click;
                            }
                            break;
                        }

                    case BackStageButton _:
                        ((BackStageButton)item).Click += Button_Click;
                        break;
                    default:
                        break;
                }
            }

            this.SetShortcut(this.btnSE_CreateLayer, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N))));
            this.SetShortcut(this.btnFileSaveProject, ((Keys)((Keys.Control | Keys.S))));
            this.SetShortcut(this.btnSetScale, ((Keys)((Keys.Control | Keys.Shift | Keys.S))));

            btnSelectFeature.Tag = btnSelectByRectangle;
            btnSelectFeature.Image = btnSelectByRectangle.Image;

            btnMeasure.Tag = btnMeasureDistance;
            btnMeasure.Image = btnMeasureDistance.Image;

            #endregion

            btnDataDictionary.Click += BtnDataDictionary_Click;

            AddCustomTileProvider();

            this.ribbonControlAdv_Main.BeforeContextMenuOpen += RibbonControlAdv_Main_BeforeContextMenuOpen;

            //DeviceManagerForm.Show();
            //DeviceManagerForm.Hide();
        }

        #region 监视USB接口插拔消息
        //private Form deviceForm;
        //private Form DeviceManagerForm {
        //    get {
        //        if (deviceForm == null || deviceForm.IsDisposed)
        //            deviceForm = new WFPhoneTree.DevicesForm(_layerService);
        //        return deviceForm;
        //    }
        //}

        //private void ShowDeviceFormFunc(bool isShow)
        //{
        //    if (isShow)
        //    {
        //        DeviceManagerForm.Show();
        //        DeviceManagerForm.BringToFront();
        //    }
        //    else
        //        DeviceManagerForm.Hide();
        //}

        #endregion

        // To canel display context menu on Ribbon
        private void RibbonControlAdv_Main_BeforeContextMenuOpen(object sender, ContextMenuEventArgs e)
        {
            e.Cancel = true;
        }

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        private void BtnDataDictionary_Click(object sender, EventArgs e)
        {
            var sdtExeFile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\emdatadefine.exe");
            if (procDataDict == null)
            {
                procDataDict = Process.Start(sdtExeFile);
                procDataDict.Exited += ProcDataDict_Exited;
                procDataDict.EnableRaisingEvents = true;
            }
            else
                SwitchToThisWindow(procDataDict.MainWindowHandle, true);
        }

        private void ProcDataDict_Exited(object sender, EventArgs e)
        {
            procDataDict = null;
        }

        private void Map_MapCursorChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static TileProvider oldTileProvider = TileProvider.None;

        private void Checker_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripCheckBox;
            if (item != null)
            {
                if (_dockPanelsName.Contains(item.Text))
                {
                    var panel = _context.DockPanels.FirstOrDefault(i => i.Caption == item.Text);
                    if (panel != null)
                    {
                        panel.Visible = item.Checked;
                        panel.Activate();
                    }
                }
                else if (_toolbarsName.Contains(item.Text))
                {
                    var barName = item.Tag as string;
                    var bar = _mainFrameBarManager1.GetBarFromBarName(barName);
                    var cbr = _mainFrameBarManager1.GetBarControl(bar);
                    cbr.Visible = item.Checked;
                }
                else if (item.Text == "加载底图")
                {
                    SwitchTilesDisplay();
                }
            }
        }

        private IMenuItem FindMenu(object sender, out string key)
        {
            IMenuItem menu = null;
            key = String.Empty;
            if (sender is ToolStripItem || sender is BackStageButton)
            {
                if (sender is ToolStripItem toolItem)
                {
                    key = toolItem.Name.Substring(3);
                }
                else if (sender is BackStageButton backButton)
                {
                    key = backButton.Name.Substring(3);
                    backStage1.Hide();
                }
                if (string.IsNullOrEmpty(key))
                    return null;

                var appContext = _context as AppContext;
                

                menu = appContext.Menu.FindItem(key, PluginIdentity.Default );
                if (menu == null)
                {
                    menu = appContext.Toolbars.FindItem(key, PluginIdentity.Default);
                    if (menu == null)
                    {
                        foreach (var item in appContext.PluginManager.AllPlugins)
                        {
                            menu = appContext.Menu.FindItem(key, item.Identity);
                            if (menu != null)
                                break;
                            menu = appContext.Toolbars.FindItem(key, item.Identity);
                            if (menu != null)
                                break;
                        }
                    }
                }
            }
            return menu;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var appContext = _context as AppContext;
             string key = string.Empty;
             var menu = FindMenu(sender, out key);
            if (menu != null)
            {
                appContext.Broadcaster.FireItemClicked(menu, new MenuItemEventArgs(key));

                switch (key)
                {
                    case "SelectByRectangle":
                        btnSelectFeature.Tag = btnSelectByRectangle;
                        btnSelectFeature.Image = btnSelectByRectangle.Image;
                        break;
                    case "SelectByPolygon":
                        btnSelectFeature.Tag = btnSelectByPolygon;
                        btnSelectFeature.Image = btnSelectByPolygon.Image;
                        break;
                    case "MeasureDistance":
                        btnMeasure.Tag = btnMeasureDistance;
                        btnMeasure.Image = btnMeasureDistance.Image;
                        break;
                    case "MeasureArea":
                        btnMeasure.Tag = btnMeasureArea;
                        btnMeasure.Image = btnMeasureArea.Image;
                        break;
                    default:
                        break;
                }
            }
            TryRunTool(key);
        }

        private void TryRunTool(string key)
        {
            key = key.TrimStart(new char[] { '_' });
            foreach (var g in _context.Toolbox.Groups)
            {
                var t = GetTool(g, key);
                if (t != null)
                {
                    _context.RunTool(t);
                }
            }
        }

        private ITool GetTool(IToolboxGroup g, string key)
        {
            foreach (var t in g.Tools)
            {
                var clsName = t.Tool.GetType().Name;
                if (clsName == key)
                {
                    // _context.RunTool(t.Tool);
                    return t.Tool;
                }
            }
            foreach (var sg in g.SubGroups)
            {
                var t = GetTool(sg, key);
                if (t != null)
                    return t;
            }
            return null;
        }

        private void btnSelectFeature_Click(object sender, EventArgs e)
        {
            var button = btnSelectFeature.Tag as ToolStripItem;
            if (button != null)
            {
                Button_Click(button, e);
            }
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            var button = btnMeasure.Tag as ToolStripItem;
            if (button != null)
            {
                Button_Click(button, e);
            }
        }

        private void ribbonControlAdv_Main_SelectedTabItemChanged(object sender, SelectedTabChangedEventArgs e)
        {
            if (e.NewSelectedTab == this.toolStripTabItem_Map)
            {
                if (!toolStripEx_Selection.Items.Contains(this.btnSelectFeature))
                {
                    toolStripEx_Selection.Items.Insert(0, this.btnSelectFeature);
                    toolStripEx_Selection.Items.Add(this.toolStripPanelItem_Select);
                }
            }
            else if (e.NewSelectedTab == this.toolStripTabItem_Edit)
            {
                if (!this.toolStripEx_Edit.Items.Contains(this.btnSelectFeature))
                {
                    var index = this.toolStripEx_Edit.Items.IndexOf(this.btnSE_DeleteSelected) + 2;
                    this.toolStripEx_Edit.Items.Insert(index, this.toolStripPanelItem_Select);
                    this.toolStripEx_Edit.Items.Insert(index, this.btnSelectFeature);
                }
            }
        }

        private void AddTmsProviderToMap(int providerId, bool update = true)
        {
            //int srsCode = _context.Map.Projection.GetEpsgCode();
            //int[] validCodes = { 4326, 3857 };
            //if (_context.Map.Layers.Count > 0 && !_context.Map.Projection.Name.Contains("Mercator"))
            //{
            //    MessageService.Current.Warn("底图当前只支持墨卡托投影，请先添加底图，再加载其它图层。"); // TODO:这里可以支持转换已加载的图层
            //    return;
            //}

            var newProject = _context.Map.Projection.IsEmpty;
            var provider = new Plugins.Model.TmsProvider();
            provider.Id = providerId;
            UpdateTmsBounds(provider, true);

            _context.Map.SetTileProvider(providerId);

            Logger.Current.Info(_context.Map.Tiles.ProviderName);

            _context.View.Update();
            if (newProject && _context.Map.Layers.Count == 0)
            {
                _context.Map.SetGeographicExtents(_context.Map.GetKnownExtents(KnownExtents.China));
            }
            _context.Map.Redraw(RedrawType.Minimal);
        }

        private void UpdateTmsBounds(Plugins.Model.TmsProvider provider, bool update)
        {
            bool projectionIsEmpty = _context.Map.Projection.IsEmpty;

            if (projectionIsEmpty)
            {
                _context.Map.SetGoogleMercatorProjection();
            }

            var mapProvider = _context.Map.Tiles.Providers.FirstOrDefault(p => p.Id == provider.Id);
            if (mapProvider != null)
            {
                mapProvider.GeographicBounds = provider.UseBounds ? provider.Bounds : Plugins.Model.TmsProvider.DefaultBounds;

                if (!update && !_context.Map.Layers.Any() && (provider.UseBounds || projectionIsEmpty))
                {
                    _context.Map.SetGeographicExtents(mapProvider.GeographicBounds);
                }
            }
        }

        private void SwitchTilesDisplay()
        {
            var provider = TileProvider.None;
            if (_context.Map.TileProvider == TileProvider.None)
            {
                if (oldTileProvider == TileProvider.None)
                    oldTileProvider = TileProvider.OpenStreetMap;
                provider = oldTileProvider;
            }
            else
            {
                oldTileProvider = _context.Map.TileProvider;
            }
            foreach (var item in _context.Repository.DefaultTmsProviders.Concat(_context.Repository.TmsProviders))
            {
                if (item.Id == (int)provider)
                {
                    var tms = item;
                    UpdateTmsBounds(tms, true);
                }
            }
            _context.Map.SetTileProvider((int)provider);
            _context.View.Update(); //to update provider in status bar
            //if (_context.Map.Layers.Count == 0)
            //    _context.Map.ZoomToTileLevel(2);
            _context.Map.Redraw(RedrawType.Minimal);
        }

        private void AddCustomTileProvider()
        {
            string subDomain = "<switch:t0,t1,t2,t3,t4,t5,t6,t7>";
            var providerTianDiTu = string.Format("https://{0}.tianditu.gov.cn/DataServer?T=img_w&tk=8678b7508f2fd3ddea3b590903b851df&x=<x>&y=<y>&l=<zoom>", subDomain);
            var index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            var ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "天地图(影像)", providerTianDiTu, TileProjection.SphericalMercator, maxZoom: 20);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }

            var providerTianDiTuImageLabel = string.Format("https://{0}.tianditu.gov.cn/DataServer?T=cia_w&tk=8678b7508f2fd3ddea3b590903b851df&x=<x>&y=<y>&l=<zoom>", subDomain);
            index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "天地图(矢量+标注)", providerTianDiTuImageLabel, TileProjection.SphericalMercator, maxZoom: 20);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }

            var providerTianDiTuVectorLabel = string.Format("https://{0}.tianditu.gov.cn/DataServer?T=cva_w&tk=8678b7508f2fd3ddea3b590903b851df&x=<x>&y=<y>&l=<zoom>", subDomain);
            index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "天地图(标注)", providerTianDiTuVectorLabel, TileProjection.SphericalMercator, maxZoom: 20);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }

            var subDomainGaoDe = "<switch:wprd01,wprd02,wprd03,wprd04>";
            var providerGaoDeMap = string.Format("https://{0}.is.autonavi.com/appmaptile?x=<x>&y=<y>&z=<zoom>&lang=zh_cn&size=1&scl=1&style=7", subDomainGaoDe);
            index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "高德地图(矢量)", providerGaoDeMap, TileProjection.SphericalMercator, maxZoom: 20, isGCJ02: true);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }

            var providerGaoDeSatellite = string.Format("https://{0}.is.autonavi.com/appmaptile?x=<x>&y=<y>&z=<zoom>&lang=zh_cn&size=1&scl=1&style=6", subDomainGaoDe);
            index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "高德地图(影像)", providerGaoDeSatellite, TileProjection.SphericalMercator, maxZoom: 20, isGCJ02: true);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }

            var subDomainGoogle = "<switch:bgn1,bgn2,bgn3>";
            var providerGoogleSatellite = string.Format("https://{0}.gpstool.com/vt/lyrs=s&hl=zh-CN&gl=cn&scale=1&x=<x>&y=<y>&z=<zoom>", subDomainGoogle);
            index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "谷歌地图(影像)", providerGoogleSatellite, TileProjection.SphericalMercator, maxZoom: 22, isGCJ02: true);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }

            var subDomainTencent = "<switch:p0,p1,p2,p3>";
            var providerTencentMap = string.Format("https://{0}.map.gtimg.com/maptilesv2/<zoom>/<x>/<y>/<x>_<y>.png", subDomainTencent);
            index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "腾讯地图(道路)", providerTencentMap, TileProjection.SphericalMercator, maxZoom: 22, isGCJ02: true, reverseY: true);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }

            var providerTencentSatellite = string.Format("https://{0}.map.gtimg.com/sateTiles/<zoom>/<x>/<y>/<x>_<y>.jpg?version=233", subDomainTencent);
            index = _context.Map.Tiles.Providers.Max(p => p.Id);
            if (index < 1024) index = 1024;
            ok = _context.Map.Tiles.Providers.AddCustom(index + 1, "腾讯地图(影像)", providerTencentSatellite, TileProjection.SphericalMercator, maxZoom: 22, isGCJ02: true, reverseY: true);
            if (!ok)
            {
                MessageService.Current.Warn("添加底图服务失败!");
            }
        }

        private void btnBaseMapNone_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void AddTmsProviderToMap(string name)
        {
            var provider = _context.Map.Tiles.Providers.FirstOrDefault(p => p.Name == name);
            if (provider != null)
            {
                AddTmsProviderToMap(provider.Id);
            }
            else
            {
                AddTmsProviderToMap((int)MW5.Api.Enums.TileProvider.None);
            }
        }

        private void btnBaseMapGoogleSatellitelabel_Click(object sender, EventArgs e)
        {
            var provider = TileProvider.GoogleMaps;
            AddTmsProviderToMap((int)provider);
        }

        private void btnBaseMapGoogleSatellite_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnBaseMapTianDiTu_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnBaseMapTianDiTuImage_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnBaseMapTianDiTuImageLabel_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnBaseMapGaoDeRoad_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnBaseMapGaoDeSatellite_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnBaseMapTencentRoad_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnBaseMapTencentSatellite_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;

            AddTmsProviderToMap(item.Text);
        }

        private void btnLayerAddLayer_Click(object sender, EventArgs e)
        {
            if (btnLayerAddLayer.DropDown.Visible)
                btnLayerAddLayer.DropDown.Close();
        }
    }
}