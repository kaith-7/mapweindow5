using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Helpers;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using System.Collections.Generic;
using System.Linq;
using MW5.Tools.Services;
using System.Collections;

namespace MW5.Plugins.ShapeEditor.Tools.Vector_Tools.DataProcess
{
    [CustomLayout]
    [GisTool(GroupKeys.DataProcess, parentGroupKey: GroupKeys.VectorTools)]
    public class XBPHTool : GisTool
    {
        [Input("林班图层", 0, canEmpty: true, SelectedIndex = -1)]
        public IVectorInput InputLB { get; set; }

        [Input("林班字段", 1, canEmpty: true)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndexLB0 { get; set; }

        [Input("小班图层", 2, canEmpty: true)]
        public IVectorInput InputXB { get; set; }

        [Input("林班字段", 3, canEmpty: true)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndexLB { get; set; }

        [Input("小班字段", 4, canEmpty: true)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndexXB { get; set; }

        [Input("带宽", 5, canEmpty: true)]
        public double BarHeight { get; set; }

        [Input("编号方式", 6, canEmpty: true)]
        [ControlHint(ControlHint.Combo)]
        public string CodeType { get; set; }

        [Input("起始编号(全部重排)", 7, canEmpty: true)]
        public int StartXBH { get; set; }


        public override string Description => "小班排号，按照从上到下,从左到右的顺序";

        public override string Name => "小班排号";

        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<XBPHTool>()
                .AddField(t => t.InputLB, t => t.FieldIndexLB0)
                .AddField(t => t.InputXB, t => t.FieldIndexLB)
                .AddField(t => t.InputXB, t => t.FieldIndexXB)
                .AddComboList(t => t.CodeType, new string[] {
                    "全部重排",
                    "递增排号",
                //    "递增排号，处理不连续小班号"
                })
                .SetDefault(t => t.StartXBH, 1)
                .SetDefault(t => t.BarHeight, 0);
        }

        public override bool Validate()
        {
            if (InputLB != null)
            {
                if (FieldIndexLB0 < 0)
                {
                    MessageService.Current.Info("林班图层需要选择林班号字段。");
                    return false;
                }
                if ((InputXB != null && FieldIndexXB >= 0) && FieldIndexLB < 0)
                {
                    MessageService.Current.Info("选择林班图层时需要选择小班图层的林班号字段。");
                    return false;
                }
            }

            return base.Validate();
        }

        public override bool Run(ITaskHandle task)
        {
            /*
             * 参数:
             * 林班图层
             * 林班号字段
             * 小班图层
             * 林班号字段
             * 小班号字段
             * 
             * 带宽
             * 起始编号
             * 是否覆盖已有编号
             * 
             * 如果选择了林班层，则按照林班层进行分组并编号
             * 如果未选择林班层，则按照LBH字段进行分组并编号
             * 如果只选择了小班层和小班编号字段，则统一编号，不分组
             */
            var fsLB = InputLB?.Datasource;
            var fsXB = InputXB?.Datasource;
            //var field = fsXB.Fields[FieldIndexLB];
            // XBPHComparer.Instance.SetBarHeight(BarHeight);

            if (fsLB != null && FieldIndexLB0 > -1)
            {
                #region 林班图层排林班号
                {
                    int StartCode = 1;
                    var dicLB = new SortedSet<KeyValuePair<int, Coordinate>>(XBPHComparer.Instance);

                    int pos = 0;
                    foreach (var featLB in fsLB.Features)
                    {
                        try
                        {
                            this.Callback.Progress("", Math.Min(100, (pos++ * 100) / fsLB.Features.Count), "林班排号...");
                            dicLB.Add(new KeyValuePair<int, Coordinate>(featLB.Index, featLB.Geometry.Center));
                            if (CodeType == "递增排号" || CodeType == "填充不连续编号并递增") // 计算起始小班号
                            {
                                var LBH = featLB.GetAsInteger(FieldIndexXB);
                                if (StartCode < LBH)
                                {
                                    StartCode = LBH + 1;
                                }
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    try
                    {
                        fsLB.StartEditingTable();
                        int lbh = StartCode;
                        var lbhType = fsLB.Fields[FieldIndexLB0].Type;
                        var len_lbh = fsLB.Features.Count.ToString().Length;
                        var fmt = $"D{len_lbh}";
                        pos = 0;
                        foreach (var lb in dicLB)
                        {
                            this.Callback.Progress("", Math.Min(100, (pos++ * 100) / fsLB.Features.Count), "林班排号...");
                            var oid = lb.Key;
                            var featLB = fsLB.Features[oid];
                            if (lbhType == AttributeType.String)
                                featLB.SetValue(FieldIndexLB0, string.Format("{0:" + fmt + "}", lbh++));
                            else
                                featLB.SetValue(FieldIndexLB0, lbh++);
                        }
                        fsLB.StopEditingTable();
                    }
                    catch (Exception)
                    {
                        fsLB.StopEditingTable(false);
                        throw;
                    }
                }
                #endregion

                // 用排好的林班，对在林班内的小班按林班分别排号
                if (InputXB != null && FieldIndexXB > -1)
                {
                    try
                    {
                        int pos = 0;
                        foreach (var featLB in fsLB.Features)
                        {
                            var dicXB = new SortedSet<KeyValuePair<int, Coordinate>>(XBPHComparer.Instance);
                            fsXB.ClearSelection();
                            int[] resultArray = null;

                            var majorAxis = fsLB.Projection.SemiMajor;
                            double Tolerance = 0.001;
                            if (fsLB.Projection.IsGeographic)
                                Tolerance /= (majorAxis * 2 * Math.PI) / 360f;

                            var filterGeom = featLB.Geometry.Buffer(Tolerance, 4);
                            if (fsXB.GetRelatedShapes(filterGeom, SpatialRelation.Contains, ref resultArray))
                            {
                                int StartCode = Math.Max(1, StartXBH);

                                for (int k = resultArray.Length - 1; k >= 0; k--)
                                {
                                    var idx = resultArray[k];
                                    var featXB = fsXB.Features[idx];
                                    try
                                    {
                                        dicXB.Add(new KeyValuePair<int, Coordinate>(idx, featXB.Geometry.Center));
                                        if (CodeType == "递增排号" || CodeType == "填充不连续编号并递增") // 计算起始小班号
                                        {
                                            var XBH = featXB.GetAsInteger(FieldIndexXB);
                                            if (StartCode < XBH)
                                            {
                                                StartCode = XBH + 1;
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        continue;
                                    }
                                }

                                fsXB.StartEditingTable();
                                int xbh = StartCode;
                                var LBH = featLB.GetValue(FieldIndexLB0);
                                var xbhType = fsXB.Fields[FieldIndexXB].Type;
                                var len_xbh = fsXB.Features.Count.ToString().Length;
                                var fmt = $"D{len_xbh}";
                                foreach (var xb in dicXB)
                                {
                                    this.Callback.Progress("", Math.Min(100, (pos++ * 100) / fsXB.Features.Count), "小班排号...");
                                    var oid = xb.Key;
                                    var featXB = fsXB.Features[oid];
                                    if (xbhType == AttributeType.String)
                                        featXB.SetValue(FieldIndexXB, string.Format("{0:" + fmt + "}", xbh++));
                                    else
                                        featXB.SetValue(FieldIndexXB, xbh++);
                                    if (FieldIndexLB > -1)
                                        featXB.SetValue(FieldIndexLB, LBH);
                                }
                            }
                        }
                        fsXB.StopEditingTable();
                    }
                    catch (Exception ex)
                    {
                        fsXB.StopEditingTable(false);
                        throw;
                    }
                }
            }
            else if (fsXB != null)
            {
                if (FieldIndexLB > -1)
                {
                    try
                    {
                        int pos = 0;
                        var listLB = (from n in fsXB.Features
                                      select n.GetValue(FieldIndexLB)).Distinct().ToList();
                        foreach (var LBH in listLB)
                        {
                            int StartCode = Math.Max(1, StartXBH);

                            var dicXB = new SortedSet<KeyValuePair<int, Coordinate>>(XBPHComparer.Instance);
                            foreach (var feat in fsXB.Features.Where(f => f.GetValue(FieldIndexLB) == LBH))
                            {
                                try
                                {
                                    dicXB.Add(new KeyValuePair<int, Coordinate>(feat.Index, feat.Geometry.Center));
                                    if (CodeType == "递增排号" || CodeType == "填充不连续编号并递增") // 计算起始小班号
                                    {
                                        var XBH = feat.GetAsInteger(FieldIndexXB);
                                        if (StartCode < XBH)
                                        {
                                            StartCode = XBH + 1;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    continue;
                                }
                            }

                            fsXB.StartEditingTable();
                            int xbh = StartCode;
                            var xbhType = fsXB.Fields[FieldIndexXB].Type;
                            var len_xbh = fsXB.Features.Count.ToString().Length;
                            var fmt = $"D{len_xbh}";
                            foreach (var xb in dicXB)
                            {
                                this.Callback.Progress("", Math.Min(100, (pos++ * 100) / fsXB.Features.Count), "小班排号...");
                                var oid = xb.Key;
                                var featXB = fsXB.Features[oid];
                                if (xbhType == AttributeType.String)
                                    featXB.SetValue(FieldIndexXB, string.Format("{0:" + fmt + "}", xbh++));
                                else
                                    featXB.SetValue(FieldIndexXB, xbh++);
                            }
                        }
                        fsXB.StopEditingTable();
                    }
                    catch (Exception ex)
                    {
                        fsXB.StopEditingTable(false);
                        throw;
                    }
                }
                else if (FieldIndexXB > -1)
                {
                    int StartCode = Math.Max(1, StartXBH);
                    int pos = 0;
                    var dicXB = new System.Collections.Generic.SortedSet<KeyValuePair<int, Coordinate>>(XBPHComparer.Instance);
                    foreach (var feat in fsXB.Features)
                    {
                        try
                        {
                            this.Callback.Progress("", Math.Min(100, (pos++ * 100) / fsXB.Features.Count), "小班排号...");
                            dicXB.Add(new KeyValuePair<int, Coordinate>(feat.Index, feat.Geometry.Center));
                            if (CodeType == "递增排号" || CodeType == "填充不连续编号并递增") // 计算起始小班号
                            {
                                var XBH = feat.GetAsInteger(FieldIndexXB);
                                if (StartCode < XBH)
                                {
                                    StartCode = XBH + 1;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                    }

                    try
                    {
                        pos = 0;
                        fsXB.StartEditingTable();
                        var xbh = StartCode;
                        var xbhType = fsXB.Fields[FieldIndexXB].Type;
                        var len_xbh = fsXB.Features.Count.ToString().Length;
                        var fmt = $"D{len_xbh}";
                        foreach (var xb in dicXB)
                        {
                            this.Callback.Progress("", Math.Min(100, (pos++ * 100) / fsXB.Features.Count), "小班排号...");
                            int oid = xb.Key;
                            var featXB = fsXB.Features[oid];
                            if (xbhType == AttributeType.String)
                                featXB.SetValue(FieldIndexXB, string.Format("{0:" + fmt + "}", xbh++));
                            else
                                featXB.SetValue(FieldIndexXB, xbh++);
                        }
                        fsXB.StopEditingTable();
                    }
                    catch (Exception ex)
                    {
                        fsXB.StopEditingTable(false);
                        throw;
                    }
                }
            }

            return true;
        }

        public override bool AfterRun()
        {
            return base.AfterRun();
        }
    }

    class XBPHComparer : IComparer<KeyValuePair<int, Coordinate>>
    {
        static double BarHeight = 0.0f;
        static private XBPHComparer _instance = null;
        static public void SetBarHeight(double height) { BarHeight = height; }
        static public XBPHComparer Instance { get { return _instance == null ? _instance = new XBPHComparer() : _instance; } }
        private XBPHComparer() { }

        public int Compare(KeyValuePair<int, Coordinate> X, KeyValuePair<int, Coordinate> Y)
        {
            var A = X.Value;
            var B = Y.Value;
            if (A != null && B != null)
            {
                var Y1 = BarHeight > 0 ? (int)(A.Y / BarHeight) : A.Y;
                var Y2 = BarHeight > 0 ? (int)(B.Y / BarHeight) : B.Y;
                if (Y1 < Y2)
                {
                    return 1;
                }
                else if (Y1 > Y2)
                {
                    return -1;
                }
                else
                {
                    if (A.X > B.X)
                    {
                        return 1;
                    }
                    else if (A.X < B.X)
                    {
                        return -1;
                    }
                    else if (A.X == B.X)
                        return 1;
                }
            }
            return 0;
        }

    }
}
