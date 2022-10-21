using MediaDevices;
using MW5.UI.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MW5.Plugins.DevicesManager
{
    public partial class DevicesForm : MapWindowView
    {
        class CompareListViewItem : IComparer<ListViewItem>, IComparer
        {
            public int Compare(object x, object y)
            {
                return Compare((ListViewItem)x, (ListViewItem)y);
            }

            public int Compare(ListViewItem x, ListViewItem y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        MW5.Plugins.Services.ILayerService _layerService;
        //ManagementEventWatcher insertWatcher;
        //ManagementEventWatcher removeWatcher;
        public DevicesForm(MW5.Plugins.Services.ILayerService layerService)
        {
            InitializeComponent();

            _layerService = layerService;

            foreach (var ctl in this.Controls)
            {
                if (ctl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
            }

            // NOTE: 由于删除卡住的问题还没有解决方案，暂时隐藏删除操作
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                btnDelete.Visible = false;
                btnListRefresh.Location = btnDelete.Location;
            }

            this.panel1.BorderStyle = BorderStyle.None;
            this.lvFiles.Sorting = SortOrder.Ascending;
            lvFiles.ListViewItemSorter = new CompareListViewItem();
            this.DoubleBuffered = true;
            this.itemImportFolder.Text = "导入文件夹";

            Control.CheckForIllegalCrossThreadCalls = false;

            //var withinInterval = new TimeSpan(0, 0, 3);
            //WqlEventQuery insertQuery = new WqlEventQuery("__InstanceCreationEvent", withinInterval, "TargetInstance ISA 'Win32_USBControllerDevice'");
            //insertWatcher = new ManagementEventWatcher(insertQuery);
            //insertWatcher.EventArrived += new EventArrivedEventHandler(DeviceInsertedEvent);
            //insertWatcher.Start();

            //WqlEventQuery removeQuery = new WqlEventQuery("__InstanceDeletionEvent", withinInterval, "TargetInstance ISA 'Win32_USBControllerDevice'");
            //removeWatcher = new ManagementEventWatcher(removeQuery);
            //removeWatcher.EventArrived += new EventArrivedEventHandler(DeviceRemovedEvent);
            //removeWatcher.Start();

            Microsoft.Win32.SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
        }

        private void SystemEvents_PowerModeChanged(object sender, Microsoft.Win32.PowerModeChangedEventArgs e)
        {
            //System.Diagnostics.Debug.Print(e.Mode.ToString());
            //if (IsActive && e.Mode == Microsoft.Win32.PowerModes.Resume && currentDevice != null)
            //{
            //    Initalize();
            //    insertWatcher.Start();
            //}
            //else if(e.Mode == Microsoft.Win32.PowerModes.Suspend && currentDevice != null)
            //{
            //    insertWatcher.Stop();
            //    if (currentDevice != null)
            //        currentDevice.DeviceRemoved -= Device_DeviceRemoved;
            //    this.Hide();
            //}
        }

        //全局变量
        public MediaDevice currentDevice = null;
        public string model = ""; //设备型号
        public static int FileState = 0;  //设置删除判断是文件还是文件夹 0是文件夹 1是文件
        public static string sdName = ""; //adb获取外置SD卡信息

        public List<string> pathAll = new List<string>();//获取遍历出来的所有文件夹
        public TreeNode ed;
        //
        private IList<TreeNodeAdv> nodePrecentList = new List<TreeNodeAdv>();
        private int idxCurrentPrecent = -1;
        private const int maxPrecent = 20;

        #region TreeView树形显示磁盘下文件夹
        /// <summary>
        /// IconIndexs类 对应ImageList中5张图片的序列
        /// </summary>
        private class IconIndexes
        {
            public const int MyComputer = 0;      //我的电脑
            public const int ClosedFolder = 1;    //文件夹关闭
            public const int OpenFolder = 2;      //文件夹打开
            public const int FixedDrive = 3;      //磁盘盘符
            public const int MyDocuments = 4;     //我的文档
        }

        public static string[] RootDirs = { "内部存储设备", "内部存储", "SD内存卡" };
        public static string[] ProductFolder = { "林调通", "林长制", "SunToonGis" };
        #endregion

        #region 设置ListView控件初始化
        /// <summary>
        /// 自定义函数设置ListView控件初始属性
        /// </summary>
        private void SetListView()
        {
            lvFiles.Clear();
            //行和列是否显示网格线
            this.lvFiles.GridLines = false;
            //显示方式(注意View是Details详细显示)
            this.lvFiles.View = View.Details;
            //是否可编辑
            this.lvFiles.LabelEdit = true;
            //没有足够的空间显示时,是否添加滚动条
            this.lvFiles.Scrollable = true;
            //对表头进行设置
            this.lvFiles.HeaderStyle = ColumnHeaderStyle.Clickable;
            //是否可以选择行
            this.lvFiles.FullRowSelect = true;
            //设置左对齐
            //this.filesList.Alignment = ListViewAlignment.Left;

            //设置listView列标题头 宽度为2/15 9/15 2/15 2/15 
            //其中设置标题头自动适应宽度,-1根据内容设置宽度,-2根据标题设置宽度
            this.lvFiles.Columns.Add("名称", 40 * lvFiles.Width / 100);
            this.lvFiles.Columns.Add("大小", 15 * lvFiles.Width / 100);
            this.lvFiles.Columns.Add("类型", 15 * lvFiles.Width / 100);
            this.lvFiles.Columns.Add("修改日期", 25 * lvFiles.Width / 100);
        }
        #endregion

        private bool Initalize()
        {
            lock (this)
            {
                try
                {
                    this.Text = "文件管理" + " -- 已连接 - 正在初始化...";
                    SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
                    this.tvDirectories.ThemeName = "Office2019Colorful";
                    this.tvDirectories.StateImageList = imageList1;
                    this.tvDirectories.ShowLines = false;
                    this.tvDirectories.ItemHeight = 35;
                    this.MinimumSize = this.Size;

                    bool ret = InitalizeTreeView();
                    SetListView();
                    UpdateControl();

                    FileState = -1;

                    splitButton_Import.Renderer = new CustomRenderer(splitButton_Import);

                    progressBarAdv1.Visible = false;
                    progressBarAdv1.Step = 1;

                    return ret;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.Text = "文件管理" + (tvDirectories.Nodes.Count > 0 ? "" : " -- 未发现设备");
                }
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Initalize();

            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
        }

        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            //insertWatcher.Stop();
            //removeWatcher.Stop();

            //if(Initalize())
            //{
            //    this.Show();
            //    this.BringToFront();
            //}

            //insertWatcher.Start();
            //removeWatcher.Start();
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            //insertWatcher.Stop();
            //removeWatcher.Stop();

            ////RemoveDevice();
            //Initalize();

            //insertWatcher.Start();
            //removeWatcher.Start();
        }

        private void Device_DeviceRemoved(object sender, MediaDeviceEventArgs e)
        {
            //insertWatcher.Stop();
            //if (e.MediaDevice.IsConnected)
            //{
            //    e.MediaDevice.DeviceRemoved -= Device_DeviceRemoved;

            //    //RemoveDevice();
            //    Initalize();
            //}
            //insertWatcher.Start();
        }

        private void RemoveDevice()
        {
            lock (this)
            {
                lvFiles.Items.Clear();
                Filepath_textBox.Text = "";
                currentDevice = null;

                IList<MediaDevice> deviceList = MediaDevice.GetDevices() as List<MediaDevice>;
                IList<string> names = new List<string>();
                foreach (TreeNodeAdv node in tvDirectories.Nodes)
                {
                    names.Add(node.Name);
                }
                foreach (MediaDevice device in deviceList)
                {
                    device.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);
                    if (device.IsConnected && device.GetDrives()?.Count() > 0)
                    {
                        names.Remove(device.FriendlyName);
                    }
                    //device.Disconnect();
                }
                foreach (TreeNodeAdv node in tvDirectories.Nodes)
                {
                    if (names.Contains(node.Name))
                    {
                        node.Nodes.Clear();
                        node.Text = node.Name + "(断开连接)";
                    }
                }
            }
        }

        private TreeNodeAdv NewTreeNode(TreeNodeAdv node, string text, string name, object tag, int closeImageIndex = 1, int openImageIndex = 1)
        {
            node = node ?? new TreeNodeAdv();
            node.Text = text;
            node.ChildStyle.EnsureDefaultOptionedChild = true;
            node.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            node.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            node.EnsureDefaultOptionedChild = true;
            node.MultiLine = true;
            node.Name = name;
            node.Tag = tag;
            node.ClosedImgIndex = node.CollapseImageIndex = node.NoChildrenImgIndex = closeImageIndex;
            node.OpenImgIndex = node.ExpandImageIndex = openImageIndex;
            node.LeftStateImagePadding = 6; // 与左边加号的距离

            return node;
        }

        private bool InitalizeTreeView()
        {
            tvDirectories.BeginUpdate();
            try
            {
                Filepath_textBox.Text = "";
                tvDirectories.Nodes.Clear();
                // 获取手机端数据
                List<MediaDevice> MediaDeviceList = MediaDevice.GetDevices() as List<MediaDevice>;
                foreach (var device in MediaDeviceList)
                {
                    device.Disconnect();
                    if (!device.IsConnected)
                        device.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);
                    if (!device.IsConnected)
                        return false;
                    //device.ObjectAdded += Device_ObjectAdded;
                    //device.ObjectRemoved += Device_ObjectRemoved;
                    //device.DeviceRemoved -= Device_DeviceRemoved;
                    //device.DeviceRemoved += Device_DeviceRemoved;
                    try
                    {
                        var drives = device.GetDrives();
                        var title = device.FriendlyName + "(未连接)";
                        var nodeDevice = NewTreeNode(null, title, device.FriendlyName, device.SerialNumber, 3, 3);
                        nodeDevice.Expanded = true;
                        tvDirectories.Nodes.Add(nodeDevice);

                        if (drives?.Length == 0)
                            return false;
                        
                        nodeDevice.Text = device.FriendlyName + "(正在连接)";

                        //var diskNode = NewTreeNode(null, "内部存储", "\\内部存储", device.FriendlyName, 5, 5);  //载入显示 选择显示
                        //nodeDevice.Nodes.Add(diskNode);             //树中添加根目录
                        //diskNode.Nodes.Add(NewTreeNode(null, "", "", null));

                        //判断是否有外置SD卡
                        var path = device.GetDrives();
                        if (path != null)
                        {
                            foreach (var driver in path)
                            {
                                sdName = driver.VolumeLabel;
                                var tNodeSD = NewTreeNode(null, sdName, driver.Name, device.FriendlyName, 5, 5);
                                nodeDevice.Nodes.Add(tNodeSD);                    //加载驱动节点
                                tNodeSD.Nodes.Add(NewTreeNode(null, "", "", null));
                            }

                            if (path.Count() > 0)
                            {
                                string full = path[0].VolumeLabel;
                                string[] dirs = device.GetDirectories(full);
                                foreach (string dic in dirs)
                                {
                                    var dirInfo = new DirectoryInfo(dic);
                                    if (ProductFolder.Contains(dirInfo.Name)) // 显示产品文件夹
                                    {
                                        var tNodeLin = NewTreeNode(null, dirInfo.Name, dic, device.FriendlyName);
                                        nodeDevice.Nodes.Add(tNodeLin);
                                        tNodeLin.Nodes.Add(NewTreeNode(null, "", "", null));
                                    }
                                }
                            }
                            nodeDevice.Text = device.FriendlyName;
                        }
                        else
                        {
                            nodeDevice.Text = title;
                        }
                        

                        this.Text = "文件管理";
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        //device.Disconnect();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tvDirectories.EndUpdate();
            }

            return true;
        }

        private TreeNodeAdv FindTreeNode(TreeNodeAdv root, string key)
        {
            foreach (TreeNodeAdv node in root.Nodes)
            {
                if (node.Nodes.Count > 0 && node.Nodes[0].Name != "")
                {
                    var n = FindTreeNode(node, key);
                    if (n != null)
                        return n;
                }
            }
            foreach (TreeNodeAdv node in root.Nodes)
            {
                if (key.Equals(node.Name))
                {
                    return node;
                }
            }
            return null;
        }

        private void Device_ObjectRemoved(object sender, MediaDeviceEventArgs e)
        {
            if (importing)
                return;
            lock (this)
            {
                var nodeSelected = tvDirectories.SelectedNode;
                var device = e.MediaDevice;
                if (nodeSelected != null && nodeSelected.Parent != tvDirectories.Root)
                {
                    if (!device.IsConnected)
                        device.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);

                    if (!device.DirectoryExists(nodeSelected.Name))
                    {
                        tvDirectories.SelectedNode = nodeSelected.Parent;
                        ResetTreeNode(nodeSelected.Parent);
                    }
                    else
                    {
                        ResetTreeNode(nodeSelected);
                    }
                }
            }
        }

        private void Device_ObjectAdded(object sender, ObjectAddedEventArgs e)
        {
            if (importing)
                return;
            lock (this)
            {
                var nodeSelected = tvDirectories.SelectedNode;
                var fullName = e.ObjectFullFileName;
                var device = e.MediaDevice;
                if (!device.IsConnected)
                    device.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);
                if (device.DirectoryExists(fullName))
                {
                    var node = FindTreeNode(tvDirectories.Root, fullName);
                    if (node == null)
                    {
                        var parentDir = System.IO.Path.GetDirectoryName(fullName);
                        node = FindTreeNode(tvDirectories.Root, parentDir);
                        if (node != null)
                        {
                            if (node == nodeSelected)
                                ResetTreeNode(node);
                            else
                            {
                                var newNode = NewTreeNode(null, System.IO.Path.GetFileName(fullName), fullName, tvDirectories.SelectedNode.Tag);
                                node.Nodes.Add(newNode);
                            }
                        }
                    }
                }
                else
                {
                    var path = System.IO.Path.GetDirectoryName(e.ObjectFullFileName);
                    var node = FindTreeNode(tvDirectories.Root, path);
                    if (nodeSelected == node)
                        ResetTreeNode(nodeSelected);
                }
            }
        }

        #region ListView显示选中文件夹中文件内容
        private void Export(MediaDevice device, string dstPath)
        {
            try
            {
                device.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);
                var srcPath = tvDirectories.SelectedNode.Name;
                var selectPath = "";
                // 选中左侧目录树
                if (FileState == 0)
                {
                    string targetPath = selectPath = System.IO.Path.Combine(dstPath, System.IO.Path.GetFileName(srcPath));
                    if (Directory.Exists(targetPath) && MessageBox.Show(this, "文件夹已存在，是否继续导出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;

                    Directory.CreateDirectory(targetPath);
                    var dirs = device.GetDirectories(srcPath, "", SearchOption.AllDirectories);
                    foreach (var dir in dirs)
                    {
                        var targetDir = System.IO.Path.Combine(targetPath, dir.Replace(srcPath, "").Trim('\\'));
                        System.IO.Directory.CreateDirectory(targetDir);
                    }
                    var files = device.GetFiles(srcPath, "", SearchOption.AllDirectories);
                    int i = 0;
                    foreach (var file in files)
                    {
                        backgroundWorker1.ReportProgress(++i * 100 / files.Count());
                        var targetFile = System.IO.Path.Combine(targetPath, file.Replace(srcPath, "").Trim('\\'));
                        currentDevice.DownloadFile(file, targetFile);
                    }
                    var args = string.Format(" /select,{0}", selectPath);
                    System.Diagnostics.Process.Start("explorer.exe", args);
                }
                else if (FileState == 1) // 选中右侧列表
                {
                    var fileList = new List<string>();
                    var selectPaths = new List<string>();
                    for (int i = lvFiles.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        var selectedItem = this.lvFiles.SelectedItems[i];
                        var fileName = selectedItem.Name.ToString();

                        string targetPath = Path.Combine(dstPath, Path.GetFileName(fileName));
                        selectPaths.Add(targetPath);
                        if (File.Exists(targetPath) || Directory.Exists(targetPath))
                        {
                            if (MessageBox.Show(this, string.Format("{0}已存在，是否覆盖？", targetPath), "提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                continue;
                            }
                        }

                        if (device.FileExists(fileName))
                        {
                            fileList.Add(fileName);
                        }
                        else if (device.DirectoryExists(fileName))
                        {
                            fileList.AddRange(device.GetFiles(fileName, "", SearchOption.AllDirectories));
                        }
                    }
                    int p = 0;
                    foreach (var file in fileList)
                    {
                        var targetFile = Path.Combine(dstPath, file.Replace(srcPath, "").Trim(Path.DirectorySeparatorChar));
                        var targetDir = Path.GetDirectoryName(targetFile);
                        if (!Directory.Exists(targetDir))
                            Directory.CreateDirectory(targetDir);
                        backgroundWorker1.ReportProgress(++p * 100 / fileList.Count);
                        device.DownloadFile(file, targetFile);
                    }
                    using (var frmAddLayer = new AddImportFilesForm(selectPaths))
                    {
                        if( selectPaths.Where(x=>x.Contains(".shp")).Count()>0)
                        {
                            if (frmAddLayer.ShowDialog(this) == DialogResult.OK)
                            {
                                foreach (var name in frmAddLayer.SelectedFileList)
                                {
                                    if (System.IO.Path.GetExtension(name) == ".shp")
                                    {
                                        if (File.Exists(Path.ChangeExtension(name, "dbf")) &&
                                            File.Exists(Path.ChangeExtension(name, "shx")))
                                            _layerService.AddLayersFromFilename(name);
                                        else
                                        {
                                            MessageBox.Show(this, "shp缺少必要的文件(dbf|shx文件)");
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                       
                    }
                }
                MessageBox.Show("导出成功!", "提示");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }

        #endregion
        private void export_Button_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show(this, "请等待当前操作完成");
                return;
            }

            if (FileState != 0 && FileState != 1)
                return;

            if ((FileState == 1 && this.lvFiles.SelectedItems.Count == 0)
                || (tvDirectories.SelectedNode == null || tvDirectories.SelectedNode.Parent == tvDirectories.Root))
            {
                if (this.lvFiles.SelectedItems.Count == 0) //文件没有选中
                {
                    MessageBox.Show(this, "请选择要导出的项目!", "提示");
                    return;
                }
            }

            if (MessageBox.Show(this, "确认导出选择的项目吗?", "提示",
                         System.Windows.Forms.MessageBoxButtons.YesNo,
                         System.Windows.Forms.MessageBoxIcon.Question) ==
                         System.Windows.Forms.DialogResult.Yes)

            {
                if (GetFolderPath(out string Folderpath) != DialogResult.OK)
                    return;

                progressBarAdv1.Value = 0;
                progressBarAdv1.Visible = true;
                backgroundWorker1.RunWorkerAsync(new List<object> { "Export", Folderpath });
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarAdv1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarAdv1.Visible = false;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            var bw = sender as BackgroundWorker;
            Debug.Assert(bw != null);
            lock (this)
            {
                var opt = (e.Argument as List<object>)[0] as string;
                switch (opt.ToLower())
                {
                    case "export":
                        var dstPath = (e.Argument as List<object>)[1] as string;
                        Export(currentDevice, dstPath);
                        break;
                    case "import":
                        var importType = (e.Argument as List<object>)[1] as string;
                        var srcItems = (e.Argument as List<object>)[2] as string[];
                        var ImportPath = (e.Argument as List<object>)[3] as string;
                        Import(importType, srcItems, ImportPath);
                        break;
                    case "delete":
                        Delete();
                        break;
                }
            }
        }

        private void treeViewAdv1_NodeMouseClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
            UpdateControl();
        }

        private void ResetTreeNode(TreeNodeAdv node, bool idRecord = true)
        {
            if (node == null || node.Tag == null)
                return;

            Filepath_textBox.Text = node.Tag + node.Name;
            if (node.Parent == tvDirectories.Root)
            {
                Filepath_textBox.Text = node.Name;
            }

            var deviceName = node.Tag;
            List<MediaDevice> deviceList = MediaDevice.GetDevices() as List<MediaDevice>;
            MediaDevice device = (MediaDevice)deviceList.Find(d => d.FriendlyName.Equals(deviceName));

            if (device == null)
            {
                lvFiles.Items.Clear();
                return;
            }
            using (var wait = new Waiting(this))
            {
                currentDevice = device;

                try
                {
                    if (!device.IsConnected)
                        device.Connect( MediaDeviceAccess.Default, MediaDeviceShare.Delete );
                    if (!device.DirectoryExists(node.Name))
                    {
                        if (node.Parent != null)
                            ResetTreeNode(node.Parent);
                        return;
                    }

                    var dirs = device.GetDirectories(node.Name);
                    var dirList = new List<string>(dirs);

                    tvDirectories.BeginUpdate();
                    for (int i = node.Nodes.Count - 1; i >= 0; i--)
                    {
                        TreeNodeAdv tnode = node.Nodes[i];
                        if (!dirList.Contains(tnode.Name))
                            node.Nodes.RemoveAt(i);
                    }
                    foreach (TreeNodeAdv n in node.Nodes)
                    {
                        if (dirList.Contains(n.Name))
                            dirList.Remove(n.Name);
                    }
                    var nodeList = (from dir in dirList select new TreeNodeAdv(dir)).ToArray();
                    foreach (var nodeItem in nodeList)
                    {
                        var name = nodeItem.Text;
                        var newNode = NewTreeNode(nodeItem, System.IO.Path.GetFileName(name), name, tvDirectories.SelectedNode.Tag);
                        var first = device.EnumerateDirectories(name).FirstOrDefault();
                        if (first != null)
                            newNode.Nodes.Add(NewTreeNode(null, "", "", null));
                    }
                    node.Nodes.AddRange(nodeList);
                    tvDirectories.EndUpdate();

                    ShowFilesList(node.Name);

                    FileState = 0;

                    this.Text = "文件管理";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //device.Disconnect();
                }
            }
        }

        private TreeNodeAdv lastSelectedNode = null;
        private void treeViewAdv1_BeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            lock (this)
            {
                var nodeSelected = e.Node;
                if (nodeSelected == lastSelectedNode)
                    return;
                Filepath_textBox.Text = nodeSelected.Tag + nodeSelected.Name;
                if (nodeSelected.Parent == tvDirectories.Root)
                {
                    Filepath_textBox.Text = nodeSelected.Name;
                }

                var deviceName = nodeSelected.Tag;
                List<MediaDevice> deviceList = MediaDevice.GetDevices() as List<MediaDevice>;
                MediaDevice device = (MediaDevice)deviceList.Find(d => d.FriendlyName.Equals(deviceName));

                if (device == null)
                    return;

                using (var waiting = new Waiting(this))
                {
                    currentDevice = device;
                    device.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);
                    System.Threading.Thread thread = null;
                    try
                    {
                        if (nodeSelected.Nodes.Count < 1 || (nodeSelected.Nodes[0].Name == ""))
                        {
                            var pathSpliter = new char[] { '\\', '/' };
                            var pathParts = (nodeSelected.Name).Split(pathSpliter);
                            if (pathParts.Count() < 1)
                                return;

                            var drivers = device.GetDrives();
                            if (drivers == null)
                                return;

                            thread = new System.Threading.Thread(() =>
                            {
                                try
                                {
                                    foreach (var driver in drivers)
                                    {
                                        if (driver.Name.Trim(pathSpliter) == pathParts[1])
                                        {
                                            var path = nodeSelected.Name;
                                            var pathList = device.GetDirectories(path);
                                            if (pathList.Count() == 0)
                                                continue;
                                            tvDirectories.BeginUpdate();
                                            nodeSelected.Nodes.Clear();
                                            //var nodeList = new TreeNodeAdv[pathList.Length];
                                            var nodeList = (from dir in pathList select new TreeNodeAdv(dir)).ToArray();
                                            foreach (var node in nodeList)
                                            {
                                                var name = node.Text;
                                                var text = name.Split(pathSpliter).Last();
                                                var newNode = NewTreeNode(node, text, name, deviceName);
                                                var first = device.EnumerateDirectories(name).FirstOrDefault();
                                                if (first != null)
                                                    newNode.Nodes.Add(NewTreeNode(null, "", "", null));
                                            }
                                            nodeSelected.Nodes.AddRange(nodeList);
                                            tvDirectories.EndUpdate();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            });
                            thread.Start();
                        }

                        ShowFilesList(e.Node.Name);

                        thread?.Join();

                        tvDirectories.SelectedNode = e.Node;

                        lastSelectedNode = nodeSelected;
                        FileState = 0;
                    }
                    catch (Exception ex)
                    {
                        if (!ex.Message.Contains("已中止 I/O 操作") && !ex.Message.Contains("已关闭"))
                            MessageBox.Show(this, ex.Message);
                    }
                    finally
                    {
                        tvDirectories.EndUpdate();
                        //device.Disconnect();
                    }
                }
            }
        }

        private delegate string GetTypeFunc(string text);
        private delegate MediaFileSystemInfo GetPathInfoFunc(string path);

        private static ulong KB = (ulong)0x3FF << 10;
        private static ulong MB = (ulong)0x3FF << 20;
        //private static ulong GB = (ulong)0x3FF << 30;
        //private static ulong TB = (ulong)0x3FF << 40;
        public static string getPrintSize(ulong size)
        {
            //if ((size & TB) > 0)
            //{
            //    return (size / (1 << 40)).ToString() + "TB";
            //}
            //else if ((size & GB) > 0)
            //{
            //    return (size / (1 << 30)).ToString() + "GB";
            //}
            //else 
            if ((size & MB) > 0)
            {
                return (size / (1 << 20)).ToString() + "MB";
            }
            else if ((size & KB) > 0)
            {
                return (size / (1 << 10)).ToString() + "KB";
            }

            return size.ToString() + "B";
        }

        private void FillFileList(IEnumerable<MediaFileSystemInfo> list)
        {
            int i = lvFiles.Items.Count;
            var nodeList = new List<ListViewItem>();
            foreach (var info in list)
            {
                try
                {

                ulong size = info.Length;
                DateTime? dt = DateTime.MinValue;
                if (info.LastWriteTime != null)
                    dt = info.LastWriteTime;
                nodeList.Add(new ListViewItem(new string[]
                {
                    info.Name,
                    info is MediaFileInfo ? getPrintSize(size) : "-" , // size
                    info is MediaFileInfo ? System.IO.Path.GetExtension(info.Name).Trim('.') + "文件": "文件夹",
                    dt.ToString()
                }, info is MediaFileInfo ? 2 : 1));
                nodeList.Last().Name = info.FullName;
                }
                catch (Exception ex)
                {
                    if (!ex.Message.Contains("非法字符"))
                    {
                        throw ex;
                    }
                }
            }
            nodeList.Sort(new CompareListViewItem());
            lvFiles.Items.AddRange(nodeList.ToArray());
        }

        private void FillFileList(IEnumerable<string> list, GetTypeFunc textFunc, GetPathInfoFunc funcGetInfo, int type/*文件夹=0,文件=1*/)
        {
            int i = lvFiles.Items.Count;
            var nodeList = (from name in list select new ListViewItem(name, type == 1 ? 2 : 1)).ToList();
            nodeList.Sort(new CompareListViewItem());
            lvFiles.Items.AddRange(nodeList.ToArray());
            foreach (var item in nodeList)
            {
                var name = item.Text;
                item.Name = name;
                item.Text = System.IO.Path.GetFileName(name);
                MediaFileSystemInfo info = funcGetInfo(name);
                if (info != null)
                {
                    ulong size = info.Length;
                    DateTime? dt = DateTime.MinValue;
                    if (info.LastWriteTime != null)
                        dt = info.LastWriteTime;
                    item.SubItems.AddRange(new string[] {
                        size == 0 ? "-" : getPrintSize(size), // size
                        textFunc(name),
                        dt.ToString()
                    });
                }
            }
        }

        public void ShowFilesList(string path)
        {
            lvFiles.BeginUpdate();
            try
            {
                var device = currentDevice;
                lvFiles.Items.Clear();
                var dirInfo = device.GetDirectoryInfo(path);
                var files = dirInfo.EnumerateFileSystemInfos(); //device.EnumerateDirectories(path);
                FillFileList(files);
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("已中止 I/O 操作") && !ex.Message.Contains("已关闭"))
                    MessageBox.Show(this, ex.Message);
            }
            finally
            {
                lvFiles.EndUpdate();
            }
        }

        //打开文件/文件夹
        private void OpenItem(ListViewItem lvSelectedItem)
        {
            lock (this)
            {
                if (lvSelectedItem != null)
                {
                    string text = lvSelectedItem.Text;
                    string path = lvSelectedItem.Name.ToString();

                    try
                    {
                        if (!currentDevice.DirectoryExists(path))
                        {
                            if (tvDirectories.SelectedNode != null)
                                ResetTreeNode(tvDirectories.SelectedNode);
                            return;
                        }

                        tvDirectories.SelectedNode.Expand();
                        foreach (TreeNodeAdv node in tvDirectories.SelectedNode.Nodes)
                        {
                            if (node.Text == text)
                            {
                                tvDirectories.BeginInvoke((MethodInvoker)delegate () { tvDirectories.SelectedNode = node; });
                                break;
                            }
                        }

                        if (!currentDevice.IsConnected)
                            currentDevice.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);
                        var info = currentDevice.GetDirectoryInfo(path);
                        //如果选中的是文件夹
                        if (info != null)
                        {
                            ShowFilesList(path);
                        }
                        Filepath_textBox.Text = tvDirectories.SelectedNode.Tag.ToString() + path;
                    }
                    catch (Exception ex)
                    {
                        if (!ex.Message.Contains("已中止 I/O 操作") && !ex.Message.Contains("已关闭"))
                            MessageBox.Show(this, ex.Message);
                    }
                    finally
                    {
                        //currentDevice.Disconnect();
                    }
                }
            }
        }

        private static int msgMaxLines = 15;

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show(this, "请等待当前操作完成");
                return;
            }

            progressBarAdv1.Value = 0;
            progressBarAdv1.Visible = true;
            backgroundWorker1.RunWorkerAsync(new List<object> { "Delete" });
        }

        private void Delete()
        {
            bool isDeleted = false;
            var nodeSelected = tvDirectories.SelectedNode;
            if (nodeSelected == null || nodeSelected.Tag == null || nodeSelected.Parent == tvDirectories.Root || (nodeSelected.Parent != null && nodeSelected.Parent.Parent == tvDirectories.Root))
            {
                MessageBox.Show(this, "未选中节点或选中的节点不可删除.");
                return;
            }

            var device = currentDevice;

            if (FileState == 0) // 左侧目录树选择
            {
                var srcPath = nodeSelected.Name;

                if (MessageBox.Show(this, string.Format("确认要删除该项目吗?\n{0}", tvDirectories.SelectedNode?.Name), "提示",
                            System.Windows.Forms.MessageBoxButtons.YesNo,
                            System.Windows.Forms.MessageBoxIcon.Question) ==
                            System.Windows.Forms.DialogResult.Yes)
                {
                    device.Connect( MediaDeviceAccess.Default, MediaDeviceShare.Delete );
                    tvDirectories.BeginUpdate();
                    progressBarAdv1.Visible = true;
                    try
                    {
                        //var files = device.GetFiles(srcPath, "", SearchOption.AllDirectories);
                        //int i = 0;
                        //foreach (var file in files)
                        //{
                        //    backgroundWorker1.ReportProgress(++i * 100 / files.Length);
                        //    device.DeleteFile(file);
                        //}
                        device.DeleteDirectory(srcPath, recursive: true);

                        tvDirectories.SelectedNode = nodeSelected.Parent;
                        ResetTreeNode(nodeSelected.Parent);
                        //nodeSelected.Parent.Nodes.Remove(nodeSelected);
                        tvDirectories.EndUpdate();
                        MessageBox.Show("删除成功!", "提示");
                    }
                    catch (Exception ex)
                    {
                        tvDirectories.EndUpdate();
                        if (!ex.Message.Contains("已中止 I/O 操作") && !ex.Message.Contains("已关闭"))
                            MessageBox.Show(this, ex.Message);
                    }
                    finally
                    {
                       
                        //device.Disconnect();
                    }
                }
            }
            else if (FileState == 1) // 右侧别表选择
            {
                if (this.lvFiles.SelectedItems.Count == 0)
                    return;

                var msg = string.Format("确认要删除({0})个项目吗?", lvFiles.SelectedItems.Count);
                var itemList = new List<string>();
                for (int i = 0; i < Math.Min(lvFiles.SelectedItems.Count, msgMaxLines); i++)
                {
                    ListViewItem item = lvFiles.SelectedItems[i];
                    msg += "\n" + item.Name.ToString();
                    itemList.Add(item.Name.ToString());
                }
                if (lvFiles.SelectedItems.Count > msgMaxLines)
                    msg += "\n......";

                if (MessageBox.Show(this, msg, "提示",
                            System.Windows.Forms.MessageBoxButtons.YesNo,
                            System.Windows.Forms.MessageBoxIcon.Question) ==
                            System.Windows.Forms.DialogResult.Yes)
                {
                    device.Connect(  MediaDeviceAccess.Default, MediaDeviceShare.Delete );
                    try
                    {
                        var fileList = new List<string>();
                        //foreach (var item in itemList)
                        //{
                        //    if (device.DirectoryExists(item))
                        //    {
                        //        var files = device.GetFiles(item, "", SearchOption.AllDirectories);
                        //        fileList.AddRange(files);
                        //    }
                        //}

                        //fileList.AddRange(itemList);
                        int i = 0;
                        foreach (var pathName in itemList)
                        {
                            backgroundWorker1.ReportProgress(++i * 100 / itemList.Count);
                            if (device.FileExists(pathName))
                            {
                                device.DeleteFile(pathName);
                            }
                            else if (device.DirectoryExists(pathName))
                            {
                                device.DeleteDirectory(pathName, true);
                                tvDirectories.BeginUpdate();
                                foreach (TreeNodeAdv node in nodeSelected.Nodes)
                                {
                                    if (node.Tag.ToString() == pathName)
                                    {
                                        nodeSelected.Nodes.Remove(node);
                                        break;
                                    }
                                }
                            }
                        }
                        tvDirectories.EndUpdate();

                       
                    }
                    catch (Exception ex)
                    {
                        isDeleted = false;
                        tvDirectories.EndUpdate();
                        lvFiles.EndUpdate();
                        if (!ex.Message.Contains("已中止 I/O 操作") && !ex.Message.Contains("已关闭"))
                            MessageBox.Show(this, ex.Message);
                    }
                    finally
                    {
                        //device.Disconnect();
                        ResetTreeNode(nodeSelected);
                        if(isDeleted) MessageBox.Show( "删除成功!", "提示");
                    }
                }
            }
        }

        private void DeviceCreateNewFolder()
        {
            if (tvDirectories.SelectedNode == null || tvDirectories.SelectedNode.Tag == null)
                return;
            var nodeSelected = tvDirectories.SelectedNode;
            var deviceName = tvDirectories.SelectedNode.Tag;

            var MediaDeviceList = MediaDevice.GetDevices() as List<MediaDevice>;
            var device = MediaDeviceList.Find(d => d.FriendlyName.Equals(deviceName));
            string strText = string.Empty;
            if (InputDialog.Show(this, out strText) != DialogResult.OK)
                return;

            try
            {
                var fullName = tvDirectories.SelectedNode?.Name + '\\' + strText;
                device.Connect( MediaDeviceAccess.Default, MediaDeviceShare.Delete );
                device.CreateDirectory(fullName);
                if (device.DirectoryExists(fullName))
                    ResetTreeNode(nodeSelected);
                else
                    MessageBox.Show(this, "新建文件夹失败");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //device.Disconnect();
            }
        }
        //新建文件夹
        private void Create_Button_Click(object sender, EventArgs e)
        {
            DeviceCreateNewFolder();
        }

        private void ToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            DeviceCreateNewFolder();
        }

        /// <summary>
        /// 获取文件夹
        /// </summary>
        /// <returns>选择的文件夹路径</returns>
        private DialogResult GetFolderPath(out string folderPath)
        { 
            folderPath = string.Empty;
            //using (var dlg = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog())
            //{
            //    dlg.Multiselect = false;
            //    dlg.IsFolderPicker = true;
            //    dlg.Title = "选择文件夹";
            //    var res = dlg.ShowDialog();
            //    this.BringToFront();
            //    if (res == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
            //    {
            //        folderPath = dlg.FileName;
            //        return DialogResult.OK;
            //    }
            //}
            using (var dlg = new FolderBrowser())
            {
                dlg.StartLocation = FolderBrowserFolder.MyComputer;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    folderPath = dlg.DirectoryPath;
                    return DialogResult.OK;
                }
            }
            return DialogResult.Cancel;
        }

        #region 刷新ListView界面

        private void Rf_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetListView(tvDirectories.SelectedNode);
        }

        //操作ListView之后，刷新界面
        public void ResetListView(TreeNodeAdv node)
        {
            ResetTreeNode(node);
        }

        private void btnListRefresh_Click(object sender, EventArgs e)
        {
            if (tvDirectories.SelectedNode == null || tvDirectories.SelectedNode.Parent == tvDirectories.Root)
                InitalizeTreeView();
            else
                ResetTreeNode(tvDirectories.SelectedNode);
        }

        private void DevicesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Process.GetCurrentProcess().MainWindowHandle != this.Handle)
            {
                e.Cancel = true;
                this.Hide();
            }
            //insertWatcher.Stop();
            //removeWatcher.Stop();
        }

        #endregion
        //TreeView刷新方法

        #region change button image
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.ImageKey = btn.ImageKey.Replace("Up", "Down");
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.ImageKey = btn.ImageKey.Replace("Down", "Up");
            }
        }
        #endregion

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tvDirectories.SelectedNode != null)
            {
                if (tvDirectories.SelectedNode.Parent != null)
                {
                    ResetTreeNode(tvDirectories.SelectedNode.Parent);
                    tvDirectories.SelectedNode = tvDirectories.SelectedNode.Parent;
                    tvDirectories.Focus();
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (nodePrecentList.Count > 0 && idxCurrentPrecent > 0)
            {
                idxCurrentPrecent--;
                ResetTreeNode(nodePrecentList[idxCurrentPrecent], false);
                tvDirectories.SelectedNode = nodePrecentList[idxCurrentPrecent];
                tvDirectories.Focus();
            }
            UpdateControl();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nodePrecentList.Count > 0 && idxCurrentPrecent < nodePrecentList.Count - 1)
            {
                idxCurrentPrecent++;
                ResetTreeNode(nodePrecentList[idxCurrentPrecent], false);
                tvDirectories.SelectedNode = nodePrecentList[idxCurrentPrecent];
                tvDirectories.Focus();
            }
            UpdateControl();
        }

        private void UpdateControl()
        {
            btnUp.Enabled = tvDirectories.SelectedNode != null && tvDirectories.SelectedNode?.Parent != tvDirectories.Root;

            var enable = ((FileState == 1 && lvFiles.SelectedItems.Count > 0)
                || (FileState == 0 && tvDirectories.SelectedNode != null && tvDirectories.SelectedNode.Parent != tvDirectories.Root));
            btnDelete.Enabled = enable;
            btnExport.Enabled = enable;
            btnCreateFolder.Enabled = enable;
            splitButton_Import.Enabled = enable;
        }

        private void filesList_MouseClick(object sender, MouseEventArgs e)
        {
            FileState = 1;
        }

        private void filesList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //if (lvFiles.HitTest(e.Location).Item == null) // 点击空白处
                {
                    Point p = new Point(e.X, e.Y);
                    contextMenuStrip2.Show(lvFiles, p);
                }
            }
            if (lvFiles.HitTest(e.Location).Item == null)
            {
                foreach (ListViewItem item in lvFiles.CheckedItems)
                {
                    item.Checked = false;
                    item.Selected = false;
                }
            }
        }

        private void lvFiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            lvFiles.SelectedIndexChanged -= filesList_SelectedIndexChanged;
            e.Item.Selected = e.Item.Checked;

            lvFiles.SelectedIndexChanged += filesList_SelectedIndexChanged;
        }

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvFiles.ItemChecked -= lvFiles_ItemChecked;
            foreach (ListViewItem item in lvFiles.Items)
            {
                item.Checked = item.Selected;
            }
            lvFiles.ItemChecked += lvFiles_ItemChecked;

            UpdateControl();
        }

        private void lvFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hitInfo = lvFiles.HitTest(e.Location);
            if (hitInfo != null)
            {
                OpenItem(hitInfo.Item);
            }
        }

        private void filesList_ItemActivate(object sender, EventArgs e)
        {
            //OpenItem();
        }

        private void tvDirectories_AfterSelect(object sender, EventArgs e)
        {
            lock (this)
            {
                if (tvDirectories.SelectedNode != null)
                {
                    if (tvDirectories.SelectedNode.Parent != tvDirectories.Root)
                    {
                        ResetTreeNode(tvDirectories.SelectedNode);
                    }
                    else
                    {
                        lvFiles.Items.Clear();
                        Filepath_textBox.Text = tvDirectories.SelectedNode.Name;
                    }
                }
            }
        }

        private void splitButton_Import_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show(this, "请等待当前操作完成");
                return;
            }

            if (tvDirectories.SelectedNode == null || tvDirectories.SelectedNode.Parent == tvDirectories.Root)
            {
                MessageBox.Show(this, "请在左侧选择导入到的位置");
                return;
            }
            var targetPath = tvDirectories.SelectedNode?.Name;
            if (targetPath == "")
            {
                MessageBox.Show(this, "文件名为空");
                return;
            }

            var importType = e.ClickedItem.Text;
            var items = new List<string>();
            if (importType == itemImportFolder.Text) // 导入文件夹
            {
                if (GetFolderPath(out string Folderpath) != DialogResult.OK)
                    return;
                items.Add(Folderpath);
            }
            else if (importType == itemImportFile.Text) // 导入文件
            {
                OpenFileDialog dialog = new OpenFileDialog() { Multiselect = true };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    items.AddRange(dialog.FileNames);
                }
            }

            progressBarAdv1.Value = 0;
            progressBarAdv1.Visible = true;
            backgroundWorker1.RunWorkerAsync(new List<object> { "Import", importType, items.ToArray(), targetPath });
        }

        private bool importing = false;
        private void Import(string importType, string[] srcItems, string ImportPath)
        {
            if (ImportPath == "")
                return;
            var selectedNode = tvDirectories.SelectedNode;
            var device = currentDevice;
            if (!device.IsConnected)
                device.Connect(MediaDeviceAccess.Default, MediaDeviceShare.Delete);

            if (importType == itemImportFolder.Text) // 导入文件夹
            {
                System.Diagnostics.Debug.Assert(srcItems.Length == 1);
                string Folderpath = srcItems[0];

                var targetPath = ImportPath + "\\" + Path.GetFileName(Folderpath);
                var areadyExists = device.DirectoryExists(targetPath);
                if (areadyExists)
                {
                    if (MessageBox.Show(this, string.Format("文件夹({0})已存在,是否覆盖?", targetPath), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }

                var filesUpload = System.IO.Directory.GetFiles(Folderpath, "*", SearchOption.AllDirectories);
                try
                {
                    importing = true;
                    int i = 0;
                    foreach (var file in filesUpload)
                    {
                        backgroundWorker1.ReportProgress(++i * 100 / filesUpload.Length);

                        var targetFile = targetPath + file.Replace(Folderpath, "");
                        var targetDir = Path.GetDirectoryName(targetFile);
                        if (!device.DirectoryExists(targetDir))
                            device.CreateDirectory(targetDir);
                        if (device.FileExists(targetFile))
                            device.DeleteFile(targetFile);
                        device.UploadFile(file, targetFile);
                    }
                    //ResetTreeNode(tvDirectories.SelectedNode);
                    if (!areadyExists)
                    {
                        lvFiles.Invoke((MethodInvoker)delegate ()
                        {
                            FillFileList(new string[] { targetPath }, (str) => { return "文件夹"; }, (str) => { return device.GetDirectoryInfo(targetPath); }, 0);
                        });

                        tvDirectories.Invoke((MethodInvoker)delegate ()
                        {
                            selectedNode.Nodes.Add(NewTreeNode(null, Path.GetFileName(Folderpath), targetPath, selectedNode.Tag));
                        });
                    }
                    MessageBox.Show("导入成功!", "提示");
                }
                catch (Exception ex)
                {
                    if (!ex.Message.Contains("已中止 I/O 操作") && !ex.Message.Contains("已关闭"))
                        MessageBox.Show(this, ex.Message);
                }
                finally
                {
                    //currentDevice.Disconnect();
                    importing = false;
                }
            }
            else if (importType == itemImportFile.Text) // 导入文件
            {
                var files = srcItems;
                try
                {
                    int i = 0;
                    foreach (string filePath in files)
                    {
                        var targetPath = ImportPath + '\\' + System.IO.Path.GetFileName(filePath);
                        if (device.FileExists(targetPath))
                        {
                            if (MessageBox.Show(this, string.Format("文件({0})已存在,是否覆盖?", targetPath), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                continue;

                            device.DeleteFile(targetPath);
                        }
                        backgroundWorker1.ReportProgress(++i * 100 / files.Length);
                        device.UploadFile(filePath, targetPath);
                    }
                    MessageBox.Show("导入成功!", "提示");
                }
                catch (Exception ex)
                {
                    if (!ex.Message.Contains("已中止 I/O 操作") && !ex.Message.Contains("已关闭"))
                        MessageBox.Show(this, ex.Message);
                }
                finally
                {
                    //currentDevice.Disconnect();
                    ResetTreeNode(tvDirectories.SelectedNode);
                }
            }
        }
    }

    public class Waiting : IDisposable
    {
        private Form _form = null;
        private Cursor oldCursor = null;
        public Waiting(Form form)
        {
            oldCursor = form.Cursor;
            form.Cursor = Cursors.WaitCursor;
            _form = form;
        }

        public void Dispose()
        {
            _form.Cursor = oldCursor;
        }
    }
    public class CustomRenderer : ISplitButtonRenderer
    {
        public CustomRenderer(SplitButton btn)
        {
            SplitButton = btn;
        }

        private SplitButton splitButton;
        public SplitButton SplitButton { get { return splitButton; } set { splitButton = value; } }

        public void DrawArrow(int left, int top, int width, int height, PaintEventArgs e, Color ArrowColor)
        {
            Image arrowImage = MW5.Plugins.DevicesManager.Properties.Resources.drop_down;
            Rectangle imageRect = new Rectangle(left - arrowImage.Width, top + (height - arrowImage.Height) / 2, arrowImage.Width, arrowImage.Height);
            e.Graphics.DrawImage(arrowImage, imageRect);
        }

        public void DrawBorder(PaintEventArgs e, int width, int height, int splitwidth, Color outerColor, Color innerColor, Color arrowOuter, Color arrowInner, Color buttonInner)
        {
            return;
        }

        public void DrawText(PaintEventArgs e, string text, Font font, Color color, int totalwidth, int totalheight, int splitwidth)
        {
            SolidBrush brush = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisCharacter;
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Rectangle textArea = new Rectangle(7, 1, totalwidth, totalheight);
            e.Graphics.DrawString(text, font, brush, textArea, format);
            brush.Dispose();
        }
    }
}

