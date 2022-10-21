using MW5.Projections.Controls;

namespace MW5.Projections.Forms
{
    partial class ProjectionManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectionManagerForm));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            MW5.Api.Concrete.Envelope envelope1 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference1 = new MW5.Api.Concrete.SpatialReference();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblGcsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPcsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblY = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._projectionTreeView1 = new MW5.Projections.Controls.ProjectionTreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoomToProjection = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnProperties = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoomToMaxExtents = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtScope = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.projectionMap1 = new MW5.Projections.Controls.ProjectionMap();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._projectionTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGcsCount,
            this.lblPcsCount,
            this.lblX,
            this.lblY});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblGcsCount
            // 
            resources.ApplyResources(this.lblGcsCount, "lblGcsCount");
            this.lblGcsCount.Name = "lblGcsCount";
            // 
            // lblPcsCount
            // 
            resources.ApplyResources(this.lblPcsCount, "lblPcsCount");
            this.lblPcsCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblPcsCount.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblPcsCount.Name = "lblPcsCount";
            // 
            // lblX
            // 
            resources.ApplyResources(this.lblX, "lblX");
            this.lblX.Name = "lblX";
            // 
            // lblY
            // 
            resources.ApplyResources(this.lblY, "lblY");
            this.lblY.Name = "lblY";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this._projectionTreeView1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // _projectionTreeView1
            // 
            resources.ApplyResources(this._projectionTreeView1, "_projectionTreeView1");
            this._projectionTreeView1.ApplyStyle = true;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this._projectionTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this._projectionTreeView1.BeforeTouchSize = new System.Drawing.Size(326, 410);
            // 
            // 
            // 
            this._projectionTreeView1.HelpTextControl.AccessibleDescription = resources.GetString("_projectionTreeView1.HelpTextControl.AccessibleDescription");
            this._projectionTreeView1.HelpTextControl.AccessibleName = resources.GetString("_projectionTreeView1.HelpTextControl.AccessibleName");
            this._projectionTreeView1.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("_projectionTreeView1.HelpTextControl.Anchor")));
            this._projectionTreeView1.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("_projectionTreeView1.HelpTextControl.AutoScroll")));
            this._projectionTreeView1.HelpTextControl.AutoSize = ((bool)(resources.GetObject("_projectionTreeView1.HelpTextControl.AutoSize")));
            this._projectionTreeView1.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("_projectionTreeView1.HelpTextControl.AutoSizeMode")));
            this._projectionTreeView1.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_projectionTreeView1.HelpTextControl.BackgroundImage")));
            this._projectionTreeView1.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("_projectionTreeView1.HelpTextControl.BackgroundImageLayout")));
            this._projectionTreeView1.HelpTextControl.BaseThemeName = null;
            this._projectionTreeView1.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("_projectionTreeView1.HelpTextControl.Dock")));
            this._projectionTreeView1.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("_projectionTreeView1.HelpTextControl.Font")));
            this._projectionTreeView1.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("_projectionTreeView1.HelpTextControl.ImeMode")));
            this._projectionTreeView1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("_projectionTreeView1.HelpTextControl.Location")));
            this._projectionTreeView1.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("_projectionTreeView1.HelpTextControl.MaximumSize")));
            this._projectionTreeView1.HelpTextControl.Name = "helpText";
            this._projectionTreeView1.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("_projectionTreeView1.HelpTextControl.RightToLeft")));
            this._projectionTreeView1.HelpTextControl.TabIndex = ((int)(resources.GetObject("_projectionTreeView1.HelpTextControl.TabIndex")));
            this._projectionTreeView1.HelpTextControl.Visible = ((bool)(resources.GetObject("_projectionTreeView1.HelpTextControl.Visible")));
            this._projectionTreeView1.HideSelection = false;
            this._projectionTreeView1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this._projectionTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this._projectionTreeView1.Name = "_projectionTreeView1";
            this._projectionTreeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this._projectionTreeView1.ShowSuperTooltip = true;
            this._projectionTreeView1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this._projectionTreeView1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this._projectionTreeView1.ToolTipControl.AccessibleDescription = resources.GetString("_projectionTreeView1.ToolTipControl.AccessibleDescription");
            this._projectionTreeView1.ToolTipControl.AccessibleName = resources.GetString("_projectionTreeView1.ToolTipControl.AccessibleName");
            this._projectionTreeView1.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("_projectionTreeView1.ToolTipControl.Anchor")));
            this._projectionTreeView1.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("_projectionTreeView1.ToolTipControl.AutoScroll")));
            this._projectionTreeView1.ToolTipControl.AutoSize = ((bool)(resources.GetObject("_projectionTreeView1.ToolTipControl.AutoSize")));
            this._projectionTreeView1.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("_projectionTreeView1.ToolTipControl.AutoSizeMode")));
            this._projectionTreeView1.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_projectionTreeView1.ToolTipControl.BackgroundImage")));
            this._projectionTreeView1.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("_projectionTreeView1.ToolTipControl.BackgroundImageLayout")));
            this._projectionTreeView1.ToolTipControl.BaseThemeName = null;
            this._projectionTreeView1.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("_projectionTreeView1.ToolTipControl.Dock")));
            this._projectionTreeView1.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("_projectionTreeView1.ToolTipControl.Font")));
            this._projectionTreeView1.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("_projectionTreeView1.ToolTipControl.ImeMode")));
            this._projectionTreeView1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("_projectionTreeView1.ToolTipControl.Location")));
            this._projectionTreeView1.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("_projectionTreeView1.ToolTipControl.MaximumSize")));
            this._projectionTreeView1.ToolTipControl.Name = "toolTip";
            this._projectionTreeView1.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("_projectionTreeView1.ToolTipControl.RightToLeft")));
            this._projectionTreeView1.ToolTipControl.TabIndex = ((int)(resources.GetObject("_projectionTreeView1.ToolTipControl.TabIndex")));
            this._projectionTreeView1.ToolTipControl.Visible = ((bool)(resources.GetObject("_projectionTreeView1.ToolTipControl.Visible")));
            this._projectionTreeView1.ToolTipDuration = 0;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.projectionMap1);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnZoomToProjection);
            this.panel1.Controls.Add(this.btnProperties);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnZoomToMaxExtents);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.txtScope);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Name = "panel1";
            // 
            // btnZoomToProjection
            // 
            resources.ApplyResources(this.btnZoomToProjection, "btnZoomToProjection");
            this.btnZoomToProjection.ImageList = this.imageList1;
            this.btnZoomToProjection.Name = "btnZoomToProjection";
            this.btnZoomToProjection.UseVisualStyleBackColor = true;
            this.btnZoomToProjection.Click += new System.EventHandler(this.btnZoomToProjection_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "zoom-extentNew.png");
            this.imageList1.Images.SetKeyName(1, "zoom-selectionNew.png");
            this.imageList1.Images.SetKeyName(2, "page_white_magnify.png");
            // 
            // btnProperties
            // 
            resources.ApplyResources(this.btnProperties, "btnProperties");
            this.btnProperties.ImageList = this.imageList1;
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnZoomToMaxExtents
            // 
            resources.ApplyResources(this.btnZoomToMaxExtents, "btnZoomToMaxExtents");
            this.btnZoomToMaxExtents.ImageList = this.imageList1;
            this.btnZoomToMaxExtents.Name = "btnZoomToMaxExtents";
            this.btnZoomToMaxExtents.UseVisualStyleBackColor = true;
            this.btnZoomToMaxExtents.Click += new System.EventHandler(this.btnZoomToMaxExtents_Click);
            // 
            // txtRemarks
            // 
            resources.ApplyResources(this.txtRemarks, "txtRemarks");
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            // 
            // txtScope
            // 
            resources.ApplyResources(this.txtScope, "txtScope");
            this.txtScope.Name = "txtScope";
            this.txtScope.ReadOnly = true;
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.Name = "txtCode";
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // projectionMap1
            // 
            resources.ApplyResources(this.projectionMap1, "projectionMap1");
            this.projectionMap1.AllowDrop = true;
            this.projectionMap1.AnimationOnZooming = MW5.Api.Enums.AutoToggle.Auto;
            this.projectionMap1.BackgroundColor = System.Drawing.Color.White;
            this.projectionMap1.CurrentScale = 18.105239626129155D;
            this.projectionMap1.CurrentZoom = -1;
            this.projectionMap1.ExpandLayersOnAdding = true;
            this.projectionMap1.ExtentHistory = 20;
            this.projectionMap1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this.projectionMap1.Extents = envelope1;
            this.projectionMap1.GrabProjectionFromData = true;
            this.projectionMap1.InertiaOnPanning = MW5.Api.Enums.AutoToggle.Auto;
            this.projectionMap1.KnownExtents = MW5.Api.Enums.KnownExtents.None;
            this.projectionMap1.Latitude = 0F;
            this.projectionMap1.Longitude = 0F;
            this.projectionMap1.MapCursor = MW5.Api.Enums.MapCursor.ZoomIn;
            this.projectionMap1.MapProjection = MW5.Api.Enums.MapProjection.None;
            this.projectionMap1.MapUnits = MW5.Api.Enums.LengthUnits.Meters;
            this.projectionMap1.MouseWheelSpeed = 0.5D;
            this.projectionMap1.Name = "projectionMap1";
            spatialReference1.Tag = "";
            this.projectionMap1.Projection = spatialReference1;
            this.projectionMap1.ResizeBehavior = MW5.Api.Enums.ResizeBehavior.Classic;
            this.projectionMap1.ReuseTileBuffer = true;
            this.projectionMap1.ScalebarUnits = MW5.Api.Enums.ScalebarUnits.GoogleStyle;
            this.projectionMap1.ScalebarVisible = true;
            this.projectionMap1.ShowCoordinates = MW5.Api.Enums.CoordinatesDisplay.Auto;
            this.projectionMap1.ShowCoordinatesFormat = MW5.Api.Enums.AngleFormat.Degrees;
            this.projectionMap1.ShowRedrawTime = false;
            this.projectionMap1.ShowVersionNumber = false;
            this.projectionMap1.SystemCursor = MW5.Api.Enums.SystemCursor.MapDefault;
            this.projectionMap1.Tag = "";
            this.projectionMap1.TileProvider = MW5.Api.Enums.TileProvider.None;
            this.projectionMap1.UdCursorHandle = -572069904;
            this.projectionMap1.UseSeamlessPan = false;
            this.projectionMap1.ZoomBehavior = MW5.Api.Enums.ZoomBehavior.UseTileLevels;
            this.projectionMap1.ZoomBoxStyle = MW5.Api.Enums.ZoomBoxStyle.Blue;
            this.projectionMap1.ZoomPercent = 0.3D;
            // 
            // ProjectionManagerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MinimizeBox = false;
            this.Name = "ProjectionManagerForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProjectionManagerForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._projectionTreeView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectionTreeView _projectionTreeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblGcsCount;
        private System.Windows.Forms.ToolStripStatusLabel lblPcsCount;
        private System.Windows.Forms.ToolStripStatusLabel lblX;
        private System.Windows.Forms.ToolStripStatusLabel lblY;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private ProjectionMap projectionMap1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtScope;
        private System.Windows.Forms.Button btnZoomToMaxExtents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnZoomToProjection;
        private System.Windows.Forms.ImageList imageList1;
    }
}