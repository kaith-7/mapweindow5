namespace MW5.Plugins.Symbology.Views
{
    partial class RasterMinMaxView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasterMinMaxView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.optPrecise = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.optRange = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.optStdDev = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRangeMin = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtRangeMax = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtStdDev = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.optPrecise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optStdDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdDev)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // optPrecise
            // 
            resources.ApplyResources(this.optPrecise, "optPrecise");
            this.optPrecise.BeforeTouchSize = new System.Drawing.Size(132, 19);
            this.optPrecise.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.optPrecise.Name = "optPrecise";
            // 
            // optRange
            // 
            resources.ApplyResources(this.optRange, "optRange");
            this.optRange.BeforeTouchSize = new System.Drawing.Size(150, 19);
            this.optRange.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.optRange.Name = "optRange";
            // 
            // optStdDev
            // 
            resources.ApplyResources(this.optStdDev, "optStdDev");
            this.optStdDev.BeforeTouchSize = new System.Drawing.Size(132, 19);
            this.optStdDev.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.optStdDev.Name = "optStdDev";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtRangeMin
            // 
            resources.ApplyResources(this.txtRangeMin, "txtRangeMin");
            this.txtRangeMin.BeforeTouchSize = new System.Drawing.Size(292, 21);
            this.txtRangeMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRangeMin.DoubleValue = 2D;
            this.txtRangeMin.Name = "txtRangeMin";
            this.txtRangeMin.ThemeName = "Default";
            // 
            // txtRangeMax
            // 
            resources.ApplyResources(this.txtRangeMax, "txtRangeMax");
            this.txtRangeMax.BeforeTouchSize = new System.Drawing.Size(292, 21);
            this.txtRangeMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRangeMax.DoubleValue = 98D;
            this.txtRangeMax.Name = "txtRangeMax";
            this.txtRangeMax.ThemeName = "Default";
            // 
            // txtStdDev
            // 
            resources.ApplyResources(this.txtStdDev, "txtStdDev");
            this.txtStdDev.BeforeTouchSize = new System.Drawing.Size(292, 21);
            this.txtStdDev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStdDev.DoubleValue = 2D;
            this.txtStdDev.MaxValue = 5D;
            this.txtStdDev.MinValue = 0D;
            this.txtStdDev.Name = "txtStdDev";
            this.txtStdDev.ThemeName = "Default";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtRangeMax);
            this.groupBox1.Controls.Add(this.txtStdDev);
            this.groupBox1.Controls.Add(this.optPrecise);
            this.groupBox1.Controls.Add(this.optRange);
            this.groupBox1.Controls.Add(this.txtRangeMin);
            this.groupBox1.Controls.Add(this.optStdDev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // RasterMinMaxView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "RasterMinMaxView";
            ((System.ComponentModel.ISupportInitialize)(this.optPrecise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optStdDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdDev)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv optPrecise;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv optRange;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv optStdDev;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtRangeMin;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtRangeMax;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtStdDev;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}