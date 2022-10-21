using MW5.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Plugins.TopologyChecker.Services
{
    class TopoConfig
    {
        public static double Tolerance { get; set; }

        protected static double CalcTolarance(ISpatialReference proj)
        {
            var majorAxis = proj.SemiMajor;
            Tolerance = 0.001;
            if (proj.IsGeographic)
                Tolerance /= (majorAxis * 2 * Math.PI) / 360f;
            return Tolerance;
        }

    }
}
