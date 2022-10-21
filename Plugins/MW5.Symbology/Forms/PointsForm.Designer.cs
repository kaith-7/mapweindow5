using MW5.Plugins.Symbology.Controls;
using MW5.Plugins.Symbology.Controls.ListControls;
using MW5.UI.Controls;

namespace MW5.Plugins.Symbology.Forms
{
    partial class PointsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointsForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.udSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udRotation = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.clpFillColor = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSymbol = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.transparencyControl1 = new MW5.UI.Controls.TransparencyControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.udPointNumSides = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udSideRatio = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.symbolControl1 = new MW5.Plugins.Symbology.Controls.ListControls.SymbolControl();
            this.icbPointShape = new MW5.UI.Controls.ImageCombo();
            this.label17 = new System.Windows.Forms.Label();
            this.tabCharacter = new System.Windows.Forms.TabPage();
            this.chkShowAllFonts = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cboFontName = new System.Windows.Forms.ComboBox();
            this.characterControl1 = new MW5.Plugins.Symbology.Controls.ListControls.CharacterControl();
            this.tabIcon = new System.Windows.Forms.TabPage();
            this.pointIconControl1 = new MW5.Plugins.Symbology.Controls.PointIconControl();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNoOptions = new System.Windows.Forms.Label();
            this.chkFillVisible = new System.Windows.Forms.CheckBox();
            this.pnlFillHatch = new System.Windows.Forms.Panel();
            this.icbHatchStyle = new MW5.UI.Controls.ImageCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFillBgTransparent = new System.Windows.Forms.CheckBox();
            this.clpHatchBack = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cboFillType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkOutlineVisible = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.icbLineWidth = new MW5.UI.Controls.ImageCombo();
            this.icbLineType = new MW5.UI.Controls.ImageCombo();
            this.clpOutline = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dynamicVisibilityControl1 = new MW5.Plugins.Symbology.Controls.DynamicVisibilityControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctPreview = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlFillGradient = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.udGradientRotation = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clpGradient2 = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.cboGradientType = new System.Windows.Forms.ComboBox();
            this.pnlFillPicture = new System.Windows.Forms.Panel();
            this.btnChooseTexture = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRotation)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSymbol.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPointNumSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSideRatio)).BeginInit();
            this.tabCharacter.SuspendLayout();
            this.tabIcon.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlFillHatch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).BeginInit();
            this.pnlFillGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udGradientRotation)).BeginInit();
            this.pnlFillPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.udSize);
            this.panel1.Controls.Add(this.udRotation);
            this.panel1.Controls.Add(this.clpFillColor);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // udSize
            // 
            resources.ApplyResources(this.udSize, "udSize");
            this.udSize.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udSize.Name = "udSize";
            this.udSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // udRotation
            // 
            resources.ApplyResources(this.udRotation, "udRotation");
            this.udRotation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.udRotation.Name = "udRotation";
            this.udRotation.ValueChanged += new System.EventHandler(this.Gui2Options);
            // 
            // clpFillColor
            // 
            resources.ApplyResources(this.clpFillColor, "clpFillColor");
            this.clpFillColor.Color = System.Drawing.Color.Black;
            this.clpFillColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFillColor.DropDownHeight = 1;
            this.clpFillColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFillColor.FormattingEnabled = true;
            this.clpFillColor.Items.AddRange(new object[] {
            resources.GetString("clpFillColor.Items")});
            this.clpFillColor.Name = "clpFillColor";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabSymbol);
            this.tabControl1.Controls.Add(this.tabCharacter);
            this.tabControl1.Controls.Add(this.tabIcon);
            this.tabControl1.Controls.Add(this.tabOptions);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabSymbol
            // 
            resources.ApplyResources(this.tabSymbol, "tabSymbol");
            this.tabSymbol.Controls.Add(this.label3);
            this.tabSymbol.Controls.Add(this.transparencyControl1);
            this.tabSymbol.Controls.Add(this.groupBox5);
            this.tabSymbol.Controls.Add(this.symbolControl1);
            this.tabSymbol.Controls.Add(this.icbPointShape);
            this.tabSymbol.Controls.Add(this.label17);
            this.tabSymbol.Name = "tabSymbol";
            this.tabSymbol.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // transparencyControl1
            // 
            resources.ApplyResources(this.transparencyControl1, "transparencyControl1");
            this.transparencyControl1.BandColor = System.Drawing.Color.Empty;
            this.transparencyControl1.Name = "transparencyControl1";
            this.transparencyControl1.Value = ((byte)(255));
            this.transparencyControl1.ValueChanged += new MW5.UI.Controls.TransparencyControl.ValueChangedDeleg(this.transparencyControl1_ValueChanged);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.udPointNumSides);
            this.groupBox5.Controls.Add(this.udSideRatio);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // udPointNumSides
            // 
            resources.ApplyResources(this.udPointNumSides, "udPointNumSides");
            this.udPointNumSides.Name = "udPointNumSides";
            // 
            // udSideRatio
            // 
            resources.ApplyResources(this.udSideRatio, "udSideRatio");
            this.udSideRatio.Name = "udSideRatio";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // symbolControl1
            // 
            resources.ApplyResources(this.symbolControl1, "symbolControl1");
            this.symbolControl1.BackColor = System.Drawing.Color.Transparent;
            this.symbolControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolControl1.CellHeight = 24;
            this.symbolControl1.CellWidth = 24;
            this.symbolControl1.GridColor = System.Drawing.Color.Black;
            this.symbolControl1.GridVisible = false;
            this.symbolControl1.ItemCount = 17;
            this.symbolControl1.Name = "symbolControl1";
            this.symbolControl1.SelectedIndex = -1;
            // 
            // icbPointShape
            // 
            resources.ApplyResources(this.icbPointShape, "icbPointShape");
            this.icbPointShape.Color1 = System.Drawing.Color.Orange;
            this.icbPointShape.Color2 = System.Drawing.Color.Honeydew;
            this.icbPointShape.ComboStyle = MW5.UI.Enums.ImageComboStyle.Common;
            this.icbPointShape.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbPointShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbPointShape.FormattingEnabled = true;
            this.icbPointShape.Name = "icbPointShape";
            this.icbPointShape.OutlineColor = System.Drawing.Color.DimGray;
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // tabCharacter
            // 
            resources.ApplyResources(this.tabCharacter, "tabCharacter");
            this.tabCharacter.Controls.Add(this.chkShowAllFonts);
            this.tabCharacter.Controls.Add(this.label35);
            this.tabCharacter.Controls.Add(this.cboFontName);
            this.tabCharacter.Controls.Add(this.characterControl1);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.UseVisualStyleBackColor = true;
            // 
            // chkShowAllFonts
            // 
            resources.ApplyResources(this.chkShowAllFonts, "chkShowAllFonts");
            this.chkShowAllFonts.Name = "chkShowAllFonts";
            this.chkShowAllFonts.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // cboFontName
            // 
            resources.ApplyResources(this.cboFontName, "cboFontName");
            this.cboFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontName.FormattingEnabled = true;
            this.cboFontName.Name = "cboFontName";
            // 
            // characterControl1
            // 
            resources.ApplyResources(this.characterControl1, "characterControl1");
            this.characterControl1.BackColor = System.Drawing.Color.Transparent;
            this.characterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.characterControl1.CellHeight = 32;
            this.characterControl1.CellWidth = 32;
            this.characterControl1.ForeColor = System.Drawing.Color.Black;
            this.characterControl1.GridColor = System.Drawing.Color.DimGray;
            this.characterControl1.GridVisible = true;
            this.characterControl1.ItemCount = 224;
            this.characterControl1.Name = "characterControl1";
            this.characterControl1.SelectedCharacterCode = ((byte)(0));
            this.characterControl1.SelectedIndex = -1;
            // 
            // tabIcon
            // 
            resources.ApplyResources(this.tabIcon, "tabIcon");
            this.tabIcon.Controls.Add(this.pointIconControl1);
            this.tabIcon.Name = "tabIcon";
            this.tabIcon.UseVisualStyleBackColor = true;
            // 
            // pointIconControl1
            // 
            resources.ApplyResources(this.pointIconControl1, "pointIconControl1");
            this.pointIconControl1.Name = "pointIconControl1";
            // 
            // tabOptions
            // 
            resources.ApplyResources(this.tabOptions, "tabOptions");
            this.tabOptions.Controls.Add(this.groupBox3);
            this.tabOptions.Controls.Add(this.groupBox2);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.lblNoOptions);
            this.groupBox3.Controls.Add(this.chkFillVisible);
            this.groupBox3.Controls.Add(this.pnlFillHatch);
            this.groupBox3.Controls.Add(this.cboFillType);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lblNoOptions
            // 
            resources.ApplyResources(this.lblNoOptions, "lblNoOptions");
            this.lblNoOptions.Name = "lblNoOptions";
            // 
            // chkFillVisible
            // 
            resources.ApplyResources(this.chkFillVisible, "chkFillVisible");
            this.chkFillVisible.Name = "chkFillVisible";
            this.chkFillVisible.UseVisualStyleBackColor = true;
            // 
            // pnlFillHatch
            // 
            resources.ApplyResources(this.pnlFillHatch, "pnlFillHatch");
            this.pnlFillHatch.Controls.Add(this.icbHatchStyle);
            this.pnlFillHatch.Controls.Add(this.label6);
            this.pnlFillHatch.Controls.Add(this.chkFillBgTransparent);
            this.pnlFillHatch.Controls.Add(this.clpHatchBack);
            this.pnlFillHatch.Controls.Add(this.label4);
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
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cboFillType
            // 
            resources.ApplyResources(this.cboFillType, "cboFillType");
            this.cboFillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFillType.FormattingEnabled = true;
            this.cboFillType.Name = "cboFillType";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.chkOutlineVisible);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.icbLineWidth);
            this.groupBox2.Controls.Add(this.icbLineType);
            this.groupBox2.Controls.Add(this.clpOutline);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chkOutlineVisible
            // 
            resources.ApplyResources(this.chkOutlineVisible, "chkOutlineVisible");
            this.chkOutlineVisible.Name = "chkOutlineVisible";
            this.chkOutlineVisible.UseVisualStyleBackColor = true;
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
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
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
            // pnlFillGradient
            // 
            resources.ApplyResources(this.pnlFillGradient, "pnlFillGradient");
            this.pnlFillGradient.Controls.Add(this.label5);
            this.pnlFillGradient.Controls.Add(this.udGradientRotation);
            this.pnlFillGradient.Controls.Add(this.label26);
            this.pnlFillGradient.Controls.Add(this.label8);
            this.pnlFillGradient.Controls.Add(this.clpGradient2);
            this.pnlFillGradient.Controls.Add(this.cboGradientType);
            this.pnlFillGradient.Name = "pnlFillGradient";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
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
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
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
            // cboGradientType
            // 
            resources.ApplyResources(this.cboGradientType, "cboGradientType");
            this.cboGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradientType.FormattingEnabled = true;
            this.cboGradientType.Name = "cboGradientType";
            // 
            // pnlFillPicture
            // 
            resources.ApplyResources(this.pnlFillPicture, "pnlFillPicture");
            this.pnlFillPicture.Controls.Add(this.btnChooseTexture);
            this.pnlFillPicture.Name = "pnlFillPicture";
            // 
            // btnChooseTexture
            // 
            resources.ApplyResources(this.btnChooseTexture, "btnChooseTexture");
            this.btnChooseTexture.Name = "btnChooseTexture";
            this.btnChooseTexture.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnApplyClick);
            // 
            // PointsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pnlFillGradient);
            this.Controls.Add(this.pnlFillPicture);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PointsForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.PointsForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRotation)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSymbol.ResumeLayout(false);
            this.tabSymbol.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPointNumSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSideRatio)).EndInit();
            this.tabCharacter.ResumeLayout(false);
            this.tabCharacter.PerformLayout();
            this.tabIcon.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlFillHatch.ResumeLayout(false);
            this.pnlFillHatch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).EndInit();
            this.pnlFillGradient.ResumeLayout(false);
            this.pnlFillGradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udGradientRotation)).EndInit();
            this.pnlFillPicture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private NumericUpDownEx udSize;
        private NumericUpDownEx udRotation;
        private Office2007ColorPicker clpFillColor;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSymbol;
        private SymbolControl symbolControl1;
        private NumericUpDownEx udPointNumSides;
        private NumericUpDownEx udSideRatio;
        private ImageCombo icbPointShape;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabCharacter;
        private System.Windows.Forms.TabPage tabIcon;
        private CharacterControl characterControl1;
        private System.Windows.Forms.CheckBox chkShowAllFonts;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cboFontName;
        private System.Windows.Forms.GroupBox groupBox5;
        private Office2007ColorPicker clpHatchBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFillHatch;
        private ImageCombo icbHatchStyle;
        private System.Windows.Forms.CheckBox chkFillBgTransparent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlFillGradient;
        private NumericUpDownEx udGradientRotation;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboGradientType;
        private Office2007ColorPicker clpGradient2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlFillPicture;
        private System.Windows.Forms.Button btnChooseTexture;
        private System.Windows.Forms.Label lblNoOptions;
        private System.Windows.Forms.Label label3;
        private TransparencyControl transparencyControl1;
        private System.Windows.Forms.Button btnApply;
        private PointIconControl pointIconControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DynamicVisibilityControl dynamicVisibilityControl1;
        private System.Windows.Forms.Button button1;
    }
}