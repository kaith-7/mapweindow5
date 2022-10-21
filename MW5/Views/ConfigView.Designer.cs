using MW5.Controls;
using MW5.UI.Controls;

namespace MW5.Views
{
    partial class ConfigView
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigView));
            this._treeViewAdv1 = new MW5.Controls.ConfigTreeView();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
            this.configPageControl1 = new MW5.UI.Controls.ConfigPageControl();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSetDefaults = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRestorePlugins = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestoreToolbars = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this._treeViewAdv1)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _treeViewAdv1
            // 
            this._treeViewAdv1.ApplyStyle = true;
            this._treeViewAdv1.BackColor = System.Drawing.Color.White;
            this._treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Gray);
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            resources.ApplyResources(treeNodeAdvStyleInfo1, "treeNodeAdvStyleInfo1");
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.ShowCheckBox = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            treeNodeAdvStyleInfo1.ThemesEnabled = false;
            this._treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this._treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(174, 472);
            this._treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this._treeViewAdv1.BorderColor = System.Drawing.Color.DarkGray;
            this._treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this._treeViewAdv1, "_treeViewAdv1");
            this._treeViewAdv1.ForeColor = System.Drawing.Color.Black;
            this._treeViewAdv1.GutterSpace = 15;
            // 
            // 
            // 
            this._treeViewAdv1.HelpTextControl.BaseThemeName = null;
            this._treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._treeViewAdv1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("_treeViewAdv1.HelpTextControl.Location")));
            this._treeViewAdv1.HelpTextControl.Name = "helpText";
            this._treeViewAdv1.HelpTextControl.Size = ((System.Drawing.Size)(resources.GetObject("_treeViewAdv1.HelpTextControl.Size")));
            this._treeViewAdv1.HelpTextControl.TabIndex = ((int)(resources.GetObject("_treeViewAdv1.HelpTextControl.TabIndex")));
            this._treeViewAdv1.HelpTextControl.Text = resources.GetString("_treeViewAdv1.HelpTextControl.Text");
            this._treeViewAdv1.HideSelection = false;
            this._treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.Color.Black;
            this._treeViewAdv1.ItemHeight = 30;
            this._treeViewAdv1.LineColor = System.Drawing.Color.DarkGray;
            this._treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this._treeViewAdv1.Name = "_treeViewAdv1";
            this._treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this._treeViewAdv1.SelectedNodeForeColor = System.Drawing.Color.Black;
            this._treeViewAdv1.ShouldSelectNodeOnEnter = false;
            this._treeViewAdv1.ShowFocusRect = false;
            this._treeViewAdv1.ShowLines = false;
            this._treeViewAdv1.ShowSuperTooltip = false;
            this._treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this._treeViewAdv1.ThemeName = "Metro";
            this._treeViewAdv1.ThemesEnabled = false;
            this._treeViewAdv1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this._treeViewAdv1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this._treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this._treeViewAdv1.ToolTipControl.BaseThemeName = null;
            this._treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._treeViewAdv1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("_treeViewAdv1.ToolTipControl.Location")));
            this._treeViewAdv1.ToolTipControl.Name = "toolTip";
            this._treeViewAdv1.ToolTipControl.Size = ((System.Drawing.Size)(resources.GetObject("_treeViewAdv1.ToolTipControl.Size")));
            this._treeViewAdv1.ToolTipControl.TabIndex = ((int)(resources.GetObject("_treeViewAdv1.ToolTipControl.TabIndex")));
            this._treeViewAdv1.ToolTipControl.Text = resources.GetString("_treeViewAdv1.ToolTipControl.Text");
            this._treeViewAdv1.ToolTipDuration = 0;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(82, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ThemeName = "OfficeXP";
            this.btnCancel.UseVisualStyle = false;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP;
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(82, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "OfficeXP";
            this.btnOk.UseVisualStyle = false;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(89, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.ThemeName = "OfficeXP";
            this.btnSave.UseVisualStyle = false;
            // 
            // configPageControl1
            // 
            this.configPageControl1.ConfigPage = null;
            this.configPageControl1.Description = " 一些常规选项的详细说明。";
            resources.ApplyResources(this.configPageControl1, "configPageControl1");
            this.configPageControl1.Icon = ((System.Drawing.Image)(resources.GetObject("configPageControl1.Icon")));
            this.configPageControl1.Name = "configPageControl1";
            // 
            // toolStripEx1
            // 
            resources.ApplyResources(this.toolStripEx1, "toolStripEx1");
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOptions});
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ThemeName = "Metro";
            this.toolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // toolOptions
            // 
            this.toolOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpenFolder,
            this.toolStripSeparator1,
            this.toolSetDefaults,
            this.toolStripSeparator2,
            this.toolRestorePlugins,
            this.toolRestoreToolbars});
            this.toolOptions.ForeColor = System.Drawing.Color.Black;
            this.toolOptions.Image = global::MW5.Properties.Resources.icon_settings;
            resources.ApplyResources(this.toolOptions, "toolOptions");
            this.toolOptions.Name = "toolOptions";
            // 
            // toolOpenFolder
            // 
            this.toolOpenFolder.Image = global::MW5.Properties.Resources.icon_folder;
            this.toolOpenFolder.Name = "toolOpenFolder";
            resources.ApplyResources(this.toolOpenFolder, "toolOpenFolder");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolSetDefaults
            // 
            this.toolSetDefaults.Image = global::MW5.Properties.Resources.img_default24;
            this.toolSetDefaults.Name = "toolSetDefaults";
            resources.ApplyResources(this.toolSetDefaults, "toolSetDefaults");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolRestorePlugins
            // 
            this.toolRestorePlugins.Image = global::MW5.Properties.Resources.img_plugin32;
            this.toolRestorePlugins.Name = "toolRestorePlugins";
            resources.ApplyResources(this.toolRestorePlugins, "toolRestorePlugins");
            // 
            // toolRestoreToolbars
            // 
            this.toolRestoreToolbars.Name = "toolRestoreToolbars";
            resources.ApplyResources(this.toolRestoreToolbars, "toolRestoreToolbars");
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.configPageControl1);
            this.splitContainer1.Panel1.Controls.Add(this._treeViewAdv1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripEx1);
            this.splitContainer1.Panel2.Controls.Add(this.btnOk);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            // 
            // ConfigView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.splitContainer1);
            this.Name = "ConfigView";
            ((System.ComponentModel.ISupportInitialize)(this._treeViewAdv1)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ConfigTreeView _treeViewAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.ButtonAdv btnSave;
        private ConfigPageControl configPageControl1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripDropDownButton toolOptions;
        private System.Windows.Forms.ToolStripMenuItem toolSetDefaults;
        private System.Windows.Forms.ToolStripMenuItem toolRestorePlugins;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolRestoreToolbars;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}