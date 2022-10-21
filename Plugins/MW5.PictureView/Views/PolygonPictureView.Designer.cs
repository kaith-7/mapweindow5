using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.PictureView.Views
{
    partial class PolygonPictureView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolygonPictureView));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PicturePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_KeyField = new System.Windows.Forms.ComboBox();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBox_Layer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "照片路径";
            // 
            // textBox_PicturePath
            // 
            this.textBox_PicturePath.Location = new System.Drawing.Point(12, 26);
            this.textBox_PicturePath.Name = "textBox_PicturePath";
            this.textBox_PicturePath.Size = new System.Drawing.Size(428, 21);
            this.textBox_PicturePath.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "关联字段";
            // 
            // comboBox_KeyField
            // 
            this.comboBox_KeyField.FormattingEnabled = true;
            this.comboBox_KeyField.Location = new System.Drawing.Point(12, 107);
            this.comboBox_KeyField.Name = "comboBox_KeyField";
            this.comboBox_KeyField.Size = new System.Drawing.Size(428, 20);
            this.comboBox_KeyField.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 27);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(257, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 27);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.ThemeName = "Metro";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(85, 27);
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(166, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 27);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确认";
            this.btnOK.ThemeName = "Metro";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // comboBox_Layer
            // 
            this.comboBox_Layer.FormattingEnabled = true;
            this.comboBox_Layer.Location = new System.Drawing.Point(12, 67);
            this.comboBox_Layer.Name = "comboBox_Layer";
            this.comboBox_Layer.Size = new System.Drawing.Size(428, 20);
            this.comboBox_Layer.TabIndex = 17;
            this.comboBox_Layer.SelectedIndexChanged += new System.EventHandler(this.comboBox_Layer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "图层";
            // 
            // PolygonPictureView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(491, 179);
            this.Controls.Add(this.comboBox_Layer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboBox_KeyField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_PicturePath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolygonPictureView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置小班照片路径";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PicturePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_KeyField;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private System.Windows.Forms.ComboBox comboBox_Layer;
        private System.Windows.Forms.Label label3;
    }
}