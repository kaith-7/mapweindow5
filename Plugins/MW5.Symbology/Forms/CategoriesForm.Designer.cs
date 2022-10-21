using MW5.Plugins.Symbology.Controls;
using MW5.UI.Controls;
using MW5.UI.Enums;

namespace MW5.Plugins.Symbology.Forms
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.cmnVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmnStyle = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCategoryStyle = new System.Windows.Forms.Button();
            this.btnCategoryRemove = new System.Windows.Forms.Button();
            this.btnEditExpression = new System.Windows.Forms.Button();
            this.btnCategoryMoveDown = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCategoryMoveUp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolAddRange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSaveCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRemoveStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategories
            // 
            resources.ApplyResources(this.dgvCategories, "dgvCategories");
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnVisible,
            this.cmnStyle,
            this.cmnName,
            this.cmnExpression,
            this.Count});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCategories.ShowCellErrors = false;
            this.toolTip1.SetToolTip(this.dgvCategories, resources.GetString("dgvCategories.ToolTip"));
            this.dgvCategories.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCategories_CellBeginEdit);
            this.dgvCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridCellDoubleClick);
            this.dgvCategories.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellEndEdit);
            this.dgvCategories.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCategories_CellFormatting);
            this.dgvCategories.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvLabelCategories_CellPainting);
            this.dgvCategories.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellValueChanged);
            this.dgvCategories.CurrentCellChanged += new System.EventHandler(this.dgvCategories_CurrentCellChanged);
            this.dgvCategories.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCategories_CurrentCellDirtyStateChanged);
            // 
            // cmnVisible
            // 
            resources.ApplyResources(this.cmnVisible, "cmnVisible");
            this.cmnVisible.Name = "cmnVisible";
            this.cmnVisible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmnStyle
            // 
            resources.ApplyResources(this.cmnStyle, "cmnStyle");
            this.cmnStyle.Name = "cmnStyle";
            this.cmnStyle.ReadOnly = true;
            this.cmnStyle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmnName
            // 
            resources.ApplyResources(this.cmnName, "cmnName");
            this.cmnName.Name = "cmnName";
            this.cmnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnExpression
            // 
            resources.ApplyResources(this.cmnExpression, "cmnExpression");
            this.cmnExpression.Name = "cmnExpression";
            this.cmnExpression.ReadOnly = true;
            // 
            // Count
            // 
            resources.ApplyResources(this.Count, "Count");
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.toolTip1.SetToolTip(this.btnOk, resources.GetString("btnOk.ToolTip"));
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.OnOkButtonClicked);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.toolTip1.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancelButtonClicked);
            // 
            // btnCategoryStyle
            // 
            resources.ApplyResources(this.btnCategoryStyle, "btnCategoryStyle");
            this.btnCategoryStyle.Name = "btnCategoryStyle";
            this.toolTip1.SetToolTip(this.btnCategoryStyle, resources.GetString("btnCategoryStyle.ToolTip"));
            this.btnCategoryStyle.UseVisualStyleBackColor = true;
            this.btnCategoryStyle.Click += new System.EventHandler(this.btnCategoryStyle_Click);
            // 
            // btnCategoryRemove
            // 
            resources.ApplyResources(this.btnCategoryRemove, "btnCategoryRemove");
            this.btnCategoryRemove.Name = "btnCategoryRemove";
            this.toolTip1.SetToolTip(this.btnCategoryRemove, resources.GetString("btnCategoryRemove.ToolTip"));
            this.btnCategoryRemove.UseVisualStyleBackColor = true;
            this.btnCategoryRemove.Click += new System.EventHandler(this.btnCategoriesRemove_Click);
            // 
            // btnEditExpression
            // 
            resources.ApplyResources(this.btnEditExpression, "btnEditExpression");
            this.btnEditExpression.Name = "btnEditExpression";
            this.toolTip1.SetToolTip(this.btnEditExpression, resources.GetString("btnEditExpression.ToolTip"));
            this.btnEditExpression.UseVisualStyleBackColor = true;
            this.btnEditExpression.Click += new System.EventHandler(this.btnEditExpression_Click);
            // 
            // btnCategoryMoveDown
            // 
            resources.ApplyResources(this.btnCategoryMoveDown, "btnCategoryMoveDown");
            this.btnCategoryMoveDown.Name = "btnCategoryMoveDown";
            this.toolTip1.SetToolTip(this.btnCategoryMoveDown, resources.GetString("btnCategoryMoveDown.ToolTip"));
            this.btnCategoryMoveDown.UseVisualStyleBackColor = true;
            this.btnCategoryMoveDown.Click += new System.EventHandler(this.btnCategoryMoveDown_Click);
            // 
            // btnGenerate
            // 
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.Name = "btnGenerate";
            this.toolTip1.SetToolTip(this.btnGenerate, resources.GetString("btnGenerate.ToolTip"));
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCategoryMoveUp
            // 
            resources.ApplyResources(this.btnCategoryMoveUp, "btnCategoryMoveUp");
            this.btnCategoryMoveUp.Name = "btnCategoryMoveUp";
            this.toolTip1.SetToolTip(this.btnCategoryMoveUp, resources.GetString("btnCategoryMoveUp.ToolTip"));
            this.btnCategoryMoveUp.UseVisualStyleBackColor = true;
            this.btnCategoryMoveUp.Click += new System.EventHandler(this.btnCategoryMoveUp_Click);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.toolTip1.SetToolTip(this.btnApply, resources.GetString("btnApply.ToolTip"));
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnApplyButtonClicked);
            // 
            // toolStripEx1
            // 
            resources.ApplyResources(this.toolStripEx1, "toolStripEx1");
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStyle});
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ThemeName = "Metro";
            this.toolTip1.SetToolTip(this.toolStripEx1, resources.GetString("toolStripEx1.ToolTip"));
            this.toolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // toolStyle
            // 
            resources.ApplyResources(this.toolStyle, "toolStyle");
            this.toolStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddRange,
            this.toolStripSeparator5,
            this.toolSaveCategories,
            this.toolRemoveStyle});
            this.toolStyle.ForeColor = System.Drawing.Color.Black;
            this.toolStyle.Image = global::MW5.Plugins.Symbology.Properties.Resources.icon_settings;
            this.toolStyle.Name = "toolStyle";
            // 
            // toolAddRange
            // 
            resources.ApplyResources(this.toolAddRange, "toolAddRange");
            this.toolAddRange.Name = "toolAddRange";
            this.toolAddRange.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // toolSaveCategories
            // 
            resources.ApplyResources(this.toolSaveCategories, "toolSaveCategories");
            this.toolSaveCategories.Image = global::MW5.Plugins.Symbology.Properties.Resources.icon_save1;
            this.toolSaveCategories.Name = "toolSaveCategories";
            this.toolSaveCategories.Click += new System.EventHandler(this.toolSaveCategories_Click);
            // 
            // toolRemoveStyle
            // 
            resources.ApplyResources(this.toolRemoveStyle, "toolRemoveStyle");
            this.toolRemoveStyle.Image = global::MW5.Plugins.Symbology.Properties.Resources.img_folder_open;
            this.toolRemoveStyle.Name = "toolRemoveStyle";
            this.toolRemoveStyle.Click += new System.EventHandler(this.toolRemoveStyle_Click);
            // 
            // lblEmpty
            // 
            resources.ApplyResources(this.lblEmpty, "lblEmpty");
            this.lblEmpty.Name = "lblEmpty";
            this.toolTip1.SetToolTip(this.lblEmpty, resources.GetString("lblEmpty.ToolTip"));
            // 
            // gradientPanel1
            // 
            resources.ApplyResources(this.gradientPanel1, "gradientPanel1");
            this.gradientPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.lblEmpty);
            this.gradientPanel1.Controls.Add(this.dgvCategories);
            this.gradientPanel1.Name = "gradientPanel1";
            this.toolTip1.SetToolTip(this.gradientPanel1, resources.GetString("gradientPanel1.ToolTip"));
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.toolTip1.SetToolTip(this.btnClear, resources.GetString("btnClear.ToolTip"));
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.OnCategoriesClearClick);
            // 
            // CategoriesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.toolStripEx1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCategoryStyle);
            this.Controls.Add(this.btnCategoryRemove);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEditExpression);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCategoryMoveDown);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCategoryMoveUp);
            this.Name = "CategoriesForm";
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnCategoriesFormClosing);
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCategoryRemove;
        private System.Windows.Forms.Button btnCategoryMoveDown;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCategoryMoveUp;
        private System.Windows.Forms.Button btnEditExpression;
        private System.Windows.Forms.Button btnCategoryStyle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmnVisible;
        private System.Windows.Forms.DataGridViewImageColumn cmnStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnExpression;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripDropDownButton toolStyle;
        private System.Windows.Forms.ToolStripMenuItem toolSaveCategories;
        private System.Windows.Forms.ToolStripMenuItem toolRemoveStyle;
        private System.Windows.Forms.ToolStripMenuItem toolAddRange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lblEmpty;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnClear;
    }
}