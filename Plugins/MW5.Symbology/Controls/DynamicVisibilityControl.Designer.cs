namespace MW5.Plugins.Symbology.Controls
{
    partial class DynamicVisibilityControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicVisibilityControl));
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.cboMaxZoom = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboMinZoom = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDynamicScaleMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnSetMaxScale = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboMaxScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnSetMinScale = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboMinScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkDynamicVisibility = new System.Windows.Forms.CheckBox();
            this.groupBox13.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDynamicScaleMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            resources.ApplyResources(this.groupBox13, "groupBox13");
            this.groupBox13.Controls.Add(this.panel1);
            this.groupBox13.Controls.Add(this.chkDynamicVisibility);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCurrent);
            this.panel1.Controls.Add(this.cboMaxZoom);
            this.panel1.Controls.Add(this.cboMinZoom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboDynamicScaleMode);
            this.panel1.Controls.Add(this.btnSetMaxScale);
            this.panel1.Controls.Add(this.cboMaxScale);
            this.panel1.Controls.Add(this.btnSetMinScale);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cboMinScale);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrent
            // 
            resources.ApplyResources(this.lblCurrent, "lblCurrent");
            this.lblCurrent.Name = "lblCurrent";
            // 
            // cboMaxZoom
            // 
            resources.ApplyResources(this.cboMaxZoom, "cboMaxZoom");
            this.cboMaxZoom.BeforeTouchSize = new System.Drawing.Size(80, 21);
            this.cboMaxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxZoom.Name = "cboMaxZoom";
            // 
            // cboMinZoom
            // 
            resources.ApplyResources(this.cboMinZoom, "cboMinZoom");
            this.cboMinZoom.BeforeTouchSize = new System.Drawing.Size(80, 21);
            this.cboMinZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinZoom.Name = "cboMinZoom";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cboDynamicScaleMode
            // 
            resources.ApplyResources(this.cboDynamicScaleMode, "cboDynamicScaleMode");
            this.cboDynamicScaleMode.BeforeTouchSize = new System.Drawing.Size(199, 21);
            this.cboDynamicScaleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDynamicScaleMode.Name = "cboDynamicScaleMode";
            this.cboDynamicScaleMode.SelectedIndexChanged += new System.EventHandler(this.cboDynamicScaleMode_SelectedIndexChanged);
            // 
            // btnSetMaxScale
            // 
            resources.ApplyResources(this.btnSetMaxScale, "btnSetMaxScale");
            this.btnSetMaxScale.BeforeTouchSize = new System.Drawing.Size(51, 22);
            this.btnSetMaxScale.Name = "btnSetMaxScale";
            this.btnSetMaxScale.UseVisualStyleBackColor = true;
            this.btnSetMaxScale.Click += new System.EventHandler(this.btnSetMaxScale_Click);
            // 
            // cboMaxScale
            // 
            resources.ApplyResources(this.cboMaxScale, "cboMaxScale");
            this.cboMaxScale.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.cboMaxScale.Name = "cboMaxScale";
            // 
            // btnSetMinScale
            // 
            resources.ApplyResources(this.btnSetMinScale, "btnSetMinScale");
            this.btnSetMinScale.BeforeTouchSize = new System.Drawing.Size(51, 22);
            this.btnSetMinScale.Name = "btnSetMinScale";
            this.btnSetMinScale.UseVisualStyleBackColor = true;
            this.btnSetMinScale.Click += new System.EventHandler(this.btnSetMinScale_Click);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // cboMinScale
            // 
            resources.ApplyResources(this.cboMinScale, "cboMinScale");
            this.cboMinScale.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.cboMinScale.Name = "cboMinScale";
            // 
            // chkDynamicVisibility
            // 
            resources.ApplyResources(this.chkDynamicVisibility, "chkDynamicVisibility");
            this.chkDynamicVisibility.Name = "chkDynamicVisibility";
            this.chkDynamicVisibility.UseVisualStyleBackColor = true;
            this.chkDynamicVisibility.CheckedChanged += new System.EventHandler(this.chkDynamicVisibility_CheckedChanged);
            // 
            // DynamicVisibilityControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox13);
            this.Name = "DynamicVisibilityControl";
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDynamicScaleMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboDynamicScaleMode;
        private Syncfusion.Windows.Forms.ButtonAdv btnSetMaxScale;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMaxScale;
        private Syncfusion.Windows.Forms.ButtonAdv btnSetMinScale;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMinScale;
        private System.Windows.Forms.CheckBox chkDynamicVisibility;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMaxZoom;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMinZoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrent;
    }
}
