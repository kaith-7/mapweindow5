using MW5.Plugins.ImageRegistration.Controls;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.ImageRegistration.Views
{
    partial class ImageRegistrationView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageRegistrationView));
            MW5.Api.Concrete.Envelope envelope1 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference1 = new MW5.Api.Concrete.SpatialReference();
            MW5.Api.Concrete.Envelope envelope2 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference2 = new MW5.Api.Concrete.SpatialReference();
            this.splitContainer1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.mapControl1 = new MW5.Api.Map.MapControl();
            this.label4 = new System.Windows.Forms.Label();
            this.mapControl2 = new MW5.Api.Map.MapControl();
            this.btnRemovePoint = new System.Windows.Forms.Button();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.statusPointCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.status1 = new Syncfusion.Windows.Forms.Tools.StatusStripButton();
            this.statusError = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pointPairGrid1 = new MW5.Plugins.ImageRegistration.Controls.PointPairGrid();
            this.btnZoomToPoint = new System.Windows.Forms.Button();
            this.btnClearPoints = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnApply = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnLoadImage = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnZoomMax = new System.Windows.Forms.Button();
            this.mnuZoomIn = new System.Windows.Forms.RadioButton();
            this.mnuZoomOut = new System.Windows.Forms.RadioButton();
            this.mnuPan = new System.Windows.Forms.RadioButton();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.mnuSelect = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointPairGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.BeforeTouchSize = 7;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.mapControl1);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.mapControl2);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.splitContainer1.SplitterDistance = 549;
            this.splitContainer1.ThemeName = "None";
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Name = "label3";
            this.label3.Tag = "<has background color>";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // mapControl1
            // 
            resources.ApplyResources(this.mapControl1, "mapControl1");
            this.mapControl1.AllowDrop = true;
            this.mapControl1.AnimationOnZooming = MW5.Api.Enums.AutoToggle.Auto;
            this.mapControl1.BackgroundColor = System.Drawing.Color.White;
            this.mapControl1.CurrentScale = 11.319912161126455D;
            this.mapControl1.CurrentZoom = -1;
            this.mapControl1.ExpandLayersOnAdding = true;
            this.mapControl1.ExtentHistory = 20;
            this.mapControl1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this.mapControl1.Extents = envelope1;
            this.mapControl1.GrabProjectionFromData = true;
            this.mapControl1.InertiaOnPanning = MW5.Api.Enums.AutoToggle.Auto;
            this.mapControl1.KnownExtents = MW5.Api.Enums.KnownExtents.None;
            this.mapControl1.Latitude = 0F;
            this.mapControl1.Longitude = 0F;
            this.mapControl1.MapCursor = MW5.Api.Enums.MapCursor.ZoomIn;
            this.mapControl1.MapProjection = MW5.Api.Enums.MapProjection.None;
            this.mapControl1.MapUnits = MW5.Api.Enums.LengthUnits.Meters;
            this.mapControl1.MouseWheelSpeed = 0.5D;
            this.mapControl1.Name = "mapControl1";
            spatialReference1.Tag = "";
            this.mapControl1.Projection = spatialReference1;
            this.mapControl1.ResizeBehavior = MW5.Api.Enums.ResizeBehavior.Classic;
            this.mapControl1.ReuseTileBuffer = true;
            this.mapControl1.ScalebarUnits = MW5.Api.Enums.ScalebarUnits.GoogleStyle;
            this.mapControl1.ScalebarVisible = false;
            this.mapControl1.ShapeLayerDrawFill = true;
            this.mapControl1.ShowCoordinates = MW5.Api.Enums.CoordinatesDisplay.Auto;
            this.mapControl1.ShowCoordinatesFormat = MW5.Api.Enums.AngleFormat.Degrees;
            this.mapControl1.ShowRedrawTime = false;
            this.mapControl1.ShowVersionNumber = false;
            this.mapControl1.SystemCursor = MW5.Api.Enums.SystemCursor.MapDefault;
            this.mapControl1.Tag = "";
            this.mapControl1.TileProvider = MW5.Api.Enums.TileProvider.None;
            this.toolTip1.SetToolTip(this.mapControl1, resources.GetString("mapControl1.ToolTip"));
            this.mapControl1.UdCursorHandle = 0;
            this.mapControl1.UseSeamlessPan = false;
            this.mapControl1.ZoomBehavior = MW5.Api.Enums.ZoomBehavior.Default;
            this.mapControl1.ZoomBoxStyle = MW5.Api.Enums.ZoomBoxStyle.Blue;
            this.mapControl1.ZoomPercent = 0.3D;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Name = "label4";
            this.label4.Tag = "<has background color>";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // mapControl2
            // 
            resources.ApplyResources(this.mapControl2, "mapControl2");
            this.mapControl2.AllowDrop = true;
            this.mapControl2.AnimationOnZooming = MW5.Api.Enums.AutoToggle.Auto;
            this.mapControl2.BackgroundColor = System.Drawing.Color.White;
            this.mapControl2.CurrentScale = 11.258167185702128D;
            this.mapControl2.CurrentZoom = -1;
            this.mapControl2.ExpandLayersOnAdding = true;
            this.mapControl2.ExtentHistory = 20;
            this.mapControl2.ExtentPad = 0.02D;
            envelope2.Tag = "";
            this.mapControl2.Extents = envelope2;
            this.mapControl2.GrabProjectionFromData = true;
            this.mapControl2.InertiaOnPanning = MW5.Api.Enums.AutoToggle.Auto;
            this.mapControl2.KnownExtents = MW5.Api.Enums.KnownExtents.None;
            this.mapControl2.Latitude = 0F;
            this.mapControl2.Longitude = 0F;
            this.mapControl2.MapCursor = MW5.Api.Enums.MapCursor.ZoomIn;
            this.mapControl2.MapProjection = MW5.Api.Enums.MapProjection.None;
            this.mapControl2.MapUnits = MW5.Api.Enums.LengthUnits.Meters;
            this.mapControl2.MouseWheelSpeed = 0.5D;
            this.mapControl2.Name = "mapControl2";
            spatialReference2.Tag = "";
            this.mapControl2.Projection = spatialReference2;
            this.mapControl2.ResizeBehavior = MW5.Api.Enums.ResizeBehavior.Classic;
            this.mapControl2.ReuseTileBuffer = true;
            this.mapControl2.ScalebarUnits = MW5.Api.Enums.ScalebarUnits.GoogleStyle;
            this.mapControl2.ScalebarVisible = false;
            this.mapControl2.ShapeLayerDrawFill = true;
            this.mapControl2.ShowCoordinates = MW5.Api.Enums.CoordinatesDisplay.Auto;
            this.mapControl2.ShowCoordinatesFormat = MW5.Api.Enums.AngleFormat.Degrees;
            this.mapControl2.ShowRedrawTime = false;
            this.mapControl2.ShowVersionNumber = false;
            this.mapControl2.SystemCursor = MW5.Api.Enums.SystemCursor.MapDefault;
            this.mapControl2.Tag = "";
            this.mapControl2.TileProvider = MW5.Api.Enums.TileProvider.None;
            this.toolTip1.SetToolTip(this.mapControl2, resources.GetString("mapControl2.ToolTip"));
            this.mapControl2.UdCursorHandle = 0;
            this.mapControl2.UseSeamlessPan = false;
            this.mapControl2.ZoomBehavior = MW5.Api.Enums.ZoomBehavior.UseTileLevels;
            this.mapControl2.ZoomBoxStyle = MW5.Api.Enums.ZoomBoxStyle.Blue;
            this.mapControl2.ZoomPercent = 0.3D;
            // 
            // btnRemovePoint
            // 
            resources.ApplyResources(this.btnRemovePoint, "btnRemovePoint");
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.toolTip1.SetToolTip(this.btnRemovePoint, resources.GetString("btnRemovePoint.ToolTip"));
            this.btnRemovePoint.UseVisualStyleBackColor = true;
            this.btnRemovePoint.Click += new System.EventHandler(this.OnRemoveClick);
            // 
            // statusStripEx1
            // 
            resources.ApplyResources(this.statusStripEx1, "statusStripEx1");
            this.statusStripEx1.BackColor = System.Drawing.Color.PaleGreen;
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(1114, 28);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPointCount,
            this.status1,
            this.statusError});
            this.statusStripEx1.MetroColor = System.Drawing.Color.PaleGreen;
            this.statusStripEx1.Name = "statusStripEx1";
            this.toolTip1.SetToolTip(this.statusStripEx1, resources.GetString("statusStripEx1.ToolTip"));
            // 
            // statusPointCount
            // 
            resources.ApplyResources(this.statusPointCount, "statusPointCount");
            this.statusPointCount.Name = "statusPointCount";
            this.statusPointCount.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            // 
            // status1
            // 
            resources.ApplyResources(this.status1, "status1");
            this.status1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.status1.Name = "status1";
            // 
            // statusError
            // 
            resources.ApplyResources(this.statusError, "statusError");
            this.statusError.Name = "statusError";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(129, 29);
            this.btnCancel.Image = global::MW5.Plugins.ImageRegistration.Properties.Resources.img_cancel24;
            this.btnCancel.Name = "btnCancel";
            this.toolTip1.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            // 
            // pointPairGrid1
            // 
            resources.ApplyResources(this.pointPairGrid1, "pointPairGrid1");
            this.pointPairGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.pointPairGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pointPairGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.pointPairGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.pointPairGrid1.GridLineColor = System.Drawing.Color.White;
            this.pointPairGrid1.Name = "pointPairGrid1";
            this.pointPairGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.pointPairGrid1.ShowRowHeaders = false;
            this.pointPairGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.pointPairGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.pointPairGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.pointPairGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.pointPairGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.pointPairGrid1, resources.GetString("pointPairGrid1.ToolTip"));
            this.pointPairGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.pointPairGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.pointPairGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.pointPairGrid1.UseRightToLeftCompatibleTextBox = true;
            this.pointPairGrid1.VersionInfo = "0.0.1.0";
            this.pointPairGrid1.WrapWithPanel = true;
            // 
            // btnZoomToPoint
            // 
            resources.ApplyResources(this.btnZoomToPoint, "btnZoomToPoint");
            this.btnZoomToPoint.Name = "btnZoomToPoint";
            this.toolTip1.SetToolTip(this.btnZoomToPoint, resources.GetString("btnZoomToPoint.ToolTip"));
            this.btnZoomToPoint.UseVisualStyleBackColor = true;
            this.btnZoomToPoint.Click += new System.EventHandler(this.OnZoomToPointClick);
            // 
            // btnClearPoints
            // 
            resources.ApplyResources(this.btnClearPoints, "btnClearPoints");
            this.btnClearPoints.Name = "btnClearPoints";
            this.toolTip1.SetToolTip(this.btnClearPoints, resources.GetString("btnClearPoints.ToolTip"));
            this.btnClearPoints.UseVisualStyleBackColor = true;
            this.btnClearPoints.Click += new System.EventHandler(this.OnClearPointsClick);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.BeforeTouchSize = new System.Drawing.Size(129, 29);
            this.btnApply.Image = global::MW5.Plugins.ImageRegistration.Properties.Resources.img_apply24;
            this.btnApply.Name = "btnApply";
            this.toolTip1.SetToolTip(this.btnApply, resources.GetString("btnApply.ToolTip"));
            // 
            // btnLoadImage
            // 
            resources.ApplyResources(this.btnLoadImage, "btnLoadImage");
            this.btnLoadImage.BeforeTouchSize = new System.Drawing.Size(129, 29);
            this.btnLoadImage.Image = global::MW5.Plugins.ImageRegistration.Properties.Resources.img_folder24;
            this.btnLoadImage.Name = "btnLoadImage";
            this.toolTip1.SetToolTip(this.btnLoadImage, resources.GetString("btnLoadImage.ToolTip"));
            // 
            // btnZoomMax
            // 
            resources.ApplyResources(this.btnZoomMax, "btnZoomMax");
            this.btnZoomMax.Image = global::MW5.Plugins.ImageRegistration.Properties.Resources.img_zoom_max24;
            this.btnZoomMax.Name = "btnZoomMax";
            this.toolTip1.SetToolTip(this.btnZoomMax, resources.GetString("btnZoomMax.ToolTip"));
            this.btnZoomMax.UseVisualStyleBackColor = true;
            this.btnZoomMax.Click += new System.EventHandler(this.OnZoomMaxClick);
            // 
            // mnuZoomIn
            // 
            resources.ApplyResources(this.mnuZoomIn, "mnuZoomIn");
            this.mnuZoomIn.Image = global::MW5.Plugins.ImageRegistration.Properties.Resources.img_zoom_in24;
            this.mnuZoomIn.Name = "mnuZoomIn";
            this.toolTip1.SetToolTip(this.mnuZoomIn, resources.GetString("mnuZoomIn.ToolTip"));
            this.mnuZoomIn.UseVisualStyleBackColor = true;
            this.mnuZoomIn.CheckedChanged += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // mnuZoomOut
            // 
            resources.ApplyResources(this.mnuZoomOut, "mnuZoomOut");
            this.mnuZoomOut.Image = global::MW5.Plugins.ImageRegistration.Properties.Resources.img_zoom_out24;
            this.mnuZoomOut.Name = "mnuZoomOut";
            this.toolTip1.SetToolTip(this.mnuZoomOut, resources.GetString("mnuZoomOut.ToolTip"));
            this.mnuZoomOut.UseVisualStyleBackColor = true;
            this.mnuZoomOut.CheckedChanged += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // mnuPan
            // 
            resources.ApplyResources(this.mnuPan, "mnuPan");
            this.mnuPan.Image = global::MW5.Plugins.ImageRegistration.Properties.Resources.img_pan24;
            this.mnuPan.Name = "mnuPan";
            this.toolTip1.SetToolTip(this.mnuPan, resources.GetString("mnuPan.ToolTip"));
            this.mnuPan.UseVisualStyleBackColor = true;
            this.mnuPan.CheckedChanged += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(129, 30);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.toolTip1.SetToolTip(this.btnClose, resources.GetString("btnClose.ToolTip"));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mnuSelect
            // 
            resources.ApplyResources(this.mnuSelect, "mnuSelect");
            this.mnuSelect.Name = "mnuSelect";
            this.toolTip1.SetToolTip(this.mnuSelect, resources.GetString("mnuSelect.ToolTip"));
            this.mnuSelect.UseVisualStyleBackColor = true;
            this.mnuSelect.Click += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // ImageRegistrationView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.mnuSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearPoints);
            this.Controls.Add(this.btnZoomToPoint);
            this.Controls.Add(this.pointPairGrid1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.statusStripEx1);
            this.Controls.Add(this.btnZoomMax);
            this.Controls.Add(this.mnuZoomIn);
            this.Controls.Add(this.mnuZoomOut);
            this.Controls.Add(this.mnuPan);
            this.Controls.Add(this.btnRemovePoint);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.MinimizeBox = false;
            this.Name = "ImageRegistrationView";
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointPairGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainerAdv splitContainer1;
        private System.Windows.Forms.Button btnRemovePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton mnuSelect;
        private System.Windows.Forms.RadioButton mnuPan;
        private System.Windows.Forms.RadioButton mnuZoomOut;
        private System.Windows.Forms.RadioButton mnuZoomIn;
        private System.Windows.Forms.Button btnZoomMax;
        private Api.Map.MapControl mapControl1;
        private Api.Map.MapControl mapControl2;
        private StatusStripEx statusStripEx1;
        private Syncfusion.Windows.Forms.ButtonAdv btnApply;
        private Syncfusion.Windows.Forms.ButtonAdv btnLoadImage;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private System.Windows.Forms.ToolStripStatusLabel statusPointCount;
        private StatusStripButton status1;
        private PointPairGrid pointPairGrid1;
        private System.Windows.Forms.ToolStripStatusLabel statusError;
        private System.Windows.Forms.Button btnZoomToPoint;
        private System.Windows.Forms.Button btnClearPoints;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
    }
}