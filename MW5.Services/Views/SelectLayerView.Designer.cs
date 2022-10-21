using MW5.Services.Controls;

namespace MW5.Services.Views
{
    partial class SelectLayerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLayerView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.selectLayerGrid1 = new MW5.Services.Controls.SelectLayerGrid();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectLayerGrid1)).BeginInit();
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
            // selectLayerGrid1
            // 
            resources.ApplyResources(this.selectLayerGrid1, "selectLayerGrid1");
            this.selectLayerGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.selectLayerGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.selectLayerGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.selectLayerGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.selectLayerGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.selectLayerGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.selectLayerGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.selectLayerGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.selectLayerGrid1.GridLineColor = System.Drawing.Color.White;
            this.selectLayerGrid1.Name = "selectLayerGrid1";
            this.selectLayerGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.selectLayerGrid1.ShowRowHeaders = false;
            this.selectLayerGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.selectLayerGrid1.TableOptions.AllowDropDownCell = true;
            this.selectLayerGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.selectLayerGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.selectLayerGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.selectLayerGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectLayerGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.selectLayerGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.selectLayerGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.selectLayerGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.selectLayerGrid1.UseRightToLeftCompatibleTextBox = true;
            this.selectLayerGrid1.VersionInfo = "5.0.1.0";
            this.selectLayerGrid1.WrapWithPanel = true;
            // 
            // chkSelectAll
            // 
            resources.ApplyResources(this.chkSelectAll, "chkSelectAll");
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            // 
            // SelectLayerView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.selectLayerGrid1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "SelectLayerView";
            ((System.ComponentModel.ISupportInitialize)(this.selectLayerGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private SelectLayerGrid selectLayerGrid1;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}