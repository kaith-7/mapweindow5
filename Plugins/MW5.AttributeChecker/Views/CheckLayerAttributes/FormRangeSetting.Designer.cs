namespace MW5.Plugins.AttributeChecker.Views.CheckLayerAttributes
{
    partial class FormRangeSetting
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.relationPanel2 = new MW5.Plugins.AttributeChecker.Views.CheckLayerAttributes.RelationPanel();
            this.relationPanel1 = new MW5.Plugins.AttributeChecker.Views.CheckLayerAttributes.RelationPanel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(291, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(226, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // relationPanel2
            // 
            this.relationPanel2.expression = " ";
            this.relationPanel2.Location = new System.Drawing.Point(13, 42);
            this.relationPanel2.Name = "relationPanel2";
            this.relationPanel2.relation = "and";
            this.relationPanel2.Size = new System.Drawing.Size(337, 35);
            this.relationPanel2.TabIndex = 11;
            // 
            // relationPanel1
            // 
            this.relationPanel1.expression = " ";
            this.relationPanel1.Location = new System.Drawing.Point(12, 12);
            this.relationPanel1.Name = "relationPanel1";
            this.relationPanel1.relation = "and";
            this.relationPanel1.Size = new System.Drawing.Size(338, 35);
            this.relationPanel1.TabIndex = 10;
            // 
            // FormRangeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(364, 117);
            this.Controls.Add(this.relationPanel2);
            this.Controls.Add(this.relationPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FormRangeSetting";
            this.Text = "取值范围";
            this.Load += new System.EventHandler(this.FormRangeSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private RelationPanel relationPanel2;
        private RelationPanel relationPanel1;
    }
}