using MW5.Api.Interfaces;
using MW5.Shared.CheckResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Plugins.TopologyChecker.Services
{
    public class TopologyCheckRuleResult
    {
        public int FeatureIndex { get; set; }
        public int FeatureIndex2 { get; set; }
        public IGeometry errGeom { get; set; }
        public TopologyCheckRuleResult(int index, int index2, IGeometry errShp)
        {
            FeatureIndex = index;
            FeatureIndex2 = index2;
            errGeom = errShp;
        }
    }

    public class TopologyCheckResult : ITopologyCheckResult
    {
        public IGeometry ErrGeom { get; set; }
        public string ErrorType { get; set; }
        public int LayerHandle { get; set; }
        public string LayerName { get; set; }
        public int FeatureIndex { get; set; }

        public int LayerHandle2 { get; set; }
        public string LayerName2 { get; set; }
        public int FeatureIndex2 { get; set; }

        public string Rule { get; set; }

        public TopologyCheckResult(string errorType, ILayer layer, int featIndex, ILayer layer2, int featIndex2, string rule, IGeometry errGeom)
        {
            ErrorType = errorType;

            LayerHandle = layer != null ? layer.Handle : -1;
            LayerName = layer?.Name;
            FeatureIndex = featIndex;

            LayerHandle2 = layer2 != null ? layer2.Handle : -1;
            LayerName2 = layer2?.Name;
            FeatureIndex2 = featIndex2;

            Rule = rule;

            ErrGeom = errGeom;
        }
    }
}
