using MW5.Tools.Views;
using MW5.UI.Forms;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW5.Plugins.DevicesManager
{
    public partial class CsvToShp : MapWindowView
    {
        DataTable _dataTable;
        public string XColName { get; private set; }
        public string YColName { get; private set; }

        MW5.Plugins.Services.ILayerService _layerService;

        public CsvToShp(MW5.Plugins.Services.ILayerService layerService)
        {
            InitializeComponent();
            _layerService = layerService;
        }

        public CsvToShp()
        {
            InitializeComponent();
        }

        private void ChooseColumnView_Load(object sender, EventArgs e)
        {
           
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
          bool result=  Api.Static.GdalUtils.Instance.ConvertPoint(_dataTable, textBox_Out.Text, cmbX.Text, cmbY.Text);
            if (result)
                MessageBox.Show("转换成功!","提示");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox_In_TextChanged(object sender, EventArgs e)
        {
            string input = textBox_In.Text;
            _dataTable = Api.Static.GdalUtils.Instance.GetTableFromFile(input);
            var listCol = _dataTable.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            cmbX.Items.AddRange(listCol);
            cmbY.Items.AddRange(listCol);

            cmbX.Text = listCol.Where(x => x.ToLower().Contains("x")).FirstOrDefault()?.ToString();
            cmbY.Text = listCol.Where(x => x.ToLower().Contains("y")).FirstOrDefault()?.ToString();
            textBox_Out.Text = input.Substring(0, input.Length - 3) + "conv.shp";
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() ;
            dialog.Filter = "Excel文件|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_In.Text = dialog.FileName;
            }

        }
    }
}
