using MW5.Tools.Model.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MW5.Tools.Model.Parameters
{
    public class GeographicTransformation
    {
        public string TransType { get; set; }
        public IList<double> ParamArray { get; set; }

        public GeographicTransformation() { }
        public GeographicTransformation(string transType, IList<double> paramArray)
        {
            TransType = transType;
            ParamArray = paramArray;
        }

    }
}
