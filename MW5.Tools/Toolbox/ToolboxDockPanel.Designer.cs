using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Tools.Toolbox
{
    public partial class ToolboxDockPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolboxDockPanel));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this._treeView = new MW5.Tools.Toolbox.ToolboxTreeView();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.mnuRun = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBatchRun = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.txtSearch = new MW5.UI.Controls.WatermarkTextbox();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolRun = new System.Windows.Forms.ToolStripButton();
            this.toolBatchRun = new System.Windows.Forms.ToolStripButton();
            this._textbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._treeView)).BeginInit();
            this.contextMenuStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            resources.ApplyResources(this.splitContainerAdv1, "splitContainerAdv1");
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            resources.ApplyResources(this.splitContainerAdv1.Panel1, "splitContainerAdv1.Panel1");
            this.splitContainerAdv1.Panel1.Controls.Add(this._treeView);
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientPanel1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.toolStripEx1);
            // 
            // splitContainerAdv1.Panel2
            // 
            resources.ApplyResources(this.splitContainerAdv1.Panel2, "splitContainerAdv1.Panel2");
            this.splitContainerAdv1.Panel2.Controls.Add(this._textbox);
            this.splitContainerAdv1.SplitterDistance = 156;
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // _treeView
            // 
            resources.ApplyResources(this._treeView, "_treeView");
            this._treeView.ApplyStyle = true;
            this._treeView.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this._treeView.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this._treeView.BeforeTouchSize = new System.Drawing.Size(252, 94);
            this._treeView.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this._treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._treeView.ContextMenuStrip = this.contextMenuStripEx1;
            // 
            // 
            // 
            this._treeView.HelpTextControl.AccessibleDescription = resources.GetString("_treeView.HelpTextControl.AccessibleDescription");
            this._treeView.HelpTextControl.AccessibleName = resources.GetString("_treeView.HelpTextControl.AccessibleName");
            this._treeView.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("_treeView.HelpTextControl.Anchor")));
            this._treeView.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("_treeView.HelpTextControl.AutoScroll")));
            this._treeView.HelpTextControl.AutoSize = ((bool)(resources.GetObject("_treeView.HelpTextControl.AutoSize")));
            this._treeView.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("_treeView.HelpTextControl.AutoSizeMode")));
            this._treeView.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_treeView.HelpTextControl.BackgroundImage")));
            this._treeView.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("_treeView.HelpTextControl.BackgroundImageLayout")));
            this._treeView.HelpTextControl.BaseThemeName = null;
            this._treeView.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("_treeView.HelpTextControl.Dock")));
            this._treeView.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("_treeView.HelpTextControl.Font")));
            this._treeView.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("_treeView.HelpTextControl.ImeMode")));
            this._treeView.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("_treeView.HelpTextControl.Location")));
            this._treeView.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("_treeView.HelpTextControl.MaximumSize")));
            this._treeView.HelpTextControl.Name = "helpText";
            this._treeView.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("_treeView.HelpTextControl.RightToLeft")));
            this._treeView.HelpTextControl.TabIndex = ((int)(resources.GetObject("_treeView.HelpTextControl.TabIndex")));
            this._treeView.HelpTextControl.Visible = ((bool)(resources.GetObject("_treeView.HelpTextControl.Visible")));
            this._treeView.HideSelection = false;
            this._treeView.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this._treeView.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this._treeView.Name = "_treeView";
            this._treeView.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this._treeView.ShowSuperTooltip = true;
            this._treeView.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this._treeView.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this._treeView.ToolTipControl.AccessibleDescription = resources.GetString("_treeView.ToolTipControl.AccessibleDescription");
            this._treeView.ToolTipControl.AccessibleName = resources.GetString("_treeView.ToolTipControl.AccessibleName");
            this._treeView.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("_treeView.ToolTipControl.Anchor")));
            this._treeView.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("_treeView.ToolTipControl.AutoScroll")));
            this._treeView.ToolTipControl.AutoSize = ((bool)(resources.GetObject("_treeView.ToolTipControl.AutoSize")));
            this._treeView.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("_treeView.ToolTipControl.AutoSizeMode")));
            this._treeView.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_treeView.ToolTipControl.BackgroundImage")));
            this._treeView.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("_treeView.ToolTipControl.BackgroundImageLayout")));
            this._treeView.ToolTipControl.BaseThemeName = null;
            this._treeView.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("_treeView.ToolTipControl.Dock")));
            this._treeView.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("_treeView.ToolTipControl.Font")));
            this._treeView.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("_treeView.ToolTipControl.ImeMode")));
            this._treeView.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("_treeView.ToolTipControl.Location")));
            this._treeView.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("_treeView.ToolTipControl.MaximumSize")));
            this._treeView.ToolTipControl.Name = "toolTip";
            this._treeView.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("_treeView.ToolTipControl.RightToLeft")));
            this._treeView.ToolTipControl.TabIndex = ((int)(resources.GetObject("_treeView.ToolTipControl.TabIndex")));
            this._treeView.ToolTipControl.Visible = ((bool)(resources.GetObject("_treeView.ToolTipControl.Visible")));
            this._treeView.ToolTipDuration = 0;
            // 
            // contextMenuStripEx1
            // 
            resources.ApplyResources(this.contextMenuStripEx1, "contextMenuStripEx1");
            this.contextMenuStripEx1.DropShadowEnabled = false;
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRun,
            this.mnuBatchRun});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
            this.contextMenuStripEx1.ThemeName = "Metro";
            // 
            // mnuRun
            // 
            resources.ApplyResources(this.mnuRun, "mnuRun");
            this.mnuRun.Name = "mnuRun";
            // 
            // mnuBatchRun
            // 
            resources.ApplyResources(this.mnuBatchRun, "mnuBatchRun");
            this.mnuBatchRun.Name = "mnuBatchRun";
            // 
            // gradientPanel1
            // 
            resources.ApplyResources(this.gradientPanel1, "gradientPanel1");
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.txtSearch);
            this.gradientPanel1.Name = "gradientPanel1";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(252, 21);
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FarImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.FarImage")));
            this.txtSearch.FocusBorderColor = System.Drawing.Color.Gray;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSearch.ThemeName = "Metro";
            this.txtSearch.ThemesEnabled = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchKeyDown);
            // 
            // toolStripEx1
            // 
            resources.ApplyResources(this.toolStripEx1, "toolStripEx1");
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRun,
            this.toolBatchRun});
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ShowItemToolTips = true;
            // 
            // toolRun
            // 
            resources.ApplyResources(this.toolRun, "toolRun");
            this.toolRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRun.Image = global::MW5.Tools.Properties.Resources.img_run24;
            this.toolRun.Name = "toolRun";
            this.toolRun.Padding = new System.Windows.Forms.Padding(3);
            // 
            // toolBatchRun
            // 
            resources.ApplyResources(this.toolBatchRun, "toolBatchRun");
            this.toolBatchRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBatchRun.Image = global::MW5.Tools.Properties.Resources.img_run_batch24;
            this.toolBatchRun.Name = "toolBatchRun";
            this.toolBatchRun.Padding = new System.Windows.Forms.Padding(3);
            // 
            // _textbox
            // 
            resources.ApplyResources(this._textbox, "_textbox");
            this._textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._textbox.Name = "_textbox";
            this._textbox.TabStop = false;
            // 
            // ToolboxDockPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.splitContainerAdv1);
            this.Name = "ToolboxDockPanel";
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.PerformLayout();
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._treeView)).EndInit();
            this.contextMenuStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolboxTreeView _treeView;
        private RichTextBox _textbox;
        private SplitContainerAdv splitContainerAdv1;
        private ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem mnuRun;
        private ToolStripMenuItem mnuBatchRun;
        private GradientPanel gradientPanel1;
        private UI.Controls.WatermarkTextbox txtSearch;
        private ToolStripEx toolStripEx1;
        private ToolStripButton toolRun;
        private ToolStripButton toolBatchRun;
    }
}
