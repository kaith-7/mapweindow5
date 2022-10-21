using Syncfusion.Windows.Forms;

namespace MW5.Projections.Forms
{
    partial class CompareProjectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareProjectionForm));
            this.lblLayer = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtLayer = new System.Windows.Forms.TextBox();
            this.btnLayer = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnProject = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkWkt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLayer
            // 
            resources.ApplyResources(this.lblLayer, "lblLayer");
            this.lblLayer.Name = "lblLayer";
            // 
            // lblProject
            // 
            resources.ApplyResources(this.lblProject, "lblProject");
            this.lblProject.Name = "lblProject";
            // 
            // txtProject
            // 
            resources.ApplyResources(this.txtProject, "txtProject");
            this.txtProject.Name = "txtProject";
            // 
            // txtLayer
            // 
            resources.ApplyResources(this.txtLayer, "txtLayer");
            this.txtLayer.Name = "txtLayer";
            // 
            // btnLayer
            // 
            resources.ApplyResources(this.btnLayer, "btnLayer");
            this.btnLayer.BeforeTouchSize = new System.Drawing.Size(66, 21);
            this.btnLayer.Name = "btnLayer";
            this.btnLayer.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(89, 24);
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnProject
            // 
            resources.ApplyResources(this.btnProject, "btnProject");
            this.btnProject.BeforeTouchSize = new System.Drawing.Size(66, 21);
            this.btnProject.Name = "btnProject";
            this.btnProject.UseVisualStyleBackColor = true;
            // 
            // chkWkt
            // 
            resources.ApplyResources(this.chkWkt, "chkWkt");
            this.chkWkt.Name = "chkWkt";
            this.chkWkt.UseVisualStyleBackColor = true;
            // 
            // CompareProjectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.chkWkt);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnLayer);
            this.Controls.Add(this.txtLayer);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblLayer);
            this.Controls.Add(this.lblProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CompareProjectionForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.CompareProjectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtLayer;
        private ButtonAdv btnLayer;
        private ButtonAdv btnOk;
        private ButtonAdv btnProject;
        private System.Windows.Forms.CheckBox chkWkt;
    }
}