namespace MW5.UI.Controls
{
    partial class NetColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetColorPicker));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.watermarkTextbox1 = new MW5.UI.Controls.WatermarkTextbox();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkTextbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // watermarkTextbox1
            // 
            resources.ApplyResources(this.watermarkTextbox1, "watermarkTextbox1");
            this.watermarkTextbox1.BeforeTouchSize = new System.Drawing.Size(258, 21);
            this.watermarkTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.watermarkTextbox1.FarImage = ((System.Drawing.Image)(resources.GetObject("watermarkTextbox1.FarImage")));
            this.watermarkTextbox1.Name = "watermarkTextbox1";
            this.watermarkTextbox1.ShowClearButton = true;
            this.watermarkTextbox1.ThemeName = "Default";
            // 
            // colorUIControl1
            // 
            resources.ApplyResources(this.colorUIControl1, "colorUIControl1");
            this.colorUIControl1.BeforeTouchSize = new System.Drawing.Size(258, 262);
            this.colorUIControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorUIControl1.Name = "colorUIControl1";
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.colorUIControl1.ScrollMetroColorTable = metroColorTable1;
            // 
            // NetColorPicker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorUIControl1);
            this.Controls.Add(this.watermarkTextbox1);
            this.Name = "NetColorPicker";
            ((System.ComponentModel.ISupportInitialize)(this.watermarkTextbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WatermarkTextbox watermarkTextbox1;
        private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
    }
}
