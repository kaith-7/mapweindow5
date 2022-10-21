using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Interfaces;
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

namespace MW5.Plugins.TopologyChecker.Views.CheckLayerAttributes
{
    public partial class TopologyRulesView : Form
    {
        private static TopologyRulesView _instance;
        private readonly IAppContext _context;

        public static TopologyRulesView GetInstance(IAppContext context, ILayerCollection<ILayer> layers)
        {
            return _instance == null ? _instance = new TopologyRulesView(context, layers) : _instance;
        }

        private ListViewItem lastLvi;
        private ListViewItem.ListViewSubItem lastSubItem;
        private ILayerCollection<ILayer> inputLayers = null;

        private int layerIdx = 1;
        private int ruleIdx = 2;
        private int layer2Idx = 3;

        //private ILayerCollection<ILayer> selectedLayers = null;
        public TopologyRulesView(IAppContext context, ILayerCollection<ILayer> layers)
        {
            InitializeComponent();

            _context = context ?? throw new ArgumentNullException("context");

            inputLayers = layers;
            var layerNames = (from n in layers where n.IsVector select n.Name).ToArray(); // TODO：需要判断有没有重名的图层
            StartPosition = FormStartPosition.CenterParent;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            var width = listView1.Width * 2 / 7;
            listView1.Columns.Add("#", 21);
            var colHeader1 = listView1.Columns.Add("图层1", width);
            var colHeaderRule = listView1.Columns.Add("检查规则", width);
            var colHeader2 = listView1.Columns.Add("图层2", width);

            listView1.MouseDown += ListView1_MouseDown;
            listView1.MouseUp += ListView1_MouseUp;

            comboBox1.MouseLeave += ComboBox1_MouseLeave;
            comboBox1.Visible = false;

            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;

            this.MinimumSize = this.Size;
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var band = comboBox1.Bounds;
            var cnt = new Point(band.X + band.Width / 2, band.Y + band.Height / 2);
            var lvi = this.listView1.GetItemAt(cnt.X, cnt.Y);

            //var cntMouse = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
            //var cntMouse = this.listView1.PointToClient(MousePosition);
            //var lviMouse = this.listView1.GetItemAt(cntMouse.X, cntMouse.Y);
            //var lvi = lviMouse;
            //var cnt = cntMouse;

            if (lvi != null)
            {
                var subItem = lvi.GetSubItemAt(cnt.X, cnt.Y);
                if (subItem == lvi.SubItems[layerIdx])
                {
                    string layername = comboBox1.Text;
                    string rulename = lvi.SubItems[ruleIdx].Text;
                    if (!string.IsNullOrEmpty(layername))
                    {
                        var layer = inputLayers.FirstOrDefault(l => l.Name == layername);
                        if (layer != null)
                        {
                            if ((rulename.StartsWith("点") && (layer.FeatureSet.GeometryType == GeometryType.MultiPoint || layer.FeatureSet.GeometryType == GeometryType.Point))
                                || (rulename.StartsWith("线") && layer.FeatureSet.GeometryType == GeometryType.Polyline)
                                || (rulename.StartsWith("面") && layer.FeatureSet.GeometryType == GeometryType.Polygon))
                            {
                                return;
                            }
                        }
                    }
                    lvi.SubItems[layerIdx].Text = string.Empty;
                }
                else if (subItem == lvi.SubItems[ruleIdx])
                {
                    var layername = lvi.SubItems[layer2Idx].Text;
                    var rulename = comboBox1.Text;
                    if (!string.IsNullOrEmpty(layername))
                    {
                        var layer = inputLayers.FirstOrDefault(l => l.Name == layername);
                        if (layer != null)
                        {
                            if ((rulename.Contains("-点") && (layer.FeatureSet.GeometryType == GeometryType.MultiPoint || layer.FeatureSet.GeometryType == GeometryType.Point))
                                || (rulename.Contains("-线") && layer.FeatureSet.GeometryType == GeometryType.Polyline)
                                || (rulename.Contains("-面") && layer.FeatureSet.GeometryType == GeometryType.Polygon))
                            {
                                return;
                            }
                        }
                    }
                    lvi.SubItems[layer2Idx].Text = string.Empty; 
                }
            }
        }

        //ListViewItem itemSelected;
        //ListViewItem.ListViewSubItem subItemSelected;
        private void ComboBox1_MouseLeave(object sender, EventArgs e)
        {
            if (lastSubItem != null)
                lastSubItem.Text = comboBox1.Text;
            comboBox1.Visible = false;
        }

