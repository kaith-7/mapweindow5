using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Shared;
using MW5.UI.Helpers;

namespace MW5.Plugins.Symbology.Services
{
    internal class SymbologyTypeCoverter : IEnumConverter<SymbologyType>
    {
        public string GetString(SymbologyType value)
        {
            switch (value)
            {
                case SymbologyType.Default:
                    return "默认存储在.mwsymb或.mwsr文件中";
                case SymbologyType.Random:
                    return "MapWinGIS ActiveX控件随机设置";
                case SymbologyType.Custom:
                default:
                    return "自定义的符号";
            }
        }
    }

    internal class RasterRenderingConverter : IEnumConverter<RasterRendering>
    {
        public string GetString(RasterRendering value)
        {
            switch (value)
            {
                case RasterRendering.SingleBand:
                    return "单波段灰度";
                case RasterRendering.Rgb:
                    return "RGB";
                case RasterRendering.ColorScheme:
                    return "配色方案";
                case RasterRendering.BuiltInColorTable:
                    return "内置色表";
            }

            return string.Empty;
        }
    }

    internal class RasterClassificationConverter : IEnumConverter<RasterClassification>
    {
        public string GetString(RasterClassification value)
        {
            switch (value)
            {
                case RasterClassification.EqualIntervals:
                    return "相等间隔";
                case RasterClassification.UniqueValues:
                    return "唯一值";
                case RasterClassification.EqualCount:
                    return "等间隔色段数";
            }

            return string.Empty;
        }
    }

    internal class CollisionModeConverter : IEnumConverter<CollisionMode>
    {
        public string GetString(CollisionMode value)
        {
            switch (value)
            {
                case CollisionMode.AllowCollisions:
                    return "允许重叠";
                case CollisionMode.LocalList:
                    return "避免点与点重叠";
                case CollisionMode.GlobalList:
                    return "避免点与标签重叠";
            }

            return string.Empty;
        }
    }
}
