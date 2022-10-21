using MW5.UI.Controls;
using MW5.UI.Enums;

namespace MW5.Plugins.Symbology.Forms
{
    partial class FontGradientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontGradientForm));
            this.label8 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUseGradient = new System.Windows.Forms.CheckBox();
            this.clpFont1 = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.clpFont2 = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.icbFontGradient = new MW5.UI.Controls.ImageCombo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
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
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chkUseGradient);
            this.groupBox1.Controls.Add(this.clpFont1);
            this.groupBox1.Controls.Add(this.clpFont2);
            this.groupBox1.Controls.Add(this.icbFontGradient);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkUseGradient
            // 
            resources.ApplyResources(this.chkUseGradient, "chkUseGradient");
            this.chkUseGradient.Name = "chkUseGradient";
            this.chkUseGradient.UseVisualStyleBackColor = true;
            this.chkUseGradient.CheckedChanged += new System.EventHandler(this.chkUseGradient_CheckedChanged);
            // 
            // clpFont1
            // 
            resources.ApplyResources(this.clpFont1, "clpFont1");
            this.clpFont1.Color = System.Drawing.Color.Black;
            this.clpFont1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFont1.DropDownHeight = 1;
            this.clpFont1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFont1.FormattingEnabled = true;
            this.clpFont1.Items.AddRange(new object[] {
            resources.GetString("clpFont1.Items")});
            this.clpFont1.Name = "clpFont1";
            this.clpFont1.SelectedColorChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // clpFont2
            // 
            resources.ApplyResources(this.clpFont2, "clpFont2");
            this.clpFont2.Color = System.Drawing.Color.Black;
            this.clpFont2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFont2.DropDownHeight = 1;
            this.clpFont2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFont2.FormattingEnabled = true;
            this.clpFont2.Items.AddRange(new object[] {
            resources.GetString("clpFont2.Items")});
            this.clpFont2.Name = "clpFont2";
            this.clpFont2.SelectedColorChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // icbFontGradient
            // 
            resources.ApplyResources(this.icbFontGradient, "icbFontGradient");
            this.icbFontGradient.Color1 = System.Drawing.Color.Blue;
            this.icbFontGradient.Color2 = System.Drawing.Color.Honeydew;
            this.icbFontGradient.ComboStyle = MW5.UI.Enums.ImageComboStyle.Common;
            this.icbFontGradient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbFontGradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbFontGradient.FormattingEnabled = true;
            this.icbFontGradient.Name = "icbFontGradient";
            this.icbFontGradient.OutlineColor = System.Drawing.Color.Black;
            this.icbFontGradient.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // FontGradientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontGradientForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FontGradientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private ImageCombo icbFontGradient;
        private Office2007ColorPicker clpFont2;
        private Office2007ColorPicker clpFont1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseGradient;
    }
}