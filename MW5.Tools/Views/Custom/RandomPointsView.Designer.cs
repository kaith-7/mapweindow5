namespace MW5.Tools.Views.Custom
{
    partial class RandomPointsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomPointsView));
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRun = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboLayers = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumPoints = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.cboLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputName)).BeginInit();
            this.SuspendLayout();
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
            // 
            // cboLayers
            // 
            resources.ApplyResources(this.cboLayers, "cboLayers");
            this.cboLayers.BeforeTouchSize = new System.Drawing.Size(387, 21);
            this.cboLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLayers.Name = "cboLayers";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtNumPoints
            // 
            resources.ApplyResources(this.txtNumPoints, "txtNumPoints");
            this.txtNumPoints.BeforeTouchSize = new System.Drawing.Size(387, 21);
            this.txtNumPoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumPoints.IntegerValue = ((long)(500));
            this.txtNumPoints.Name = "txtNumPoints";
            this.txtNumPoints.ThemeName = "Default";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtOutputName
            // 
            resources.ApplyResources(this.txtOutputName, "txtOutputName");
            this.txtOutputName.BeforeTouchSize = new System.Drawing.Size(387, 21);
            this.txtOutputName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.ThemeName = "Default";
            // 
            // RandomPointsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.txtOutputName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLayers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Name = "RandomPointsView";
            ((System.ComponentModel.ISupportInitialize)(this.cboLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.ButtonAdv btnRun;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboLayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtNumPoints;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtOutputName;
    }
}