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
    public partial class RelationPanel : UserControl
    {
        public RelationPanel()
        {
            InitializeComponent();
            textBox1.Text = "0.0";
        }

        private Color textboxBC = Color.Empty;
        public string expression
        {
            get
            {
                if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(textBox1.Text))
                    return string.Format($"{comboBox1.Text} {textBox1.Text}");
                else
                    return string.Empty;
            }
            set
            {
                var items = value.Replace("val", "").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (items.Length > 0) comboBox1.Text = items[0];
                if (items.Length > 1) textBox1.Text = items[1];
            }
        }

        public string relation
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = value; }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (!textboxBC.IsEmpty)
                textBox1.BackColor = textboxBC;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                if (!double.TryParse(textBox1.Text + e.KeyChar, out double result))
                {
                    e.Handled = true;
                }
        }
    }
}
