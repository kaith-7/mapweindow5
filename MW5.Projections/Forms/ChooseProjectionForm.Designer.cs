using MW5.Projections.Controls;
using MW5.UI.Controls;

namespace MW5.Projections.Forms
{
    partial class ChooseProjectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseProjectionForm));
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this._projectionTreeView1 = new MW5.Projections.Controls.ProjectionTreeView();
            this.chkUpdate = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtSearch = new MW5.UI.Controls.WatermarkTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._projectionTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
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
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Body.Text = resources.GetString("resource.Text");
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Footer.Text = resources.GetString("resource.Text1");
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = resources.GetString("resource.Text2");
            this.superToolTip1.SetToolTip(this.btnOk, toolTipInfo1);
            this.btnOk.UseVisualStyle = false;
            // 
            // superToolTip1
            // 
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // comboBoxAdv1
            // 
            resources.ApplyResources(this.comboBoxAdv1, "comboBoxAdv1");
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(154, 19);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            resources.GetString("comboBoxAdv1.Items")});
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.ThemeName = "Metro";
            // 
            // _projectionTreeView1
            // 
            resources.ApplyResources(this._projectionTreeView1, "_projectionTreeView1");
            this._projectionTreeView1.ApplyStyle = true;
            this._projectionTreeView1.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this._projectionTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this._projectionTreeView1.BeforeTouchSize = new System.Drawing.Size(450, 409);
            this._projectionTreeView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this._projectionTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._projectionTreeView1.DelayToolTip = true;
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
            this._projectionTreeView1.RecalculateExpansion = false;
            this._projectionTreeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this._projectionTreeView1.ShowSuperTooltip = true;
            this._projectionTreeView1.SuspendExpandRecalculate = true;
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
            // chkUpdate
            // 
            resources.ApplyResources(this.chkUpdate, "chkUpdate");
            this.chkUpdate.BeforeTouchSize = new System.Drawing.Size(150, 19);
            this.chkUpdate.Checked = true;
            this.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdate.Name = "chkUpdate";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(290, 21);
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearch.FarImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.FarImage")));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSearch.ThemeName = "Metro";
            this.txtSearch.ThemesEnabled = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // ChooseProjectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.chkUpdate);
            this.Controls.Add(this._projectionTreeView1);
            this.Controls.Add(this.comboBoxAdv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MinimizeBox = false;
            this.Name = "ChooseProjectionForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ChooseProjectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._projectionTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectionTreeView _projectionTreeView1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private WatermarkTextbox txtSearch;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkUpdate;
    }
}