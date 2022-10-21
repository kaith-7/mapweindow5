namespace MW5.Plugins.Symbology.Controls
{
    partial class PointIconControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointIconControl));
            this.iconControl1 = new MW5.Plugins.Symbology.Controls.ListControls.IconControl();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.chkScaleIcons = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIconCollection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // iconControl1
            // 
            resources.ApplyResources(this.iconControl1, "iconControl1");
            this.iconControl1.BackColor = System.Drawing.Color.Transparent;
            this.iconControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconControl1.CellHeight = 24;
            this.iconControl1.CellWidth = 24;
            this.iconControl1.FilePath = "";
            this.iconControl1.GridColor = System.Drawing.Color.Black;
            this.iconControl1.GridVisible = true;
            this.iconControl1.ItemCount = 0;
            this.iconControl1.Name = "iconControl1";
            this.iconControl1.SelectedIndex = -1;
            this.iconControl1.SelectedPath = "";
            this.iconControl1.Textures = false;
            // 
            // lblCopyright
            // 
            resources.ApplyResources(this.lblCopyright, "lblCopyright");
            this.lblCopyright.Name = "lblCopyright";
            // 
            // chkScaleIcons
            // 
            resources.ApplyResources(this.chkScaleIcons, "chkScaleIcons");
            this.chkScaleIcons.Name = "chkScaleIcons";
            this.chkScaleIcons.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboIconCollection
            // 
            resources.ApplyResources(this.cboIconCollection, "cboIconCollection");
            this.cboIconCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIconCollection.FormattingEnabled = true;
            this.cboIconCollection.Name = "cboIconCollection";
            // 
            // PointIconControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconControl1);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.chkScaleIcons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboIconCollection);
            this.Name = "PointIconControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListControls.IconControl iconControl1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.CheckBox chkScaleIcons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIconCollection;
    }
}
