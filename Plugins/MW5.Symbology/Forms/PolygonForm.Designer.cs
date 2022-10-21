using MW5.Plugins.Symbology.Controls;
using MW5.Plugins.Symbology.Controls.ListControls;
using MW5.UI.Controls;

namespace MW5.Plugins.Symbology.Forms
{
    partial class PolygonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolygonForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctPreview = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.transpFill = new MW5.UI.Controls.TransparencyControl();
            this.pnlFillPicture = new System.Windows.Forms.Panel();
            this.udScaleY = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.udScaleX = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupGradient = new System.Windows.Forms.GroupBox();
            this.pnlFillGradient = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.udGradientRotation = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.cboGradientBounds = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGradientType = new System.Windows.Forms.ComboBox();
            this.clpGradient2 = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.clpFill = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFillType = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.transpOutline = new MW5.UI.Controls.TransparencyControl();
            this.icbLineWidth = new MW5.UI.Controls.ImageCombo();
            this.icbLineType = new MW5.UI.Controls.ImageCombo();
            this.clpOutline = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.udVerticesSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.chkVerticesFillVisible = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cboVerticesType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.clpVerticesColor = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dynamicVisibilityControl1 = new MW5.Plugins.Symbology.Controls.DynamicVisibilityControl();
            this.pnlFillHatch = new System.Windows.Forms.Panel();
            this.icbHatchStyle = new MW5.UI.Controls.ImageCombo();
            this.chkFillBgTransparent = new System.Windows.Forms.CheckBox();
            this.clpHatchBack = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkOutlineVisible = new System.Windows.Forms.CheckBox();
            this.chkFillVisible = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkVerticesVisible = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupHatch = new System.Windows.Forms.GroupBox();
            this.groupPicture = new System.Windows.Forms.GroupBox();
            this.textureControl1 = new MW5.Plugins.Symbology.Controls.ListControls.IconControl();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlFillPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udScaleX)).BeginInit();
            this.groupGradient.SuspendLayout();
            this.pnlFillGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udGradientRotation)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udVerticesSize)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.pnlFillHatch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupHatch.SuspendLayout();
            this.groupPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.pctPreview);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pctPreview
            // 
            resources.ApplyResources(this.pctPreview, "pctPreview");
            this.pctPreview.BackColor = System.Drawing.Color.Transparent;
            this.pctPreview.Name = "pctPreview";
            this.pctPreview.TabStop = false;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.transpFill);
            this.tabPage2.Controls.Add(this.pnlFillPicture);
            this.tabPage2.Controls.Add(this.groupGradient);
            this.tabPage2.Controls.Add(this.clpFill);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cboFillType);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // transpFill
            // 
            resources.ApplyResources(this.transpFill, "transpFill");
            this.transpFill.BandColor = System.Drawing.Color.Empty;
            this.transpFill.Name = "transpFill";
            this.transpFill.Value = ((byte)(255));
            this.transpFill.ValueChanged += new MW5.UI.Controls.TransparencyControl.ValueChangedDeleg(this.transpOutline_ValueChanged);
            // 
            // pnlFillPicture
            // 
            resources.ApplyResources(this.pnlFillPicture, "pnlFillPicture");
            this.pnlFillPicture.Controls.Add(this.udScaleY);
            this.pnlFillPicture.Controls.Add(this.label9);
            this.pnlFillPicture.Controls.Add(this.udScaleX);
            this.pnlFillPicture.Controls.Add(this.label8);
            this.pnlFillPicture.Name = "pnlFillPicture";
            // 
            // udScaleY
            // 
            resources.ApplyResources(this.udScaleY, "udScaleY");
            this.udScaleY.DecimalPlaces = 1;
            this.udScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udScaleY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udScaleY.Name = "udScaleY";
            this.udScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // udScaleX
            // 
            resources.ApplyResources(this.udScaleX, "udScaleX");
            this.udScaleX.DecimalPlaces = 1;
            this.udScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udScaleX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udScaleX.Name = "udScaleX";
            this.udScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupGradient
            // 
            resources.ApplyResources(this.groupGradient, "groupGradient");
            this.groupGradient.Controls.Add(this.pnlFillGradient);
            this.groupGradient.Name = "groupGradient";
            this.groupGradient.TabStop = false;
            // 
            // pnlFillGradient
            // 
            resources.ApplyResources(this.pnlFillGradient, "pnlFillGradient");
            this.pnlFillGradient.Controls.Add(this.label11);
            this.pnlFillGradient.Controls.Add(this.udGradientRotation);
            this.pnlFillGradient.Controls.Add(this.cboGradientBounds);
            this.pnlFillGradient.Controls.Add(this.label4);
            this.pnlFillGradient.Controls.Add(this.label26);
            this.pnlFillGradient.Controls.Add(this.label7);
            this.pnlFillGradient.Controls.Add(this.cboGradientType);
            this.pnlFillGradient.Controls.Add(this.clpGradient2);
            this.pnlFillGradient.Name = "pnlFillGradient";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // udGradientRotation
            // 
            resources.ApplyResources(this.udGradientRotation, "udGradientRotation");
            this.udGradientRotation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udGradientRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.udGradientRotation.Name = "udGradientRotation";
            // 
            // cboGradientBounds
            // 
            resources.ApplyResources(this.cboGradientBounds, "cboGradientBounds");
            this.cboGradientBounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradientBounds.FormattingEnabled = true;
            this.cboGradientBounds.Name = "cboGradientBounds";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cboGradientType
            // 
            resources.ApplyResources(this.cboGradientType, "cboGradientType");
            this.cboGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradientType.FormattingEnabled = true;
            this.cboGradientType.Name = "cboGradientType";
            // 
            // clpGradient2
            // 
            resources.ApplyResources(this.clpGradient2, "clpGradient2");
            this.clpGradient2.Color = System.Drawing.Color.Black;
            this.clpGradient2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpGradient2.DropDownHeight = 1;
            this.clpGradient2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpGradient2.FormattingEnabled = true;
            this.clpGradient2.Items.AddRange(new object[] {
            resources.GetString("clpGradient2.Items")});
            this.clpGradient2.Name = "clpGradient2";
            // 
            // clpFill
            // 
            resources.ApplyResources(this.clpFill, "clpFill");
            this.clpFill.Color = System.Drawing.Color.Black;
            this.clpFill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFill.DropDownHeight = 1;
            this.clpFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFill.FormattingEnabled = true;
            this.clpFill.Items.AddRange(new object[] {
            resources.GetString("clpFill.Items")});
            this.clpFill.Name = "clpFill";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboFillType
            // 
            resources.ApplyResources(this.cboFillType, "cboFillType");
            this.cboFillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFillType.FormattingEnabled = true;
            this.cboFillType.Name = "cboFillType";
            // 
            // tabPage5
            // 
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.transpOutline);
            this.groupBox3.Controls.Add(this.icbLineWidth);
            this.groupBox3.Controls.Add(this.icbLineType);
            this.groupBox3.Controls.Add(this.clpOutline);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // transpOutline
            // 
            resources.ApplyResources(this.transpOutline, "transpOutline");
            this.transpOutline.BandColor = System.Drawing.Color.Empty;
            this.transpOutline.Name = "transpOutline";
            this.transpOutline.Value = ((byte)(255));
            this.transpOutline.ValueChanged += new MW5.UI.Controls.TransparencyControl.ValueChangedDeleg(this.transpOutline_ValueChanged);
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
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.udVerticesSize);
            this.groupBox4.Controls.Add(this.chkVerticesFillVisible);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.cboVerticesType);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.clpVerticesColor);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // udVerticesSize
            // 
            resources.ApplyResources(this.udVerticesSize, "udVerticesSize");
            this.udVerticesSize.Name = "udVerticesSize";
            // 
            // chkVerticesFillVisible
            // 
            resources.ApplyResources(this.chkVerticesFillVisible, "chkVerticesFillVisible");
            this.chkVerticesFillVisible.Name = "chkVerticesFillVisible";
            this.chkVerticesFillVisible.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // cboVerticesType
            // 
            resources.ApplyResources(this.cboVerticesType, "cboVerticesType");
            this.cboVerticesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVerticesType.FormattingEnabled = true;
            this.cboVerticesType.Name = "cboVerticesType";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
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
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.dynamicVisibilityControl1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dynamicVisibilityControl1.UseDynamicVisiblity = false;
            // 
            // pnlFillHatch
            // 
            resources.ApplyResources(this.pnlFillHatch, "pnlFillHatch");
            this.pnlFillHatch.Controls.Add(this.icbHatchStyle);
            this.pnlFillHatch.Controls.Add(this.chkFillBgTransparent);
            this.pnlFillHatch.Controls.Add(this.clpHatchBack);
            this.pnlFillHatch.Controls.Add(this.label2);
            this.pnlFillHatch.Controls.Add(this.label3);
            this.pnlFillHatch.Name = "pnlFillHatch";
            // 
            // icbHatchStyle
            // 
            resources.ApplyResources(this.icbHatchStyle, "icbHatchStyle");
            this.icbHatchStyle.Color1 = System.Drawing.Color.Blue;
            this.icbHatchStyle.Color2 = System.Drawing.Color.Honeydew;
            this.icbHatchStyle.ComboStyle = MW5.UI.Enums.ImageComboStyle.Common;
            this.icbHatchStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbHatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbHatchStyle.FormattingEnabled = true;
            this.icbHatchStyle.Name = "icbHatchStyle";
            this.icbHatchStyle.OutlineColor = System.Drawing.Color.Black;
            // 
            // chkFillBgTransparent
            // 
            resources.ApplyResources(this.chkFillBgTransparent, "chkFillBgTransparent");
            this.chkFillBgTransparent.Name = "chkFillBgTransparent";
            this.chkFillBgTransparent.UseVisualStyleBackColor = true;
            // 
            // clpHatchBack
            // 
            resources.ApplyResources(this.clpHatchBack, "clpHatchBack");
            this.clpHatchBack.Color = System.Drawing.Color.Black;
            this.clpHatchBack.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpHatchBack.DropDownHeight = 1;
            this.clpHatchBack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpHatchBack.FormattingEnabled = true;
            this.clpHatchBack.Items.AddRange(new object[] {
            resources.GetString("clpHatchBack.Items")});
            this.clpHatchBack.Name = "clpHatchBack";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // chkOutlineVisible
            // 
            resources.ApplyResources(this.chkOutlineVisible, "chkOutlineVisible");
            this.chkOutlineVisible.Name = "chkOutlineVisible";
            this.chkOutlineVisible.UseVisualStyleBackColor = true;
            // 
            // chkFillVisible
            // 
            resources.ApplyResources(this.chkFillVisible, "chkFillVisible");
            this.chkFillVisible.Name = "chkFillVisible";
            this.chkFillVisible.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.chkFillVisible);
            this.groupBox2.Controls.Add(this.chkVerticesVisible);
            this.groupBox2.Controls.Add(this.chkOutlineVisible);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chkVerticesVisible
            // 
            resources.ApplyResources(this.chkVerticesVisible, "chkVerticesVisible");
            this.chkVerticesVisible.Name = "chkVerticesVisible";
            this.chkVerticesVisible.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupHatch
            // 
            resources.ApplyResources(this.groupHatch, "groupHatch");
            this.groupHatch.Controls.Add(this.pnlFillHatch);
            this.groupHatch.Name = "groupHatch";
            this.groupHatch.TabStop = false;
            // 
            // groupPicture
            // 
            resources.ApplyResources(this.groupPicture, "groupPicture");
            this.groupPicture.Controls.Add(this.textureControl1);
            this.groupPicture.Name = "groupPicture";
            this.groupPicture.TabStop = false;
            // 
            // textureControl1
            // 
            resources.ApplyResources(this.textureControl1, "textureControl1");
            this.textureControl1.BackColor = System.Drawing.Color.Transparent;
            this.textureControl1.CellHeight = 48;
            this.textureControl1.CellWidth = 48;
            this.textureControl1.FilePath = "";
            this.textureControl1.GridColor = System.Drawing.Color.Gray;
            this.textureControl1.GridVisible = true;
            this.textureControl1.ItemCount = 0;
            this.textureControl1.Name = "textureControl1";
            this.textureControl1.SelectedIndex = -1;
            this.textureControl1.SelectedPath = "";
            this.textureControl1.Textures = false;
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // PolygonForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupPicture);
            this.Controls.Add(this.groupHatch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PolygonForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPolygons_FormClosing);
            this.Load += new System.EventHandler(this.PolygonForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlFillPicture.ResumeLayout(false);
            this.pnlFillPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udScaleX)).EndInit();
            this.groupGradient.ResumeLayout(false);
            this.pnlFillGradient.ResumeLayout(false);
            this.pnlFillGradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udGradientRotation)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udVerticesSize)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.pnlFillHatch.ResumeLayout(false);
            this.pnlFillHatch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupHatch.ResumeLayout(false);
            this.groupPicture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctPreview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel pnlFillGradient;
        private NumericUpDownEx udGradientRotation;
        private System.Windows.Forms.ComboBox cboGradientBounds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGradientType;
        private Office2007ColorPicker clpGradient2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlFillHatch;
        private ImageCombo icbHatchStyle;
        private System.Windows.Forms.CheckBox chkFillBgTransparent;
        private Office2007ColorPicker clpHatchBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private NumericUpDownEx udVerticesSize;
        private System.Windows.Forms.CheckBox chkVerticesFillVisible;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboVerticesType;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private Office2007ColorPicker clpVerticesColor;
        private System.Windows.Forms.CheckBox chkOutlineVisible;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private ImageCombo icbLineWidth;
        private ImageCombo icbLineType;
        private Office2007ColorPicker clpOutline;
        private System.Windows.Forms.CheckBox chkFillVisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFillType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private IconControl textureControl1;
        private Office2007ColorPicker clpFill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlFillPicture;
        private NumericUpDownEx udScaleY;
        private System.Windows.Forms.Label label9;
        private NumericUpDownEx udScaleX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkVerticesVisible;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupGradient;
        private System.Windows.Forms.GroupBox groupHatch;
        private System.Windows.Forms.GroupBox groupPicture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private TransparencyControl transpFill;
        private System.Windows.Forms.Label label12;
        private TransparencyControl transpOutline;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabPage tabPage1;
        private DynamicVisibilityControl dynamicVisibilityControl1;
    }
}