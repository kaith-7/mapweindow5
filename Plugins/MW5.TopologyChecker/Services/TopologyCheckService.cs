using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Plugins.TopologyChecker.Model;
using MW5.Services.Concrete;
using MW5.Shared;
using MW5.Shared.CheckResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace MW5.Plugins.TopologyChecker.Services
{
    public class TopologyCheckService
    {
        public static readonly string pointLayerName = "拓扑错误_点";
        public static readonly string lineLayerName = "拓扑错误_线";
        public static readonly string polyLayerName = "拓扑错误_面";
        public static readonly string groupName = "拓扑检查";
        private static TopologyCheckService _instance;
        public static TopologyCheckService GetInstance()
        {
            return _instance == null ? _instance = new TopologyCheckService() : _instance;
        }

        private TopologyCheckService() { }

        public bool Busy { get; private set; }
        private IAppContext _context;
        public event EventHandler<TopologyCheckResultEntryAddArgs> EntryAdded;

        private void FireEntrysAdded(IList<ITopologyCheckResult> entrys)
        {
            DelegateHelper.FireEvent(this, EntryAdded, new TopologyCheckResultEntryAddArgs(entrys));
            //EntryAdded?.Invoke(this, new CheckResultEntryAddArgs(entry));
        }

        public void Run(IAppContext context, ILayerService layerService, IEnumerable<TopologyRuleClass> topologyRules)
        {
            lock (this)
            {
                Busy = true;
                try
                {
                    FireEntrysAdded(null);

                    _context = context ?? throw new ArgumentNullException("context");

                    var broadcaster = _context.Container.Resolve<IBroadcasterService>();
                    EntryAdded += (s, e) => broadcaster.BroadcastEvent(p => p.TopologyCheckEntryAdded_, this, new TopologyCheckResultEntryAddArgs(e.Entrys));

                    // dic[type:dic[layer:list[errids]]]
                    var dicErrors = new Dictionary<TopologyRuleClass, IEnumerable<TopologyCheckRuleResult>>();

                    foreach (var rule in topologyRules)
                    {
                        var layer = context.Layers.First(l => l.Name == rule.Layer);
                        var baseLayer = context.Layers.FirstOrDefault(l => l.Name == rule.BaseLayer);
                        layer?.FeatureSet?.ClearSelection();
                        baseLayer?.FeatureSet?.ClearSelection();
                        IEnumerable<TopologyCheckRuleResult> errList = null;
                        switch (rule.Rule)
                        {
                            case Api.Enums.TopologyRule.None:
                                break;
                            case Api.Enums.TopologyRule.PointNotDuplicate:
                                errList = TopoTest.PointNotDuplicate(layer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PointPointNotDuplicate:
                                errList = TopoTest.PointPointNotDuplicate(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PointOverlapLineEnds:
                                errList = TopoTest.PointOverlapLineEnds(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PointOverlapLine:
                                errList = TopoTest.PointOverlapLine(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PointOnPolygonBoundary:
                                errList = TopoTest.PointOnPolygonBoundary(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PointInPolygonNotBoundary:
                                errList = TopoTest.PointInPolygonNotBoundary(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PointInPolygonAndBoundary:
                                errList = TopoTest.PointInPolygonAndBoundary(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.LineNotOverlaps:
                                errList = TopoTest.LineNotOverlaps(layer.FeatureSet);
                                break;
                            //case Api.Enums.TopologyRule.LineNotSelfOverlaps:
                            //    break;
                            case Api.Enums.TopologyRule.LineNotIntersect:
                                errList = TopoTest.LineNotIntersect(layer.FeatureSet);
                                break;
                            //case Api.Enums.TopologyRule.LineNotSelfIntersect:
                            //    break;
                            case Api.Enums.TopologyRule.LineLineNotOverlaps:
                                errList = TopoTest.LineLineNotOverlaps(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.LineLineNotIntersect:
                                errList = TopoTest.LineLineNotIntersect(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.LineInPolygon:
                                errList = TopoTest.LineInPolygon(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PolygonNotOverlaps:
                                errList = TopoTest.PolygonNotOverlaps(layer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PolygonNoGaps:
                                errList = TopoTest.PolygonNoGaps(layer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PolygonBoundaryMustOverlapsByLines:
                                errList = TopoTest.PolygonBoundaryMustOverlapsByLines(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PolygonMustBeCovredBy:
                                errList = TopoTest.PolygonMustBeCoverdBy(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PolygonMustNotOverlapWith:
                                errList = TopoTest.PolygonMustNotOverlapWith(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case Api.Enums.TopologyRule.PolygonMustPartOverlapWith:
                                errList = TopoTest.PolygonMustPartOverlapWith(layer.FeatureSet, baseLayer.FeatureSet);
                                break;
                            case TopologyRule.PolygonNoMultiParts:
                                errList = TopoTest.PolygonNoMultiParts(layer.FeatureSet);
                                break;
                            default:
                                break;
                        }

                        if (errList != null)
                        {
                            if (dicErrors.ContainsKey(rule) && dicErrors[rule] is List<TopologyCheckRuleResult> errs)
                            {
                                errs.AddRange(errList);
                            }
                            else
                            {
                                dicErrors[rule] = errList;
                            }
                        }
                    }
                    IList<ITopologyCheckResult> resList = new List<ITopologyCheckResult>();
                    foreach (var item in dicErrors)
                    {
                        var layer = item.Key.Layer != null ? _context.Legend.Layers[item.Key.Layer] : null;
                        var baseLayer = item.Key.BaseLayer != null ? _context.Legend.Layers[item.Key.BaseLayer] : null;
                        foreach (var res in item.Value)
                        {
                            resList.Add(new TopologyCheckResult(res.errGeom.GeometryType.EnumToString(), layer, res.FeatureIndex,
                                baseLayer, res.FeatureIndex2,
                                item.Key.Rule.EnumToString(), res.errGeom));
                        }
                    }
                    FireEntrysAdded(resList);

                    var selectedLayer = context.Legend.SelectedLayer;
                    CreateErrLayer(layerService, _context.Map.Projection, dicErrors);
                    context.Legend.SelectedLayer = selectedLayer;
                    //MessageBox.Show("Mission complete!", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
                finally
                {
                    _context.Map.Redraw();
                    Busy = false;
                }
            }
        }

        private void CreateErrLayer(ILayerService layerService, ISpatialReference proj,
            Dictionary<TopologyRuleClass, IEnumerable<TopologyCheckRuleResult>> errDict)
        {
            // TODO: Init Feileds
            // shape, 第一层，检查规则，第二层
            try
            {
                // clear
                var err_point = _context.Legend.Layers.FirstOrDefault(l => l.Name == pointLayerName);
                if (err_point != null)
                    _context.Legend.Layers.Remove(err_point.Handle);

                var err_line = _context.Legend.Layers.FirstOrDefault(l => l.Name == lineLayerName);
                if (err_line != null)
                    _context.Legend.Layers.Remove(err_line.Handle);

                var err_poly = _context.Legend.Layers.FirstOrDefault(l => l.Name == polyLayerName);
                if (err_poly != null)
                    _context.Legend.Layers.Remove(err_poly.Handle);

                var group = _context.Legend.Groups.GroupByName(groupName);
                if (group != null)
                    _context.Legend.Groups.Remove(group.Handle);
                group = _context.Legend.Groups.Add(groupName);

                // AREA ERROR
                var fsArea = new FeatureSet(GeometryType.Polygon);
                fsArea.Projection.CopyFrom(proj);
                fsArea.InteractiveEditing = false;
                InsertGeometry(fsArea, errDict);
                fsArea.Style.Fill.Color = System.Drawing.Color.FromArgb(0xFF, 0x8A, 0x8C);
                fsArea.Style.Line.Color = System.Drawing.Color.FromArgb(0xFF, 0x00, 0x00);
                fsArea.Style.Line.Width = 3;
                layerService.AddDatasource(fsArea, polyLayerName, targetGroupHandle: group.Handle);

                // LINE ERROR
                var fsLine = new FeatureSet(GeometryType.Polyline);
                fsLine.Projection.CopyFrom(proj);
                fsLine.InteractiveEditing = false;
                InsertGeometry(fsLine, errDict);
                fsLine.Style.Line.Color = System.Drawing.Color.FromArgb(0xFF, 0x8A, 0x8C);
                fsLine.Style.Line.Width = 3;
                layerService.AddDatasource(fsLine, lineLayerName, targetGroupHandle: group.Handle);

                // POINT ERROR
                var fsPoint = new FeatureSet(GeometryType.Point);
                fsPoint.Projection.CopyFrom(proj);
                fsPoint.InteractiveEditing = false;
                InsertGeometry(fsPoint, errDict);
                fsPoint.Style.Fill.Color = System.Drawing.Color.FromArgb(0xFF, 0x8A, 0x8C);
                fsPoint.Style.Line.Color = System.Drawing.Color.FromArgb(0xFF, 0x8A, 0x8C);
                fsPoint.Style.Line.Width = 3;
                var marker = fsPoint.Style.Marker;
                //marker.Size = (float)udSize.Value;
                //marker.UpdatePictureScale(pointIconControl1.ScaleIcons, (int)udSize.Value);
                marker.Rotation = 45;
                marker.VectorMarker = VectorMarkerType.Regular;
                marker.VectorSideCount = 4;
                marker.VectorMarkerSideRatio = 0;

                layerService.AddDatasource(fsPoint, pointLayerName, targetGroupHandle: group.Handle);

                _context.Legend.Redraw(Api.Legend.LegendRedraw.LegendAndMap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InsertGeometry(FeatureSet fs, Dictionary<TopologyRuleClass, IEnumerable<TopologyCheckRuleResult>> errDict)
        {
            //fs.Fields.Add("错误类型", AttributeType.String, 0, 16);
            fs.Fields.Add("层1", AttributeType.String, 0, 16);
            fs.Fields.Add("要素ID1", AttributeType.Integer, 0, 8);
            fs.Fields.Add("层2", AttributeType.String, 0, 16);
            fs.Fields.Add("要素ID2", AttributeType.Integer, 0, 8);
            fs.Fields.Add("拓扑规则", AttributeType.String, 0, 32);
            foreach (var item in errDict)
            {
                var layerName = item.Key.Layer;
                var layer = _context.Layers[layerName];
                foreach (var errResult in item.Value)
                {
                    if (errResult.errGeom.GeometryType == fs.GeometryType)
                    {
                        var feat = layer.FeatureSet.Features[errResult.FeatureIndex];
                        var idx = fs.Features.EditAdd(errResult.errGeom);
                        for (int i = 0; i < fs.Fields.Count; i++)
                        {
                            var fieldName = fs.Fields[i].Name;
                            switch (fieldName)
                            {
                                //case "错误类型":
                                //    fs.Features[idx].SetValue(i, fs.GeometryType);
                                //    break;
                                case "层1":
                                    fs.Features[idx].SetValue(i, layerName);
                                    break;
                                case "要素ID1":
                                    fs.Features[idx].SetValue(i, errResult.FeatureIndex);
                                    break;
                                case "层2":
                                    if (!string.IsNullOrEmpty(item.Key.BaseLayer))
                                    {
                                        fs.Features[idx].SetValue(i, item.Key.BaseLayer);
                                    }
                                    break;
                                case "要素ID2":
                                    if (errResult.FeatureIndex2 > -1)
                                    {
                                        fs.Features[idx].SetValue(i, errResult.FeatureIndex2);
                                    }
                                    break;
                                case "拓扑规则":
                                    fs.Features[idx].SetValue(i, EnumHelper.EnumToString(item.Key.Rule));
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
