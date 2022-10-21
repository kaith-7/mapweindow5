using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.Printing.Views
{
    partial class PageSetupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSetupView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLeftUnit = new System.Windows.Forms.Label();
            this.lblRightUnit = new System.Windows.Forms.Label();
            this.lblBottomUnit = new System.Windows.Forms.Label();
            this.lblTopUnit = new System.Windows.Forms.Label();
            this.txtMarginRight = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtMarginBottom = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtMarginLeft = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtMarginTop = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPaperSizes = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.optPortrait = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.optLandscape = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaperSizes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(81, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ThemeName = "Metro";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(84, 24);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            // 
            // GroupBox1
            // 
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Controls.Add(this.lblLeftUnit);
            this.GroupBox1.Controls.Add(this.lblRightUnit);
            this.GroupBox1.Controls.Add(this.lblBottomUnit);
            this.GroupBox1.Controls.Add(this.lblTopUnit);
            this.GroupBox1.Controls.Add(this.txtMarginRight);
            this.GroupBox1.Controls.Add(this.txtMarginBottom);
            this.GroupBox1.Controls.Add(this.txtMarginLeft);
            this.GroupBox1.Controls.Add(this.txtMarginTop);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // lblLeftUnit
            // 
            resources.ApplyResources(this.lblLeftUnit, "lblLeftUnit");
            this.lblLeftUnit.Name = "lblLeftUnit";
            // 
            // lblRightUnit
            // 
            resources.ApplyResources(this.lblRightUnit, "lblRightUnit");
            this.lblRightUnit.Name = "lblRightUnit";
            // 
            // lblBottomUnit
            // 
            resources.ApplyResources(this.lblBottomUnit, "lblBottomUnit");
            this.lblBottomUnit.Name = "lblBottomUnit";
            // 
            // lblTopUnit
            // 
            resources.ApplyResources(this.lblTopUnit, "lblTopUnit");
            this.lblTopUnit.Name = "lblTopUnit";
            // 
            // txtMarginRight
            // 
            resources.ApplyResources(this.txtMarginRight, "txtMarginRight");
            this.txtMarginRight.BeforeTouchSize = new System.Drawing.Size(62, 21);
            this.txtMarginRight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarginRight.DoubleValue = 1D;
            this.txtMarginRight.Name = "txtMarginRight";
            this.txtMarginRight.ThemeName = "Default";
            // 
            // txtMarginBottom
            // 
            resources.ApplyResources(this.txtMarginBottom, "txtMarginBottom");
            this.txtMarginBottom.BeforeTouchSize = new System.Drawing.Size(62, 21);
            this.txtMarginBottom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarginBottom.DoubleValue = 1D;
            this.txtMarginBottom.Name = "txtMarginBottom";
            this.txtMarginBottom.ThemeName = "Default";
            // 
            // txtMarginLeft
            // 
            resources.ApplyResources(this.txtMarginLeft, "txtMarginLeft");
            this.txtMarginLeft.BeforeTouchSize = new System.Drawing.Size(62, 21);
            this.txtMarginLeft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarginLeft.DoubleValue = 1D;
            this.txtMarginLeft.Name = "txtMarginLeft";
            this.txtMarginLeft.ThemeName = "Default";
            // 
            // txtMarginTop
            // 
            resources.ApplyResources(this.txtMarginTop, "txtMarginTop");
            this.txtMarginTop.BeforeTouchSize = new System.Drawing.Size(62, 21);
            this.txtMarginTop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarginTop.DoubleValue = 1D;
            this.txtMarginTop.Name = "txtMarginTop";
            this.txtMarginTop.ThemeName = "Default";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // cboPaperSizes
            // 
            resources.ApplyResources(this.cboPaperSizes, "cboPaperSizes");
            this.cboPaperSizes.BeforeTouchSize = new System.Drawing.Size(250, 21);
            this.cboPaperSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaperSizes.Name = "cboPaperSizes";
            // 
            // optPortrait
            // 
            resources.ApplyResources(this.optPortrait, "optPortrait");
            this.optPortrait.Name = "optPortrait";
            this.optPortrait.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::MW5.Plugins.Printing.Properties.Resources.img_landscape32;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::MW5.Plugins.Printing.Properties.Resources.img_portrait32;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // optLandscape
            // 
            resources.ApplyResources(this.optLandscape, "optLandscape");
            this.optLandscape.Checked = true;
            this.optLandscape.Name = "optLandscape";
            this.optLandscape.TabStop = true;
            this.optLandscape.UseVisualStyleBackColor = true;
            // 
            // PageSetupView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.optLandscape);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.optPortrait);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboPaperSizes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "PageSetupView";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarginTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaperSizes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal ComboBoxAdv cboPaperSizes;
        private DoubleTextBox txtMarginRight;
        private DoubleTextBox txtMarginBottom;
        private DoubleTextBox txtMarginLeft;
        private DoubleTextBox txtMarginTop;
        private System.Windows.Forms.RadioButton optPortrait;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton optLandscape;
        private System.Windows.Forms.Label lblLeftUnit;
        private System.Windows.Forms.Label lblRightUnit;
        private System.Windows.Forms.Label lblBottomUnit;
        private System.Windows.Forms.Label lblTopUnit;
    }
}