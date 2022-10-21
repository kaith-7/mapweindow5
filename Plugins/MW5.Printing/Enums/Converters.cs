using System;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Shared;

namespace MW5.Plugins.Printing.Enums
{
    public class LayoutUnitConverter : IEnumConverter<LayoutUnit>
    {
        public string GetString(LayoutUnit value)
        {
            switch (value)
            {
                case LayoutUnit.Inch:
                    return "英寸";
                case LayoutUnit.Millimeter:
                    return "毫米";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    public class OrientationConverter : IEnumConverter<Orientation>
    {
        public string GetString(Orientation value)
        {
            switch (value)
            {
                case Orientation.Horizontal:
                    return "横向";
                case Orientation.Vertical:
                    return "纵向";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }
}
