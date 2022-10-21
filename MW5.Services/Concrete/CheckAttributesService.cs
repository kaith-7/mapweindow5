using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Shared.CheckResult;
using System;
using System.Collections.Generic;
using System.Linq;
using Vanderbilt.Biostatistics.Wfccm2;

namespace MW5.Services.Concrete
{
    //public class CheckResult
    //{
    //    public int index;
    //    public object value;
    //}

    public class CheckAttributesService : ICheckAttrService
    {
        private ILayer _layer;
        private LayerCheckAttributesRule _rule;
        private IAppContext _context;
        public event EventHandler<AttributeCheckResultEntryAddArgs> EntryAdded;

        public CheckAttributesService()
        {
            if (AttributeChecker.Current == null)
            {
                AttributeChecker.Current = this;
            }
        }

        //public void Init(IAppContext context, ILayer layer, LayerCheckAttributesRule rule)
        public void Init(object context, object layer, object rule)
        {
            _context = context as IAppContext ?? throw new ArgumentNullException("context");
            _layer = layer as ILayer ?? throw new ArgumentNullException("layer");
            _rule = rule as LayerCheckAttributesRule ?? throw new ArgumentNullException("rule");

            var broadcaster = _context.Container.Resolve<IBroadcasterService>();
            EntryAdded += (s, e) => broadcaster.BroadcastEvent(p => p.CheckAttrEntryAdded_, this, new AttributeCheckResultEntryAddArgs(e.Entrys));
        }

        private void FireEntrysAdded(IList<ILayerCheckResult> entrys)
        {
            DelegateHelper.FireEvent(this, EntryAdded, new AttributeCheckResultEntryAddArgs(entrys));
            //EntryAdded?.Invoke(this, new CheckResultEntryAddArgs(entry));
        }

        //public void Run(out IList<ILayerCheckResult> resList)
        public void Run()
        {
            var express = new Expression();
            int count = 0;
            //resList = new List<ILayerCheckResult>();
            var fs = _layer.FeatureSet;
            //form.Rules;

            //GlobalListeners.ReportProgress(string.Empty, 0, msg);
            int nums = fs.NumFeatures * _rule.ruleList.Count;
            int i = 0, idxFld = 0;
            foreach (var field in fs.Fields)
            {
                if (!_rule.ruleList.ContainsKey(field.DisplayName))
                    continue;
                string msg = $"属性检查 {_layer.Name} {field.DisplayName} ";
                var rule = _rule.ruleList[field.DisplayName];

                // TODO:使用查询实现
                if (rule.Unique)
                {
                    var lst = (from n in fs.Features
                               group n by n.GetValue(field.Index) into g
                               where g.Count() > 1
                               select g.Key).ToList<object>();

                    foreach (var dupVal in lst)
                    {
                        var feats = (from n in fs.Features
                                     where dupVal.Equals(n.GetValue(field.Index))
                                     select n);//.ToList<IFeature>();
                        //resList.AddRange(feats);
                        foreach (var feat in feats)
                        {
                            //resList.Add(new LayerCheckResult(_layer, feat.Index, string.Format($"字段 {field.Name} 重复值.")));
                            var res = new LayerCheckResult(_layer.Handle, feat.Index, string.Format($"字段 {field.Name} 重复值."));
                            FireEntrysAdded(new List<ILayerCheckResult> { res });
                            GlobalListeners.ReportProgress(string.Empty, ++i / nums * 100, msg);
                        }
                        count += feats.Count();
                    }
                }
                else if (rule.Range.Values?.Count > 0)
                {
                    var values = string.Join(",", rule.Range.Values);

                    //var feats = (from n in fs.Features
                    //             where values.Contains(n.GetValue(field.Index).ToString())
                    //             select n);//.ToList<IFeature>();

                    //resList.AddRange(feats);
                    //foreach (var feat in fs.Features)
                    //{
                    //    //GlobalListeners.ReportProgress(string.Empty, ++i * 100 / nums, $"{msg}{i}/{nums}");
                    //    var val = feat.GetAsString(field.Index);
                    //    var ok = values.Contains(val);
                    //    if (ok)
                    //        continue;
                    //    var res = new LayerCheckResult(_layer.Handle, feat.Index, string.Format($"字段 {field.Name} 取值 {feat.GetValue(field.Index)} 应在列表({values})中."));
                    //    FireEntrysAdded(new List<ILayerCheckResult> { res });
                    //    count++;
                    //}
                    //count += feats.Count();
                    var exp = "";
                    switch (field.Type)
                    {
                        case Api.Enums.AttributeType.String:
                            foreach (var v in rule.Range.Values)
                            {
                                if (string.IsNullOrEmpty(exp))
                                    exp += $"[{field.Name}] = \"{v}\"";
                                else
                                    exp += $" or [{field.Name}] = \"{v}\"";
                            }
                            break;
                        default:
                            foreach (var v in rule.Range.Values)
                            {
                                if (string.IsNullOrEmpty(exp))
                                    exp += $"[{field.Name}] = {v}";
                                else
                                    exp += $" or [{field.Name}] = {v}";
                            }
                            break;
                    }

                    var bQuery = fs.Table.Query($"NOT ({exp})", out int[] result, out string err);
                    var numRes = result.Length;
                    i = 0;
                    IList<ILayerCheckResult> resList = new List<ILayerCheckResult>();
                    foreach (var idx in result)
                    {
                        //GlobalListeners.ReportProgress(string.Empty, ++i * 100 / numRes, $"{msg}{i}/{numRes}");
                        var feat = fs.Features[i];
                        resList.Add(new LayerCheckResult(_layer.Handle, idx, string.Format($"字段 {field.Name} 取值 {feat.GetValue(field.Index)} 应在列表({values})中.")));
                        count++;
                    }
                    FireEntrysAdded(resList);
                }
                else if (!string.IsNullOrEmpty(rule.Range.Expression))
                {
                    var exp = rule.Range.Expression.ToLower().Replace("value", $"[{field.Name}]");

                    var bQuery = fs.Table.Query($"NOT ({exp})", out int[] result, out string errorString);
                    //GlobalListeners.ReportProgress(string.Empty, 0, msg);
                    var numRes = result.Length;
                    i = 0;
                    IList<ILayerCheckResult> resList = new List<ILayerCheckResult>();
                    foreach (var idx in result)
                    {
                        //GlobalListeners.ReportProgress(string.Empty, ++i * 100 / numRes, $"{msg}{i}/{numRes}");
                        var feat = fs.Features[i];
                        resList.Add(new LayerCheckResult(_layer.Handle, idx, string.Format($"字段 {field.Name} 值为 {feat.GetValue(field.Index)} 应在区间({rule.Range.Expression}).")));
                        count++;
                    }
                    FireEntrysAdded(resList);
                }
                //GlobalListeners.ReportProgress(string.Empty, (++idxFld * fs.NumFeatures) * 100 / nums, msg);
            }

            MessageService.Current.Info($"检查完成 {_layer.Name}");

            //var grid = new System.Windows.Forms.DataGridView();
            //grid.DataSource = resList;
        }

    }
}
