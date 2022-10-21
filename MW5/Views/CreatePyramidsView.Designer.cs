namespace MW5.Views
{
    partial class CreatePyramidsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePyramidsView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnYes = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.cboInterpolation = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboCompression = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDontShow = new System.Windows.Forms.CheckBox();
            this.btnNo = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.cboInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompression)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ThemeName = "Metro";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnYes
            // 
            resources.ApplyResources(this.btnYes, "btnYes");
            this.btnYes.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnYes.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnYes.Name = "btnYes";
            this.btnYes.ThemeName = "Office2000";
            this.btnYes.UseVisualStyle = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboInterpolation
            // 
            resources.ApplyResources(this.cboInterpolation, "cboInterpolation");
            this.cboInterpolation.BeforeTouchSize = new System.Drawing.Size(290, 21);
            this.cboInterpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterpolation.Name = "cboInterpolation";
            // 
            // cboCompression
            // 
            resources.ApplyResources(this.cboCompression, "cboCompression");
            this.cboCompression.BeforeTouchSize = new System.Drawing.Size(288, 21);
            this.cboCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompression.Name = "cboCompression";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // chkDontShow
            // 
            resources.ApplyResources(this.chkDontShow, "chkDontShow");
            this.chkDontShow.Name = "chkDontShow";
            this.chkDontShow.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            resources.ApplyResources(this.btnNo, "btnNo");
            this.btnNo.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnNo.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnNo.Name = "btnNo";
            this.btnNo.ThemeName = "Office2000";
            this.btnNo.UseVisualStyle = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // CreatePyramidsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.chkDontShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCompression);
            this.Controls.Add(this.cboInterpolation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Name = "CreatePyramidsView";
            ((System.ComponentModel.ISupportInitialize)(this.cboInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompression)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnYes;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboInterpolation;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboCompression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDontShow;
        private Syncfusion.Windows.Forms.ButtonAdv btnNo;
    }
}