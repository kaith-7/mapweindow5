using System.Drawing;
using System.Windows.Forms;
namespace MW5.Api.Legend
{
    // TODO turn this in to service?
    public class Constants
    {

        public static readonly int ItemHeight = (int)(22 * LegendControlBase.ZoomRate);
        //  public static  readonly int ItemHeight =(int)(22*LegendControlBase.ZoomRate); 
        public static readonly int ItemPad = (int)(4 * LegendControlBase.ZoomRate);
        public static readonly int ItemRightPad = (int)(5 * LegendControlBase.ZoomRate);
        // TEXT
        public static readonly int TextHeight = (int)(18 * LegendControlBase.ZoomRate);//14
        public static readonly int TextTopPad = (int)(3 * LegendControlBase.ZoomRate);
        public static readonly int TextLeftPad = (int)(30 * LegendControlBase.ZoomRate);
        public static readonly int TextRightPad = (int)(25 * LegendControlBase.ZoomRate);
        public static readonly int TextRightPadNoIcon = (int)(8 * LegendControlBase.ZoomRate);
        public static readonly int TextEditingRightPad = (int)(10 * LegendControlBase.ZoomRate);
        // CHECK BOX
        public static readonly int CheckTopPad = (int)(4 * LegendControlBase.ZoomRate);
        public static readonly int CheckBoxSize = (int)(12 * LegendControlBase.ZoomRate);
        // EXPANSION BOX
        public static readonly int ExpandBoxTopPad = (int)(5 * LegendControlBase.ZoomRate);
        public static readonly int ExpandBoxLeftPad = (int)(3 * LegendControlBase.ZoomRate);
        public static readonly int ExpandBoxSize = (int)(8 * LegendControlBase.ZoomRate);
        // LIST ITEMS
        public static readonly int ListItemIndent = (int)(18 * LegendControlBase.ZoomRate);
        public static readonly int IconRightPad = (int)(25 * LegendControlBase.ZoomRate);
        public static readonly int IconTopPad = (int)(3 * LegendControlBase.ZoomRate);
        public static readonly int IconSize = (int)(13 * LegendControlBase.ZoomRate);
        public static readonly int VertLineGrpTopOffset = (int)(14 * LegendControlBase.ZoomRate);
        // COLOR SCHEME static  readonlyANTS
        public static readonly int CsItemHeight = (int)(14 * LegendControlBase.ZoomRate);
        public static readonly int CsTopPad = (int)(1 * LegendControlBase.ZoomRate);
        public static readonly int CsPatchHeight = (int)(12 * LegendControlBase.ZoomRate);
        public static readonly int CsTextTopPad = (int)(3 * LegendControlBase.ZoomRate);
        // SCROLLBAR
        public static readonly int ScrollWidth = (int)(15 * LegendControlBase.ZoomRate);
        // MISC
        // DROP_TOLERANCE 4
        public static readonly int InvalidIndex = (int)(-1 * LegendControlBase.ZoomRate);
        // static  readonlyants for the new symbology
        public static readonly int IconWidth = (int)(24 * LegendControlBase.ZoomRate);
        public static readonly int IconHeight = (int)(14 * LegendControlBase.ZoomRate);
        // Visual Basic Related static  readonlyants
        public static readonly int VbShiftButton = (int)(1 * LegendControlBase.ZoomRate);
        public static readonly int VbLeftButton = (int)(1 * LegendControlBase.ZoomRate);
        public static readonly int VbRightButton = (int)(2 * LegendControlBase.ZoomRate);
        public static readonly int CheckLeftPad = (int)(15 * LegendControlBase.ZoomRate);
        // GROUP
        public static readonly int GrpIndent = (int)(3 * LegendControlBase.ZoomRate);
        // CONNECTION LINES FROM GROUPS TO SUB ITEMS
        public static readonly int VertLineIndent = (int)(GrpIndent + 7 * LegendControlBase.ZoomRate);
        public static readonly int CsPatchWidth = (int)(15 * LegendControlBase.ZoomRate);
        public static readonly int CsPatchLeftIndent = (int)(CheckLeftPad * LegendControlBase.ZoomRate);
        public static readonly int CsTextLeftIndent = (int)(CsPatchLeftIndent + CsPatchWidth + 3 * LegendControlBase.ZoomRate);

