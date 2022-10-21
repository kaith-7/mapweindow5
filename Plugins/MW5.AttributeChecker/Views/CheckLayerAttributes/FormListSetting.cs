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
    public partial class FormListSetting : FormRangeListBase
    {
        public FormListSetting()
        {
            InitializeComponent();
        }

        private void FormRangeSetting_Load(object sender, EventArgs e)
        {
            richTextBox1.Lines = values;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            values = richTextBox1.Lines;
        }
    }
}
