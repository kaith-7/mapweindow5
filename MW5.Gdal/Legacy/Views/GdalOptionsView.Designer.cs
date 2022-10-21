namespace MW5.Gdal.Legacy.Views
{
    partial class GdalOptionsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GdalOptionsView));
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRun = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtMain = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtAdditional = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDontShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdditional)).BeginInit();
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
            // txtMain
            // 
            resources.ApplyResources(this.txtMain, "txtMain");
            this.txtMain.BeforeTouchSize = new System.Drawing.Size(439, 72);
            this.txtMain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.ThemeName = "Default";
            // 
            // txtAdditional
            // 
            resources.ApplyResources(this.txtAdditional, "txtAdditional");
            this.txtAdditional.BeforeTouchSize = new System.Drawing.Size(439, 72);
            this.txtAdditional.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.ThemeName = "Default";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chkDontShow
            // 
            resources.ApplyResources(this.chkDontShow, "chkDontShow");
            this.chkDontShow.Name = "chkDontShow";
            this.chkDontShow.UseVisualStyleBackColor = true;
            // 
            // GdalOptionsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.chkDontShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdditional);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Name = "GdalOptionsView";
            ((System.ComponentModel.ISupportInitialize)(this.txtMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdditional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.ButtonAdv btnRun;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMain;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAdditional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDontShow;
    }
}