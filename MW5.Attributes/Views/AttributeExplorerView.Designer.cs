namespace MW5.Attributes.Views
{
    partial class AttributeExplorerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeExplorerView));
            this.label2 = new System.Windows.Forms.Label();
            this.valueCountGrid1 = new MW5.Attributes.Controls.ValueCountGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cboField = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkZoomTo = new System.Windows.Forms.CheckBox();
            this.recordNavigationBar1 = new Syncfusion.Windows.Forms.RecordNavigationBar();
            this.txtSearch = new MW5.UI.Controls.WatermarkTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.valueCountGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
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
            this.toolTip1.SetToolTip(this.valueCountGrid1, resources.GetString("valueCountGrid1.ToolTip"));
            this.valueCountGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.valueCountGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.valueCountGrid1.TopLevelGroupOptions.ShowColumnHeaders = false;
            this.valueCountGrid1.UseRightToLeftCompatibleTextBox = true;
            this.valueCountGrid1.VersionInfo = "5.0.1.0";
            this.valueCountGrid1.WrapWithPanel = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // cboField
            // 
            resources.ApplyResources(this.cboField, "cboField");
            this.cboField.BeforeTouchSize = new System.Drawing.Size(395, 21);
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.Name = "cboField";
            this.toolTip1.SetToolTip(this.cboField, resources.GetString("cboField.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.toolTip1.SetToolTip(this.btnClose, resources.GetString("btnClose.ToolTip"));
            // 
            // chkZoomTo
            // 
            resources.ApplyResources(this.chkZoomTo, "chkZoomTo");
            this.chkZoomTo.Checked = true;
            this.chkZoomTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZoomTo.Name = "chkZoomTo";
            this.toolTip1.SetToolTip(this.chkZoomTo, resources.GetString("chkZoomTo.ToolTip"));
            this.chkZoomTo.UseVisualStyleBackColor = true;
            this.chkZoomTo.CheckedChanged += new System.EventHandler(this.OnZoomToChanged);
            // 
            // recordNavigationBar1
            // 
            resources.ApplyResources(this.recordNavigationBar1, "recordNavigationBar1");
            this.recordNavigationBar1.AllowAddNew = false;
            this.recordNavigationBar1.ButtonLook = Syncfusion.Windows.Forms.ButtonLook.Flat;
            this.recordNavigationBar1.CausesValidation = false;
            this.recordNavigationBar1.DisplayArrowButtons = Syncfusion.Windows.Forms.DisplayArrowButtons.All;
            this.recordNavigationBar1.Label = "Feature";
            this.recordNavigationBar1.MaxLabel = "of 20";
            this.recordNavigationBar1.MaxRecord = 20;
            this.recordNavigationBar1.Name = "recordNavigationBar1";
            this.recordNavigationBar1.SizeToFit = false;
            this.recordNavigationBar1.ThemesEnabled = true;
            this.toolTip1.SetToolTip(this.recordNavigationBar1, resources.GetString("recordNavigationBar1.ToolTip"));
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(395, 21);
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FarImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.FarImage")));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.ThemeName = "Default";
            this.toolTip1.SetToolTip(this.txtSearch, resources.GetString("txtSearch.ToolTip"));
            this.txtSearch.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
            // 
            // AttributeExplorerView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.recordNavigationBar1);
            this.Controls.Add(this.chkZoomTo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueCountGrid1);
            this.Controls.Add(this.label1);
            this.Name = "AttributeExplorerView";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.valueCountGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Controls.ValueCountGrid valueCountGrid1;
        private System.Windows.Forms.Label label1;
        private UI.Controls.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboField;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private System.Windows.Forms.CheckBox chkZoomTo;
        private Syncfusion.Windows.Forms.RecordNavigationBar recordNavigationBar1;
    }
}