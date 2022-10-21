using MW5.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Api.Concrete
{
    public class LayerCheckAttributesRule
    {
        public string name { get; set; }
        private IDictionary<string, CheckRuleItem> _ruleList = new Dictionary<string, CheckRuleItem>();
        public IDictionary<string, CheckRuleItem> ruleList { get { return _ruleList; } set { _ruleList = value; } }
        public LayerCheckAttributesRule()
        {
            // Test Data
            if (System.Diagnostics.Debugger.IsAttached)
            {
                //name = "check rules";
                //ruleList.Add("Field 1", new CheckRuleItem());
                //var itemR = new CheckRuleItem("secondary", "range", "Deifned a range about the value of the field.");
                //itemR.Range.MinVal = 100;
                //itemR.Range.MaxVal = 1000;
                //ruleList.Add("Field 2", itemR);
                //var item = new CheckRuleItem("第三个规则", "列表选项", "定义一个字段内容的列表");
                //item.Range.Values.Add("选项1");
                //item.Range.Values.Add("选项2");
                //item.Range.Values.Add("选项3");
                //ruleList.Add("Field 3", item);
            }
        }
    }

    public class CheckRuleItem
    {
        public string Name { get; set; } // field name
        public string Type { get; set; }

        private RangeOrlist _range = new RangeOrlist();
        public RangeOrlist Range { get { return _range; } set { _range = value; } }
        //public double minVal { get; set; }
        //public double maxVal { get; set; }
        //public IList<string> values { get; set; }

        public string Description { get; set; }

        public bool Nullable { get; set; }
        public bool Unique { get; set; }

        public CheckRuleItem()
        {
        }

        public CheckRuleItem(string _name, string _tyep, string _desc)
        {
            Name = _name;
            Type = _tyep;
            Description = _desc;
        }
    }

    public class RangeOrlist
    {
        public double MinVal { get; set; }
        public double MaxVal { get; set; }
        public string Expression { get; set; }
        private IList<string> _values = new List<string>();
        public IList<string> Values { get { return _values; } set { _values = value; } }

        public RangeOrlist()
        {
            Values = new List<string>();
        }
        public RangeOrlist(double min = 0, double max = 0)
        {
        }
    }

}
