using MW5.Services.Controls;
using Syncfusion.Windows.Forms.Grid;

namespace MW5.Services.Views
{
    partial class MissingLayersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissingLayersView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.missingLayersGrid1 = new MW5.Services.Controls.MissingLayersGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.missingLayersGrid1)).BeginInit();
            this.SuspendLayout();
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
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // missingLayersGrid1
            // 
            resources.ApplyResources(this.missingLayersGrid1, "missingLayersGrid1");
            this.missingLayersGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.missingLayersGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.missingLayersGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.missingLayersGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.missingLayersGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.missingLayersGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.missingLayersGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.missingLayersGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.missingLayersGrid1.BrowseOnly = true;
            this.missingLayersGrid1.GridLineColor = System.Drawing.Color.White;
            this.missingLayersGrid1.Name = "missingLayersGrid1";
            this.missingLayersGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.missingLayersGrid1.ShowRowHeaders = false;
            this.missingLayersGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.missingLayersGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.missingLayersGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.None;
            this.missingLayersGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.missingLayersGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.missingLayersGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.missingLayersGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.missingLayersGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.missingLayersGrid1.UseRightToLeftCompatibleTextBox = true;
            this.missingLayersGrid1.VersionInfo = "5.0.1.0";
            this.missingLayersGrid1.WrapWithPanel = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MissingLayersView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.missingLayersGrid1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "MissingLayersView";
            ((System.ComponentModel.ISupportInitialize)(this.missingLayersGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private MissingLayersGrid missingLayersGrid1;
        private System.Windows.Forms.Label label1;
    }
}