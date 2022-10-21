namespace MW5.Forms
{
    partial class ErrorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorView));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnContinue = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnReport = new Syncfusion.Windows.Forms.ButtonAdv();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.btnCopy = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxExt1
            // 
            resources.ApplyResources(this.textBoxExt1, "textBoxExt1");
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(484, 100);
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.ReadOnly = true;
            this.textBoxExt1.ThemeName = "Default";
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::MW5.Properties.Resources.img_warning64;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnQuit
            // 
            resources.ApplyResources(this.btnQuit, "btnQuit");
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnQuit.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.UseVisualStyle = false;
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            resources.ApplyResources(this.btnContinue, "btnContinue");
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnContinue.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.UseVisualStyle = false;
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.BeforeTouchSize = new System.Drawing.Size(77, 24);
            this.btnReport.Name = "btnReport";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // treeViewAdv1
            // 
            resources.ApplyResources(this.treeViewAdv1, "treeViewAdv1");
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(411, 67);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.ShowFocusRect = false;
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
            this.treeViewAdv1.AfterSelect += new System.EventHandler(this.OntreeViewAdvAfterSelect);
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.BeforeTouchSize = new System.Drawing.Size(77, 24);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // ErrorView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnContinue;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.textBoxExt1);
            this.Name = "ErrorView";
            this.Load += new System.EventHandler(this.ErrorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.ButtonAdv btnQuit;
        private Syncfusion.Windows.Forms.ButtonAdv btnContinue;
        private Syncfusion.Windows.Forms.ButtonAdv btnReport;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCopy;
    }
}