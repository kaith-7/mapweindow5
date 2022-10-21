using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.TableEditor.Views
{
    partial class UpdateMeasurementsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMeasurementsView));
            this.groupArea = new System.Windows.Forms.GroupBox();
            this.optAreaIgnore = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboAreaUnits = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.udAreaWidth = new System.Windows.Forms.NumericUpDown();
            this.udAreaPrecision = new System.Windows.Forms.NumericUpDown();
            this.txtAreaField = new System.Windows.Forms.TextBox();
            this.cboAreaField = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.optAreaNew = new System.Windows.Forms.RadioButton();
            this.optAreaExisting = new System.Windows.Forms.RadioButton();
            this.groupLength = new System.Windows.Forms.GroupBox();
            this.optLengthIgnore = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboLengthUnits = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.udLengthWidth = new System.Windows.Forms.NumericUpDown();
            this.udLengthPrecision = new System.Windows.Forms.NumericUpDown();
            this.txtLengthField = new System.Windows.Forms.TextBox();
            this.cboLengthField = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.optLengthNew = new System.Windows.Forms.RadioButton();
            this.optLengthExisting = new System.Windows.Forms.RadioButton();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSetDefault = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAreaUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAreaWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAreaPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAreaField)).BeginInit();
            this.groupLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLengthUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLengthWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLengthPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLengthField)).BeginInit();
            this.SuspendLayout();
            // 
            // groupArea
            // 
            resources.ApplyResources(this.groupArea, "groupArea");
            this.groupArea.Controls.Add(this.optAreaIgnore);
            this.groupArea.Controls.Add(this.pictureBox1);
            this.groupArea.Controls.Add(this.cboAreaUnits);
            this.groupArea.Controls.Add(this.label1);
            this.groupArea.Controls.Add(this.udAreaWidth);
            this.groupArea.Controls.Add(this.udAreaPrecision);
            this.groupArea.Controls.Add(this.txtAreaField);
            this.groupArea.Controls.Add(this.cboAreaField);
            this.groupArea.Controls.Add(this.optAreaNew);
            this.groupArea.Controls.Add(this.optAreaExisting);
            this.groupArea.Name = "groupArea";
            this.groupArea.TabStop = false;
            // 
            // optAreaIgnore
            // 
            resources.ApplyResources(this.optAreaIgnore, "optAreaIgnore");
            this.optAreaIgnore.Checked = true;
            this.optAreaIgnore.Name = "optAreaIgnore";
            this.optAreaIgnore.TabStop = true;
            this.optAreaIgnore.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::MW5.Plugins.TableEditor.Properties.Resources.img_geometry;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // cboAreaUnits
            // 
            resources.ApplyResources(this.cboAreaUnits, "cboAreaUnits");
            this.cboAreaUnits.BeforeTouchSize = new System.Drawing.Size(220, 21);
            this.cboAreaUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAreaUnits.Name = "cboAreaUnits";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // udAreaWidth
            // 
            resources.ApplyResources(this.udAreaWidth, "udAreaWidth");
            this.udAreaWidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.udAreaWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.udAreaWidth.Name = "udAreaWidth";
            this.udAreaWidth.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // udAreaPrecision
            // 
            resources.ApplyResources(this.udAreaPrecision, "udAreaPrecision");
            this.udAreaPrecision.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udAreaPrecision.Name = "udAreaPrecision";
            this.udAreaPrecision.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtAreaField
            // 
            resources.ApplyResources(this.txtAreaField, "txtAreaField");
            this.txtAreaField.Name = "txtAreaField";
            // 
            // cboAreaField
            // 
            resources.ApplyResources(this.cboAreaField, "cboAreaField");
            this.cboAreaField.BeforeTouchSize = new System.Drawing.Size(220, 21);
            this.cboAreaField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAreaField.Name = "cboAreaField";
            // 
            // optAreaNew
            // 
            resources.ApplyResources(this.optAreaNew, "optAreaNew");
            this.optAreaNew.Name = "optAreaNew";
            this.optAreaNew.UseVisualStyleBackColor = true;
            // 
            // optAreaExisting
            // 
            resources.ApplyResources(this.optAreaExisting, "optAreaExisting");
            this.optAreaExisting.Name = "optAreaExisting";
            this.optAreaExisting.UseVisualStyleBackColor = true;
            // 
            // groupLength
            // 
            resources.ApplyResources(this.groupLength, "groupLength");
            this.groupLength.Controls.Add(this.optLengthIgnore);
            this.groupLength.Controls.Add(this.pictureBox2);
            this.groupLength.Controls.Add(this.cboLengthUnits);
            this.groupLength.Controls.Add(this.label2);
            this.groupLength.Controls.Add(this.udLengthWidth);
            this.groupLength.Controls.Add(this.udLengthPrecision);
            this.groupLength.Controls.Add(this.txtLengthField);
            this.groupLength.Controls.Add(this.cboLengthField);
            this.groupLength.Controls.Add(this.optLengthNew);
            this.groupLength.Controls.Add(this.optLengthExisting);
            this.groupLength.Name = "groupLength";
            this.groupLength.TabStop = false;
            // 
            // optLengthIgnore
            // 
            resources.ApplyResources(this.optLengthIgnore, "optLengthIgnore");
            this.optLengthIgnore.Checked = true;
            this.optLengthIgnore.Name = "optLengthIgnore";
            this.optLengthIgnore.TabStop = true;
            this.optLengthIgnore.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::MW5.Plugins.TableEditor.Properties.Resources.img_line;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // cboLengthUnits
            // 
            resources.ApplyResources(this.cboLengthUnits, "cboLengthUnits");
            this.cboLengthUnits.BeforeTouchSize = new System.Drawing.Size(220, 21);
            this.cboLengthUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLengthUnits.Name = "cboLengthUnits";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // udLengthWidth
            // 
            resources.ApplyResources(this.udLengthWidth, "udLengthWidth");
            this.udLengthWidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.udLengthWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.udLengthWidth.Name = "udLengthWidth";
            this.udLengthWidth.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // udLengthPrecision
            // 
            resources.ApplyResources(this.udLengthPrecision, "udLengthPrecision");
            this.udLengthPrecision.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udLengthPrecision.Name = "udLengthPrecision";
            this.udLengthPrecision.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtLengthField
            // 
            resources.ApplyResources(this.txtLengthField, "txtLengthField");
            this.txtLengthField.Name = "txtLengthField";
            // 
            // cboLengthField
            // 
            resources.ApplyResources(this.cboLengthField, "cboLengthField");
            this.cboLengthField.BeforeTouchSize = new System.Drawing.Size(220, 21);
            this.cboLengthField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLengthField.Name = "cboLengthField";
            // 
            // optLengthNew
            // 
            resources.ApplyResources(this.optLengthNew, "optLengthNew");
            this.optLengthNew.Name = "optLengthNew";
            this.optLengthNew.UseVisualStyleBackColor = true;
            // 
            // optLengthExisting
            // 
            resources.ApplyResources(this.optLengthExisting, "optLengthExisting");
            this.optLengthExisting.Name = "optLengthExisting";
            this.optLengthExisting.UseVisualStyleBackColor = true;
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
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            // 
            // btnSetDefault
            // 
            resources.ApplyResources(this.btnSetDefault, "btnSetDefault");
            this.btnSetDefault.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSetDefault.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnSetDefault.ForeColor = System.Drawing.Color.White;
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.ThemeName = "Metro";
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // UpdateMeasurementsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnSetDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupLength);
            this.Controls.Add(this.groupArea);
            this.Name = "UpdateMeasurementsView";
            this.groupArea.ResumeLayout(false);
            this.groupArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAreaUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAreaWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAreaPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAreaField)).EndInit();
            this.groupLength.ResumeLayout(false);
            this.groupLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLengthUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLengthWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLengthPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLengthField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupArea;
        private ComboBoxAdv cboAreaUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udAreaWidth;
        private System.Windows.Forms.NumericUpDown udAreaPrecision;
        private System.Windows.Forms.TextBox txtAreaField;
        private ComboBoxAdv cboAreaField;
        private System.Windows.Forms.RadioButton optAreaNew;
        private System.Windows.Forms.RadioButton optAreaExisting;
        private System.Windows.Forms.GroupBox groupLength;
        private ComboBoxAdv cboLengthUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udLengthWidth;
        private System.Windows.Forms.NumericUpDown udLengthPrecision;
        private System.Windows.Forms.TextBox txtLengthField;
        private ComboBoxAdv cboLengthField;
        private System.Windows.Forms.RadioButton optLengthNew;
        private System.Windows.Forms.RadioButton optLengthExisting;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton optAreaIgnore;
        private System.Windows.Forms.RadioButton optLengthIgnore;
        private Syncfusion.Windows.Forms.ButtonAdv btnSetDefault;

    }
}