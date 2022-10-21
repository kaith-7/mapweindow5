using MW5.Api.Enums;
using MW5.Plugins.Repository.Views.Abstract;
using MW5.UI.Forms;
using MW5.UI.Helpers;
using System.Windows.Forms;

namespace MW5.Plugins.Repository.Views
{
    public partial class CreateLayerView : CreateLayerViewBase, ICreateLayerView
    {
        private static GeometryType _lastGeometryType = GeometryType.Point;
        private static ZValueType _lastZValue = ZValueType.None;

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
        }

        private void InitControls()
        {
            var list = new[] { GeometryType.Point, GeometryType.Polyline, GeometryType.Polygon, GeometryType.MultiPoint, };

            _layerTypeComboBox.AddItemsFromEnum(list);
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            _layerTypeComboBox.SetValue(_lastGeometryType);

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
        }

        public ButtonBase OkButton
        {
            get { return _okButton; }
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
    }

    public class CreateLayerViewBase : MapWindowView<CreateLayerModel> { }
}
