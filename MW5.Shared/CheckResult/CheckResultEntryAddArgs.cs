using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Shared.CheckResult
{
    public class AttributeCheckResultEntryAddArgs : EventArgs
    {
        public AttributeCheckResultEntryAddArgs(IList<ILayerCheckResult> entrys)
        {
            Entrys = entrys;
        }

        public IList<ILayerCheckResult> Entrys { get; private set; }
    }

    public class TopologyCheckResultEntryAddArgs : EventArgs
    {
        public TopologyCheckResultEntryAddArgs(IList<ITopologyCheckResult> entrys)
        {
            Entrys = entrys;
        }

        public IList<ITopologyCheckResult> Entrys { get; private set; }
    }

}
