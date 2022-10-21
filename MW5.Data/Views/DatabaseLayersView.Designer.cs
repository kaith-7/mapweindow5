using MW5.Data.Controls;

namespace MW5.Data.Views
{
    partial class DatabaseLayersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseLayersView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.databaseLayersGrid1 = new MW5.Data.Controls.DatabaseLayersGrid();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.lblConnection = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLayersGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 27);
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
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 27);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            // 
            // databaseLayersGrid1
            // 
            resources.ApplyResources(this.databaseLayersGrid1, "databaseLayersGrid1");
            this.databaseLayersGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.databaseLayersGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.databaseLayersGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.databaseLayersGrid1.GridLineColor = System.Drawing.Color.White;
            this.databaseLayersGrid1.Name = "databaseLayersGrid1";
            this.databaseLayersGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.databaseLayersGrid1.ShowRowHeaders = false;
            this.databaseLayersGrid1.UseRightToLeftCompatibleTextBox = true;
            this.databaseLayersGrid1.WrapWithPanel = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_point.png");
            this.imageList1.Images.SetKeyName(1, "img_line.png");
            this.imageList1.Images.SetKeyName(2, "img_polygon.png");
            this.imageList1.Images.SetKeyName(3, "img_geometry.png");
            // 
            // lblConnection
            // 
            resources.ApplyResources(this.lblConnection, "lblConnection");
            this.lblConnection.Name = "lblConnection";
            // 
            // chkSelectAll
            // 
            resources.ApplyResources(this.chkSelectAll, "chkSelectAll");
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.OnSelectAllChecked);
            // 
            // DatabaseLayersView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.databaseLayersGrid1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "DatabaseLayersView";
            ((System.ComponentModel.ISupportInitialize)(this.databaseLayersGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private DatabaseLayersGrid databaseLayersGrid1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}