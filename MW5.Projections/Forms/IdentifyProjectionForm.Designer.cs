using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Projections.Forms
{
    partial class IdentifyProjectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyProjectionForm));
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLayer = new System.Windows.Forms.ComboBox();
            this.chkBreak = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblStandard = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBreak)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(290, 21);
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Name = "textBox1";
            this.textBox1.ThemeName = "Default";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BeforeTouchSize = new System.Drawing.Size(101, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(101, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cboLayer
            // 
            resources.ApplyResources(this.cboLayer, "cboLayer");
            this.cboLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.SelectedIndexChanged += new System.EventHandler(this.cboLayer_SelectedIndexChanged);
            // 
            // chkBreak
            // 
            resources.ApplyResources(this.chkBreak, "chkBreak");
            this.chkBreak.BeforeTouchSize = new System.Drawing.Size(154, 18);
            this.chkBreak.Name = "chkBreak";
            // 
            // lblStandard
            // 
            resources.ApplyResources(this.lblStandard, "lblStandard");
            this.lblStandard.Name = "lblStandard";
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // IdentifyProjectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.chkBreak);
            this.Controls.Add(this.cboLayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IdentifyProjectionForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.IdentifyProjectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBreak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ButtonAdv btnStart;
        private ButtonAdv btnCancel;
        public TextBoxExt textBox1;
        private System.Windows.Forms.Label label3;
        private ComboBox cboLayer;
        private CheckBoxAdv chkBreak;
        private System.Windows.Forms.Label lblStandard;
        private ListBox listBox1;
    }
}