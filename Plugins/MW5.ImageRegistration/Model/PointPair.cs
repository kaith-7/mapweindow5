using System;
using System.ComponentModel;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Shared;

namespace MW5.Plugins.ImageRegistration.Model
{
    internal class PointPair
    {
        private readonly LengthUnits _units;
        private bool _point1Exists;
        private bool _point2Exists;
        private bool _selected;

        public PointPair(LengthUnits units, int index)
        {
            _units = units;
            Index = index;
        }

        public event EventHandler PointSelected;

        [DisplayName("序号")]
        public int Index { get; private set; }

        public double Deviation { get; set; }

        [DisplayName("残差")]
        public string DeviationString
        {
            get
            {
                double value = UnitConversionHelper.Convert(_units, LengthUnits.Meters, Deviation);
                return value.ToString("0.00 m");
            }
        }

        [DisplayName("X地图")]
        public double X1 { get; set; }

        [DisplayName("X源")]
        public double X2 { get; set; }

        [DisplayName("Y地图")]
        public double Y1 { get; set; }

        [DisplayName("Y源")]
        public double Y2 { get; set; }

        [DisplayName("选择")]
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                DelegateHelper.FireEvent(this, PointSelected);
            }
        }

        public bool Active
        {
            get { return Selected && Complete; }
        }

        public void SetSourcePoint(double x, double y)
        {
            X2 = x;
            Y2 = y;
            _point2Exists = true;
        }

        public void SetTargetPoint(double x, double y)
        {
            X1 = x;
            Y1 = y;
            _point1Exists = true;
        }

        public bool Exists(bool source)
        {
            return source ? _point2Exists : _point1Exists;
        }

        public bool Complete
        {
            get { return _point1Exists && _point2Exists; }
        }
    }
}
