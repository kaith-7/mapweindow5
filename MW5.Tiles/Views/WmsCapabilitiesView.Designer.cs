using MW5.UI.Controls;

namespace MW5.Tiles.Views
{
    partial class WmsCapabilitiesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WmsCapabilitiesView));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAdd = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboServers = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnConnect = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCreate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnEdit = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDelete = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.wmsTreeView1 = new MW5.Tiles.Controls.WmsTreeView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cboServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmsTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnAdd.Name = "btnAdd";
            // 
            // cboServers
            // 
            resources.ApplyResources(this.cboServers, "cboServers");
            this.cboServers.BeforeTouchSize = new System.Drawing.Size(370, 21);
            this.cboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServers.Name = "cboServers";
            this.cboServers.ShowImageInTextBox = true;
            this.cboServers.ShowImagesInComboListBox = true;
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnConnect.Name = "btnConnect";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnCreate.Name = "btnCreate";
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnDelete.Name = "btnDelete";
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(479, 363);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Name = "tabControlAdv1";
            // 
            // tabPageAdv1
            // 
            resources.ApplyResources(this.tabPageAdv1, "tabPageAdv1");
            this.tabPageAdv1.Controls.Add(this.wmsTreeView1);
            this.tabPageAdv1.Controls.Add(this.label1);
            this.tabPageAdv1.Controls.Add(this.btnDelete);
            this.tabPageAdv1.Controls.Add(this.btnEdit);
            this.tabPageAdv1.Controls.Add(this.cboServers);
            this.tabPageAdv1.Controls.Add(this.btnConnect);
            this.tabPageAdv1.Controls.Add(this.btnCreate);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // wmsTreeView1
            // 
            resources.ApplyResources(this.wmsTreeView1, "wmsTreeView1");
            this.wmsTreeView1.ApplyStyle = true;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.wmsTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.wmsTreeView1.BeforeTouchSize = new System.Drawing.Size(451, 248);
            this.wmsTreeView1.BorderColor = System.Drawing.Color.DarkGray;
            this.wmsTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.wmsTreeView1.HelpTextControl.AccessibleDescription = resources.GetString("wmsTreeView1.HelpTextControl.AccessibleDescription");
            this.wmsTreeView1.HelpTextControl.AccessibleName = resources.GetString("wmsTreeView1.HelpTextControl.AccessibleName");
            this.wmsTreeView1.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wmsTreeView1.HelpTextControl.Anchor")));
            this.wmsTreeView1.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("wmsTreeView1.HelpTextControl.AutoScroll")));
            this.wmsTreeView1.HelpTextControl.AutoSize = ((bool)(resources.GetObject("wmsTreeView1.HelpTextControl.AutoSize")));
            this.wmsTreeView1.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("wmsTreeView1.HelpTextControl.AutoSizeMode")));
            this.wmsTreeView1.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wmsTreeView1.HelpTextControl.BackgroundImage")));
            this.wmsTreeView1.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("wmsTreeView1.HelpTextControl.BackgroundImageLayout")));
            this.wmsTreeView1.HelpTextControl.BaseThemeName = null;
            this.wmsTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wmsTreeView1.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wmsTreeView1.HelpTextControl.Dock")));
            this.wmsTreeView1.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("wmsTreeView1.HelpTextControl.Font")));
            this.wmsTreeView1.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wmsTreeView1.HelpTextControl.ImeMode")));
            this.wmsTreeView1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("wmsTreeView1.HelpTextControl.Location")));
            this.wmsTreeView1.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("wmsTreeView1.HelpTextControl.MaximumSize")));
            this.wmsTreeView1.HelpTextControl.Name = "helpText";
            this.wmsTreeView1.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wmsTreeView1.HelpTextControl.RightToLeft")));
            this.wmsTreeView1.HelpTextControl.Size = ((System.Drawing.Size)(resources.GetObject("wmsTreeView1.HelpTextControl.Size")));
            this.wmsTreeView1.HelpTextControl.TabIndex = ((int)(resources.GetObject("wmsTreeView1.HelpTextControl.TabIndex")));
            this.wmsTreeView1.HelpTextControl.Text = resources.GetString("wmsTreeView1.HelpTextControl.Text");
            this.wmsTreeView1.HelpTextControl.Visible = ((bool)(resources.GetObject("wmsTreeView1.HelpTextControl.Visible")));
            this.wmsTreeView1.HideSelection = false;
            this.wmsTreeView1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.wmsTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.wmsTreeView1.Name = "wmsTreeView1";
            this.wmsTreeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.wmsTreeView1.ShowSuperTooltip = true;
            this.wmsTreeView1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.wmsTreeView1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.wmsTreeView1.ToolTipControl.AccessibleDescription = resources.GetString("wmsTreeView1.ToolTipControl.AccessibleDescription");
            this.wmsTreeView1.ToolTipControl.AccessibleName = resources.GetString("wmsTreeView1.ToolTipControl.AccessibleName");
            this.wmsTreeView1.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wmsTreeView1.ToolTipControl.Anchor")));
            this.wmsTreeView1.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("wmsTreeView1.ToolTipControl.AutoScroll")));
            this.wmsTreeView1.ToolTipControl.AutoSize = ((bool)(resources.GetObject("wmsTreeView1.ToolTipControl.AutoSize")));
            this.wmsTreeView1.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("wmsTreeView1.ToolTipControl.AutoSizeMode")));
            this.wmsTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.wmsTreeView1.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wmsTreeView1.ToolTipControl.BackgroundImage")));
            this.wmsTreeView1.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("wmsTreeView1.ToolTipControl.BackgroundImageLayout")));
            this.wmsTreeView1.ToolTipControl.BaseThemeName = null;
            this.wmsTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wmsTreeView1.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wmsTreeView1.ToolTipControl.Dock")));
            this.wmsTreeView1.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("wmsTreeView1.ToolTipControl.Font")));
            this.wmsTreeView1.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wmsTreeView1.ToolTipControl.ImeMode")));
            this.wmsTreeView1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("wmsTreeView1.ToolTipControl.Location")));
            this.wmsTreeView1.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("wmsTreeView1.ToolTipControl.MaximumSize")));
            this.wmsTreeView1.ToolTipControl.Name = "toolTip";
            this.wmsTreeView1.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wmsTreeView1.ToolTipControl.RightToLeft")));
            this.wmsTreeView1.ToolTipControl.Size = ((System.Drawing.Size)(resources.GetObject("wmsTreeView1.ToolTipControl.Size")));
            this.wmsTreeView1.ToolTipControl.TabIndex = ((int)(resources.GetObject("wmsTreeView1.ToolTipControl.TabIndex")));
            this.wmsTreeView1.ToolTipControl.Text = resources.GetString("wmsTreeView1.ToolTipControl.Text");
            this.wmsTreeView1.ToolTipControl.Visible = ((bool)(resources.GetObject("wmsTreeView1.ToolTipControl.Visible")));
            this.wmsTreeView1.ToolTipDuration = 5000;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // WmsCapabilitiesView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Name = "WmsCapabilitiesView";
            ((System.ComponentModel.ISupportInitialize)(this.cboServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmsTreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.ButtonAdv btnAdd;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboServers;
        private Syncfusion.Windows.Forms.ButtonAdv btnConnect;
        private Syncfusion.Windows.Forms.ButtonAdv btnCreate;
        private Syncfusion.Windows.Forms.ButtonAdv btnEdit;
        private Syncfusion.Windows.Forms.ButtonAdv btnDelete;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private System.Windows.Forms.Label label1;
        private Controls.WmsTreeView wmsTreeView1;
    }
}