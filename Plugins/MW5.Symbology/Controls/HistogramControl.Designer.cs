namespace MW5.Plugins.Symbology.Controls
{
    partial class HistogramControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramControl));
            this.btnCalculateHistogram = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.cboBand = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btnDefault = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.cboBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateHistogram
            // 
            resources.ApplyResources(this.btnCalculateHistogram, "btnCalculateHistogram");
            this.btnCalculateHistogram.BeforeTouchSize = new System.Drawing.Size(71, 19);
            this.btnCalculateHistogram.Name = "btnCalculateHistogram";
            this.btnCalculateHistogram.Click += new System.EventHandler(this.btnCalculateHistogram_Click);
            // 
            // chartControl1
            // 
            resources.ApplyResources(this.chartControl1, "chartControl1");
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 10, 10, 0);
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.AccessibleDescription = resources.GetString("chartControl1.Legend.AccessibleDescription");
            this.chartControl1.Legend.AccessibleName = resources.GetString("chartControl1.Legend.AccessibleName");
            this.chartControl1.Legend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartControl1.Legend.BackgroundImage")));
            this.chartControl1.Legend.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("chartControl1.Legend.BackgroundImageLayout")));
            this.chartControl1.Legend.Font = ((System.Drawing.Font)(resources.GetObject("chartControl1.Legend.Font")));
            this.chartControl1.Legend.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartControl1.Legend.ImeMode")));
            this.chartControl1.Legend.Location = ((System.Drawing.Point)(resources.GetObject("chartControl1.Legend.Location")));
            this.chartControl1.Legend.MaximumSize = ((System.Drawing.Size)(resources.GetObject("chartControl1.Legend.MaximumSize")));
            this.chartControl1.Legend.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartControl1.Legend.RightToLeft")));
            this.chartControl1.Legend.Visible = ((bool)(resources.GetObject("chartControl1.Legend.Visible")));
            this.chartControl1.Localize = null;
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Title = "值";
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Title = "频次";
            this.chartControl1.Spacing = 80F;
            // 
            // 
            // 
            this.chartControl1.Title.AccessibleDescription = resources.GetString("chartControl1.Title.AccessibleDescription");
            this.chartControl1.Title.AccessibleName = resources.GetString("chartControl1.Title.AccessibleName");
            this.chartControl1.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartControl1.Title.Anchor")));
            this.chartControl1.Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartControl1.Title.BackgroundImage")));
            this.chartControl1.Title.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("chartControl1.Title.BackgroundImageLayout")));
            this.chartControl1.Title.Font = ((System.Drawing.Font)(resources.GetObject("chartControl1.Title.Font")));
            this.chartControl1.Title.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartControl1.Title.ImeMode")));
            this.chartControl1.Title.MaximumSize = ((System.Drawing.Size)(resources.GetObject("chartControl1.Title.MaximumSize")));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Title.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartControl1.Title.RightToLeft")));
            this.chartControl1.VisualTheme = "";
            // 
            // cboBand
            // 
            resources.ApplyResources(this.cboBand, "cboBand");
            this.cboBand.BeforeTouchSize = new System.Drawing.Size(144, 21);
            this.cboBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBand.Name = "cboBand";
            // 
            // gradientPanel1
            // 
            resources.ApplyResources(this.gradientPanel1, "gradientPanel1");
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.btnDefault);
            this.gradientPanel1.Controls.Add(this.btnCalculateHistogram);
            this.gradientPanel1.Controls.Add(this.cboBand);
            this.gradientPanel1.Name = "gradientPanel1";
            // 
            // btnDefault
            // 
            resources.ApplyResources(this.btnDefault, "btnDefault");
            this.btnDefault.BeforeTouchSize = new System.Drawing.Size(71, 19);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // HistogramControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "HistogramControl";
            ((System.ComponentModel.ISupportInitialize)(this.cboBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCalculateHistogram;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboBand;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnDefault;
    }
}
