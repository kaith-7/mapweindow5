using MW5.Plugins.Symbology.Controls;
using MW5.Plugins.Symbology.Controls.ImageCombo;

namespace MW5.Plugins.Symbology.Forms
{
    partial class GenerateCategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateCategoriesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCategoriesCount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClassificationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.udMaxSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udMinSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.btnChangeColorScheme = new System.Windows.Forms.Button();
            this.chkSetGradient = new System.Windows.Forms.CheckBox();
            this.chkUseVariableSize = new System.Windows.Forms.CheckBox();
            this.icbColorScheme = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.chkRandomColors = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.cboField);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboCategoriesCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboClassificationType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cboField
            // 
            resources.ApplyResources(this.cboField, "cboField");
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Name = "cboField";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // cboCategoriesCount
            // 
            resources.ApplyResources(this.cboCategoriesCount, "cboCategoriesCount");
            this.cboCategoriesCount.FormattingEnabled = true;
            this.cboCategoriesCount.Name = "cboCategoriesCount";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboClassificationType
            // 
            resources.ApplyResources(this.cboClassificationType, "cboClassificationType");
            this.cboClassificationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassificationType.FormattingEnabled = true;
            this.cboClassificationType.Name = "cboClassificationType";
            this.cboClassificationType.SelectedIndexChanged += new System.EventHandler(this.RefreshControlsState);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.udMaxSize);
            this.groupBox2.Controls.Add(this.udMinSize);
            this.groupBox2.Controls.Add(this.btnChangeColorScheme);
            this.groupBox2.Controls.Add(this.chkSetGradient);
            this.groupBox2.Controls.Add(this.chkUseVariableSize);
            this.groupBox2.Controls.Add(this.icbColorScheme);
            this.groupBox2.Controls.Add(this.chkRandomColors);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // udMaxSize
            // 
            resources.ApplyResources(this.udMaxSize, "udMaxSize");
            this.udMaxSize.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udMaxSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udMaxSize.Name = "udMaxSize";
            this.udMaxSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udMinSize
            // 
            resources.ApplyResources(this.udMinSize, "udMinSize");
            this.udMinSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.udMinSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udMinSize.Name = "udMinSize";
            this.udMinSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnChangeColorScheme
            // 
            resources.ApplyResources(this.btnChangeColorScheme, "btnChangeColorScheme");
            this.btnChangeColorScheme.Name = "btnChangeColorScheme";
            this.btnChangeColorScheme.UseVisualStyleBackColor = true;
            this.btnChangeColorScheme.Click += new System.EventHandler(this.btnChangeColorScheme_Click);
            // 
            // chkSetGradient
            // 
            resources.ApplyResources(this.chkSetGradient, "chkSetGradient");
            this.chkSetGradient.Checked = true;
            this.chkSetGradient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetGradient.Name = "chkSetGradient";
            this.chkSetGradient.UseVisualStyleBackColor = true;
            // 
            // chkUseVariableSize
            // 
            resources.ApplyResources(this.chkUseVariableSize, "chkUseVariableSize");
            this.chkUseVariableSize.Name = "chkUseVariableSize";
            this.chkUseVariableSize.UseVisualStyleBackColor = true;
            this.chkUseVariableSize.CheckedChanged += new System.EventHandler(this.RefreshControlsState);
            // 
            // icbColorScheme
            // 
            resources.ApplyResources(this.icbColorScheme, "icbColorScheme");
            this.icbColorScheme.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbColorScheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbColorScheme.FormattingEnabled = true;
            this.icbColorScheme.Name = "icbColorScheme";
            this.icbColorScheme.OutlineColor = System.Drawing.Color.Black;
            this.icbColorScheme.Target = MW5.Plugins.Symbology.SchemeTarget.Vector;
            // 
            // chkRandomColors
            // 
            resources.ApplyResources(this.chkRandomColors, "chkRandomColors");
            this.chkRandomColors.Name = "chkRandomColors";
            this.chkRandomColors.UseVisualStyleBackColor = true;
            this.chkRandomColors.CheckedChanged += new System.EventHandler(this.chkRandomColors_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // GenerateCategoriesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateCategoriesForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.GenerateCategoriesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCategoriesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClassificationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUseVariableSize;
        private ColorSchemeCombo icbColorScheme;
        private System.Windows.Forms.CheckBox chkRandomColors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSetGradient;
        private System.Windows.Forms.Button btnChangeColorScheme;
        private NumericUpDownEx udMaxSize;
        private NumericUpDownEx udMinSize;
    }
}