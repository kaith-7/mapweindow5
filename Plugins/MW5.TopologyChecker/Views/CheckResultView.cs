// -------------------------------------------------------------------------------------------
// <copyright file="DebugDockView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using MW5.Api.Concrete;
using MW5.Plugins.TopologyChecker.Views.Abstract;
using MW5.Plugins.Interfaces;
using MW5.Services.Concrete;
using MW5.Shared;
using MW5.Shared.CheckResult;
using MW5.Shared.Log;
using MW5.UI.Controls;
using MW5.UI.Helpers;
using MW5.Plugins.TopologyChecker.Services;
using MW5.Api.Enums;

namespace MW5.Plugins.TopologyChecker.Views
{
    public partial class CheckResultView : DockPanelControlBase, ICheckerView
    {
        private readonly IAppContext _context;
        private readonly BindingListView<ITopologyCheckResult> _entries;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckResultView"/> class.
        /// </summary>
        public CheckResultView(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            InitializeComponent();

            _entries = new BindingListView<ITopologyCheckResult>(new SortableBindingList<ITopologyCheckResult>());

            InitGrid();

            InitCombo();

            VisibleChanged += OnVisibleChanged;
        }

        private void CheckResultView_Load(object sender, EventArgs e)
        {
            this.toolStripEx1.Top = 3;
            this.gradientPanel1.Height = this.toolStripEx1.Height + 8;

            this.boxRules.DropDownStyle = ComboBoxStyle.DropDownList;
            this.boxRepairMethods.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get { yield return toolStripEx1.Items; }
        }

        public IEnumerable<Control> Buttons
        {
            get { yield break; }
        }

        public void Clear()
        {
            _entries.DataSource.Clear();
        }

        private void InitCombo()
        {
            //comboBoxAdv1.Items.Clear();
            //comboBoxAdv1.AddItemsFromEnum<LogLevel>();
            //comboBoxAdv1.SetValue(LogLevel.All);
            //comboBoxAdv1.SelectedIndexChanged += UpdateFilter;
        }

        private void InitGrid()
        {
            grid.SetDatasource(_entries);
            grid.CellDoubleClick += Grid_CellDoubleClick;
            //MW5.Shared.AttributeChecker.Current.EntryAdded += OnEntryAdded;
            Services.TopologyCheckService.GetInstance().EntryAdded += OnEntryAdded;

            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            grid.GridColor = System.Drawing.Color.LightGray;

            boxRules.SelectedIndexChanged += BoxRules_SelectedIndexChanged;
            grid.CellMouseClick += Grid_CellMouseClick;
            contextMenuStrip1.ItemClicked += ContextMenuStrip1_ItemClicked;
        }

        ITopologyCheckResult rowData = null;
        private void Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right
                && e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
            {
                contextMenuStrip1.Items.Clear();
                var row = grid.Rows[e.RowIndex];

                rowData = ((ObjectView<ITopologyCheckResult>)row.DataBoundItem)?.Object;

                var rule = EnumHelper.StringToEnum<TopologyRule>(rowData.Rule);
                var methods = GetRepairMathods(rule);
                methods.ToList().ForEach(item => contextMenuStrip1.Items.Add(item));
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void ContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var rule = EnumHelper.StringToEnum<TopologyRule>(rowData.Rule);
            RepairTopology(rowData.Rule, rule, e.ClickedItem.Text, true);
        }

        private void btnAutoRepairTopologyError_Click(object sender, EventArgs e)
        {
            var ruleDesc = boxRules.Text;
            var rule = EnumHelper.StringToEnum<MW5.Api.Enums.TopologyRule>(ruleDesc);
            var repairMethod = boxRepairMethods.Text;
            RepairTopology(ruleDesc, rule, repairMethod);

            boxRepairMethods.Text = "";
            boxRules.Text = "";
        }

        private void RepairTopology(string ruleDesc, TopologyRule rule, string repairMethod, bool selectedOnly = false)
        {
            System.Collections.IList datasource = null;
            if (selectedOnly)
            {
                datasource = new System.Collections.ArrayList();
                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    rowData = ((ObjectView<ITopologyCheckResult>)row.DataBoundItem)?.Object;
                    datasource.Add(rowData);
                    _entries.DataSource.RemoveAt(row.Index);
                }
            }
            else
                datasource = _entries.DataSource;

