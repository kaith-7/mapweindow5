using System.ComponentModel;
using System.Windows.Forms;
using MW5.Data.Repository;
using MW5.Plugins.Repository.Properties;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.Repository.Views
{
    partial class RepositoryDockPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepositoryDockPanel));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.treeViewAdv1 = new MW5.Data.Repository.RepositoryTreeView();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.mnuAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddFolderToMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddToMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGdalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddTms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRemoveTms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolImportTms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClearTms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolRemoveFolder = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.contextMenuStripEx1.SuspendLayout();
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
            this.splitContainerAdv1.Panel1.Controls.Add(this.treeViewAdv1);
            // 
            // splitContainerAdv1.Panel2
            // 
            resources.ApplyResources(this.splitContainerAdv1.Panel2, "splitContainerAdv1.Panel2");
            this.splitContainerAdv1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainerAdv1.SplitterDistance = 500;
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // treeViewAdv1
            // 
            resources.ApplyResources(this.treeViewAdv1, "treeViewAdv1");
            this.treeViewAdv1.ApplyStyle = true;
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo2.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo2.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo2)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(330, 500);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ContextMenuStrip = this.contextMenuStripEx1;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.AccessibleDescription = resources.GetString("treeViewAdv1.HelpTextControl.AccessibleDescription");
            this.treeViewAdv1.HelpTextControl.AccessibleName = resources.GetString("treeViewAdv1.HelpTextControl.AccessibleName");
            this.treeViewAdv1.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("treeViewAdv1.HelpTextControl.Anchor")));
            this.treeViewAdv1.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("treeViewAdv1.HelpTextControl.AutoScroll")));
            this.treeViewAdv1.HelpTextControl.AutoSize = ((bool)(resources.GetObject("treeViewAdv1.HelpTextControl.AutoSize")));
            this.treeViewAdv1.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("treeViewAdv1.HelpTextControl.AutoSizeMode")));
            this.treeViewAdv1.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeViewAdv1.HelpTextControl.BackgroundImage")));
            this.treeViewAdv1.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("treeViewAdv1.HelpTextControl.BackgroundImageLayout")));
            this.treeViewAdv1.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("treeViewAdv1.HelpTextControl.Dock")));
            this.treeViewAdv1.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("treeViewAdv1.HelpTextControl.Font")));
            this.treeViewAdv1.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("treeViewAdv1.HelpTextControl.ImeMode")));
            this.treeViewAdv1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("treeViewAdv1.HelpTextControl.Location")));
            this.treeViewAdv1.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("treeViewAdv1.HelpTextControl.MaximumSize")));
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("treeViewAdv1.HelpTextControl.RightToLeft")));
            this.treeViewAdv1.HelpTextControl.Size = ((System.Drawing.Size)(resources.GetObject("treeViewAdv1.HelpTextControl.Size")));
            this.treeViewAdv1.HelpTextControl.TabIndex = ((int)(resources.GetObject("treeViewAdv1.HelpTextControl.TabIndex")));
            this.treeViewAdv1.HelpTextControl.Text = resources.GetString("treeViewAdv1.HelpTextControl.Text");
            this.treeViewAdv1.HelpTextControl.Visible = ((bool)(resources.GetObject("treeViewAdv1.HelpTextControl.Visible")));
            this.treeViewAdv1.HideSelection = false;
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.ItemHeight = 18;
            this.treeViewAdv1.LoadOnDemand = true;
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.ShowSuperTooltip = false;
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv1.ThemeName = "Metro";
            this.treeViewAdv1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.treeViewAdv1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.AccessibleDescription = resources.GetString("treeViewAdv1.ToolTipControl.AccessibleDescription");
            this.treeViewAdv1.ToolTipControl.AccessibleName = resources.GetString("treeViewAdv1.ToolTipControl.AccessibleName");
            this.treeViewAdv1.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("treeViewAdv1.ToolTipControl.Anchor")));
            this.treeViewAdv1.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("treeViewAdv1.ToolTipControl.AutoScroll")));
            this.treeViewAdv1.ToolTipControl.AutoSize = ((bool)(resources.GetObject("treeViewAdv1.ToolTipControl.AutoSize")));
            this.treeViewAdv1.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("treeViewAdv1.ToolTipControl.AutoSizeMode")));
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeViewAdv1.ToolTipControl.BackgroundImage")));
            this.treeViewAdv1.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("treeViewAdv1.ToolTipControl.BackgroundImageLayout")));
            this.treeViewAdv1.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("treeViewAdv1.ToolTipControl.Dock")));
            this.treeViewAdv1.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("treeViewAdv1.ToolTipControl.Font")));
            this.treeViewAdv1.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("treeViewAdv1.ToolTipControl.ImeMode")));
            this.treeViewAdv1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("treeViewAdv1.ToolTipControl.Location")));
            this.treeViewAdv1.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("treeViewAdv1.ToolTipControl.MaximumSize")));
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("treeViewAdv1.ToolTipControl.RightToLeft")));
            this.treeViewAdv1.ToolTipControl.Size = ((System.Drawing.Size)(resources.GetObject("treeViewAdv1.ToolTipControl.Size")));
            this.treeViewAdv1.ToolTipControl.TabIndex = ((int)(resources.GetObject("treeViewAdv1.ToolTipControl.TabIndex")));
            this.treeViewAdv1.ToolTipControl.Text = resources.GetString("treeViewAdv1.ToolTipControl.Text");
            this.treeViewAdv1.ToolTipControl.Visible = ((bool)(resources.GetObject("treeViewAdv1.ToolTipControl.Visible")));
            this.treeViewAdv1.ToolTipDuration = 3000;
            // 
            // contextMenuStripEx1
            // 
            resources.ApplyResources(this.contextMenuStripEx1, "contextMenuStripEx1");
            this.contextMenuStripEx1.DropShadowEnabled = false;
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddFolder,
            this.mnuRemoveFolder,
            this.mnuAddFolderToMap,
            this.mnuAddToMap,
            this.mnuRemoveFile,
            this.mnuGdalInfo,
            this.mnuRefresh,
            this.mnuOpenLocation,
            this.mnuAddConnection,
            this.mnuRemoveConnection,
            this.mnuRemoveLayer,
            this.toolAddTms,
            this.toolRemoveTms,
            this.toolProperties,
            this.toolImportTms,
            this.toolClearTms,
            this.toolHelp});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
            this.contextMenuStripEx1.ThemeName = "Metro";
            // 
            // mnuAddFolder
            // 
            resources.ApplyResources(this.mnuAddFolder, "mnuAddFolder");
            this.mnuAddFolder.Name = "mnuAddFolder";
            // 
            // mnuRemoveFolder
            // 
            resources.ApplyResources(this.mnuRemoveFolder, "mnuRemoveFolder");
            this.mnuRemoveFolder.Name = "mnuRemoveFolder";
            // 
            // mnuAddFolderToMap
            // 
            resources.ApplyResources(this.mnuAddFolderToMap, "mnuAddFolderToMap");
            this.mnuAddFolderToMap.Name = "mnuAddFolderToMap";
            // 
            // mnuAddToMap
            // 
            resources.ApplyResources(this.mnuAddToMap, "mnuAddToMap");
            this.mnuAddToMap.Name = "mnuAddToMap";
            // 
            // mnuRemoveFile
            // 
            resources.ApplyResources(this.mnuRemoveFile, "mnuRemoveFile");
            this.mnuRemoveFile.Name = "mnuRemoveFile";
            // 
            // mnuGdalInfo
            // 
            resources.ApplyResources(this.mnuGdalInfo, "mnuGdalInfo");
            this.mnuGdalInfo.Name = "mnuGdalInfo";
            // 
            // mnuRefresh
            // 
            resources.ApplyResources(this.mnuRefresh, "mnuRefresh");
            this.mnuRefresh.Name = "mnuRefresh";
            // 
            // mnuOpenLocation
            // 
            resources.ApplyResources(this.mnuOpenLocation, "mnuOpenLocation");
            this.mnuOpenLocation.Name = "mnuOpenLocation";
            // 
            // mnuAddConnection
            // 
            resources.ApplyResources(this.mnuAddConnection, "mnuAddConnection");
            this.mnuAddConnection.Name = "mnuAddConnection";
            // 
            // mnuRemoveConnection
            // 
            resources.ApplyResources(this.mnuRemoveConnection, "mnuRemoveConnection");
            this.mnuRemoveConnection.Name = "mnuRemoveConnection";
            // 
            // mnuRemoveLayer
            // 
            resources.ApplyResources(this.mnuRemoveLayer, "mnuRemoveLayer");
            this.mnuRemoveLayer.Name = "mnuRemoveLayer";
            // 
            // toolAddTms
            // 
            resources.ApplyResources(this.toolAddTms, "toolAddTms");
            this.toolAddTms.Name = "toolAddTms";
            // 
            // toolRemoveTms
            // 
            resources.ApplyResources(this.toolRemoveTms, "toolRemoveTms");
            this.toolRemoveTms.Name = "toolRemoveTms";
            // 
            // toolProperties
            // 
            resources.ApplyResources(this.toolProperties, "toolProperties");
            this.toolProperties.Name = "toolProperties";
            // 
            // toolImportTms
            // 
            resources.ApplyResources(this.toolImportTms, "toolImportTms");
            this.toolImportTms.Name = "toolImportTms";
            // 
            // toolClearTms
            // 
            resources.ApplyResources(this.toolClearTms, "toolClearTms");
            this.toolClearTms.Name = "toolClearTms";
            // 
            // toolHelp
            // 
            resources.ApplyResources(this.toolHelp, "toolHelp");
            this.toolHelp.Name = "toolHelp";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Name = "richTextBox1";
            // 
            // toolStripEx1
            // 
            resources.ApplyResources(this.toolStripEx1, "toolStripEx1");
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddFolder,
            this.toolRemoveFolder});
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ShowItemToolTips = true;
            // 
            // toolAddFolder
            // 
            resources.ApplyResources(this.toolAddFolder, "toolAddFolder");
            this.toolAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddFolder.Image = global::MW5.Plugins.Repository.Properties.Resources.img_folder_add;
            this.toolAddFolder.Name = "toolAddFolder";
            this.toolAddFolder.Padding = new System.Windows.Forms.Padding(3);
            // 
            // toolRemoveFolder
            // 
            resources.ApplyResources(this.toolRemoveFolder, "toolRemoveFolder");
            this.toolRemoveFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemoveFolder.Image = global::MW5.Plugins.Repository.Properties.Resources.img_folder_delete;
            this.toolRemoveFolder.Name = "toolRemoveFolder";
            this.toolRemoveFolder.Padding = new System.Windows.Forms.Padding(3);
            // 
            // RepositoryDockPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.toolStripEx1);
            this.Name = "RepositoryDockPanel";
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.contextMenuStripEx1.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepositoryTreeView treeViewAdv1;
        private ToolStripEx toolStripEx1;
        private ToolStripButton toolAddFolder;
        private ToolStripButton toolRemoveFolder;
        private ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem mnuAddFolder;
        private ToolStripMenuItem mnuRemoveFolder;
        private ToolStripMenuItem mnuAddFolderToMap;
        private ToolStripMenuItem mnuRefresh;
        private ToolStripMenuItem mnuAddToMap;
        private ToolStripMenuItem mnuRemoveFile;
        private ToolStripMenuItem mnuGdalInfo;
        private ToolStripMenuItem mnuOpenLocation;
        private ToolStripMenuItem mnuAddConnection;
        private ToolStripMenuItem mnuRemoveConnection;
        private ToolStripMenuItem mnuRemoveLayer;
        private SplitContainerAdv splitContainerAdv1;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem toolAddTms;
        private ToolStripMenuItem toolRemoveTms;
        private ToolStripMenuItem toolProperties;
        private ToolStripMenuItem toolImportTms;
        private ToolStripMenuItem toolClearTms;
        private ToolStripMenuItem toolHelp;
    }
}
