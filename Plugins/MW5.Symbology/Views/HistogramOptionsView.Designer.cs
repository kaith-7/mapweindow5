namespace MW5.Plugins.Symbology.Views
{
    partial class HistogramOptionsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramOptionsView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtMin = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.udNumberBuckets = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumberBuckets)).BeginInit();
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
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Office2000";
            this.btnOk.UseVisualStyle = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtMax
            // 
            resources.ApplyResources(this.txtMax, "txtMax");
            this.txtMax.BeforeTouchSize = new System.Drawing.Size(292, 21);
            this.txtMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMax.DoubleValue = 1D;
            this.txtMax.Name = "txtMax";
            this.txtMax.ThemeName = "Default";
            // 
            // txtMin
            // 
            resources.ApplyResources(this.txtMin, "txtMin");
            this.txtMin.BeforeTouchSize = new System.Drawing.Size(292, 21);
            this.txtMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMin.DoubleValue = 1D;
            this.txtMin.Name = "txtMin";
            this.txtMin.ThemeName = "Default";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.udNumberBuckets);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // udNumberBuckets
            // 
            resources.ApplyResources(this.udNumberBuckets, "udNumberBuckets");
            this.udNumberBuckets.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.udNumberBuckets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumberBuckets.Name = "udNumberBuckets";
            this.udNumberBuckets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HistogramOptionsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "HistogramOptionsView";
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumberBuckets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMax;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.NumericUpDownEx udNumberBuckets;
    }
}