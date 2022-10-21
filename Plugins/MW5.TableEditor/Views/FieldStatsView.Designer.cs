namespace MW5.Plugins.TableEditor.Views
{
    partial class FieldStatsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldStatsView));
            this.cboField = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCopy = new Syncfusion.Windows.Forms.ButtonAdv();
            this.fieldStatsGrid1 = new MW5.Plugins.TableEditor.Controls.FieldStatsGrid();
            ((System.ComponentModel.ISupportInitialize)(this.cboField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldStatsGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboField
            // 
            resources.ApplyResources(this.cboField, "cboField");
            this.cboField.BeforeTouchSize = new System.Drawing.Size(223, 21);
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.Name = "cboField";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(75, 24);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.BeforeTouchSize = new System.Drawing.Size(75, 24);
            this.btnCopy.Name = "btnCopy";
            // 
            // fieldStatsGrid1
            // 
            resources.ApplyResources(this.fieldStatsGrid1, "fieldStatsGrid1");
            this.fieldStatsGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.fieldStatsGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.fieldStatsGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldStatsGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldStatsGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldStatsGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.fieldStatsGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.fieldStatsGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.fieldStatsGrid1.BrowseOnly = true;
            this.fieldStatsGrid1.GridLineColor = System.Drawing.Color.White;
            this.fieldStatsGrid1.Name = "fieldStatsGrid1";
            this.fieldStatsGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.fieldStatsGrid1.ShowRowHeaders = false;
            this.fieldStatsGrid1.TableDescriptor.AllowEdit = false;
            this.fieldStatsGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.fieldStatsGrid1.TableOptions.AllowDropDownCell = false;
            this.fieldStatsGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.fieldStatsGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.fieldStatsGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.fieldStatsGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.fieldStatsGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.fieldStatsGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.fieldStatsGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.fieldStatsGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.fieldStatsGrid1.UseRightToLeftCompatibleTextBox = true;
            this.fieldStatsGrid1.VersionInfo = "0.0.1.0";
            this.fieldStatsGrid1.WrapWithPanel = true;
            // 
            // FieldStatsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.fieldStatsGrid1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboField);
            this.Name = "FieldStatsView";
            ((System.ComponentModel.ISupportInitialize)(this.cboField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldStatsGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboField;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.ButtonAdv btnCopy;
        private Controls.FieldStatsGrid fieldStatsGrid1;
    }
}