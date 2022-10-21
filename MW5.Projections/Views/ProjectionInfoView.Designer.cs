using MW5.Projections.Controls;

namespace MW5.Projections.Views
{
    partial class ProjectionInfoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectionInfoView));
            MW5.Api.Concrete.Envelope envelope1 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference1 = new MW5.Api.Concrete.SpatialReference();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabDescription = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtProj4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemarks = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtScope = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabMap = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this._projectionMap1 = new MW5.Projections.Controls.ProjectionMap();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAreaName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabWkt = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnCopyClipboard = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.projectionTextBox1 = new MW5.Projections.Controls.ProjectionTextBox();
            this.tabEsriWkt = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnCopyClipboardEsri = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.projectionTextBoxEsri = new MW5.Projections.Controls.ProjectionTextBox();
            this.tabDialects = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dialectGrid1 = new MW5.Projections.Controls.DialectGrid();
            this.btnClearDialects = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnEditDialect = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRemoveDialect = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAddDialect = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProj4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScope)).BeginInit();
            this.tabMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName)).BeginInit();
            this.tabWkt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.tabEsriWkt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.tabDialects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialectGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ThemeName = "Metro";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            this.btnOk.UseVisualStyle = false;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.BeforeTouchSize = new System.Drawing.Size(450, 455);
            this.tabControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControl1.Controls.Add(this.tabDescription);
            this.tabControl1.Controls.Add(this.tabMap);
            this.tabControl1.Controls.Add(this.tabWkt);
            this.tabControl1.Controls.Add(this.tabEsriWkt);
            this.tabControl1.Controls.Add(this.tabDialects);
            this.tabControl1.FixedSingleBorderColor = System.Drawing.Color.LightGray;
            this.tabControl1.FocusOnTabClick = false;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControl1.ThemeName = "TabRendererMetro";
            // 
            // tabDescription
            // 
            resources.ApplyResources(this.tabDescription, "tabDescription");
            this.tabDescription.Controls.Add(this.label8);
            this.tabDescription.Controls.Add(this.txtName);
            this.tabDescription.Controls.Add(this.txtProj4);
            this.tabDescription.Controls.Add(this.label1);
            this.tabDescription.Controls.Add(this.txtRemarks);
            this.tabDescription.Controls.Add(this.label3);
            this.tabDescription.Controls.Add(this.label4);
            this.tabDescription.Controls.Add(this.txtCode);
            this.tabDescription.Controls.Add(this.label2);
            this.tabDescription.Controls.Add(this.linkLabel1);
            this.tabDescription.Controls.Add(this.txtScope);
            this.tabDescription.Image = null;
            this.tabDescription.ImageSize = new System.Drawing.Size(16, 16);
            this.tabDescription.Name = "tabDescription";
            this.tabDescription.ShowCloseButton = true;
            this.tabDescription.ThemesEnabled = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.BeforeTouchSize = new System.Drawing.Size(409, 172);
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.ThemeName = "Default";
            // 
            // txtProj4
            // 
            resources.ApplyResources(this.txtProj4, "txtProj4");
            this.txtProj4.BeforeTouchSize = new System.Drawing.Size(409, 172);
            this.txtProj4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProj4.Name = "txtProj4";
            this.txtProj4.ReadOnly = true;
            this.txtProj4.ThemeName = "Default";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtRemarks
            // 
            resources.ApplyResources(this.txtRemarks, "txtRemarks");
            this.txtRemarks.BeforeTouchSize = new System.Drawing.Size(409, 172);
            this.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ThemeName = "Default";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.BeforeTouchSize = new System.Drawing.Size(409, 172);
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.ThemeName = "Default";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnEpsgLinkClicked);
            // 
            // txtScope
            // 
            resources.ApplyResources(this.txtScope, "txtScope");
            this.txtScope.BeforeTouchSize = new System.Drawing.Size(409, 172);
            this.txtScope.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScope.Name = "txtScope";
            this.txtScope.ReadOnly = true;
            this.txtScope.ThemeName = "Default";
            // 
            // tabMap
            // 
            resources.ApplyResources(this.tabMap, "tabMap");
            this.tabMap.Controls.Add(this._projectionMap1);
            this.tabMap.Controls.Add(this.label5);
            this.tabMap.Controls.Add(this.txtAreaName);
            this.tabMap.Image = null;
            this.tabMap.ImageSize = new System.Drawing.Size(16, 16);
            this.tabMap.Name = "tabMap";
            this.tabMap.ShowCloseButton = true;
            this.tabMap.ThemesEnabled = false;
            // 
            // _projectionMap1
            // 
            resources.ApplyResources(this._projectionMap1, "_projectionMap1");
            this._projectionMap1.AllowDrop = true;
            this._projectionMap1.AnimationOnZooming = MW5.Api.Enums.AutoToggle.Auto;
            this._projectionMap1.BackgroundColor = System.Drawing.Color.White;
            this._projectionMap1.CurrentScale = 16.948554059192823D;
            this._projectionMap1.CurrentZoom = -1;
            this._projectionMap1.ExpandLayersOnAdding = true;
            this._projectionMap1.ExtentHistory = 20;
            this._projectionMap1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this._projectionMap1.Extents = envelope1;
            this._projectionMap1.GrabProjectionFromData = true;
            this._projectionMap1.InertiaOnPanning = MW5.Api.Enums.AutoToggle.Auto;
            this._projectionMap1.KnownExtents = MW5.Api.Enums.KnownExtents.None;
            this._projectionMap1.Latitude = 0F;
            this._projectionMap1.Longitude = 0F;
            this._projectionMap1.MapCursor = MW5.Api.Enums.MapCursor.ZoomIn;
            this._projectionMap1.MapProjection = MW5.Api.Enums.MapProjection.None;
            this._projectionMap1.MapUnits = MW5.Api.Enums.LengthUnits.Meters;
            this._projectionMap1.MouseWheelSpeed = 0.5D;
            this._projectionMap1.Name = "_projectionMap1";
            spatialReference1.Tag = "";
            this._projectionMap1.Projection = spatialReference1;
            this._projectionMap1.ResizeBehavior = MW5.Api.Enums.ResizeBehavior.Classic;
            this._projectionMap1.ReuseTileBuffer = true;
            this._projectionMap1.ScalebarUnits = MW5.Api.Enums.ScalebarUnits.GoogleStyle;
            this._projectionMap1.ScalebarVisible = true;
            this._projectionMap1.ShowCoordinates = MW5.Api.Enums.CoordinatesDisplay.Auto;
            this._projectionMap1.ShowCoordinatesFormat = MW5.Api.Enums.AngleFormat.Degrees;
            this._projectionMap1.ShowRedrawTime = false;
            this._projectionMap1.ShowVersionNumber = false;
            this._projectionMap1.SystemCursor = MW5.Api.Enums.SystemCursor.MapDefault;
            this._projectionMap1.Tag = "";
            this._projectionMap1.TileProvider = MW5.Api.Enums.TileProvider.None;
            this._projectionMap1.UdCursorHandle = 0;
            this._projectionMap1.UseSeamlessPan = false;
            this._projectionMap1.ZoomBehavior = MW5.Api.Enums.ZoomBehavior.UseTileLevels;
            this._projectionMap1.ZoomBoxStyle = MW5.Api.Enums.ZoomBoxStyle.Blue;
            this._projectionMap1.ZoomPercent = 0.3D;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtAreaName
            // 
            resources.ApplyResources(this.txtAreaName, "txtAreaName");
            this.txtAreaName.BeforeTouchSize = new System.Drawing.Size(409, 172);
            this.txtAreaName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.ReadOnly = true;
            this.txtAreaName.ThemeName = "Default";
            // 
            // tabWkt
            // 
            resources.ApplyResources(this.tabWkt, "tabWkt");
            this.tabWkt.Controls.Add(this.btnCopyClipboard);
            this.tabWkt.Controls.Add(this.gradientPanel1);
            this.tabWkt.Image = null;
            this.tabWkt.ImageSize = new System.Drawing.Size(16, 16);
            this.tabWkt.Name = "tabWkt";
            this.tabWkt.ShowCloseButton = true;
            this.tabWkt.ThemesEnabled = false;
            // 
            // btnCopyClipboard
            // 
            resources.ApplyResources(this.btnCopyClipboard, "btnCopyClipboard");
            this.btnCopyClipboard.BeforeTouchSize = new System.Drawing.Size(110, 21);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Click += new System.EventHandler(this.OnCopyClipboardClick);
            // 
            // gradientPanel1
            // 
            resources.ApplyResources(this.gradientPanel1, "gradientPanel1");
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.projectionTextBox1);
            this.gradientPanel1.Name = "gradientPanel1";
            // 
            // projectionTextBox1
            // 
            resources.ApplyResources(this.projectionTextBox1, "projectionTextBox1");
            this.projectionTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectionTextBox1.Name = "projectionTextBox1";
            // 
            // tabEsriWkt
            // 
            resources.ApplyResources(this.tabEsriWkt, "tabEsriWkt");
            this.tabEsriWkt.Controls.Add(this.btnCopyClipboardEsri);
            this.tabEsriWkt.Controls.Add(this.gradientPanel2);
            this.tabEsriWkt.Image = null;
            this.tabEsriWkt.ImageSize = new System.Drawing.Size(16, 16);
            this.tabEsriWkt.Name = "tabEsriWkt";
            this.tabEsriWkt.ShowCloseButton = true;
            this.tabEsriWkt.ThemesEnabled = false;
            // 
            // btnCopyClipboardEsri
            // 
            resources.ApplyResources(this.btnCopyClipboardEsri, "btnCopyClipboardEsri");
            this.btnCopyClipboardEsri.BeforeTouchSize = new System.Drawing.Size(110, 21);
            this.btnCopyClipboardEsri.Name = "btnCopyClipboardEsri";
            this.btnCopyClipboardEsri.Click += new System.EventHandler(this.btnCopyClipboardEsri_Click);
            // 
            // gradientPanel2
            // 
            resources.ApplyResources(this.gradientPanel2, "gradientPanel2");
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.projectionTextBoxEsri);
            this.gradientPanel2.Name = "gradientPanel2";
            // 
            // projectionTextBoxEsri
            // 
            resources.ApplyResources(this.projectionTextBoxEsri, "projectionTextBoxEsri");
            this.projectionTextBoxEsri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectionTextBoxEsri.Name = "projectionTextBoxEsri";
            // 
            // tabDialects
            // 
            resources.ApplyResources(this.tabDialects, "tabDialects");
            this.tabDialects.Controls.Add(this.dialectGrid1);
            this.tabDialects.Controls.Add(this.btnClearDialects);
            this.tabDialects.Controls.Add(this.btnEditDialect);
            this.tabDialects.Controls.Add(this.btnRemoveDialect);
            this.tabDialects.Controls.Add(this.btnAddDialect);
            this.tabDialects.Controls.Add(this.label6);
            this.tabDialects.Image = null;
            this.tabDialects.ImageSize = new System.Drawing.Size(16, 16);
            this.tabDialects.Name = "tabDialects";
            this.tabDialects.ShowCloseButton = true;
            this.tabDialects.ThemesEnabled = false;
            // 
            // dialectGrid1
            // 
            resources.ApplyResources(this.dialectGrid1, "dialectGrid1");
            this.dialectGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.dialectGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dialectGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.dialectGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.dialectGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.dialectGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.dialectGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.dialectGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.dialectGrid1.BrowseOnly = true;
            this.dialectGrid1.GridLineColor = System.Drawing.Color.White;
            this.dialectGrid1.Name = "dialectGrid1";
            this.dialectGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.dialectGrid1.ShowRowHeaders = false;
            this.dialectGrid1.TableDescriptor.AllowEdit = false;
            this.dialectGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.dialectGrid1.TableOptions.AllowDropDownCell = false;
            this.dialectGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.dialectGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.dialectGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.dialectGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dialectGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.dialectGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.dialectGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.dialectGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.dialectGrid1.UseRightToLeftCompatibleTextBox = true;
            this.dialectGrid1.VersionInfo = "5.0.1.0";
            this.dialectGrid1.WrapWithPanel = true;
            // 
            // btnClearDialects
            // 
            resources.ApplyResources(this.btnClearDialects, "btnClearDialects");
            this.btnClearDialects.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnClearDialects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnClearDialects.BeforeTouchSize = new System.Drawing.Size(69, 21);
            this.btnClearDialects.ForeColor = System.Drawing.Color.White;
            this.btnClearDialects.Name = "btnClearDialects";
            this.btnClearDialects.ThemeName = "Metro";
            this.btnClearDialects.UseVisualStyle = false;
            // 
            // btnEditDialect
            // 
            resources.ApplyResources(this.btnEditDialect, "btnEditDialect");
            this.btnEditDialect.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnEditDialect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnEditDialect.BeforeTouchSize = new System.Drawing.Size(69, 21);
            this.btnEditDialect.ForeColor = System.Drawing.Color.White;
            this.btnEditDialect.Name = "btnEditDialect";
            this.btnEditDialect.ThemeName = "Metro";
            this.btnEditDialect.UseVisualStyle = false;
            // 
            // btnRemoveDialect
            // 
            resources.ApplyResources(this.btnRemoveDialect, "btnRemoveDialect");
            this.btnRemoveDialect.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnRemoveDialect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnRemoveDialect.BeforeTouchSize = new System.Drawing.Size(69, 21);
            this.btnRemoveDialect.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDialect.Name = "btnRemoveDialect";
            this.btnRemoveDialect.ThemeName = "Metro";
            this.btnRemoveDialect.UseVisualStyle = false;
            // 
            // btnAddDialect
            // 
            resources.ApplyResources(this.btnAddDialect, "btnAddDialect");
            this.btnAddDialect.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnAddDialect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnAddDialect.BeforeTouchSize = new System.Drawing.Size(69, 21);
            this.btnAddDialect.ForeColor = System.Drawing.Color.White;
            this.btnAddDialect.Name = "btnAddDialect";
            this.btnAddDialect.ThemeName = "Metro";
            this.btnAddDialect.UseVisualStyle = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // ProjectionInfoView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProjectionInfoView";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDescription.ResumeLayout(false);
            this.tabDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProj4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScope)).EndInit();
            this.tabMap.ResumeLayout(false);
            this.tabMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName)).EndInit();
            this.tabWkt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.tabEsriWkt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.tabDialects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dialectGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControl1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabDescription;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtProj4;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtScope;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabMap;
        private ProjectionMap _projectionMap1;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAreaName;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabWkt;
        private Syncfusion.Windows.Forms.ButtonAdv btnCopyClipboard;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private ProjectionTextBox projectionTextBox1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabDialects;
        private Syncfusion.Windows.Forms.ButtonAdv btnClearDialects;
        private Syncfusion.Windows.Forms.ButtonAdv btnEditDialect;
        private Syncfusion.Windows.Forms.ButtonAdv btnRemoveDialect;
        private Syncfusion.Windows.Forms.ButtonAdv btnAddDialect;
        private System.Windows.Forms.Label label6;
        private DialectGrid dialectGrid1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabEsriWkt;
        private Syncfusion.Windows.Forms.ButtonAdv btnCopyClipboardEsri;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private ProjectionTextBox projectionTextBoxEsri;

    }
}