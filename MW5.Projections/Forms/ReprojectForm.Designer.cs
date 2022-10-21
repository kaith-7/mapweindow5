using MW5.Projections.Controls;
using MW5.UI.Legacy;

namespace MW5.Projections.Forms
{
    partial class ReprojectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReprojectForm));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProjectionTreeView1 = new MW5.Projections.Controls.ProjectionTreeView();
            this.LayersControl1 = new MW5.UI.Legacy.LayersControl();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProjection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectionTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            resources.ApplyResources(this.SplitContainer1, "SplitContainer1");
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            resources.ApplyResources(this.SplitContainer1.Panel1, "SplitContainer1.Panel1");
            this.SplitContainer1.Panel1.Controls.Add(this.ProjectionTreeView1);
            // 
            // SplitContainer1.Panel2
            // 
            resources.ApplyResources(this.SplitContainer1.Panel2, "SplitContainer1.Panel2");
            this.SplitContainer1.Panel2.Controls.Add(this.LayersControl1);
            // 
            // ProjectionTreeView1
            // 
            resources.ApplyResources(this.ProjectionTreeView1, "ProjectionTreeView1");
            this.ProjectionTreeView1.ApplyStyle = true;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ProjectionTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.ProjectionTreeView1.BeforeTouchSize = new System.Drawing.Size(302, 327);
            this.ProjectionTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectionTreeView1.FullRowSelect = true;
            // 
            // 
            // 
            this.ProjectionTreeView1.HelpTextControl.AccessibleDescription = resources.GetString("ProjectionTreeView1.HelpTextControl.AccessibleDescription");
            this.ProjectionTreeView1.HelpTextControl.AccessibleName = resources.GetString("ProjectionTreeView1.HelpTextControl.AccessibleName");
            this.ProjectionTreeView1.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ProjectionTreeView1.HelpTextControl.Anchor")));
            this.ProjectionTreeView1.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("ProjectionTreeView1.HelpTextControl.AutoScroll")));
            this.ProjectionTreeView1.HelpTextControl.AutoSize = ((bool)(resources.GetObject("ProjectionTreeView1.HelpTextControl.AutoSize")));
            this.ProjectionTreeView1.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("ProjectionTreeView1.HelpTextControl.AutoSizeMode")));
            this.ProjectionTreeView1.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProjectionTreeView1.HelpTextControl.BackgroundImage")));
            this.ProjectionTreeView1.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("ProjectionTreeView1.HelpTextControl.BackgroundImageLayout")));
            this.ProjectionTreeView1.HelpTextControl.BaseThemeName = null;
            this.ProjectionTreeView1.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ProjectionTreeView1.HelpTextControl.Dock")));
            this.ProjectionTreeView1.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("ProjectionTreeView1.HelpTextControl.Font")));
            this.ProjectionTreeView1.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ProjectionTreeView1.HelpTextControl.ImeMode")));
            this.ProjectionTreeView1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("ProjectionTreeView1.HelpTextControl.Location")));
            this.ProjectionTreeView1.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("ProjectionTreeView1.HelpTextControl.MaximumSize")));
            this.ProjectionTreeView1.HelpTextControl.Name = "helpText";
            this.ProjectionTreeView1.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ProjectionTreeView1.HelpTextControl.RightToLeft")));
            this.ProjectionTreeView1.HelpTextControl.TabIndex = ((int)(resources.GetObject("ProjectionTreeView1.HelpTextControl.TabIndex")));
            this.ProjectionTreeView1.HelpTextControl.Visible = ((bool)(resources.GetObject("ProjectionTreeView1.HelpTextControl.Visible")));
            this.ProjectionTreeView1.HideSelection = false;
            this.ProjectionTreeView1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.ProjectionTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ProjectionTreeView1.Name = "ProjectionTreeView1";
            this.ProjectionTreeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProjectionTreeView1.ShowSuperTooltip = true;
            this.ProjectionTreeView1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.ProjectionTreeView1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.ProjectionTreeView1.ToolTipControl.AccessibleDescription = resources.GetString("ProjectionTreeView1.ToolTipControl.AccessibleDescription");
            this.ProjectionTreeView1.ToolTipControl.AccessibleName = resources.GetString("ProjectionTreeView1.ToolTipControl.AccessibleName");
            this.ProjectionTreeView1.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ProjectionTreeView1.ToolTipControl.Anchor")));
            this.ProjectionTreeView1.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("ProjectionTreeView1.ToolTipControl.AutoScroll")));
            this.ProjectionTreeView1.ToolTipControl.AutoSize = ((bool)(resources.GetObject("ProjectionTreeView1.ToolTipControl.AutoSize")));
            this.ProjectionTreeView1.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("ProjectionTreeView1.ToolTipControl.AutoSizeMode")));
            this.ProjectionTreeView1.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProjectionTreeView1.ToolTipControl.BackgroundImage")));
            this.ProjectionTreeView1.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("ProjectionTreeView1.ToolTipControl.BackgroundImageLayout")));
            this.ProjectionTreeView1.ToolTipControl.BaseThemeName = null;
            this.ProjectionTreeView1.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ProjectionTreeView1.ToolTipControl.Dock")));
            this.ProjectionTreeView1.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("ProjectionTreeView1.ToolTipControl.Font")));
            this.ProjectionTreeView1.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ProjectionTreeView1.ToolTipControl.ImeMode")));
            this.ProjectionTreeView1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("ProjectionTreeView1.ToolTipControl.Location")));
            this.ProjectionTreeView1.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("ProjectionTreeView1.ToolTipControl.MaximumSize")));
            this.ProjectionTreeView1.ToolTipControl.Name = "toolTip";
            this.ProjectionTreeView1.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ProjectionTreeView1.ToolTipControl.RightToLeft")));
            this.ProjectionTreeView1.ToolTipControl.TabIndex = ((int)(resources.GetObject("ProjectionTreeView1.ToolTipControl.TabIndex")));
            this.ProjectionTreeView1.ToolTipControl.Visible = ((bool)(resources.GetObject("ProjectionTreeView1.ToolTipControl.Visible")));
            this.ProjectionTreeView1.ToolTipDuration = 0;
            // 
            // LayersControl1
            // 
            resources.ApplyResources(this.LayersControl1, "LayersControl1");
            this.LayersControl1.ControlType = MW5.UI.Legacy.LayersControl.CustomType.Default;
            this.LayersControl1.Multiselect = false;
            this.LayersControl1.Name = "LayersControl1";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblProjection
            // 
            resources.ApplyResources(this.lblProjection, "lblProjection");
            this.lblProjection.Name = "lblProjection";
            // 
            // ReprojectForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.lblProjection);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.SplitContainer1);
            this.MinimizeBox = false;
            this.Name = "ReprojectForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ReprojectForm_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectionTreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal ProjectionTreeView ProjectionTreeView1;
        internal LayersControl LayersControl1;
        private System.Windows.Forms.Label lblProjection;
    }
}