            switch (rule)
            {
                case Api.Enums.TopologyRule.None:
                    break;
                case Api.Enums.TopologyRule.PointNotDuplicate:
                    switch (repairMethod)
                    {
                        case "删除重复点":
                            TopoRepair.PointNotDuplicate(datasource, ruleDesc, _context, remainOne: false);
                            break;
                        case "重复点保留一个":
                            TopoRepair.PointNotDuplicate(datasource, ruleDesc, _context);
                            break;
                    }
                    break;
                case Api.Enums.TopologyRule.PointPointNotDuplicate:
                    switch (repairMethod)
                    {
                        //case "删除重复点": // TODO: 需要验证
                        //    TopoRepair.PointNotDuplicate(_entries.DataSource, ruleDesc, _context, remainOne: false);
                        //    break;
                        case "重复点保留一个":
                            TopoRepair.PointPointNotDuplicate(datasource, ruleDesc, _context);
                            break;
                    }
                    break;
                case Api.Enums.TopologyRule.PointOverlapLineEnds:
                case Api.Enums.TopologyRule.PointOverlapLine:
                case Api.Enums.TopologyRule.PointOnPolygonBoundary:
                case Api.Enums.TopologyRule.PointInPolygonNotBoundary:
                case Api.Enums.TopologyRule.PointInPolygonAndBoundary:
                    switch (repairMethod)
                    {
                        case "删除错误点":
                            TopoRepair.PointOverlapLineEnds(datasource, ruleDesc, _context);
                            break;
                    }
                    break;
                case Api.Enums.TopologyRule.LineNotOverlaps:
                    TopoRepair.LineNotOverlaps(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.LineNotSelfOverlaps:
                    break;
                case Api.Enums.TopologyRule.LineNotIntersect:
                    TopoRepair.LineNotIntersect(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.LineNotSelfIntersect: // TODO:
                    break;
                case Api.Enums.TopologyRule.LineLineNotOverlaps: // TODO:
                    break;
                case Api.Enums.TopologyRule.LineLineNotIntersect:
                    TopoRepair.LineLineNotIntersect(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.LineInPolygon:
                    TopoRepair.LineInPolygon(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonNotOverlaps:
                    TopoRepair.PolygonNotOverlaps(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonNoMultiParts:
                    TopoRepair.PolygonNoMultiParts(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonBoundaryMustOverlapsByLines:
                    TopoRepair.PolygonBoundaryMustOverlapsByLines(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonMustBeCovredBy:
                    TopoRepair.PolygonMustBeCovredBy(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonMustNotOverlapWith:
                    TopoRepair.PolygonMustNotOverlapWith(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonMustPartOverlapWith:
                    TopoRepair.PolygonMustPartOverlapWith(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonNoGaps:
                    TopoRepair.PolygonNoGaps(datasource, ruleDesc, _context, repairMethod);
                    break;
                case Api.Enums.TopologyRule.PolygonNoSmallArea: // TODO:
                    break;
                case Api.Enums.TopologyRule.PolygonNoSharpAngle: // TODO:
                    break;
                default:
                    break;
            }
        }

        private string[] GetRepairMathods(TopologyRule rule)
        {
            switch (rule)
            {
                case Api.Enums.TopologyRule.None:
                    break;
                case Api.Enums.TopologyRule.PointNotDuplicate:
                    return new string[] { "删除重复点", "重复点保留一个" };
                case Api.Enums.TopologyRule.PointPointNotDuplicate:
                    return new string[] { "删除重复点", "重复点保留一个" };
                case Api.Enums.TopologyRule.PointOverlapLineEnds:
                    return new string[] { "删除错误点" };
                case Api.Enums.TopologyRule.PointOverlapLine:
                    return new string[] { "删除错误点" };
                case Api.Enums.TopologyRule.PointOnPolygonBoundary:
                    return new string[] { "删除错误点" };
                case Api.Enums.TopologyRule.PointInPolygonNotBoundary:
                    return new string[] { "删除错误点" };
                case Api.Enums.TopologyRule.PointInPolygonAndBoundary:
                    return new string[] { "删除错误点" };
                case Api.Enums.TopologyRule.LineNotOverlaps:
                    return new string[] { "合并到长的线", "合并到短的线", "解散到单独的线" }; // NOTE:擦除短线的部分，擦除长线的部分，单独保留重叠部分
                case Api.Enums.TopologyRule.LineNotSelfOverlaps:
                    return new string[] { "删除重叠部分", "截断重叠部分成为单独的一根线" };
                case Api.Enums.TopologyRule.LineNotIntersect:
                    return new string[] { "打断长的线", "打断短的线", "打断所有相交的线" };
                case Api.Enums.TopologyRule.LineNotSelfIntersect:
                    return new string[] { "打断并解散线" };
                case Api.Enums.TopologyRule.LineLineNotOverlaps:
                    return new string[] { "删除重叠的线", "将重叠部分删除" };
                case Api.Enums.TopologyRule.LineLineNotIntersect:
                    return new string[] { "打断线要素", "删除线要素" };
                case Api.Enums.TopologyRule.LineInPolygon:
                    return new string[] { "删除错误线", "截断并保留在面内的部分" };
                case Api.Enums.TopologyRule.PolygonNotOverlaps:
                    return new string[] { "删除重叠的部分,留空白", "删除重叠部分，新增多边形填充空白", "从面积大的多边形中删除重叠部分", "从面积小的多边形中删除重叠部分" };
                case Api.Enums.TopologyRule.PolygonNoMultiParts:
                    return new string[] { "解散多部件" };
                case Api.Enums.TopologyRule.PolygonBoundaryMustOverlapsByLines:
                    return new string[] { "删除错误多边形" };
                case Api.Enums.TopologyRule.PolygonMustBeCovredBy:
                    return new string[] { "删除错误多边形", "删除边形未被覆盖的部分" };
                case Api.Enums.TopologyRule.PolygonMustNotOverlapWith:
                    return new string[] { "删除错误多边形", "删除多边形重叠的部分" };
                case Api.Enums.TopologyRule.PolygonMustPartOverlapWith:
                    return new string[] { "删除错误多边形" };
                case Api.Enums.TopologyRule.PolygonNoGaps:
                    return new string[] { "缝隙添加新面", "添加新面合并到大面", "添加新面合并到小面" };
                case Api.Enums.TopologyRule.PolygonNoSmallArea:
                    return new string[] { "删除小面" };
                case Api.Enums.TopologyRule.PolygonNoSharpAngle:
                    return new string[] { "钝化" };
                default:
                    break;
            }
            return null;
        }

        private void BoxRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid.UpdateFilter(boxRules.Text);

            boxRepairMethods.Items.Clear();
            var rule = EnumHelper.StringToEnum<MW5.Api.Enums.TopologyRule>(boxRules.Text);
            boxRepairMethods.Items.AddRange(GetRepairMathods(rule));
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //var line = _entries.DataSource[e.RowIndex] as TopologyCheckResult;
                var row = grid.Rows[e.RowIndex];
                var line0 = ((ObjectView<ITopologyCheckResult>)row.DataBoundItem)?.Object;
                if (line0 == null) return;
                var line = line0 as TopologyCheckResult;
                if (line == null) return;
                //Console.WriteLine($"{line.LayerHandle} {line.FeatureIndex} {line.Rule}");

                Api.Interfaces.ILayer errLayer = null;
                switch (line.ErrGeom.GeometryType)
                {
                    case Api.Enums.GeometryType.None:
                        break;
                    case Api.Enums.GeometryType.MultiPoint:
                    case Api.Enums.GeometryType.Point:
                        errLayer = _context.Layers[TopologyCheckService.pointLayerName];
                        break;
                    case Api.Enums.GeometryType.Polyline:
                        errLayer = _context.Layers[TopologyCheckService.lineLayerName];
                        break;
                    case Api.Enums.GeometryType.Polygon:
                        errLayer = _context.Layers[TopologyCheckService.polyLayerName];
                        break;
                    default:
                        break;
                }
                int[] ids = null;
                if (errLayer != null && errLayer.FeatureSet.GetRelatedShapes(line.ErrGeom, Api.Enums.SpatialRelation.Equals, ref ids))
                {
                    errLayer.UpdateSelection(ids, Api.Enums.SelectionOperation.New);
                }

                var layer = _context.Layers[line.LayerName]; // [$"拓扑错误_{line.ErrorType}"];
                layer.UpdateSelection(new int[] { line.FeatureIndex }, Api.Enums.SelectionOperation.New);
                var Baselayer = _context.Layers[line.LayerHandle2];
                if (Baselayer != null)
                    layer.UpdateSelection(new int[] { line.FeatureIndex }, Api.Enums.SelectionOperation.New);
            }
        }

        private void OnEntryAdded(object sender, TopologyCheckResultEntryAddArgs e)
        {
            if (/*!IsDockVisible ||*/ !grid.IsHandleCreated)
            {
                // do nothing records will be added on the next display of the panel
                return;
            }

            lock (grid)
            {
                Action action = () =>
                {
                    if (e.Entrys is IList<ITopologyCheckResult> resList)
                    {
                        if (resList is List<ITopologyCheckResult> listOld)
                        {
                            var iter = _entries.DataSource as IList<ITopologyCheckResult>;
                            if (iter != null)
                                listOld.AddRange(iter);
                            var rules = (from v in listOld select v.Rule).Distinct().ToArray();
                            boxRules.Items.Clear();
                            boxRepairMethods.Items.Clear();
                            boxRules.Items.AddRange(rules);
                        }
                        grid.UpdateFilter("");
                        _entries.DataSource = new SortableBindingList<ITopologyCheckResult>(resList);
                        if (grid.Rows.Count > 0)
                        {
                            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[1];
                        }
                    }
                    else
                    {
                        _entries.DataSource = null;
                        boxRules.Items.Clear();
                    }
                };
                grid.SafeInvoke(action);
            }
        }

        public void EntryAdd(ILayerCheckResult res)
        {
            _entries.DataSource.Add(res);
        }

        public void EntryAddRange(IList<ILayerCheckResult> range)
        {
            foreach (var item in range)
            {
                _entries.DataSource.Add(item);
            }
        }

        /// <summary>
        /// Adds all undisplayed records to the grid.
        /// </summary>
        private void OnVisibleChanged(object sender, EventArgs e)
        {
            if (Visible && Logger.Current.Entries.Any(item => !item.Displayed))
            {
                var list = Logger.Current.Entries.Where(item => !item.Displayed).ToList();

                var target = _entries.DataSource as BindingList<ILogEntry>;
                if (target != null)
                {
                    target.RaiseListChangedEvents = false;

                    foreach (var item in list)
                    {
                        target.Add(item);
                        item.Displayed = true;
                    }

                    target.RaiseListChangedEvents = true;

                    target.ResetBindings();
                }
            }
        }

    }
}