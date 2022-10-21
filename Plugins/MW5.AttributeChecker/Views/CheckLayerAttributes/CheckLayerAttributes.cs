using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSON = System.Text.Json;

namespace MW5.Plugins.AttributeChecker.Views.CheckLayerAttributes
{
    public partial class CheckLayerAttributes : Form
    {
        private static IDictionary<string, CheckLayerAttributes> _instance = new Dictionary<string, CheckLayerAttributes>();

        public static CheckLayerAttributes GetInstance(ILayer layer)
        {
            var name = layer.FeatureSet.Filename;
            return _instance.ContainsKey(name) ? _instance[name] : _instance[name] = new CheckLayerAttributes(layer);
        }

        LayerCheckAttributesRule rules = new LayerCheckAttributesRule();
        public LayerCheckAttributesRule Rules { get { return rules; } }
        private ILayer inputLayer = null;
        public CheckLayerAttributes(ILayer layer)
        {
            InitializeComponent();

            inputLayer = layer;
            Load += CheckLayerAttributes_Load;
            lvCheckRules.View = View.Details;
            StartPosition = FormStartPosition.CenterParent;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox1.MouseLeave += ComboBox1_MouseLeave;
            comboBox1.DropDownClosed += ComboBox1_DropDownClosed;
        }

