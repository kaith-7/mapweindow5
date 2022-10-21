using MW5.Tools.Controls.Parameters;
using MW5.Tools.Properties;

namespace MW5.Tools.Views
{
    partial class ToolView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolView));
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabRequired = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panelRequired = new System.Windows.Forms.Panel();
            this.tabOptional = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panelOptional = new System.Windows.Forms.Panel();
            this.tabHelp = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.chkBackground = new System.Windows.Forms.CheckBox();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRun = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabRequired.SuspendLayout();
            this.tabOptional.SuspendLayout();
            this.tabHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.tabControlAdv1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.chkBackground);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.btnRun);
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.AllowDrop = true;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(806, 460);
            this.tabControlAdv1.Controls.Add(this.tabRequired);
            this.tabControlAdv1.Controls.Add(this.tabOptional);
            this.tabControlAdv1.Controls.Add(this.tabHelp);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // tabRequired
            // 
            resources.ApplyResources(this.tabRequired, "tabRequired");
            this.tabRequired.Controls.Add(this.panelRequired);
            this.tabRequired.Image = global::MW5.Tools.Properties.Resources.img_tools24;
            this.tabRequired.ImageSize = new System.Drawing.Size(24, 24);
            this.tabRequired.Name = "tabRequired";
            this.tabRequired.ShowCloseButton = true;
            this.tabRequired.ThemesEnabled = false;
            // 
            // panelRequired
            // 
            resources.ApplyResources(this.panelRequired, "panelRequired");
            this.panelRequired.Name = "panelRequired";
            // 
            // tabOptional
            // 
            resources.ApplyResources(this.tabOptional, "tabOptional");
            this.tabOptional.Controls.Add(this.panelOptional);
            this.tabOptional.Image = global::MW5.Tools.Properties.Resources.img_options24;
            this.tabOptional.ImageSize = new System.Drawing.Size(24, 24);
            this.tabOptional.Name = "tabOptional";
            this.tabOptional.ShowCloseButton = true;
            this.tabOptional.ThemesEnabled = false;
            // 
            // panelOptional
            // 
            resources.ApplyResources(this.panelOptional, "panelOptional");
            this.panelOptional.Name = "panelOptional";
            // 
            // tabHelp
            // 
            resources.ApplyResources(this.tabHelp, "tabHelp");
            this.tabHelp.Controls.Add(this.webBrowser1);
            this.tabHelp.Image = global::MW5.Tools.Properties.Resources.img_help24;
            this.tabHelp.ImageSize = new System.Drawing.Size(24, 24);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.ShowCloseButton = true;
            this.tabHelp.ThemesEnabled = false;
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            // 
            // chkBackground
            // 
            resources.ApplyResources(this.chkBackground, "chkBackground");
            this.chkBackground.Name = "chkBackground";
            this.chkBackground.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.ThemeName = "Metro";
            this.btnClose.Click += new System.EventHandler(this.OnCloseClick);
            // 
            // btnRun
            // 
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnRun.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Name = "btnRun";
            this.btnRun.ThemeName = "Metro";
            toolTipInfo1.BackColor = System.Drawing.Color.White;
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Body.Text = resources.GetString("resource.Text");
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Footer.Text = resources.GetString("resource.Text1");
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = resources.GetString("resource.Text2");
            this.superToolTip1.SetToolTip(this.btnRun, toolTipInfo1);
            // 
            // comboBoxAdv2
            // 
            resources.ApplyResources(this.comboBoxAdv2, "comboBoxAdv2");
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(282, 25);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            // 
            // superToolTip1
            // 
            this.superToolTip1.MaxWidth = 400;
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.superToolTip1.Style = Syncfusion.Windows.Forms.Tools.SuperToolTip.SuperToolTipStyle.Office2013Style;
            this.superToolTip1.ToolTipDuration = 5;
            this.superToolTip1.UseFading = Syncfusion.Windows.Forms.Tools.SuperToolTip.FadingType.System;
            // 
            // ToolView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.splitContainer1);
            this.Name = "ToolView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabRequired.ResumeLayout(false);
            this.tabOptional.ResumeLayout(false);
            this.tabHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.ButtonAdv btnRun;
        protected Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabRequired;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabOptional;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabHelp;
        private System.Windows.Forms.Panel panelRequired;
        private System.Windows.Forms.Panel panelOptional;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckBox chkBackground;
        protected Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}