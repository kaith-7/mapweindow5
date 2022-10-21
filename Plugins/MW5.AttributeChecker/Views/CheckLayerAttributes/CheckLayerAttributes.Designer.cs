namespace MW5.Plugins.AttributeChecker.Views.CheckLayerAttributes
{
    partial class CheckLayerAttributes
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
            this.boxInputLayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRuleTemplate = new System.Windows.Forms.TextBox();
            this.btnSelectTemplate = new System.Windows.Forms.Button();
            this.lvCheckRules = new System.Windows.Forms.ListView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportCheckTemplate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boxInputLayer
            // 
            this.boxInputLayer.FormattingEnabled = true;
            this.boxInputLayer.Location = new System.Drawing.Point(71, 20);
            this.boxInputLayer.Name = "boxInputLayer";
            this.boxInputLayer.Size = new System.Drawing.Size(370, 20);
            this.boxInputLayer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入图层";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "规则文件";
            // 
            // txtRuleTemplate
            // 
            this.txtRuleTemplate.Location = new System.Drawing.Point(71, 50);
            this.txtRuleTemplate.Name = "txtRuleTemplate";
            this.txtRuleTemplate.Size = new System.Drawing.Size(305, 21);
            this.txtRuleTemplate.TabIndex = 3;
            // 
            // btnSelectTemplate
            // 
            this.btnSelectTemplate.Location = new System.Drawing.Point(382, 50);
            this.btnSelectTemplate.Name = "btnSelectTemplate";
            this.btnSelectTemplate.Size = new System.Drawing.Size(59, 23);
            this.btnSelectTemplate.TabIndex = 4;
            this.btnSelectTemplate.Text = "文件";
            this.btnSelectTemplate.UseVisualStyleBackColor = true;
            this.btnSelectTemplate.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // lvCheckRules
            // 
            this.lvCheckRules.HideSelection = false;
            this.lvCheckRules.Location = new System.Drawing.Point(14, 80);
            this.lvCheckRules.Name = "lvCheckRules";
            this.lvCheckRules.Size = new System.Drawing.Size(427, 391);
            this.lvCheckRules.TabIndex = 5;
            this.lvCheckRules.UseCompatibleStateImageBehavior = false;
            this.lvCheckRules.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvCheckRules_MouseClick);
            this.lvCheckRules.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCheckRules_MouseDoubleClick);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(317, 477);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExportCheckTemplate
            // 
            this.btnExportCheckTemplate.Location = new System.Drawing.Point(14, 477);
            this.btnExportCheckTemplate.Name = "btnExportCheckTemplate";
            this.btnExportCheckTemplate.Size = new System.Drawing.Size(103, 23);
            this.btnExportCheckTemplate.TabIndex = 8;
            this.btnExportCheckTemplate.Text = "保存检查规则";
            this.btnExportCheckTemplate.UseVisualStyleBackColor = true;
            this.btnExportCheckTemplate.Click += new System.EventHandler(this.btnExportCheckTemplate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 477);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // CheckLayerAttributes
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(453, 512);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnExportCheckTemplate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvCheckRules);
            this.Controls.Add(this.btnSelectTemplate);
            this.Controls.Add(this.txtRuleTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxInputLayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckLayerAttributes";
            this.Text = "检查图层属性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxInputLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuleTemplate;
        private System.Windows.Forms.Button btnSelectTemplate;
        private System.Windows.Forms.ListView lvCheckRules;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportCheckTemplate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}