using MW5.Api.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Shared;
using MW5.Api.Interfaces;

namespace MW5.Plugins.TopologyChecker.Model
{
    public sealed class TopologyRuleClass
    {
        public string Layer { get; private set; }
        public TopologyRule Rule { get; private set; }
        public string BaseLayer { get; private set; }

        public TopologyRuleClass(string layer, string rule, string baseLayer)
        {
            Layer = layer;
            BaseLayer = baseLayer;

            //foreach (var item in Shared.EnumHelper.GetValues<TopologyRule>())
            //{
            //    if (item.EnumToString() == rule)
            //    {
            //        Rule = item;
            //        break;
            //    }
            //}
            Rule = (from r in EnumHelper.GetValues<TopologyRule>() where r.EnumToString() == rule select r).First();
        }
    }

    public class TopologyError
    {
        public int firstIndex { get; private set; }
        public int secondIndex { get; private set; }
        public IGeometry errShape { get; private set; }

        public TopologyError(int idxFirst, int idxSecond, IGeometry err)
        {
            firstIndex = idxFirst;
            secondIndex = idxSecond;
            errShape = err;
        }
    }
}
