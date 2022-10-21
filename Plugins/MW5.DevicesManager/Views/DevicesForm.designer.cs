
namespace MW5.Plugins.DevicesManager
{
    partial class DevicesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevicesForm));
            Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer office2016WhiteSplitButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.splitButton_Import = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.itemImportFile = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.itemImportFolder = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.typeIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.Rf_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnListRefresh = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvDirectories = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Filepath_textBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnUp = new System.Windows.Forms.Button();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvDirectories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filepath_textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitButton_Import
            // 
            this.splitButton_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitButton_Import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitButton_Import.BackgroundImage")));
            this.splitButton_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitButton_Import.BeforeTouchSize = new System.Drawing.Size(118, 50);
            this.splitButton_Import.DropDownIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton_Import.DropDownItems.Add(this.itemImportFile);
            this.splitButton_Import.DropDownItems.Add(this.itemImportFolder);
            this.splitButton_Import.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton_Import.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitButton_Import.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton_Import.Location = new System.Drawing.Point(137, 17);
            this.splitButton_Import.Margin = new System.Windows.Forms.Padding(0);
            this.splitButton_Import.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton_Import.Name = "splitButton_Import";
            office2016WhiteSplitButtonRenderer2.SplitButton = this.splitButton_Import;
            this.splitButton_Import.Renderer = office2016WhiteSplitButtonRenderer2;
            this.splitButton_Import.ShowDropDownOnButtonClick = true;
            this.splitButton_Import.Size = new System.Drawing.Size(118, 50);
            this.splitButton_Import.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016White;
            this.splitButton_Import.TabIndex = 20;
            this.splitButton_Import.Text = "导入";
            this.splitButton_Import.ThemeName = "Office2016White";
            this.splitButton_Import.ThemeStyle.BorderColor = System.Drawing.Color.Transparent;
            this.splitButton_Import.DropDowItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.splitButton_Import_DropDowItemClicked);
            // 
            // itemImportFile
            // 
            this.itemImportFile.BackColor = System.Drawing.Color.Transparent;
            this.itemImportFile.Name = "itemImportFile";
            this.itemImportFile.Size = new System.Drawing.Size(23, 23);
            this.itemImportFile.Text = "导入文件";
            // 
            // itemImportFolder
            // 
            this.itemImportFolder.BackColor = System.Drawing.Color.Transparent;
            this.itemImportFolder.Name = "itemImportFolder";
            this.itemImportFolder.Size = new System.Drawing.Size(23, 23);
            this.itemImportFolder.Text = "导入目录";
            // 
            // typeIcons
            // 
            this.typeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("typeIcons.ImageStream")));
            this.typeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.typeIcons.Images.SetKeyName(0, "closeFolder.png");
            this.typeIcons.Images.SetKeyName(1, "组 1.png");
            this.typeIcons.Images.SetKeyName(2, "组 194.png");
            this.typeIcons.Images.SetKeyName(3, "组 194.png");
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageKey = "DeleteUp.png";
            this.btnDelete.ImageList = this.imageList2;
            this.btnDelete.Location = new System.Drawing.Point(330, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 56);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Button_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "CopyDown.png");
            this.imageList2.Images.SetKeyName(1, "CopyUp.png");
            this.imageList2.Images.SetKeyName(2, "CreateFolderDown.png");
            this.imageList2.Images.SetKeyName(3, "CreateFolderUp.png");
            this.imageList2.Images.SetKeyName(4, "DeleteDown.png");
            this.imageList2.Images.SetKeyName(5, "DeleteUp.png");
            this.imageList2.Images.SetKeyName(6, "ExportDown.png");
            this.imageList2.Images.SetKeyName(7, "ExportUp.png");
            this.imageList2.Images.SetKeyName(8, "ImportDown.png");
            this.imageList2.Images.SetKeyName(9, "ImportUp.png");
            this.imageList2.Images.SetKeyName(10, "PasteDown.png");
            this.imageList2.Images.SetKeyName(11, "PasteUp.png");
            this.imageList2.Images.SetKeyName(12, "RefreshDown");
            this.imageList2.Images.SetKeyName(13, "RefreshUp");
            this.imageList2.Images.SetKeyName(14, "ArrowDown");
            this.imageList2.Images.SetKeyName(15, "ArrowUp");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdd,
            this.Rf_ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(137, 48);
            // 
            // ToolStripMenuItemAdd
            // 
            this.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            this.ToolStripMenuItemAdd.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItemAdd.Text = "新建文件夹";
            this.ToolStripMenuItemAdd.Click += new System.EventHandler(this.ToolStripMenuItemAdd_Click);
            // 
            // Rf_ToolStripMenuItem
            // 
            this.Rf_ToolStripMenuItem.Name = "Rf_ToolStripMenuItem";
            this.Rf_ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.Rf_ToolStripMenuItem.Text = "刷新";
            this.Rf_ToolStripMenuItem.Click += new System.EventHandler(this.Rf_ToolStripMenuItem_Click);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.AutoSize = true;
            this.btnCreateFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCreateFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateFolder.ImageKey = "CreateFolderUp.png";
            this.btnCreateFolder.ImageList = this.imageList2;
            this.btnCreateFolder.Location = new System.Drawing.Point(12, 12);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(125, 56);
            this.btnCreateFolder.TabIndex = 7;
            this.btnCreateFolder.Text = "新建文件夹";
            this.btnCreateFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.Create_Button_Click);
            this.btnCreateFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnCreateFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ImageKey = "ExportUp.png";
            this.btnExport.ImageList = this.imageList2;
            this.btnExport.Location = new System.Drawing.Point(242, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 56);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "导出";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.export_Button_Click);
            this.btnExport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnExport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnListRefresh
            // 
            this.btnListRefresh.AutoSize = true;
            this.btnListRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnListRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListRefresh.ImageKey = "RefreshUp";
            this.btnListRefresh.ImageList = this.imageList2;
            this.btnListRefresh.Location = new System.Drawing.Point(418, 12);
            this.btnListRefresh.Name = "btnListRefresh";
            this.btnListRefresh.Size = new System.Drawing.Size(89, 56);
            this.btnListRefresh.TabIndex = 12;
            this.btnListRefresh.Text = "刷新";
            this.btnListRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListRefresh.UseVisualStyleBackColor = true;
            this.btnListRefresh.Click += new System.EventHandler(this.btnListRefresh_Click);
            this.btnListRefresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnListRefresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "closeFolder.png");
            this.imageList1.Images.SetKeyName(1, "openFolder.png");
            this.imageList1.Images.SetKeyName(2, "组 196.png");
            this.imageList1.Images.SetKeyName(3, "组 196.png");
            this.imageList1.Images.SetKeyName(4, "组 197.png");
            this.imageList1.Images.SetKeyName(5, "组 197.png");
            this.imageList1.Images.SetKeyName(6, "lALPJwY7SgAKYo0wMA_48_48.png");
            this.imageList1.Images.SetKeyName(7, "lALPJwY7SgANmV8wMA_48_48.png");
            this.imageList1.Images.SetKeyName(8, "computer.png");
            this.imageList1.Images.SetKeyName(9, "folder.png");
            this.imageList1.Images.SetKeyName(10, "folder-open.png");
            this.imageList1.Images.SetKeyName(11, "folder-loading.gif");
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "新项选择";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(1, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(917, 25);
            this.miniToolStrip.TabIndex = 18;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvDirectories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 575);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 15;
            // 
            // tvDirectories
            // 
            treeNodeAdvStyleInfo2.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNodeAdvStyleInfo2.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.tvDirectories.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo2)});
            this.tvDirectories.BeforeTouchSize = new System.Drawing.Size(277, 575);
            this.tvDirectories.BorderSides = System.Windows.Forms.Border3DSide.Right;
            this.tvDirectories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDirectories.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvDirectories.FullRowSelect = true;
            // 
            // 
            // 
            this.tvDirectories.HelpTextControl.BaseThemeName = null;
            this.tvDirectories.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tvDirectories.HelpTextControl.Name = "";
            this.tvDirectories.HelpTextControl.Size = new System.Drawing.Size(392, 112);
            this.tvDirectories.HelpTextControl.TabIndex = 0;
            this.tvDirectories.HelpTextControl.Visible = true;
            this.tvDirectories.HideSelection = false;
            this.tvDirectories.InactiveSelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control);
            this.tvDirectories.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tvDirectories.ItemHeight = 30;
            this.tvDirectories.Location = new System.Drawing.Point(0, 0);
            this.tvDirectories.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tvDirectories.Name = "tvDirectories";
            this.tvDirectories.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.GradientInactiveCaption);
            this.tvDirectories.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvDirectories.Size = new System.Drawing.Size(277, 575);
            this.tvDirectories.TabIndex = 0;
            this.tvDirectories.Text = "treeViewAdv1";
            this.tvDirectories.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.tvDirectories.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.tvDirectories.ToolTipControl.BaseThemeName = null;
            this.tvDirectories.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tvDirectories.ToolTipControl.Name = "";
            this.tvDirectories.ToolTipControl.Size = new System.Drawing.Size(392, 112);
            this.tvDirectories.ToolTipControl.TabIndex = 0;
            this.tvDirectories.ToolTipControl.Visible = true;
            this.tvDirectories.AfterSelect += new System.EventHandler(this.tvDirectories_AfterSelect);
            this.tvDirectories.BeforeExpand += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv1_BeforeExpand);
            this.tvDirectories.NodeMouseClick += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvMouseClickArgs(this.treeViewAdv1_NodeMouseClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Filepath_textBox);
            this.splitContainer2.Panel1.Controls.Add(this.btnUp);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvFiles);
            this.splitContainer2.Size = new System.Drawing.Size(853, 575);
            this.splitContainer2.SplitterDistance = 35;
            this.splitContainer2.TabIndex = 19;
            // 
            // Filepath_textBox
            // 
            this.Filepath_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Filepath_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Filepath_textBox.BeforeTouchSize = new System.Drawing.Size(809, 21);
            this.Filepath_textBox.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.Filepath_textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Filepath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Filepath_textBox.CornerRadius = 10;
            this.Filepath_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Filepath_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Filepath_textBox.Location = new System.Drawing.Point(41, 6);
            this.Filepath_textBox.MinimumSize = new System.Drawing.Size(25, 20);
            this.Filepath_textBox.Name = "Filepath_textBox";
            this.Filepath_textBox.Size = new System.Drawing.Size(809, 21);
            this.Filepath_textBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.Filepath_textBox.TabIndex = 18;
            this.Filepath_textBox.ThemeName = "Office2016White";
            this.Filepath_textBox.ThemeStyle.CornerRadius = 10;
            // 
            // btnUp
            // 
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ImageKey = "ArrowUp";
            this.btnUp.ImageList = this.imageList2;
            this.btnUp.Location = new System.Drawing.Point(0, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 35);
            this.btnUp.TabIndex = 17;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // lvFiles
            // 
            this.lvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFiles.CheckBoxes = true;
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvFiles.GridLines = true;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(0, 0);
            this.lvFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(853, 536);
            this.lvFiles.SmallImageList = this.typeIcons;
            this.lvFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvFiles.TabIndex = 1;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.ItemActivate += new System.EventHandler(this.filesList_ItemActivate);
            this.lvFiles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFiles_ItemChecked);
            this.lvFiles.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            this.lvFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filesList_MouseClick);
            this.lvFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFiles_MouseDoubleClick);
            this.lvFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filesList_MouseDown);
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.progressBarAdv1.Location = new System.Drawing.Point(12, 647);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.Size = new System.Drawing.Size(1135, 16);
            this.progressBarAdv1.Step = 1;
            this.progressBarAdv1.TabIndex = 21;
            this.progressBarAdv1.TextShadow = false;
            this.progressBarAdv1.ThemeName = "Metro";
            this.progressBarAdv1.ThemesEnabled = true;
            this.progressBarAdv1.UseWaitCursor = true;
            this.progressBarAdv1.Value = 30;
            this.progressBarAdv1.WaitingGradientEnabled = true;
            this.progressBarAdv1.WaitingGradientInterval = 3;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 577);
            this.panel1.TabIndex = 19;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // DevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(1159, 659);
            this.Controls.Add(this.progressBarAdv1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListRefresh);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.splitButton_Import);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(499, 643);
            this.Name = "DevicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "文件管理";
            this.Text = "文件管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevicesForm_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvDirectories)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Filepath_textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem Rf_ToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnListRefresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList typeIcons;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv tvDirectories;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUp;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Filepath_textBox;
        private Syncfusion.Windows.Forms.Tools.SplitButton splitButton_Import;
        private Syncfusion.Windows.Forms.Tools.toolstripitem itemImportFile;
        private Syncfusion.Windows.Forms.Tools.toolstripitem itemImportFolder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
    }
}

