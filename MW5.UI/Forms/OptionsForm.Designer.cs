using MW5.UI.Controls;

namespace MW5.UI.Forms
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.lblText = new System.Windows.Forms.Label();
            this.lblColorText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkDontShow = new System.Windows.Forms.CheckBox();
            this.colorPicker = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.SuspendLayout();
            // 
            // lblText
            // 
            resources.ApplyResources(this.lblText, "lblText");
            this.lblText.Name = "lblText";
            // 
            // lblColorText
            // 
            resources.ApplyResources(this.lblColorText, "lblColorText");
            this.lblColorText.Name = "lblColorText";
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
            // chkDontShow
            // 
            resources.ApplyResources(this.chkDontShow, "chkDontShow");
            this.chkDontShow.Name = "chkDontShow";
            this.chkDontShow.UseVisualStyleBackColor = true;
            // 
            // colorPicker
            // 
            resources.ApplyResources(this.colorPicker, "colorPicker");
            this.colorPicker.Color = System.Drawing.Color.Yellow;
            this.colorPicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorPicker.DropDownHeight = 1;
            this.colorPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPicker.FormattingEnabled = true;
            this.colorPicker.Items.AddRange(new object[] {
            resources.GetString("colorPicker.Items")});
            this.colorPicker.Name = "colorPicker";
            // 
            // OptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.CaptionFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.lblColorText);
            this.Controls.Add(this.chkDontShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblColorText;
        protected System.Windows.Forms.Label lblText;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.CheckBox chkDontShow;
        protected Office2007ColorPicker colorPicker;

    }
}