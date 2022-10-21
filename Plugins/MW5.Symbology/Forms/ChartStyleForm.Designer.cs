using MW5.Plugins.Symbology.Controls;
using MW5.Plugins.Symbology.Controls.ImageCombo;
using MW5.UI.Controls;

namespace MW5.Plugins.Symbology.Forms
{
    partial class ChartStyleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartStyleForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cboChartNormalizationField = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboChartSizeField = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.listLeft = new System.Windows.Forms.ListBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.listRight = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChangeScheme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panelPieChart = new System.Windows.Forms.Panel();
            this.udPieRadius2 = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udPieRadius = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelBarChart = new System.Windows.Forms.Panel();
            this.udBarHeight = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udBarWidth = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.udThickness = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udTilt = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.chk3DMode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.icbColors = new MW5.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkValuesFrame = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clpFrame = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.cboValuesStyle = new System.Windows.Forms.ComboBox();
            this.chkValuesVisible = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFontName = new System.Windows.Forms.ComboBox();
            this.chkFontItalic = new System.Windows.Forms.CheckBox();
            this.chkFontBold = new System.Windows.Forms.CheckBox();
            this.udFontSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.clpFont = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.tabPosition = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cboChartVerticalPosition = new System.Windows.Forms.ComboBox();
            this.groupboxChartsOffset = new System.Windows.Forms.GroupBox();
            this.udChartsOffsetY = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udChartsOffsetX = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udChartsBuffer = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabVisibility = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnSetMinScale = new System.Windows.Forms.Button();
            this.btnSetMaxScale = new System.Windows.Forms.Button();
            this.cboMaxScale = new System.Windows.Forms.ComboBox();
            this.cboMinScale = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chkDynamicVisibility = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnClearChartsExpression = new System.Windows.Forms.Button();
            this.btnChartExpression = new System.Windows.Forms.Button();
            this.txtChartExpression = new System.Windows.Forms.TextBox();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optBarCharts = new System.Windows.Forms.RadioButton();
            this.optPieCharts = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.transparencyControl1 = new MW5.UI.Controls.TransparencyControl();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panelPieChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius)).BeginInit();
            this.panelBarChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTilt)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize)).BeginInit();
            this.tabPosition.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupboxChartsOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsBuffer)).BeginInit();
            this.tabVisibility.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPosition);
            this.tabControl1.Controls.Add(this.tabVisibility);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.btnDeleteAll);
            this.tabPage3.Controls.Add(this.listLeft);
            this.tabPage3.Controls.Add(this.btnAddAll);
            this.tabPage3.Controls.Add(this.listRight);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            resources.ApplyResources(this.groupBox13, "groupBox13");
            this.groupBox13.Controls.Add(this.cboChartNormalizationField);
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.cboChartSizeField);
            this.groupBox13.Controls.Add(this.label18);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.TabStop = false;
            // 
            // cboChartNormalizationField
            // 
            resources.ApplyResources(this.cboChartNormalizationField, "cboChartNormalizationField");
            this.cboChartNormalizationField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChartNormalizationField.FormattingEnabled = true;
            this.cboChartNormalizationField.Name = "cboChartNormalizationField";
            this.cboChartNormalizationField.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // cboChartSizeField
            // 
            resources.ApplyResources(this.cboChartSizeField, "cboChartSizeField");
            this.cboChartSizeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChartSizeField.FormattingEnabled = true;
            this.cboChartSizeField.Name = "cboChartSizeField";
            this.cboChartSizeField.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteAll
            // 
            resources.ApplyResources(this.btnDeleteAll, "btnDeleteAll");
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // listLeft
            // 
            resources.ApplyResources(this.listLeft, "listLeft");
            this.listLeft.FormattingEnabled = true;
            this.listLeft.Name = "listLeft";
            this.listLeft.DoubleClick += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            resources.ApplyResources(this.btnAddAll, "btnAddAll");
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // listRight
            // 
            resources.ApplyResources(this.listRight, "listRight");
            this.listRight.FormattingEnabled = true;
            this.listRight.Name = "listRight";
            this.listRight.DoubleClick += new System.EventHandler(this.btnAdd_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.btnChangeScheme);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.icbColors);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChangeScheme
            // 
            resources.ApplyResources(this.btnChangeScheme, "btnChangeScheme");
            this.btnChangeScheme.Name = "btnChangeScheme";
            this.btnChangeScheme.UseVisualStyleBackColor = true;
            this.btnChangeScheme.Click += new System.EventHandler(this.btnChangeScheme_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.panelPieChart);
            this.groupBox6.Controls.Add(this.panelBarChart);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // panelPieChart
            // 
            resources.ApplyResources(this.panelPieChart, "panelPieChart");
            this.panelPieChart.Controls.Add(this.udPieRadius2);
            this.panelPieChart.Controls.Add(this.udPieRadius);
            this.panelPieChart.Controls.Add(this.label8);
            this.panelPieChart.Controls.Add(this.label9);
            this.panelPieChart.Name = "panelPieChart";
            // 
            // udPieRadius2
            // 
            resources.ApplyResources(this.udPieRadius2, "udPieRadius2");
            this.udPieRadius2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius2.Name = "udPieRadius2";
            this.udPieRadius2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius2.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udPieRadius
            // 
            resources.ApplyResources(this.udPieRadius, "udPieRadius");
            this.udPieRadius.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius.Name = "udPieRadius";
            this.udPieRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // panelBarChart
            // 
            resources.ApplyResources(this.panelBarChart, "panelBarChart");
            this.panelBarChart.Controls.Add(this.udBarHeight);
            this.panelBarChart.Controls.Add(this.udBarWidth);
            this.panelBarChart.Controls.Add(this.label3);
            this.panelBarChart.Controls.Add(this.label2);
            this.panelBarChart.Name = "panelBarChart";
            // 
            // udBarHeight
            // 
            resources.ApplyResources(this.udBarHeight, "udBarHeight");
            this.udBarHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarHeight.Name = "udBarHeight";
            this.udBarHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarHeight.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udBarWidth
            // 
            resources.ApplyResources(this.udBarWidth, "udBarWidth");
            this.udBarWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udBarWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarWidth.Name = "udBarWidth";
            this.udBarWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarWidth.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.udThickness);
            this.groupBox7.Controls.Add(this.udTilt);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.chk3DMode);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // udThickness
            // 
            resources.ApplyResources(this.udThickness, "udThickness");
            this.udThickness.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.udThickness.Name = "udThickness";
            this.udThickness.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udTilt
            // 
            resources.ApplyResources(this.udTilt, "udTilt");
            this.udTilt.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.udTilt.Name = "udTilt";
            this.udTilt.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // chk3DMode
            // 
            resources.ApplyResources(this.chk3DMode, "chk3DMode");
            this.chk3DMode.Name = "chk3DMode";
            this.chk3DMode.UseVisualStyleBackColor = true;
            this.chk3DMode.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // icbColors
            // 
            resources.ApplyResources(this.icbColors, "icbColors");
            this.icbColors.ComboStyle = MW5.Api.Enums.SchemeType.Graduated;
            this.icbColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbColors.FormattingEnabled = true;
            this.icbColors.Name = "icbColors";
            this.icbColors.OutlineColor = System.Drawing.Color.Black;
            this.icbColors.Target = MW5.Plugins.Symbology.SchemeTarget.Vector;
            this.icbColors.SelectedIndexChanged += new System.EventHandler(this.icbColors_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.cboValuesStyle);
            this.tabPage2.Controls.Add(this.chkValuesVisible);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.chkValuesFrame);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.clpFrame);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // chkValuesFrame
            // 
            resources.ApplyResources(this.chkValuesFrame, "chkValuesFrame");
            this.chkValuesFrame.Name = "chkValuesFrame";
            this.chkValuesFrame.UseVisualStyleBackColor = true;
            this.chkValuesFrame.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // clpFrame
            // 
            resources.ApplyResources(this.clpFrame, "clpFrame");
            this.clpFrame.Color = System.Drawing.Color.Black;
            this.clpFrame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFrame.DropDownHeight = 1;
            this.clpFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFrame.FormattingEnabled = true;
            this.clpFrame.Items.AddRange(new object[] {
            resources.GetString("clpFrame.Items")});
            this.clpFrame.Name = "clpFrame";
            this.clpFrame.SelectedColorChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // cboValuesStyle
            // 
            resources.ApplyResources(this.cboValuesStyle, "cboValuesStyle");
            this.cboValuesStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValuesStyle.FormattingEnabled = true;
            this.cboValuesStyle.Name = "cboValuesStyle";
            this.cboValuesStyle.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // chkValuesVisible
            // 
            resources.ApplyResources(this.chkValuesVisible, "chkValuesVisible");
            this.chkValuesVisible.Name = "chkValuesVisible";
            this.chkValuesVisible.UseVisualStyleBackColor = true;
            this.chkValuesVisible.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboFontName);
            this.groupBox4.Controls.Add(this.chkFontItalic);
            this.groupBox4.Controls.Add(this.chkFontBold);
            this.groupBox4.Controls.Add(this.udFontSize);
            this.groupBox4.Controls.Add(this.clpFont);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cboFontName
            // 
            resources.ApplyResources(this.cboFontName, "cboFontName");
            this.cboFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontName.FormattingEnabled = true;
            this.cboFontName.Name = "cboFontName";
            this.cboFontName.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // chkFontItalic
            // 
            resources.ApplyResources(this.chkFontItalic, "chkFontItalic");
            this.chkFontItalic.Name = "chkFontItalic";
            this.chkFontItalic.UseVisualStyleBackColor = true;
            this.chkFontItalic.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // chkFontBold
            // 
            resources.ApplyResources(this.chkFontBold, "chkFontBold");
            this.chkFontBold.Name = "chkFontBold";
            this.chkFontBold.UseVisualStyleBackColor = true;
            this.chkFontBold.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udFontSize
            // 
            resources.ApplyResources(this.udFontSize, "udFontSize");
            this.udFontSize.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.udFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.udFontSize.Name = "udFontSize";
            this.udFontSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.udFontSize.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // clpFont
            // 
            resources.ApplyResources(this.clpFont, "clpFont");
            this.clpFont.Color = System.Drawing.Color.Black;
            this.clpFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFont.DropDownHeight = 1;
            this.clpFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFont.FormattingEnabled = true;
            this.clpFont.Items.AddRange(new object[] {
            resources.GetString("clpFont.Items")});
            this.clpFont.Name = "clpFont";
            this.clpFont.SelectedColorChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // tabPosition
            // 
            resources.ApplyResources(this.tabPosition, "tabPosition");
            this.tabPosition.Controls.Add(this.groupBox10);
            this.tabPosition.Controls.Add(this.groupboxChartsOffset);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Controls.Add(this.cboChartVerticalPosition);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // cboChartVerticalPosition
            // 
            resources.ApplyResources(this.cboChartVerticalPosition, "cboChartVerticalPosition");
            this.cboChartVerticalPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChartVerticalPosition.FormattingEnabled = true;
            this.cboChartVerticalPosition.Name = "cboChartVerticalPosition";
            this.cboChartVerticalPosition.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // groupboxChartsOffset
            // 
            resources.ApplyResources(this.groupboxChartsOffset, "groupboxChartsOffset");
            this.groupboxChartsOffset.Controls.Add(this.udChartsOffsetY);
            this.groupboxChartsOffset.Controls.Add(this.udChartsOffsetX);
            this.groupboxChartsOffset.Controls.Add(this.udChartsBuffer);
            this.groupboxChartsOffset.Controls.Add(this.label17);
            this.groupboxChartsOffset.Controls.Add(this.label14);
            this.groupboxChartsOffset.Controls.Add(this.label15);
            this.groupboxChartsOffset.Name = "groupboxChartsOffset";
            this.groupboxChartsOffset.TabStop = false;
            // 
            // udChartsOffsetY
            // 
            resources.ApplyResources(this.udChartsOffsetY, "udChartsOffsetY");
            this.udChartsOffsetY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udChartsOffsetY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udChartsOffsetY.Name = "udChartsOffsetY";
            this.udChartsOffsetY.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udChartsOffsetX
            // 
            resources.ApplyResources(this.udChartsOffsetX, "udChartsOffsetX");
            this.udChartsOffsetX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udChartsOffsetX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udChartsOffsetX.Name = "udChartsOffsetX";
            this.udChartsOffsetX.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udChartsBuffer
            // 
            resources.ApplyResources(this.udChartsBuffer, "udChartsBuffer");
            this.udChartsBuffer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udChartsBuffer.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udChartsBuffer.Name = "udChartsBuffer";
            this.udChartsBuffer.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // tabVisibility
            // 
            resources.ApplyResources(this.tabVisibility, "tabVisibility");
            this.tabVisibility.Controls.Add(this.groupBox11);
            this.tabVisibility.Controls.Add(this.groupBox9);
            this.tabVisibility.Name = "tabVisibility";
            this.tabVisibility.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Controls.Add(this.btnSetMinScale);
            this.groupBox11.Controls.Add(this.btnSetMaxScale);
            this.groupBox11.Controls.Add(this.cboMaxScale);
            this.groupBox11.Controls.Add(this.cboMinScale);
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.chkDynamicVisibility);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // btnSetMinScale
            // 
            resources.ApplyResources(this.btnSetMinScale, "btnSetMinScale");
            this.btnSetMinScale.Name = "btnSetMinScale";
            this.btnSetMinScale.UseVisualStyleBackColor = true;
            this.btnSetMinScale.Click += new System.EventHandler(this.btnSetMinScale_Click);
            // 
            // btnSetMaxScale
            // 
            resources.ApplyResources(this.btnSetMaxScale, "btnSetMaxScale");
            this.btnSetMaxScale.Name = "btnSetMaxScale";
            this.btnSetMaxScale.UseVisualStyleBackColor = true;
            this.btnSetMaxScale.Click += new System.EventHandler(this.btnSetMaxScale_Click);
            // 
            // cboMaxScale
            // 
            resources.ApplyResources(this.cboMaxScale, "cboMaxScale");
            this.cboMaxScale.FormattingEnabled = true;
            this.cboMaxScale.Name = "cboMaxScale";
            this.cboMaxScale.TextChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // cboMinScale
            // 
            resources.ApplyResources(this.cboMinScale, "cboMinScale");
            this.cboMinScale.FormattingEnabled = true;
            this.cboMinScale.Name = "cboMinScale";
            this.cboMinScale.TextChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // chkDynamicVisibility
            // 
            resources.ApplyResources(this.chkDynamicVisibility, "chkDynamicVisibility");
            this.chkDynamicVisibility.Name = "chkDynamicVisibility";
            this.chkDynamicVisibility.UseVisualStyleBackColor = true;
            this.chkDynamicVisibility.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // groupBox9
            // 
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Controls.Add(this.btnClearChartsExpression);
            this.groupBox9.Controls.Add(this.btnChartExpression);
            this.groupBox9.Controls.Add(this.txtChartExpression);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // btnClearChartsExpression
            // 
            resources.ApplyResources(this.btnClearChartsExpression, "btnClearChartsExpression");
            this.btnClearChartsExpression.Name = "btnClearChartsExpression";
            this.btnClearChartsExpression.UseVisualStyleBackColor = true;
            this.btnClearChartsExpression.Click += new System.EventHandler(this.btnClearChartsExpression_Click);
            // 
            // btnChartExpression
            // 
            resources.ApplyResources(this.btnChartExpression, "btnChartExpression");
            this.btnChartExpression.Name = "btnChartExpression";
            this.btnChartExpression.UseVisualStyleBackColor = true;
            this.btnChartExpression.Click += new System.EventHandler(this.btnChartExpression_Click);
            // 
            // txtChartExpression
            // 
            resources.ApplyResources(this.txtChartExpression, "txtChartExpression");
            this.txtChartExpression.Name = "txtChartExpression";
            this.txtChartExpression.ReadOnly = true;
            // 
            // chkVisible
            // 
            resources.ApplyResources(this.chkVisible, "chkVisible");
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.optBarCharts);
            this.groupBox2.Controls.Add(this.optPieCharts);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // optBarCharts
            // 
            resources.ApplyResources(this.optBarCharts, "optBarCharts");
            this.optBarCharts.Name = "optBarCharts";
            this.optBarCharts.TabStop = true;
            this.optBarCharts.UseVisualStyleBackColor = true;
            this.optBarCharts.CheckedChanged += new System.EventHandler(this.optBarCharts_CheckedChanged);
            // 
            // optPieCharts
            // 
            resources.ApplyResources(this.optPieCharts, "optPieCharts");
            this.optPieCharts.Name = "optPieCharts";
            this.optPieCharts.TabStop = true;
            this.optPieCharts.UseVisualStyleBackColor = true;
            this.optPieCharts.CheckedChanged += new System.EventHandler(this.optPieCharts_CheckedChanged);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.chkVisible);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Controls.Add(this.transparencyControl1);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // transparencyControl1
            // 
            resources.ApplyResources(this.transparencyControl1, "transparencyControl1");
            this.transparencyControl1.BandColor = System.Drawing.Color.Empty;
            this.transparencyControl1.Name = "transparencyControl1";
            this.transparencyControl1.Value = ((byte)(255));
            this.transparencyControl1.ValueChanged += new MW5.UI.Controls.TransparencyControl.ValueChangedDeleg(this.transparencyControl1_ValueChanged);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ChartStyleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartStyleForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChartStyle_FormClosing);
            this.Load += new System.EventHandler(this.ChartStyleForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panelPieChart.ResumeLayout(false);
            this.panelPieChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius)).EndInit();
            this.panelBarChart.ResumeLayout(false);
            this.panelBarChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTilt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize)).EndInit();
            this.tabPosition.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupboxChartsOffset.ResumeLayout(false);
            this.groupboxChartsOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsBuffer)).EndInit();
            this.tabVisibility.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk3DMode;
        private System.Windows.Forms.Panel panelBarChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPieChart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkValuesVisible;
        private System.Windows.Forms.Label label11;
        private Office2007ColorPicker clpFrame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboValuesStyle;
        private NumericUpDownEx udFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFontName;
        private System.Windows.Forms.CheckBox chkFontItalic;
        private System.Windows.Forms.CheckBox chkFontBold;
        private Office2007ColorPicker clpFont;
        private System.Windows.Forms.CheckBox chkValuesFrame;
        private System.Windows.Forms.RadioButton optBarCharts;
        private System.Windows.Forms.RadioButton optPieCharts;
        private ColorSchemeCombo icbColors;
        private System.Windows.Forms.GroupBox groupBox2;
        private NumericUpDownEx udTilt;
        private NumericUpDownEx udThickness;
        private NumericUpDownEx udBarHeight;
        private NumericUpDownEx udBarWidth;
        private NumericUpDownEx udPieRadius2;
        private NumericUpDownEx udPieRadius;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private TransparencyControl transparencyControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listRight;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPosition;
        private System.Windows.Forms.GroupBox groupboxChartsOffset;
        private NumericUpDownEx udChartsOffsetY;
        private NumericUpDownEx udChartsOffsetX;
        private NumericUpDownEx udChartsBuffer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabVisibility;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cboChartNormalizationField;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboChartSizeField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnClearChartsExpression;
        private System.Windows.Forms.Button btnChartExpression;
        private System.Windows.Forms.TextBox txtChartExpression;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cboChartVerticalPosition;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cboMaxScale;
        private System.Windows.Forms.ComboBox cboMinScale;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkDynamicVisibility;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnChangeScheme;
        private System.Windows.Forms.Button btnSetMinScale;
        private System.Windows.Forms.Button btnSetMaxScale;
    }
}