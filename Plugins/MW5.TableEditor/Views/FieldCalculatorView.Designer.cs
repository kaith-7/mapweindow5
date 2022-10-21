using MW5.Attributes.Controls;
using MW5.Data.Controls;

namespace MW5.Plugins.TableEditor.Views
{
    partial class FieldCalculatorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldCalculatorView));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.functionTreeView1 = new MW5.Plugins.TableEditor.Controls.FunctionTreeView();
            this.txtSearch = new MW5.UI.Controls.WatermarkTextbox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.btnMinus = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnMultiply = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClear = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnPlus = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDivide = new Syncfusion.Windows.Forms.ButtonAdv();
            this.fieldTypeGrid1 = new MW5.Attributes.Controls.FieldTypeGrid();
            this.btnTest = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.functionTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldTypeGrid1)).BeginInit();
            this.SuspendLayout();
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
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            // 
            // functionTreeView1
            // 
            resources.ApplyResources(this.functionTreeView1, "functionTreeView1");
            this.functionTreeView1.ApplyStyle = true;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.functionTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.functionTreeView1.BeforeTouchSize = new System.Drawing.Size(206, 301);
            // 
            // 
            // 
            this.functionTreeView1.HelpTextControl.AccessibleDescription = resources.GetString("functionTreeView1.HelpTextControl.AccessibleDescription");
            this.functionTreeView1.HelpTextControl.AccessibleName = resources.GetString("functionTreeView1.HelpTextControl.AccessibleName");
            this.functionTreeView1.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("functionTreeView1.HelpTextControl.Anchor")));
            this.functionTreeView1.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("functionTreeView1.HelpTextControl.AutoScroll")));
            this.functionTreeView1.HelpTextControl.AutoSize = ((bool)(resources.GetObject("functionTreeView1.HelpTextControl.AutoSize")));
            this.functionTreeView1.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("functionTreeView1.HelpTextControl.AutoSizeMode")));
            this.functionTreeView1.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("functionTreeView1.HelpTextControl.BackgroundImage")));
            this.functionTreeView1.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("functionTreeView1.HelpTextControl.BackgroundImageLayout")));
            this.functionTreeView1.HelpTextControl.BaseThemeName = null;
            this.functionTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functionTreeView1.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("functionTreeView1.HelpTextControl.Dock")));
            this.functionTreeView1.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("functionTreeView1.HelpTextControl.Font")));
            this.functionTreeView1.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("functionTreeView1.HelpTextControl.ImeMode")));
            this.functionTreeView1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("functionTreeView1.HelpTextControl.Location")));
            this.functionTreeView1.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("functionTreeView1.HelpTextControl.MaximumSize")));
            this.functionTreeView1.HelpTextControl.Name = "helpText";
            this.functionTreeView1.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("functionTreeView1.HelpTextControl.RightToLeft")));
            this.functionTreeView1.HelpTextControl.Size = ((System.Drawing.Size)(resources.GetObject("functionTreeView1.HelpTextControl.Size")));
            this.functionTreeView1.HelpTextControl.TabIndex = ((int)(resources.GetObject("functionTreeView1.HelpTextControl.TabIndex")));
            this.functionTreeView1.HelpTextControl.Text = resources.GetString("functionTreeView1.HelpTextControl.Text");
            this.functionTreeView1.HelpTextControl.Visible = ((bool)(resources.GetObject("functionTreeView1.HelpTextControl.Visible")));
            this.functionTreeView1.HideSelection = false;
            this.functionTreeView1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.functionTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.functionTreeView1.Name = "functionTreeView1";
            this.functionTreeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.functionTreeView1.ShowSuperTooltip = true;
            this.functionTreeView1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.functionTreeView1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.functionTreeView1.ToolTipControl.AccessibleDescription = resources.GetString("functionTreeView1.ToolTipControl.AccessibleDescription");
            this.functionTreeView1.ToolTipControl.AccessibleName = resources.GetString("functionTreeView1.ToolTipControl.AccessibleName");
            this.functionTreeView1.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("functionTreeView1.ToolTipControl.Anchor")));
            this.functionTreeView1.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("functionTreeView1.ToolTipControl.AutoScroll")));
            this.functionTreeView1.ToolTipControl.AutoSize = ((bool)(resources.GetObject("functionTreeView1.ToolTipControl.AutoSize")));
            this.functionTreeView1.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("functionTreeView1.ToolTipControl.AutoSizeMode")));
            this.functionTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.functionTreeView1.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("functionTreeView1.ToolTipControl.BackgroundImage")));
            this.functionTreeView1.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("functionTreeView1.ToolTipControl.BackgroundImageLayout")));
            this.functionTreeView1.ToolTipControl.BaseThemeName = null;
            this.functionTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functionTreeView1.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("functionTreeView1.ToolTipControl.Dock")));
            this.functionTreeView1.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("functionTreeView1.ToolTipControl.Font")));
            this.functionTreeView1.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("functionTreeView1.ToolTipControl.ImeMode")));
            this.functionTreeView1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("functionTreeView1.ToolTipControl.Location")));
            this.functionTreeView1.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("functionTreeView1.ToolTipControl.MaximumSize")));
            this.functionTreeView1.ToolTipControl.Name = "toolTip";
            this.functionTreeView1.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("functionTreeView1.ToolTipControl.RightToLeft")));
            this.functionTreeView1.ToolTipControl.Size = ((System.Drawing.Size)(resources.GetObject("functionTreeView1.ToolTipControl.Size")));
            this.functionTreeView1.ToolTipControl.TabIndex = ((int)(resources.GetObject("functionTreeView1.ToolTipControl.TabIndex")));
            this.functionTreeView1.ToolTipControl.Text = resources.GetString("functionTreeView1.ToolTipControl.Text");
            this.functionTreeView1.ToolTipControl.Visible = ((bool)(resources.GetObject("functionTreeView1.ToolTipControl.Visible")));
            this.functionTreeView1.ToolTipDuration = 5000;
            this.functionTreeView1.NodeMouseDoubleClick += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvMouseClickArgs(this.FunctionTreeView1DoubleClick);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(206, 21);
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FarImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.FarImage")));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.ThemeName = "Default";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblValidation
            // 
            resources.ApplyResources(this.lblValidation, "lblValidation");
            this.lblValidation.Name = "lblValidation";
            // 
            // txtExpression
            // 
            resources.ApplyResources(this.txtExpression, "txtExpression");
            this.txtExpression.HideSelection = false;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.TextChanged += new System.EventHandler(this.OnExpressionTextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblField
            // 
            resources.ApplyResources(this.lblField, "lblField");
            this.lblField.Name = "lblField";
            // 
            // btnMinus
            // 
            resources.ApplyResources(this.btnMinus, "btnMinus");
            this.btnMinus.BeforeTouchSize = new System.Drawing.Size(32, 21);
            this.btnMinus.Name = "btnMinus";
            // 
            // btnMultiply
            // 
            resources.ApplyResources(this.btnMultiply, "btnMultiply");
            this.btnMultiply.BeforeTouchSize = new System.Drawing.Size(32, 21);
            this.btnMultiply.Name = "btnMultiply";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlus
            // 
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.BeforeTouchSize = new System.Drawing.Size(32, 21);
            this.btnPlus.Name = "btnPlus";
            // 
            // btnDivide
            // 
            resources.ApplyResources(this.btnDivide, "btnDivide");
            this.btnDivide.BeforeTouchSize = new System.Drawing.Size(32, 21);
            this.btnDivide.Name = "btnDivide";
            // 
            // fieldTypeGrid1
            // 
            resources.ApplyResources(this.fieldTypeGrid1, "fieldTypeGrid1");
            this.fieldTypeGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.fieldTypeGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.fieldTypeGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldTypeGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldTypeGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldTypeGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldTypeGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.fieldTypeGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.fieldTypeGrid1.GridLineColor = System.Drawing.Color.White;
            this.fieldTypeGrid1.Name = "fieldTypeGrid1";
            this.fieldTypeGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.fieldTypeGrid1.ShowRowHeaders = false;
            this.fieldTypeGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.fieldTypeGrid1.TableOptions.AllowDropDownCell = true;
            this.fieldTypeGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.fieldTypeGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.fieldTypeGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.fieldTypeGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.fieldTypeGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.fieldTypeGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.fieldTypeGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.fieldTypeGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.fieldTypeGrid1.UseRightToLeftCompatibleTextBox = true;
            this.fieldTypeGrid1.VersionInfo = "0.0.1.0";
            this.fieldTypeGrid1.WrapWithPanel = true;
            // 
            // btnTest
            // 
            resources.ApplyResources(this.btnTest, "btnTest");
            this.btnTest.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.btnTest.Name = "btnTest";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // FieldCalculatorView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.fieldTypeGrid1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.lblValidation);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.functionTreeView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FieldCalculatorView";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FieldCalculatorView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.functionTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldTypeGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Controls.FunctionTreeView functionTreeView1;
        private UI.Controls.WatermarkTextbox txtSearch;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblField;
        private Syncfusion.Windows.Forms.ButtonAdv btnMinus;
        private Syncfusion.Windows.Forms.ButtonAdv btnMultiply;
        private Syncfusion.Windows.Forms.ButtonAdv btnClear;
        private Syncfusion.Windows.Forms.ButtonAdv btnPlus;
        private Syncfusion.Windows.Forms.ButtonAdv btnDivide;
        private FieldTypeGrid fieldTypeGrid1;
        private Syncfusion.Windows.Forms.ButtonAdv btnTest;
        private System.Windows.Forms.Label lblType;
    }
}