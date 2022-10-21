using MW5.Api.Map;
using MW5.Plugins.Symbology.Controls;
using MW5.Plugins.Symbology.Controls.ImageCombo;
using MW5.UI.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.Symbology.Views
{
    partial class VectorStyleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorStyleView));
            MW5.Api.Concrete.Envelope envelope1 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference1 = new MW5.Api.Concrete.SpatialReference();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControl1 = new MW5.UI.Controls.TabPropertiesControl();
            this.tabGeneral = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chkEditMode = new System.Windows.Forms.CheckBox();
            this.chkSpatialIndex = new System.Windows.Forms.CheckBox();
            this.btnOpenLocation = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtBriefInfo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProjectionDetails = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtProjection = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatasourceName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.axMap1 = new MW5.Api.Map.MapControl();
            this.chkLayerPreview = new System.Windows.Forms.CheckBox();
            this.chkLayerVisible = new System.Windows.Forms.CheckBox();
            this.txtLayerName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dynamicVisibilityControl1 = new MW5.Plugins.Symbology.Controls.DynamicVisibilityControl();
            this.tabInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnCopyInfo = new Syncfusion.Windows.Forms.ButtonAdv();
            this.infoGrid1 = new MW5.Plugins.Symbology.Controls.InfoGrid();
            this.tabDefault = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.cboCollisionMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.udMinDrawingSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udMinLabelingSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnClearVisibilityExpression = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnChangeVisibilityExpression = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtLayerExpression = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCategories = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.tabFields = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.attributesControl1 = new MW5.Plugins.Symbology.Controls.AttributesControl();
            this.tabJoins = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.joinControl1 = new MW5.Plugins.Symbology.Controls.JoinControl();
            this.tabLabels = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearLabels = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupLabelAppearance = new System.Windows.Forms.GroupBox();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.udLabelFontSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.clpLabelFrame = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.chkShowLabels = new System.Windows.Forms.CheckBox();
            this.chkLabelFrame = new System.Windows.Forms.CheckBox();
            this.groupLabelStyle = new System.Windows.Forms.GroupBox();
            this.pctLabelPreview = new System.Windows.Forms.PictureBox();
            this.btnLabelAppearance = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabCharts = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChartAppearance = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClearCharts = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupChartAppearance = new System.Windows.Forms.GroupBox();
            this.btnChartsEditColorScheme = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkChartsVisible = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.optChartsPie = new System.Windows.Forms.RadioButton();
            this.icbChartColorScheme = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.optChartBars = new System.Windows.Forms.RadioButton();
            this.groupCharts = new System.Windows.Forms.GroupBox();
            this.pctCharts = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboMaxScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboMinScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnApply = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolSaveStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRemoveStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOpenLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleControl2 = new MW5.Plugins.Symbology.Controls.ScaleControl();
            this.scaleControl1 = new MW5.Plugins.Symbology.Controls.ScaleControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBriefInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasourceName)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid1)).BeginInit();
            this.tabDefault.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCollisionMode)).BeginInit();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinDrawingSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinLabelingSize)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCategories.SuspendLayout();
            this.tabFields.SuspendLayout();
            this.tabJoins.SuspendLayout();
            this.tabLabels.SuspendLayout();
            this.groupLabelAppearance.SuspendLayout();
            this.panelLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelFontSize)).BeginInit();
            this.groupLabelStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLabelPreview)).BeginInit();
            this.tabCharts.SuspendLayout();
            this.groupChartAppearance.SuspendLayout();
            this.groupCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCharts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 30);
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.toolTip1.SetToolTip(this.btnOk, resources.GetString("btnOk.ToolTip"));
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.OnButtonOkClicked);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 30);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.toolTip1.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tabControl1.BeforeTouchSize = new System.Drawing.Size(862, 479);
            this.tabControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabDefault);
            this.tabControl1.Controls.Add(this.tabCategories);
            this.tabControl1.Controls.Add(this.tabFields);
            this.tabControl1.Controls.Add(this.tabJoins);
            this.tabControl1.Controls.Add(this.tabLabels);
            this.tabControl1.Controls.Add(this.tabCharts);
            this.tabControl1.FocusOnTabClick = false;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PersistTabState = true;
            this.tabControl1.RotateTextWhenVertical = true;
            this.tabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendLight);
            this.tabControl1.ThemeName = "TabRendererBlendLight";
            this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabGeneral
            // 
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Controls.Add(this.chkEditMode);
            this.tabGeneral.Controls.Add(this.chkSpatialIndex);
            this.tabGeneral.Controls.Add(this.btnOpenLocation);
            this.tabGeneral.Controls.Add(this.txtBriefInfo);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.btnProjectionDetails);
            this.tabGeneral.Controls.Add(this.txtProjection);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.txtDatasourceName);
            this.tabGeneral.Controls.Add(this.label8);
            this.tabGeneral.Controls.Add(this.groupBox10);
            this.tabGeneral.Controls.Add(this.chkLayerVisible);
            this.tabGeneral.Controls.Add(this.txtLayerName);
            this.tabGeneral.Controls.Add(this.label18);
            this.tabGeneral.Controls.Add(this.dynamicVisibilityControl1);
            this.tabGeneral.Image = null;
            this.tabGeneral.ImageSize = new System.Drawing.Size(16, 16);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.ShowCloseButton = true;
            this.tabGeneral.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabGeneral, resources.GetString("tabGeneral.ToolTip"));
            // 
            // chkEditMode
            // 
            resources.ApplyResources(this.chkEditMode, "chkEditMode");
            this.chkEditMode.Name = "chkEditMode";
            this.toolTip1.SetToolTip(this.chkEditMode, resources.GetString("chkEditMode.ToolTip"));
            this.chkEditMode.UseVisualStyleBackColor = true;
            // 
            // chkSpatialIndex
            // 
            resources.ApplyResources(this.chkSpatialIndex, "chkSpatialIndex");
            this.chkSpatialIndex.Name = "chkSpatialIndex";
            this.toolTip1.SetToolTip(this.chkSpatialIndex, resources.GetString("chkSpatialIndex.ToolTip"));
            this.chkSpatialIndex.UseVisualStyleBackColor = true;
            this.chkSpatialIndex.CheckedChanged += new System.EventHandler(this.OnSpatialIndexChecked);
            // 
            // btnOpenLocation
            // 
            resources.ApplyResources(this.btnOpenLocation, "btnOpenLocation");
            this.btnOpenLocation.BeforeTouchSize = new System.Drawing.Size(63, 21);
            this.btnOpenLocation.Name = "btnOpenLocation";
            this.toolTip1.SetToolTip(this.btnOpenLocation, resources.GetString("btnOpenLocation.ToolTip"));
            // 
            // txtBriefInfo
            // 
            resources.ApplyResources(this.txtBriefInfo, "txtBriefInfo");
            this.txtBriefInfo.BeforeTouchSize = new System.Drawing.Size(461, 25);
            this.txtBriefInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBriefInfo.Name = "txtBriefInfo";
            this.txtBriefInfo.ReadOnly = true;
            this.txtBriefInfo.ThemeName = "Default";
            this.toolTip1.SetToolTip(this.txtBriefInfo, resources.GetString("txtBriefInfo.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnProjectionDetails
            // 
            resources.ApplyResources(this.btnProjectionDetails, "btnProjectionDetails");
            this.btnProjectionDetails.BeforeTouchSize = new System.Drawing.Size(63, 21);
            this.btnProjectionDetails.Name = "btnProjectionDetails";
            this.toolTip1.SetToolTip(this.btnProjectionDetails, resources.GetString("btnProjectionDetails.ToolTip"));
            // 
            // txtProjection
            // 
            resources.ApplyResources(this.txtProjection, "txtProjection");
            this.txtProjection.BeforeTouchSize = new System.Drawing.Size(461, 25);
            this.txtProjection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjection.Name = "txtProjection";
            this.txtProjection.ReadOnly = true;
            this.txtProjection.ThemeName = "Default";
            this.toolTip1.SetToolTip(this.txtProjection, resources.GetString("txtProjection.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // txtDatasourceName
            // 
            resources.ApplyResources(this.txtDatasourceName, "txtDatasourceName");
            this.txtDatasourceName.BeforeTouchSize = new System.Drawing.Size(461, 25);
            this.txtDatasourceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatasourceName.Name = "txtDatasourceName";
            this.txtDatasourceName.ReadOnly = true;
            this.txtDatasourceName.ThemeName = "Default";
            this.toolTip1.SetToolTip(this.txtDatasourceName, resources.GetString("txtDatasourceName.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // groupBox10
            // 
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Controls.Add(this.axMap1);
            this.groupBox10.Controls.Add(this.chkLayerPreview);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox10, resources.GetString("groupBox10.ToolTip"));
            // 
            // axMap1
            // 
            resources.ApplyResources(this.axMap1, "axMap1");
            this.axMap1.AllowDrop = true;
            this.axMap1.AnimationOnZooming = MW5.Api.Enums.AutoToggle.Auto;
            this.axMap1.BackgroundColor = System.Drawing.Color.White;
            this.axMap1.CurrentScale = 38.078708719993372D;
            this.axMap1.CurrentZoom = -1;
            this.axMap1.ExpandLayersOnAdding = true;
            this.axMap1.ExtentHistory = 20;
            this.axMap1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this.axMap1.Extents = envelope1;
            this.axMap1.GrabProjectionFromData = true;
            this.axMap1.InertiaOnPanning = MW5.Api.Enums.AutoToggle.Auto;
            this.axMap1.KnownExtents = MW5.Api.Enums.KnownExtents.None;
            this.axMap1.Latitude = 0F;
            this.axMap1.Longitude = 0F;
            this.axMap1.MapCursor = MW5.Api.Enums.MapCursor.ZoomIn;
            this.axMap1.MapProjection = MW5.Api.Enums.MapProjection.None;
            this.axMap1.MapUnits = MW5.Api.Enums.LengthUnits.Meters;
            this.axMap1.MouseWheelSpeed = 0.5D;
            this.axMap1.Name = "axMap1";
            spatialReference1.Tag = "";
            this.axMap1.Projection = spatialReference1;
            this.axMap1.ResizeBehavior = MW5.Api.Enums.ResizeBehavior.Classic;
            this.axMap1.ReuseTileBuffer = true;
            this.axMap1.ScalebarUnits = MW5.Api.Enums.ScalebarUnits.GoogleStyle;
            this.axMap1.ScalebarVisible = false;
            this.axMap1.ShapeLayerDrawFill = true;
            this.axMap1.ShowCoordinates = MW5.Api.Enums.CoordinatesDisplay.None;
            this.axMap1.ShowCoordinatesFormat = MW5.Api.Enums.AngleFormat.Degrees;
            this.axMap1.ShowRedrawTime = false;
            this.axMap1.ShowVersionNumber = false;
            this.axMap1.SystemCursor = MW5.Api.Enums.SystemCursor.MapDefault;
            this.axMap1.Tag = "";
            this.axMap1.TileProvider = MW5.Api.Enums.TileProvider.None;
            this.toolTip1.SetToolTip(this.axMap1, resources.GetString("axMap1.ToolTip"));
            this.axMap1.UdCursorHandle = 0;
            this.axMap1.UseSeamlessPan = false;
            this.axMap1.ZoomBehavior = MW5.Api.Enums.ZoomBehavior.UseTileLevels;
            this.axMap1.ZoomBoxStyle = MW5.Api.Enums.ZoomBoxStyle.Blue;
            this.axMap1.ZoomPercent = 0.3D;
            // 
            // chkLayerPreview
            // 
            resources.ApplyResources(this.chkLayerPreview, "chkLayerPreview");
            this.chkLayerPreview.Name = "chkLayerPreview";
            this.toolTip1.SetToolTip(this.chkLayerPreview, resources.GetString("chkLayerPreview.ToolTip"));
            this.chkLayerPreview.UseVisualStyleBackColor = true;
            this.chkLayerPreview.CheckedChanged += new System.EventHandler(this.OnLayerPreviewChecked);
            // 
            // chkLayerVisible
            // 
            resources.ApplyResources(this.chkLayerVisible, "chkLayerVisible");
            this.chkLayerVisible.Name = "chkLayerVisible";
            this.toolTip1.SetToolTip(this.chkLayerVisible, resources.GetString("chkLayerVisible.ToolTip"));
            this.chkLayerVisible.UseVisualStyleBackColor = true;
            this.chkLayerVisible.CheckedChanged += new System.EventHandler(this.RefreshModel);
            // 
            // txtLayerName
            // 
            resources.ApplyResources(this.txtLayerName, "txtLayerName");
            this.txtLayerName.Name = "txtLayerName";
            this.toolTip1.SetToolTip(this.txtLayerName, resources.GetString("txtLayerName.ToolTip"));
            this.txtLayerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnLayerNameKeyPress);
            this.txtLayerName.Validated += new System.EventHandler(this.OnLayerNameValidated);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.toolTip1.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
            // 
            // dynamicVisibilityControl1
            // 
            resources.ApplyResources(this.dynamicVisibilityControl1, "dynamicVisibilityControl1");
            this.dynamicVisibilityControl1.CurrentScale = 0D;
            this.dynamicVisibilityControl1.CurrentZoom = 0;
            this.dynamicVisibilityControl1.MaxScale = 1000000D;
            this.dynamicVisibilityControl1.MaxZoom = 24;
            this.dynamicVisibilityControl1.MinScale = 100D;
            this.dynamicVisibilityControl1.MinZoom = 1;
            this.dynamicVisibilityControl1.Mode = MW5.Api.Enums.DynamicVisibilityMode.Scale;
            this.dynamicVisibilityControl1.Name = "dynamicVisibilityControl1";
            this.toolTip1.SetToolTip(this.dynamicVisibilityControl1, resources.GetString("dynamicVisibilityControl1.ToolTip"));
            this.dynamicVisibilityControl1.UseDynamicVisiblity = false;
            this.dynamicVisibilityControl1.ValueChanged += new System.EventHandler<System.EventArgs>(this.RefreshModel);
            // 
            // tabInfo
            // 
            resources.ApplyResources(this.tabInfo, "tabInfo");
            this.tabInfo.Controls.Add(this.btnCopyInfo);
            this.tabInfo.Controls.Add(this.infoGrid1);
            this.tabInfo.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_info24;
            this.tabInfo.ImageSize = new System.Drawing.Size(24, 24);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.ShowCloseButton = true;
            this.tabInfo.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabInfo, resources.GetString("tabInfo.ToolTip"));
            // 
            // btnCopyInfo
            // 
            resources.ApplyResources(this.btnCopyInfo, "btnCopyInfo");
            this.btnCopyInfo.BeforeTouchSize = new System.Drawing.Size(88, 28);
            this.btnCopyInfo.Name = "btnCopyInfo";
            this.toolTip1.SetToolTip(this.btnCopyInfo, resources.GetString("btnCopyInfo.ToolTip"));
            this.btnCopyInfo.Click += new System.EventHandler(this.btnCopyInfo_Click);
            // 
            // infoGrid1
            // 
            resources.ApplyResources(this.infoGrid1, "infoGrid1");
            this.infoGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.infoGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.infoGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.infoGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.infoGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.infoGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.infoGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.infoGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.infoGrid1.BrowseOnly = true;
            this.infoGrid1.GridLineColor = System.Drawing.Color.White;
            this.infoGrid1.Name = "infoGrid1";
            this.infoGrid1.ShowColumnHeaders = false;
            this.infoGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.infoGrid1.ShowRowHeaders = false;
            this.infoGrid1.TableDescriptor.AllowEdit = false;
            this.infoGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.infoGrid1.TableOptions.AllowDropDownCell = false;
            this.infoGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.infoGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.infoGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.infoGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.infoGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.infoGrid1, resources.GetString("infoGrid1.ToolTip"));
            this.infoGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.infoGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.infoGrid1.TopLevelGroupOptions.ShowColumnHeaders = false;
            this.infoGrid1.UseRightToLeftCompatibleTextBox = true;
            this.infoGrid1.VersionInfo = "0.0.1.0";
            this.infoGrid1.WrapWithPanel = false;
            // 
            // tabDefault
            // 
            resources.ApplyResources(this.tabDefault, "tabDefault");
            this.tabDefault.Controls.Add(this.label5);
            this.tabDefault.Controls.Add(this.groupBox21);
            this.tabDefault.Controls.Add(this.groupBox19);
            this.tabDefault.Controls.Add(this.groupBox13);
            this.tabDefault.Controls.Add(this.groupBox5);
            this.tabDefault.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_eye24;
            this.tabDefault.ImageSize = new System.Drawing.Size(24, 24);
            this.tabDefault.Name = "tabDefault";
            this.tabDefault.ShowCloseButton = true;
            this.tabDefault.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabDefault, resources.GetString("tabDefault.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // groupBox21
            // 
            resources.ApplyResources(this.groupBox21, "groupBox21");
            this.groupBox21.Controls.Add(this.cboCollisionMode);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox21, resources.GetString("groupBox21.ToolTip"));
            // 
            // cboCollisionMode
            // 
            resources.ApplyResources(this.cboCollisionMode, "cboCollisionMode");
            this.cboCollisionMode.BeforeTouchSize = new System.Drawing.Size(203, 21);
            this.cboCollisionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollisionMode.Name = "cboCollisionMode";
            this.toolTip1.SetToolTip(this.cboCollisionMode, resources.GetString("cboCollisionMode.ToolTip"));
            this.cboCollisionMode.Click += new System.EventHandler(this.RefreshModel);
            // 
            // groupBox19
            // 
            resources.ApplyResources(this.groupBox19, "groupBox19");
            this.groupBox19.Controls.Add(this.label12);
            this.groupBox19.Controls.Add(this.udMinDrawingSize);
            this.groupBox19.Controls.Add(this.udMinLabelingSize);
            this.groupBox19.Controls.Add(this.label6);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox19, resources.GetString("groupBox19.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // udMinDrawingSize
            // 
            resources.ApplyResources(this.udMinDrawingSize, "udMinDrawingSize");
            this.udMinDrawingSize.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udMinDrawingSize.Name = "udMinDrawingSize";
            this.toolTip1.SetToolTip(this.udMinDrawingSize, resources.GetString("udMinDrawingSize.ToolTip"));
            this.udMinDrawingSize.ValueChanged += new System.EventHandler(this.RefreshModel);
            // 
            // udMinLabelingSize
            // 
            resources.ApplyResources(this.udMinLabelingSize, "udMinLabelingSize");
            this.udMinLabelingSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udMinLabelingSize.Name = "udMinLabelingSize";
            this.toolTip1.SetToolTip(this.udMinLabelingSize, resources.GetString("udMinLabelingSize.ToolTip"));
            this.udMinLabelingSize.ValueChanged += new System.EventHandler(this.RefreshModel);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // groupBox13
            // 
            resources.ApplyResources(this.groupBox13, "groupBox13");
            this.groupBox13.Controls.Add(this.btnClearVisibilityExpression);
            this.groupBox13.Controls.Add(this.btnChangeVisibilityExpression);
            this.groupBox13.Controls.Add(this.txtLayerExpression);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox13, resources.GetString("groupBox13.ToolTip"));
            // 
            // btnClearVisibilityExpression
            // 
            resources.ApplyResources(this.btnClearVisibilityExpression, "btnClearVisibilityExpression");
            this.btnClearVisibilityExpression.BeforeTouchSize = new System.Drawing.Size(74, 24);
            this.btnClearVisibilityExpression.Name = "btnClearVisibilityExpression";
            this.toolTip1.SetToolTip(this.btnClearVisibilityExpression, resources.GetString("btnClearVisibilityExpression.ToolTip"));
            this.btnClearVisibilityExpression.UseVisualStyleBackColor = true;
            // 
            // btnChangeVisibilityExpression
            // 
            resources.ApplyResources(this.btnChangeVisibilityExpression, "btnChangeVisibilityExpression");
            this.btnChangeVisibilityExpression.BeforeTouchSize = new System.Drawing.Size(75, 24);
            this.btnChangeVisibilityExpression.Name = "btnChangeVisibilityExpression";
            this.toolTip1.SetToolTip(this.btnChangeVisibilityExpression, resources.GetString("btnChangeVisibilityExpression.ToolTip"));
            this.btnChangeVisibilityExpression.UseVisualStyleBackColor = true;
            // 
            // txtLayerExpression
            // 
            resources.ApplyResources(this.txtLayerExpression, "txtLayerExpression");
            this.txtLayerExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLayerExpression.Name = "txtLayerExpression";
            this.toolTip1.SetToolTip(this.txtLayerExpression, resources.GetString("txtLayerExpression.ToolTip"));
            this.txtLayerExpression.TextChanged += new System.EventHandler(this.RefreshModel);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.pictureBox1.Click += new System.EventHandler(this.OnDefaultDrawingOptionsClick);
            // 
            // tabCategories
            // 
            resources.ApplyResources(this.tabCategories, "tabCategories");
            this.tabCategories.Controls.Add(this.label9);
            this.tabCategories.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_palette;
            this.tabCategories.ImageSize = new System.Drawing.Size(24, 24);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.ShowCloseButton = true;
            this.tabCategories.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabCategories, resources.GetString("tabCategories.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // tabFields
            // 
            resources.ApplyResources(this.tabFields, "tabFields");
            this.tabFields.Controls.Add(this.attributesControl1);
            this.tabFields.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_table24;
            this.tabFields.ImageSize = new System.Drawing.Size(24, 24);
            this.tabFields.Name = "tabFields";
            this.tabFields.ShowCloseButton = true;
            this.tabFields.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabFields, resources.GetString("tabFields.ToolTip"));
            // 
            // attributesControl1
            // 
            resources.ApplyResources(this.attributesControl1, "attributesControl1");
            this.attributesControl1.Name = "attributesControl1";
            this.toolTip1.SetToolTip(this.attributesControl1, resources.GetString("attributesControl1.ToolTip"));
            // 
            // tabJoins
            // 
            resources.ApplyResources(this.tabJoins, "tabJoins");
            this.tabJoins.Controls.Add(this.joinControl1);
            this.tabJoins.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_database241;
            this.tabJoins.ImageSize = new System.Drawing.Size(24, 24);
            this.tabJoins.Name = "tabJoins";
            this.tabJoins.ShowCloseButton = true;
            this.tabJoins.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabJoins, resources.GetString("tabJoins.ToolTip"));
            // 
            // joinControl1
            // 
            resources.ApplyResources(this.joinControl1, "joinControl1");
            this.joinControl1.Name = "joinControl1";
            this.toolTip1.SetToolTip(this.joinControl1, resources.GetString("joinControl1.ToolTip"));
            // 
            // tabLabels
            // 
            resources.ApplyResources(this.tabLabels, "tabLabels");
            this.tabLabels.Controls.Add(this.label1);
            this.tabLabels.Controls.Add(this.btnClearLabels);
            this.tabLabels.Controls.Add(this.groupLabelAppearance);
            this.tabLabels.Controls.Add(this.groupLabelStyle);
            this.tabLabels.Controls.Add(this.btnLabelAppearance);
            this.tabLabels.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_label24;
            this.tabLabels.ImageSize = new System.Drawing.Size(24, 24);
            this.tabLabels.Name = "tabLabels";
            this.tabLabels.ShowCloseButton = true;
            this.tabLabels.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabLabels, resources.GetString("tabLabels.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnClearLabels
            // 
            resources.ApplyResources(this.btnClearLabels, "btnClearLabels");
            this.btnClearLabels.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnClearLabels.Name = "btnClearLabels";
            this.toolTip1.SetToolTip(this.btnClearLabels, resources.GetString("btnClearLabels.ToolTip"));
            this.btnClearLabels.UseVisualStyleBackColor = true;
            // 
            // groupLabelAppearance
            // 
            resources.ApplyResources(this.groupLabelAppearance, "groupLabelAppearance");
            this.groupLabelAppearance.Controls.Add(this.panelLabels);
            this.groupLabelAppearance.Name = "groupLabelAppearance";
            this.groupLabelAppearance.TabStop = false;
            this.toolTip1.SetToolTip(this.groupLabelAppearance, resources.GetString("groupLabelAppearance.ToolTip"));
            // 
            // panelLabels
            // 
            resources.ApplyResources(this.panelLabels, "panelLabels");
            this.panelLabels.Controls.Add(this.udLabelFontSize);
            this.panelLabels.Controls.Add(this.clpLabelFrame);
            this.panelLabels.Controls.Add(this.label15);
            this.panelLabels.Controls.Add(this.chkShowLabels);
            this.panelLabels.Controls.Add(this.chkLabelFrame);
            this.panelLabels.Name = "panelLabels";
            this.toolTip1.SetToolTip(this.panelLabels, resources.GetString("panelLabels.ToolTip"));
            // 
            // udLabelFontSize
            // 
            resources.ApplyResources(this.udLabelFontSize, "udLabelFontSize");
            this.udLabelFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLabelFontSize.Name = "udLabelFontSize";
            this.toolTip1.SetToolTip(this.udLabelFontSize, resources.GetString("udLabelFontSize.ToolTip"));
            this.udLabelFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLabelFontSize.ValueChanged += new System.EventHandler(this.OnLabelFontSizeValueChanged);
            // 
            // clpLabelFrame
            // 
            resources.ApplyResources(this.clpLabelFrame, "clpLabelFrame");
            this.clpLabelFrame.Color = System.Drawing.Color.Black;
            this.clpLabelFrame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpLabelFrame.DropDownHeight = 1;
            this.clpLabelFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpLabelFrame.FormattingEnabled = true;
            this.clpLabelFrame.Items.AddRange(new object[] {
            resources.GetString("clpLabelFrame.Items")});
            this.clpLabelFrame.Name = "clpLabelFrame";
            this.toolTip1.SetToolTip(this.clpLabelFrame, resources.GetString("clpLabelFrame.ToolTip"));
            this.clpLabelFrame.SelectedColorChanged += new System.EventHandler(this.OnLabelFrameColorChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // chkShowLabels
            // 
            resources.ApplyResources(this.chkShowLabels, "chkShowLabels");
            this.chkShowLabels.Name = "chkShowLabels";
            this.toolTip1.SetToolTip(this.chkShowLabels, resources.GetString("chkShowLabels.ToolTip"));
            this.chkShowLabels.UseVisualStyleBackColor = true;
            this.chkShowLabels.CheckedChanged += new System.EventHandler(this.RefreshModel);
            // 
            // chkLabelFrame
            // 
            resources.ApplyResources(this.chkLabelFrame, "chkLabelFrame");
            this.chkLabelFrame.Name = "chkLabelFrame";
            this.toolTip1.SetToolTip(this.chkLabelFrame, resources.GetString("chkLabelFrame.ToolTip"));
            this.chkLabelFrame.UseVisualStyleBackColor = true;
            this.chkLabelFrame.CheckedChanged += new System.EventHandler(this.OnLabelFrameChecked);
            // 
            // groupLabelStyle
            // 
            resources.ApplyResources(this.groupLabelStyle, "groupLabelStyle");
            this.groupLabelStyle.Controls.Add(this.pctLabelPreview);
            this.groupLabelStyle.Name = "groupLabelStyle";
            this.groupLabelStyle.TabStop = false;
            this.toolTip1.SetToolTip(this.groupLabelStyle, resources.GetString("groupLabelStyle.ToolTip"));
            // 
            // pctLabelPreview
            // 
            resources.ApplyResources(this.pctLabelPreview, "pctLabelPreview");
            this.pctLabelPreview.Name = "pctLabelPreview";
            this.pctLabelPreview.TabStop = false;
            this.toolTip1.SetToolTip(this.pctLabelPreview, resources.GetString("pctLabelPreview.ToolTip"));
            this.pctLabelPreview.Click += new System.EventHandler(this.OnLabelPreviewClick);
            // 
            // btnLabelAppearance
            // 
            resources.ApplyResources(this.btnLabelAppearance, "btnLabelAppearance");
            this.btnLabelAppearance.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnLabelAppearance.Name = "btnLabelAppearance";
            this.toolTip1.SetToolTip(this.btnLabelAppearance, resources.GetString("btnLabelAppearance.ToolTip"));
            this.btnLabelAppearance.UseVisualStyleBackColor = true;
            // 
            // tabCharts
            // 
            resources.ApplyResources(this.tabCharts, "tabCharts");
            this.tabCharts.Controls.Add(this.label4);
            this.tabCharts.Controls.Add(this.btnChartAppearance);
            this.tabCharts.Controls.Add(this.btnClearCharts);
            this.tabCharts.Controls.Add(this.groupChartAppearance);
            this.tabCharts.Controls.Add(this.groupCharts);
            this.tabCharts.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_chart24;
            this.tabCharts.ImageSize = new System.Drawing.Size(24, 24);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.ShowCloseButton = true;
            this.tabCharts.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabCharts, resources.GetString("tabCharts.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // btnChartAppearance
            // 
            resources.ApplyResources(this.btnChartAppearance, "btnChartAppearance");
            this.btnChartAppearance.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnChartAppearance.Name = "btnChartAppearance";
            this.toolTip1.SetToolTip(this.btnChartAppearance, resources.GetString("btnChartAppearance.ToolTip"));
            this.btnChartAppearance.UseVisualStyleBackColor = true;
            // 
            // btnClearCharts
            // 
            resources.ApplyResources(this.btnClearCharts, "btnClearCharts");
            this.btnClearCharts.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnClearCharts.Name = "btnClearCharts";
            this.toolTip1.SetToolTip(this.btnClearCharts, resources.GetString("btnClearCharts.ToolTip"));
            this.btnClearCharts.UseVisualStyleBackColor = true;
            // 
            // groupChartAppearance
            // 
            resources.ApplyResources(this.groupChartAppearance, "groupChartAppearance");
            this.groupChartAppearance.Controls.Add(this.btnChartsEditColorScheme);
            this.groupChartAppearance.Controls.Add(this.chkChartsVisible);
            this.groupChartAppearance.Controls.Add(this.label7);
            this.groupChartAppearance.Controls.Add(this.optChartsPie);
            this.groupChartAppearance.Controls.Add(this.icbChartColorScheme);
            this.groupChartAppearance.Controls.Add(this.optChartBars);
            this.groupChartAppearance.Name = "groupChartAppearance";
            this.groupChartAppearance.TabStop = false;
            this.toolTip1.SetToolTip(this.groupChartAppearance, resources.GetString("groupChartAppearance.ToolTip"));
            // 
            // btnChartsEditColorScheme
            // 
            resources.ApplyResources(this.btnChartsEditColorScheme, "btnChartsEditColorScheme");
            this.btnChartsEditColorScheme.BeforeTouchSize = new System.Drawing.Size(29, 20);
            this.btnChartsEditColorScheme.Name = "btnChartsEditColorScheme";
            this.toolTip1.SetToolTip(this.btnChartsEditColorScheme, resources.GetString("btnChartsEditColorScheme.ToolTip"));
            this.btnChartsEditColorScheme.UseVisualStyleBackColor = true;
            // 
            // chkChartsVisible
            // 
            resources.ApplyResources(this.chkChartsVisible, "chkChartsVisible");
            this.chkChartsVisible.Name = "chkChartsVisible";
            this.toolTip1.SetToolTip(this.chkChartsVisible, resources.GetString("chkChartsVisible.ToolTip"));
            this.chkChartsVisible.UseVisualStyleBackColor = true;
            this.chkChartsVisible.CheckedChanged += new System.EventHandler(this.RefreshModel);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // optChartsPie
            // 
            resources.ApplyResources(this.optChartsPie, "optChartsPie");
            this.optChartsPie.Name = "optChartsPie";
            this.toolTip1.SetToolTip(this.optChartsPie, resources.GetString("optChartsPie.ToolTip"));
            this.optChartsPie.UseVisualStyleBackColor = true;
            this.optChartsPie.CheckedChanged += new System.EventHandler(this.RefreshModel);
            // 
            // icbChartColorScheme
            // 
            resources.ApplyResources(this.icbChartColorScheme, "icbChartColorScheme");
            this.icbChartColorScheme.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbChartColorScheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbChartColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbChartColorScheme.FormattingEnabled = true;
            this.icbChartColorScheme.Name = "icbChartColorScheme";
            this.icbChartColorScheme.OutlineColor = System.Drawing.Color.Black;
            this.icbChartColorScheme.Target = MW5.Plugins.Symbology.SchemeTarget.Vector;
            this.toolTip1.SetToolTip(this.icbChartColorScheme, resources.GetString("icbChartColorScheme.ToolTip"));
            this.icbChartColorScheme.SelectedIndexChanged += new System.EventHandler(this.OnChartColorSchemeSelectedIndexChanged);
            // 
            // optChartBars
            // 
            resources.ApplyResources(this.optChartBars, "optChartBars");
            this.optChartBars.Checked = true;
            this.optChartBars.Name = "optChartBars";
            this.optChartBars.TabStop = true;
            this.toolTip1.SetToolTip(this.optChartBars, resources.GetString("optChartBars.ToolTip"));
            this.optChartBars.UseVisualStyleBackColor = true;
            this.optChartBars.CheckedChanged += new System.EventHandler(this.RefreshModel);
            // 
            // groupCharts
            // 
            resources.ApplyResources(this.groupCharts, "groupCharts");
            this.groupCharts.Controls.Add(this.pctCharts);
            this.groupCharts.Name = "groupCharts";
            this.groupCharts.TabStop = false;
            this.toolTip1.SetToolTip(this.groupCharts, resources.GetString("groupCharts.ToolTip"));
            // 
            // pctCharts
            // 
            resources.ApplyResources(this.pctCharts, "pctCharts");
            this.pctCharts.Name = "pctCharts";
            this.pctCharts.TabStop = false;
            this.toolTip1.SetToolTip(this.pctCharts, resources.GetString("pctCharts.ToolTip"));
            this.pctCharts.Click += new System.EventHandler(this.OnChartsClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_options32.png");
            this.imageList1.Images.SetKeyName(1, "img_info32.png");
            this.imageList1.Images.SetKeyName(2, "img_colors32.png");
            this.imageList1.Images.SetKeyName(3, "img_contrast32.png");
            this.imageList1.Images.SetKeyName(4, "img_pyramid32.png");
            this.imageList1.Images.SetKeyName(5, "img_brush24.png");
            this.imageList1.Images.SetKeyName(6, "img_chart24.png");
            this.imageList1.Images.SetKeyName(7, "img_cog24.png");
            this.imageList1.Images.SetKeyName(8, "img_eye24.png");
            this.imageList1.Images.SetKeyName(9, "img_label24.png");
            // 
            // comboBoxAdv1
            // 
            resources.ApplyResources(this.comboBoxAdv1, "comboBoxAdv1");
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(199, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.toolTip1.SetToolTip(this.comboBoxAdv1, resources.GetString("comboBoxAdv1.ToolTip"));
            // 
            // cboMaxScale
            // 
            resources.ApplyResources(this.cboMaxScale, "cboMaxScale");
            this.cboMaxScale.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.cboMaxScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxScale.Name = "cboMaxScale";
            this.toolTip1.SetToolTip(this.cboMaxScale, resources.GetString("cboMaxScale.ToolTip"));
            // 
            // cboMinScale
            // 
            resources.ApplyResources(this.cboMinScale, "cboMinScale");
            this.cboMinScale.BeforeTouchSize = new System.Drawing.Size(141, 21);
            this.cboMinScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinScale.Name = "cboMinScale";
            this.toolTip1.SetToolTip(this.cboMinScale, resources.GetString("cboMinScale.ToolTip"));
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.txtComments);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox7, resources.GetString("groupBox7.ToolTip"));
            // 
            // txtComments
            // 
            resources.ApplyResources(this.txtComments, "txtComments");
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComments.Name = "txtComments";
            this.toolTip1.SetToolTip(this.txtComments, resources.GetString("txtComments.ToolTip"));
            this.txtComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCommentsKeyPress);
            this.txtComments.Validated += new System.EventHandler(this.OnCommentsValidated);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.BeforeTouchSize = new System.Drawing.Size(85, 30);
            this.btnApply.Name = "btnApply";
            this.toolTip1.SetToolTip(this.btnApply, resources.GetString("btnApply.ToolTip"));
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnSaveChangesClick);
            // 
            // toolStripEx1
            // 
            resources.ApplyResources(this.toolStripEx1, "toolStripEx1");
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStyle});
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ThemeName = "Metro";
            this.toolTip1.SetToolTip(this.toolStripEx1, resources.GetString("toolStripEx1.ToolTip"));
            this.toolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // toolStyle
            // 
            resources.ApplyResources(this.toolStyle, "toolStyle");
            this.toolStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSaveStyle,
            this.toolStripSeparator2,
            this.toolRemoveStyle,
            this.toolStripSeparator1,
            this.toolOpenLocation});
            this.toolStyle.ForeColor = System.Drawing.Color.Black;
            this.toolStyle.Image = global::MW5.Plugins.Symbology.Properties.Resources.icon_settings;
            this.toolStyle.Name = "toolStyle";
            // 
            // toolSaveStyle
            // 
            resources.ApplyResources(this.toolSaveStyle, "toolSaveStyle");
            this.toolSaveStyle.Image = global::MW5.Plugins.Symbology.Properties.Resources.icon_save1;
            this.toolSaveStyle.Name = "toolSaveStyle";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolRemoveStyle
            // 
            resources.ApplyResources(this.toolRemoveStyle, "toolRemoveStyle");
            this.toolRemoveStyle.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_remove16;
            this.toolRemoveStyle.Name = "toolRemoveStyle";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolOpenLocation
            // 
            resources.ApplyResources(this.toolOpenLocation, "toolOpenLocation");
            this.toolOpenLocation.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_hard_disk;
            this.toolOpenLocation.Name = "toolOpenLocation";
            // 
            // scaleControl2
            // 
            resources.ApplyResources(this.scaleControl2, "scaleControl2");
            this.scaleControl2.BackColor = System.Drawing.Color.Transparent;
            this.scaleControl2.CurrentScale = -1D;
            this.scaleControl2.FillColor = System.Drawing.Color.LightGreen;
            this.scaleControl2.FillColor2 = System.Drawing.Color.Khaki;
            this.scaleControl2.MaximumScale = 1000000000D;
            this.scaleControl2.MinimimScale = 1.0000004910124416D;
            this.scaleControl2.Name = "scaleControl2";
            this.scaleControl2.OutlineColor = System.Drawing.Color.DarkGray;
            this.scaleControl2.SelectionColor = System.Drawing.Color.Blue;
            this.toolTip1.SetToolTip(this.scaleControl2, resources.GetString("scaleControl2.ToolTip"));
            this.scaleControl2.UseDynamicVisibility = false;
            // 
            // scaleControl1
            // 
            resources.ApplyResources(this.scaleControl1, "scaleControl1");
            this.scaleControl1.BackColor = System.Drawing.Color.Transparent;
            this.scaleControl1.CurrentScale = -1D;
            this.scaleControl1.FillColor = System.Drawing.Color.LightGreen;
            this.scaleControl1.FillColor2 = System.Drawing.Color.Khaki;
            this.scaleControl1.MaximumScale = 1000000000D;
            this.scaleControl1.MinimimScale = 1.0000004910124416D;
            this.scaleControl1.Name = "scaleControl1";
            this.scaleControl1.OutlineColor = System.Drawing.Color.DarkGray;
            this.scaleControl1.SelectionColor = System.Drawing.Color.Blue;
            this.toolTip1.SetToolTip(this.scaleControl1, resources.GetString("scaleControl1.ToolTip"));
            this.scaleControl1.UseDynamicVisibility = false;
            // 
            // VectorStyleView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.toolStripEx1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VectorStyleView";
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBriefInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasourceName)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid1)).EndInit();
            this.tabDefault.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboCollisionMode)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinDrawingSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinLabelingSize)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            this.tabFields.ResumeLayout(false);
            this.tabJoins.ResumeLayout(false);
            this.tabLabels.ResumeLayout(false);
            this.groupLabelAppearance.ResumeLayout(false);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelFontSize)).EndInit();
            this.groupLabelStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLabelPreview)).EndInit();
            this.tabCharts.ResumeLayout(false);
            this.groupChartAppearance.ResumeLayout(false);
            this.groupChartAppearance.PerformLayout();
            this.groupCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCharts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonAdv btnOk;
        private ButtonAdv btnCancel;
        private TabPropertiesControl tabControl1;
        private TabPageAdv tabLabels;
        private TabPageAdv tabDefault;
        private TabPageAdv tabCategories;
        private TabPageAdv tabGeneral;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLayerName;
        private System.Windows.Forms.GroupBox groupLabelStyle;
        private System.Windows.Forms.PictureBox pctLabelPreview;
        private ButtonAdv btnLabelAppearance;
        private System.Windows.Forms.CheckBox chkShowLabels;
        private Office2007ColorPicker clpLabelFrame;
        private System.Windows.Forms.CheckBox chkLabelFrame;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkLayerVisible;
        private System.Windows.Forms.CheckBox chkLayerPreview;
        private System.Windows.Forms.GroupBox groupBox10;
        private MapControl axMap1;
        private System.Windows.Forms.Panel panelLabels;
        private NumericUpDownEx udLabelFontSize;
        private ScaleControl scaleControl2;
        private ScaleControl scaleControl1;
        private TabPageAdv tabJoins;
        private System.Windows.Forms.GroupBox groupLabelAppearance;
        private ButtonAdv btnApply;
        private ButtonAdv btnClearLabels;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox txtComments;
        private TabPageAdv tabCharts;
        private ButtonAdv btnChartAppearance;
        private ButtonAdv btnClearCharts;
        private System.Windows.Forms.GroupBox groupChartAppearance;
        private ButtonAdv btnChartsEditColorScheme;
        private System.Windows.Forms.CheckBox chkChartsVisible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton optChartsPie;
        private ColorSchemeCombo icbChartColorScheme;
        private System.Windows.Forms.RadioButton optChartBars;
        private System.Windows.Forms.GroupBox groupCharts;
        private System.Windows.Forms.PictureBox pctCharts;
        private TabPageAdv tabInfo;
        private System.Windows.Forms.ImageList imageList1;
        private TextBoxExt txtBriefInfo;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv btnProjectionDetails;
        private TextBoxExt txtProjection;
        private System.Windows.Forms.Label label3;
        private TextBoxExt txtDatasourceName;
        private System.Windows.Forms.Label label8;
        private ComboBoxAdv comboBoxAdv1;
        private ComboBoxAdv cboMaxScale;
        private ComboBoxAdv cboMinScale;
        private DynamicVisibilityControl dynamicVisibilityControl1;
        private TabPageAdv tabFields;
        private AttributesControl attributesControl1;
        private ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripDropDownButton toolStyle;
        private System.Windows.Forms.ToolStripMenuItem toolSaveStyle;
        private ButtonAdv btnOpenLocation;
        private System.Windows.Forms.ToolStripMenuItem toolRemoveStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolOpenLocation;
        private JoinControl joinControl1;
        private System.Windows.Forms.CheckBox chkEditMode;
        private System.Windows.Forms.CheckBox chkSpatialIndex;
        private System.Windows.Forms.GroupBox groupBox21;
        private ComboBoxAdv cboCollisionMode;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label12;
        private NumericUpDownEx udMinDrawingSize;
        private NumericUpDownEx udMinLabelingSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox13;
        private ButtonAdv btnClearVisibilityExpression;
        private ButtonAdv btnChangeVisibilityExpression;
        private System.Windows.Forms.TextBox txtLayerExpression;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private InfoGrid infoGrid1;
        private ButtonAdv btnCopyInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}