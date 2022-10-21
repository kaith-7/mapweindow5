// -------------------------------------------------------------------------------------------
// <copyright file="PolygonPictureView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.UI.Forms;
using MW5.UI.Helpers;
using MW5.Plugins.PictureView.Views.Abstract;
using System.IO;
using MW5.Plugins.Services;
using System.Text;
//using MW5.Plugins.Interfaces;
using System.Xml;
using MW5.Api.Legend;
using MW5.Api.Legend.Abstract;

namespace MW5.Plugins.PictureView.Views
{
    public partial class PolygonPictureView : Form
    {
        public string PictureFullPath { get { return textBox_PicturePath.Text; } set { textBox_PicturePath.Text = value; } }
        public string DatasourceName { get; private set; }
        public LayerCollection<ILegendLayer> Layers { get; set; }
        public string LayerName { get { return comboBox_Layer.Text; } private set { comboBox_Layer.Text = value; } }
        public string KeyFeild { get { return comboBox_KeyField.Text; } private set { comboBox_KeyField.Text = value; } }
        
        public PolygonPictureView(string dsName, LayerCollection<ILegendLayer> layers, string layerName, string picPath, string keyField = "imageid")
        {
            InitializeComponent();

            DatasourceName = dsName;
            Layers = layers;
            foreach (var layer in layers)
            {
                comboBox_Layer.Items.Add(layer.Name);
                if (layer.Name == layerName)
                {
                    foreach (var fld in layer.FeatureSet.Fields)
                    {
                        comboBox_KeyField.Items.Add(fld.DisplayName);
                    }
                    KeyFeild = string.IsNullOrEmpty(keyField) || layer.FeatureSet.Fields.IndexByName(keyField) < 0 
                        ? (string)comboBox_KeyField.Items[0] 
                        : keyField;
                }
            }
            LayerName = layerName;
            PictureFullPath = picPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = textBox_PicturePath.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PictureFullPath = dialog.SelectedPath;
                textBox_PicturePath.Text = PictureFullPath;
            }
        }
        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //public void ViewOkClicked(object sender, EventArgs e)
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            PictureFullPath = textBox_PicturePath.Text;
            string imagePath = PictureFullPath;// System.IO.Path.Combine(PictureFullPath, LayerName);
            if (!Directory.Exists(imagePath))
            {
                MessageService.Current.Warn("请选择正确的路径!!!");
            }
            else
            {
                //将路径和字段信息写入临时文件
                
                string configFile = System.IO.Path.Combine(Path.GetDirectoryName(DatasourceName), "picture_info.xml"); // Directory.GetCurrentDirectory();

                var conf = new XmlDocument();
                var item = conf.CreateElement("PictureInfo");
                var item0 = conf.AppendChild(item);
                item.SetAttribute("FilePath", DatasourceName);
                item.SetAttribute("PicturePath", PictureFullPath);
                var subItem = conf.CreateElement("Layers");
                item.AppendChild(subItem);
                var lyrItem = subItem.AppendChild(conf.CreateElement("Layer"));
                ((XmlElement)lyrItem).SetAttribute("LayerName", LayerName);
                ((XmlElement)lyrItem).SetAttribute("KeyField", KeyFeild);

                conf.Save(configFile);
            }
            this.Close();
        }

        private void comboBox_Layer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_KeyField.Items.Clear();
            ILegendLayer layer = null;
            foreach (var item in Layers)
            {
                if (item.Name == comboBox_Layer.SelectedItem.ToString())
                {
                    layer = item;
                }
            }
            foreach (var fld in layer.FeatureSet.Fields)
            {
                comboBox_KeyField.Items.Add(fld.DisplayName);
            }
        }
    }
}