using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW5.Plugins.ShapeEditor.Views
{
    public partial class FieldsSelection : Form
    {
        static private IDictionary<string, FieldsSelection> _instance = new Dictionary<string, FieldsSelection>();
        static public void RemoveInstance(string layerFileName)
        {
            if (_instance.ContainsKey(layerFileName))
            {
                _instance.Remove(layerFileName);
            }
        }
        static public FieldsSelection GetInstance(IFeatureSet fs)
        {
            var name = fs.Filename;
            if (!_instance.ContainsKey(name))
            {
                _instance[name] = new FieldsSelection();
                _instance[name].InputFeatureSet = fs;
            }
            return _instance[name];
        }

        private string Title;

        private System.Collections.IList fieldsIndeciesSelected = null;
        public IEnumerable<int> FieldsIndecies
        {
            get
            {
                foreach (var item in fieldsIndeciesSelected)
                {
                    yield return (int)item;
                }
            }
        }
        public IFeatureSet InputFeatureSet { get; set; }
        private FieldsSelection()
        {
            InitializeComponent();
            Title = Text;
            listView1.CheckBoxes = true;
            listView1.View = View.Details;
            listView1.GridLines = true;
            DoubleBuffered = true;
            MinimumSize = Size;
        }
        private void FieldsSelection_Load(object sender, EventArgs e)
        {
            if (InputFeatureSet == null)
                return;

            Text = Title + InputFeatureSet.Name;

            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text != InputFeatureSet.Fields[i].DisplayName)
                    break;
                i++;
            }
            if (i < InputFeatureSet.Fields.Count) // 字段不同的话重新添加
            {
                listView1.Clear();

                listView1.Columns.Add("字段", this.Width / 3);
                listView1.Columns.Add("值", this.Width / 3);

                foreach (var field in InputFeatureSet.Fields)
                {
                    string text = field.DisplayName;
                    var item = listView1.Items.Add(text);
                    item.Checked = true;
                    if (InputFeatureSet.NumSelected == 1)
                    {
                        var feat = InputFeatureSet.Features[InputFeatureSet.SelectedIndices[0]];
                        var val = feat.GetValue(field.Index).ToString();
                        item.SubItems.Add(val);
                    }
                }
            }
        }

        private void SelectAll(Button btn)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = btn.Text == "全选";
            }
            btn.Text = btn.Text == "全选" ? "全不选" : "全选";
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                SelectAll(btn);
            }
        }

        private void btnSelectReverse_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (listView1.CheckedIndices.Count == 0 || listView1.CheckedIndices.Count == listView1.Items.Count)
                {
                    SelectAll(btnSelectAll);
                }
                else
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        listView1.Items[i].Checked = !listView1.Items[i].Checked;
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fieldsIndeciesSelected = listView1.CheckedIndices;
        }
    }
}
