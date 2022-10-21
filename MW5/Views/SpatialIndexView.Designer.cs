namespace MW5.Views
{
    partial class SpatialIndexView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpatialIndexView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNo = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkDontShow = new System.Windows.Forms.CheckBox();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnYes = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
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
            // chkDontShow
            // 
            resources.ApplyResources(this.chkDontShow, "chkDontShow");
            this.chkDontShow.Name = "chkDontShow";
            this.chkDontShow.UseVisualStyleBackColor = true;
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
            // SpatialIndexView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.chkDontShow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SpatialIndexView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv btnNo;
        private System.Windows.Forms.CheckBox chkDontShow;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnYes;
    }
}