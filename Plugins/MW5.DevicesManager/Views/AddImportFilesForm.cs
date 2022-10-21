using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MW5.Plugins.DevicesManager
{
    public partial class AddImportFilesForm : Form
    {
        IList<string> fileList;
        public IList<string> SelectedFileList { get; private set; }

        private static string[] supportExts = new string[] {
            ".shp", ".dxf",
            ".tif", ".gtif"
        };

        public AddImportFilesForm(IList<string> list)
        {
            InitializeComponent();

            fileList = list;
        }

        private void AddImportFilesForm_Load(object sender, EventArgs e)
        {
            lvFiles.View = View.Details;
            SetListView();
        }

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

            if (fileList?.Count > 0)
            {
                FillFileList(fileList, (str) => { return str.Split('.').Last().ToUpper() + "文件"; },
                    (str) => { FileInfo fInfo = null; try { fInfo = new System.IO.FileInfo(str); } finally { } return fInfo; }, 1);
            }
        }
        #endregion

        private delegate string GetTypeFunc(string text);
        private delegate FileSystemInfo GetPathInfoFunc(string path);

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

        private void FillFileList(IEnumerable<string> list, GetTypeFunc textFunc, GetPathInfoFunc funcGetInfo, int type/*文件夹=0,文件=1*/)
        {
            int i = lvFiles.Items.Count;
            var nodeList = (from name in list where supportExts.Contains(Path.GetExtension(name)) select new ListViewItem(name, type == 1 ? 2 : 1)).ToArray();
            lvFiles.Items.AddRange(nodeList);
            foreach (var item in nodeList)
            {
                var name = item.Text;
                item.Name = name;
                item.Text = System.IO.Path.GetFileName(name);
                var info = funcGetInfo(name);
                if (info != null)
                {
                    ulong size = 0;
                    if (info is FileInfo finfo)
                        size = (ulong)finfo.Length;
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


        private void filesList_MouseDown(object sender, MouseEventArgs e)
        {
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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in lvFiles.SelectedItems)
            //{
            //    selectedFileList.Add(item.Name);
            //}
            SelectedFileList = (from ListViewItem item in lvFiles.SelectedItems select item.Name).ToList<string>();
        }
    }
}
