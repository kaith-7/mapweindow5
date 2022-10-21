using MW5.Api.Enums;
using MW5.Plugins.Symbology.Controls;
using MW5.Plugins.Symbology.Controls.ImageCombo;

namespace MW5.Plugins.Symbology.Forms
{
    partial class AddCategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoriesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.icbColors = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.numericUpDownExt1 = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chkRandom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.icbColors);
            this.groupBox1.Controls.Add(this.numericUpDownExt1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkRandom
            // 
            resources.ApplyResources(this.chkRandom, "chkRandom");
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // icbColors
            // 
            resources.ApplyResources(this.icbColors, "icbColors");
            this.icbColors.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbColors.FormattingEnabled = true;
            this.icbColors.Name = "icbColors";
            this.icbColors.OutlineColor = System.Drawing.Color.Black;
            this.icbColors.Target = MW5.Plugins.Symbology.SchemeTarget.Vector;
            // 
            // numericUpDownExt1
            // 
            resources.ApplyResources(this.numericUpDownExt1, "numericUpDownExt1");
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddCategoriesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCategoriesForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddCategoriesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal NumericUpDownEx numericUpDownExt1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal ColorSchemeCombo icbColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.CheckBox chkRandom;
    }
}