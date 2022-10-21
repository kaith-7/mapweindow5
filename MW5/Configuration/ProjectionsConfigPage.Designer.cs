using System.Windows.Forms;

namespace MW5.Configuration
{
    partial class ProjectionsConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectionsConfigPage));
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboProjectionAbsence = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProjectionMismatch = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkProjectionDialog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionMismatch)).BeginInit();
            this.SuspendLayout();
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.checkBox1);
            this.configPanelControl2.Controls.Add(this.cboProjectionAbsence);
            this.configPanelControl2.Controls.Add(this.label3);
            this.configPanelControl2.Controls.Add(this.label5);
            this.configPanelControl2.Controls.Add(this.cboProjectionMismatch);
            this.configPanelControl2.Controls.Add(this.chkProjectionDialog);
            this.configPanelControl2.HeaderText = "投影";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            // 
            // cboProjectionAbsence
            // 
            resources.ApplyResources(this.cboProjectionAbsence, "cboProjectionAbsence");
            this.cboProjectionAbsence.BeforeTouchSize = new System.Drawing.Size(166, 21);
            this.cboProjectionAbsence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectionAbsence.Name = "cboProjectionAbsence";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboProjectionMismatch
            // 
            resources.ApplyResources(this.cboProjectionMismatch, "cboProjectionMismatch");
            this.cboProjectionMismatch.BeforeTouchSize = new System.Drawing.Size(166, 21);
            this.cboProjectionMismatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectionMismatch.Name = "cboProjectionMismatch";
            // 
            // chkProjectionDialog
            // 
            resources.ApplyResources(this.chkProjectionDialog, "chkProjectionDialog");
            this.chkProjectionDialog.Name = "chkProjectionDialog";
            this.chkProjectionDialog.CheckedChanged += new System.EventHandler(this.chkProjectionDialog_CheckedChanged);
            // 
            // ProjectionsConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.configPanelControl2);
            this.Name = "ProjectionsConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            this.configPanelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionMismatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ConfigPanelControl configPanelControl2;
        private CheckBox chkProjectionDialog;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboProjectionAbsence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboProjectionMismatch;
        private CheckBox checkBox1;
    }
}
