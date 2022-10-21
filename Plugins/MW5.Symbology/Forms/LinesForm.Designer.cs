using MW5.Plugins.Symbology.Controls;
using MW5.Plugins.Symbology.Controls.ListControls;
using MW5.UI.Controls;
using MW5.UI.Enums;

namespace MW5.Plugins.Symbology.Forms
{
    partial class LinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctPreview = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLine = new System.Windows.Forms.TabPage();
            this.transparencyControl1 = new MW5.UI.Controls.TransparencyControl();
            this.groupLine = new System.Windows.Forms.GroupBox();
            this.icbLineWidth = new MW5.UI.Controls.ImageCombo();
            this.label21 = new System.Windows.Forms.Label();
            this.clpOutline = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.icbLineType = new MW5.UI.Controls.ImageCombo();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLineType = new System.Windows.Forms.ComboBox();
            this.tabVertices = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.udVerticesSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.chkVerticesFillVisible = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cboVerticesType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.clpVerticesColor = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.chkVerticesVisible = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemoveStyle = new System.Windows.Forms.Button();
            this.btnAddStyle = new System.Windows.Forms.Button();
            this.linePatternControl1 = new MW5.Plugins.Symbology.Controls.ListControls.LinePatternControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dynamicVisibilityControl1 = new MW5.Plugins.Symbology.Controls.DynamicVisibilityControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupMarker = new System.Windows.Forms.GroupBox();
            this.chkOffsetIsRelative = new System.Windows.Forms.CheckBox();
            this.chkIntervalIsRelative = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.udMarkerOffset = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.clpMarkerOutline = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.udMarkerSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.cboOrientation = new System.Windows.Forms.ComboBox();
            this.pointSymbolControl1 = new MW5.Plugins.Symbology.Controls.ListControls.SymbolControl();
            this.clpMarkerFill = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.udMarkerInterval = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.chkMarkerFlipFirst = new System.Windows.Forms.CheckBox();
            this.chkMarkerAllowOverflow = new System.Windows.Forms.CheckBox();
            this.ttOffsetIsRelative = new System.Windows.Forms.ToolTip(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLine.SuspendLayout();
            this.groupLine.SuspendLayout();
            this.tabVertices.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udVerticesSize)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupMarker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMarkerOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMarkerSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMarkerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.pctPreview);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.ttOffsetIsRelative.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // pctPreview
            // 
            resources.ApplyResources(this.pctPreview, "pctPreview");
            this.pctPreview.BackColor = System.Drawing.Color.Transparent;
            this.pctPreview.Name = "pctPreview";
            this.pctPreview.TabStop = false;
            this.ttOffsetIsRelative.SetToolTip(this.pctPreview, resources.GetString("pctPreview.ToolTip"));
            // 
            // dgv
            // 
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ttOffsetIsRelative.SetToolTip(this.dgv, resources.GetString("dgv.ToolTip"));
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.ttOffsetIsRelative.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabLine);
            this.tabControl1.Controls.Add(this.tabVertices);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.ttOffsetIsRelative.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabLine
            // 
            resources.ApplyResources(this.tabLine, "tabLine");
            this.tabLine.Controls.Add(this.transparencyControl1);
            this.tabLine.Controls.Add(this.groupLine);
            this.tabLine.Controls.Add(this.label5);
            this.tabLine.Controls.Add(this.cboLineType);
            this.tabLine.Name = "tabLine";
            this.ttOffsetIsRelative.SetToolTip(this.tabLine, resources.GetString("tabLine.ToolTip"));
            this.tabLine.UseVisualStyleBackColor = true;
            // 
            // transparencyControl1
            // 
            resources.ApplyResources(this.transparencyControl1, "transparencyControl1");
            this.transparencyControl1.BandColor = System.Drawing.Color.Empty;
            this.transparencyControl1.Name = "transparencyControl1";
            this.ttOffsetIsRelative.SetToolTip(this.transparencyControl1, resources.GetString("transparencyControl1.ToolTip"));
            this.transparencyControl1.Value = ((byte)(255));
            this.transparencyControl1.ValueChanged += new MW5.UI.Controls.TransparencyControl.ValueChangedDeleg(this.transparencyControl1_ValueChanged);
            // 
            // groupLine
            // 
            resources.ApplyResources(this.groupLine, "groupLine");
            this.groupLine.Controls.Add(this.icbLineWidth);
            this.groupLine.Controls.Add(this.label21);
            this.groupLine.Controls.Add(this.clpOutline);
            this.groupLine.Controls.Add(this.icbLineType);
            this.groupLine.Controls.Add(this.label22);
            this.groupLine.Controls.Add(this.label23);
            this.groupLine.Name = "groupLine";
            this.groupLine.TabStop = false;
            this.ttOffsetIsRelative.SetToolTip(this.groupLine, resources.GetString("groupLine.ToolTip"));
            // 
            // icbLineWidth
            // 
            resources.ApplyResources(this.icbLineWidth, "icbLineWidth");
            this.icbLineWidth.Color1 = System.Drawing.Color.Blue;
            this.icbLineWidth.Color2 = System.Drawing.Color.Honeydew;
            this.icbLineWidth.ComboStyle = MW5.UI.Enums.ImageComboStyle.Common;
            this.icbLineWidth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbLineWidth.FormattingEnabled = true;
            this.icbLineWidth.Name = "icbLineWidth";
            this.icbLineWidth.OutlineColor = System.Drawing.Color.Black;
            this.ttOffsetIsRelative.SetToolTip(this.icbLineWidth, resources.GetString("icbLineWidth.ToolTip"));
            this.icbLineWidth.SelectedIndexChanged += new System.EventHandler(this.Ui2Options);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            this.ttOffsetIsRelative.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
            // 
            // clpOutline
            // 
            resources.ApplyResources(this.clpOutline, "clpOutline");
            this.clpOutline.Color = System.Drawing.Color.Black;
            this.clpOutline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpOutline.DropDownHeight = 1;
            this.clpOutline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpOutline.FormattingEnabled = true;
            this.clpOutline.Items.AddRange(new object[] {
            resources.GetString("clpOutline.Items")});
            this.clpOutline.Name = "clpOutline";
            this.ttOffsetIsRelative.SetToolTip(this.clpOutline, resources.GetString("clpOutline.ToolTip"));
            this.clpOutline.SelectedColorChanged += new System.EventHandler(this.Ui2Options);
            // 
            // icbLineType
            // 
            resources.ApplyResources(this.icbLineType, "icbLineType");
            this.icbLineType.Color1 = System.Drawing.Color.Blue;
            this.icbLineType.Color2 = System.Drawing.Color.Honeydew;
            this.icbLineType.ComboStyle = MW5.UI.Enums.ImageComboStyle.Common;
            this.icbLineType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbLineType.FormattingEnabled = true;
            this.icbLineType.Name = "icbLineType";
            this.icbLineType.OutlineColor = System.Drawing.Color.Black;
            this.ttOffsetIsRelative.SetToolTip(this.icbLineType, resources.GetString("icbLineType.ToolTip"));
            this.icbLineType.SelectedIndexChanged += new System.EventHandler(this.Ui2Options);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            this.ttOffsetIsRelative.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            this.ttOffsetIsRelative.SetToolTip(this.label23, resources.GetString("label23.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.ttOffsetIsRelative.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // cboLineType
            // 
            resources.ApplyResources(this.cboLineType, "cboLineType");
            this.cboLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineType.FormattingEnabled = true;
            this.cboLineType.Name = "cboLineType";
            this.ttOffsetIsRelative.SetToolTip(this.cboLineType, resources.GetString("cboLineType.ToolTip"));
            // 
            // tabVertices
            // 
            resources.ApplyResources(this.tabVertices, "tabVertices");
            this.tabVertices.Controls.Add(this.groupBox3);
            this.tabVertices.Controls.Add(this.chkVerticesVisible);
            this.tabVertices.Name = "tabVertices";
            this.ttOffsetIsRelative.SetToolTip(this.tabVertices, resources.GetString("tabVertices.ToolTip"));
            this.tabVertices.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.udVerticesSize);
            this.groupBox3.Controls.Add(this.chkVerticesFillVisible);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.cboVerticesType);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.clpVerticesColor);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.ttOffsetIsRelative.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // udVerticesSize
            // 
            resources.ApplyResources(this.udVerticesSize, "udVerticesSize");
            this.udVerticesSize.Name = "udVerticesSize";
            this.ttOffsetIsRelative.SetToolTip(this.udVerticesSize, resources.GetString("udVerticesSize.ToolTip"));
            // 
            // chkVerticesFillVisible
            // 
            resources.ApplyResources(this.chkVerticesFillVisible, "chkVerticesFillVisible");
            this.chkVerticesFillVisible.Name = "chkVerticesFillVisible";
            this.ttOffsetIsRelative.SetToolTip(this.chkVerticesFillVisible, resources.GetString("chkVerticesFillVisible.ToolTip"));
            this.chkVerticesFillVisible.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            this.ttOffsetIsRelative.SetToolTip(this.label29, resources.GetString("label29.ToolTip"));
            // 
            // cboVerticesType
            // 
            resources.ApplyResources(this.cboVerticesType, "cboVerticesType");
            this.cboVerticesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVerticesType.FormattingEnabled = true;
            this.cboVerticesType.Name = "cboVerticesType";
            this.ttOffsetIsRelative.SetToolTip(this.cboVerticesType, resources.GetString("cboVerticesType.ToolTip"));
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            this.ttOffsetIsRelative.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            this.ttOffsetIsRelative.SetToolTip(this.label27, resources.GetString("label27.ToolTip"));
            // 
            // clpVerticesColor
            // 
            resources.ApplyResources(this.clpVerticesColor, "clpVerticesColor");
            this.clpVerticesColor.Color = System.Drawing.Color.Black;
            this.clpVerticesColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpVerticesColor.DropDownHeight = 1;
            this.clpVerticesColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpVerticesColor.FormattingEnabled = true;
            this.clpVerticesColor.Items.AddRange(new object[] {
            resources.GetString("clpVerticesColor.Items")});
            this.clpVerticesColor.Name = "clpVerticesColor";
            this.ttOffsetIsRelative.SetToolTip(this.clpVerticesColor, resources.GetString("clpVerticesColor.ToolTip"));
            // 
            // chkVerticesVisible
            // 
            resources.ApplyResources(this.chkVerticesVisible, "chkVerticesVisible");
            this.chkVerticesVisible.Name = "chkVerticesVisible";
            this.ttOffsetIsRelative.SetToolTip(this.chkVerticesVisible, resources.GetString("chkVerticesVisible.ToolTip"));
            this.chkVerticesVisible.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.btnRemoveStyle);
            this.tabPage1.Controls.Add(this.btnAddStyle);
            this.tabPage1.Controls.Add(this.linePatternControl1);
            this.tabPage1.Name = "tabPage1";
            this.ttOffsetIsRelative.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStyle
            // 
            resources.ApplyResources(this.btnRemoveStyle, "btnRemoveStyle");
            this.btnRemoveStyle.Name = "btnRemoveStyle";
            this.ttOffsetIsRelative.SetToolTip(this.btnRemoveStyle, resources.GetString("btnRemoveStyle.ToolTip"));
            this.btnRemoveStyle.UseVisualStyleBackColor = true;
            this.btnRemoveStyle.Click += new System.EventHandler(this.btnRemoveStyle_Click);
            // 
            // btnAddStyle
            // 
            resources.ApplyResources(this.btnAddStyle, "btnAddStyle");
            this.btnAddStyle.Name = "btnAddStyle";
            this.ttOffsetIsRelative.SetToolTip(this.btnAddStyle, resources.GetString("btnAddStyle.ToolTip"));
            this.btnAddStyle.UseVisualStyleBackColor = true;
            this.btnAddStyle.Click += new System.EventHandler(this.btnAddStyle_Click);
            // 
            // linePatternControl1
            // 
            resources.ApplyResources(this.linePatternControl1, "linePatternControl1");
            this.linePatternControl1.BackColor = System.Drawing.Color.Transparent;
            this.linePatternControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linePatternControl1.CellHeight = 24;
            this.linePatternControl1.CellWidth = 72;
            this.linePatternControl1.GridColor = System.Drawing.Color.Gray;
            this.linePatternControl1.GridVisible = true;
            this.linePatternControl1.ItemCount = 1;
            this.linePatternControl1.Name = "linePatternControl1";
            this.linePatternControl1.SelectedIndex = -1;
            this.ttOffsetIsRelative.SetToolTip(this.linePatternControl1, resources.GetString("linePatternControl1.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.dynamicVisibilityControl1);
            this.tabPage2.Name = "tabPage2";
            this.ttOffsetIsRelative.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dynamicVisibilityControl1
            // 
            resources.ApplyResources(this.dynamicVisibilityControl1, "dynamicVisibilityControl1");
            this.dynamicVisibilityControl1.CurrentScale = 0D;
            this.dynamicVisibilityControl1.CurrentZoom = 0;
            this.dynamicVisibilityControl1.MaxScale = 1000000D;
            this.dynamicVisibilityControl1.MaxZoom = 24;
            this.dynamicVisibilityControl1.MinScale = 100D;
            this.dynamicVisibilityControl1.MinZoom = 1;
            this.dynamicVisibilityControl1.Mode = MW5.Api.Enums.DynamicVisibilityMode.Scale;
            this.dynamicVisibilityControl1.Name = "dynamicVisibilityControl1";
            this.ttOffsetIsRelative.SetToolTip(this.dynamicVisibilityControl1, resources.GetString("dynamicVisibilityControl1.ToolTip"));
            this.dynamicVisibilityControl1.UseDynamicVisiblity = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.ttOffsetIsRelative.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.ttOffsetIsRelative.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            this.ttOffsetIsRelative.SetToolTip(this.label30, resources.GetString("label30.ToolTip"));
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.ttOffsetIsRelative.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.ttOffsetIsRelative.SetToolTip(this.btnOk, resources.GetString("btnOk.ToolTip"));
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupMarker
            // 
            resources.ApplyResources(this.groupMarker, "groupMarker");
            this.groupMarker.Controls.Add(this.chkOffsetIsRelative);
            this.groupMarker.Controls.Add(this.chkIntervalIsRelative);
            this.groupMarker.Controls.Add(this.label7);
            this.groupMarker.Controls.Add(this.label4);
            this.groupMarker.Controls.Add(this.udMarkerOffset);
            this.groupMarker.Controls.Add(this.clpMarkerOutline);
            this.groupMarker.Controls.Add(this.label6);
            this.groupMarker.Controls.Add(this.udMarkerSize);
            this.groupMarker.Controls.Add(this.cboOrientation);
            this.groupMarker.Controls.Add(this.label2);
            this.groupMarker.Controls.Add(this.label1);
            this.groupMarker.Controls.Add(this.pointSymbolControl1);
            this.groupMarker.Controls.Add(this.clpMarkerFill);
            this.groupMarker.Controls.Add(this.udMarkerInterval);
            this.groupMarker.Controls.Add(this.label30);
            this.groupMarker.Controls.Add(this.chkMarkerFlipFirst);
            this.groupMarker.Controls.Add(this.chkMarkerAllowOverflow);
            this.groupMarker.Name = "groupMarker";
            this.groupMarker.TabStop = false;
            this.ttOffsetIsRelative.SetToolTip(this.groupMarker, resources.GetString("groupMarker.ToolTip"));
            // 
            // chkOffsetIsRelative
            // 
            resources.ApplyResources(this.chkOffsetIsRelative, "chkOffsetIsRelative");
            this.chkOffsetIsRelative.Name = "chkOffsetIsRelative";
            this.ttOffsetIsRelative.SetToolTip(this.chkOffsetIsRelative, resources.GetString("chkOffsetIsRelative.ToolTip"));
            this.chkOffsetIsRelative.UseVisualStyleBackColor = true;
            this.chkOffsetIsRelative.CheckedChanged += new System.EventHandler(this.OnOffsetIsRelativeChanged);
            // 
            // chkIntervalIsRelative
            // 
            resources.ApplyResources(this.chkIntervalIsRelative, "chkIntervalIsRelative");
            this.chkIntervalIsRelative.Name = "chkIntervalIsRelative";
            this.ttOffsetIsRelative.SetToolTip(this.chkIntervalIsRelative, resources.GetString("chkIntervalIsRelative.ToolTip"));
            this.chkIntervalIsRelative.UseVisualStyleBackColor = true;
            this.chkIntervalIsRelative.CheckedChanged += new System.EventHandler(this.OnIntervalIsRelativeChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.ttOffsetIsRelative.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.ttOffsetIsRelative.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // udMarkerOffset
            // 
            resources.ApplyResources(this.udMarkerOffset, "udMarkerOffset");
            this.udMarkerOffset.Name = "udMarkerOffset";
            this.ttOffsetIsRelative.SetToolTip(this.udMarkerOffset, resources.GetString("udMarkerOffset.ToolTip"));
            this.udMarkerOffset.ValueChanged += new System.EventHandler(this.Ui2Options);
            // 
            // clpMarkerOutline
            // 
            resources.ApplyResources(this.clpMarkerOutline, "clpMarkerOutline");
            this.clpMarkerOutline.Color = System.Drawing.Color.Black;
            this.clpMarkerOutline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpMarkerOutline.DropDownHeight = 1;
            this.clpMarkerOutline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpMarkerOutline.FormattingEnabled = true;
            this.clpMarkerOutline.Items.AddRange(new object[] {
            resources.GetString("clpMarkerOutline.Items")});
            this.clpMarkerOutline.Name = "clpMarkerOutline";
            this.ttOffsetIsRelative.SetToolTip(this.clpMarkerOutline, resources.GetString("clpMarkerOutline.ToolTip"));
            this.clpMarkerOutline.SelectedColorChanged += new System.EventHandler(this.Ui2Options);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.ttOffsetIsRelative.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // udMarkerSize
            // 
            resources.ApplyResources(this.udMarkerSize, "udMarkerSize");
            this.udMarkerSize.Name = "udMarkerSize";
            this.ttOffsetIsRelative.SetToolTip(this.udMarkerSize, resources.GetString("udMarkerSize.ToolTip"));
            this.udMarkerSize.ValueChanged += new System.EventHandler(this.Ui2Options);
            // 
            // cboOrientation
            // 
            resources.ApplyResources(this.cboOrientation, "cboOrientation");
            this.cboOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrientation.FormattingEnabled = true;
            this.cboOrientation.Name = "cboOrientation";
            this.ttOffsetIsRelative.SetToolTip(this.cboOrientation, resources.GetString("cboOrientation.ToolTip"));
            this.cboOrientation.SelectedIndexChanged += new System.EventHandler(this.Ui2Options);
            // 
            // pointSymbolControl1
            // 
            resources.ApplyResources(this.pointSymbolControl1, "pointSymbolControl1");
            this.pointSymbolControl1.BackColor = System.Drawing.Color.White;
            this.pointSymbolControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointSymbolControl1.CellHeight = 24;
            this.pointSymbolControl1.CellWidth = 24;
            this.pointSymbolControl1.GridColor = System.Drawing.Color.Black;
            this.pointSymbolControl1.GridVisible = false;
            this.pointSymbolControl1.ItemCount = 17;
            this.pointSymbolControl1.Name = "pointSymbolControl1";
            this.pointSymbolControl1.SelectedIndex = -1;
            this.ttOffsetIsRelative.SetToolTip(this.pointSymbolControl1, resources.GetString("pointSymbolControl1.ToolTip"));
            // 
            // clpMarkerFill
            // 
            resources.ApplyResources(this.clpMarkerFill, "clpMarkerFill");
            this.clpMarkerFill.Color = System.Drawing.Color.Black;
            this.clpMarkerFill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpMarkerFill.DropDownHeight = 1;
            this.clpMarkerFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpMarkerFill.FormattingEnabled = true;
            this.clpMarkerFill.Items.AddRange(new object[] {
            resources.GetString("clpMarkerFill.Items")});
            this.clpMarkerFill.Name = "clpMarkerFill";
            this.ttOffsetIsRelative.SetToolTip(this.clpMarkerFill, resources.GetString("clpMarkerFill.ToolTip"));
            this.clpMarkerFill.SelectedColorChanged += new System.EventHandler(this.Ui2Options);
            // 
            // udMarkerInterval
            // 
            resources.ApplyResources(this.udMarkerInterval, "udMarkerInterval");
            this.udMarkerInterval.Name = "udMarkerInterval";
            this.ttOffsetIsRelative.SetToolTip(this.udMarkerInterval, resources.GetString("udMarkerInterval.ToolTip"));
            this.udMarkerInterval.ValueChanged += new System.EventHandler(this.Ui2Options);
            // 
            // chkMarkerFlipFirst
            // 
            resources.ApplyResources(this.chkMarkerFlipFirst, "chkMarkerFlipFirst");
            this.chkMarkerFlipFirst.Name = "chkMarkerFlipFirst";
            this.ttOffsetIsRelative.SetToolTip(this.chkMarkerFlipFirst, resources.GetString("chkMarkerFlipFirst.ToolTip"));
            this.chkMarkerFlipFirst.UseVisualStyleBackColor = true;
            this.chkMarkerFlipFirst.CheckedChanged += new System.EventHandler(this.Ui2Options);
            // 
            // chkMarkerAllowOverflow
            // 
            resources.ApplyResources(this.chkMarkerAllowOverflow, "chkMarkerAllowOverflow");
            this.chkMarkerAllowOverflow.Name = "chkMarkerAllowOverflow";
            this.ttOffsetIsRelative.SetToolTip(this.chkMarkerAllowOverflow, resources.GetString("chkMarkerAllowOverflow.ToolTip"));
            this.chkMarkerAllowOverflow.UseVisualStyleBackColor = true;
            this.chkMarkerAllowOverflow.CheckedChanged += new System.EventHandler(this.Ui2Options);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.ttOffsetIsRelative.SetToolTip(this.btnApply, resources.GetString("btnApply.ToolTip"));
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnMoveDown
            // 
            resources.ApplyResources(this.btnMoveDown, "btnMoveDown");
            this.btnMoveDown.Image = global::MW5.Plugins.Symbology.Properties.Resources.Arrow2___Down;
            this.btnMoveDown.Name = "btnMoveDown";
            this.ttOffsetIsRelative.SetToolTip(this.btnMoveDown, resources.GetString("btnMoveDown.ToolTip"));
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            resources.ApplyResources(this.btnMoveUp, "btnMoveUp");
            this.btnMoveUp.Image = global::MW5.Plugins.Symbology.Properties.Resources.Arrow2___Up;
            this.btnMoveUp.Name = "btnMoveUp";
            this.ttOffsetIsRelative.SetToolTip(this.btnMoveUp, resources.GetString("btnMoveUp.ToolTip"));
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Image = global::MW5.Plugins.Symbology.Properties.Resources.Minus;
            this.btnRemove.Name = "btnRemove";
            this.ttOffsetIsRelative.SetToolTip(this.btnRemove, resources.GetString("btnRemove.ToolTip"));
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Image = global::MW5.Plugins.Symbology.Properties.Resources.Plus_orange;
            this.btnAdd.Name = "btnAdd";
            this.ttOffsetIsRelative.SetToolTip(this.btnAdd, resources.GetString("btnAdd.ToolTip"));
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LinesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupMarker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LinesForm";
            this.ShowInTaskbar = false;
            this.ttOffsetIsRelative.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLines_FormClosing);
            this.Load += new System.EventHandler(this.LinesForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLine.ResumeLayout(false);
            this.tabLine.PerformLayout();
            this.groupLine.ResumeLayout(false);
            this.groupLine.PerformLayout();
            this.tabVertices.ResumeLayout(false);
            this.tabVertices.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udVerticesSize)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupMarker.ResumeLayout(false);
            this.groupMarker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMarkerOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMarkerSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMarkerInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctPreview;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVertices;
        private NumericUpDownEx udVerticesSize;
        private System.Windows.Forms.CheckBox chkVerticesFillVisible;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboVerticesType;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chkVerticesVisible;
        private Office2007ColorPicker clpVerticesColor;
        private System.Windows.Forms.TabPage tabLine;
        private NumericUpDownEx udMarkerInterval;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private Office2007ColorPicker clpMarkerFill;
        private SymbolControl pointSymbolControl1;
        private NumericUpDownEx udMarkerSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLineType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private ImageCombo icbLineWidth;
        private ImageCombo icbLineType;
        private Office2007ColorPicker clpOutline;
        private System.Windows.Forms.GroupBox groupLine;
        private System.Windows.Forms.GroupBox groupMarker;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label4;
        private Office2007ColorPicker clpMarkerOutline;
        private System.Windows.Forms.Label label7;
        private NumericUpDownEx udMarkerOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboOrientation;
        private System.Windows.Forms.CheckBox chkMarkerFlipFirst;
        private System.Windows.Forms.CheckBox chkMarkerAllowOverflow;
        private TransparencyControl transparencyControl1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRemoveStyle;
        private System.Windows.Forms.Button btnAddStyle;
        private LinePatternControl linePatternControl1;
        private System.Windows.Forms.CheckBox chkOffsetIsRelative;
        private System.Windows.Forms.ToolTip ttOffsetIsRelative;
        private System.Windows.Forms.CheckBox chkIntervalIsRelative;
        private System.Windows.Forms.TabPage tabPage2;
        private DynamicVisibilityControl dynamicVisibilityControl1;
    }
}