using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW5.Plugins.AttributeChecker.Views.CheckLayerAttributes
{
    public class FormRangeListBase : Form
    {
        static string[] operators = {
">",
"<",
">=",
"<=",
"==",
"!="
};
        private string _expression;
        public string expression
        {
            get { return _expression; }
            set
            {
                if (value != null)
                    _expression = value.ToLower();
            }
        }
        public string[] values;
    }
}
