using MW5.Data.Controls;

namespace MW5.Data.Views
{
    partial class DriversView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversView));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.driversTreeView1 = new MW5.Data.Controls.DriversTreeView();
            this.txtSearch = new MW5.UI.Controls.WatermarkTextbox();
            this._driverMetadataGrid1 = new MW5.Data.Controls.DriverMetadataGrid();
            this.lblCount = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabGeneral = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabCreationOptions = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gridCreationOptions = new MW5.Data.Controls.DriverOptionsGrid();
            this.tabOpenOptions = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gridOpenOptions = new MW5.Data.Controls.DriverOptionsGrid();
            this.tabLayerOptions = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gridLayerOptions = new MW5.Data.Controls.DriverOptionsGrid();
            this.cboFilter = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.driversTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._driverMetadataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabCreationOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreationOptions)).BeginInit();
            this.tabOpenOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOpenOptions)).BeginInit();
            this.tabLayerOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayerOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // driversTreeView1
            // 
            resources.ApplyResources(this.driversTreeView1, "driversTreeView1");
            this.driversTreeView1.ApplyStyle = true;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.driversTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.driversTreeView1.BeforeTouchSize = new System.Drawing.Size(228, 388);
            this.driversTreeView1.BorderColor = System.Drawing.Color.LightGray;
            this.driversTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.driversTreeView1.HelpTextControl.AccessibleDescription = resources.GetString("driversTreeView1.HelpTextControl.AccessibleDescription");
            this.driversTreeView1.HelpTextControl.AccessibleName = resources.GetString("driversTreeView1.HelpTextControl.AccessibleName");
            this.driversTreeView1.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("driversTreeView1.HelpTextControl.Anchor")));
            this.driversTreeView1.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("driversTreeView1.HelpTextControl.AutoScroll")));
            this.driversTreeView1.HelpTextControl.AutoSize = ((bool)(resources.GetObject("driversTreeView1.HelpTextControl.AutoSize")));
            this.driversTreeView1.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("driversTreeView1.HelpTextControl.AutoSizeMode")));
            this.driversTreeView1.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("driversTreeView1.HelpTextControl.BackgroundImage")));
            this.driversTreeView1.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("driversTreeView1.HelpTextControl.BackgroundImageLayout")));
            this.driversTreeView1.HelpTextControl.BaseThemeName = null;
            this.driversTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driversTreeView1.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("driversTreeView1.HelpTextControl.Dock")));
            this.driversTreeView1.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("driversTreeView1.HelpTextControl.Font")));
            this.driversTreeView1.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("driversTreeView1.HelpTextControl.ImeMode")));
            this.driversTreeView1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("driversTreeView1.HelpTextControl.Location")));
            this.driversTreeView1.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("driversTreeView1.HelpTextControl.MaximumSize")));
            this.driversTreeView1.HelpTextControl.Name = "helpText";
            this.driversTreeView1.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("driversTreeView1.HelpTextControl.RightToLeft")));
            this.driversTreeView1.HelpTextControl.Size = ((System.Drawing.Size)(resources.GetObject("driversTreeView1.HelpTextControl.Size")));
            this.driversTreeView1.HelpTextControl.TabIndex = ((int)(resources.GetObject("driversTreeView1.HelpTextControl.TabIndex")));
            this.driversTreeView1.HelpTextControl.Text = resources.GetString("driversTreeView1.HelpTextControl.Text");
            this.driversTreeView1.HelpTextControl.Visible = ((bool)(resources.GetObject("driversTreeView1.HelpTextControl.Visible")));
            this.driversTreeView1.HideSelection = false;
            this.driversTreeView1.InactiveSelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.driversTreeView1.InactiveSelectedNodeForeColor = System.Drawing.Color.White;
            this.driversTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.driversTreeView1.Name = "driversTreeView1";
            this.driversTreeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.driversTreeView1.ShowSuperTooltip = false;
            this.driversTreeView1.ShowToolTip = false;
            this.driversTreeView1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.driversTreeView1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.driversTreeView1.ToolTipControl.AccessibleDescription = resources.GetString("driversTreeView1.ToolTipControl.AccessibleDescription");
            this.driversTreeView1.ToolTipControl.AccessibleName = resources.GetString("driversTreeView1.ToolTipControl.AccessibleName");
            this.driversTreeView1.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("driversTreeView1.ToolTipControl.Anchor")));
            this.driversTreeView1.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("driversTreeView1.ToolTipControl.AutoScroll")));
            this.driversTreeView1.ToolTipControl.AutoSize = ((bool)(resources.GetObject("driversTreeView1.ToolTipControl.AutoSize")));
            this.driversTreeView1.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("driversTreeView1.ToolTipControl.AutoSizeMode")));
            this.driversTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.driversTreeView1.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("driversTreeView1.ToolTipControl.BackgroundImage")));
            this.driversTreeView1.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("driversTreeView1.ToolTipControl.BackgroundImageLayout")));
            this.driversTreeView1.ToolTipControl.BaseThemeName = null;
            this.driversTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driversTreeView1.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("driversTreeView1.ToolTipControl.Dock")));
            this.driversTreeView1.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("driversTreeView1.ToolTipControl.Font")));
            this.driversTreeView1.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("driversTreeView1.ToolTipControl.ImeMode")));
            this.driversTreeView1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("driversTreeView1.ToolTipControl.Location")));
            this.driversTreeView1.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("driversTreeView1.ToolTipControl.MaximumSize")));
            this.driversTreeView1.ToolTipControl.Name = "toolTip";
            this.driversTreeView1.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("driversTreeView1.ToolTipControl.RightToLeft")));
            this.driversTreeView1.ToolTipControl.Size = ((System.Drawing.Size)(resources.GetObject("driversTreeView1.ToolTipControl.Size")));
            this.driversTreeView1.ToolTipControl.TabIndex = ((int)(resources.GetObject("driversTreeView1.ToolTipControl.TabIndex")));
            this.driversTreeView1.ToolTipControl.Text = resources.GetString("driversTreeView1.ToolTipControl.Text");
            this.driversTreeView1.ToolTipControl.Visible = ((bool)(resources.GetObject("driversTreeView1.ToolTipControl.Visible")));
            this.driversTreeView1.ToolTipDuration = 0;
            this.driversTreeView1.AfterSelect += new System.EventHandler(this.DriverAfterSelect);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(528, 21);
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FarImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.FarImage")));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSearch.ThemeName = "Metro";
            this.txtSearch.ThemesEnabled = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // _driverMetadataGrid1
            // 
            resources.ApplyResources(this._driverMetadataGrid1, "_driverMetadataGrid1");
            this._driverMetadataGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this._driverMetadataGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this._driverMetadataGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._driverMetadataGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._driverMetadataGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._driverMetadataGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._driverMetadataGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this._driverMetadataGrid1.BackColor = System.Drawing.SystemColors.Window;
            this._driverMetadataGrid1.BrowseOnly = true;
            this._driverMetadataGrid1.GridLineColor = System.Drawing.Color.White;
            this._driverMetadataGrid1.Name = "_driverMetadataGrid1";
            this._driverMetadataGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this._driverMetadataGrid1.ShowRowHeaders = false;
            this._driverMetadataGrid1.TableDescriptor.AllowEdit = false;
            this._driverMetadataGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this._driverMetadataGrid1.TableOptions.AllowDropDownCell = false;
            this._driverMetadataGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this._driverMetadataGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this._driverMetadataGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this._driverMetadataGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this._driverMetadataGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this._driverMetadataGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this._driverMetadataGrid1.TopLevelGroupOptions.ShowCaption = false;
            this._driverMetadataGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this._driverMetadataGrid1.UseRightToLeftCompatibleTextBox = true;
            this._driverMetadataGrid1.VersionInfo = "5.0.1.0";
            this._driverMetadataGrid1.WrapWithPanel = false;
            // 
            // lblCount
            // 
            resources.ApplyResources(this.lblCount, "lblCount");
            this.lblCount.Name = "lblCount";
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(566, 388);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.Controls.Add(this.tabGeneral);
            this.tabControlAdv1.Controls.Add(this.tabCreationOptions);
            this.tabControlAdv1.Controls.Add(this.tabOpenOptions);
            this.tabControlAdv1.Controls.Add(this.tabLayerOptions);
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendDark);
            this.tabControlAdv1.ThemeName = "TabRendererBlendDark";
            // 
            // tabGeneral
            // 
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Controls.Add(this._driverMetadataGrid1);
            this.tabGeneral.Image = null;
            this.tabGeneral.ImageSize = new System.Drawing.Size(16, 16);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.ShowCloseButton = true;
            this.tabGeneral.ThemesEnabled = false;
            // 
            // tabCreationOptions
            // 
            resources.ApplyResources(this.tabCreationOptions, "tabCreationOptions");
            this.tabCreationOptions.Controls.Add(this.gridCreationOptions);
            this.tabCreationOptions.Image = null;
            this.tabCreationOptions.ImageSize = new System.Drawing.Size(16, 16);
            this.tabCreationOptions.Name = "tabCreationOptions";
            this.tabCreationOptions.ShowCloseButton = true;
            this.tabCreationOptions.ThemesEnabled = false;
            // 
            // gridCreationOptions
            // 
            resources.ApplyResources(this.gridCreationOptions, "gridCreationOptions");
            this.gridCreationOptions.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.gridCreationOptions.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridCreationOptions.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridCreationOptions.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridCreationOptions.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridCreationOptions.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridCreationOptions.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridCreationOptions.BackColor = System.Drawing.SystemColors.Window;
            this.gridCreationOptions.BrowseOnly = true;
            this.gridCreationOptions.GridLineColor = System.Drawing.Color.White;
            this.gridCreationOptions.Name = "gridCreationOptions";
            this.gridCreationOptions.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.gridCreationOptions.ShowRowHeaders = false;
            this.gridCreationOptions.TableDescriptor.AllowEdit = false;
            this.gridCreationOptions.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.gridCreationOptions.TableOptions.AllowDropDownCell = false;
            this.gridCreationOptions.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.gridCreationOptions.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.gridCreationOptions.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.gridCreationOptions.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gridCreationOptions.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.gridCreationOptions.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridCreationOptions.TopLevelGroupOptions.ShowCaption = false;
            this.gridCreationOptions.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.gridCreationOptions.UseRightToLeftCompatibleTextBox = true;
            this.gridCreationOptions.VersionInfo = "5.0.1.0";
            this.gridCreationOptions.WrapWithPanel = false;
            // 
            // tabOpenOptions
            // 
            resources.ApplyResources(this.tabOpenOptions, "tabOpenOptions");
            this.tabOpenOptions.Controls.Add(this.gridOpenOptions);
            this.tabOpenOptions.Image = null;
            this.tabOpenOptions.ImageSize = new System.Drawing.Size(16, 16);
            this.tabOpenOptions.Name = "tabOpenOptions";
            this.tabOpenOptions.ShowCloseButton = true;
            this.tabOpenOptions.ThemesEnabled = false;
            // 
            // gridOpenOptions
            // 
            resources.ApplyResources(this.gridOpenOptions, "gridOpenOptions");
            this.gridOpenOptions.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.gridOpenOptions.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridOpenOptions.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridOpenOptions.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridOpenOptions.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridOpenOptions.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridOpenOptions.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridOpenOptions.BackColor = System.Drawing.SystemColors.Window;
            this.gridOpenOptions.BrowseOnly = true;
            this.gridOpenOptions.GridLineColor = System.Drawing.Color.White;
            this.gridOpenOptions.Name = "gridOpenOptions";
            this.gridOpenOptions.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.gridOpenOptions.ShowRowHeaders = false;
            this.gridOpenOptions.TableDescriptor.AllowEdit = false;
            this.gridOpenOptions.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.gridOpenOptions.TableOptions.AllowDropDownCell = false;
            this.gridOpenOptions.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.gridOpenOptions.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.gridOpenOptions.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.gridOpenOptions.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gridOpenOptions.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.gridOpenOptions.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridOpenOptions.TopLevelGroupOptions.ShowCaption = false;
            this.gridOpenOptions.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.gridOpenOptions.UseRightToLeftCompatibleTextBox = true;
            this.gridOpenOptions.VersionInfo = "5.0.1.0";
            this.gridOpenOptions.WrapWithPanel = false;
            // 
            // tabLayerOptions
            // 
            resources.ApplyResources(this.tabLayerOptions, "tabLayerOptions");
            this.tabLayerOptions.Controls.Add(this.gridLayerOptions);
            this.tabLayerOptions.Image = null;
            this.tabLayerOptions.ImageSize = new System.Drawing.Size(16, 16);
            this.tabLayerOptions.Name = "tabLayerOptions";
            this.tabLayerOptions.ShowCloseButton = true;
            this.tabLayerOptions.ThemesEnabled = false;
            // 
            // gridLayerOptions
            // 
            resources.ApplyResources(this.gridLayerOptions, "gridLayerOptions");
            this.gridLayerOptions.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.gridLayerOptions.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridLayerOptions.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridLayerOptions.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridLayerOptions.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridLayerOptions.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.gridLayerOptions.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridLayerOptions.BackColor = System.Drawing.SystemColors.Window;
            this.gridLayerOptions.BrowseOnly = true;
            this.gridLayerOptions.GridLineColor = System.Drawing.Color.White;
            this.gridLayerOptions.Name = "gridLayerOptions";
            this.gridLayerOptions.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.gridLayerOptions.ShowRowHeaders = false;
            this.gridLayerOptions.TableDescriptor.AllowEdit = false;
            this.gridLayerOptions.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.gridLayerOptions.TableOptions.AllowDropDownCell = false;
            this.gridLayerOptions.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.gridLayerOptions.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.gridLayerOptions.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.gridLayerOptions.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gridLayerOptions.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.gridLayerOptions.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridLayerOptions.TopLevelGroupOptions.ShowCaption = false;
            this.gridLayerOptions.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.gridLayerOptions.UseRightToLeftCompatibleTextBox = true;
            this.gridLayerOptions.VersionInfo = "5.0.1.0";
            this.gridLayerOptions.WrapWithPanel = false;
            // 
            // cboFilter
            // 
            resources.ApplyResources(this.cboFilter, "cboFilter");
            this.cboFilter.BeforeTouchSize = new System.Drawing.Size(259, 21);
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Name = "cboFilter";
            // 
            // DriversView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.driversTreeView1);
            this.Controls.Add(this.btnClose);
            this.Name = "DriversView";
            ((System.ComponentModel.ISupportInitialize)(this.driversTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._driverMetadataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabCreationOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCreationOptions)).EndInit();
            this.tabOpenOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOpenOptions)).EndInit();
            this.tabLayerOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayerOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private DriversTreeView driversTreeView1;
        private UI.Controls.WatermarkTextbox txtSearch;
        private DriverMetadataGrid _driverMetadataGrid1;
        private System.Windows.Forms.Label lblCount;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabGeneral;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabCreationOptions;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabOpenOptions;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabLayerOptions;
        private DriverOptionsGrid gridCreationOptions;
        private DriverOptionsGrid gridOpenOptions;
        private DriverOptionsGrid gridLayerOptions;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboFilter;
    }
}