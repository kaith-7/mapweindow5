namespace MW5.Plugins.Symbology.Forms
{
    partial class AddChartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChartsForm));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.optPosition4 = new System.Windows.Forms.RadioButton();
            this.optPosition3 = new System.Windows.Forms.RadioButton();
            this.optPosition2 = new System.Windows.Forms.RadioButton();
            this.optPosition1 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.optPosition4);
            this.groupBox5.Controls.Add(this.optPosition3);
            this.groupBox5.Controls.Add(this.optPosition2);
            this.groupBox5.Controls.Add(this.optPosition1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // optPosition4
            // 
            resources.ApplyResources(this.optPosition4, "optPosition4");
            this.optPosition4.Name = "optPosition4";
            this.optPosition4.UseVisualStyleBackColor = true;
            // 
            // optPosition3
            // 
            resources.ApplyResources(this.optPosition3, "optPosition3");
            this.optPosition3.Name = "optPosition3";
            this.optPosition3.UseVisualStyleBackColor = true;
            // 
            // optPosition2
            // 
            resources.ApplyResources(this.optPosition2, "optPosition2");
            this.optPosition2.Name = "optPosition2";
            this.optPosition2.UseVisualStyleBackColor = true;
            // 
            // optPosition1
            // 
            resources.ApplyResources(this.optPosition1, "optPosition1");
            this.optPosition1.Checked = true;
            this.optPosition1.Name = "optPosition1";
            this.optPosition1.TabStop = true;
            this.optPosition1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddChartsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddChartsForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddChartsForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton optPosition4;
        private System.Windows.Forms.RadioButton optPosition3;
        private System.Windows.Forms.RadioButton optPosition2;
        private System.Windows.Forms.RadioButton optPosition1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}