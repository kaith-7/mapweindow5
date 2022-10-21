using System.Windows.Forms;

namespace MW5.Configuration
{
    partial class WidgetsConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidgetsConfigPage));
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.cboScalebarUnits = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.chkShowScalebar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboZoombarVerbosity = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkShowZoombar = new System.Windows.Forms.CheckBox();
            this.chkShowRedrawTime = new System.Windows.Forms.CheckBox();
            this.udCoordinatePrecision = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cboAngleFormat = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCoordinateDisplay = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.chkShowCoordinates = new System.Windows.Forms.CheckBox();
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboScalebarUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboZoombarVerbosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordinatePrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAngleFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCoordinateDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // configPanelControl1
            // 
            resources.ApplyResources(this.configPanelControl1, "configPanelControl1");
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.cboScalebarUnits);
            this.configPanelControl1.Controls.Add(this.label4);
            this.configPanelControl1.Controls.Add(this.chkShowScalebar);
            this.configPanelControl1.Controls.Add(this.label2);
            this.configPanelControl1.Controls.Add(this.cboZoombarVerbosity);
            this.configPanelControl1.Controls.Add(this.chkShowZoombar);
            this.configPanelControl1.HeaderText = "地图部件";
            this.configPanelControl1.Name = "configPanelControl1";
            // 
            // cboScalebarUnits
            // 
            resources.ApplyResources(this.cboScalebarUnits, "cboScalebarUnits");
            this.cboScalebarUnits.BeforeTouchSize = new System.Drawing.Size(173, 21);
            this.cboScalebarUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScalebarUnits.Name = "cboScalebarUnits";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkShowScalebar
            // 
            resources.ApplyResources(this.chkShowScalebar, "chkShowScalebar");
            this.chkShowScalebar.Name = "chkShowScalebar";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboZoombarVerbosity
            // 
            resources.ApplyResources(this.cboZoombarVerbosity, "cboZoombarVerbosity");
            this.cboZoombarVerbosity.BeforeTouchSize = new System.Drawing.Size(173, 21);
            this.cboZoombarVerbosity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZoombarVerbosity.Name = "cboZoombarVerbosity";
            // 
            // chkShowZoombar
            // 
            resources.ApplyResources(this.chkShowZoombar, "chkShowZoombar");
            this.chkShowZoombar.Name = "chkShowZoombar";
            // 
            // chkShowRedrawTime
            // 
            resources.ApplyResources(this.chkShowRedrawTime, "chkShowRedrawTime");
            this.chkShowRedrawTime.Name = "chkShowRedrawTime";
            // 
            // udCoordinatePrecision
            // 
            resources.ApplyResources(this.udCoordinatePrecision, "udCoordinatePrecision");
            this.udCoordinatePrecision.Name = "udCoordinatePrecision";
            this.udCoordinatePrecision.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cboAngleFormat
            // 
            resources.ApplyResources(this.cboAngleFormat, "cboAngleFormat");
            this.cboAngleFormat.BeforeTouchSize = new System.Drawing.Size(173, 21);
            this.cboAngleFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAngleFormat.Name = "cboAngleFormat";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // cboCoordinateDisplay
            // 
            resources.ApplyResources(this.cboCoordinateDisplay, "cboCoordinateDisplay");
            this.cboCoordinateDisplay.BeforeTouchSize = new System.Drawing.Size(173, 21);
            this.cboCoordinateDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCoordinateDisplay.Name = "cboCoordinateDisplay";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // chkShowCoordinates
            // 
            resources.ApplyResources(this.chkShowCoordinates, "chkShowCoordinates");
            this.chkShowCoordinates.Name = "chkShowCoordinates";
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.chkShowRedrawTime);
            this.configPanelControl2.Controls.Add(this.label10);
            this.configPanelControl2.Controls.Add(this.udCoordinatePrecision);
            this.configPanelControl2.Controls.Add(this.chkShowCoordinates);
            this.configPanelControl2.Controls.Add(this.label12);
            this.configPanelControl2.Controls.Add(this.cboCoordinateDisplay);
            this.configPanelControl2.Controls.Add(this.cboAngleFormat);
            this.configPanelControl2.Controls.Add(this.label11);
            this.configPanelControl2.HeaderText = "信息";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // WidgetsConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.configPanelControl2);
            this.Controls.Add(this.configPanelControl1);
            this.Name = "WidgetsConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            this.configPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboScalebarUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboZoombarVerbosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordinatePrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAngleFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCoordinateDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            this.configPanelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ConfigPanelControl configPanelControl1;
        private CheckBox chkShowRedrawTime;
        private System.Windows.Forms.NumericUpDown udCoordinatePrecision;
        private System.Windows.Forms.Label label12;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboAngleFormat;
        private System.Windows.Forms.Label label11;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboCoordinateDisplay;
        private System.Windows.Forms.Label label10;
        private CheckBox chkShowCoordinates;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboScalebarUnits;
        private System.Windows.Forms.Label label4;
        private CheckBox chkShowScalebar;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboZoombarVerbosity;
        private CheckBox chkShowZoombar;
        private UI.Controls.ConfigPanelControl configPanelControl2;
    }
}
