namespace MW5.Plugins.DevicesManager
{
    partial class CsvToShp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Out = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gradientLabel_out = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel_choose = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel_open = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.cmbY = new System.Windows.Forms.ComboBox();
            this.textBox_In = new System.Windows.Forms.TextBox();
            this.cmbX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox_Out);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gradientLabel_out);
            this.panel1.Controls.Add(this.gradientLabel_choose);
            this.panel1.Controls.Add(this.gradientLabel_open);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_open);
            this.panel1.Controls.Add(this.cmbY);
            this.panel1.Controls.Add(this.textBox_In);
            this.panel1.Controls.Add(this.cmbX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 403);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_Out
            // 
            this.textBox_Out.Location = new System.Drawing.Point(52, 337);
            this.textBox_Out.Name = "textBox_Out";
            this.textBox_Out.Size = new System.Drawing.Size(436, 25);
            this.textBox_Out.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "输出文件：";
            // 
            // gradientLabel_out
            // 
            this.gradientLabel_out.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.WhiteSmoke);
            this.gradientLabel_out.BeforeTouchSize = new System.Drawing.Size(549, 23);
            this.gradientLabel_out.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.gradientLabel_out.BorderColor = System.Drawing.Color.Gainsboro;
            this.gradientLabel_out.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.gradientLabel_out.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gradientLabel_out.Location = new System.Drawing.Point(36, 269);
            this.gradientLabel_out.Name = "gradientLabel_out";
            this.gradientLabel_out.Size = new System.Drawing.Size(549, 23);
            this.gradientLabel_out.TabIndex = 9;
            this.gradientLabel_out.Text = "输出";
            this.gradientLabel_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel_choose
            // 
            this.gradientLabel_choose.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.WhiteSmoke);
            this.gradientLabel_choose.BeforeTouchSize = new System.Drawing.Size(549, 23);
            this.gradientLabel_choose.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.gradientLabel_choose.BorderColor = System.Drawing.Color.Gainsboro;
            this.gradientLabel_choose.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.gradientLabel_choose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gradientLabel_choose.Location = new System.Drawing.Point(36, 127);
            this.gradientLabel_choose.Name = "gradientLabel_choose";
            this.gradientLabel_choose.Size = new System.Drawing.Size(549, 23);
            this.gradientLabel_choose.TabIndex = 9;
            this.gradientLabel_choose.Text = "选择列";
            this.gradientLabel_choose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel_open
            // 
            this.gradientLabel_open.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.WhiteSmoke);
            this.gradientLabel_open.BeforeTouchSize = new System.Drawing.Size(549, 23);
            this.gradientLabel_open.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.gradientLabel_open.BorderColor = System.Drawing.Color.Gainsboro;
            this.gradientLabel_open.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.gradientLabel_open.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gradientLabel_open.Location = new System.Drawing.Point(36, 18);
            this.gradientLabel_open.Name = "gradientLabel_open";
            this.gradientLabel_open.Size = new System.Drawing.Size(549, 23);
            this.gradientLabel_open.TabIndex = 9;
            this.gradientLabel_open.Text = "输入";
            this.gradientLabel_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X对应列：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y对应列：";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(510, 72);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(53, 26);
            this.button_open.TabIndex = 8;
            this.button_open.Text = "..";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // cmbY
            // 
            this.cmbY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbY.FormattingEnabled = true;
            this.cmbY.Location = new System.Drawing.Point(163, 215);
            this.cmbY.Name = "cmbY";
            this.cmbY.Size = new System.Drawing.Size(156, 23);
            this.cmbY.TabIndex = 3;
            // 
            // textBox_In
            // 
            this.textBox_In.Location = new System.Drawing.Point(52, 75);
            this.textBox_In.Name = "textBox_In";
            this.textBox_In.Size = new System.Drawing.Size(436, 25);
            this.textBox_In.TabIndex = 7;
            this.textBox_In.TextChanged += new System.EventHandler(this.textBox_In_TextChanged);
            // 
            // cmbX
            // 
            this.cmbX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbX.FormattingEnabled = true;
            this.cmbX.Location = new System.Drawing.Point(163, 166);
            this.cmbX.Name = "cmbX";
            this.cmbX.Size = new System.Drawing.Size(156, 23);
            this.cmbX.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "输入文件：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_OK);
            this.panel2.Controls.Add(this.button_Cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 60);
            this.panel2.TabIndex = 1;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(413, 21);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 30);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "运行";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(510, 21);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 30);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // CsvToShp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CsvToShp";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "csv转shp";
            this.Load += new System.EventHandler(this.ChooseColumnView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbY;
        private System.Windows.Forms.ComboBox cmbX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.TextBox textBox_In;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel_open;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel_out;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel_choose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Out;
        private System.Windows.Forms.Label label4;
    }
}