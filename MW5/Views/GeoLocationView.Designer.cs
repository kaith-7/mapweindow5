using Syncfusion.Windows.Forms.Tools;

namespace MW5.Views
{
    partial class GeoLocationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoLocationView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboKnownExtents = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtFindLocation = new System.Windows.Forms.TextBox();
            this.optFindLocation = new System.Windows.Forms.RadioButton();
            this.optKnownExtents = new System.Windows.Forms.RadioButton();
            this.lblLicense = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cboKnownExtents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // cboKnownExtents
            // 
            resources.ApplyResources(this.cboKnownExtents, "cboKnownExtents");
            this.cboKnownExtents.BeforeTouchSize = new System.Drawing.Size(329, 21);
            this.cboKnownExtents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKnownExtents.Name = "cboKnownExtents";
            // 
            // txtFindLocation
            // 
            resources.ApplyResources(this.txtFindLocation, "txtFindLocation");
            this.txtFindLocation.Name = "txtFindLocation";
            // 
            // optFindLocation
            // 
            resources.ApplyResources(this.optFindLocation, "optFindLocation");
            this.optFindLocation.Checked = true;
            this.optFindLocation.Name = "optFindLocation";
            this.optFindLocation.TabStop = true;
            this.optFindLocation.UseVisualStyleBackColor = true;
            // 
            // optKnownExtents
            // 
            resources.ApplyResources(this.optKnownExtents, "optKnownExtents");
            this.optKnownExtents.Name = "optKnownExtents";
            this.optKnownExtents.UseVisualStyleBackColor = true;
            this.optKnownExtents.CheckedChanged += new System.EventHandler(this.optKnownExtents_CheckedChanged);
            // 
            // lblLicense
            // 
            resources.ApplyResources(this.lblLicense, "lblLicense");
            this.lblLicense.Name = "lblLicense";
            // 
            // GeoLocationView
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.cboKnownExtents);
            this.Controls.Add(this.txtFindLocation);
            this.Controls.Add(this.optFindLocation);
            this.Controls.Add(this.optKnownExtents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "GeoLocationView";
            ((System.ComponentModel.ISupportInitialize)(this.cboKnownExtents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private ComboBoxAdv cboKnownExtents;
        private System.Windows.Forms.TextBox txtFindLocation;
        private System.Windows.Forms.RadioButton optFindLocation;
        private System.Windows.Forms.RadioButton optKnownExtents;
        private System.Windows.Forms.Label lblLicense;
    }
}