        private void ListView1_MouseDown(object sender, MouseEventArgs e)
        {
            var lvi = this.listView1.GetItemAt(e.X, e.Y);
            if (lvi != null)
            {
                var subItem = lvi.GetSubItemAt(e.X, e.Y);
                if (subItem != lastSubItem && subItem != lvi.SubItems[0])
                {
                    if (lastSubItem != null )
                        lastSubItem.Text = comboBox1.Text;
                    lastSubItem = subItem;
                }
                comboBox1.Visible = false;
            }
        }

        private void ListView1_MouseUp(object sender, MouseEventArgs e)
        {
            var lvi = this.listView1.GetItemAt(e.X, e.Y);
            if (lvi != null)
            {
                lastLvi = lvi;
                var subItem = lvi.GetSubItemAt(e.X, e.Y);
                if (subItem != lastSubItem && subItem != lvi.SubItems[0])
                {
                    if (lastSubItem != null)
                        lastSubItem = subItem;
                    return;
                }
                if (lvi.SubItems.Count > 1)
                {
                    this.comboBox1.SelectedValueChanged -= this.ComboBox1_SelectedValueChanged;
                    if (subItem == lvi.SubItems[layerIdx])
                    {
                        this.comboBox1.Visible = false;
                        Rectangle Rect = subItem.Bounds;
                        this.comboBox1.Items.Clear();
                        this.comboBox1.Items.AddRange(inputLayers.Select(l => l.Name).ToArray());
                        this.comboBox1.Parent = listView1;
                        this.comboBox1.Bounds = Rect;
                        this.comboBox1.Text = subItem.Text;
                        this.comboBox1.Visible = true;
                        this.comboBox1.BringToFront();
                        this.comboBox1.Focus();
                        this.comboBox1.Width = this.listView1.Columns[layerIdx].Width;
                        comboBox1.DroppedDown = true;
                    }
                    else if (subItem == lvi.SubItems[ruleIdx] && lvi.SubItems[layerIdx].Text != null)
                    {
                        var layername = lvi.SubItems[layerIdx].Text;
                        var layer = inputLayers.FirstOrDefault(l => l.Name == layername);
                        if (layer == null || layer.FeatureSet == null)
                            return;

                        this.comboBox1.Visible = false;
                        Rectangle Rect = subItem.Bounds;
                        this.comboBox1.Items.Clear();
                        foreach (var item in GetRulesByLayerType(layer.FeatureSet.GeometryType))
                        {
                            this.comboBox1.Items.Add(Shared.EnumHelper.EnumToString(item));
                        }
                        this.comboBox1.Parent = listView1;
                        this.comboBox1.Bounds = Rect;
                        this.comboBox1.Text = subItem.Text;
                        this.comboBox1.Visible = true;
                        this.comboBox1.BringToFront();
                        this.comboBox1.Focus();
                        comboBox1.DroppedDown = true;
                    }
                    else if (subItem == lvi.SubItems[layer2Idx] && lvi.SubItems[layerIdx].Text != null && lvi.SubItems[ruleIdx].Text != null)
                    {
                        var layername = lvi.SubItems[layerIdx].Text;
                        var rulename = lvi.SubItems[ruleIdx].Text;
                        this.comboBox1.Items.Clear();
                        if (rulename.Contains("-点"))
                        {
                            var layers = (from l in inputLayers where (l.Name != layername && l.FeatureSet != null && (l.FeatureSet.GeometryType == GeometryType.Point || l.FeatureSet.GeometryType == GeometryType.MultiPoint)) select l).ToArray();
                            this.comboBox1.Items.AddRange(layers.Select(l => l.Name).ToArray());
                        }
                        else if (rulename.Contains("-线"))
                        {
                            var layers = (from l in inputLayers where (l.Name != layername && l.FeatureSet != null && (l.FeatureSet.GeometryType == GeometryType.Polyline)) select l).ToArray();
                            this.comboBox1.Items.AddRange(layers.Select(l => l.Name).ToArray());
                        }
                        else if (rulename.Contains("-面"))
                        {
                            var layers = (from l in inputLayers where (l.Name != layername && l.FeatureSet != null && (l.FeatureSet.GeometryType == GeometryType.Polygon)) select l).ToArray();
                            this.comboBox1.Items.AddRange(layers.Select(l => l.Name).ToArray());
                        }

                        this.comboBox1.Visible = false;
                        Rectangle Rect = subItem.Bounds;
                        this.comboBox1.Parent = listView1;
                        this.comboBox1.Bounds = Rect;
                        this.comboBox1.Text = subItem.Text;
                        this.comboBox1.BringToFront();
                        this.comboBox1.Focus();
                        this.comboBox1.Visible = comboBox1.DroppedDown = this.comboBox1.Items.Count > 0;
                    }
                    this.comboBox1.SelectedValueChanged += this.ComboBox1_SelectedValueChanged;
                }
            }
            else
            {
                if (lastSubItem != null)
                    lastSubItem.Text = comboBox1.Text;
                comboBox1.Visible = false;
            }
        }


