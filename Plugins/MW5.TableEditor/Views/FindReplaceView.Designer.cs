namespace MW5.Plugins.TableEditor.Views
{
    partial class FindReplaceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindReplaceView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMatch = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.btnFind = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.cboFind = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboReplace = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnReplace = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnReplaceAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFields = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cboMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboReplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFields)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // cboMatch
            // 
            resources.ApplyResources(this.cboMatch, "cboMatch");
            this.cboMatch.BeforeTouchSize = new System.Drawing.Size(122, 21);
            this.cboMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatch.Name = "cboMatch";
            // 
            // chkCaseSensitive
            // 
            resources.ApplyResources(this.chkCaseSensitive, "chkCaseSensitive");
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            resources.ApplyResources(this.btnFind, "btnFind");
            this.btnFind.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnFind.Name = "btnFind";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            // 
            // lblReplaceWith
            // 
            resources.ApplyResources(this.lblReplaceWith, "lblReplaceWith");
            this.lblReplaceWith.Name = "lblReplaceWith";
            // 
            // cboFind
            // 
            resources.ApplyResources(this.cboFind, "cboFind");
            this.cboFind.BeforeTouchSize = new System.Drawing.Size(226, 21);
            this.cboFind.Name = "cboFind";
            // 
            // cboReplace
            // 
            resources.ApplyResources(this.cboReplace, "cboReplace");
            this.cboReplace.BeforeTouchSize = new System.Drawing.Size(226, 21);
            this.cboReplace.Name = "cboReplace";
            // 
            // btnReplace
            // 
            resources.ApplyResources(this.btnReplace, "btnReplace");
            this.btnReplace.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnReplace.Name = "btnReplace";
            // 
            // btnReplaceAll
            // 
            resources.ApplyResources(this.btnReplaceAll, "btnReplaceAll");
            this.btnReplaceAll.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnReplaceAll.Name = "btnReplaceAll";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cboFields
            // 
            resources.ApplyResources(this.cboFields, "cboFields");
            this.cboFields.BeforeTouchSize = new System.Drawing.Size(122, 21);
            this.cboFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFields.Name = "cboFields";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.cboFields);
            this.panel1.Controls.Add(this.chkCaseSensitive);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboMatch);
            this.panel1.Name = "panel1";
            // 
            // FindReplaceView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.cboFind);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboReplace);
            this.Controls.Add(this.lblReplaceWith);
            this.Name = "FindReplaceView";
            ((System.ComponentModel.ISupportInitialize)(this.cboMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboReplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFields)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMatch;
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private Syncfusion.Windows.Forms.ButtonAdv btnFind;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private System.Windows.Forms.Label lblReplaceWith;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboFind;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboReplace;
        private Syncfusion.Windows.Forms.ButtonAdv btnReplace;
        private Syncfusion.Windows.Forms.ButtonAdv btnReplaceAll;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboFields;
        private System.Windows.Forms.Panel panel1;
    }
}