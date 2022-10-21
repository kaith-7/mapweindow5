// ********************************************************************************************************
// <copyright file="MWLite.Symbology.cs" company="MapWindow.org">
// Copyright (c) MapWindow.org. All rights reserved.
// </copyright>
// The contents of this file are subject to the Mozilla Public License Version 1.1 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http:// Www.mozilla.org/MPL/ 
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specificlanguage governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this version of the Original Code is Sergei Leschinski
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date            Changed By      Notes
// ********************************************************************************************************

using System.Windows.Forms;
using MW5.Plugins.Symbology.Controls;
using MW5.UI.Controls;
using MW5.UI.Enums;

namespace MW5.Plugins.Symbology.Forms
{
    partial class LabelStyleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelStyleForm));
            this.chkLogScaleForSize = new System.Windows.Forms.CheckBox();
            this.chkUseVariableSize = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboDecimalPlaces = new System.Windows.Forms.ComboBox();
            this.chkSortAscending = new System.Windows.Forms.CheckBox();
            this.cboSortField = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.btnQuotes = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtExpression = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrent = new System.Windows.Forms.Button();
            this.cboBasicScale = new System.Windows.Forms.ComboBox();
            this.chkScaleLabels = new System.Windows.Forms.CheckBox();
            this.cboTextRenderingHint = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cboFontName = new System.Windows.Forms.ComboBox();
            this.chkFontStrikeout = new System.Windows.Forms.CheckBox();
            this.chkFontUnderline = new System.Windows.Forms.CheckBox();
            this.chkFontItalic = new System.Windows.Forms.CheckBox();
            this.clpFont1 = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.chkFontBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.udShadowOffsetY = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udShadowOffsetX = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udHaloSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.clpShadow = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.clpHalo = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.chkShadowVisible = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkHaloVisible = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.udFramePaddingY = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.udFramePaddingX = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetFrameGradient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.icbFrameType = new MW5.UI.Controls.ImageCombo();
            this.clpFrame1 = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.chkUseFrame = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.icbLineWidth = new MW5.UI.Controls.ImageCombo();
            this.icbLineType = new MW5.UI.Controls.ImageCombo();
            this.clpFrameBorder = new MW5.UI.Controls.Office2007ColorPicker(this.components);
            this.groupLabelAlignment = new System.Windows.Forms.GroupBox();
            this.udLabelOffsetY = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udLabelOffsetX = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udLabelsBuffer = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.optAlignBottomRight = new System.Windows.Forms.RadioButton();
            this.lblLabelsOffsetY = new System.Windows.Forms.Label();
            this.optAlignBottomCenter = new System.Windows.Forms.RadioButton();
            this.lblLabelsOffsetX = new System.Windows.Forms.Label();
            this.optAlignBottomLeft = new System.Windows.Forms.RadioButton();
            this.optAlignCenterRight = new System.Windows.Forms.RadioButton();
            this.optAlignCenter = new System.Windows.Forms.RadioButton();
            this.optAlignCenterLeft = new System.Windows.Forms.RadioButton();
            this.optAlignTopRight = new System.Windows.Forms.RadioButton();
            this.optAlignTopCenter = new System.Windows.Forms.RadioButton();
            this.optAlignTopLeft = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtLabelExpression = new System.Windows.Forms.TextBox();
            this.btnLabelExpression = new System.Windows.Forms.Button();
            this.btnClearLabelsExpression = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctPreview = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.udFontSize2 = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.transparencyControl1 = new MW5.UI.Controls.TransparencyControl();
            this.udFontSize = new MW5.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabMain = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.chkAviodCollisions = new System.Windows.Forms.CheckBox();
            this.chkLabelsRemoveDuplicates = new System.Windows.Forms.CheckBox();
            this.lblLabelVerticalPosition = new System.Windows.Forms.Label();
            this.cboLabelsVerticalPosition = new System.Windows.Forms.ComboBox();
            this.tabExpression = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPosition = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBoxPositioning = new System.Windows.Forms.GroupBox();
            this.chkLabelEveryPart = new System.Windows.Forms.CheckBox();
            this.cboLineOrientation = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.optPosition4 = new System.Windows.Forms.RadioButton();
            this.optPosition3 = new System.Windows.Forms.RadioButton();
            this.optPosition2 = new System.Windows.Forms.RadioButton();
            this.optPosition1 = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.comboOffsetY = new System.Windows.Forms.ComboBox();
            this.comboOffsetX = new System.Windows.Forms.ComboBox();
            this.labelOffsetYField = new System.Windows.Forms.Label();
            this.labelOffsetXField = new System.Windows.Forms.Label();
            this.tabVisibility = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dynamicVisibilityControl1 = new MW5.Plugins.Symbology.Controls.DynamicVisibilityControl();
            this.tabFont = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabFrame = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udShadowOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udShadowOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHaloSize)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFramePaddingY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFramePaddingX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupLabelAlignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelsBuffer)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tabExpression.SuspendLayout();
            this.tabPosition.SuspendLayout();
            this.groupBoxPositioning.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabVisibility.SuspendLayout();
            this.tabFont.SuspendLayout();
            this.tabFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLogScaleForSize
            // 
            resources.ApplyResources(this.chkLogScaleForSize, "chkLogScaleForSize");
            this.chkLogScaleForSize.Name = "chkLogScaleForSize";
            this.chkLogScaleForSize.UseVisualStyleBackColor = true;
            this.chkLogScaleForSize.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkUseVariableSize
            // 
            resources.ApplyResources(this.chkUseVariableSize, "chkUseVariableSize");
            this.chkUseVariableSize.Name = "chkUseVariableSize";
            this.chkUseVariableSize.UseVisualStyleBackColor = true;
            this.chkUseVariableSize.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // cboDecimalPlaces
            // 
            resources.ApplyResources(this.cboDecimalPlaces, "cboDecimalPlaces");
            this.cboDecimalPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDecimalPlaces.FormattingEnabled = true;
            this.cboDecimalPlaces.Name = "cboDecimalPlaces";
            this.cboDecimalPlaces.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkSortAscending
            // 
            resources.ApplyResources(this.chkSortAscending, "chkSortAscending");
            this.chkSortAscending.Name = "chkSortAscending";
            this.chkSortAscending.UseVisualStyleBackColor = true;
            this.chkSortAscending.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // cboSortField
            // 
            resources.ApplyResources(this.cboSortField, "cboSortField");
            this.cboSortField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortField.Name = "cboSortField";
            this.cboSortField.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // cboField
            // 
            resources.ApplyResources(this.cboField, "cboField");
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.Name = "cboField";
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.OnFieldChanged);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // groupBox10
            // 
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // groupBox9
            // 
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.OnClearClick);
            // 
            // btnNewLine
            // 
            resources.ApplyResources(this.btnNewLine, "btnNewLine");
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.OnNewLineClick);
            // 
            // btnQuotes
            // 
            resources.ApplyResources(this.btnQuotes, "btnQuotes");
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.UseVisualStyleBackColor = true;
            this.btnQuotes.Click += new System.EventHandler(this.OnQuotesClick);
            // 
            // btnPlus
            // 
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.OnPlusClick);
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.listBox1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.DoubleClick += new System.EventHandler(this.OnFieldListBoxDoubleClick);
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Controls.Add(this.txtExpression);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // txtExpression
            // 
            resources.ApplyResources(this.txtExpression, "txtExpression");
            this.txtExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.TextChanged += new System.EventHandler(this.OnExpressionChanged);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.btnSetCurrent);
            this.groupBox5.Controls.Add(this.cboBasicScale);
            this.groupBox5.Controls.Add(this.chkScaleLabels);
            this.groupBox5.Controls.Add(this.cboTextRenderingHint);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.cboFontName);
            this.groupBox5.Controls.Add(this.chkFontStrikeout);
            this.groupBox5.Controls.Add(this.chkFontUnderline);
            this.groupBox5.Controls.Add(this.chkFontItalic);
            this.groupBox5.Controls.Add(this.clpFont1);
            this.groupBox5.Controls.Add(this.chkFontBold);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btnSetCurrent
            // 
            resources.ApplyResources(this.btnSetCurrent, "btnSetCurrent");
            this.btnSetCurrent.Name = "btnSetCurrent";
            this.btnSetCurrent.UseVisualStyleBackColor = true;
            this.btnSetCurrent.Click += new System.EventHandler(this.btnSetCurrent_Click);
            // 
            // cboBasicScale
            // 
            resources.ApplyResources(this.cboBasicScale, "cboBasicScale");
            this.cboBasicScale.FormattingEnabled = true;
            this.cboBasicScale.Name = "cboBasicScale";
            this.cboBasicScale.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkScaleLabels
            // 
            resources.ApplyResources(this.chkScaleLabels, "chkScaleLabels");
            this.chkScaleLabels.Name = "chkScaleLabels";
            this.chkScaleLabels.UseVisualStyleBackColor = true;
            this.chkScaleLabels.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // cboTextRenderingHint
            // 
            resources.ApplyResources(this.cboTextRenderingHint, "cboTextRenderingHint");
            this.cboTextRenderingHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTextRenderingHint.FormattingEnabled = true;
            this.cboTextRenderingHint.Name = "cboTextRenderingHint";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
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
            this.cboFontName.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkFontStrikeout
            // 
            resources.ApplyResources(this.chkFontStrikeout, "chkFontStrikeout");
            this.chkFontStrikeout.Name = "chkFontStrikeout";
            this.chkFontStrikeout.UseVisualStyleBackColor = true;
            this.chkFontStrikeout.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkFontUnderline
            // 
            resources.ApplyResources(this.chkFontUnderline, "chkFontUnderline");
            this.chkFontUnderline.Name = "chkFontUnderline";
            this.chkFontUnderline.UseVisualStyleBackColor = true;
            this.chkFontUnderline.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkFontItalic
            // 
            resources.ApplyResources(this.chkFontItalic, "chkFontItalic");
            this.chkFontItalic.Name = "chkFontItalic";
            this.chkFontItalic.UseVisualStyleBackColor = true;
            this.chkFontItalic.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // clpFont1
            // 
            resources.ApplyResources(this.clpFont1, "clpFont1");
            this.clpFont1.Color = System.Drawing.Color.Black;
            this.clpFont1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFont1.DropDownHeight = 1;
            this.clpFont1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFont1.FormattingEnabled = true;
            this.clpFont1.Items.AddRange(new object[] {
            resources.GetString("clpFont1.Items")});
            this.clpFont1.Name = "clpFont1";
            this.clpFont1.SelectedColorChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkFontBold
            // 
            resources.ApplyResources(this.chkFontBold, "chkFontBold");
            this.chkFontBold.Name = "chkFontBold";
            this.chkFontBold.UseVisualStyleBackColor = true;
            this.chkFontBold.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.udShadowOffsetY);
            this.groupBox3.Controls.Add(this.udShadowOffsetX);
            this.groupBox3.Controls.Add(this.udHaloSize);
            this.groupBox3.Controls.Add(this.clpShadow);
            this.groupBox3.Controls.Add(this.clpHalo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.chkShadowVisible);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.chkHaloVisible);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // udShadowOffsetY
            // 
            resources.ApplyResources(this.udShadowOffsetY, "udShadowOffsetY");
            this.udShadowOffsetY.Name = "udShadowOffsetY";
            this.udShadowOffsetY.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // udShadowOffsetX
            // 
            resources.ApplyResources(this.udShadowOffsetX, "udShadowOffsetX");
            this.udShadowOffsetX.Name = "udShadowOffsetX";
            this.udShadowOffsetX.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // udHaloSize
            // 
            resources.ApplyResources(this.udHaloSize, "udHaloSize");
            this.udHaloSize.Name = "udHaloSize";
            this.udHaloSize.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // clpShadow
            // 
            resources.ApplyResources(this.clpShadow, "clpShadow");
            this.clpShadow.Color = System.Drawing.Color.Black;
            this.clpShadow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpShadow.DropDownHeight = 1;
            this.clpShadow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpShadow.FormattingEnabled = true;
            this.clpShadow.Items.AddRange(new object[] {
            resources.GetString("clpShadow.Items")});
            this.clpShadow.Name = "clpShadow";
            this.clpShadow.SelectedColorChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // clpHalo
            // 
            resources.ApplyResources(this.clpHalo, "clpHalo");
            this.clpHalo.Color = System.Drawing.Color.Black;
            this.clpHalo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpHalo.DropDownHeight = 1;
            this.clpHalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpHalo.FormattingEnabled = true;
            this.clpHalo.Items.AddRange(new object[] {
            resources.GetString("clpHalo.Items")});
            this.clpHalo.Name = "clpHalo";
            this.clpHalo.SelectedColorChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // chkShadowVisible
            // 
            resources.ApplyResources(this.chkShadowVisible, "chkShadowVisible");
            this.chkShadowVisible.Name = "chkShadowVisible";
            this.chkShadowVisible.UseVisualStyleBackColor = true;
            this.chkShadowVisible.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // chkHaloVisible
            // 
            resources.ApplyResources(this.chkHaloVisible, "chkHaloVisible");
            this.chkHaloVisible.Name = "chkHaloVisible";
            this.chkHaloVisible.UseVisualStyleBackColor = true;
            this.chkHaloVisible.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.udFramePaddingY);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.udFramePaddingX);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnSetFrameGradient);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.icbFrameType);
            this.groupBox4.Controls.Add(this.clpFrame1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // udFramePaddingY
            // 
            resources.ApplyResources(this.udFramePaddingY, "udFramePaddingY");
            this.udFramePaddingY.Name = "udFramePaddingY";
            this.udFramePaddingY.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // udFramePaddingX
            // 
            resources.ApplyResources(this.udFramePaddingX, "udFramePaddingX");
            this.udFramePaddingX.Name = "udFramePaddingX";
            this.udFramePaddingX.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnSetFrameGradient
            // 
            resources.ApplyResources(this.btnSetFrameGradient, "btnSetFrameGradient");
            this.btnSetFrameGradient.Name = "btnSetFrameGradient";
            this.btnSetFrameGradient.UseVisualStyleBackColor = true;
            this.btnSetFrameGradient.Click += new System.EventHandler(this.OnSetFrameGradientClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // icbFrameType
            // 
            resources.ApplyResources(this.icbFrameType, "icbFrameType");
            this.icbFrameType.Color1 = System.Drawing.Color.Blue;
            this.icbFrameType.Color2 = System.Drawing.Color.Honeydew;
            this.icbFrameType.ComboStyle = MW5.UI.Enums.ImageComboStyle.Common;
            this.icbFrameType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbFrameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbFrameType.FormattingEnabled = true;
            this.icbFrameType.Name = "icbFrameType";
            this.icbFrameType.OutlineColor = System.Drawing.Color.Black;
            this.icbFrameType.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // clpFrame1
            // 
            resources.ApplyResources(this.clpFrame1, "clpFrame1");
            this.clpFrame1.Color = System.Drawing.Color.Black;
            this.clpFrame1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFrame1.DropDownHeight = 1;
            this.clpFrame1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFrame1.FormattingEnabled = true;
            this.clpFrame1.Items.AddRange(new object[] {
            resources.GetString("clpFrame1.Items")});
            this.clpFrame1.Name = "clpFrame1";
            this.clpFrame1.SelectedColorChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // chkUseFrame
            // 
            resources.ApplyResources(this.chkUseFrame, "chkUseFrame");
            this.chkUseFrame.Name = "chkUseFrame";
            this.chkUseFrame.UseVisualStyleBackColor = true;
            this.chkUseFrame.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.icbLineWidth);
            this.groupBox2.Controls.Add(this.icbLineType);
            this.groupBox2.Controls.Add(this.clpFrameBorder);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
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
            this.icbLineWidth.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
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
            this.icbLineType.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // clpFrameBorder
            // 
            resources.ApplyResources(this.clpFrameBorder, "clpFrameBorder");
            this.clpFrameBorder.Color = System.Drawing.Color.Black;
            this.clpFrameBorder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFrameBorder.DropDownHeight = 1;
            this.clpFrameBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFrameBorder.FormattingEnabled = true;
            this.clpFrameBorder.Items.AddRange(new object[] {
            resources.GetString("clpFrameBorder.Items")});
            this.clpFrameBorder.Name = "clpFrameBorder";
            this.clpFrameBorder.SelectedColorChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // groupLabelAlignment
            // 
            resources.ApplyResources(this.groupLabelAlignment, "groupLabelAlignment");
            this.groupLabelAlignment.Controls.Add(this.udLabelOffsetY);
            this.groupLabelAlignment.Controls.Add(this.udLabelOffsetX);
            this.groupLabelAlignment.Controls.Add(this.udLabelsBuffer);
            this.groupLabelAlignment.Controls.Add(this.label14);
            this.groupLabelAlignment.Controls.Add(this.optAlignBottomRight);
            this.groupLabelAlignment.Controls.Add(this.lblLabelsOffsetY);
            this.groupLabelAlignment.Controls.Add(this.optAlignBottomCenter);
            this.groupLabelAlignment.Controls.Add(this.lblLabelsOffsetX);
            this.groupLabelAlignment.Controls.Add(this.optAlignBottomLeft);
            this.groupLabelAlignment.Controls.Add(this.optAlignCenterRight);
            this.groupLabelAlignment.Controls.Add(this.optAlignCenter);
            this.groupLabelAlignment.Controls.Add(this.optAlignCenterLeft);
            this.groupLabelAlignment.Controls.Add(this.optAlignTopRight);
            this.groupLabelAlignment.Controls.Add(this.optAlignTopCenter);
            this.groupLabelAlignment.Controls.Add(this.optAlignTopLeft);
            this.groupLabelAlignment.Name = "groupLabelAlignment";
            this.groupLabelAlignment.TabStop = false;
            // 
            // udLabelOffsetY
            // 
            resources.ApplyResources(this.udLabelOffsetY, "udLabelOffsetY");
            this.udLabelOffsetY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udLabelOffsetY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udLabelOffsetY.Name = "udLabelOffsetY";
            this.udLabelOffsetY.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // udLabelOffsetX
            // 
            resources.ApplyResources(this.udLabelOffsetX, "udLabelOffsetX");
            this.udLabelOffsetX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udLabelOffsetX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udLabelOffsetX.Name = "udLabelOffsetX";
            this.udLabelOffsetX.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // udLabelsBuffer
            // 
            resources.ApplyResources(this.udLabelsBuffer, "udLabelsBuffer");
            this.udLabelsBuffer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udLabelsBuffer.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udLabelsBuffer.Name = "udLabelsBuffer";
            this.udLabelsBuffer.ValueChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // optAlignBottomRight
            // 
            resources.ApplyResources(this.optAlignBottomRight, "optAlignBottomRight");
            this.optAlignBottomRight.Name = "optAlignBottomRight";
            this.optAlignBottomRight.TabStop = true;
            this.optAlignBottomRight.UseVisualStyleBackColor = true;
            this.optAlignBottomRight.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // lblLabelsOffsetY
            // 
            resources.ApplyResources(this.lblLabelsOffsetY, "lblLabelsOffsetY");
            this.lblLabelsOffsetY.Name = "lblLabelsOffsetY";
            // 
            // optAlignBottomCenter
            // 
            resources.ApplyResources(this.optAlignBottomCenter, "optAlignBottomCenter");
            this.optAlignBottomCenter.Name = "optAlignBottomCenter";
            this.optAlignBottomCenter.TabStop = true;
            this.optAlignBottomCenter.UseVisualStyleBackColor = true;
            this.optAlignBottomCenter.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // lblLabelsOffsetX
            // 
            resources.ApplyResources(this.lblLabelsOffsetX, "lblLabelsOffsetX");
            this.lblLabelsOffsetX.Name = "lblLabelsOffsetX";
            // 
            // optAlignBottomLeft
            // 
            resources.ApplyResources(this.optAlignBottomLeft, "optAlignBottomLeft");
            this.optAlignBottomLeft.Name = "optAlignBottomLeft";
            this.optAlignBottomLeft.TabStop = true;
            this.optAlignBottomLeft.UseVisualStyleBackColor = true;
            this.optAlignBottomLeft.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optAlignCenterRight
            // 
            resources.ApplyResources(this.optAlignCenterRight, "optAlignCenterRight");
            this.optAlignCenterRight.Name = "optAlignCenterRight";
            this.optAlignCenterRight.TabStop = true;
            this.optAlignCenterRight.UseVisualStyleBackColor = true;
            this.optAlignCenterRight.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optAlignCenter
            // 
            resources.ApplyResources(this.optAlignCenter, "optAlignCenter");
            this.optAlignCenter.Name = "optAlignCenter";
            this.optAlignCenter.TabStop = true;
            this.optAlignCenter.UseVisualStyleBackColor = true;
            this.optAlignCenter.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optAlignCenterLeft
            // 
            resources.ApplyResources(this.optAlignCenterLeft, "optAlignCenterLeft");
            this.optAlignCenterLeft.Name = "optAlignCenterLeft";
            this.optAlignCenterLeft.TabStop = true;
            this.optAlignCenterLeft.UseVisualStyleBackColor = true;
            this.optAlignCenterLeft.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optAlignTopRight
            // 
            resources.ApplyResources(this.optAlignTopRight, "optAlignTopRight");
            this.optAlignTopRight.Name = "optAlignTopRight";
            this.optAlignTopRight.TabStop = true;
            this.optAlignTopRight.UseVisualStyleBackColor = true;
            this.optAlignTopRight.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optAlignTopCenter
            // 
            resources.ApplyResources(this.optAlignTopCenter, "optAlignTopCenter");
            this.optAlignTopCenter.Name = "optAlignTopCenter";
            this.optAlignTopCenter.TabStop = true;
            this.optAlignTopCenter.UseVisualStyleBackColor = true;
            this.optAlignTopCenter.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optAlignTopLeft
            // 
            resources.ApplyResources(this.optAlignTopLeft, "optAlignTopLeft");
            this.optAlignTopLeft.Name = "optAlignTopLeft";
            this.optAlignTopLeft.TabStop = true;
            this.optAlignTopLeft.UseVisualStyleBackColor = true;
            this.optAlignTopLeft.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // groupBox11
            // 
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Controls.Add(this.txtLabelExpression);
            this.groupBox11.Controls.Add(this.btnLabelExpression);
            this.groupBox11.Controls.Add(this.btnClearLabelsExpression);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // txtLabelExpression
            // 
            resources.ApplyResources(this.txtLabelExpression, "txtLabelExpression");
            this.txtLabelExpression.Name = "txtLabelExpression";
            this.txtLabelExpression.ReadOnly = true;
            // 
            // btnLabelExpression
            // 
            resources.ApplyResources(this.btnLabelExpression, "btnLabelExpression");
            this.btnLabelExpression.Name = "btnLabelExpression";
            this.btnLabelExpression.UseVisualStyleBackColor = true;
            this.btnLabelExpression.Click += new System.EventHandler(this.OnLabelExpressionClick);
            // 
            // btnClearLabelsExpression
            // 
            resources.ApplyResources(this.btnClearLabelsExpression, "btnClearLabelsExpression");
            this.btnClearLabelsExpression.Name = "btnClearLabelsExpression";
            this.btnClearLabelsExpression.UseVisualStyleBackColor = true;
            this.btnClearLabelsExpression.Click += new System.EventHandler(this.OnClearLabelsExpressionClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.OnOkClick);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            // 
            // comboBox11
            // 
            resources.ApplyResources(this.comboBox11, "comboBox11");
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Name = "comboBox11";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // comboBox12
            // 
            resources.ApplyResources(this.comboBox12, "comboBox12");
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Name = "comboBox12";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // comboBox13
            // 
            resources.ApplyResources(this.comboBox13, "comboBox13");
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Name = "comboBox13";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // comboBox14
            // 
            resources.ApplyResources(this.comboBox14, "comboBox14");
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Name = "comboBox14";
            // 
            // comboBox15
            // 
            resources.ApplyResources(this.comboBox15, "comboBox15");
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Name = "comboBox15";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
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
            // pictureBox9
            // 
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            resources.ApplyResources(this.pictureBox10, "pictureBox10");
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabStop = false;
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.udFontSize2);
            this.groupBox6.Controls.Add(this.chkVisible);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.transparencyControl1);
            this.groupBox6.Controls.Add(this.udFontSize);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // udFontSize2
            // 
            resources.ApplyResources(this.udFontSize2, "udFontSize2");
            this.udFontSize2.Name = "udFontSize2";
            this.udFontSize2.ValueChanged += new System.EventHandler(this.UpdateSize);
            // 
            // chkVisible
            // 
            resources.ApplyResources(this.chkVisible, "chkVisible");
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // transparencyControl1
            // 
            resources.ApplyResources(this.transparencyControl1, "transparencyControl1");
            this.transparencyControl1.BandColor = System.Drawing.Color.Empty;
            this.transparencyControl1.Name = "transparencyControl1";
            this.transparencyControl1.Value = ((byte)(255));
            this.transparencyControl1.ValueChanged += new MW5.UI.Controls.TransparencyControl.ValueChangedDeleg(this.OnTransparencyControlValueChanged);
            // 
            // udFontSize
            // 
            resources.ApplyResources(this.udFontSize, "udFontSize");
            this.udFontSize.Name = "udFontSize";
            this.udFontSize.ValueChanged += new System.EventHandler(this.UpdateSize);
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnApplyClick);
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(402, 320);
            this.tabControlAdv1.Controls.Add(this.tabMain);
            this.tabControlAdv1.Controls.Add(this.tabExpression);
            this.tabControlAdv1.Controls.Add(this.tabPosition);
            this.tabControlAdv1.Controls.Add(this.tabVisibility);
            this.tabControlAdv1.Controls.Add(this.tabFont);
            this.tabControlAdv1.Controls.Add(this.tabFrame);
            this.tabControlAdv1.Name = "tabControlAdv1";
            // 
            // tabMain
            // 
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Controls.Add(this.groupBox20);
            this.tabMain.Controls.Add(this.chkLogScaleForSize);
            this.tabMain.Controls.Add(this.label22);
            this.tabMain.Controls.Add(this.chkUseVariableSize);
            this.tabMain.Controls.Add(this.cboField);
            this.tabMain.Controls.Add(this.label33);
            this.tabMain.Controls.Add(this.label24);
            this.tabMain.Controls.Add(this.label18);
            this.tabMain.Controls.Add(this.cboSortField);
            this.tabMain.Controls.Add(this.cboDecimalPlaces);
            this.tabMain.Controls.Add(this.chkSortAscending);
            this.tabMain.Image = null;
            this.tabMain.ImageSize = new System.Drawing.Size(16, 16);
            this.tabMain.Name = "tabMain";
            this.tabMain.ShowCloseButton = true;
            this.tabMain.ThemesEnabled = false;
            // 
            // groupBox20
            // 
            resources.ApplyResources(this.groupBox20, "groupBox20");
            this.groupBox20.Controls.Add(this.chkAviodCollisions);
            this.groupBox20.Controls.Add(this.chkLabelsRemoveDuplicates);
            this.groupBox20.Controls.Add(this.lblLabelVerticalPosition);
            this.groupBox20.Controls.Add(this.cboLabelsVerticalPosition);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.TabStop = false;
            // 
            // chkAviodCollisions
            // 
            resources.ApplyResources(this.chkAviodCollisions, "chkAviodCollisions");
            this.chkAviodCollisions.Name = "chkAviodCollisions";
            this.chkAviodCollisions.UseVisualStyleBackColor = true;
            // 
            // chkLabelsRemoveDuplicates
            // 
            resources.ApplyResources(this.chkLabelsRemoveDuplicates, "chkLabelsRemoveDuplicates");
            this.chkLabelsRemoveDuplicates.Name = "chkLabelsRemoveDuplicates";
            this.chkLabelsRemoveDuplicates.UseVisualStyleBackColor = true;
            // 
            // lblLabelVerticalPosition
            // 
            resources.ApplyResources(this.lblLabelVerticalPosition, "lblLabelVerticalPosition");
            this.lblLabelVerticalPosition.Name = "lblLabelVerticalPosition";
            // 
            // cboLabelsVerticalPosition
            // 
            resources.ApplyResources(this.cboLabelsVerticalPosition, "cboLabelsVerticalPosition");
            this.cboLabelsVerticalPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLabelsVerticalPosition.FormattingEnabled = true;
            this.cboLabelsVerticalPosition.Name = "cboLabelsVerticalPosition";
            // 
            // tabExpression
            // 
            resources.ApplyResources(this.tabExpression, "tabExpression");
            this.tabExpression.Controls.Add(this.groupBox10);
            this.tabExpression.Controls.Add(this.groupBox8);
            this.tabExpression.Controls.Add(this.groupBox9);
            this.tabExpression.Controls.Add(this.groupBox7);
            this.tabExpression.Controls.Add(this.btnClear);
            this.tabExpression.Controls.Add(this.btnPlus);
            this.tabExpression.Controls.Add(this.btnNewLine);
            this.tabExpression.Controls.Add(this.btnQuotes);
            this.tabExpression.Image = null;
            this.tabExpression.ImageSize = new System.Drawing.Size(16, 16);
            this.tabExpression.Name = "tabExpression";
            this.tabExpression.ShowCloseButton = true;
            this.tabExpression.ThemesEnabled = false;
            // 
            // tabPosition
            // 
            resources.ApplyResources(this.tabPosition, "tabPosition");
            this.tabPosition.Controls.Add(this.groupBoxPositioning);
            this.tabPosition.Controls.Add(this.groupBox13);
            this.tabPosition.Controls.Add(this.groupLabelAlignment);
            this.tabPosition.Image = null;
            this.tabPosition.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.ShowCloseButton = true;
            this.tabPosition.ThemesEnabled = false;
            // 
            // groupBoxPositioning
            // 
            resources.ApplyResources(this.groupBoxPositioning, "groupBoxPositioning");
            this.groupBoxPositioning.Controls.Add(this.chkLabelEveryPart);
            this.groupBoxPositioning.Controls.Add(this.cboLineOrientation);
            this.groupBoxPositioning.Controls.Add(this.label16);
            this.groupBoxPositioning.Controls.Add(this.optPosition4);
            this.groupBoxPositioning.Controls.Add(this.optPosition3);
            this.groupBoxPositioning.Controls.Add(this.optPosition2);
            this.groupBoxPositioning.Controls.Add(this.optPosition1);
            this.groupBoxPositioning.Name = "groupBoxPositioning";
            this.groupBoxPositioning.TabStop = false;
            // 
            // chkLabelEveryPart
            // 
            resources.ApplyResources(this.chkLabelEveryPart, "chkLabelEveryPart");
            this.chkLabelEveryPart.Name = "chkLabelEveryPart";
            this.chkLabelEveryPart.UseVisualStyleBackColor = true;
            this.chkLabelEveryPart.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // cboLineOrientation
            // 
            resources.ApplyResources(this.cboLineOrientation, "cboLineOrientation");
            this.cboLineOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineOrientation.FormattingEnabled = true;
            this.cboLineOrientation.Name = "cboLineOrientation";
            this.cboLineOrientation.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // optPosition4
            // 
            resources.ApplyResources(this.optPosition4, "optPosition4");
            this.optPosition4.Name = "optPosition4";
            this.optPosition4.UseVisualStyleBackColor = true;
            this.optPosition4.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optPosition3
            // 
            resources.ApplyResources(this.optPosition3, "optPosition3");
            this.optPosition3.Name = "optPosition3";
            this.optPosition3.UseVisualStyleBackColor = true;
            this.optPosition3.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optPosition2
            // 
            resources.ApplyResources(this.optPosition2, "optPosition2");
            this.optPosition2.Name = "optPosition2";
            this.optPosition2.UseVisualStyleBackColor = true;
            this.optPosition2.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // optPosition1
            // 
            resources.ApplyResources(this.optPosition1, "optPosition1");
            this.optPosition1.Checked = true;
            this.optPosition1.Name = "optPosition1";
            this.optPosition1.TabStop = true;
            this.optPosition1.UseVisualStyleBackColor = true;
            this.optPosition1.CheckedChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // groupBox13
            // 
            resources.ApplyResources(this.groupBox13, "groupBox13");
            this.groupBox13.Controls.Add(this.comboOffsetY);
            this.groupBox13.Controls.Add(this.comboOffsetX);
            this.groupBox13.Controls.Add(this.labelOffsetYField);
            this.groupBox13.Controls.Add(this.labelOffsetXField);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.TabStop = false;
            // 
            // comboOffsetY
            // 
            resources.ApplyResources(this.comboOffsetY, "comboOffsetY");
            this.comboOffsetY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOffsetY.FormattingEnabled = true;
            this.comboOffsetY.Name = "comboOffsetY";
            this.comboOffsetY.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // comboOffsetX
            // 
            resources.ApplyResources(this.comboOffsetX, "comboOffsetX");
            this.comboOffsetX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOffsetX.FormattingEnabled = true;
            this.comboOffsetX.Name = "comboOffsetX";
            this.comboOffsetX.SelectedIndexChanged += new System.EventHandler(this.Ui2LabelStyle);
            // 
            // labelOffsetYField
            // 
            resources.ApplyResources(this.labelOffsetYField, "labelOffsetYField");
            this.labelOffsetYField.Name = "labelOffsetYField";
            // 
            // labelOffsetXField
            // 
            resources.ApplyResources(this.labelOffsetXField, "labelOffsetXField");
            this.labelOffsetXField.Name = "labelOffsetXField";
            // 
            // tabVisibility
            // 
            resources.ApplyResources(this.tabVisibility, "tabVisibility");
            this.tabVisibility.Controls.Add(this.dynamicVisibilityControl1);
            this.tabVisibility.Controls.Add(this.groupBox11);
            this.tabVisibility.Image = null;
            this.tabVisibility.ImageSize = new System.Drawing.Size(16, 16);
            this.tabVisibility.Name = "tabVisibility";
            this.tabVisibility.ShowCloseButton = true;
            this.tabVisibility.ThemesEnabled = false;
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
            this.dynamicVisibilityControl1.ValueChanged += new System.EventHandler<System.EventArgs>(this.Ui2LabelStyle);
            // 
            // tabFont
            // 
            resources.ApplyResources(this.tabFont, "tabFont");
            this.tabFont.Controls.Add(this.groupBox5);
            this.tabFont.Controls.Add(this.groupBox3);
            this.tabFont.Image = null;
            this.tabFont.ImageSize = new System.Drawing.Size(16, 16);
            this.tabFont.Name = "tabFont";
            this.tabFont.ShowCloseButton = true;
            this.tabFont.ThemesEnabled = false;
            // 
            // tabFrame
            // 
            resources.ApplyResources(this.tabFrame, "tabFrame");
            this.tabFrame.Controls.Add(this.groupBox4);
            this.tabFrame.Controls.Add(this.chkUseFrame);
            this.tabFrame.Controls.Add(this.groupBox2);
            this.tabFrame.Image = null;
            this.tabFrame.ImageSize = new System.Drawing.Size(16, 16);
            this.tabFrame.Name = "tabFrame";
            this.tabFrame.ShowCloseButton = true;
            this.tabFrame.ThemesEnabled = false;
            // 
            // LabelStyleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelStyleForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.LabelStyleForm_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udShadowOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udShadowOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHaloSize)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFramePaddingY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFramePaddingX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupLabelAlignment.ResumeLayout(false);
            this.groupLabelAlignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLabelsBuffer)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tabExpression.ResumeLayout(false);
            this.tabPosition.ResumeLayout(false);
            this.groupBoxPositioning.ResumeLayout(false);
            this.groupBoxPositioning.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabVisibility.ResumeLayout(false);
            this.tabFont.ResumeLayout(false);
            this.tabFrame.ResumeLayout(false);
            this.tabFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFontName;
        private System.Windows.Forms.CheckBox chkFontStrikeout;
        private System.Windows.Forms.CheckBox chkFontUnderline;
        private System.Windows.Forms.CheckBox chkFontItalic;
        private System.Windows.Forms.CheckBox chkFontBold;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctPreview;
        private Office2007ColorPicker clpFont1;
        private Office2007ColorPicker clpFrame1;
        private ImageCombo icbFrameType;
        private System.Windows.Forms.CheckBox chkUseFrame;
        private System.Windows.Forms.Button btnSetFrameGradient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NumericUpDownEx udFramePaddingY;
        private NumericUpDownEx udFramePaddingX;
        private NumericUpDownEx udFontSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private ImageCombo icbLineWidth;
        private ImageCombo icbLineType;
        private Office2007ColorPicker clpFrameBorder;
        private System.Windows.Forms.GroupBox groupBox3;
        private NumericUpDownEx udShadowOffsetY;
        private NumericUpDownEx udShadowOffsetX;
        private NumericUpDownEx udHaloSize;
        private Office2007ColorPicker clpShadow;
        private Office2007ColorPicker clpHalo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkShadowVisible;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkHaloVisible;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private TransparencyControl transparencyControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNewLine;
        private System.Windows.Forms.Button btnQuotes;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox txtExpression;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.GroupBox groupLabelAlignment;
        private NumericUpDownEx udLabelOffsetY;
        private NumericUpDownEx udLabelOffsetX;
        private NumericUpDownEx udLabelsBuffer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton optAlignBottomRight;
        private System.Windows.Forms.Label lblLabelsOffsetY;
        private System.Windows.Forms.RadioButton optAlignBottomCenter;
        private System.Windows.Forms.Label lblLabelsOffsetX;
        private System.Windows.Forms.RadioButton optAlignBottomLeft;
        private System.Windows.Forms.RadioButton optAlignCenterRight;
        private System.Windows.Forms.RadioButton optAlignCenter;
        private System.Windows.Forms.RadioButton optAlignCenterLeft;
        private System.Windows.Forms.RadioButton optAlignTopRight;
        private System.Windows.Forms.RadioButton optAlignTopCenter;
        private System.Windows.Forms.RadioButton optAlignTopLeft;
        private System.Windows.Forms.Button btnClearLabelsExpression;
        private System.Windows.Forms.TextBox txtLabelExpression;
        private System.Windows.Forms.Button btnLabelExpression;
        private System.Windows.Forms.GroupBox groupBox11;
        protected System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cboTextRenderingHint;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboDecimalPlaces;
        private System.Windows.Forms.CheckBox chkSortAscending;
        private ComboBox cboSortField;
        private System.Windows.Forms.Label label24;
        private ComboBox cboField;
        private System.Windows.Forms.Label label22;
        private Label label33;
        private Label label36;
        private NumericUpDownEx udFontSize2;
        private CheckBox chkUseVariableSize;
        private CheckBox chkLogScaleForSize;
        private DynamicVisibilityControl dynamicVisibilityControl1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabMain;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabExpression;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPosition;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabVisibility;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabFont;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabFrame;
        private GroupBox groupBox13;
        private Label labelOffsetYField;
        private Label labelOffsetXField;
        private ComboBox comboOffsetY;
        private ComboBox comboOffsetX;
        private Button btnSetCurrent;
        private ComboBox cboBasicScale;
        private CheckBox chkScaleLabels;
        private GroupBox groupBox20;
        private CheckBox chkAviodCollisions;
        private CheckBox chkLabelsRemoveDuplicates;
        private Label lblLabelVerticalPosition;
        private ComboBox cboLabelsVerticalPosition;
        private GroupBox groupBoxPositioning;
        private CheckBox chkLabelEveryPart;
        private ComboBox cboLineOrientation;
        private Label label16;
        private RadioButton optPosition4;
        private RadioButton optPosition3;
        private RadioButton optPosition2;
        private RadioButton optPosition1;
    }
}