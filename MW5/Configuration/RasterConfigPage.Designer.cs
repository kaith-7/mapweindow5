using System.Windows.Forms;

namespace MW5.Configuration
{
    partial class RasterConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasterConfigPage));
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.chkUseHistogram = new System.Windows.Forms.CheckBox();
            this.chkCreateColorScheme = new System.Windows.Forms.CheckBox();
            this.chkRandomColorScheme = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDefaultColorScheme = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            this.label11 = new System.Windows.Forms.Label();
            this.cboUpsampling = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboDownsampling = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label12 = new System.Windows.Forms.Label();
            this.configPanelControl3 = new MW5.UI.Controls.ConfigPanelControl();
            this.cboPyramidsSampling = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPyramidCompression = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkCreatePyramids = new System.Windows.Forms.CheckBox();
            this.chkPyramidsDialog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDefaultColorScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUpsampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDownsampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).BeginInit();
            this.configPanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPyramidsSampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPyramidCompression)).BeginInit();
            this.SuspendLayout();
            // 
            // configPanelControl1
            // 
            resources.ApplyResources(this.configPanelControl1, "configPanelControl1");
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.chkUseHistogram);
            this.configPanelControl1.Controls.Add(this.chkCreateColorScheme);
            this.configPanelControl1.Controls.Add(this.chkRandomColorScheme);
            this.configPanelControl1.Controls.Add(this.label1);
            this.configPanelControl1.Controls.Add(this.cboDefaultColorScheme);
            this.configPanelControl1.HeaderText = "网格渲染";
            this.configPanelControl1.Name = "configPanelControl1";
            this.configPanelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.configPanelControl1_Paint);
            // 
            // chkUseHistogram
            // 
            resources.ApplyResources(this.chkUseHistogram, "chkUseHistogram");
            this.chkUseHistogram.Name = "chkUseHistogram";
            this.chkUseHistogram.UseVisualStyleBackColor = true;
            // 
            // chkCreateColorScheme
            // 
            resources.ApplyResources(this.chkCreateColorScheme, "chkCreateColorScheme");
            this.chkCreateColorScheme.Name = "chkCreateColorScheme";
            this.chkCreateColorScheme.UseVisualStyleBackColor = true;
            // 
            // chkRandomColorScheme
            // 
            resources.ApplyResources(this.chkRandomColorScheme, "chkRandomColorScheme");
            this.chkRandomColorScheme.Name = "chkRandomColorScheme";
            this.chkRandomColorScheme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboDefaultColorScheme
            // 
            resources.ApplyResources(this.cboDefaultColorScheme, "cboDefaultColorScheme");
            this.cboDefaultColorScheme.BeforeTouchSize = new System.Drawing.Size(212, 21);
            this.cboDefaultColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefaultColorScheme.Name = "cboDefaultColorScheme";
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.label11);
            this.configPanelControl2.Controls.Add(this.cboUpsampling);
            this.configPanelControl2.Controls.Add(this.cboDownsampling);
            this.configPanelControl2.Controls.Add(this.label12);
            this.configPanelControl2.HeaderText = "默认设置";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // cboUpsampling
            // 
            resources.ApplyResources(this.cboUpsampling, "cboUpsampling");
            this.cboUpsampling.BeforeTouchSize = new System.Drawing.Size(207, 21);
            this.cboUpsampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpsampling.Name = "cboUpsampling";
            // 
            // cboDownsampling
            // 
            resources.ApplyResources(this.cboDownsampling, "cboDownsampling");
            this.cboDownsampling.BeforeTouchSize = new System.Drawing.Size(207, 21);
            this.cboDownsampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDownsampling.Name = "cboDownsampling";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // configPanelControl3
            // 
            resources.ApplyResources(this.configPanelControl3, "configPanelControl3");
            this.configPanelControl3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl3.Controls.Add(this.cboPyramidsSampling);
            this.configPanelControl3.Controls.Add(this.label4);
            this.configPanelControl3.Controls.Add(this.label2);
            this.configPanelControl3.Controls.Add(this.cboPyramidCompression);
            this.configPanelControl3.Controls.Add(this.chkCreatePyramids);
            this.configPanelControl3.Controls.Add(this.chkPyramidsDialog);
            this.configPanelControl3.HeaderText = "栅格金字塔";
            this.configPanelControl3.Name = "configPanelControl3";
            // 
            // cboPyramidsSampling
            // 
            resources.ApplyResources(this.cboPyramidsSampling, "cboPyramidsSampling");
            this.cboPyramidsSampling.BeforeTouchSize = new System.Drawing.Size(166, 21);
            this.cboPyramidsSampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPyramidsSampling.Name = "cboPyramidsSampling";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboPyramidCompression
            // 
            resources.ApplyResources(this.cboPyramidCompression, "cboPyramidCompression");
            this.cboPyramidCompression.BeforeTouchSize = new System.Drawing.Size(166, 21);
            this.cboPyramidCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPyramidCompression.Name = "cboPyramidCompression";
            // 
            // chkCreatePyramids
            // 
            resources.ApplyResources(this.chkCreatePyramids, "chkCreatePyramids");
            this.chkCreatePyramids.Name = "chkCreatePyramids";
            // 
            // chkPyramidsDialog
            // 
            resources.ApplyResources(this.chkPyramidsDialog, "chkPyramidsDialog");
            this.chkPyramidsDialog.Name = "chkPyramidsDialog";
            // 
            // RasterConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.configPanelControl2);
            this.Controls.Add(this.configPanelControl1);
            this.Controls.Add(this.configPanelControl3);
            this.Name = "RasterConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            this.configPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDefaultColorScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            this.configPanelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUpsampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDownsampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).EndInit();
            this.configPanelControl3.ResumeLayout(false);
            this.configPanelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPyramidsSampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPyramidCompression)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ConfigPanelControl configPanelControl1;
        private UI.Controls.ConfigPanelControl configPanelControl2;
        private Label label11;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboUpsampling;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboDownsampling;
        private Label label12;
        private CheckBox chkRandomColorScheme;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboDefaultColorScheme;
        private CheckBox chkCreateColorScheme;
        private CheckBox chkUseHistogram;
        private UI.Controls.ConfigPanelControl configPanelControl3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboPyramidsSampling;
        private Label label4;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboPyramidCompression;
        private CheckBox chkCreatePyramids;
        private CheckBox chkPyramidsDialog;
    }
}
