namespace MW5.Views
{
    partial class AboutView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutView));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGdalVersion = new System.Windows.Forms.Label();
            this.lblOcxVersion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.assembliesGrid1 = new MW5.Controls.AssembliesGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboAssemblyFilter = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assembliesGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAssemblyFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(595, 321);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            // 
            // tabPageAdv1
            // 
            resources.ApplyResources(this.tabPageAdv1, "tabPageAdv1");
            this.tabPageAdv1.Controls.Add(this.pictureBox1);
            this.tabPageAdv1.Controls.Add(this.lblGdalVersion);
            this.tabPageAdv1.Controls.Add(this.lblOcxVersion);
            this.tabPageAdv1.Controls.Add(this.lblVersion);
            this.tabPageAdv1.Controls.Add(this.label4);
            this.tabPageAdv1.Controls.Add(this.label3);
            this.tabPageAdv1.Image = global::MW5.Properties.Resources.img_suntoongis_logo;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::MW5.Properties.Resources.img_suntoongis_view;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblGdalVersion
            // 
            resources.ApplyResources(this.lblGdalVersion, "lblGdalVersion");
            this.lblGdalVersion.Name = "lblGdalVersion";
            // 
            // lblOcxVersion
            // 
            resources.ApplyResources(this.lblOcxVersion, "lblOcxVersion");
            this.lblOcxVersion.Name = "lblOcxVersion";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabPageAdv2
            // 
            resources.ApplyResources(this.tabPageAdv2, "tabPageAdv2");
            this.tabPageAdv2.Controls.Add(this.assembliesGrid1);
            this.tabPageAdv2.Controls.Add(this.panel1);
            this.tabPageAdv2.Image = global::MW5.Properties.Resources.img_component32;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // assembliesGrid1
            // 
            resources.ApplyResources(this.assembliesGrid1, "assembliesGrid1");
            this.assembliesGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.assembliesGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.assembliesGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.assembliesGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.assembliesGrid1.BrowseOnly = true;
            this.assembliesGrid1.GridLineColor = System.Drawing.Color.White;
            this.assembliesGrid1.Name = "assembliesGrid1";
            this.assembliesGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.assembliesGrid1.ShowRowHeaders = false;
            this.assembliesGrid1.TableDescriptor.AllowEdit = false;
            this.assembliesGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.assembliesGrid1.TableOptions.AllowDropDownCell = false;
            this.assembliesGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.assembliesGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.assembliesGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.assembliesGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.assembliesGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.assembliesGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.assembliesGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.assembliesGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.assembliesGrid1.UseRightToLeftCompatibleTextBox = true;
            this.assembliesGrid1.VersionInfo = "5.0.1.0";
            this.assembliesGrid1.WrapWithPanel = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.cboAssemblyFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // cboAssemblyFilter
            // 
            resources.ApplyResources(this.cboAssemblyFilter, "cboAssemblyFilter");
            this.cboAssemblyFilter.BeforeTouchSize = new System.Drawing.Size(170, 21);
            this.cboAssemblyFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssemblyFilter.Name = "cboAssemblyFilter";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_options.png");
            // 
            // AboutView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "AboutView";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assembliesGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAssemblyFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private System.Windows.Forms.ImageList imageList1;
        private Controls.AssembliesGrid assembliesGrid1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboAssemblyFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGdalVersion;
        private System.Windows.Forms.Label lblOcxVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}