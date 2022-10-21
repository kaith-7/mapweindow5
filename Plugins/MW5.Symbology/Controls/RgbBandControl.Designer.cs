namespace MW5.Plugins.Symbology.Controls
{
    partial class RgbBandControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RgbBandControl));
            this.chkCustomMinMax = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDefaultMapping = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboAlpha = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBlue = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGreen = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRed = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMinRed = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtMaxRed = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.btnAllCustom = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtMinGreen = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.btnAllDefault = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtMaxGreen = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtMinBlue = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtMaxBlue = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.btnBlueCustom = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnBlueDefault = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGreenCustom = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRedDefault = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGreenDefault = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRedCustom = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRed)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCustomMinMax
            // 
            resources.ApplyResources(this.chkCustomMinMax, "chkCustomMinMax");
            this.chkCustomMinMax.Name = "chkCustomMinMax";
            this.chkCustomMinMax.UseVisualStyleBackColor = true;
            this.chkCustomMinMax.CheckedChanged += new System.EventHandler(this.chkCustomMinMax_CheckedChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.chkCustomMinMax);
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnDefaultMapping);
            this.panel4.Controls.Add(this.cboAlpha);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cboBlue);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cboGreen);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cboRed);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Name = "panel4";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BeforeTouchSize = new System.Drawing.Size(87, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.ClearMappingClick);
            // 
            // btnDefaultMapping
            // 
            resources.ApplyResources(this.btnDefaultMapping, "btnDefaultMapping");
            this.btnDefaultMapping.BeforeTouchSize = new System.Drawing.Size(117, 31);
            this.btnDefaultMapping.Name = "btnDefaultMapping";
            this.btnDefaultMapping.Click += new System.EventHandler(this.SetDefaultMappingClick);
            // 
            // cboAlpha
            // 
            resources.ApplyResources(this.cboAlpha, "cboAlpha");
            this.cboAlpha.BeforeTouchSize = new System.Drawing.Size(215, 25);
            this.cboAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlpha.Name = "cboAlpha";
            this.cboAlpha.SelectedIndexChanged += new System.EventHandler(this.SelectedBandChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cboBlue
            // 
            resources.ApplyResources(this.cboBlue, "cboBlue");
            this.cboBlue.BeforeTouchSize = new System.Drawing.Size(215, 25);
            this.cboBlue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBlue.Name = "cboBlue";
            this.cboBlue.SelectedIndexChanged += new System.EventHandler(this.SelectedBandChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cboGreen
            // 
            resources.ApplyResources(this.cboGreen, "cboGreen");
            this.cboGreen.BeforeTouchSize = new System.Drawing.Size(215, 25);
            this.cboGreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGreen.Name = "cboGreen";
            this.cboGreen.SelectedIndexChanged += new System.EventHandler(this.SelectedBandChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboRed
            // 
            resources.ApplyResources(this.cboRed, "cboRed");
            this.cboRed.BeforeTouchSize = new System.Drawing.Size(215, 25);
            this.cboRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRed.Name = "cboRed";
            this.cboRed.SelectedIndexChanged += new System.EventHandler(this.SelectedBandChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.txtMinRed);
            this.panel1.Controls.Add(this.txtMaxRed);
            this.panel1.Controls.Add(this.btnAllCustom);
            this.panel1.Controls.Add(this.txtMinGreen);
            this.panel1.Controls.Add(this.btnAllDefault);
            this.panel1.Controls.Add(this.txtMaxGreen);
            this.panel1.Controls.Add(this.txtMinBlue);
            this.panel1.Controls.Add(this.txtMaxBlue);
            this.panel1.Controls.Add(this.btnBlueCustom);
            this.panel1.Controls.Add(this.btnBlueDefault);
            this.panel1.Controls.Add(this.btnGreenCustom);
            this.panel1.Controls.Add(this.btnRedDefault);
            this.panel1.Controls.Add(this.btnGreenDefault);
            this.panel1.Controls.Add(this.btnRedCustom);
            this.panel1.Name = "panel1";
            // 
            // txtMinRed
            // 
            resources.ApplyResources(this.txtMinRed, "txtMinRed");
            this.txtMinRed.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMinRed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinRed.DoubleValue = 1D;
            this.txtMinRed.Name = "txtMinRed";
            this.txtMinRed.NegativeColor = System.Drawing.Color.Black;
            this.txtMinRed.ThemeName = "Default";
            // 
            // txtMaxRed
            // 
            resources.ApplyResources(this.txtMaxRed, "txtMaxRed");
            this.txtMaxRed.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMaxRed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxRed.DoubleValue = 1D;
            this.txtMaxRed.Name = "txtMaxRed";
            this.txtMaxRed.NegativeColor = System.Drawing.Color.Black;
            this.txtMaxRed.ThemeName = "Default";
            // 
            // btnAllCustom
            // 
            resources.ApplyResources(this.btnAllCustom, "btnAllCustom");
            this.btnAllCustom.BeforeTouchSize = new System.Drawing.Size(103, 28);
            this.btnAllCustom.Name = "btnAllCustom";
            this.btnAllCustom.Click += new System.EventHandler(this.SetAllCustomClick);
            // 
            // txtMinGreen
            // 
            resources.ApplyResources(this.txtMinGreen, "txtMinGreen");
            this.txtMinGreen.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMinGreen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinGreen.DoubleValue = 1D;
            this.txtMinGreen.Name = "txtMinGreen";
            this.txtMinGreen.NegativeColor = System.Drawing.Color.Black;
            this.txtMinGreen.ThemeName = "Default";
            // 
            // btnAllDefault
            // 
            resources.ApplyResources(this.btnAllDefault, "btnAllDefault");
            this.btnAllDefault.BeforeTouchSize = new System.Drawing.Size(103, 28);
            this.btnAllDefault.Name = "btnAllDefault";
            this.btnAllDefault.Click += new System.EventHandler(this.SetAllDefaultClick);
            // 
            // txtMaxGreen
            // 
            resources.ApplyResources(this.txtMaxGreen, "txtMaxGreen");
            this.txtMaxGreen.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMaxGreen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxGreen.DoubleValue = 1D;
            this.txtMaxGreen.Name = "txtMaxGreen";
            this.txtMaxGreen.NegativeColor = System.Drawing.Color.Black;
            this.txtMaxGreen.ThemeName = "Default";
            // 
            // txtMinBlue
            // 
            resources.ApplyResources(this.txtMinBlue, "txtMinBlue");
            this.txtMinBlue.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMinBlue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinBlue.DoubleValue = 1D;
            this.txtMinBlue.Name = "txtMinBlue";
            this.txtMinBlue.NegativeColor = System.Drawing.Color.Black;
            this.txtMinBlue.ThemeName = "Default";
            // 
            // txtMaxBlue
            // 
            resources.ApplyResources(this.txtMaxBlue, "txtMaxBlue");
            this.txtMaxBlue.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.txtMaxBlue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxBlue.DoubleValue = 1D;
            this.txtMaxBlue.Name = "txtMaxBlue";
            this.txtMaxBlue.NegativeColor = System.Drawing.Color.Black;
            this.txtMaxBlue.ThemeName = "Default";
            // 
            // btnBlueCustom
            // 
            resources.ApplyResources(this.btnBlueCustom, "btnBlueCustom");
            this.btnBlueCustom.BeforeTouchSize = new System.Drawing.Size(79, 28);
            this.btnBlueCustom.Name = "btnBlueCustom";
            this.btnBlueCustom.Click += new System.EventHandler(this.BandSetCustomClick);
            // 
            // btnBlueDefault
            // 
            resources.ApplyResources(this.btnBlueDefault, "btnBlueDefault");
            this.btnBlueDefault.BeforeTouchSize = new System.Drawing.Size(79, 28);
            this.btnBlueDefault.Name = "btnBlueDefault";
            this.btnBlueDefault.Click += new System.EventHandler(this.BandSetDefaultClick);
            // 
            // btnGreenCustom
            // 
            resources.ApplyResources(this.btnGreenCustom, "btnGreenCustom");
            this.btnGreenCustom.BeforeTouchSize = new System.Drawing.Size(79, 28);
            this.btnGreenCustom.Name = "btnGreenCustom";
            this.btnGreenCustom.Click += new System.EventHandler(this.BandSetCustomClick);
            // 
            // btnRedDefault
            // 
            resources.ApplyResources(this.btnRedDefault, "btnRedDefault");
            this.btnRedDefault.BeforeTouchSize = new System.Drawing.Size(79, 28);
            this.btnRedDefault.Name = "btnRedDefault";
            this.btnRedDefault.Click += new System.EventHandler(this.BandSetDefaultClick);
            // 
            // btnGreenDefault
            // 
            resources.ApplyResources(this.btnGreenDefault, "btnGreenDefault");
            this.btnGreenDefault.BeforeTouchSize = new System.Drawing.Size(79, 28);
            this.btnGreenDefault.Name = "btnGreenDefault";
            this.btnGreenDefault.Click += new System.EventHandler(this.BandSetDefaultClick);
            // 
            // btnRedCustom
            // 
            resources.ApplyResources(this.btnRedCustom, "btnRedCustom");
            this.btnRedCustom.BeforeTouchSize = new System.Drawing.Size(79, 28);
            this.btnRedCustom.Name = "btnRedCustom";
            this.btnRedCustom.Click += new System.EventHandler(this.BandSetCustomClick);
            // 
            // RgbBandControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "RgbBandControl";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkCustomMinMax;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.ButtonAdv btnClear;
        private Syncfusion.Windows.Forms.ButtonAdv btnDefaultMapping;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboAlpha;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboBlue;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboGreen;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMinRed;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMaxRed;
        private Syncfusion.Windows.Forms.ButtonAdv btnAllCustom;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMinGreen;
        private Syncfusion.Windows.Forms.ButtonAdv btnAllDefault;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMaxGreen;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMinBlue;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMaxBlue;
        private Syncfusion.Windows.Forms.ButtonAdv btnBlueCustom;
        private Syncfusion.Windows.Forms.ButtonAdv btnBlueDefault;
        private Syncfusion.Windows.Forms.ButtonAdv btnGreenCustom;
        private Syncfusion.Windows.Forms.ButtonAdv btnRedDefault;
        private Syncfusion.Windows.Forms.ButtonAdv btnGreenDefault;
        private Syncfusion.Windows.Forms.ButtonAdv btnRedCustom;
    }
}
