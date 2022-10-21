using System.Windows.Forms;
using MW5.Plugins.Symbology.Controls;

namespace MW5.Plugins.Symbology.Views
{
    partial class RasterRenderingSubView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasterRenderingSubView));
            this.groupMinMax = new System.Windows.Forms.GroupBox();
            this.btnDefaultMinMax = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCalculateMinMax = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboSelectedBand = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtMaximum = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMinimum = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboClassification = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnGenerateColorScheme = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRasterRendering = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkUseHistogram = new System.Windows.Forms.CheckBox();
            this.chkAlphaRendering = new System.Windows.Forms.CheckBox();
            this.chkHillshade = new System.Windows.Forms.CheckBox();
            this.groupBuildColorScheme = new System.Windows.Forms.GroupBox();
            this.btnEditColorSchemeList = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkReverseColorScheme = new System.Windows.Forms.CheckBox();
            this.cboGradientModel = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkGradientWithinCategory = new System.Windows.Forms.CheckBox();
            this.colorSchemeCombo1 = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.udBreakCount = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.rgbBandControl1 = new MW5.Plugins.Symbology.Controls.RgbBandControl();
            this.colorSchemeGrid = new MW5.Plugins.Symbology.Controls.RasterColorSchemeGrid();
            this.btnEditColorScheme = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panelSingleBand = new System.Windows.Forms.Panel();
            this.panelColorScheme = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupMinMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSelectedBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRasterRendering)).BeginInit();
            this.groupBuildColorScheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGradientModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBreakCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSchemeGrid)).BeginInit();
            this.panelSingleBand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelColorScheme)).BeginInit();
            this.panelColorScheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMinMax
            // 
            resources.ApplyResources(this.groupMinMax, "groupMinMax");
            this.groupMinMax.Controls.Add(this.btnDefaultMinMax);
            this.groupMinMax.Controls.Add(this.btnCalculateMinMax);
            this.groupMinMax.Controls.Add(this.cboSelectedBand);
            this.groupMinMax.Controls.Add(this.txtMaximum);
            this.groupMinMax.Controls.Add(this.label14);
            this.groupMinMax.Controls.Add(this.txtMinimum);
            this.groupMinMax.Controls.Add(this.label15);
            this.groupMinMax.Name = "groupMinMax";
            this.groupMinMax.TabStop = false;
            // 
            // btnDefaultMinMax
            // 
            resources.ApplyResources(this.btnDefaultMinMax, "btnDefaultMinMax");
            this.btnDefaultMinMax.BeforeTouchSize = new System.Drawing.Size(100, 26);
            this.btnDefaultMinMax.Name = "btnDefaultMinMax";
            // 
            // btnCalculateMinMax
            // 
            resources.ApplyResources(this.btnCalculateMinMax, "btnCalculateMinMax");
            this.btnCalculateMinMax.BeforeTouchSize = new System.Drawing.Size(100, 26);
            this.btnCalculateMinMax.Name = "btnCalculateMinMax";
            // 
            // cboSelectedBand
            // 
            resources.ApplyResources(this.cboSelectedBand, "cboSelectedBand");
            this.cboSelectedBand.BeforeTouchSize = new System.Drawing.Size(239, 25);
            this.cboSelectedBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedBand.Name = "cboSelectedBand";
            this.cboSelectedBand.SelectedIndexChanged += new System.EventHandler(this.cboSelectedBand_SelectedIndexChanged);
            // 
            // txtMaximum
            // 
            resources.ApplyResources(this.txtMaximum, "txtMaximum");
            this.txtMaximum.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMaximum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaximum.DoubleValue = 1D;
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.NegativeColor = System.Drawing.Color.Black;
            this.txtMaximum.ThemeName = "Default";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txtMinimum
            // 
            resources.ApplyResources(this.txtMinimum, "txtMinimum");
            this.txtMinimum.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMinimum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimum.DoubleValue = 1D;
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.NegativeColor = System.Drawing.Color.Black;
            this.txtMinimum.ThemeName = "Default";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // cboClassification
            // 
            resources.ApplyResources(this.cboClassification, "cboClassification");
            this.cboClassification.BeforeTouchSize = new System.Drawing.Size(179, 25);
            this.cboClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassification.Name = "cboClassification";
            this.cboClassification.SelectedIndexChanged += new System.EventHandler(this.cboClassification_SelectedIndexChanged);
            // 
            // btnGenerateColorScheme
            // 
            resources.ApplyResources(this.btnGenerateColorScheme, "btnGenerateColorScheme");
            this.btnGenerateColorScheme.BeforeTouchSize = new System.Drawing.Size(100, 26);
            this.btnGenerateColorScheme.Name = "btnGenerateColorScheme";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboRasterRendering
            // 
            resources.ApplyResources(this.cboRasterRendering, "cboRasterRendering");
            this.cboRasterRendering.BeforeTouchSize = new System.Drawing.Size(337, 25);
            this.cboRasterRendering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRasterRendering.Name = "cboRasterRendering";
            this.cboRasterRendering.SelectedIndexChanged += new System.EventHandler(this.cboRasterRendering_SelectedIndexChanged);
            // 
            // chkUseHistogram
            // 
            resources.ApplyResources(this.chkUseHistogram, "chkUseHistogram");
            this.chkUseHistogram.Name = "chkUseHistogram";
            // 
            // chkAlphaRendering
            // 
            resources.ApplyResources(this.chkAlphaRendering, "chkAlphaRendering");
            this.chkAlphaRendering.Name = "chkAlphaRendering";
            // 
            // chkHillshade
            // 
            resources.ApplyResources(this.chkHillshade, "chkHillshade");
            this.chkHillshade.Name = "chkHillshade";
            // 
            // groupBuildColorScheme
            // 
            resources.ApplyResources(this.groupBuildColorScheme, "groupBuildColorScheme");
            this.groupBuildColorScheme.Controls.Add(this.btnEditColorSchemeList);
            this.groupBuildColorScheme.Controls.Add(this.chkReverseColorScheme);
            this.groupBuildColorScheme.Controls.Add(this.cboGradientModel);
            this.groupBuildColorScheme.Controls.Add(this.chkGradientWithinCategory);
            this.groupBuildColorScheme.Controls.Add(this.chkHillshade);
            this.groupBuildColorScheme.Controls.Add(this.colorSchemeCombo1);
            this.groupBuildColorScheme.Controls.Add(this.btnGenerateColorScheme);
            this.groupBuildColorScheme.Controls.Add(this.udBreakCount);
            this.groupBuildColorScheme.Controls.Add(this.cboClassification);
            this.groupBuildColorScheme.Name = "groupBuildColorScheme";
            this.groupBuildColorScheme.TabStop = false;
            // 
            // btnEditColorSchemeList
            // 
            resources.ApplyResources(this.btnEditColorSchemeList, "btnEditColorSchemeList");
            this.btnEditColorSchemeList.BeforeTouchSize = new System.Drawing.Size(40, 26);
            this.btnEditColorSchemeList.Name = "btnEditColorSchemeList";
            // 
            // chkReverseColorScheme
            // 
            resources.ApplyResources(this.chkReverseColorScheme, "chkReverseColorScheme");
            this.chkReverseColorScheme.Name = "chkReverseColorScheme";
            // 
            // cboGradientModel
            // 
            resources.ApplyResources(this.cboGradientModel, "cboGradientModel");
            this.cboGradientModel.BeforeTouchSize = new System.Drawing.Size(239, 25);
            this.cboGradientModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradientModel.Name = "cboGradientModel";
            // 
            // chkGradientWithinCategory
            // 
            resources.ApplyResources(this.chkGradientWithinCategory, "chkGradientWithinCategory");
            this.chkGradientWithinCategory.Checked = true;
            this.chkGradientWithinCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGradientWithinCategory.Name = "chkGradientWithinCategory";
            this.chkGradientWithinCategory.CheckStateChanged += new System.EventHandler(this.chkGradientWithinCategory_CheckStateChanged);
            // 
            // colorSchemeCombo1
            // 
            resources.ApplyResources(this.colorSchemeCombo1, "colorSchemeCombo1");
            this.colorSchemeCombo1.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.colorSchemeCombo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorSchemeCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorSchemeCombo1.Name = "colorSchemeCombo1";
            this.colorSchemeCombo1.OutlineColor = System.Drawing.Color.Black;
            this.colorSchemeCombo1.Target = MW5.Plugins.Symbology.SchemeTarget.Raster;
            // 
            // udBreakCount
            // 
            resources.ApplyResources(this.udBreakCount, "udBreakCount");
            this.udBreakCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.udBreakCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udBreakCount.Name = "udBreakCount";
            this.udBreakCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chkReverse
            // 
            resources.ApplyResources(this.chkReverse, "chkReverse");
            this.chkReverse.Name = "chkReverse";
            // 
            // rgbBandControl1
            // 
            resources.ApplyResources(this.rgbBandControl1, "rgbBandControl1");
            this.rgbBandControl1.Name = "rgbBandControl1";
            // 
            // colorSchemeGrid
            // 
            resources.ApplyResources(this.colorSchemeGrid, "colorSchemeGrid");
            this.colorSchemeGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.colorSchemeGrid.BackColor = System.Drawing.SystemColors.Window;
            this.colorSchemeGrid.Extended = false;
            this.colorSchemeGrid.GridLineColor = System.Drawing.Color.White;
            this.colorSchemeGrid.Name = "colorSchemeGrid";
            this.colorSchemeGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.colorSchemeGrid.ShowGradient = true;
            this.colorSchemeGrid.ShowRowHeaders = false;
            this.colorSchemeGrid.TableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Visible"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("LowColor"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("HighColor"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Range")});
            this.colorSchemeGrid.UseRightToLeftCompatibleTextBox = true;
            this.colorSchemeGrid.WrapWithPanel = true;
            // 
            // btnEditColorScheme
            // 
            resources.ApplyResources(this.btnEditColorScheme, "btnEditColorScheme");
            this.btnEditColorScheme.BeforeTouchSize = new System.Drawing.Size(91, 28);
            this.btnEditColorScheme.Name = "btnEditColorScheme";
            // 
            // panelSingleBand
            // 
            resources.ApplyResources(this.panelSingleBand, "panelSingleBand");
            this.panelSingleBand.Controls.Add(this.chkUseHistogram);
            this.panelSingleBand.Controls.Add(this.chkAlphaRendering);
            this.panelSingleBand.Controls.Add(this.chkReverse);
            this.panelSingleBand.Name = "panelSingleBand";
            // 
            // panelColorScheme
            // 
            resources.ApplyResources(this.panelColorScheme, "panelColorScheme");
            this.panelColorScheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelColorScheme.Controls.Add(this.colorSchemeGrid);
            this.panelColorScheme.Controls.Add(this.btnEditColorScheme);
            this.panelColorScheme.Name = "panelColorScheme";
            // 
            // RasterRenderingSubView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgbBandControl1);
            this.Controls.Add(this.panelColorScheme);
            this.Controls.Add(this.panelSingleBand);
            this.Controls.Add(this.groupBuildColorScheme);
            this.Controls.Add(this.groupMinMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRasterRendering);
            this.Name = "RasterRenderingSubView";
            this.groupMinMax.ResumeLayout(false);
            this.groupMinMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSelectedBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRasterRendering)).EndInit();
            this.groupBuildColorScheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboGradientModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBreakCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSchemeGrid)).EndInit();
            this.panelSingleBand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelColorScheme)).EndInit();
            this.panelColorScheme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMinMax;
        private Syncfusion.Windows.Forms.ButtonAdv btnGenerateColorScheme;
        private Controls.ImageCombo.ColorSchemeCombo colorSchemeCombo1;
        private System.Windows.Forms.Label label14;
        private RasterColorSchemeGrid colorSchemeGrid;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRasterRendering;
        private CheckBox chkUseHistogram;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboClassification;
        private RgbBandControl rgbBandControl1;
        private CheckBox chkAlphaRendering;
        private CheckBox chkHillshade;
        private Syncfusion.Windows.Forms.ButtonAdv btnCalculateMinMax;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboSelectedBand;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMaximum;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMinimum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBuildColorScheme;
        private CheckBox chkReverse;
        private Syncfusion.Windows.Forms.ButtonAdv btnDefaultMinMax;
        private Syncfusion.Windows.Forms.ButtonAdv btnEditColorScheme;
        private NumericUpDownEx udBreakCount;
        private CheckBox chkGradientWithinCategory;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboGradientModel;
        private System.Windows.Forms.Panel panelSingleBand;
        private Syncfusion.Windows.Forms.Tools.GradientPanel panelColorScheme;
        private CheckBox chkReverseColorScheme;
        private Syncfusion.Windows.Forms.ButtonAdv btnEditColorSchemeList;
    }
}
