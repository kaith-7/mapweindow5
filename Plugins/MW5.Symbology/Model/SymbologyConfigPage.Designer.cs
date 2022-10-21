using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.Symbology.Model
{
    partial class SymbologyConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymbologyConfigPage));
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChartsScheme = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRasterScheme = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnVectorScheme = new Syncfusion.Windows.Forms.ButtonAdv();
            this.icbCharts = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.label3 = new System.Windows.Forms.Label();
            this.icbRaster = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.label2 = new System.Windows.Forms.Label();
            this.icbVector = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOpenTextures = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOpenIcons = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTexurePath = new System.Windows.Forms.TextBox();
            this.txtIconPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // configPanelControl1
            // 
            resources.ApplyResources(this.configPanelControl1, "configPanelControl1");
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.label6);
            this.configPanelControl1.Controls.Add(this.btnChartsScheme);
            this.configPanelControl1.Controls.Add(this.btnRasterScheme);
            this.configPanelControl1.Controls.Add(this.btnVectorScheme);
            this.configPanelControl1.Controls.Add(this.icbCharts);
            this.configPanelControl1.Controls.Add(this.label3);
            this.configPanelControl1.Controls.Add(this.icbRaster);
            this.configPanelControl1.Controls.Add(this.label2);
            this.configPanelControl1.Controls.Add(this.icbVector);
            this.configPanelControl1.Controls.Add(this.label1);
            this.configPanelControl1.HeaderText = "配色方案";
            this.configPanelControl1.Name = "configPanelControl1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnChartsScheme
            // 
            resources.ApplyResources(this.btnChartsScheme, "btnChartsScheme");
            this.btnChartsScheme.BeforeTouchSize = new System.Drawing.Size(28, 21);
            this.btnChartsScheme.Name = "btnChartsScheme";
            this.btnChartsScheme.Click += new System.EventHandler(this.OnChartsSchemeClick);
            // 
            // btnRasterScheme
            // 
            resources.ApplyResources(this.btnRasterScheme, "btnRasterScheme");
            this.btnRasterScheme.BeforeTouchSize = new System.Drawing.Size(28, 21);
            this.btnRasterScheme.Name = "btnRasterScheme";
            this.btnRasterScheme.Click += new System.EventHandler(this.OnRasterSchemeClick);
            // 
            // btnVectorScheme
            // 
            resources.ApplyResources(this.btnVectorScheme, "btnVectorScheme");
            this.btnVectorScheme.BeforeTouchSize = new System.Drawing.Size(28, 21);
            this.btnVectorScheme.Name = "btnVectorScheme";
            this.btnVectorScheme.Click += new System.EventHandler(this.OnVectorSchemeClick);
            // 
            // icbCharts
            // 
            resources.ApplyResources(this.icbCharts, "icbCharts");
            this.icbCharts.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbCharts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbCharts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbCharts.FormattingEnabled = true;
            this.icbCharts.Name = "icbCharts";
            this.icbCharts.OutlineColor = System.Drawing.Color.Black;
            this.icbCharts.Target = MW5.Plugins.Symbology.SchemeTarget.Charts;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // icbRaster
            // 
            resources.ApplyResources(this.icbRaster, "icbRaster");
            this.icbRaster.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbRaster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbRaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbRaster.FormattingEnabled = true;
            this.icbRaster.Name = "icbRaster";
            this.icbRaster.OutlineColor = System.Drawing.Color.Black;
            this.icbRaster.Target = MW5.Plugins.Symbology.SchemeTarget.Raster;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // icbVector
            // 
            resources.ApplyResources(this.icbVector, "icbVector");
            this.icbVector.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbVector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbVector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbVector.FormattingEnabled = true;
            this.icbVector.Name = "icbVector";
            this.icbVector.OutlineColor = System.Drawing.Color.Black;
            this.icbVector.Target = MW5.Plugins.Symbology.SchemeTarget.Vector;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.label7);
            this.configPanelControl2.Controls.Add(this.btnOpenTextures);
            this.configPanelControl2.Controls.Add(this.btnOpenIcons);
            this.configPanelControl2.Controls.Add(this.label5);
            this.configPanelControl2.Controls.Add(this.txtTexurePath);
            this.configPanelControl2.Controls.Add(this.txtIconPath);
            this.configPanelControl2.Controls.Add(this.label4);
            this.configPanelControl2.HeaderText = "图标和纹理";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnOpenTextures
            // 
            resources.ApplyResources(this.btnOpenTextures, "btnOpenTextures");
            this.btnOpenTextures.BeforeTouchSize = new System.Drawing.Size(49, 21);
            this.btnOpenTextures.Name = "btnOpenTextures";
            this.btnOpenTextures.Click += new System.EventHandler(this.OnOpenTexturesClick);
            // 
            // btnOpenIcons
            // 
            resources.ApplyResources(this.btnOpenIcons, "btnOpenIcons");
            this.btnOpenIcons.BeforeTouchSize = new System.Drawing.Size(49, 21);
            this.btnOpenIcons.Name = "btnOpenIcons";
            this.btnOpenIcons.Click += new System.EventHandler(this.OnOpenIconsClick);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtTexurePath
            // 
            resources.ApplyResources(this.txtTexurePath, "txtTexurePath");
            this.txtTexurePath.Name = "txtTexurePath";
            this.txtTexurePath.ReadOnly = true;
            // 
            // txtIconPath
            // 
            resources.ApplyResources(this.txtIconPath, "txtIconPath");
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // SymbologyConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.configPanelControl2);
            this.Controls.Add(this.configPanelControl1);
            this.Name = "SymbologyConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            this.configPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            this.configPanelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ConfigPanelControl configPanelControl1;
        private Syncfusion.Windows.Forms.ButtonAdv btnChartsScheme;
        private Syncfusion.Windows.Forms.ButtonAdv btnRasterScheme;
        private Syncfusion.Windows.Forms.ButtonAdv btnVectorScheme;
        private Controls.ImageCombo.ColorSchemeCombo icbCharts;
        private System.Windows.Forms.Label label3;
        private Controls.ImageCombo.ColorSchemeCombo icbRaster;
        private System.Windows.Forms.Label label2;
        private Controls.ImageCombo.ColorSchemeCombo icbVector;
        private System.Windows.Forms.Label label1;
        private UI.Controls.ConfigPanelControl configPanelControl2;
        private Syncfusion.Windows.Forms.ButtonAdv btnOpenIcons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTexurePath;
        private System.Windows.Forms.TextBox txtIconPath;
        private Syncfusion.Windows.Forms.ButtonAdv btnOpenTextures;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
