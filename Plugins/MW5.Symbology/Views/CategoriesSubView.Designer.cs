namespace MW5.Plugins.Symbology.Views
{
    partial class CategoriesSubView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesSubView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new MW5.Plugins.Symbology.Controls.CategoriesGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmnStyle = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lstFields1 = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkRandomColors = new System.Windows.Forms.CheckBox();
            this.chkSetGradient = new System.Windows.Forms.CheckBox();
            this.icbCategories = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.btnChangeColorScheme = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCategoryClear = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupVariableSize = new System.Windows.Forms.GroupBox();
            this.udMaxSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udMinSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.chkUseVariableSize = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.udNumCategories = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.chkUniqueValues = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCategoryRemove = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCategoryAppearance = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCategoryGenerate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupVariableSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinSize)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            resources.ApplyResources(this.groupBox12, "groupBox12");
            this.groupBox12.Controls.Add(this.dgvCategories);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox12, resources.GetString("groupBox12.ToolTip"));
            // 
            // dgvCategories
            // 
            resources.ApplyResources(this.dgvCategories, "dgvCategories");
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cmnVisible,
            this.cmnStyle,
            this.cmnName,
            this.cmnExpression,
            this.cmnCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategories.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCategories.LockUpdate = false;
            this.dgvCategories.Name = "dgvCategories";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCategories.ShowCellErrors = false;
            this.toolTip1.SetToolTip(this.dgvCategories, resources.GetString("dgvCategories.ToolTip"));
            // 
            // ID
            // 
            this.ID.Frozen = true;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnVisible
            // 
            resources.ApplyResources(this.cmnVisible, "cmnVisible");
            this.cmnVisible.Name = "cmnVisible";
            // 
            // cmnStyle
            // 
            resources.ApplyResources(this.cmnStyle, "cmnStyle");
            this.cmnStyle.Name = "cmnStyle";
            this.cmnStyle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.cmnExpression.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnCount
            // 
            resources.ApplyResources(this.cmnCount, "cmnCount");
            this.cmnCount.Name = "cmnCount";
            this.cmnCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox11
            // 
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Controls.Add(this.lstFields1);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox11, resources.GetString("groupBox11.ToolTip"));
            // 
            // lstFields1
            // 
            resources.ApplyResources(this.lstFields1, "lstFields1");
            this.lstFields1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFields1.FormattingEnabled = true;
            this.lstFields1.Name = "lstFields1";
            this.toolTip1.SetToolTip(this.lstFields1, resources.GetString("lstFields1.ToolTip"));
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.chkRandomColors);
            this.groupBox6.Controls.Add(this.chkSetGradient);
            this.groupBox6.Controls.Add(this.icbCategories);
            this.groupBox6.Controls.Add(this.btnChangeColorScheme);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox6, resources.GetString("groupBox6.ToolTip"));
            // 
            // chkRandomColors
            // 
            resources.ApplyResources(this.chkRandomColors, "chkRandomColors");
            this.chkRandomColors.Name = "chkRandomColors";
            this.toolTip1.SetToolTip(this.chkRandomColors, resources.GetString("chkRandomColors.ToolTip"));
            this.chkRandomColors.UseVisualStyleBackColor = true;
            this.chkRandomColors.CheckedChanged += new System.EventHandler(this.OnRandomColorsChecked);
            // 
            // chkSetGradient
            // 
            resources.ApplyResources(this.chkSetGradient, "chkSetGradient");
            this.chkSetGradient.Checked = true;
            this.chkSetGradient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetGradient.Name = "chkSetGradient";
            this.toolTip1.SetToolTip(this.chkSetGradient, resources.GetString("chkSetGradient.ToolTip"));
            this.chkSetGradient.UseVisualStyleBackColor = true;
            // 
            // icbCategories
            // 
            resources.ApplyResources(this.icbCategories, "icbCategories");
            this.icbCategories.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbCategories.FormattingEnabled = true;
            this.icbCategories.Name = "icbCategories";
            this.icbCategories.OutlineColor = System.Drawing.Color.Black;
            this.icbCategories.Target = MW5.Plugins.Symbology.SchemeTarget.Vector;
            this.toolTip1.SetToolTip(this.icbCategories, resources.GetString("icbCategories.ToolTip"));
            // 
            // btnChangeColorScheme
            // 
            resources.ApplyResources(this.btnChangeColorScheme, "btnChangeColorScheme");
            this.btnChangeColorScheme.BeforeTouchSize = new System.Drawing.Size(28, 19);
            this.btnChangeColorScheme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnChangeColorScheme.Name = "btnChangeColorScheme";
            this.toolTip1.SetToolTip(this.btnChangeColorScheme, resources.GetString("btnChangeColorScheme.ToolTip"));
            this.btnChangeColorScheme.UseVisualStyleBackColor = true;
            // 
            // btnCategoryClear
            // 
            resources.ApplyResources(this.btnCategoryClear, "btnCategoryClear");
            this.btnCategoryClear.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnCategoryClear.Name = "btnCategoryClear";
            this.toolTip1.SetToolTip(this.btnCategoryClear, resources.GetString("btnCategoryClear.ToolTip"));
            this.btnCategoryClear.UseVisualStyleBackColor = true;
            // 
            // groupVariableSize
            // 
            resources.ApplyResources(this.groupVariableSize, "groupVariableSize");
            this.groupVariableSize.Controls.Add(this.udMaxSize);
            this.groupVariableSize.Controls.Add(this.udMinSize);
            this.groupVariableSize.Controls.Add(this.label5);
            this.groupVariableSize.Controls.Add(this.chkUseVariableSize);
            this.groupVariableSize.Name = "groupVariableSize";
            this.groupVariableSize.TabStop = false;
            this.toolTip1.SetToolTip(this.groupVariableSize, resources.GetString("groupVariableSize.ToolTip"));
            // 
            // udMaxSize
            // 
            resources.ApplyResources(this.udMaxSize, "udMaxSize");
            this.udMaxSize.Name = "udMaxSize";
            this.toolTip1.SetToolTip(this.udMaxSize, resources.GetString("udMaxSize.ToolTip"));
            // 
            // udMinSize
            // 
            resources.ApplyResources(this.udMinSize, "udMinSize");
            this.udMinSize.Name = "udMinSize";
            this.toolTip1.SetToolTip(this.udMinSize, resources.GetString("udMinSize.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // chkUseVariableSize
            // 
            resources.ApplyResources(this.chkUseVariableSize, "chkUseVariableSize");
            this.chkUseVariableSize.Name = "chkUseVariableSize";
            this.toolTip1.SetToolTip(this.chkUseVariableSize, resources.GetString("chkUseVariableSize.ToolTip"));
            this.chkUseVariableSize.UseVisualStyleBackColor = true;
            this.chkUseVariableSize.CheckedChanged += new System.EventHandler(this.OnUseVariableSizeChanged);
            // 
            // groupBox9
            // 
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Controls.Add(this.udNumCategories);
            this.groupBox9.Controls.Add(this.chkUniqueValues);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox9, resources.GetString("groupBox9.ToolTip"));
            // 
            // udNumCategories
            // 
            resources.ApplyResources(this.udNumCategories, "udNumCategories");
            this.udNumCategories.Name = "udNumCategories";
            this.toolTip1.SetToolTip(this.udNumCategories, resources.GetString("udNumCategories.ToolTip"));
            // 
            // chkUniqueValues
            // 
            resources.ApplyResources(this.chkUniqueValues, "chkUniqueValues");
            this.chkUniqueValues.Name = "chkUniqueValues";
            this.toolTip1.SetToolTip(this.chkUniqueValues, resources.GetString("chkUniqueValues.ToolTip"));
            this.chkUniqueValues.UseVisualStyleBackColor = true;
            this.chkUniqueValues.CheckedChanged += new System.EventHandler(this.OnUniqueValuesChecked);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.toolTip1.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
            // 
            // btnCategoryRemove
            // 
            resources.ApplyResources(this.btnCategoryRemove, "btnCategoryRemove");
            this.btnCategoryRemove.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnCategoryRemove.Name = "btnCategoryRemove";
            this.toolTip1.SetToolTip(this.btnCategoryRemove, resources.GetString("btnCategoryRemove.ToolTip"));
            this.btnCategoryRemove.UseVisualStyleBackColor = true;
            // 
            // btnCategoryAppearance
            // 
            resources.ApplyResources(this.btnCategoryAppearance, "btnCategoryAppearance");
            this.btnCategoryAppearance.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnCategoryAppearance.Name = "btnCategoryAppearance";
            this.toolTip1.SetToolTip(this.btnCategoryAppearance, resources.GetString("btnCategoryAppearance.ToolTip"));
            this.btnCategoryAppearance.UseVisualStyleBackColor = true;
            // 
            // btnCategoryGenerate
            // 
            resources.ApplyResources(this.btnCategoryGenerate, "btnCategoryGenerate");
            this.btnCategoryGenerate.BeforeTouchSize = new System.Drawing.Size(93, 24);
            this.btnCategoryGenerate.Name = "btnCategoryGenerate";
            this.toolTip1.SetToolTip(this.btnCategoryGenerate, resources.GetString("btnCategoryGenerate.ToolTip"));
            this.btnCategoryGenerate.UseVisualStyleBackColor = true;
            // 
            // CategoriesSubView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCategoryClear);
            this.Controls.Add(this.groupVariableSize);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnCategoryRemove);
            this.Controls.Add(this.btnCategoryAppearance);
            this.Controls.Add(this.btnCategoryGenerate);
            this.Name = "CategoriesSubView";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupVariableSize.ResumeLayout(false);
            this.groupVariableSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinSize)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private Controls.CategoriesGrid dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmnVisible;
        private System.Windows.Forms.DataGridViewImageColumn cmnStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnExpression;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCount;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox lstFields1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkRandomColors;
        private System.Windows.Forms.CheckBox chkSetGradient;
        private Controls.ImageCombo.ColorSchemeCombo icbCategories;
        private Syncfusion.Windows.Forms.ButtonAdv btnChangeColorScheme;
        private Syncfusion.Windows.Forms.ButtonAdv btnCategoryClear;
        private System.Windows.Forms.GroupBox groupVariableSize;
        private Controls.NumericUpDownEx udMaxSize;
        private Controls.NumericUpDownEx udMinSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUseVariableSize;
        private System.Windows.Forms.GroupBox groupBox9;
        private Controls.NumericUpDownEx udNumCategories;
        private System.Windows.Forms.CheckBox chkUniqueValues;
        private System.Windows.Forms.Label label19;
        private Syncfusion.Windows.Forms.ButtonAdv btnCategoryRemove;
        private Syncfusion.Windows.Forms.ButtonAdv btnCategoryAppearance;
        private Syncfusion.Windows.Forms.ButtonAdv btnCategoryGenerate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
