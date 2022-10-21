using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW5.Plugins.AttributeChecker.Views.CheckLayerAttributes
{
    public partial class FormRangeSetting : FormRangeListBase
    {
        public FormRangeSetting()
        {
            InitializeComponent();
        }

        private void FormRangeSetting_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(expression))
            {
                string[] exps = expression.Split(new string[] { "and", "or" }, StringSplitOptions.RemoveEmptyEntries);
                if (expression.Contains("and"))
                    relationPanel1.relation = "and";
                else if (expression.Contains("or"))
                    relationPanel1.relation = "or";
                if (exps.Length > 0)
                    relationPanel1.expression = exps[0].Replace("value ", "");
                if (exps.Length > 1)
                    relationPanel2.expression = exps[1].Replace("value ", "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            expression = string.Format($"value {relationPanel1.expression}");
            if (!string.IsNullOrEmpty(relationPanel2.expression))
            {
                expression += string.Format($"{relationPanel1.relation} value {relationPanel2.expression}");
            }
            if (expression == string.Empty)
            {
                DialogResult = DialogResult.None;
            }
            //if (!string.IsNullOrEmpty(expression))
            //    expression = expression.Replace("value", "").Trim();
        }
    }
}
