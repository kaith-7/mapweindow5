namespace MW5.Plugins.TableEditor.Views
{
    partial class FieldPropertiesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldPropertiesView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.udPrecision = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.cboDataType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDataType)).BeginInit();
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
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtAlias
            // 
            resources.ApplyResources(this.txtAlias, "txtAlias");
            this.txtAlias.Name = "txtAlias";
            // 
            // chkVisible
            // 
            resources.ApplyResources(this.chkVisible, "chkVisible");
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.UseVisualStyleBackColor = true;
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
            // udPrecision
            // 
            resources.ApplyResources(this.udPrecision, "udPrecision");
            this.udPrecision.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.udPrecision.Name = "udPrecision";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // udWidth
            // 
            resources.ApplyResources(this.udWidth, "udWidth");
            this.udWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udWidth.Name = "udWidth";
            this.udWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboDataType
            // 
            resources.ApplyResources(this.cboDataType, "cboDataType");
            this.cboDataType.BeforeTouchSize = new System.Drawing.Size(192, 21);
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtExpression);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboDataType);
            this.groupBox1.Controls.Add(this.udPrecision);
            this.groupBox1.Controls.Add(this.chkVisible);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAlias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.udWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtExpression
            // 
            resources.ApplyResources(this.txtExpression, "txtExpression");
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // FieldPropertiesView
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FieldPropertiesView";
            ((System.ComponentModel.ISupportInitialize)(this.udPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDataType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udPrecision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown udWidth;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboDataType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label label6;
    }
}