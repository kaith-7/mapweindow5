using System.Windows.Forms;

namespace MW5.Configuration
{
    partial class VectorConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorConfigPage));
            this.cboProjectionAbsence = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboProjectionMismatch = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.chkFastMode = new System.Windows.Forms.CheckBox();
            this.chkCacheDbfRecords = new System.Windows.Forms.CheckBox();
            this.chkCacheRenderingData = new System.Windows.Forms.CheckBox();
            this.configPanelControl3 = new MW5.UI.Controls.ConfigPanelControl();
            this.udSpatialIndexCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCreateSpatialIndex = new System.Windows.Forms.CheckBox();
            this.chkSpatialIndexDialog = new System.Windows.Forms.CheckBox();
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            this.chkShareConnection = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxOgrCount = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionMismatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).BeginInit();
            this.configPanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSpatialIndexCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxOgrCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProjectionAbsence
            // 
            resources.ApplyResources(this.cboProjectionAbsence, "cboProjectionAbsence");
            this.cboProjectionAbsence.BeforeTouchSize = new System.Drawing.Size(166, 21);
            this.cboProjectionAbsence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectionAbsence.Name = "cboProjectionAbsence";
            // 
            // cboProjectionMismatch
            // 
            resources.ApplyResources(this.cboProjectionMismatch, "cboProjectionMismatch");
            this.cboProjectionMismatch.BeforeTouchSize = new System.Drawing.Size(166, 21);
            this.cboProjectionMismatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectionMismatch.Name = "cboProjectionMismatch";
            // 
            // configPanelControl1
            // 
            resources.ApplyResources(this.configPanelControl1, "configPanelControl1");
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.chkFastMode);
            this.configPanelControl1.Controls.Add(this.chkCacheDbfRecords);
            this.configPanelControl1.Controls.Add(this.chkCacheRenderingData);
            this.configPanelControl1.HeaderText = "性能和缓存";
            this.configPanelControl1.Name = "configPanelControl1";
            // 
            // chkFastMode
            // 
            resources.ApplyResources(this.chkFastMode, "chkFastMode");
            this.chkFastMode.Name = "chkFastMode";
            // 
            // chkCacheDbfRecords
            // 
            resources.ApplyResources(this.chkCacheDbfRecords, "chkCacheDbfRecords");
            this.chkCacheDbfRecords.Name = "chkCacheDbfRecords";
            // 
            // chkCacheRenderingData
            // 
            resources.ApplyResources(this.chkCacheRenderingData, "chkCacheRenderingData");
            this.chkCacheRenderingData.Name = "chkCacheRenderingData";
            // 
            // configPanelControl3
            // 
            resources.ApplyResources(this.configPanelControl3, "configPanelControl3");
            this.configPanelControl3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl3.Controls.Add(this.udSpatialIndexCount);
            this.configPanelControl3.Controls.Add(this.label2);
            this.configPanelControl3.Controls.Add(this.chkCreateSpatialIndex);
            this.configPanelControl3.Controls.Add(this.chkSpatialIndexDialog);
            this.configPanelControl3.HeaderText = "空间索引";
            this.configPanelControl3.Name = "configPanelControl3";
            // 
            // udSpatialIndexCount
            // 
            resources.ApplyResources(this.udSpatialIndexCount, "udSpatialIndexCount");
            this.udSpatialIndexCount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.udSpatialIndexCount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udSpatialIndexCount.Name = "udSpatialIndexCount";
            this.udSpatialIndexCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // chkCreateSpatialIndex
            // 
            resources.ApplyResources(this.chkCreateSpatialIndex, "chkCreateSpatialIndex");
            this.chkCreateSpatialIndex.Name = "chkCreateSpatialIndex";
            // 
            // chkSpatialIndexDialog
            // 
            resources.ApplyResources(this.chkSpatialIndexDialog, "chkSpatialIndexDialog");
            this.chkSpatialIndexDialog.Name = "chkSpatialIndexDialog";
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.chkShareConnection);
            this.configPanelControl2.Controls.Add(this.label3);
            this.configPanelControl2.Controls.Add(this.label1);
            this.configPanelControl2.Controls.Add(this.txtMaxOgrCount);
            this.configPanelControl2.HeaderText = "OGR 数据源";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // chkShareConnection
            // 
            resources.ApplyResources(this.chkShareConnection, "chkShareConnection");
            this.chkShareConnection.Name = "chkShareConnection";
            this.chkShareConnection.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtMaxOgrCount
            // 
            resources.ApplyResources(this.txtMaxOgrCount, "txtMaxOgrCount");
            this.txtMaxOgrCount.BeforeTouchSize = new System.Drawing.Size(301, 20);
            this.txtMaxOgrCount.BorderColor = System.Drawing.Color.LightGray;
            this.txtMaxOgrCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxOgrCount.IntegerValue = ((long)(1));
            this.txtMaxOgrCount.MinValue = ((long)(0));
            this.txtMaxOgrCount.Name = "txtMaxOgrCount";
            this.txtMaxOgrCount.ThemeName = "Default";
            // 
            // VectorConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.configPanelControl2);
            this.Controls.Add(this.configPanelControl1);
            this.Controls.Add(this.configPanelControl3);
            this.Name = "VectorConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProjectionMismatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).EndInit();
            this.configPanelControl3.ResumeLayout(false);
            this.configPanelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSpatialIndexCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            this.configPanelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxOgrCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboProjectionAbsence;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboProjectionMismatch;
        private CheckBox chkSpatialIndexDialog;
        private CheckBox chkCreateSpatialIndex;
        private Label label2;
        private NumericUpDown udSpatialIndexCount;
        private UI.Controls.ConfigPanelControl configPanelControl3;
        private UI.Controls.ConfigPanelControl configPanelControl1;
        private CheckBox chkCacheDbfRecords;
        private CheckBox chkCacheRenderingData;
        private CheckBox chkFastMode;
        private UI.Controls.ConfigPanelControl configPanelControl2;
        private Label label3;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtMaxOgrCount;
        private CheckBox chkShareConnection;
    }
}
