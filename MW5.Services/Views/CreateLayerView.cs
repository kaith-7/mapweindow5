using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Projections.Forms;
using MW5.Services.Views.Abstract;
using MW5.UI;
using MW5.UI.Forms;
using MW5.UI.Helpers;
using Syncfusion.Windows.Forms;

namespace MW5.Services.Views
{
    public partial class CreateLayerView : CreateLayerViewBase, ICreateLayerView
    {
        private static GeometryType _lastGeometryType = GeometryType.Point;
        private static ZValueType _lastZValue = ZValueType.None;
        private static bool _lastMemoryLayer = false;

        public event Action ChooseProjection;
        public event Action<object, EventArgs> ChooseDataDictionary;

        public CreateLayerView()
        {
            InitializeComponent();

            InitControls();

            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _lastGeometryType = GeometryType;
            _lastZValue = ZValueType;
            _lastMemoryLayer = chkMemoryLayer.Checked;
        }

        private void InitControls()
        {
            var list = new[] { GeometryType.Point, GeometryType.Polyline, GeometryType.Polygon, };

            _layerTypeComboBox.AddItemsFromEnum(list);

            btnChooseCRS.Text = "未定义投影";
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            _layerTypeComboBox.SetValue(_lastGeometryType);

            chkMemoryLayer.Checked = _lastMemoryLayer;

            switch (_lastZValue)
            {
                case ZValueType.None:
                    opt2D.Checked = true;
                    break;
                case ZValueType.M:
                    optM.Checked = true;
                    break;
                case ZValueType.Z:
                    optZ.Checked = true;
                    break;
            }

            if (Model != null && !Model.SR.IsEmpty)
            {
                SR = Model.SR;
                btnChooseCRS.Text = Model.SR.Name;
            }
        }

        public Control ChooseButton
        {
            get { return btnChooseCRS; }
        }

        public ButtonBase OkButton
        {
            get { return _okButton; }
        }

        public bool MemoryLayer
        {
            get { return chkMemoryLayer.Checked; }
        }

        public string LayerName
        {
            get { return _layerNameTextbox.Text; }
            set { _layerNameTextbox.Text = value; }
        }

        public GeometryType GeometryType
        {
            get { return _layerTypeComboBox.GetValue<GeometryType>(); }
            set { _layerTypeComboBox.SetValue(value); }
        }

        public ZValueType ZValueType
        {
            get
            {
                if (optM.Checked)
                {
                    return ZValueType.M;
                }
                if (optZ.Checked)
                {
                    return ZValueType.Z;
                }
                return ZValueType.None;
            }
            set
            {
                switch (value)
                {
                    case ZValueType.M:
                        optM.Checked = true;
                        break;
                    case ZValueType.Z:
                        optZ.Checked = true;
                        break;
                    case ZValueType.None:
                        opt2D.Checked = true;
                        break;
                }
            }
        }

        public ISpatialReference SR { get; set; }
        public string DataDictionaryName { get { return txtDataDict.Text; } set { txtDataDict.Text = value; } }

        private void btnChooseCRS_Click(object sender, EventArgs e)
        {
            ChooseProjection?.Invoke();

        }

        private void btnChooseCRS_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SR = (ISpatialReference)e.ClickedItem.Tag;
            btnChooseCRS.Text = SR.Name;
        }

        private void cboDataDict_DropDown(object sender, EventArgs e)
        {
            ChooseDataDictionary?.Invoke(sender, e);
        }

        private void cboDataDict_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDataDict_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "数据字典|*.sdt|(*.sdt)|";
                dlg.CheckFileExists = true;
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.DataDictionaryName = dlg.FileName;
                }
            }
        }

        private void _layerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (_layerTypeComboBox.Text)
            {
                case "点":
                    this.DataDictionaryName = "pointxy.sdt";
                    break;
                case "线":
                    this.DataDictionaryName = "line.sdt";
                    break;
                case "面":
                    this.DataDictionaryName = "poly.sdt";
                    break;
            }
        }
    }

    public class CreateLayerViewBase : MapWindowView<CreateLayerModel> { }
}