        private void CheckLayerAttributes_Load(object sender, EventArgs e)
        {
            lvCheckRules.FullRowSelect = true;
            lvCheckRules.Clear();
            lvCheckRules.Columns.Add("字段名称", this.Width / 4);
            lvCheckRules.Columns.Add("类型", this.Width / 4);
            lvCheckRules.Columns.Add("检查规则", this.Width / 4);

            foreach (var fld in inputLayer.FeatureSet.Fields)
            {
                var item = lvCheckRules.Items.Add(fld.DisplayName);
                string type = "未知";
                switch (fld.Type)
                {
                    case Api.Enums.AttributeType.String:
                        type = "字符串";
                        break;
                    case Api.Enums.AttributeType.Integer:
                        type = "整数";
                        break;
                    case Api.Enums.AttributeType.Double:
                        type = "浮点数";
                        break;
                    case Api.Enums.AttributeType.Boolean:
                        type = "逻辑";
                        break;
                    case Api.Enums.AttributeType.Date:
                        type = "日期";
                        break;
                }
                item.SubItems.Add(type);
                item.SubItems.Add("").Tag = "RULE";
            }

            string filename = txtRuleTemplate.Text;
            if (string.IsNullOrEmpty(filename))
            {
                filename = inputLayer.CheckRuleFile;
            }
            if (!string.IsNullOrEmpty(filename))
                InitRule(filename);
            else
                InitRule();

            btnExportCheckTemplate.Enabled = false;

            comboBox1.Visible = false;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "", "唯一值", "列表项", "取值范围" });
        }

        private void InitRule()
        {
            // set column of listview
            foreach (ListViewItem item in lvCheckRules.Items)
            {
                var fieldName = item.Text;
                if (rules.ruleList.ContainsKey(fieldName))
                {
                    var rule = rules.ruleList[fieldName];
                    if (rule.Name == fieldName)
                    {
                        if (item.SubItems.Count == 3)
                            item.SubItems[2].Text = rule.Type;
                        else
                            item.SubItems.Add(rule.Type);
                    }
                }
            }
        }

        private void InitRule(string filename)
        {
            // Read check rule file and set column of listview
            LayerCheckAttributesRule ruleDeserialize;
            try
            {
                using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.UTF8))
                {
                    var jsonText = reader.ReadToEnd();
                    ruleDeserialize = JSON.JsonSerializer.Deserialize<LayerCheckAttributesRule>(jsonText);
                    rules = ruleDeserialize ?? rules;
                    InitRule();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "检查规则(*.rule)|*.rule";
            dialog.Title = "选择检查规则";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var filename = dialog.FileName;
                txtRuleTemplate.Text = filename;
                InitRule(filename);
                inputLayer.CheckRuleFile = filename;
                comboBox1.Visible = false;
            }
        }

        private void btnExportCheckTemplate_Click(object sender, EventArgs e)
        {
            // Save check rule to file, Use JSON file format
            /* Data Struct
             * Rule Name : Default name is "检查规则"
             * Fields
             *  Filed
             *      Name
             *      Rule
             *          Nullable
             *          Unique
             *          Other Rule 
             *              Range
             *              List
             *              Calculate
             *              Relation
             */

            var ruleFilename = this.txtRuleTemplate.Text;
            if (string.IsNullOrEmpty(ruleFilename) || !System.IO.File.Exists(ruleFilename))
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "检查规则(*.rule)|*.rule";
                dialog.Title = "选择检查规则";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    ruleFilename = dialog.FileName;
                }
            }
            using (var writer = new System.IO.StreamWriter(path: ruleFilename, append: false, encoding: Encoding.ASCII))
            {
                //var encoderSetting = new TextEncoderSettings();
                //encoderSetting.AllowRange(UnicodeRanges.All);
                //encoderSetting.AllowCharacters('\u003C', '\u003E');
                JSON.JsonSerializerOptions options = new JSON.JsonSerializerOptions
                {
                    WriteIndented = true,
                    //Encoder = JavaScriptEncoder.Create(encoderSetting),
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                };

                JSON.JsonSerializer.Serialize<LayerCheckAttributesRule>(writer.BaseStream, rules, options);
            }

            this.btnExportCheckTemplate.Enabled = false;
        }

        private void SetRang()
        {
            ListViewItem item = itemSelected;
            ListViewItem.ListViewSubItem subItem = subItemSelected;

            CheckRuleItem ruleItem = null;
            if (comboBox1.Text == "列表项" || comboBox1.Text == "取值范围")
            {
                FormRangeListBase frm = null;
                if (comboBox1.Text == "列表项")
                {
                    frm = (FormRangeListBase)(new FormListSetting());
                }
                else
                {
                    frm = (FormRangeListBase)(new FormRangeSetting());
                }

                frm.StartPosition = FormStartPosition.CenterParent;
                if (rules.ruleList.ContainsKey(item.Text))
                {
                    frm.expression = rules.ruleList[item.Text].Range.Expression;
                    frm.values = rules.ruleList[item.Text].Range.Values.ToArray();
                }
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    ruleItem = new CheckRuleItem(item.Text, "", "");
                    if (frm.values?.Length > 0) // 有列表的话按找列表检查
                    {
                        ruleItem.Range.Values = frm.values.ToList<string>();
                        ruleItem.Type = "列表项";
                    }
                    if (!string.IsNullOrEmpty(frm.expression))
                    {
                        ruleItem.Range.Expression = frm.expression;
                        ruleItem.Type = "取值范围";
                    }
                    //subItem.Text = item.Text;
                }
            }
            else if (comboBox1.Text == "唯一值")
            {
                ruleItem = new CheckRuleItem(item.Text, "", "");
                ruleItem.Unique = true;
            }
            if (ruleItem != null)
            {
                if (!rules.ruleList.ContainsKey(item.Text))
                {
                    rules.ruleList.Add(item.Text, ruleItem);
                }
                else
                {
                    rules.ruleList[item.Text] = ruleItem;
                }
                this.btnExportCheckTemplate.Enabled = true;
            }
        }
        private void lvCheckRules_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            itemSelected = lvCheckRules.GetItemAt(e.X, e.Y);
            subItemSelected = itemSelected.GetSubItemAt(e.X, e.Y);
            if (subItemSelected?.Tag?.ToString() == "RULE")
            {
                //MessageBox.Show(this, subItem?.Text, "SunToonGIS");
                SetRang();
            }
        }

        ListViewItem itemSelected;
        ListViewItem.ListViewSubItem subItemSelected;
        private void ComboBox1_MouseLeave(object sender, EventArgs e)
        {
            //if(subItemSelected !=null)
            //    subItemSelected.Text = comboBox1.Text;
            comboBox1.Visible = false;
        }

        private void ComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.Visible/* && (comboBox1.Text == "取值范围" || comboBox1.Text == "列表项")*/)
                SetRang();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subItemSelected != null)
                subItemSelected.Text = comboBox1.Text;
            comboBox1.Visible = false;
            //if (comboBox1.Text == "取值范围" || comboBox1.Text == "列表项")
            //    SetRang();

            if (comboBox1.Text == "唯一值")
            {
                var name = itemSelected.Text;
                var ruleItem = new CheckRuleItem(name, "唯一值", "");
                ruleItem.Unique = true;
                if (!rules.ruleList.ContainsKey(name))
                {
                    rules.ruleList.Add(name, ruleItem);
                }
                else
                {
                    rules.ruleList[name] = ruleItem;
                }
                this.btnExportCheckTemplate.Enabled = true;
            }
        }

        private void lvCheckRules_MouseClick(object sender, MouseEventArgs e)
        {
            itemSelected = lvCheckRules.GetItemAt(e.X, e.Y);
            subItemSelected = itemSelected.GetSubItemAt(e.X, e.Y);
            if (subItemSelected?.Tag?.ToString() == "RULE")
            {
                comboBox1.Parent = lvCheckRules;
                comboBox1.Visible = false;
                comboBox1.Bounds = subItemSelected.Bounds;
                comboBox1.Text = subItemSelected.Text;
                comboBox1.BringToFront();
                comboBox1.Focus();
                comboBox1.Visible = true;
                comboBox1.DroppedDown = true;
            }
        }
    }
}
