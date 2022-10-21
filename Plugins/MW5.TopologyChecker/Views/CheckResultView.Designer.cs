using MW5.UI.Controls;

namespace MW5.Plugins.TopologyChecker.Views
{
    partial class CheckResultView
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckResultView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.boxRules = new System.Windows.Forms.ToolStripComboBox();
            this.boxRepairMethods = new System.Windows.Forms.ToolStripComboBox();
            this.btnAutoRepairTopologyError = new System.Windows.Forms.ToolStripButton();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grid = new MW5.Plugins.TopologyChecker.Controls.CheckAttributesDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.toolStripEx1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(759, 28);
            this.gradientPanel1.TabIndex = 1;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxRules,
            this.boxRepairMethods,
            this.btnAutoRepairTopologyError});
            this.toolStripEx1.Location = new System.Drawing.Point(1, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ShowItemToolTips = true;
            this.toolStripEx1.Size = new System.Drawing.Size(309, 25);
            this.toolStripEx1.TabIndex = 44;
            this.toolStripEx1.Text = "toolStripEx1";
            this.toolStripEx1.ThemeName = "Metro";
            this.toolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // boxRules
            // 
            this.boxRules.Name = "boxRules";
            this.boxRules.Size = new System.Drawing.Size(121, 25);
            // 
            // boxRepairMethods
            // 
            this.boxRepairMethods.Name = "boxRepairMethods";
            this.boxRepairMethods.Size = new System.Drawing.Size(121, 25);
            // 
            // btnAutoRepairTopologyError
            // 
            this.btnAutoRepairTopologyError.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAutoRepairTopologyError.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoRepairTopologyError.Image")));
            this.btnAutoRepairTopologyError.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutoRepairTopologyError.Name = "btnAutoRepairTopologyError";
            this.btnAutoRepairTopologyError.Size = new System.Drawing.Size(60, 22);
            this.btnAutoRepairTopologyError.Text = "自动修复";
            this.btnAutoRepairTopologyError.Click += new System.EventHandler(this.btnAutoRepairTopologyError_Click);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.ID = "xcvxcv";
            this.barItem1.ImageIndex = 4;
            this.barItem1.ImageList = this.imageList1;
            this.barItem1.ImageSize = new System.Drawing.Size(20, 20);
            this.barItem1.Padding = new System.Drawing.Point(5, 0);
            this.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "清除日志";
            this.barItem1.TextAlignment = Syncfusion.Windows.Forms.Tools.XPMenus.TextAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_info.png");
            this.imageList1.Images.SetKeyName(1, "img_debug.png");
            this.imageList1.Images.SetKeyName(2, "img_warning.png");
            this.imageList1.Images.SetKeyName(3, "img_error.png");
            this.imageList1.Images.SetKeyName(4, "img_clear.png");
            // 
            // grid
            // 
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 28);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(759, 60);
            this.grid.TabIndex = 45;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CheckResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "CheckResultView";
            this.Size = new System.Drawing.Size(759, 88);
            this.Load += new System.EventHandler(this.CheckResultView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ImageList imageList1;
        private Controls.CheckAttributesDataGridView grid;
        private System.Windows.Forms.ToolStripComboBox boxRules;
        private System.Windows.Forms.ToolStripButton btnAutoRepairTopologyError;
        private System.Windows.Forms.ToolStripComboBox boxRepairMethods;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