        private IEnumerable<TopologyRule> GetRulesByLayerType(Api.Enums.GeometryType geomType)
        {
            switch (geomType)
            {
                case Api.Enums.GeometryType.Point:
                case Api.Enums.GeometryType.MultiPoint:
                    return new TopologyRule[] {
                        TopologyRule.PointNotDuplicate,
                        TopologyRule.PointPointNotDuplicate,
                        TopologyRule.PointOverlapLineEnds,
                        TopologyRule.PointOverlapLine,
                        TopologyRule.PointOnPolygonBoundary,
                        TopologyRule.PointInPolygonNotBoundary,
                        TopologyRule.PointInPolygonAndBoundary
                    };
                case Api.Enums.GeometryType.Polyline:
                    return new TopologyRule[] {
                        TopologyRule.LineNotIntersect,
                        TopologyRule.LineNotOverlaps,
                        TopologyRule.LineLineNotIntersect,
                        TopologyRule.LineLineNotOverlaps,
                        TopologyRule.LineInPolygon
                    };
                case Api.Enums.GeometryType.Polygon:
                    return new TopologyRule[] {
                        TopologyRule.PolygonNotOverlaps,
                        TopologyRule.PolygonNoGaps,
                        TopologyRule.PolygonMustPartOverlapWith,
                        TopologyRule.PolygonMustNotOverlapWith,
                        TopologyRule.PolygonMustBeCovredBy,
                        TopologyRule.PolygonBoundaryMustOverlapsByLines,

                        TopologyRule.PolygonNoSmallArea,
                        TopologyRule.PolygonNoSharpAngle,
                        TopologyRule.PolygonNoMultiParts
                    };
                case Api.Enums.GeometryType.None:
                default:
                    return Shared.EnumHelper.GetValues<MW5.Api.Enums.TopologyRule>();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem litem = new ListViewItem(new string[] { "", "", "", "" });
            litem.BackColor = Color.LightBlue;
            listView1.Items.Add(litem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var lastSelectIndex = -1;
            if (listView1.SelectedIndices.Count == 1)
            {
                lastSelectIndex = listView1.SelectedIndices[0];
            }
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.SelectedIndices.Contains(i))
                    listView1.Items.RemoveAt(i);
            }
            if (listView1.Items.Count <= lastSelectIndex || lastSelectIndex == -1)
            {
                if (listView1.Items.Count > 0)
                    listView1.SelectedIndices.Add(listView1.Items.Count - 1);
            }
            else
            {
                listView1.SelectedIndices.Add(lastSelectIndex);
            }
        }

        public IEnumerable<Model.TopologyRuleClass> Rules { get; private set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Visible)
            {
                lastSubItem.Text = comboBox1.Text;
                comboBox1.Visible = false;
            }

            var rules = new List<Model.TopologyRuleClass>();
            foreach (ListViewItem item in this.listView1.Items)
            {
                foreach (ListViewItem.ListViewSubItem i in item.SubItems)
                {
                    Console.WriteLine(i.Text);
                }

                var topo = new Model.TopologyRuleClass(item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
                rules.Add(topo);
            }

            Rules = rules;
        }

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            var cntMouse = this.listView1.PointToClient(MousePosition);
            var lviMouse = this.listView1.GetItemAt(cntMouse.X, cntMouse.Y);
            if (lviMouse != null && lviMouse.Text != null)
            {
                var lviSusItem = lviMouse.GetSubItemAt(cntMouse.X, cntMouse.Y);
                if (lviSusItem == lviMouse.SubItems[ruleIdx])
                {
                    TopologyRule rule = Shared.EnumHelper.StringToEnum<TopologyRule>(lviSusItem.Text);
                    if (Enum.IsDefined(typeof(TopologyRule), rule) && rule != TopologyRule.None)
                    {
                        Help.ShowPopup(this.listView1, lviSusItem.Text, MousePosition);
                    }
                }
            }
        }
    }
}
