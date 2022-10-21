namespace MW5.Plugins.Symbology.Controls
{
    partial class AttributesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributesControl));
            this.chkVisibility = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attributeGrid1 = new MW5.Plugins.Symbology.Controls.AttributeGrid();
            ((System.ComponentModel.ISupportInitialize)(this.attributeGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkVisibility
            // 
            resources.ApplyResources(this.chkVisibility, "chkVisibility");
            this.chkVisibility.Name = "chkVisibility";
            this.chkVisibility.UseVisualStyleBackColor = true;
            this.chkVisibility.CheckedChanged += new System.EventHandler(this.OnVisibilityCheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // attributeGrid1
            // 
            resources.ApplyResources(this.attributeGrid1, "attributeGrid1");
            this.attributeGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.attributeGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.attributeGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.attributeGrid1.GridLineColor = System.Drawing.Color.White;
            this.attributeGrid1.Name = "attributeGrid1";
            this.attributeGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.attributeGrid1.ShowRowHeaders = false;
            this.attributeGrid1.UseRightToLeftCompatibleTextBox = true;
            this.attributeGrid1.WrapWithPanel = true;
            // 
            // AttributesControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkVisibility);
            this.Controls.Add(this.attributeGrid1);
            this.Name = "AttributesControl";
            ((System.ComponentModel.ISupportInitialize)(this.attributeGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AttributeGrid attributeGrid1;
        private System.Windows.Forms.CheckBox chkVisibility;
        private System.Windows.Forms.Label label1;
    }
}
