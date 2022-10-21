using MW5.Attributes.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Attributes.Views
{
    partial class JoinTableView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinTableView));
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupKeys = new System.Windows.Forms.GroupBox();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblMatchJoin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurrent = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboExternal = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldsGrid1 = new MW5.Attributes.Controls.FieldsGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDatasource = new MW5.UI.Controls.WatermarkTextbox();
            this.btnOpen = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOptions = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblOptions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOptions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAll
            // 
            resources.ApplyResources(this.chkAll, "chkAll");
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Name = "chkAll";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // groupKeys
            // 
            resources.ApplyResources(this.groupKeys, "groupKeys");
            this.groupKeys.Controls.Add(this.lblMatch);
            this.groupKeys.Controls.Add(this.lblMatchJoin);
            this.groupKeys.Controls.Add(this.label5);
            this.groupKeys.Controls.Add(this.label4);
            this.groupKeys.Controls.Add(this.cboCurrent);
            this.groupKeys.Controls.Add(this.cboExternal);
            this.groupKeys.Controls.Add(this.label3);
            this.groupKeys.Name = "groupKeys";
            this.groupKeys.TabStop = false;
            // 
            // lblMatch
            // 
            resources.ApplyResources(this.lblMatch, "lblMatch");
            this.lblMatch.Name = "lblMatch";
            // 
            // lblMatchJoin
            // 
            resources.ApplyResources(this.lblMatchJoin, "lblMatchJoin");
            this.lblMatchJoin.Name = "lblMatchJoin";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cboCurrent
            // 
            resources.ApplyResources(this.cboCurrent, "cboCurrent");
            this.cboCurrent.BeforeTouchSize = new System.Drawing.Size(158, 21);
            this.cboCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrent.Name = "cboCurrent";
            // 
            // cboExternal
            // 
            resources.ApplyResources(this.cboExternal, "cboExternal");
            this.cboExternal.BeforeTouchSize = new System.Drawing.Size(158, 21);
            this.cboExternal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExternal.Name = "cboExternal";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // fieldsGrid1
            // 
            resources.ApplyResources(this.fieldsGrid1, "fieldsGrid1");
            this.fieldsGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.fieldsGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.fieldsGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.fieldsGrid1.GridLineColor = System.Drawing.Color.White;
            this.fieldsGrid1.Name = "fieldsGrid1";
            this.fieldsGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.fieldsGrid1.ShowRowHeaders = false;
            this.fieldsGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.fieldsGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.fieldsGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.fieldsGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.fieldsGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.fieldsGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.fieldsGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.fieldsGrid1.UseRightToLeftCompatibleTextBox = true;
            this.fieldsGrid1.VersionInfo = "0.0.1.0";
            this.fieldsGrid1.WrapWithPanel = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txtDatasource);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboOptions);
            this.groupBox2.Controls.Add(this.lblOptions);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtDatasource
            // 
            resources.ApplyResources(this.txtDatasource, "txtDatasource");
            this.txtDatasource.BeforeTouchSize = new System.Drawing.Size(395, 21);
            this.txtDatasource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatasource.Name = "txtDatasource";
            this.txtDatasource.ReadOnly = true;
            this.txtDatasource.ShowClearButton = false;
            this.txtDatasource.ThemeName = "Default";
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.BeforeTouchSize = new System.Drawing.Size(53, 21);
            this.btnOpen.Name = "btnOpen";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cboOptions
            // 
            resources.ApplyResources(this.cboOptions, "cboOptions");
            this.cboOptions.BeforeTouchSize = new System.Drawing.Size(277, 21);
            this.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOptions.Name = "cboOptions";
            // 
            // lblOptions
            // 
            resources.ApplyResources(this.lblOptions, "lblOptions");
            this.lblOptions.Name = "lblOptions";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fieldsGrid1);
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // JoinTableView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupKeys);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "JoinTableView";
            this.groupKeys.ResumeLayout(false);
            this.groupKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOptions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAll;
        private ButtonAdv btnCancel;
        private ButtonAdv btnOk;
        private System.Windows.Forms.GroupBox groupKeys;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblMatchJoin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ComboBoxAdv cboCurrent;
        private ComboBoxAdv cboExternal;
        private System.Windows.Forms.Label label3;
        private FieldsGrid fieldsGrid1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ButtonAdv btnOpen;
        private System.Windows.Forms.Label label6;
        private ComboBoxAdv cboOptions;
        private System.Windows.Forms.Label lblOptions;
        private UI.Controls.WatermarkTextbox txtDatasource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}