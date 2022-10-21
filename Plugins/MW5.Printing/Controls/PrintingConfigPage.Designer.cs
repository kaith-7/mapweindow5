namespace MW5.Plugins.Printing.Controls
{
    partial class PrintingConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintingConfigPage));
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.cboOrientation = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUnits = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.txtFormat);
            this.configPanelControl2.Controls.Add(this.cboOrientation);
            this.configPanelControl2.Controls.Add(this.label3);
            this.configPanelControl2.Controls.Add(this.label2);
            this.configPanelControl2.Controls.Add(this.cboUnits);
            this.configPanelControl2.Controls.Add(this.label1);
            this.configPanelControl2.HeaderText = "布局选项";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // txtFormat
            // 
            resources.ApplyResources(this.txtFormat, "txtFormat");
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.ReadOnly = true;
            // 
            // cboOrientation
            // 
            resources.ApplyResources(this.cboOrientation, "cboOrientation");
            this.cboOrientation.BeforeTouchSize = new System.Drawing.Size(260, 21);
            this.cboOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrientation.Name = "cboOrientation";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboUnits
            // 
            resources.ApplyResources(this.cboUnits, "cboUnits");
            this.cboUnits.BeforeTouchSize = new System.Drawing.Size(260, 21);
            this.cboUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnits.Name = "cboUnits";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PrintingConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.configPanelControl2);
            this.Name = "PrintingConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            this.configPanelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ConfigPanelControl configPanelControl2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboOrientation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFormat;
    }
}
