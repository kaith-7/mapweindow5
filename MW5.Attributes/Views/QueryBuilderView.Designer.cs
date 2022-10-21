using MW5.Attributes.Controls;

namespace MW5.Attributes.Views
{
    partial class QueryBuilderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryBuilderView));
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valueCountGrid1 = new MW5.Attributes.Controls.ValueCountGrid();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldTypeGrid1 = new MW5.Attributes.Controls.FieldTypeGrid();
            this.chkShowValues = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowValues = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblValidation = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueCountGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldTypeGrid1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.Name = "btnRun";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // valueCountGrid1
            // 
            resources.ApplyResources(this.valueCountGrid1, "valueCountGrid1");
            this.valueCountGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.valueCountGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.valueCountGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.valueCountGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.valueCountGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.valueCountGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.valueCountGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.valueCountGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.valueCountGrid1.BrowseOnly = true;
            this.valueCountGrid1.GridLineColor = System.Drawing.Color.White;
            this.valueCountGrid1.Name = "valueCountGrid1";
            this.valueCountGrid1.ShowColumnHeaders = false;
            this.valueCountGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.valueCountGrid1.ShowRowHeaders = false;
            this.valueCountGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.valueCountGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.valueCountGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.valueCountGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.valueCountGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.valueCountGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.valueCountGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.valueCountGrid1.TopLevelGroupOptions.ShowColumnHeaders = false;
            this.valueCountGrid1.UseRightToLeftCompatibleTextBox = true;
            this.valueCountGrid1.VersionInfo = "5.0.1.0";
            this.valueCountGrid1.WrapWithPanel = true;
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.Tag = "";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // button12
            // 
            resources.ApplyResources(this.button12, "button12");
            this.button12.Name = "button12";
            this.button12.Tag = "";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.Name = "button11";
            this.button11.Tag = "";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // chkShowValues
            // 
            resources.ApplyResources(this.chkShowValues, "chkShowValues");
            this.chkShowValues.Name = "chkShowValues";
            this.chkShowValues.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.OnClearClicked);
            // 
            // btnShowValues
            // 
            resources.ApplyResources(this.btnShowValues, "btnShowValues");
            this.btnShowValues.Name = "btnShowValues";
            this.btnShowValues.UseVisualStyleBackColor = true;
            this.btnShowValues.Click += new System.EventHandler(this.OnShowValuesClicked);
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.Name = "button10";
            this.button10.Tag = "";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // btnTest
            // 
            resources.ApplyResources(this.btnTest, "btnTest");
            this.btnTest.Name = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.Tag = "";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // lblValidation
            // 
            resources.ApplyResources(this.lblValidation, "lblValidation");
            this.lblValidation.Name = "lblValidation";
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.Tag = "";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Name = "richTextBox1";
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.Tag = "";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.Tag = "";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.Tag = "";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.Tag = "";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.Tag = "";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Tag = "";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // button0
            // 
            resources.ApplyResources(this.button0, "button0");
            this.button0.Name = "button0";
            this.button0.Tag = "";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Tag = "";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // lblSelect
            // 
            resources.ApplyResources(this.lblSelect, "lblSelect");
            this.lblSelect.Name = "lblSelect";
            // 
            // QueryBuilderView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueCountGrid1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldTypeGrid1);
            this.Controls.Add(this.chkShowValues);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowValues);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lblValidation);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Name = "QueryBuilderView";
            ((System.ComponentModel.ISupportInitialize)(this.valueCountGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldTypeGrid1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.FieldTypeGrid fieldTypeGrid1;
        private System.Windows.Forms.CheckBox chkShowValues;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowValues;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private Controls.ValueCountGrid valueCountGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblSelect;
    }
}