        public static readonly int VerticalPad = (int)(2 * LegendControlBase.ZoomRate);

        public static int ItemHeightAndPad()
        {
            return ItemHeight + VerticalPad;
        }

        public static int CsItemHeightAndPad()
        {
            return CsItemHeight + VerticalPad;
        }

        public static int CategoryCheckboxWidthWithPadding()
        {
            return CheckBoxSize + 5;
        }

        public static int CheckboxTopOffset()
        {
            return (TextHeight - CheckBoxSize) / 2;
        }

        //public Constants(Control control)
        //{
        //    Control = control;
        //}

        //public int _itemHeight => (int)(19.0 * GetScalingFactor());

        //public int ItemHeight => TextHeight + 4;
        //public const int ItemPad = 4;
        //public const int ItemRightPad = 5;
        //// TEXT

        //public static Font DefaultLegendFont = new Font("Arial", 8, GraphicsUnit.Pixel);

        //public int _textHeight = -1;
        //public int TextHeight
        //{
        //    get
        //    {
        //        var scale = GetScalingFactor();
        //        return (int) (14.0 * scale);/*
        //        if (_textHeight < 0)
        //        {
                    
        //            _textHeight = TextRenderer
        //                .MeasureText("HçjÊ{}g", DefaultLegendFont)
        //                .Height + (int) (4 * scale);
        //        }

        //        return _textHeight;*/
        //    }
        //}

        //public Control Control { get; }

        //private double GetScalingFactor()
        //{
        //    var graphics = Control.CreateGraphics();
        //    return graphics.DpiX / 96.0;
        //}

        //public const int TextTopPad = 3;
        //public const int TextLeftPad = 30;
        //public const int TextRightPad = 25;
        //public const int TextRightPadNoIcon = 8;
        //public const int TextEditingRightPad = 10;
        //// CHECK BOX
        //public int CheckTopPad => (ItemHeight - CheckBoxSize) / 2;
        //public int CheckBoxSize => 12;
        //// EXPANSION BOX
        //public const int ExpandBoxTopPad = 5;
        //public const int ExpandBoxLeftPad = 3;
        //public const int ExpandBoxSize = 8;
        //// LIST ITEMS
        //public const int ListItemIndent = 18;
        //public const int IconRightPad = 25;
        //public int IconTopPad => (ItemHeight - IconSize) / 2;
        //public const int IconSize = 13;
        //public const int VertLineGrpTopOffset = 14;
        //// COLOR SCHEME CONSTANTS
        //public int CsItemHeight => (int) (14 * GetScalingFactor());
        //public const int CsPatchHeight = 12;
        //// SCROLLBAR
        //public const int ScrollWidth = 15;
        //// MISC
        //// DROP_TOLERANCE 4
        //public const int InvalidIndex = -1;
        //// constants for the new symbology
        //public const int IconWidth = 24;
        //public const int IconHeight = 13;
        //// Visual Basic Related constants
        //public const int VbShiftButton = 1;
        //public const int VbLeftButton = 1;
        //public const int VbRightButton = 2;
        //public const int CheckLeftPad = 15;
        //// GROUP
        //public const int GrpIndent = 3;
        //// CONNECTION LINES FROM GROUPS TO SUB ITEMS
        //public const int VertLineIndent = GrpIndent + 7;
        //public const int CsPatchWidth = 15;
        //public const int CsPatchLeftIndent = CheckLeftPad;
        //public const int CsTextLeftIndent = CsPatchLeftIndent + CsPatchWidth + 3;

        //public const int VerticalPad = 2;

        //public int ItemHeightAndPad => ItemHeight + VerticalPad;

        //public int CsItemHeightAndPad => CsItemHeight + VerticalPad;

        //public int CategoryCheckboxWidthWithPadding
        //    => CheckBoxSize + 5;

        //public int CheckboxTopOffset => (TextHeight - CheckBoxSize) / 2;
    }
}