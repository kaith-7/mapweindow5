using System.Windows.Forms;

namespace MW5.Plugins.Symbology.Views
{
    partial class RasterColorSchemeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasterColorSchemeView));
            this.rasterColorSchemeGrid1 = new MW5.Plugins.Symbology.Controls.RasterColorSchemeGrid();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAddInterval = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRemoveInterval = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClear = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkGradientWithinCategory = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rasterColorSchemeGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // rasterColorSchemeGrid1
            // 
            resources.ApplyResources(this.rasterColorSchemeGrid1, "rasterColorSchemeGrid1");
            this.rasterColorSchemeGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rasterColorSchemeGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.rasterColorSchemeGrid1.Extended = false;
            this.rasterColorSchemeGrid1.GridLineColor = System.Drawing.Color.White;
            this.rasterColorSchemeGrid1.Name = "rasterColorSchemeGrid1";
            this.rasterColorSchemeGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.rasterColorSchemeGrid1.ShowGradient = true;
            this.rasterColorSchemeGrid1.ShowRowHeaders = false;
            this.rasterColorSchemeGrid1.TableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Visible"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("LowColor"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("HighColor"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Range")});
            this.rasterColorSchemeGrid1.UseRightToLeftCompatibleTextBox = true;
            this.rasterColorSchemeGrid1.WrapWithPanel = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ThemeName = "Metro";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Office2000";
            this.btnOk.UseVisualStyle = false;
            // 
            // btnAddInterval
            // 
            resources.ApplyResources(this.btnAddInterval, "btnAddInterval");
            this.btnAddInterval.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnAddInterval.Name = "btnAddInterval";
            // 
            // btnRemoveInterval
            // 
            resources.ApplyResources(this.btnRemoveInterval, "btnRemoveInterval");
            this.btnRemoveInterval.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnRemoveInterval.Name = "btnRemoveInterval";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnClear.Name = "btnClear";
            // 
            // chkGradientWithinCategory
            // 
            resources.ApplyResources(this.chkGradientWithinCategory, "chkGradientWithinCategory");
            this.chkGradientWithinCategory.Name = "chkGradientWithinCategory";
            this.chkGradientWithinCategory.CheckStateChanged += new System.EventHandler(this.chkGradientWithinCategory_CheckStateChanged);
            // 
            // RasterColorSchemeView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.chkGradientWithinCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveInterval);
            this.Controls.Add(this.btnAddInterval);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rasterColorSchemeGrid1);
            this.Name = "RasterColorSchemeView";
            ((System.ComponentModel.ISupportInitialize)(this.rasterColorSchemeGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RasterColorSchemeGrid rasterColorSchemeGrid1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.ButtonAdv btnAddInterval;
        private Syncfusion.Windows.Forms.ButtonAdv btnRemoveInterval;
        private Syncfusion.Windows.Forms.ButtonAdv btnClear;
        private CheckBox chkGradientWithinCategory;
    }
}