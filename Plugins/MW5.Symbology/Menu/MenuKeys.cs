using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Plugins.Symbology.Menu
{
    internal static class MenuKeys
    {
        public const string Labels = "SY_Labels";
        public const string Charts = "SY_Charts";
        public const string QueryBuilder = "SY_QueryBuilder";
        public const string Categories = "SY_Categories";

        public const string LabelMover = "SY_LabelMover";
        public const string SymbolRotator = "SY_SymbolRotator";

        public static string LayerProperties
        {
            get { return MW5.Plugins.Menu.MenuKeys.LayerProperties;  }
        }
    }
}
