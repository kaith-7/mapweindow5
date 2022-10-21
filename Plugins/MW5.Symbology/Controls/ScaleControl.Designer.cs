namespace MW5.Plugins.Symbology.Controls
{
    partial class ScaleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleControl));
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.btnSetMin = new System.Windows.Forms.Button();
            this.btnSetMax = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMaxScale = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMinScale = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnabled
            // 
            resources.ApplyResources(this.chkEnabled, "chkEnabled");
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // btnSetMin
            // 
            resources.ApplyResources(this.btnSetMin, "btnSetMin");
            this.btnSetMin.Name = "btnSetMin";
            this.btnSetMin.UseVisualStyleBackColor = true;
            this.btnSetMin.Click += new System.EventHandler(this.btnSetMin_Click);
            // 
            // btnSetMax
            // 
            resources.ApplyResources(this.btnSetMax, "btnSetMax");
            this.btnSetMax.Name = "btnSetMax";
            this.btnSetMax.UseVisualStyleBackColor = true;
            this.btnSetMax.Click += new System.EventHandler(this.btnSetMax_Click);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // txtMaxScale
            // 
            resources.ApplyResources(this.txtMaxScale, "txtMaxScale");
            this.txtMaxScale.Name = "txtMaxScale";
            this.txtMaxScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxScale_KeyPress);
            this.txtMaxScale.Validated += new System.EventHandler(this.txtMaxScale_Validated);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // txtMinScale
            // 
            resources.ApplyResources(this.txtMinScale, "txtMinScale");
            this.txtMinScale.Name = "txtMinScale";
            this.txtMinScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinScale_KeyPress);
            this.txtMinScale.Validated += new System.EventHandler(this.txtMinScale_Validated);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnSetMin);
            this.panel1.Controls.Add(this.txtMinScale);
            this.panel1.Controls.Add(this.btnSetMax);
            this.panel1.Controls.Add(this.txtMaxScale);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Name = "panel1";
            // 
            // ScaleControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkEnabled);
            this.DoubleBuffered = true;
            this.Name = "ScaleControl";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.Button btnSetMin;
        private System.Windows.Forms.Button btnSetMax;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMaxScale;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMinScale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;

    }
}
