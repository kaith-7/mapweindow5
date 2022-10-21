using MW5.Api;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Map;

namespace MW5.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            MW5.Api.Concrete.Envelope envelope1 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference1 = new MW5.Api.Concrete.SpatialReference();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem5 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem6 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem7 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem toolStripGalleryItem8 = new Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem();
            this.ribbonControlAdv_Main = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.btnFileNewMap = new Syncfusion.Windows.Forms.BackStageButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFileOpenProject = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageSeparator3 = new Syncfusion.Windows.Forms.BackStageSeparator();
            this.btnFileSaveProject = new Syncfusion.Windows.Forms.BackStageButton();
            this.btnFileSaveProjectAs = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageSeparator1 = new Syncfusion.Windows.Forms.BackStageSeparator();
            this.btnppPrint = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageSeparator2 = new Syncfusion.Windows.Forms.BackStageSeparator();
            this.btnFileSettings = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageSeparator4 = new Syncfusion.Windows.Forms.BackStageSeparator();
            this.btnFileQuit = new Syncfusion.Windows.Forms.BackStageButton();
            this.superAccelerator1 = new Syncfusion.Windows.Forms.Tools.SuperAccelerator(this);
            this.toolStripEx_Settings = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnSetScale = new System.Windows.Forms.ToolStripButton();
            this.btnSY_Charts = new System.Windows.Forms.ToolStripButton();
            this.btnSY_Categories = new System.Windows.Forms.ToolStripButton();
            this.btnSetProjection = new System.Windows.Forms.ToolStripButton();
            this.btnSY_Labels = new System.Windows.Forms.ToolStripButton();
            this.btnSwitchFill = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx_Layer = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnLayerAddLayer = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.btnLayerAddVectorLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLayerAddRasterLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLayerAddDatabaseLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLayerAddWmsLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton_BaseMap = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnBaseMapNone = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseMapTianDiTuImage = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt();
            this.btnBaseMapTianDiTu = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt();
            this.btnBaseMapTianDiTuImageLabel = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt();
            this.btnBaseMapGoogleSatellite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseMapGoogleSatellitelabel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseMapGaoDeRoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseMapGaoDeSatellite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseMapTencentRoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseMapTencentSatellite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSE_CreateLayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem_Layer = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnDataDictionary = new System.Windows.Forms.ToolStripButton();
            this.btnLayerRemoveLayer = new System.Windows.Forms.ToolStripButton();
            this.btnLayerClearLayers = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx_Printer = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsbppPrint = new System.Windows.Forms.ToolStripButton();
            this.btnppSelectPrintArea = new System.Windows.Forms.ToolStripButton();
            this.btnShowDeviceManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem_Map = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx_MapExplore = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnGoToXY = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem_Browse = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnViewZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomPrev = new System.Windows.Forms.ToolStripButton();
            this.btnZoomMax = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnZoomNext = new System.Windows.Forms.ToolStripButton();
            this.btnPan = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx_Selection = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnSelectFeature = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.btnSelectByRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectByPolygon = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt();
            this.btnSelectionByLocation = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem_Select = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnSelectionByAttribute = new System.Windows.Forms.ToolStripButton();
            this.btnClearSelection = new System.Windows.Forms.ToolStripButton();
            this.btnZoomToSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx12 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnMeasure = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.btnMeasureDistance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMeasureArea = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSwipeTool = new System.Windows.Forms.ToolStripButton();
            this.btnPictureViewer = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.btnPictureViewSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanelItem_Symbol = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnip_IdentifyTool = new System.Windows.Forms.ToolStripButton();
            this.btnSY_LabelMover = new System.Windows.Forms.ToolStripButton();
            this.btnSY_SymbolRotator = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem_Edit = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx_Edit = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnSE_LayerEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSE_GeometryCreate = new System.Windows.Forms.ToolStripButton();
            this.btnSE_VertexEditor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSE_SplitShapes = new System.Windows.Forms.ToolStripButton();
            this.btnSE_MergeShapes = new System.Windows.Forms.ToolStripButton();
            this.btnSE_MoveShapes = new System.Windows.Forms.ToolStripButton();
            this.btnSE_RotateShapes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSE_CopyAttributes = new System.Windows.Forms.ToolStripButton();
            this.btnSE_PasteAttributes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSE_Copy = new System.Windows.Forms.ToolStripButton();
            this.btnSE_Paste = new System.Windows.Forms.ToolStripButton();
            this.btnSE_Cut = new System.Windows.Forms.ToolStripButton();
            this.btnSE_DeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSE_SplitByPolygon = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.btnSE_EraseByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSE_ClipByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSE_SplitByPolyline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSE_Undo = new System.Windows.Forms.ToolStripButton();
            this.txtHistoryLength = new System.Windows.Forms.ToolStripLabel();
            this.btnSE_Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx14 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnSE_SnapToVertices = new System.Windows.Forms.ToolStripButton();
            this.btnSE_SnapToSegments = new System.Windows.Forms.ToolStripButton();
            this.btnSE_SnapToActiveLayer = new System.Windows.Forms.ToolStripButton();
            this.btnSE_SnapToAllLayers = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem_Help = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx6 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnShowZoombar = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnShowScalebar = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnShowCoordinates = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnShowRedrawTime = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolStripEx7 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnViewPropertiesTable = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewRepository = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewDebugger = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewToolbox = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewContents = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewTasks = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewIdentity = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewTheme = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnViewAttributeChecker = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolStripEx16 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnShowTiles = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolStripEx_About = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnHelpWelcome = new System.Windows.Forms.ToolStripButton();
            this.btnHelpGuide = new System.Windows.Forms.ToolStripButton();
            this.btnHelpAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx4 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripSplitButtonEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExt1 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnTP_ShowTopologyRulesWindow = new System.Windows.Forms.ToolStripButton();
            this.btn_XBPHTool = new System.Windows.Forms.ToolStripButton();
            this.btn_ImageRegistrationTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btn_TranslateRasterTool = new System.Windows.Forms.ToolStripButton();
            this.btn_Ogr2OgrTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx3 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btn_RasterReprojectTool = new System.Windows.Forms.ToolStripButton();
            this.btn_ReprojectTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx5 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btn_AttributesCopyTool = new System.Windows.Forms.ToolStripButton();
            this.btn_DissolveTool = new System.Windows.Forms.ToolStripButton();
            this.btn_AggregateShapesTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx8 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btn_LineToPolygonTool = new System.Windows.Forms.ToolStripButton();
            this.btn_AreaMergeTool = new System.Windows.Forms.ToolStripButton();
            this.btn_PolyToLineTool = new System.Windows.Forms.ToolStripButton();
            this.btn_PolygonizeGridTool = new System.Windows.Forms.ToolStripButton();
            this.btnShowCsvToShp = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem_Tools = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this._dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.dockingClientPanel1 = new Syncfusion.Windows.Forms.Tools.DockingClientPanel();
            this._mapControl1 = new MW5.Api.Map.BoundMapControl();
            this._mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.statusStripLabel5 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            this.statusMapUnits = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.toolStripGallery1 = new Syncfusion.Windows.Forms.Tools.ToolStripGallery();
            this.toolStripPanelItem_zoom = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.btnFileToolbar = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnMapToolbar = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.btnEditToolbar = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolStripPanelItem5 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem6 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem7 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExt2 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt();
            this.miniToolBar1 = new Syncfusion.Windows.Forms.Tools.MiniToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv_Main)).BeginInit();
            this.ribbonControlAdv_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).BeginInit();
            this.backStage1.SuspendLayout();
            this.toolStripEx_Settings.SuspendLayout();
            this.toolStripEx_Layer.SuspendLayout();
            this.toolStripEx_Printer.SuspendLayout();
            this.toolStripTabItem_Map.Panel.SuspendLayout();
            this.toolStripEx_MapExplore.SuspendLayout();
            this.toolStripEx_Selection.SuspendLayout();
            this.toolStripEx12.SuspendLayout();
            this.toolStripTabItem_Edit.Panel.SuspendLayout();
            this.toolStripEx_Edit.SuspendLayout();
            this.toolStripEx14.SuspendLayout();
            this.toolStripTabItem_Help.Panel.SuspendLayout();
            this.toolStripEx6.SuspendLayout();
            this.toolStripEx7.SuspendLayout();
            this.toolStripEx16.SuspendLayout();
            this.toolStripEx_About.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.toolStripEx3.SuspendLayout();
            this.toolStripEx5.SuspendLayout();
            this.toolStripEx8.SuspendLayout();
            this.toolStripTabItem_Tools.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dockingManager1)).BeginInit();
            this.dockingClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlAdv_Main
            // 
            resources.ApplyResources(this.ribbonControlAdv_Main, "ribbonControlAdv_Main");
            this.ribbonControlAdv_Main.BackStageView = this.backStageView1;
            this.ribbonControlAdv_Main.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ribbonControlAdv_Main.Header.AddMainItem(toolStripTabItem_Map);
            this.ribbonControlAdv_Main.Header.AddMainItem(toolStripTabItem_Edit);
            this.ribbonControlAdv_Main.Header.AddMainItem(toolStripTabItem_Tools);
            this.ribbonControlAdv_Main.Header.AddMainItem(toolStripTabItem_Help);
            this.superAccelerator1.SetMenuButtonAccelerator(this.ribbonControlAdv_Main, "F");
            this.ribbonControlAdv_Main.MenuButtonFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ribbonControlAdv_Main.MenuButtonText = "文件";
            this.ribbonControlAdv_Main.MenuButtonWidth = 60;
            this.ribbonControlAdv_Main.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv_Main.Name = "ribbonControlAdv_Main";
            this.ribbonControlAdv_Main.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.White;
            office2016ColorTable1.BackStageItemHoverColor = System.Drawing.Color.LimeGreen;
            office2016ColorTable1.CheckedTabColor = System.Drawing.Color.LimeGreen;
            office2016ColorTable1.CheckedTabForeColor = System.Drawing.Color.White;
            office2016ColorTable1.DisabledControlBoxForeColor = System.Drawing.Color.LimeGreen;
            office2016ColorTable1.HeaderColor = System.Drawing.Color.LimeGreen;
            office2016ColorTable1.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable1.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2016ColorTable1.SelectedTabColor = System.Drawing.Color.LimeGreen;
            this.ribbonControlAdv_Main.Office2016ColorTable.Add(office2016ColorTable1);
            this.ribbonControlAdv_Main.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv_Main.OfficeMenu
            // 
            resources.ApplyResources(this.ribbonControlAdv_Main.OfficeMenu, "ribbonControlAdv_Main.OfficeMenu");
            this.ribbonControlAdv_Main.OfficeMenu.AutoClose = false;
            this.ribbonControlAdv_Main.OfficeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ribbonControlAdv_Main.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv_Main.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv_Main.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv_Main.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv_Main.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv_Main.SelectedTab = this.toolStripTabItem_Map;
            this.ribbonControlAdv_Main.ShowQuickItemsDropDownButton = false;
            this.ribbonControlAdv_Main.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv_Main.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv_Main.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv_Main.ThemeName = "Office2016";
            this.ribbonControlAdv_Main.ThemeStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ribbonControlAdv_Main.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ribbonControlAdv_Main.ThemeStyle.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ribbonControlAdv_Main.ThemeStyle.TabForeColor = System.Drawing.Color.Empty;
            this.ribbonControlAdv_Main.ThemeStyle.TabGroupBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.ribbonControlAdv_Main.ThemeStyle.TitleBarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ribbonControlAdv_Main.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ribbonControlAdv_Main.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ribbonControlAdv_Main.UseDefaultHighlightColor = false;
            this.ribbonControlAdv_Main.UseTouchStyleArrowColor = true;
            this.ribbonControlAdv_Main.SelectedTabItemChanged += new Syncfusion.Windows.Forms.Tools.SelectedTabChangedEventHandler(this.ribbonControlAdv_Main_SelectedTabItemChanged);
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.BackStageViewNavigationButtonImage = global::MW5.Properties.Resources.img_mapwindow24;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            // 
            // backStage1
            // 
            resources.ApplyResources(this.backStage1, "backStage1");
            this.backStage1.AllowDrop = true;
            this.backStage1.BackStagePanelWidth = 130;
            this.backStage1.BeforeTouchSize = new System.Drawing.Size(1787, 766);
            this.backStage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage1.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage1.Controls.Add(this.btnFileNewMap);
            this.backStage1.Controls.Add(this.btnFileOpenProject);
            this.backStage1.Controls.Add(this.backStageSeparator3);
            this.backStage1.Controls.Add(this.btnFileSaveProject);
            this.backStage1.Controls.Add(this.btnFileSaveProjectAs);
            this.backStage1.Controls.Add(this.backStageSeparator1);
            this.backStage1.Controls.Add(this.btnppPrint);
            this.backStage1.Controls.Add(this.backStageSeparator2);
            this.backStage1.Controls.Add(this.btnFileSettings);
            this.backStage1.Controls.Add(this.backStageSeparator4);
            this.backStage1.Controls.Add(this.btnFileQuit);
            this.backStage1.ImageList = this.imageList1;
            this.backStage1.Name = "backStage1";
            this.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            this.backStage1.SuperAccelerator = this.superAccelerator1;
            this.backStage1.ThemeName = "BackStage2016Renderer";
            // 
            // btnFileNewMap
            // 
            this.btnFileNewMap.Accelerator = "";
            resources.ApplyResources(this.btnFileNewMap, "btnFileNewMap");
            this.btnFileNewMap.BackColor = System.Drawing.Color.Transparent;
            this.btnFileNewMap.ImageList = this.imageList1;
            this.btnFileNewMap.Name = "btnFileNewMap";
            this.btnFileNewMap.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.btnFileNewMap.Tag = "FileNewMap";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon_edit_copy.png");
            this.imageList1.Images.SetKeyName(1, "icon_edit_cut.png");
            this.imageList1.Images.SetKeyName(2, "icon_quit.png");
            this.imageList1.Images.SetKeyName(3, "EffectsSwipe32.png");
            this.imageList1.Images.SetKeyName(4, "GoToXY32.png");
            this.imageList1.Images.SetKeyName(5, "ico_legend.ico");
            this.imageList1.Images.SetKeyName(6, "ico_results.ico");
            this.imageList1.Images.SetKeyName(7, "ico_tasks.ico");
            this.imageList1.Images.SetKeyName(8, "ico_toolbox24.ico");
            this.imageList1.Images.SetKeyName(9, "ico_tools.ico");
            this.imageList1.Images.SetKeyName(10, "ico_zoom_to_layer.ico");
            this.imageList1.Images.SetKeyName(11, "icon_attribute_show.png");
            this.imageList1.Images.SetKeyName(12, "icon_attribute_show1.png");
            this.imageList1.Images.SetKeyName(13, "icon_clear_selection.png");
            this.imageList1.Images.SetKeyName(14, "icon_crs_change.png");
            this.imageList1.Images.SetKeyName(15, "icon_element_add.png");
            this.imageList1.Images.SetKeyName(16, "icon_folder.png");
            this.imageList1.Images.SetKeyName(17, "icon_identify.png");
            this.imageList1.Images.SetKeyName(18, "icon_label_add.png");
            this.imageList1.Images.SetKeyName(19, "icon_layer_add.png");
            this.imageList1.Images.SetKeyName(20, "icon_layer_clear.png");
            this.imageList1.Images.SetKeyName(21, "icon_layer_create.png");
            this.imageList1.Images.SetKeyName(22, "icon_layer_database_add.png");
            this.imageList1.Images.SetKeyName(23, "icon_layer_db_add.png");
            this.imageList1.Images.SetKeyName(24, "icon_layer_raster_add.png");
            this.imageList1.Images.SetKeyName(25, "icon_layer_remove.png");
            this.imageList1.Images.SetKeyName(26, "icon_layer_vector_add.png");
            this.imageList1.Images.SetKeyName(27, "icon_layer_vector_thematic_add.png");
            this.imageList1.Images.SetKeyName(28, "icon_mapwindow.ico");
            this.imageList1.Images.SetKeyName(29, "icon_measure_area.png");
            this.imageList1.Images.SetKeyName(30, "icon_measure_distance.png");
            this.imageList1.Images.SetKeyName(31, "icon_new_map.png");
            this.imageList1.Images.SetKeyName(32, "icon_pan.png");
            this.imageList1.Images.SetKeyName(33, "icon_pan1.png");
            this.imageList1.Images.SetKeyName(34, "icon_project_open.png");
            this.imageList1.Images.SetKeyName(35, "icon_save.png");
            this.imageList1.Images.SetKeyName(36, "icon_save_as.png");
            this.imageList1.Images.SetKeyName(37, "icon_save1.png");
            this.imageList1.Images.SetKeyName(38, "icon_search.png");
            this.imageList1.Images.SetKeyName(39, "icon_select.png");
            this.imageList1.Images.SetKeyName(40, "icon_select_by_polygon.png");
            this.imageList1.Images.SetKeyName(41, "icon_settings.png");
            this.imageList1.Images.SetKeyName(42, "icon_snapshot.png");
            this.imageList1.Images.SetKeyName(43, "icon_vertex.png");
            this.imageList1.Images.SetKeyName(44, "icon_zoom_in.png");
            this.imageList1.Images.SetKeyName(45, "icon_zoom_max_extents.png");
            this.imageList1.Images.SetKeyName(46, "icon_zoom_out.png");
            this.imageList1.Images.SetKeyName(47, "icon_zoom_to_layer.png");
            this.imageList1.Images.SetKeyName(48, "icon_zoom_to_selection.png");
            this.imageList1.Images.SetKeyName(49, "img_book24.png");
            this.imageList1.Images.SetKeyName(50, "img_broken_robot.jpg");
            this.imageList1.Images.SetKeyName(51, "img_compass.png");
            this.imageList1.Images.SetKeyName(52, "img_component32.png");
            this.imageList1.Images.SetKeyName(53, "img_coordinates32.png");
            this.imageList1.Images.SetKeyName(54, "img_default24.png");
            this.imageList1.Images.SetKeyName(55, "img_docs24.png");
            this.imageList1.Images.SetKeyName(56, "img_error_orange32.png");
            this.imageList1.Images.SetKeyName(57, "img_error_red32.png");
            this.imageList1.Images.SetKeyName(58, "img_eye32.png");
            this.imageList1.Images.SetKeyName(59, "img_folder_open32.png");
            this.imageList1.Images.SetKeyName(60, "img_geometry.png");
            this.imageList1.Images.SetKeyName(61, "img_globe32.png");
            this.imageList1.Images.SetKeyName(62, "img_layers32.png");
            this.imageList1.Images.SetKeyName(63, "img_map32.png");
            this.imageList1.Images.SetKeyName(64, "img_mapwindow_logo.png");
            this.imageList1.Images.SetKeyName(65, "img_mapwindow_logo1.bmp");
            this.imageList1.Images.SetKeyName(66, "img_mapwindow24.png");
            this.imageList1.Images.SetKeyName(67, "img_measure_length.png");
            this.imageList1.Images.SetKeyName(68, "img_measure32.png");
            this.imageList1.Images.SetKeyName(69, "img_open_layer32.png");
            this.imageList1.Images.SetKeyName(70, "img_options.png");
            this.imageList1.Images.SetKeyName(71, "img_palette.png");
            this.imageList1.Images.SetKeyName(72, "img_paypal24.png");
            this.imageList1.Images.SetKeyName(73, "img_picture32.png");
            this.imageList1.Images.SetKeyName(74, "img_picture321.png");
            this.imageList1.Images.SetKeyName(75, "img_plugin32.png");
            this.imageList1.Images.SetKeyName(76, "img_raster.png");
            this.imageList1.Images.SetKeyName(77, "img_scale24.png");
            this.imageList1.Images.SetKeyName(78, "img_server32.png");
            this.imageList1.Images.SetKeyName(79, "img_test24.png");
            this.imageList1.Images.SetKeyName(80, "img_tiles32.png");
            this.imageList1.Images.SetKeyName(81, "img_toolbox16.png");
            this.imageList1.Images.SetKeyName(82, "img_toolbox24.png");
            this.imageList1.Images.SetKeyName(83, "img_tools32.png");
            this.imageList1.Images.SetKeyName(84, "img_tune32.png");
            this.imageList1.Images.SetKeyName(85, "img_vector32.png");
            this.imageList1.Images.SetKeyName(86, "img_vector32_1.png");
            this.imageList1.Images.SetKeyName(87, "img_warning64.png");
            this.imageList1.Images.SetKeyName(88, "img_widgets32.png");
            this.imageList1.Images.SetKeyName(89, "img_wms_add24.png");
            this.imageList1.Images.SetKeyName(90, "img_world_grid32.png");
            this.imageList1.Images.SetKeyName(91, "img_zoom_next24.png");
            this.imageList1.Images.SetKeyName(92, "img_zoom_prev24.png");
            this.imageList1.Images.SetKeyName(93, "mapwindow_logo.png");
            this.imageList1.Images.SetKeyName(94, "red_fill.png");
            this.imageList1.Images.SetKeyName(95, "red_no_fill.png");
            this.imageList1.Images.SetKeyName(96, "SelectionSelectByAttributes32.png");
            this.imageList1.Images.SetKeyName(97, "SelectionSelectByLocation32.png");
            this.imageList1.Images.SetKeyName(98, "ST GIS(1).png");
            this.imageList1.Images.SetKeyName(99, "ST GIS(2).png");
            this.imageList1.Images.SetKeyName(100, "ST GIS(2)1.png");
            // 
            // btnFileOpenProject
            // 
            this.btnFileOpenProject.Accelerator = "";
            resources.ApplyResources(this.btnFileOpenProject, "btnFileOpenProject");
            this.btnFileOpenProject.BackColor = System.Drawing.Color.Transparent;
            this.btnFileOpenProject.ImageList = this.imageList1;
            this.btnFileOpenProject.Name = "btnFileOpenProject";
            this.btnFileOpenProject.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.btnFileOpenProject.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFileOpenProject.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnFileOpenProject.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnFileOpenProject.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFileOpenProject.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnFileOpenProject.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFileOpenProject.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnFileOpenProject.ThemeStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.btnFileOpenProject.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(175)))), ((int)(((byte)(229)))));
            this.btnFileOpenProject.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnFileOpenProject.ThemeStyle.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btnFileOpenProject.ThemeStyle.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnFileOpenProject.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // backStageSeparator3
            // 
            resources.ApplyResources(this.backStageSeparator3, "backStageSeparator3");
            this.backStageSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(255)))), ((int)(((byte)(96)))));
            this.backStageSeparator3.Name = "backStageSeparator3";
            this.backStageSeparator3.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            // 
            // btnFileSaveProject
            // 
            this.btnFileSaveProject.Accelerator = "";
            resources.ApplyResources(this.btnFileSaveProject, "btnFileSaveProject");
            this.btnFileSaveProject.BackColor = System.Drawing.Color.Transparent;
            this.btnFileSaveProject.ImageList = this.imageList1;
            this.btnFileSaveProject.Name = "btnFileSaveProject";
            this.btnFileSaveProject.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.btnFileSaveProject.Tag = "FileSaveProject";
            // 
            // btnFileSaveProjectAs
            // 
            this.btnFileSaveProjectAs.Accelerator = "";
            resources.ApplyResources(this.btnFileSaveProjectAs, "btnFileSaveProjectAs");
            this.btnFileSaveProjectAs.BackColor = System.Drawing.Color.Transparent;
            this.btnFileSaveProjectAs.ImageList = this.imageList1;
            this.btnFileSaveProjectAs.Name = "btnFileSaveProjectAs";
            this.btnFileSaveProjectAs.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.btnFileSaveProjectAs.Tag = "FileSaveProjectAs";
            // 
            // backStageSeparator1
            // 
            resources.ApplyResources(this.backStageSeparator1, "backStageSeparator1");
            this.backStageSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(255)))), ((int)(((byte)(96)))));
            this.backStageSeparator1.Name = "backStageSeparator1";
            this.backStageSeparator1.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            // 
            // btnppPrint
            // 
            this.btnppPrint.Accelerator = "";
            resources.ApplyResources(this.btnppPrint, "btnppPrint");
            this.btnppPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnppPrint.Name = "btnppPrint";
            this.btnppPrint.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.btnppPrint.Tag = "ppPrint";
            // 
            // backStageSeparator2
            // 
            resources.ApplyResources(this.backStageSeparator2, "backStageSeparator2");
            this.backStageSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(255)))), ((int)(((byte)(96)))));
            this.backStageSeparator2.Name = "backStageSeparator2";
            this.backStageSeparator2.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            // 
            // btnFileSettings
            // 
            this.btnFileSettings.Accelerator = "";
            resources.ApplyResources(this.btnFileSettings, "btnFileSettings");
            this.btnFileSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnFileSettings.ImageList = this.imageList1;
            this.btnFileSettings.Name = "btnFileSettings";
            this.btnFileSettings.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            // 
            // backStageSeparator4
            // 
            resources.ApplyResources(this.backStageSeparator4, "backStageSeparator4");
            this.backStageSeparator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(255)))), ((int)(((byte)(96)))));
            this.backStageSeparator4.Name = "backStageSeparator4";
            this.backStageSeparator4.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            // 
            // btnFileQuit
            // 
            this.btnFileQuit.Accelerator = "";
            resources.ApplyResources(this.btnFileQuit, "btnFileQuit");
            this.btnFileQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnFileQuit.ImageList = this.imageList1;
            this.btnFileQuit.Name = "btnFileQuit";
            this.btnFileQuit.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.btnFileQuit.Tag = "btnFileQuit";
            this.btnFileQuit.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFileQuit.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnFileQuit.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnFileQuit.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFileQuit.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btnFileQuit.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFileQuit.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnFileQuit.ThemeStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.btnFileQuit.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(175)))), ((int)(((byte)(229)))));
            this.btnFileQuit.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnFileQuit.ThemeStyle.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btnFileQuit.ThemeStyle.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnFileQuit.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // superAccelerator1
            // 
            this.superAccelerator1.ThemeName = "Default";
            // 
            // toolStripEx_Settings
            // 
            resources.ApplyResources(this.toolStripEx_Settings, "toolStripEx_Settings");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx_Settings, null);
            this.toolStripEx_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx_Settings.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx_Settings.Image = null;
            this.toolStripEx_Settings.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetScale,
            this.btnSY_Charts,
            this.btnSY_Categories,
            this.btnSetProjection,
            this.btnSY_Labels,
            this.btnSwitchFill});
            this.toolStripEx_Settings.Name = "toolStripEx_Settings";
            this.toolStripEx_Settings.Office12Mode = false;
            this.toolStripEx_Settings.ShowLauncher = false;
            // 
            // btnSetScale
            // 
            resources.ApplyResources(this.btnSetScale, "btnSetScale");
            this.btnSetScale.Image = global::MW5.Properties.Resources.比例尺;
            this.btnSetScale.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetScale.Name = "btnSetScale";
            this.SetShortcut(this.btnSetScale, System.Windows.Forms.Keys.None);
            this.btnSetScale.Tag = "SetScale";
            // 
            // btnSY_Charts
            // 
            resources.ApplyResources(this.btnSY_Charts, "btnSY_Charts");
            this.btnSY_Charts.Image = global::MW5.Properties.Resources.统计表;
            this.btnSY_Charts.Margin = new System.Windows.Forms.Padding(0);
            this.btnSY_Charts.Name = "btnSY_Charts";
            this.SetShortcut(this.btnSY_Charts, System.Windows.Forms.Keys.None);
            this.btnSY_Charts.Tag = "SY_Charts";
            // 
            // btnSY_Categories
            // 
            resources.ApplyResources(this.btnSY_Categories, "btnSY_Categories");
            this.btnSY_Categories.Image = global::MW5.Properties.Resources.分类渲染;
            this.btnSY_Categories.Margin = new System.Windows.Forms.Padding(0);
            this.btnSY_Categories.Name = "btnSY_Categories";
            this.SetShortcut(this.btnSY_Categories, System.Windows.Forms.Keys.None);
            this.btnSY_Categories.Tag = "SY_Categories";
            // 
            // btnSetProjection
            // 
            resources.ApplyResources(this.btnSetProjection, "btnSetProjection");
            this.btnSetProjection.Image = global::MW5.Properties.Resources.地图投影;
            this.btnSetProjection.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetProjection.Name = "btnSetProjection";
            this.SetShortcut(this.btnSetProjection, System.Windows.Forms.Keys.None);
            this.btnSetProjection.Tag = "SetProjection";
            // 
            // btnSY_Labels
            // 
            resources.ApplyResources(this.btnSY_Labels, "btnSY_Labels");
            this.btnSY_Labels.Image = global::MW5.Properties.Resources.标注设置;
            this.btnSY_Labels.Margin = new System.Windows.Forms.Padding(0);
            this.btnSY_Labels.Name = "btnSY_Labels";
            this.SetShortcut(this.btnSY_Labels, System.Windows.Forms.Keys.None);
            this.btnSY_Labels.Tag = "SY_Labels";
            // 
            // btnSwitchFill
            // 
            resources.ApplyResources(this.btnSwitchFill, "btnSwitchFill");
            this.btnSwitchFill.Image = global::MW5.Properties.Resources.面透明;
            this.btnSwitchFill.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwitchFill.Name = "btnSwitchFill";
            this.SetShortcut(this.btnSwitchFill, System.Windows.Forms.Keys.None);
            this.btnSwitchFill.Tag = "SwitchFill";
            // 
            // toolStripEx_Layer
            // 
            resources.ApplyResources(this.toolStripEx_Layer, "toolStripEx_Layer");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx_Layer, null);
            this.toolStripEx_Layer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx_Layer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx_Layer.Image = null;
            this.toolStripEx_Layer.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx_Layer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLayerAddLayer,
            this.toolStripSplitButton_BaseMap,
            this.btnSE_CreateLayer,
            this.toolStripPanelItem_Layer});
            this.toolStripEx_Layer.Name = "toolStripEx_Layer";
            this.toolStripEx_Layer.Office12Mode = false;
            this.toolStripEx_Layer.ShowLauncher = false;
            // 
            // btnLayerAddLayer
            // 
            resources.ApplyResources(this.btnLayerAddLayer, "btnLayerAddLayer");
            this.btnLayerAddLayer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLayerAddVectorLayer,
            this.btnLayerAddRasterLayer,
            this.btnLayerAddDatabaseLayer,
            this.btnLayerAddWmsLayer});
            this.btnLayerAddLayer.Image = global::MW5.Properties.Resources.添加数据;
            this.btnLayerAddLayer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btnLayerAddLayer.Name = "btnLayerAddLayer";
            this.SetShortcut(this.btnLayerAddLayer, System.Windows.Forms.Keys.None);
            this.btnLayerAddLayer.Click += new System.EventHandler(this.btnLayerAddLayer_Click);
            // 
            // btnLayerAddVectorLayer
            // 
            resources.ApplyResources(this.btnLayerAddVectorLayer, "btnLayerAddVectorLayer");
            this.btnLayerAddVectorLayer.Name = "btnLayerAddVectorLayer";
            this.SetShortcut(this.btnLayerAddVectorLayer, System.Windows.Forms.Keys.None);
            this.btnLayerAddVectorLayer.Tag = "LayerAddVectorLayer";
            // 
            // btnLayerAddRasterLayer
            // 
            resources.ApplyResources(this.btnLayerAddRasterLayer, "btnLayerAddRasterLayer");
            this.btnLayerAddRasterLayer.Name = "btnLayerAddRasterLayer";
            this.SetShortcut(this.btnLayerAddRasterLayer, System.Windows.Forms.Keys.None);
            this.btnLayerAddRasterLayer.Tag = "LayerAddRasterLayer";
            // 
            // btnLayerAddDatabaseLayer
            // 
            resources.ApplyResources(this.btnLayerAddDatabaseLayer, "btnLayerAddDatabaseLayer");
            this.btnLayerAddDatabaseLayer.Name = "btnLayerAddDatabaseLayer";
            this.SetShortcut(this.btnLayerAddDatabaseLayer, System.Windows.Forms.Keys.None);
            this.btnLayerAddDatabaseLayer.Tag = "LayerAddDatabaseLayer";
            // 
            // btnLayerAddWmsLayer
            // 
            resources.ApplyResources(this.btnLayerAddWmsLayer, "btnLayerAddWmsLayer");
            this.btnLayerAddWmsLayer.Name = "btnLayerAddWmsLayer";
            this.SetShortcut(this.btnLayerAddWmsLayer, System.Windows.Forms.Keys.None);
            this.btnLayerAddWmsLayer.Tag = "LayerAddWmsLayer";
            // 
            // toolStripSplitButton_BaseMap
            // 
            resources.ApplyResources(this.toolStripSplitButton_BaseMap, "toolStripSplitButton_BaseMap");
            this.toolStripSplitButton_BaseMap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaseMapNone,
            this.btnBaseMapTianDiTuImage,
            this.btnBaseMapTianDiTu,
            this.btnBaseMapTianDiTuImageLabel,
            this.btnBaseMapGoogleSatellite,
            this.btnBaseMapGoogleSatellitelabel,
            this.btnBaseMapGaoDeRoad,
            this.btnBaseMapGaoDeSatellite,
            this.btnBaseMapTencentRoad,
            this.btnBaseMapTencentSatellite});
            this.toolStripSplitButton_BaseMap.Image = global::MW5.Properties.Resources.底图;
            this.toolStripSplitButton_BaseMap.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.toolStripSplitButton_BaseMap.Name = "toolStripSplitButton_BaseMap";
            this.SetShortcut(this.toolStripSplitButton_BaseMap, System.Windows.Forms.Keys.None);
            // 
            // btnBaseMapNone
            // 
            resources.ApplyResources(this.btnBaseMapNone, "btnBaseMapNone");
            this.btnBaseMapNone.Name = "btnBaseMapNone";
            this.SetShortcut(this.btnBaseMapNone, System.Windows.Forms.Keys.None);
            this.btnBaseMapNone.Click += new System.EventHandler(this.btnBaseMapNone_Click);
            // 
            // btnBaseMapTianDiTuImage
            // 
            resources.ApplyResources(this.btnBaseMapTianDiTuImage, "btnBaseMapTianDiTuImage");
            this.btnBaseMapTianDiTuImage.Name = "btnBaseMapTianDiTuImage";
            this.SetShortcut(this.btnBaseMapTianDiTuImage, System.Windows.Forms.Keys.None);
            this.btnBaseMapTianDiTuImage.Click += new System.EventHandler(this.btnBaseMapTianDiTuImage_Click);
            // 
            // btnBaseMapTianDiTu
            // 
            resources.ApplyResources(this.btnBaseMapTianDiTu, "btnBaseMapTianDiTu");
            this.btnBaseMapTianDiTu.Name = "btnBaseMapTianDiTu";
            this.SetShortcut(this.btnBaseMapTianDiTu, System.Windows.Forms.Keys.None);
            this.btnBaseMapTianDiTu.Click += new System.EventHandler(this.btnBaseMapTianDiTu_Click);
            // 
            // btnBaseMapTianDiTuImageLabel
            // 
            resources.ApplyResources(this.btnBaseMapTianDiTuImageLabel, "btnBaseMapTianDiTuImageLabel");
            this.btnBaseMapTianDiTuImageLabel.Name = "btnBaseMapTianDiTuImageLabel";
            this.SetShortcut(this.btnBaseMapTianDiTuImageLabel, System.Windows.Forms.Keys.None);
            this.btnBaseMapTianDiTuImageLabel.Click += new System.EventHandler(this.btnBaseMapTianDiTuImageLabel_Click);
            // 
            // btnBaseMapGoogleSatellite
            // 
            resources.ApplyResources(this.btnBaseMapGoogleSatellite, "btnBaseMapGoogleSatellite");
            this.btnBaseMapGoogleSatellite.Name = "btnBaseMapGoogleSatellite";
            this.SetShortcut(this.btnBaseMapGoogleSatellite, System.Windows.Forms.Keys.None);
            this.btnBaseMapGoogleSatellite.Click += new System.EventHandler(this.btnBaseMapGoogleSatellite_Click);
            // 
            // btnBaseMapGoogleSatellitelabel
            // 
            resources.ApplyResources(this.btnBaseMapGoogleSatellitelabel, "btnBaseMapGoogleSatellitelabel");
            this.btnBaseMapGoogleSatellitelabel.Name = "btnBaseMapGoogleSatellitelabel";
            this.SetShortcut(this.btnBaseMapGoogleSatellitelabel, System.Windows.Forms.Keys.None);
            this.btnBaseMapGoogleSatellitelabel.Click += new System.EventHandler(this.btnBaseMapGoogleSatellitelabel_Click);
            // 
            // btnBaseMapGaoDeRoad
            // 
            resources.ApplyResources(this.btnBaseMapGaoDeRoad, "btnBaseMapGaoDeRoad");
            this.btnBaseMapGaoDeRoad.Name = "btnBaseMapGaoDeRoad";
            this.SetShortcut(this.btnBaseMapGaoDeRoad, System.Windows.Forms.Keys.None);
            this.btnBaseMapGaoDeRoad.Click += new System.EventHandler(this.btnBaseMapGaoDeRoad_Click);
            // 
            // btnBaseMapGaoDeSatellite
            // 
            resources.ApplyResources(this.btnBaseMapGaoDeSatellite, "btnBaseMapGaoDeSatellite");
            this.btnBaseMapGaoDeSatellite.Name = "btnBaseMapGaoDeSatellite";
            this.SetShortcut(this.btnBaseMapGaoDeSatellite, System.Windows.Forms.Keys.None);
            this.btnBaseMapGaoDeSatellite.Click += new System.EventHandler(this.btnBaseMapGaoDeSatellite_Click);
            // 
            // btnBaseMapTencentRoad
            // 
            resources.ApplyResources(this.btnBaseMapTencentRoad, "btnBaseMapTencentRoad");
            this.btnBaseMapTencentRoad.Name = "btnBaseMapTencentRoad";
            this.SetShortcut(this.btnBaseMapTencentRoad, System.Windows.Forms.Keys.None);
            this.btnBaseMapTencentRoad.Click += new System.EventHandler(this.btnBaseMapTencentRoad_Click);
            // 
            // btnBaseMapTencentSatellite
            // 
            resources.ApplyResources(this.btnBaseMapTencentSatellite, "btnBaseMapTencentSatellite");
            this.btnBaseMapTencentSatellite.Name = "btnBaseMapTencentSatellite";
            this.SetShortcut(this.btnBaseMapTencentSatellite, System.Windows.Forms.Keys.None);
            this.btnBaseMapTencentSatellite.Click += new System.EventHandler(this.btnBaseMapTencentSatellite_Click);
            // 
            // btnSE_CreateLayer
            // 
            resources.ApplyResources(this.btnSE_CreateLayer, "btnSE_CreateLayer");
            this.btnSE_CreateLayer.Image = global::MW5.Properties.Resources.新建图层;
            this.btnSE_CreateLayer.Margin = new System.Windows.Forms.Padding(0);
            this.btnSE_CreateLayer.Name = "btnSE_CreateLayer";
            this.SetShortcut(this.btnSE_CreateLayer, System.Windows.Forms.Keys.None);
            this.btnSE_CreateLayer.Tag = "SE_CreateLayer";
            // 
            // toolStripPanelItem_Layer
            // 
            resources.ApplyResources(this.toolStripPanelItem_Layer, "toolStripPanelItem_Layer");
            this.toolStripPanelItem_Layer.CausesValidation = false;
            this.toolStripPanelItem_Layer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem_Layer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDataDictionary,
            this.btnLayerRemoveLayer,
            this.btnLayerClearLayers});
            this.toolStripPanelItem_Layer.Name = "toolStripPanelItem_Layer";
            this.SetShortcut(this.toolStripPanelItem_Layer, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem_Layer.Transparent = true;
            // 
            // btnDataDictionary
            // 
            resources.ApplyResources(this.btnDataDictionary, "btnDataDictionary");
            this.btnDataDictionary.Name = "btnDataDictionary";
            this.SetShortcut(this.btnDataDictionary, System.Windows.Forms.Keys.None);
            // 
            // btnLayerRemoveLayer
            // 
            resources.ApplyResources(this.btnLayerRemoveLayer, "btnLayerRemoveLayer");
            this.btnLayerRemoveLayer.Name = "btnLayerRemoveLayer";
            this.SetShortcut(this.btnLayerRemoveLayer, System.Windows.Forms.Keys.None);
            this.btnLayerRemoveLayer.Tag = "LayerRemoveLayer";
            // 
            // btnLayerClearLayers
            // 
            resources.ApplyResources(this.btnLayerClearLayers, "btnLayerClearLayers");
            this.btnLayerClearLayers.Name = "btnLayerClearLayers";
            this.SetShortcut(this.btnLayerClearLayers, System.Windows.Forms.Keys.None);
            this.btnLayerClearLayers.Tag = "LayerClearLayers";
            // 
            // toolStripEx_Printer
            // 
            resources.ApplyResources(this.toolStripEx_Printer, "toolStripEx_Printer");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx_Printer, null);
            this.toolStripEx_Printer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx_Printer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx_Printer.Image = null;
            this.toolStripEx_Printer.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx_Printer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbppPrint,
            this.btnppSelectPrintArea,
            this.btnShowDeviceManager});
            this.toolStripEx_Printer.Name = "toolStripEx_Printer";
            this.toolStripEx_Printer.Office12Mode = false;
            this.toolStripEx_Printer.ShowLauncher = false;
            // 
            // tsbppPrint
            // 
            resources.ApplyResources(this.tsbppPrint, "tsbppPrint");
            this.tsbppPrint.Image = global::MW5.Properties.Resources.打印机;
            this.tsbppPrint.Name = "tsbppPrint";
            this.SetShortcut(this.tsbppPrint, System.Windows.Forms.Keys.None);
            this.tsbppPrint.Tag = "ppPrint";
            // 
            // btnppSelectPrintArea
            // 
            resources.ApplyResources(this.btnppSelectPrintArea, "btnppSelectPrintArea");
            this.btnppSelectPrintArea.Image = global::MW5.Properties.Resources.区域打印;
            this.btnppSelectPrintArea.Name = "btnppSelectPrintArea";
            this.SetShortcut(this.btnppSelectPrintArea, System.Windows.Forms.Keys.None);
            this.btnppSelectPrintArea.Tag = "ppSelectPrintArea";
            // 
            // btnShowDeviceManager
            // 
            resources.ApplyResources(this.btnShowDeviceManager, "btnShowDeviceManager");
            this.btnShowDeviceManager.Image = global::MW5.Properties.Resources.移动设备;
            this.btnShowDeviceManager.Name = "btnShowDeviceManager";
            this.SetShortcut(this.btnShowDeviceManager, System.Windows.Forms.Keys.None);
            this.btnShowDeviceManager.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripTabItem_Map
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem_Map, "M");
            resources.ApplyResources(this.toolStripTabItem_Map, "toolStripTabItem_Map");
            this.toolStripTabItem_Map.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTabItem_Map.Name = "toolStripTabItem_Map";
            // 
            // ribbonControlAdv_Main.ribbonPanel1
            // 
            resources.ApplyResources(this.toolStripTabItem_Map.Panel, "ribbonControlAdv_Main.ribbonPanel1");
            this.toolStripTabItem_Map.Panel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTabItem_Map.Panel.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toolStripTabItem_Map.Panel.Controls.Add(this.toolStripEx_MapExplore);
            this.toolStripTabItem_Map.Panel.Controls.Add(this.toolStripEx_Layer);
            this.toolStripTabItem_Map.Panel.Controls.Add(this.toolStripEx_Selection);
            this.toolStripTabItem_Map.Panel.Controls.Add(this.toolStripEx12);
            this.toolStripTabItem_Map.Panel.Controls.Add(this.toolStripEx_Settings);
            this.toolStripTabItem_Map.Panel.Controls.Add(this.toolStripEx_Printer);
            this.toolStripTabItem_Map.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem_Map.Panel.ScrollPosition = 0;
            this.toolStripTabItem_Map.Panel.ShowCaption = true;
            this.toolStripTabItem_Map.Panel.ShowLauncher = true;
            this.toolStripTabItem_Map.Position = 0;
            this.SetShortcut(this.toolStripTabItem_Map, System.Windows.Forms.Keys.None);
            this.toolStripTabItem_Map.Tag = "2";
            // 
            // toolStripEx_MapExplore
            // 
            resources.ApplyResources(this.toolStripEx_MapExplore, "toolStripEx_MapExplore");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx_MapExplore, null);
            this.toolStripEx_MapExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx_MapExplore.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx_MapExplore.Image = null;
            this.toolStripEx_MapExplore.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx_MapExplore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoToXY,
            this.toolStripPanelItem_Browse});
            this.toolStripEx_MapExplore.Name = "toolStripEx_MapExplore";
            this.toolStripEx_MapExplore.Office12Mode = false;
            this.toolStripEx_MapExplore.ShowCaption = true;
            this.toolStripEx_MapExplore.ShowLauncher = false;
            // 
            // btnGoToXY
            // 
            this.superAccelerator1.SetAccelerator(this.btnGoToXY, "G");
            resources.ApplyResources(this.btnGoToXY, "btnGoToXY");
            this.btnGoToXY.Image = global::MW5.Properties.Resources.定位;
            this.btnGoToXY.Name = "btnGoToXY";
            this.SetShortcut(this.btnGoToXY, System.Windows.Forms.Keys.None);
            this.btnGoToXY.Tag = "GoToXY";
            // 
            // toolStripPanelItem_Browse
            // 
            resources.ApplyResources(this.toolStripPanelItem_Browse, "toolStripPanelItem_Browse");
            this.toolStripPanelItem_Browse.CausesValidation = false;
            this.toolStripPanelItem_Browse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem_Browse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewZoomIn,
            this.btnZoomPrev,
            this.btnZoomMax,
            this.btnZoomOut,
            this.btnZoomNext,
            this.btnPan});
            this.toolStripPanelItem_Browse.Name = "toolStripPanelItem_Browse";
            this.SetShortcut(this.toolStripPanelItem_Browse, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem_Browse.Transparent = true;
            // 
            // btnViewZoomIn
            // 
            this.superAccelerator1.SetAccelerator(this.btnViewZoomIn, "O");
            resources.ApplyResources(this.btnViewZoomIn, "btnViewZoomIn");
            this.btnViewZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViewZoomIn.Image = global::MW5.Properties.Resources.放大;
            this.btnViewZoomIn.Name = "btnViewZoomIn";
            this.SetShortcut(this.btnViewZoomIn, System.Windows.Forms.Keys.None);
            // 
            // btnZoomPrev
            // 
            this.superAccelerator1.SetAccelerator(this.btnZoomPrev, "P");
            resources.ApplyResources(this.btnZoomPrev, "btnZoomPrev");
            this.btnZoomPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomPrev.Image = global::MW5.Properties.Resources.前视图;
            this.btnZoomPrev.Name = "btnZoomPrev";
            this.SetShortcut(this.btnZoomPrev, System.Windows.Forms.Keys.None);
            this.btnZoomPrev.Tag = "ZoomPrev";
            // 
            // btnZoomMax
            // 
            this.superAccelerator1.SetAccelerator(this.btnZoomMax, "AA");
            resources.ApplyResources(this.btnZoomMax, "btnZoomMax");
            this.btnZoomMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomMax.Image = global::MW5.Properties.Resources.全图;
            this.btnZoomMax.Name = "btnZoomMax";
            this.SetShortcut(this.btnZoomMax, System.Windows.Forms.Keys.None);
            // 
            // btnZoomOut
            // 
            this.superAccelerator1.SetAccelerator(this.btnZoomOut, "I");
            resources.ApplyResources(this.btnZoomOut, "btnZoomOut");
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = global::MW5.Properties.Resources.缩小;
            this.btnZoomOut.Name = "btnZoomOut";
            this.SetShortcut(this.btnZoomOut, System.Windows.Forms.Keys.None);
            // 
            // btnZoomNext
            // 
            this.superAccelerator1.SetAccelerator(this.btnZoomNext, "N");
            resources.ApplyResources(this.btnZoomNext, "btnZoomNext");
            this.btnZoomNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomNext.Image = global::MW5.Properties.Resources.后视图;
            this.btnZoomNext.Name = "btnZoomNext";
            this.SetShortcut(this.btnZoomNext, System.Windows.Forms.Keys.None);
            this.btnZoomNext.Tag = "ZoomNext";
            // 
            // btnPan
            // 
            this.superAccelerator1.SetAccelerator(this.btnPan, "W");
            resources.ApplyResources(this.btnPan, "btnPan");
            this.btnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPan.Name = "btnPan";
            this.SetShortcut(this.btnPan, System.Windows.Forms.Keys.None);
            this.btnPan.Tag = "Pan";
            // 
            // toolStripEx_Selection
            // 
            resources.ApplyResources(this.toolStripEx_Selection, "toolStripEx_Selection");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx_Selection, null);
            this.toolStripEx_Selection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx_Selection.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx_Selection.Image = null;
            this.toolStripEx_Selection.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx_Selection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectFeature,
            this.btnSelectionByLocation,
            this.toolStripPanelItem_Select});
            this.toolStripEx_Selection.Name = "toolStripEx_Selection";
            this.toolStripEx_Selection.Office12Mode = false;
            this.toolStripEx_Selection.ShowLauncher = false;
            // 
            // btnSelectFeature
            // 
            this.superAccelerator1.SetAccelerator(this.btnSelectFeature, "SF");
            resources.ApplyResources(this.btnSelectFeature, "btnSelectFeature");
            this.btnSelectFeature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectByRectangle,
            this.btnSelectByPolygon});
            this.btnSelectFeature.Image = global::MW5.Properties.Resources.选择;
            this.btnSelectFeature.Name = "btnSelectFeature";
            this.SetShortcut(this.btnSelectFeature, System.Windows.Forms.Keys.None);
            this.btnSelectFeature.Tag = "SelectByRectangle";
            this.btnSelectFeature.Click += new System.EventHandler(this.btnSelectFeature_Click);
            // 
            // btnSelectByRectangle
            // 
            resources.ApplyResources(this.btnSelectByRectangle, "btnSelectByRectangle");
            this.btnSelectByRectangle.Image = global::MW5.Properties.Resources.选择;
            this.btnSelectByRectangle.Name = "btnSelectByRectangle";
            this.SetShortcut(this.btnSelectByRectangle, System.Windows.Forms.Keys.None);
            // 
            // btnSelectByPolygon
            // 
            resources.ApplyResources(this.btnSelectByPolygon, "btnSelectByPolygon");
            this.btnSelectByPolygon.Name = "btnSelectByPolygon";
            this.SetShortcut(this.btnSelectByPolygon, System.Windows.Forms.Keys.None);
            this.btnSelectByPolygon.Tag = "SelectByPolygon";
            // 
            // btnSelectionByLocation
            // 
            this.superAccelerator1.SetAccelerator(this.btnSelectionByLocation, "SS");
            resources.ApplyResources(this.btnSelectionByLocation, "btnSelectionByLocation");
            this.btnSelectionByLocation.Image = global::MW5.Properties.Resources.空间选择;
            this.btnSelectionByLocation.Name = "btnSelectionByLocation";
            this.SetShortcut(this.btnSelectionByLocation, System.Windows.Forms.Keys.None);
            this.btnSelectionByLocation.Tag = "SelectionByLocation";
            // 
            // toolStripPanelItem_Select
            // 
            resources.ApplyResources(this.toolStripPanelItem_Select, "toolStripPanelItem_Select");
            this.toolStripPanelItem_Select.CausesValidation = false;
            this.toolStripPanelItem_Select.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem_Select.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectionByAttribute,
            this.btnClearSelection,
            this.btnZoomToSelected});
            this.toolStripPanelItem_Select.Name = "toolStripPanelItem_Select";
            this.SetShortcut(this.toolStripPanelItem_Select, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem_Select.Transparent = true;
            // 
            // btnSelectionByAttribute
            // 
            this.superAccelerator1.SetAccelerator(this.btnSelectionByAttribute, "SC");
            resources.ApplyResources(this.btnSelectionByAttribute, "btnSelectionByAttribute");
            this.btnSelectionByAttribute.Image = global::MW5.Properties.Resources.条件选择;
            this.btnSelectionByAttribute.Name = "btnSelectionByAttribute";
            this.SetShortcut(this.btnSelectionByAttribute, System.Windows.Forms.Keys.None);
            this.btnSelectionByAttribute.Tag = "SelectionByAttribute";
            // 
            // btnClearSelection
            // 
            this.superAccelerator1.SetAccelerator(this.btnClearSelection, "SR");
            resources.ApplyResources(this.btnClearSelection, "btnClearSelection");
            this.btnClearSelection.BackColor = System.Drawing.SystemColors.Window;
            this.btnClearSelection.Image = global::MW5.Properties.Resources.全不选;
            this.btnClearSelection.Name = "btnClearSelection";
            this.SetShortcut(this.btnClearSelection, System.Windows.Forms.Keys.None);
            this.btnClearSelection.Tag = "ClearSelection";
            // 
            // btnZoomToSelected
            // 
            this.superAccelerator1.SetAccelerator(this.btnZoomToSelected, "ZS");
            resources.ApplyResources(this.btnZoomToSelected, "btnZoomToSelected");
            this.btnZoomToSelected.Image = global::MW5.Properties.Resources.缩放到已选;
            this.btnZoomToSelected.Name = "btnZoomToSelected";
            this.SetShortcut(this.btnZoomToSelected, System.Windows.Forms.Keys.None);
            this.btnZoomToSelected.Tag = "ZoomToSelected";
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Body.Text = resources.GetString("resource.Text");
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Footer.Text = resources.GetString("resource.Text1");
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = resources.GetString("resource.Text2");
            this.superToolTip1.SetToolTip(this.btnZoomToSelected, toolTipInfo1);
            // 
            // toolStripEx12
            // 
            resources.ApplyResources(this.toolStripEx12, "toolStripEx12");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx12, null);
            this.toolStripEx12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx12.Image = null;
            this.toolStripEx12.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMeasure,
            this.btnSwipeTool,
            this.btnPictureViewer,
            this.toolStripPanelItem_Symbol});
            this.toolStripEx12.Name = "toolStripEx12";
            this.toolStripEx12.Office12Mode = false;
            this.toolStripEx12.ShowLauncher = false;
            // 
            // btnMeasure
            // 
            resources.ApplyResources(this.btnMeasure, "btnMeasure");
            this.btnMeasure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMeasureDistance,
            this.btnMeasureArea});
            this.btnMeasure.Image = global::MW5.Properties.Resources.距离测量;
            this.btnMeasure.Name = "btnMeasure";
            this.SetShortcut(this.btnMeasure, System.Windows.Forms.Keys.None);
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnMeasureDistance
            // 
            resources.ApplyResources(this.btnMeasureDistance, "btnMeasureDistance");
            this.btnMeasureDistance.Name = "btnMeasureDistance";
            this.SetShortcut(this.btnMeasureDistance, System.Windows.Forms.Keys.None);
            // 
            // btnMeasureArea
            // 
            resources.ApplyResources(this.btnMeasureArea, "btnMeasureArea");
            this.btnMeasureArea.Image = global::MW5.Properties.Resources.面积测量;
            this.btnMeasureArea.Name = "btnMeasureArea";
            this.SetShortcut(this.btnMeasureArea, System.Windows.Forms.Keys.None);
            // 
            // btnSwipeTool
            // 
            this.superAccelerator1.SetAccelerator(this.btnSwipeTool, "SW");
            resources.ApplyResources(this.btnSwipeTool, "btnSwipeTool");
            this.btnSwipeTool.Image = global::MW5.Properties.Resources.卷帘;
            this.btnSwipeTool.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSwipeTool.Name = "btnSwipeTool";
            this.SetShortcut(this.btnSwipeTool, System.Windows.Forms.Keys.None);
            this.btnSwipeTool.Tag = "SwipeTool";
            // 
            // btnPictureViewer
            // 
            resources.ApplyResources(this.btnPictureViewer, "btnPictureViewer");
            this.btnPictureViewer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPictureViewSetting});
            this.btnPictureViewer.Image = global::MW5.Properties.Resources.小班照片;
            this.btnPictureViewer.Name = "btnPictureViewer";
            this.SetShortcut(this.btnPictureViewer, System.Windows.Forms.Keys.None);
            // 
            // btnPictureViewSetting
            // 
            resources.ApplyResources(this.btnPictureViewSetting, "btnPictureViewSetting");
            this.btnPictureViewSetting.Name = "btnPictureViewSetting";
            this.SetShortcut(this.btnPictureViewSetting, System.Windows.Forms.Keys.None);
            // 
            // toolStripPanelItem_Symbol
            // 
            resources.ApplyResources(this.toolStripPanelItem_Symbol, "toolStripPanelItem_Symbol");
            this.toolStripPanelItem_Symbol.CausesValidation = false;
            this.toolStripPanelItem_Symbol.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem_Symbol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnip_IdentifyTool,
            this.btnSY_LabelMover,
            this.btnSY_SymbolRotator});
            this.toolStripPanelItem_Symbol.Name = "toolStripPanelItem_Symbol";
            this.SetShortcut(this.toolStripPanelItem_Symbol, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem_Symbol.Transparent = true;
            // 
            // btnip_IdentifyTool
            // 
            resources.ApplyResources(this.btnip_IdentifyTool, "btnip_IdentifyTool");
            this.btnip_IdentifyTool.Name = "btnip_IdentifyTool";
            this.SetShortcut(this.btnip_IdentifyTool, System.Windows.Forms.Keys.None);
            this.btnip_IdentifyTool.Tag = "ip_IdentifyTool";
            // 
            // btnSY_LabelMover
            // 
            resources.ApplyResources(this.btnSY_LabelMover, "btnSY_LabelMover");
            this.btnSY_LabelMover.Image = global::MW5.Properties.Resources.标签移动标签;
            this.btnSY_LabelMover.Name = "btnSY_LabelMover";
            this.SetShortcut(this.btnSY_LabelMover, System.Windows.Forms.Keys.None);
            this.btnSY_LabelMover.Tag = "sy_LabelMover";
            // 
            // btnSY_SymbolRotator
            // 
            resources.ApplyResources(this.btnSY_SymbolRotator, "btnSY_SymbolRotator");
            this.btnSY_SymbolRotator.Name = "btnSY_SymbolRotator";
            this.SetShortcut(this.btnSY_SymbolRotator, System.Windows.Forms.Keys.None);
            this.btnSY_SymbolRotator.Tag = "sy_SymbolRotator";
            // 
            // toolStripTabItem_Edit
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem_Edit, "E");
            resources.ApplyResources(this.toolStripTabItem_Edit, "toolStripTabItem_Edit");
            this.toolStripTabItem_Edit.Name = "toolStripTabItem_Edit";
            // 
            // ribbonControlAdv_Main.ribbonPanel2
            // 
            resources.ApplyResources(this.toolStripTabItem_Edit.Panel, "ribbonControlAdv_Main.ribbonPanel2");
            this.toolStripTabItem_Edit.Panel.Controls.Add(this.toolStripEx_Edit);
            this.toolStripTabItem_Edit.Panel.Controls.Add(this.toolStripEx14);
            this.toolStripTabItem_Edit.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem_Edit.Panel.ScrollPosition = 0;
            this.toolStripTabItem_Edit.Position = 1;
            this.SetShortcut(this.toolStripTabItem_Edit, System.Windows.Forms.Keys.None);
            this.toolStripTabItem_Edit.Tag = "3";
            // 
            // toolStripEx_Edit
            // 
            resources.ApplyResources(this.toolStripEx_Edit, "toolStripEx_Edit");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx_Edit, null);
            this.toolStripEx_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx_Edit.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx_Edit.Image = null;
            this.toolStripEx_Edit.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx_Edit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSE_LayerEdit,
            this.toolStripSeparator7,
            this.btnSE_GeometryCreate,
            this.btnSE_VertexEditor,
            this.toolStripSeparator6,
            this.btnSE_SplitShapes,
            this.btnSE_MergeShapes,
            this.btnSE_MoveShapes,
            this.btnSE_RotateShapes,
            this.toolStripSeparator9,
            this.btnSE_CopyAttributes,
            this.btnSE_PasteAttributes,
            this.toolStripSeparator8,
            this.btnSE_Copy,
            this.btnSE_Paste,
            this.btnSE_Cut,
            this.btnSE_DeleteSelected,
            this.toolStripSeparator11,
            this.btnSE_SplitByPolygon,
            this.btnSE_SplitByPolyline,
            this.toolStripSeparator1,
            this.btnSE_Undo,
            this.txtHistoryLength,
            this.btnSE_Redo});
            this.toolStripEx_Edit.Name = "toolStripEx_Edit";
            this.toolStripEx_Edit.Office12Mode = false;
            this.toolStripEx_Edit.ShowLauncher = false;
            // 
            // btnSE_LayerEdit
            // 
            resources.ApplyResources(this.btnSE_LayerEdit, "btnSE_LayerEdit");
            this.btnSE_LayerEdit.Name = "btnSE_LayerEdit";
            this.SetShortcut(this.btnSE_LayerEdit, System.Windows.Forms.Keys.None);
            this.btnSE_LayerEdit.Tag = "SE_LayerEdit";
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.SetShortcut(this.toolStripSeparator7, System.Windows.Forms.Keys.None);
            // 
            // btnSE_GeometryCreate
            // 
            resources.ApplyResources(this.btnSE_GeometryCreate, "btnSE_GeometryCreate");
            this.btnSE_GeometryCreate.Image = global::MW5.Properties.Resources.新建要素;
            this.btnSE_GeometryCreate.Name = "btnSE_GeometryCreate";
            this.SetShortcut(this.btnSE_GeometryCreate, System.Windows.Forms.Keys.None);
            this.btnSE_GeometryCreate.Tag = "SE_GeometryCreate";
            // 
            // btnSE_VertexEditor
            // 
            resources.ApplyResources(this.btnSE_VertexEditor, "btnSE_VertexEditor");
            this.btnSE_VertexEditor.Image = global::MW5.Properties.Resources.顶点编辑;
            this.btnSE_VertexEditor.Name = "btnSE_VertexEditor";
            this.SetShortcut(this.btnSE_VertexEditor, System.Windows.Forms.Keys.None);
            this.btnSE_VertexEditor.Tag = "SE_VertexEditor";
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.SetShortcut(this.toolStripSeparator6, System.Windows.Forms.Keys.None);
            // 
            // btnSE_SplitShapes
            // 
            resources.ApplyResources(this.btnSE_SplitShapes, "btnSE_SplitShapes");
            this.btnSE_SplitShapes.Image = global::MW5.Properties.Resources.拆分;
            this.btnSE_SplitShapes.Name = "btnSE_SplitShapes";
            this.SetShortcut(this.btnSE_SplitShapes, System.Windows.Forms.Keys.None);
            this.btnSE_SplitShapes.Tag = "SE_SplitShapes";
            // 
            // btnSE_MergeShapes
            // 
            resources.ApplyResources(this.btnSE_MergeShapes, "btnSE_MergeShapes");
            this.btnSE_MergeShapes.Image = global::MW5.Properties.Resources.合并;
            this.btnSE_MergeShapes.Name = "btnSE_MergeShapes";
            this.SetShortcut(this.btnSE_MergeShapes, System.Windows.Forms.Keys.None);
            this.btnSE_MergeShapes.Tag = "SE_MergeShapes";
            // 
            // btnSE_MoveShapes
            // 
            resources.ApplyResources(this.btnSE_MoveShapes, "btnSE_MoveShapes");
            this.btnSE_MoveShapes.Image = global::MW5.Properties.Resources.移动;
            this.btnSE_MoveShapes.Name = "btnSE_MoveShapes";
            this.SetShortcut(this.btnSE_MoveShapes, System.Windows.Forms.Keys.None);
            this.btnSE_MoveShapes.Tag = "SE_RotateShapes";
            // 
            // btnSE_RotateShapes
            // 
            resources.ApplyResources(this.btnSE_RotateShapes, "btnSE_RotateShapes");
            this.btnSE_RotateShapes.Image = global::MW5.Properties.Resources.旋转;
            this.btnSE_RotateShapes.Name = "btnSE_RotateShapes";
            this.SetShortcut(this.btnSE_RotateShapes, System.Windows.Forms.Keys.None);
            this.btnSE_RotateShapes.Tag = "SE_RotateShapes";
            // 
            // toolStripSeparator9
            // 
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.SetShortcut(this.toolStripSeparator9, System.Windows.Forms.Keys.None);
            // 
            // btnSE_CopyAttributes
            // 
            resources.ApplyResources(this.btnSE_CopyAttributes, "btnSE_CopyAttributes");
            this.btnSE_CopyAttributes.DoubleClickEnabled = true;
            this.btnSE_CopyAttributes.Image = global::MW5.Properties.Resources.属性复制;
            this.btnSE_CopyAttributes.Name = "btnSE_CopyAttributes";
            this.SetShortcut(this.btnSE_CopyAttributes, System.Windows.Forms.Keys.None);
            this.btnSE_CopyAttributes.Tag = "SE_CopyAttributes";
            // 
            // btnSE_PasteAttributes
            // 
            resources.ApplyResources(this.btnSE_PasteAttributes, "btnSE_PasteAttributes");
            this.btnSE_PasteAttributes.Image = global::MW5.Properties.Resources.属性粘贴;
            this.btnSE_PasteAttributes.Name = "btnSE_PasteAttributes";
            this.SetShortcut(this.btnSE_PasteAttributes, System.Windows.Forms.Keys.None);
            this.btnSE_PasteAttributes.Tag = "SE_PasteAttributes";
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.SetShortcut(this.toolStripSeparator8, System.Windows.Forms.Keys.None);
            // 
            // btnSE_Copy
            // 
            resources.ApplyResources(this.btnSE_Copy, "btnSE_Copy");
            this.btnSE_Copy.Image = global::MW5.Properties.Resources.复制;
            this.btnSE_Copy.Name = "btnSE_Copy";
            this.SetShortcut(this.btnSE_Copy, System.Windows.Forms.Keys.None);
            this.btnSE_Copy.Tag = "SE_Copy";
            // 
            // btnSE_Paste
            // 
            resources.ApplyResources(this.btnSE_Paste, "btnSE_Paste");
            this.btnSE_Paste.Image = global::MW5.Properties.Resources.粘贴;
            this.btnSE_Paste.Name = "btnSE_Paste";
            this.SetShortcut(this.btnSE_Paste, System.Windows.Forms.Keys.None);
            this.btnSE_Paste.Tag = "SE_Paste";
            // 
            // btnSE_Cut
            // 
            resources.ApplyResources(this.btnSE_Cut, "btnSE_Cut");
            this.btnSE_Cut.Image = global::MW5.Properties.Resources.剪切;
            this.btnSE_Cut.Name = "btnSE_Cut";
            this.SetShortcut(this.btnSE_Cut, System.Windows.Forms.Keys.None);
            this.btnSE_Cut.Tag = "SE_Cut";
            // 
            // btnSE_DeleteSelected
            // 
            resources.ApplyResources(this.btnSE_DeleteSelected, "btnSE_DeleteSelected");
            this.btnSE_DeleteSelected.Image = global::MW5.Properties.Resources.删除;
            this.btnSE_DeleteSelected.Name = "btnSE_DeleteSelected";
            this.SetShortcut(this.btnSE_DeleteSelected, System.Windows.Forms.Keys.None);
            this.btnSE_DeleteSelected.Tag = "SE_DeleteSelected";
            // 
            // toolStripSeparator11
            // 
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.SetShortcut(this.toolStripSeparator11, System.Windows.Forms.Keys.None);
            // 
            // btnSE_SplitByPolygon
            // 
            resources.ApplyResources(this.btnSE_SplitByPolygon, "btnSE_SplitByPolygon");
            this.btnSE_SplitByPolygon.AutoToolTip = true;
            this.btnSE_SplitByPolygon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSE_EraseByPolygon,
            this.btnSE_ClipByPolygon});
            this.btnSE_SplitByPolygon.Image = global::MW5.Properties.Resources.多边形分割;
            this.btnSE_SplitByPolygon.Name = "btnSE_SplitByPolygon";
            this.SetShortcut(this.btnSE_SplitByPolygon, System.Windows.Forms.Keys.None);
            // 
            // btnSE_EraseByPolygon
            // 
            resources.ApplyResources(this.btnSE_EraseByPolygon, "btnSE_EraseByPolygon");
            this.btnSE_EraseByPolygon.AutoToolTip = true;
            this.btnSE_EraseByPolygon.Name = "btnSE_EraseByPolygon";
            this.SetShortcut(this.btnSE_EraseByPolygon, System.Windows.Forms.Keys.None);
            this.btnSE_EraseByPolygon.Tag = "SE_EraseByPolygon";
            // 
            // btnSE_ClipByPolygon
            // 
            resources.ApplyResources(this.btnSE_ClipByPolygon, "btnSE_ClipByPolygon");
            this.btnSE_ClipByPolygon.AutoToolTip = true;
            this.btnSE_ClipByPolygon.Name = "btnSE_ClipByPolygon";
            this.SetShortcut(this.btnSE_ClipByPolygon, System.Windows.Forms.Keys.None);
            this.btnSE_ClipByPolygon.Tag = "SE_ClipByPolygon";
            // 
            // btnSE_SplitByPolyline
            // 
            resources.ApplyResources(this.btnSE_SplitByPolyline, "btnSE_SplitByPolyline");
            this.btnSE_SplitByPolyline.Image = global::MW5.Properties.Resources.线分割;
            this.btnSE_SplitByPolyline.Name = "btnSE_SplitByPolyline";
            this.SetShortcut(this.btnSE_SplitByPolyline, System.Windows.Forms.Keys.None);
            this.btnSE_SplitByPolyline.Tag = "SE_SplitByPolyline";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.SetShortcut(this.toolStripSeparator1, System.Windows.Forms.Keys.None);
            // 
            // btnSE_Undo
            // 
            resources.ApplyResources(this.btnSE_Undo, "btnSE_Undo");
            this.btnSE_Undo.Image = global::MW5.Properties.Resources.撤销;
            this.btnSE_Undo.Name = "btnSE_Undo";
            this.SetShortcut(this.btnSE_Undo, System.Windows.Forms.Keys.None);
            this.btnSE_Undo.Tag = "SE_Undo";
            // 
            // txtHistoryLength
            // 
            resources.ApplyResources(this.txtHistoryLength, "txtHistoryLength");
            this.txtHistoryLength.Name = "txtHistoryLength";
            this.SetShortcut(this.txtHistoryLength, System.Windows.Forms.Keys.None);
            // 
            // btnSE_Redo
            // 
            resources.ApplyResources(this.btnSE_Redo, "btnSE_Redo");
            this.btnSE_Redo.Image = global::MW5.Properties.Resources.重做;
            this.btnSE_Redo.Name = "btnSE_Redo";
            this.SetShortcut(this.btnSE_Redo, System.Windows.Forms.Keys.None);
            this.btnSE_Redo.Tag = "SE_Redo";
            // 
            // toolStripEx14
            // 
            resources.ApplyResources(this.toolStripEx14, "toolStripEx14");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx14, null);
            this.toolStripEx14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx14.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx14.Image = null;
            this.toolStripEx14.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx14.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSE_SnapToVertices,
            this.btnSE_SnapToSegments,
            this.btnSE_SnapToActiveLayer,
            this.btnSE_SnapToAllLayers});
            this.toolStripEx14.Name = "toolStripEx14";
            this.toolStripEx14.Office12Mode = false;
            this.toolStripEx14.ShowLauncher = false;
            // 
            // btnSE_SnapToVertices
            // 
            resources.ApplyResources(this.btnSE_SnapToVertices, "btnSE_SnapToVertices");
            this.btnSE_SnapToVertices.Image = global::MW5.Properties.Resources.顶点;
            this.btnSE_SnapToVertices.Name = "btnSE_SnapToVertices";
            this.SetShortcut(this.btnSE_SnapToVertices, System.Windows.Forms.Keys.None);
            this.btnSE_SnapToVertices.Tag = "SE_SnapToVertices";
            // 
            // btnSE_SnapToSegments
            // 
            resources.ApplyResources(this.btnSE_SnapToSegments, "btnSE_SnapToSegments");
            this.btnSE_SnapToSegments.Image = global::MW5.Properties.Resources.间断点;
            this.btnSE_SnapToSegments.Name = "btnSE_SnapToSegments";
            this.SetShortcut(this.btnSE_SnapToSegments, System.Windows.Forms.Keys.None);
            this.btnSE_SnapToSegments.Tag = "SE_SnapToSegments";
            // 
            // btnSE_SnapToActiveLayer
            // 
            resources.ApplyResources(this.btnSE_SnapToActiveLayer, "btnSE_SnapToActiveLayer");
            this.btnSE_SnapToActiveLayer.Image = global::MW5.Properties.Resources.当前层;
            this.btnSE_SnapToActiveLayer.Name = "btnSE_SnapToActiveLayer";
            this.SetShortcut(this.btnSE_SnapToActiveLayer, System.Windows.Forms.Keys.None);
            this.btnSE_SnapToActiveLayer.Tag = "SE_SnapToActiveLayer";
            // 
            // btnSE_SnapToAllLayers
            // 
            resources.ApplyResources(this.btnSE_SnapToAllLayers, "btnSE_SnapToAllLayers");
            this.btnSE_SnapToAllLayers.Image = global::MW5.Properties.Resources.所有层;
            this.btnSE_SnapToAllLayers.Name = "btnSE_SnapToAllLayers";
            this.SetShortcut(this.btnSE_SnapToAllLayers, System.Windows.Forms.Keys.None);
            this.btnSE_SnapToAllLayers.Tag = "SE_SnapToAllLayers";
            // 
            // toolStripTabItem_Help
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem_Help, "H");
            resources.ApplyResources(this.toolStripTabItem_Help, "toolStripTabItem_Help");
            this.toolStripTabItem_Help.Name = "toolStripTabItem_Help";
            // 
            // ribbonControlAdv_Main.ribbonPanel4
            // 
            resources.ApplyResources(this.toolStripTabItem_Help.Panel, "ribbonControlAdv_Main.ribbonPanel4");
            this.toolStripTabItem_Help.Panel.Controls.Add(this.toolStripEx6);
            this.toolStripTabItem_Help.Panel.Controls.Add(this.toolStripEx7);
            this.toolStripTabItem_Help.Panel.Controls.Add(this.toolStripEx16);
            this.toolStripTabItem_Help.Panel.Controls.Add(this.toolStripEx_About);
            this.toolStripTabItem_Help.Panel.Name = "ribbonPanel4";
            this.toolStripTabItem_Help.Panel.ScrollPosition = 0;
            this.toolStripTabItem_Help.Position = 3;
            this.SetShortcut(this.toolStripTabItem_Help, System.Windows.Forms.Keys.None);
            this.toolStripTabItem_Help.Tag = "4";
            // 
            // toolStripEx6
            // 
            resources.ApplyResources(this.toolStripEx6, "toolStripEx6");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx6, null);
            this.toolStripEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx6.Image = null;
            this.toolStripEx6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem2});
            this.toolStripEx6.Name = "toolStripEx6";
            this.toolStripEx6.Office12Mode = false;
            this.toolStripEx6.ShowLauncher = false;
            // 
            // toolStripPanelItem2
            // 
            resources.ApplyResources(this.toolStripPanelItem2, "toolStripPanelItem2");
            this.toolStripPanelItem2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowZoombar,
            this.btnShowScalebar,
            this.btnShowCoordinates,
            this.btnShowRedrawTime});
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.RowCount = 2;
            this.SetShortcut(this.toolStripPanelItem2, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem2.Transparent = true;
            // 
            // btnShowZoombar
            // 
            resources.ApplyResources(this.btnShowZoombar, "btnShowZoombar");
            this.btnShowZoombar.Name = "btnShowZoombar";
            this.SetShortcut(this.btnShowZoombar, System.Windows.Forms.Keys.None);
            this.btnShowZoombar.Tag = "ShowZoombar";
            // 
            // btnShowScalebar
            // 
            resources.ApplyResources(this.btnShowScalebar, "btnShowScalebar");
            this.btnShowScalebar.Name = "btnShowScalebar";
            this.SetShortcut(this.btnShowScalebar, System.Windows.Forms.Keys.None);
            this.btnShowScalebar.Tag = "ShowScalebar";
            // 
            // btnShowCoordinates
            // 
            resources.ApplyResources(this.btnShowCoordinates, "btnShowCoordinates");
            this.btnShowCoordinates.Name = "btnShowCoordinates";
            this.SetShortcut(this.btnShowCoordinates, System.Windows.Forms.Keys.None);
            this.btnShowCoordinates.Tag = "ShowCoordinates";
            // 
            // btnShowRedrawTime
            // 
            resources.ApplyResources(this.btnShowRedrawTime, "btnShowRedrawTime");
            this.btnShowRedrawTime.Name = "btnShowRedrawTime";
            this.SetShortcut(this.btnShowRedrawTime, System.Windows.Forms.Keys.None);
            this.btnShowRedrawTime.Tag = "ShowRedrawTime";
            // 
            // toolStripEx7
            // 
            resources.ApplyResources(this.toolStripEx7, "toolStripEx7");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx7, null);
            this.toolStripEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx7.Image = null;
            this.toolStripEx7.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem4});
            this.toolStripEx7.Name = "toolStripEx7";
            this.toolStripEx7.Office12Mode = false;
            this.toolStripEx7.ShowLauncher = false;
            // 
            // toolStripPanelItem4
            // 
            resources.ApplyResources(this.toolStripPanelItem4, "toolStripPanelItem4");
            this.toolStripPanelItem4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripPanelItem4.CausesValidation = false;
            this.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewPropertiesTable,
            this.btnViewRepository,
            this.btnViewDebugger,
            this.btnViewToolbox,
            this.btnViewContents,
            this.btnViewTasks,
            this.btnViewIdentity,
            this.btnViewTheme,
            this.btnViewAttributeChecker});
            this.toolStripPanelItem4.Name = "toolStripPanelItem4";
            this.toolStripPanelItem4.RowCount = 2;
            this.SetShortcut(this.toolStripPanelItem4, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem4.Transparent = true;
            // 
            // btnViewPropertiesTable
            // 
            resources.ApplyResources(this.btnViewPropertiesTable, "btnViewPropertiesTable");
            this.btnViewPropertiesTable.Name = "btnViewPropertiesTable";
            this.SetShortcut(this.btnViewPropertiesTable, System.Windows.Forms.Keys.None);
            this.btnViewPropertiesTable.Tag = "编辑属性表";
            // 
            // btnViewRepository
            // 
            resources.ApplyResources(this.btnViewRepository, "btnViewRepository");
            this.btnViewRepository.Name = "btnViewRepository";
            this.SetShortcut(this.btnViewRepository, System.Windows.Forms.Keys.None);
            this.btnViewRepository.Tag = "存储库";
            // 
            // btnViewDebugger
            // 
            resources.ApplyResources(this.btnViewDebugger, "btnViewDebugger");
            this.btnViewDebugger.Name = "btnViewDebugger";
            this.SetShortcut(this.btnViewDebugger, System.Windows.Forms.Keys.None);
            this.btnViewDebugger.Tag = "日志";
            // 
            // btnViewToolbox
            // 
            resources.ApplyResources(this.btnViewToolbox, "btnViewToolbox");
            this.btnViewToolbox.Name = "btnViewToolbox";
            this.SetShortcut(this.btnViewToolbox, System.Windows.Forms.Keys.None);
            this.btnViewToolbox.Tag = "工具箱";
            // 
            // btnViewContents
            // 
            resources.ApplyResources(this.btnViewContents, "btnViewContents");
            this.btnViewContents.Name = "btnViewContents";
            this.SetShortcut(this.btnViewContents, System.Windows.Forms.Keys.None);
            this.btnViewContents.Tag = "内容列表";
            // 
            // btnViewTasks
            // 
            resources.ApplyResources(this.btnViewTasks, "btnViewTasks");
            this.btnViewTasks.Name = "btnViewTasks";
            this.SetShortcut(this.btnViewTasks, System.Windows.Forms.Keys.None);
            this.btnViewTasks.Tag = "任务";
            // 
            // btnViewIdentity
            // 
            resources.ApplyResources(this.btnViewIdentity, "btnViewIdentity");
            this.btnViewIdentity.Name = "btnViewIdentity";
            this.SetShortcut(this.btnViewIdentity, System.Windows.Forms.Keys.None);
            this.btnViewIdentity.Tag = "识别";
            // 
            // btnViewTheme
            // 
            resources.ApplyResources(this.btnViewTheme, "btnViewTheme");
            this.btnViewTheme.Name = "btnViewTheme";
            this.SetShortcut(this.btnViewTheme, System.Windows.Forms.Keys.None);
            this.btnViewTheme.Tag = "缩略图";
            // 
            // btnViewAttributeChecker
            // 
            resources.ApplyResources(this.btnViewAttributeChecker, "btnViewAttributeChecker");
            this.btnViewAttributeChecker.Name = "btnViewAttributeChecker";
            this.SetShortcut(this.btnViewAttributeChecker, System.Windows.Forms.Keys.None);
            this.btnViewAttributeChecker.Tag = "属性检查";
            // 
            // toolStripEx16
            // 
            resources.ApplyResources(this.toolStripEx16, "toolStripEx16");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx16, null);
            this.toolStripEx16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx16.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx16.Image = null;
            this.toolStripEx16.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx16.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem1});
            this.toolStripEx16.Name = "toolStripEx16";
            this.toolStripEx16.Office12Mode = false;
            this.toolStripEx16.ShowLauncher = false;
            // 
            // toolStripPanelItem1
            // 
            resources.ApplyResources(this.toolStripPanelItem1, "toolStripPanelItem1");
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowTiles});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.SetShortcut(this.toolStripPanelItem1, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem1.Transparent = true;
            // 
            // btnShowTiles
            // 
            resources.ApplyResources(this.btnShowTiles, "btnShowTiles");
            this.btnShowTiles.Name = "btnShowTiles";
            this.SetShortcut(this.btnShowTiles, System.Windows.Forms.Keys.None);
            this.btnShowTiles.Tag = "加载底图";
            // 
            // toolStripEx_About
            // 
            resources.ApplyResources(this.toolStripEx_About, "toolStripEx_About");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx_About, null);
            this.toolStripEx_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx_About.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx_About.Image = null;
            this.toolStripEx_About.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx_About.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelpWelcome,
            this.btnHelpGuide,
            this.btnHelpAbout});
            this.toolStripEx_About.Name = "toolStripEx_About";
            this.toolStripEx_About.Office12Mode = false;
            this.toolStripEx_About.ShowLauncher = false;
            // 
            // btnHelpWelcome
            // 
            resources.ApplyResources(this.btnHelpWelcome, "btnHelpWelcome");
            this.btnHelpWelcome.Image = global::MW5.Properties.Resources.欢迎;
            this.btnHelpWelcome.Name = "btnHelpWelcome";
            this.SetShortcut(this.btnHelpWelcome, System.Windows.Forms.Keys.None);
            this.btnHelpWelcome.Tag = "HelpWelcome";
            // 
            // btnHelpGuide
            // 
            resources.ApplyResources(this.btnHelpGuide, "btnHelpGuide");
            this.btnHelpGuide.Image = global::MW5.Properties.Resources.手册;
            this.btnHelpGuide.Name = "btnHelpGuide";
            this.SetShortcut(this.btnHelpGuide, System.Windows.Forms.Keys.None);
            this.btnHelpGuide.Tag = "HelpGuide";
            // 
            // btnHelpAbout
            // 
            resources.ApplyResources(this.btnHelpAbout, "btnHelpAbout");
            this.btnHelpAbout.Image = global::MW5.Properties.Resources.关于;
            this.btnHelpAbout.Name = "btnHelpAbout";
            this.SetShortcut(this.btnHelpAbout, System.Windows.Forms.Keys.None);
            this.btnHelpAbout.Tag = "HelpAbout";
            // 
            // toolStripEx4
            // 
            resources.ApplyResources(this.toolStripEx4, "toolStripEx4");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx4, null);
            this.toolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx4.Image = null;
            this.toolStripEx4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx4.Name = "toolStripEx4";
            this.toolStripEx4.Office12Mode = false;
            // 
            // toolStripSplitButtonEx1
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripSplitButtonEx1, "RS");
            resources.ApplyResources(this.toolStripSplitButtonEx1, "toolStripSplitButtonEx1");
            this.toolStripSplitButtonEx1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemExt1});
            this.toolStripSplitButtonEx1.Image = global::MW5.Properties.Resources.icon_select;
            this.toolStripSplitButtonEx1.Name = "toolStripSplitButtonEx1";
            this.SetShortcut(this.toolStripSplitButtonEx1, System.Windows.Forms.Keys.None);
            this.toolStripSplitButtonEx1.Tag = "SelectByRectangle";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Image = global::MW5.Properties.Resources.icon_select;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.SetShortcut(this.toolStripMenuItem1, System.Windows.Forms.Keys.None);
            // 
            // toolStripMenuItemExt1
            // 
            resources.ApplyResources(this.toolStripMenuItemExt1, "toolStripMenuItemExt1");
            this.toolStripMenuItemExt1.Image = global::MW5.Properties.Resources.icon_select_by_polygon;
            this.toolStripMenuItemExt1.Name = "toolStripMenuItemExt1";
            this.SetShortcut(this.toolStripMenuItemExt1, System.Windows.Forms.Keys.None);
            this.toolStripMenuItemExt1.Tag = "SelectByPolygon";
            // 
            // toolStripEx1
            // 
            resources.ApplyResources(this.toolStripEx1, "toolStripEx1");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx1, null);
            this.toolStripEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTP_ShowTopologyRulesWindow,
            this.btn_XBPHTool,
            this.btn_ImageRegistrationTool});
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            // 
            // btnTP_ShowTopologyRulesWindow
            // 
            resources.ApplyResources(this.btnTP_ShowTopologyRulesWindow, "btnTP_ShowTopologyRulesWindow");
            this.btnTP_ShowTopologyRulesWindow.Image = global::MW5.Properties.Resources.拓扑检查;
            this.btnTP_ShowTopologyRulesWindow.Name = "btnTP_ShowTopologyRulesWindow";
            this.SetShortcut(this.btnTP_ShowTopologyRulesWindow, System.Windows.Forms.Keys.None);
            // 
            // btn_XBPHTool
            // 
            resources.ApplyResources(this.btn_XBPHTool, "btn_XBPHTool");
            this.btn_XBPHTool.Image = global::MW5.Properties.Resources.小班排号;
            this.btn_XBPHTool.Name = "btn_XBPHTool";
            this.SetShortcut(this.btn_XBPHTool, System.Windows.Forms.Keys.None);
            // 
            // btn_ImageRegistrationTool
            // 
            resources.ApplyResources(this.btn_ImageRegistrationTool, "btn_ImageRegistrationTool");
            this.btn_ImageRegistrationTool.Image = global::MW5.Properties.Resources.影像配准;
            this.btn_ImageRegistrationTool.Name = "btn_ImageRegistrationTool";
            this.SetShortcut(this.btn_ImageRegistrationTool, System.Windows.Forms.Keys.None);
            // 
            // toolStripEx2
            // 
            resources.ApplyResources(this.toolStripEx2, "toolStripEx2");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx2, null);
            this.toolStripEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TranslateRasterTool,
            this.btn_Ogr2OgrTool});
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            // 
            // btn_TranslateRasterTool
            // 
            resources.ApplyResources(this.btn_TranslateRasterTool, "btn_TranslateRasterTool");
            this.btn_TranslateRasterTool.Image = global::MW5.Properties.Resources.删格格式转换;
            this.btn_TranslateRasterTool.Name = "btn_TranslateRasterTool";
            this.SetShortcut(this.btn_TranslateRasterTool, System.Windows.Forms.Keys.None);
            // 
            // btn_Ogr2OgrTool
            // 
            resources.ApplyResources(this.btn_Ogr2OgrTool, "btn_Ogr2OgrTool");
            this.btn_Ogr2OgrTool.Image = global::MW5.Properties.Resources.矢量格式转换;
            this.btn_Ogr2OgrTool.Name = "btn_Ogr2OgrTool";
            this.SetShortcut(this.btn_Ogr2OgrTool, System.Windows.Forms.Keys.None);
            // 
            // toolStripEx3
            // 
            resources.ApplyResources(this.toolStripEx3, "toolStripEx3");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx3, null);
            this.toolStripEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx3.Image = null;
            this.toolStripEx3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_RasterReprojectTool,
            this.btn_ReprojectTool});
            this.toolStripEx3.Name = "toolStripEx3";
            this.toolStripEx3.Office12Mode = false;
            // 
            // btn_RasterReprojectTool
            // 
            resources.ApplyResources(this.btn_RasterReprojectTool, "btn_RasterReprojectTool");
            this.btn_RasterReprojectTool.Name = "btn_RasterReprojectTool";
            this.SetShortcut(this.btn_RasterReprojectTool, System.Windows.Forms.Keys.None);
            // 
            // btn_ReprojectTool
            // 
            resources.ApplyResources(this.btn_ReprojectTool, "btn_ReprojectTool");
            this.btn_ReprojectTool.Image = global::MW5.Properties.Resources.矢量数据重投影;
            this.btn_ReprojectTool.Name = "btn_ReprojectTool";
            this.SetShortcut(this.btn_ReprojectTool, System.Windows.Forms.Keys.None);
            // 
            // toolStripEx5
            // 
            resources.ApplyResources(this.toolStripEx5, "toolStripEx5");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx5, null);
            this.toolStripEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx5.Image = null;
            this.toolStripEx5.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AttributesCopyTool,
            this.btn_DissolveTool,
            this.btn_AggregateShapesTool});
            this.toolStripEx5.Name = "toolStripEx5";
            this.toolStripEx5.Office12Mode = false;
            // 
            // btn_AttributesCopyTool
            // 
            resources.ApplyResources(this.btn_AttributesCopyTool, "btn_AttributesCopyTool");
            this.btn_AttributesCopyTool.Image = global::MW5.Properties.Resources.属性提取;
            this.btn_AttributesCopyTool.Name = "btn_AttributesCopyTool";
            this.SetShortcut(this.btn_AttributesCopyTool, System.Windows.Forms.Keys.None);
            // 
            // btn_DissolveTool
            // 
            resources.ApplyResources(this.btn_DissolveTool, "btn_DissolveTool");
            this.btn_DissolveTool.Image = global::MW5.Properties.Resources.按属性合并;
            this.btn_DissolveTool.Name = "btn_DissolveTool";
            this.SetShortcut(this.btn_DissolveTool, System.Windows.Forms.Keys.None);
            // 
            // btn_AggregateShapesTool
            // 
            resources.ApplyResources(this.btn_AggregateShapesTool, "btn_AggregateShapesTool");
            this.btn_AggregateShapesTool.Image = global::MW5.Properties.Resources.按属性统计;
            this.btn_AggregateShapesTool.Name = "btn_AggregateShapesTool";
            this.SetShortcut(this.btn_AggregateShapesTool, System.Windows.Forms.Keys.None);
            // 
            // toolStripEx8
            // 
            resources.ApplyResources(this.toolStripEx8, "toolStripEx8");
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx8, null);
            this.toolStripEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx8.Image = null;
            this.toolStripEx8.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_LineToPolygonTool,
            this.btn_AreaMergeTool,
            this.btn_PolyToLineTool,
            this.btn_PolygonizeGridTool,
            this.btnShowCsvToShp});
            this.toolStripEx8.Name = "toolStripEx8";
            this.toolStripEx8.Office12Mode = false;
            // 
            // btn_LineToPolygonTool
            // 
            resources.ApplyResources(this.btn_LineToPolygonTool, "btn_LineToPolygonTool");
            this.btn_LineToPolygonTool.Image = global::MW5.Properties.Resources.线构面;
            this.btn_LineToPolygonTool.Name = "btn_LineToPolygonTool";
            this.SetShortcut(this.btn_LineToPolygonTool, System.Windows.Forms.Keys.None);
            // 
            // btn_AreaMergeTool
            // 
            resources.ApplyResources(this.btn_AreaMergeTool, "btn_AreaMergeTool");
            this.btn_AreaMergeTool.Image = global::MW5.Properties.Resources.面融合;
            this.btn_AreaMergeTool.Name = "btn_AreaMergeTool";
            this.SetShortcut(this.btn_AreaMergeTool, System.Windows.Forms.Keys.None);
            // 
            // btn_PolyToLineTool
            // 
            resources.ApplyResources(this.btn_PolyToLineTool, "btn_PolyToLineTool");
            this.btn_PolyToLineTool.Image = global::MW5.Properties.Resources.面转线;
            this.btn_PolyToLineTool.Name = "btn_PolyToLineTool";
            this.SetShortcut(this.btn_PolyToLineTool, System.Windows.Forms.Keys.None);
            // 
            // btn_PolygonizeGridTool
            // 
            resources.ApplyResources(this.btn_PolygonizeGridTool, "btn_PolygonizeGridTool");
            this.btn_PolygonizeGridTool.Image = global::MW5.Properties.Resources.删格转多边形;
            this.btn_PolygonizeGridTool.Name = "btn_PolygonizeGridTool";
            this.SetShortcut(this.btn_PolygonizeGridTool, System.Windows.Forms.Keys.None);
            // 
            // btnShowCsvToShp
            // 
            resources.ApplyResources(this.btnShowCsvToShp, "btnShowCsvToShp");
            this.btnShowCsvToShp.Name = "btnShowCsvToShp";
            this.SetShortcut(this.btnShowCsvToShp, System.Windows.Forms.Keys.None);
            // 
            // toolStripTabItem_Tools
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem_Tools, "T");
            resources.ApplyResources(this.toolStripTabItem_Tools, "toolStripTabItem_Tools");
            this.toolStripTabItem_Tools.Name = "toolStripTabItem_Tools";
            // 
            // ribbonControlAdv_Main.ribbonPanel3
            // 
            resources.ApplyResources(this.toolStripTabItem_Tools.Panel, "ribbonControlAdv_Main.ribbonPanel3");
            this.toolStripTabItem_Tools.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem_Tools.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem_Tools.Panel.Controls.Add(this.toolStripEx3);
            this.toolStripTabItem_Tools.Panel.Controls.Add(this.toolStripEx5);
            this.toolStripTabItem_Tools.Panel.Controls.Add(this.toolStripEx8);
            this.toolStripTabItem_Tools.Panel.Name = "ribbonPanel3";
            this.toolStripTabItem_Tools.Panel.ScrollPosition = 0;
            this.toolStripTabItem_Tools.Position = 2;
            this.SetShortcut(this.toolStripTabItem_Tools, System.Windows.Forms.Keys.None);
            this.toolStripTabItem_Tools.Tag = "1";
            // 
            // _dockingManager1
            // 
            this._dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.AnimateAutoHiddenWindow = true;
            this._dockingManager1.AutoHideTabFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this._dockingManager1.CloseTabOnMiddleClick = false;
            this._dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("_dockingManager1.DockLayoutStream")));
            this._dockingManager1.DockTabAlignment = Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Left;
            this._dockingManager1.DockTabFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.DockTabHeight = 26;
            this._dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Office2016Colorful;
            this._dockingManager1.HostControl = this;
            this._dockingManager1.ImageList = this.imageList1;
            this._dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this._dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this._dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this._dockingManager1.ReduceFlickeringInRtl = false;
            this._dockingManager1.ThemeName = "Office2016White";
            this._dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 1;
            resources.ApplyResources(this.parentBarItem3, "parentBarItem3");
            this.parentBarItem3.ID = "Trial";
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem3.WrapLength = 20;
            // 
            // dockingClientPanel1
            // 
            resources.ApplyResources(this.dockingClientPanel1, "dockingClientPanel1");
            this.dockingClientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.dockingClientPanel1.Controls.Add(this._mapControl1);
            this.dockingClientPanel1.Name = "dockingClientPanel1";
            // 
            // _mapControl1
            // 
            resources.ApplyResources(this._mapControl1, "_mapControl1");
            this._mapControl1.AllowDrop = true;
            this._mapControl1.AnimationOnZooming = MW5.Api.Enums.AutoToggle.Auto;
            this._mapControl1.BackgroundColor = System.Drawing.SystemColors.Control;
            this._mapControl1.CurrentScale = 8.564304221488479D;
            this._mapControl1.CurrentZoom = -1;
            this._mapControl1.CustomCursor = null;
            this._mapControl1.ExpandLayersOnAdding = true;
            this._mapControl1.ExtentHistory = 20;
            this._mapControl1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this._mapControl1.Extents = envelope1;
            this._mapControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._mapControl1.GrabProjectionFromData = true;
            this._mapControl1.InertiaOnPanning = MW5.Api.Enums.AutoToggle.Auto;
            this._mapControl1.KnownExtents = MW5.Api.Enums.KnownExtents.None;
            this._mapControl1.Latitude = 0F;
            this._mapControl1.Legend = null;
            this._mapControl1.Longitude = 0F;
            this._mapControl1.MapCursor = MW5.Api.Enums.MapCursor.None;
            this._mapControl1.MapProjection = MW5.Api.Enums.MapProjection.None;
            this._mapControl1.MapUnits = MW5.Api.Enums.LengthUnits.Meters;
            this._mapControl1.MouseWheelSpeed = 0.5D;
            this._mapControl1.Name = "_mapControl1";
            spatialReference1.Tag = "";
            this._mapControl1.Projection = spatialReference1;
            this._mapControl1.ResizeBehavior = MW5.Api.Enums.ResizeBehavior.Classic;
            this._mapControl1.ReuseTileBuffer = true;
            this._mapControl1.ScalebarUnits = MW5.Api.Enums.ScalebarUnits.GoogleStyle;
            this._mapControl1.ScalebarVisible = true;
            this._mapControl1.ShapeLayerDrawFill = true;
            this._mapControl1.ShowCoordinates = MW5.Api.Enums.CoordinatesDisplay.Auto;
            this._mapControl1.ShowCoordinatesFormat = MW5.Api.Enums.AngleFormat.Degrees;
            this._mapControl1.ShowRedrawTime = false;
            this._mapControl1.ShowVersionNumber = false;
            this._mapControl1.SystemCursor = MW5.Api.Enums.SystemCursor.MapDefault;
            this._mapControl1.Tag = "";
            this._mapControl1.TileProvider = MW5.Api.Enums.TileProvider.None;
            this._mapControl1.UdCursorHandle = -65536;
            this._mapControl1.UseSeamlessPan = false;
            this._mapControl1.ZoomBehavior = MW5.Api.Enums.ZoomBehavior.UseTileLevels;
            this._mapControl1.ZoomBoxStyle = MW5.Api.Enums.ZoomBoxStyle.Blue;
            this._mapControl1.ZoomPercent = 0.3D;
            // 
            // _mainFrameBarManager1
            // 
            this._mainFrameBarManager1.AutoLoadToolBarPositions = false;
            this._mainFrameBarManager1.AutoPersistCustomization = false;
            this._mainFrameBarManager1.AutoScale = true;
            this._mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("_mainFrameBarManager1.BarPositionInfo")));
            this._mainFrameBarManager1.CurrentBaseFormType = "MW5.UI.Forms.MapWindowViewMain";
            resources.ApplyResources(this._mainFrameBarManager1, "_mainFrameBarManager1");
            this._mainFrameBarManager1.EnableMenuMerge = true;
            this._mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this._mainFrameBarManager1.Form = this;
            this._mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this._mainFrameBarManager1.ResetCustomization = false;
            this._mainFrameBarManager1.UseBackwardCompatiblity = false;
            // 
            // statusStripEx1
            // 
            resources.ApplyResources(this.statusStripEx1, "statusStripEx1");
            this.statusStripEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(1787, 22);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            this.statusStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.ThemeName = "Metro";
            this.statusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Metro;
            // 
            // statusStripLabel5
            // 
            resources.ApplyResources(this.statusStripLabel5, "statusStripLabel5");
            this.statusStripLabel5.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripLabel5.Name = "statusStripLabel5";
            this.SetShortcut(this.statusStripLabel5, System.Windows.Forms.Keys.None);
            // 
            // statusMapUnits
            // 
            resources.ApplyResources(this.statusMapUnits, "statusMapUnits");
            this.statusMapUnits.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusMapUnits.Name = "statusMapUnits";
            this.SetShortcut(this.statusMapUnits, System.Windows.Forms.Keys.None);
            // 
            // toolStripStatusLabel3
            // 
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.SetShortcut(this.toolStripStatusLabel3, System.Windows.Forms.Keys.None);
            // 
            // statusProgress
            // 
            resources.ApplyResources(this.statusProgress, "statusProgress");
            this.statusProgress.Name = "statusProgress";
            this.SetShortcut(this.statusProgress, System.Windows.Forms.Keys.None);
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.SetShortcut(this.toolStripMenuItem6, System.Windows.Forms.Keys.None);
            // 
            // superToolTip1
            // 
            this.superToolTip1.MetroColor = System.Drawing.Color.White;
            this.superToolTip1.Style = Syncfusion.Windows.Forms.Tools.SuperToolTip.SuperToolTipStyle.Office2013Style;
            this.superToolTip1.ThemeName = "Metro";
            this.superToolTip1.UseFading = Syncfusion.Windows.Forms.Tools.SuperToolTip.FadingType.System;
            this.superToolTip1.VisualStyle = Syncfusion.Windows.Forms.Tools.SuperToolTip.Appearance.Metro;
            // 
            // toolStripGallery1
            // 
            resources.ApplyResources(this.toolStripGallery1, "toolStripGallery1");
            this.toolStripGallery1.CaptionText = "";
            this.toolStripGallery1.CheckOnClick = true;
            this.toolStripGallery1.ItemBackColor = System.Drawing.Color.Empty;
            toolStripGalleryItem1.Image = global::MW5.Properties.Resources.img_warning64;
            resources.ApplyResources(toolStripGalleryItem1, "toolStripGalleryItem1");
            toolStripGalleryItem1.ToolTipText = "";
            toolStripGalleryItem2.Image = global::MW5.Properties.Resources.img_tools32;
            resources.ApplyResources(toolStripGalleryItem2, "toolStripGalleryItem2");
            toolStripGalleryItem2.ToolTipText = "";
            toolStripGalleryItem3.Image = global::MW5.Properties.Resources.img_SelectionSelectByLocation32;
            resources.ApplyResources(toolStripGalleryItem3, "toolStripGalleryItem3");
            toolStripGalleryItem3.ToolTipText = "";
            toolStripGalleryItem4.Image = global::MW5.Properties.Resources.img_measure_length;
            resources.ApplyResources(toolStripGalleryItem4, "toolStripGalleryItem4");
            toolStripGalleryItem4.ToolTipText = "";
            toolStripGalleryItem5.Image = global::MW5.Properties.Resources.img_globe32;
            resources.ApplyResources(toolStripGalleryItem5, "toolStripGalleryItem5");
            toolStripGalleryItem5.ToolTipText = "";
            toolStripGalleryItem6.Image = global::MW5.Properties.Resources.icon_measure_distance;
            resources.ApplyResources(toolStripGalleryItem6, "toolStripGalleryItem6");
            toolStripGalleryItem6.ToolTipText = "";
            toolStripGalleryItem7.Image = global::MW5.Properties.Resources.icon_pan1;
            resources.ApplyResources(toolStripGalleryItem7, "toolStripGalleryItem7");
            toolStripGalleryItem7.ToolTipText = "";
            toolStripGalleryItem8.Image = global::MW5.Properties.Resources.icon_attribute_show;
            resources.ApplyResources(toolStripGalleryItem8, "toolStripGalleryItem8");
            toolStripGalleryItem8.ToolTipText = "";
            this.toolStripGallery1.Items.Add(toolStripGalleryItem1);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem2);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem3);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem4);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem5);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem6);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem7);
            this.toolStripGallery1.Items.Add(toolStripGalleryItem8);
            this.toolStripGallery1.ItemSize = new System.Drawing.Size(82, 61);
            this.toolStripGallery1.Name = "toolStripGallery1";
            this.SetShortcut(this.toolStripGallery1, System.Windows.Forms.Keys.None);
            this.toolStripGallery1.ShowToolTip = true;
            // 
            // toolStripPanelItem_zoom
            // 
            resources.ApplyResources(this.toolStripPanelItem_zoom, "toolStripPanelItem_zoom");
            this.toolStripPanelItem_zoom.CausesValidation = false;
            this.toolStripPanelItem_zoom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem_zoom.Name = "toolStripPanelItem_zoom";
            this.SetShortcut(this.toolStripPanelItem_zoom, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem_zoom.Transparent = true;
            // 
            // toolStripPanelItem3
            // 
            resources.ApplyResources(this.toolStripPanelItem3, "toolStripPanelItem3");
            this.toolStripPanelItem3.CausesValidation = false;
            this.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileToolbar,
            this.btnMapToolbar,
            this.btnEditToolbar});
            this.toolStripPanelItem3.Name = "toolStripPanelItem3";
            this.SetShortcut(this.toolStripPanelItem3, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem3.Transparent = true;
            // 
            // btnFileToolbar
            // 
            resources.ApplyResources(this.btnFileToolbar, "btnFileToolbar");
            this.btnFileToolbar.Name = "btnFileToolbar";
            this.SetShortcut(this.btnFileToolbar, System.Windows.Forms.Keys.None);
            this.btnFileToolbar.Tag = "文件";
            // 
            // btnMapToolbar
            // 
            resources.ApplyResources(this.btnMapToolbar, "btnMapToolbar");
            this.btnMapToolbar.Name = "btnMapToolbar";
            this.SetShortcut(this.btnMapToolbar, System.Windows.Forms.Keys.None);
            this.btnMapToolbar.Tag = "地图";
            // 
            // btnEditToolbar
            // 
            resources.ApplyResources(this.btnEditToolbar, "btnEditToolbar");
            this.btnEditToolbar.Name = "btnEditToolbar";
            this.SetShortcut(this.btnEditToolbar, System.Windows.Forms.Keys.None);
            this.btnEditToolbar.Tag = "编辑矢量";
            // 
            // toolStripPanelItem5
            // 
            resources.ApplyResources(this.toolStripPanelItem5, "toolStripPanelItem5");
            this.toolStripPanelItem5.CausesValidation = false;
            this.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripPanelItem6,
            this.toolStripPanelItem7});
            this.toolStripPanelItem5.Name = "toolStripPanelItem5";
            this.toolStripPanelItem5.RowCount = 2;
            this.SetShortcut(this.toolStripPanelItem5, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem5.Transparent = true;
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.SetShortcut(this.toolStripButton2, System.Windows.Forms.Keys.None);
            // 
            // toolStripButton3
            // 
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            this.SetShortcut(this.toolStripButton3, System.Windows.Forms.Keys.None);
            // 
            // toolStripPanelItem6
            // 
            resources.ApplyResources(this.toolStripPanelItem6, "toolStripPanelItem6");
            this.toolStripPanelItem6.CausesValidation = false;
            this.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStripPanelItem6.Name = "toolStripPanelItem6";
            this.SetShortcut(this.toolStripPanelItem6, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem6.Transparent = true;
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Name = "toolStripButton1";
            this.SetShortcut(this.toolStripButton1, System.Windows.Forms.Keys.None);
            // 
            // toolStripPanelItem7
            // 
            resources.ApplyResources(this.toolStripPanelItem7, "toolStripPanelItem7");
            this.toolStripPanelItem7.CausesValidation = false;
            this.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4});
            this.toolStripPanelItem7.Name = "toolStripPanelItem7";
            this.SetShortcut(this.toolStripPanelItem7, System.Windows.Forms.Keys.None);
            this.toolStripPanelItem7.Transparent = true;
            // 
            // toolStripButton4
            // 
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Name = "toolStripButton4";
            this.SetShortcut(this.toolStripButton4, System.Windows.Forms.Keys.None);
            // 
            // toolStripButton5
            // 
            resources.ApplyResources(this.toolStripButton5, "toolStripButton5");
            this.toolStripButton5.Name = "toolStripButton5";
            this.SetShortcut(this.toolStripButton5, System.Windows.Forms.Keys.None);
            // 
            // toolStripSplitButtonEx2
            // 
            resources.ApplyResources(this.toolStripSplitButtonEx2, "toolStripSplitButtonEx2");
            this.toolStripSplitButtonEx2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItemExt2});
            this.toolStripSplitButtonEx2.Image = global::MW5.Properties.Resources.icon_select;
            this.toolStripSplitButtonEx2.Name = "toolStripSplitButtonEx2";
            this.SetShortcut(this.toolStripSplitButtonEx2, System.Windows.Forms.Keys.None);
            this.toolStripSplitButtonEx2.Tag = "SelectByRectangle";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Image = global::MW5.Properties.Resources.icon_select;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.SetShortcut(this.toolStripMenuItem2, System.Windows.Forms.Keys.None);
            // 
            // toolStripMenuItemExt2
            // 
            resources.ApplyResources(this.toolStripMenuItemExt2, "toolStripMenuItemExt2");
            this.toolStripMenuItemExt2.Image = global::MW5.Properties.Resources.icon_select_by_polygon;
            this.toolStripMenuItemExt2.Name = "toolStripMenuItemExt2";
            this.SetShortcut(this.toolStripMenuItemExt2, System.Windows.Forms.Keys.None);
            this.toolStripMenuItemExt2.Tag = "SelectByPolygon";
            // 
            // miniToolBar1
            // 
            resources.ApplyResources(this.miniToolBar1, "miniToolBar1");
            this.miniToolBar1.AllowDrop = true;
            this.miniToolBar1.AutoClose = false;
            this.miniToolBar1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolBar1.Name = "miniToolBar1";
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.backStage1);
            this.Controls.Add(this.ribbonControlAdv_Main);
            this.Controls.Add(this.dockingClientPanel1);
            this.Controls.Add(this.statusStripEx1);
            this.Name = "MainView";
            this.ShowApplicationIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv_Main)).EndInit();
            this.ribbonControlAdv_Main.ResumeLayout(false);
            this.ribbonControlAdv_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).EndInit();
            this.backStage1.ResumeLayout(false);
            this.toolStripEx_Settings.ResumeLayout(false);
            this.toolStripEx_Settings.PerformLayout();
            this.toolStripEx_Layer.ResumeLayout(false);
            this.toolStripEx_Layer.PerformLayout();
            this.toolStripEx_Printer.ResumeLayout(false);
            this.toolStripEx_Printer.PerformLayout();
            this.toolStripTabItem_Map.Panel.ResumeLayout(false);
            this.toolStripTabItem_Map.Panel.PerformLayout();
            this.toolStripEx_MapExplore.ResumeLayout(false);
            this.toolStripEx_MapExplore.PerformLayout();
            this.toolStripEx_Selection.ResumeLayout(false);
            this.toolStripEx_Selection.PerformLayout();
            this.toolStripEx12.ResumeLayout(false);
            this.toolStripEx12.PerformLayout();
            this.toolStripTabItem_Edit.Panel.ResumeLayout(false);
            this.toolStripTabItem_Edit.Panel.PerformLayout();
            this.toolStripEx_Edit.ResumeLayout(false);
            this.toolStripEx_Edit.PerformLayout();
            this.toolStripEx14.ResumeLayout(false);
            this.toolStripEx14.PerformLayout();
            this.toolStripTabItem_Help.Panel.ResumeLayout(false);
            this.toolStripTabItem_Help.Panel.PerformLayout();
            this.toolStripEx6.ResumeLayout(false);
            this.toolStripEx6.PerformLayout();
            this.toolStripEx7.ResumeLayout(false);
            this.toolStripEx7.PerformLayout();
            this.toolStripEx16.ResumeLayout(false);
            this.toolStripEx16.PerformLayout();
            this.toolStripEx_About.ResumeLayout(false);
            this.toolStripEx_About.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.toolStripEx3.ResumeLayout(false);
            this.toolStripEx3.PerformLayout();
            this.toolStripEx5.ResumeLayout(false);
            this.toolStripEx5.PerformLayout();
            this.toolStripEx8.ResumeLayout(false);
            this.toolStripEx8.PerformLayout();
            this.toolStripTabItem_Tools.Panel.ResumeLayout(false);
            this.toolStripTabItem_Tools.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dockingManager1)).EndInit();
            this.dockingClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DockingManager _dockingManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager _mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel5;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusMapUnits;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private BoundMapControl _mapControl1;
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv_Main;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx_Settings;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem_Map;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem_Edit;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem_Help;
        private Syncfusion.Windows.Forms.BackStage backStage1;
        private Syncfusion.Windows.Forms.BackStageButton btnFileOpenProject;
        private Syncfusion.Windows.Forms.BackStageButton btnFileQuit;
        private Syncfusion.Windows.Forms.BackStageButton btnFileNewMap;
        private Syncfusion.Windows.Forms.BackStageButton btnFileSaveProject;
        private Syncfusion.Windows.Forms.BackStageButton btnFileSaveProjectAs;
        private System.Windows.Forms.ToolStripMenuItem btnLayerAddVectorLayer;
        private System.Windows.Forms.ToolStripMenuItem btnLayerAddRasterLayer;
        private System.Windows.Forms.ToolStripMenuItem btnLayerAddDatabaseLayer;
        private System.Windows.Forms.ToolStripMenuItem btnLayerAddWmsLayer;
        private Syncfusion.Windows.Forms.BackStageButton btnppPrint;
        private Syncfusion.Windows.Forms.BackStageSeparator backStageSeparator1;
        private Syncfusion.Windows.Forms.BackStageSeparator backStageSeparator2;
        private Syncfusion.Windows.Forms.BackStageSeparator backStageSeparator3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx_MapExplore;
        private System.Windows.Forms.ToolStripButton btnViewZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnZoomMax;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx4;
        private System.Windows.Forms.ToolStripButton btnZoomPrev;
        private System.Windows.Forms.ToolStripButton btnZoomNext;
        private System.Windows.Forms.ToolStripButton btnPan;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx7;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem3;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnFileToolbar;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnMapToolbar;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnEditToolbar;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem4;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewPropertiesTable;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewRepository;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewDebugger;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewToolbox;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewContents;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewTasks;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewIdentity;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewTheme;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx_Selection;
        private System.Windows.Forms.ToolStripButton btnSelectionByAttribute;
        private System.Windows.Forms.ToolStripButton btnSelectionByLocation;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx btnSelectFeature;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt btnSelectByPolygon;
        private System.Windows.Forms.ToolStripButton btnZoomToSelected;
        private System.Windows.Forms.ToolStripButton btnClearSelection;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx6;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnShowZoombar;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnShowScalebar;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnShowCoordinates;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnShowRedrawTime;
        private System.Windows.Forms.ToolStripButton btnSetScale;
        private System.Windows.Forms.ToolStripButton btnSetProjection;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx_Layer;
        private System.Windows.Forms.ToolStripButton btnLayerRemoveLayer;
        private System.Windows.Forms.ToolStripButton btnLayerClearLayers;
        private System.Windows.Forms.ToolStripButton btnSY_Categories;
        private System.Windows.Forms.ToolStripButton btnSY_Charts;
        private System.Windows.Forms.ToolStripButton btnSY_Labels;
        private Syncfusion.Windows.Forms.BackStageButton btnFileSettings;
        private Syncfusion.Windows.Forms.BackStageSeparator backStageSeparator4;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx12;
        private System.Windows.Forms.ToolStripButton btnip_IdentifyTool;
        private System.Windows.Forms.ToolStripButton btnGoToXY;
        private System.Windows.Forms.ToolStripButton btnSwipeTool;
        private System.Windows.Forms.ToolStripButton btnSY_LabelMover;
        private System.Windows.Forms.ToolStripButton btnSY_SymbolRotator;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx_Edit;
        private System.Windows.Forms.ToolStripButton btnSE_LayerEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnSE_GeometryCreate;
        private System.Windows.Forms.ToolStripButton btnSE_VertexEditor;
        private System.Windows.Forms.ToolStripButton btnSE_SplitShapes;
        private System.Windows.Forms.ToolStripButton btnSE_MergeShapes;
        private System.Windows.Forms.ToolStripButton btnSE_MoveShapes;
        private System.Windows.Forms.ToolStripButton btnSE_CopyAttributes;
        private System.Windows.Forms.ToolStripButton btnSE_RotateShapes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnSE_Copy;
        private System.Windows.Forms.ToolStripButton btnSE_Paste;
        private System.Windows.Forms.ToolStripButton btnSE_DeleteSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btnSE_SplitByPolyline;
        private System.Windows.Forms.ToolStripButton btnSE_Undo;
        private System.Windows.Forms.ToolStripLabel txtHistoryLength;
        private System.Windows.Forms.ToolStripButton btnSE_Redo;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx14;
        private System.Windows.Forms.ToolStripButton btnSE_SnapToActiveLayer;
        private System.Windows.Forms.ToolStripButton btnSE_SnapToAllLayers;
        private System.Windows.Forms.ToolStripButton btnSE_SnapToVertices;
        private System.Windows.Forms.ToolStripButton btnSE_SnapToSegments;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx btnSE_SplitByPolygon;
        private System.Windows.Forms.ToolStripMenuItem btnSE_EraseByPolygon;
        private System.Windows.Forms.ToolStripMenuItem btnSE_ClipByPolygon;
        private System.Windows.Forms.ToolStripButton btnSE_Cut;
        private System.Windows.Forms.ToolStripButton btnSE_CreateLayer;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx_Printer;
        private System.Windows.Forms.ToolStripButton btnppSelectPrintArea;
        private System.Windows.Forms.ToolStripButton tsbppPrint;
        private Syncfusion.Windows.Forms.Tools.SuperAccelerator superAccelerator1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx16;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnShowTiles;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem7;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem_zoom;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem btnSelectByRectangle;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx btnMeasure;
        private System.Windows.Forms.ToolStripMenuItem btnMeasureDistance;
        private System.Windows.Forms.ToolStripMenuItem btnMeasureArea;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem_Select;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx toolStripSplitButtonEx1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx toolStripSplitButtonEx2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt2;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem_Browse;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx btnLayerAddLayer;
        private Syncfusion.Windows.Forms.Tools.MiniToolBar miniToolBar1;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem_Layer;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt btnBaseMapTianDiTu;
        private Syncfusion.Windows.Forms.Tools.ToolStripGallery toolStripGallery1;
        private System.Windows.Forms.ToolStripMenuItem btnBaseMapGoogleSatellite;
        private System.Windows.Forms.ToolStripMenuItem btnBaseMapGoogleSatellitelabel;
        private System.Windows.Forms.ToolStripMenuItem btnBaseMapGaoDeRoad;
        private System.Windows.Forms.ToolStripMenuItem btnBaseMapGaoDeSatellite;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton_BaseMap;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt btnBaseMapTianDiTuImage;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt btnBaseMapTianDiTuImageLabel;
        private System.Windows.Forms.ToolStripMenuItem btnBaseMapTencentSatellite;
        private System.Windows.Forms.ToolStripMenuItem btnBaseMapTencentRoad;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx btnPictureViewer;
        private System.Windows.Forms.ToolStripMenuItem btnPictureViewSetting;
        private System.Windows.Forms.ToolStripButton btnDataDictionary;
        private System.Windows.Forms.ToolStripMenuItem btnBaseMapNone;
        private System.Windows.Forms.ToolStripButton btnSE_PasteAttributes;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox btnViewAttributeChecker;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx_About;
        private System.Windows.Forms.ToolStripButton btnHelpWelcome;
        private System.Windows.Forms.ToolStripButton btnHelpGuide;
        private System.Windows.Forms.ToolStripButton btnHelpAbout;
        private System.Windows.Forms.ToolStripButton btnShowDeviceManager;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem_Symbol;
        private System.Windows.Forms.ToolStripButton btnSwitchFill;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem_Tools;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton btnTP_ShowTopologyRulesWindow;
        private System.Windows.Forms.ToolStripButton btn_XBPHTool;
        private System.Windows.Forms.ToolStripButton btn_ImageRegistrationTool;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx8;
        private System.Windows.Forms.ToolStripButton btn_LineToPolygonTool;
        private System.Windows.Forms.ToolStripButton btn_AreaMergeTool;
        private System.Windows.Forms.ToolStripButton btn_PolygonizeGridTool;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx5;
        private System.Windows.Forms.ToolStripButton btn_AttributesCopyTool;
        private System.Windows.Forms.ToolStripButton btn_DissolveTool;
        private System.Windows.Forms.ToolStripButton btn_AggregateShapesTool;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx3;
        private System.Windows.Forms.ToolStripButton btn_RasterReprojectTool;
        private System.Windows.Forms.ToolStripButton btn_ReprojectTool;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripButton btn_TranslateRasterTool;
        private System.Windows.Forms.ToolStripButton btn_Ogr2OgrTool;
        private System.Windows.Forms.ToolStripButton btn_PolyToLineTool;
        private System.Windows.Forms.ToolStripButton btnShowCsvToShp;
    }
}