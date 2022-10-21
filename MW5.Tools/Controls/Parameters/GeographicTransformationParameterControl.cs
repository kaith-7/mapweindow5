using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Tools.Model;
using MW5.Tools.Model.Parameters;

namespace MW5.Tools.Controls.Parameters
{
    public partial class GeographicTransformationParameterControl : ParameterControlBase
    {
        public GeographicTransformationParameterControl()
        {
            InitializeComponent();

            this.comboBoxAdv1.Items.AddRange(new string[]{
                "",
                "三参数",
                "七参数"});

            this.comboBoxAdv1.SelectedValueChanged += ComboBoxAdv1_SelectedValueChanged;

            geoTransformParameterControl1.Caption = "X平移";
            geoTransformParameterControl2.Caption = "Y平移";
            geoTransformParameterControl3.Caption = "Z平移";
            geoTransformParameterControl4.Caption = "X旋转";
            geoTransformParameterControl5.Caption = "Y旋转";
            geoTransformParameterControl6.Caption = "Z旋转";
            geoTransformParameterControl7.Caption = "缩放";

            geoTransformParameterControl1.SetValue(0);
            geoTransformParameterControl2.SetValue(0);
            geoTransformParameterControl3.SetValue(0);
            geoTransformParameterControl4.SetValue(0);
            geoTransformParameterControl5.SetValue(0);
            geoTransformParameterControl6.SetValue(0);
            geoTransformParameterControl7.SetValue(0);
            if (System.Diagnostics.Debugger.IsAttached)
            {
                geoTransformParameterControl1.SetValue(-93.5);
                geoTransformParameterControl2.SetValue(-75.5);
                geoTransformParameterControl3.SetValue(-14.5);
            }

            this.MaximumSize = this.Size;
            height3 = geoTransformParameterControl4.Top;

            this.Size = new Size(this.Size.Width, geoTransformParameterControl1.Top);
            var visible = false;
            geoTransformParameterControl1.Visible = visible;
            geoTransformParameterControl2.Visible = visible;
            geoTransformParameterControl3.Visible = visible;
            geoTransformParameterControl4.Visible = visible;
            geoTransformParameterControl5.Visible = visible;
            geoTransformParameterControl6.Visible = visible;
            geoTransformParameterControl7.Visible = visible;
        }
        private int height3;
        private void ComboBoxAdv1_SelectedValueChanged(object sender, EventArgs e)
        {
            geoTransformParameterControl1.Visible = true;
            geoTransformParameterControl2.Visible = true;
            geoTransformParameterControl3.Visible = true;
            var visible = false;
            switch (this.comboBoxAdv1.Text)
            {
                case "":
                    this.Size = new Size(this.Size.Width, geoTransformParameterControl1.Top);
                    geoTransformParameterControl1.Visible = false;
                    geoTransformParameterControl2.Visible = false;
                    geoTransformParameterControl3.Visible = false;
                    break;
                case "三参数":
                    this.Size = new Size(this.Size.Width, height3);
                    break;
                case "七参数":
                    this.Size = this.MaximumSize;
                    visible = true;
                    break;
            }

            geoTransformParameterControl4.Visible = visible;
            geoTransformParameterControl5.Visible = visible;
            geoTransformParameterControl6.Visible = visible;
            geoTransformParameterControl7.Visible = visible;

        }

        public override string Caption
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public override Control ToolTipControl => throw new NotImplementedException();

        public override object GetValue()
        {
            var list = new List<double>();
            if (geoTransformParameterControl1.Visible)
            {
                list.Add((double)(geoTransformParameterControl1.GetValue()));
                list.Add((double)(geoTransformParameterControl2.GetValue()));
                list.Add((double)(geoTransformParameterControl3.GetValue()));
            }
            if (geoTransformParameterControl4.Visible)
            {
                list.Add((double)(geoTransformParameterControl4.GetValue()));
                list.Add((double)(geoTransformParameterControl5.GetValue()));
                list.Add((double)(geoTransformParameterControl6.GetValue()));
                list.Add((double)(geoTransformParameterControl7.GetValue()));
            }

            return new GeographicTransformation(comboBoxAdv1.Text, list);
        }

        public override void SetValue(object value)
        {
            if (value is GeographicTransformation paramlist)
            {

            }
        }
    }
}
