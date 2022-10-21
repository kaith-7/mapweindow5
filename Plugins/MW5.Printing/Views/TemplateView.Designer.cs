namespace MW5.Plugins.Printing.Views
{
    partial class TemplateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateView));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabNewLayout = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnFitToPage = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboArea = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboFormat = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblMapArea = new System.Windows.Forms.Label();
            this.cboScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOrientation = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTemplates = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.templateGrid1 = new MW5.Plugins.Printing.Controls.TemplateGrid();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabNewLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrientation)).BeginInit();
            this.tabTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(460, 266);
            this.tabControlAdv1.Controls.Add(this.tabNewLayout);
            this.tabControlAdv1.Controls.Add(this.tabTemplates);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.OnTabChanged);
            // 
            // tabNewLayout
            // 
            resources.ApplyResources(this.tabNewLayout, "tabNewLayout");
            this.tabNewLayout.Controls.Add(this.btnFitToPage);
            this.tabNewLayout.Controls.Add(this.lblArea);
            this.tabNewLayout.Controls.Add(this.lblWarning);
            this.tabNewLayout.Controls.Add(this.lblPages);
            this.tabNewLayout.Controls.Add(this.label2);
            this.tabNewLayout.Controls.Add(this.cboArea);
            this.tabNewLayout.Controls.Add(this.cboFormat);
            this.tabNewLayout.Controls.Add(this.lblMapArea);
            this.tabNewLayout.Controls.Add(this.cboScale);
            this.tabNewLayout.Controls.Add(this.label4);
            this.tabNewLayout.Controls.Add(this.cboOrientation);
            this.tabNewLayout.Controls.Add(this.label3);
            this.tabNewLayout.Image = null;
            this.tabNewLayout.ImageSize = new System.Drawing.Size(16, 16);
            this.tabNewLayout.Name = "tabNewLayout";
            this.tabNewLayout.ShowCloseButton = true;
            this.tabNewLayout.ThemesEnabled = false;
            // 
            // btnFitToPage
            // 
            resources.ApplyResources(this.btnFitToPage, "btnFitToPage");
            this.btnFitToPage.BeforeTouchSize = new System.Drawing.Size(78, 21);
            this.btnFitToPage.Name = "btnFitToPage";
            // 
            // lblArea
            // 
            resources.ApplyResources(this.lblArea, "lblArea");
            this.lblArea.Name = "lblArea";
            // 
            // lblWarning
            // 
            resources.ApplyResources(this.lblWarning, "lblWarning");
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Name = "lblWarning";
            // 
            // lblPages
            // 
            resources.ApplyResources(this.lblPages, "lblPages");
            this.lblPages.Name = "lblPages";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboArea
            // 
            resources.ApplyResources(this.cboArea, "cboArea");
            this.cboArea.BeforeTouchSize = new System.Drawing.Size(226, 21);
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Name = "cboArea";
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.OnAreaChanged);
            // 
            // cboFormat
            // 
            resources.ApplyResources(this.cboFormat, "cboFormat");
            this.cboFormat.BeforeTouchSize = new System.Drawing.Size(226, 21);
            this.cboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormat.Name = "cboFormat";
            // 
            // lblMapArea
            // 
            resources.ApplyResources(this.lblMapArea, "lblMapArea");
            this.lblMapArea.Name = "lblMapArea";
            // 
            // cboScale
            // 
            resources.ApplyResources(this.cboScale, "cboScale");
            this.cboScale.BeforeTouchSize = new System.Drawing.Size(226, 21);
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.Name = "cboScale";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cboOrientation
            // 
            resources.ApplyResources(this.cboOrientation, "cboOrientation");
            this.cboOrientation.BeforeTouchSize = new System.Drawing.Size(316, 21);
            this.cboOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrientation.Name = "cboOrientation";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabTemplates
            // 
            resources.ApplyResources(this.tabTemplates, "tabTemplates");
            this.tabTemplates.Controls.Add(this.templateGrid1);
            this.tabTemplates.Image = null;
            this.tabTemplates.ImageSize = new System.Drawing.Size(16, 16);
            this.tabTemplates.Name = "tabTemplates";
            this.tabTemplates.ShowCloseButton = true;
            this.tabTemplates.ThemesEnabled = false;
            // 
            // templateGrid1
            // 
            resources.ApplyResources(this.templateGrid1, "templateGrid1");
            this.templateGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.templateGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.templateGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.templateGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.templateGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.templateGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.templateGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.templateGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.templateGrid1.GridLineColor = System.Drawing.Color.White;
            this.templateGrid1.Name = "templateGrid1";
            this.templateGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.templateGrid1.ShowRowHeaders = false;
            this.templateGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.templateGrid1.TableOptions.AllowDropDownCell = false;
            this.templateGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.templateGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.templateGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.templateGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.templateGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.templateGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.templateGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.templateGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.templateGrid1.UseRightToLeftCompatibleTextBox = true;
            this.templateGrid1.VersionInfo = "0.0.1.0";
            this.templateGrid1.WrapWithPanel = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(81, 24);
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
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(84, 24);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            // 
            // TemplateView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "TemplateView";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabNewLayout.ResumeLayout(false);
            this.tabNewLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrientation)).EndInit();
            this.tabTemplates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.templateGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabTemplates;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabNewLayout;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboScale;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboOrientation;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboArea;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboFormat;
        private System.Windows.Forms.Label lblMapArea;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblArea;
        private Controls.TemplateGrid templateGrid1;
        private Syncfusion.Windows.Forms.ButtonAdv btnFitToPage;
    }
}