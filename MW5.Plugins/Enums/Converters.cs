using System;
using MW5.Api.Enums;
using MW5.Shared;

namespace MW5.Plugins.Enums
{
    public class GisTaskStatusConverter: IEnumConverter<GisTaskStatus>
    {
        public string GetString(GisTaskStatus value)
        {
            switch (value)
            {
                case GisTaskStatus.NotStarted:
                    return "未开始";
                case GisTaskStatus.Running:
                    return "运行中";
                case GisTaskStatus.Success:
                    return "成功";
                case GisTaskStatus.Failed:
                    return "失败";
                case GisTaskStatus.Cancelled:
                    return "已取消";
                case GisTaskStatus.Paused:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("value");
            }

            return string.Empty;
        }
    }

    public class TilesMaxAgeConverter : IEnumConverter<TilesMaxAge>
    {
        public string GetString(TilesMaxAge value)
        {
            switch (value)
            {
                case TilesMaxAge.Never:
                    return "从不";
                case TilesMaxAge.Month:
                    return "1个月";
                case TilesMaxAge.Month3:
                    return "3个月";
                case TilesMaxAge.Month6:
                    return "6个月";
                case TilesMaxAge.Year:
                    return "1年";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    public class GdalDriverMetadataConverter : IEnumConverter<GdalDriverMetadata>
    {
        public string GetString(GdalDriverMetadata value)
        {
            switch (value)
            {
                case GdalDriverMetadata.Longname:
                    return "Long name";
                case GdalDriverMetadata.HelpTopic:
                    return "Help topic";
                case GdalDriverMetadata.MimeType:
                    return "Mime type";
                case GdalDriverMetadata.Extension:
                    return "Extension";
                case GdalDriverMetadata.Extensions:
                    return "Extensions";
                case GdalDriverMetadata.CreationOptionList:
                    return "Creation option list";
                case GdalDriverMetadata.OpenOptionList:
                    return "Open option list";
                case GdalDriverMetadata.CreationDataTypes:
                    return "Creation data types";
                case GdalDriverMetadata.SubDatasets:
                    return "Sub datasets";
                case GdalDriverMetadata.Open:
                    return "Supports open";
                case GdalDriverMetadata.Create:
                    return "Supports creation";
                case GdalDriverMetadata.CreateCopy:
                    return "Supports create copy";
                case GdalDriverMetadata.VirtualIo:
                    return "Supports virtual IO";
                case GdalDriverMetadata.LayerCreationOptionList:
                    return "Layer creation option list";
                case GdalDriverMetadata.OgrDriver:
                    return "Is OGR driver";
                case GdalDriverMetadata.Raster:
                    return "Is raster";
                case GdalDriverMetadata.Vector:
                    return "Is vector";
                case GdalDriverMetadata.NotNullFields:
                    return "Not null fields";
                case GdalDriverMetadata.DefaultFields:
                    return "Default fields";
                case GdalDriverMetadata.NotNullGeometries:
                    return "Not null geometries";
                case GdalDriverMetadata.CreateFieldDataTypes:
                    return "Creation field data types";
            }

            return string.Empty;
        }
    }

    public class AutoToggleConverter : IEnumConverter<AutoToggle>
    {
        public string GetString(AutoToggle value)
        {
            switch (value)
            {
                case AutoToggle.Auto:
                    return "自动";
                case AutoToggle.True:
                    return "经常";
                case AutoToggle.False:
                    return "偶尔";
            }

            return string.Empty;
        }
    }

    public class ResizeBehaviorConverter : IEnumConverter<ResizeBehavior>
    {
        public string GetString(ResizeBehavior value)
        {
            switch (value)
            {
                case ResizeBehavior.Classic:
                    return "经典";
                case ResizeBehavior.Modern:
                    return "时尚";
                case ResizeBehavior.Intuitive:
                    return "直观";
                case ResizeBehavior.Warp:
                    return "隐晦";
                case ResizeBehavior.KeepScale:
                    return "保持不变";
            }

            return string.Empty;
        }
    }

    public class ScalebarUnitsConverter : IEnumConverter<ScalebarUnits>
    {
        public string GetString(ScalebarUnits value)
        {
            switch (value)
            {
                case ScalebarUnits.Metric:
                    return "公共样式";
                case ScalebarUnits.American:
                    return "美式";
                case ScalebarUnits.GoogleStyle:
                    return "谷歌样式";
            }

            return string.Empty;
        }
    }

    public class ZoomBehaviorConverter : IEnumConverter<ZoomBehavior>
    {
        public string GetString(ZoomBehavior value)
        {
            switch (value)
            {
                case ZoomBehavior.Default:
                    return "默认 (没有分级别)";
                case ZoomBehavior.UseTileLevels:
                    return "捕捉缩放级别";
            }

            return string.Empty;
        }
    }

    public class MouseWheelDirectionConverter : IEnumConverter<MouseWheelDirection>
    {
        public string GetString(MouseWheelDirection value)
        {
            switch (value)
            {
                case MouseWheelDirection.Forward:
                    return "向前";
                case MouseWheelDirection.Reverse:
                    return "向后";
                case MouseWheelDirection.None:
                    return "无";
            }

            return string.Empty;
        }
    }

    public class ZoombarVerbosityConverter : IEnumConverter<ZoomBarVerbosity>
    {
        public string GetString(ZoomBarVerbosity value)
        {
            switch (value)
            {
                case ZoomBarVerbosity.ZoomOnly:
                    return "仅显示缩放级别";
                case ZoomBarVerbosity.Full:
                    return "显示完整信息";
                case ZoomBarVerbosity.None:
                    return "不显示任何信息";
            }

            return string.Empty;
        }
    }

    public class ZoomBoxStyleConverter : IEnumConverter<ZoomBoxStyle>
    {
        public string GetString(ZoomBoxStyle value)
        {
            switch (value)
            {
                case ZoomBoxStyle.RubberBand:
                    return "卡其色";
                case ZoomBoxStyle.Gray:
                    return "粉色";
                case ZoomBoxStyle.GrayInverted:
                    return "灰白色";
                case ZoomBoxStyle.Orange:
                    return "橙色";
                case ZoomBoxStyle.Blue:
                    return "蓝色";
            }

            return string.Empty;
        }
    }

    public class ProjectionMistmatchConverter : IEnumConverter<ProjectionMismatch>
    {
        public string GetString(ProjectionMismatch value)
        {
            switch (value)
            {
                case ProjectionMismatch.IgnoreMismatch:
                    return "忽略";
                case ProjectionMismatch.Reproject:
                    return "重投影";
                case ProjectionMismatch.SkipFile:
                    return "跳过";
            }

            return string.Empty;
        }
    }

    public class ProjectionAbsenceConverter : IEnumConverter<ProjectionAbsence>
    {
        public string GetString(ProjectionAbsence value)
        {
            switch (value)
            {
                case ProjectionAbsence.AssignFromProject:
                    return "从当前项目中指定";
                case ProjectionAbsence.IgnoreAbsence:
                    return "忽略";
                case ProjectionAbsence.SkipFile:
                    return "跳过";
            }

            return string.Empty;
        }
    }

    public class SymbologyStorageConverter : IEnumConverter<SymbologyStorage>
    {
        public string GetString(SymbologyStorage value)
        {
            switch (value)
            {
                case SymbologyStorage.Project:
                    return "项目文件";
                case SymbologyStorage.StyleFile:
                    return "样式文件 (.mwleg)";
            }

            return string.Empty;
        }
    }

    public class ColorInterpretationConverter : IEnumConverter<ColorInterpretation>
    {
        public string GetString(ColorInterpretation value)
        {
            switch (value)
            {
                case ColorInterpretation.Undefined:
                    return "未定义";
                case ColorInterpretation.GrayIndex:
                    return "灰白色索引";
                case ColorInterpretation.PaletteIndex:
                    return "调色板索引";
                case ColorInterpretation.RedBand:
                    return "红";
                case ColorInterpretation.GreenBand:
                    return "绿";
                case ColorInterpretation.BlueBand:
                    return "蓝";
                case ColorInterpretation.AlphaBand:
                    return "透明度";
                case ColorInterpretation.HueBand:
                    return "色调";
                case ColorInterpretation.SaturationBand:
                    return "饱和度";
                case ColorInterpretation.LightnessBand:
                    return "亮度";
                case ColorInterpretation.CyanBand:
                    return "青";
                case ColorInterpretation.MagentaBand:
                    return "品红";
                case ColorInterpretation.YellowBand:
                    return "黄";
                case ColorInterpretation.BlackBand:
                    return "黑";
                case ColorInterpretation.Yband:
                    return "明亮度和浓度";
                case ColorInterpretation.CbBand:
                    return "蓝色浓度偏移量";
                case ColorInterpretation.CrBand:
                    return "红色浓度偏移量";
            }

            return string.Empty;
        }
    }

    public class UnitsOfMeasureConverter : IEnumConverter<LengthUnits>
    {
        public string GetString(LengthUnits value)
        {
            switch (value)
            {
                case LengthUnits.DecimalDegrees:
                    return "十进制度";
                case LengthUnits.Milimeters:
                    return "毫米";
                case LengthUnits.Centimeters:
                    return "厘米";
                case LengthUnits.Inches:
                    return "英寸";
                case LengthUnits.Feet:
                    return "英尺";
                case LengthUnits.Yards:
                    return "码";
                case LengthUnits.Meters:
                    return "米";
                case LengthUnits.Miles:
                    return "英里";
                case LengthUnits.Kilometers:
                    return "千米";
            }

            return string.Empty;
        }
    }

    public class GroupOperationConverter : IEnumConverter<GroupOperation>
    {
        public string GetString(GroupOperation value)
        {
            switch (value)
            {
                case GroupOperation.Sum:
                    return "求合";
                case GroupOperation.Min:
                    return "最小值";
                case GroupOperation.Max:
                    return "最大值";
                case GroupOperation.Avg:
                    return "平均值";
                case GroupOperation.WeightedAvg:
                    return "加权平均值";
                case GroupOperation.Mode:
                    return "余数";
            }

            return string.Empty;
        }
    }

    public class ClipOperationConverter : IEnumConverter<ClipOperation>
    {
        public string GetString(ClipOperation value)
        {
            switch (value)
            {
                case ClipOperation.Difference:
                    return "差集";
                case ClipOperation.Intersection:
                    return "交集";
                case ClipOperation.SymDifference:
                    return "对称差集";
                case ClipOperation.Union:
                    return "合并";
                case ClipOperation.Clip:
                    return "裁剪";
                case ClipOperation.AddColl:
                    return "";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    public class TileProjectionConverter : IEnumConverter<TileProjection>
    {
        public string GetString(TileProjection value)
        {
            switch (value)
            {
                case TileProjection.SphericalMercator:
                    return "Spherical Mercator";
                case TileProjection.Amersfoort:
                    return "Amersfoort";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    public class SpatialSelectionModeConverter : IEnumConverter<SpatialSelectionMode>
    {
        public string GetString(SpatialSelectionMode value)
        {
            switch (value)
            {
                case SpatialSelectionMode.Intersection:
                    return "相交";
                case SpatialSelectionMode.Contains:
                    return "包含";
                case SpatialSelectionMode.Within:
                    return "被包含";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    public class AngleFormatConverter : IEnumConverter<AngleFormat>
    {
        public string GetString(AngleFormat value)
        {
            switch (value)
            {
                default:
                case AngleFormat.Degrees:
                    return "度";
                case AngleFormat.Minutes:
                    return "分";
                case AngleFormat.Seconds:
                    return "秒";
                case AngleFormat.Radians:
                    return "弧度";
            }
        }
    }

    public class LengthDisplayConverter : IEnumConverter<LengthDisplay>
    {
        public string GetString(LengthDisplay value)
        {
            switch (value)
            {
                default:
                case LengthDisplay.Metric:
                    return "通用";
                case LengthDisplay.American:
                    return "美式";
            }
        }
    }

    public class AreaDisplayConverter : IEnumConverter<AreaDisplay>
    {
        public string GetString(AreaDisplay value)
        {
            switch (value)
            {
                default:
                case AreaDisplay.Metric:
                    return "公制";
                case AreaDisplay.American:
                    return "美式";
                case AreaDisplay.Hectars:
                    return "公顷";
            }
        }
    }
}
