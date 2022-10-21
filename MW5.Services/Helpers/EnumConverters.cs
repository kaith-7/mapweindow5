using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Shared;

namespace MW5.Services.Helpers
{
    public class TileProviderConverter : IEnumConverter<TileProvider>
    {
        public string GetString(TileProvider enumeration)
        {
            switch (enumeration)
            {
                case TileProvider.None:
                    return "None";
                case TileProvider.OpenStreetMap:
                    return "OpenStreetMap";
                case TileProvider.OpenCycleMap:
                    return "OpenCycleMap";
                case TileProvider.OpenTransportMap:
                    return "OpenTransportMap";
                case TileProvider.BingMaps:
                    return "必应地图";
                case TileProvider.BingSatellite:
                    return "必应卫星影像";
                case TileProvider.BingHybrid:
                    return "必应混合地图";
                case TileProvider.GoogleMaps:
                    return "谷歌地图";
                case TileProvider.GoogleSatellite:
                    return "谷歌卫星影像";
                case TileProvider.GoogleTerrain:
                    return "谷歌地形";
                case TileProvider.GoogleHybrid:
                    return "谷歌混合地图";
                case TileProvider.HereMaps:
                    return "Here Maps";
                case TileProvider.HereSatellite:
                    return "Here Satellite";
                case TileProvider.HereHybrid:
                    return "Here Hybrid";
                case TileProvider.HereTerrain:
                    return "Here Terrain";
                case TileProvider.Rosreestr:
                    return "Rosreestr";
                case TileProvider.OpenHumanitarianMap:
                    return "OpenHumanitarianMap";
                case TileProvider.MapQuestAerial:
                    return "MapQuest Aerial";
                case TileProvider.ProviderCustom:
                    return "Custom Provider";
            }
            return "Not defined";
        }
    }

    public class GeometryTypeConverter : IEnumConverter<GeometryType>
    {
        public string GetString(GeometryType enumeration)
        {
            switch (enumeration)
            {
                case GeometryType.Point:
                    return "点";
                case GeometryType.Polyline:
                    return "线";
                case GeometryType.Polygon:
                    return "面";
                case GeometryType.MultiPoint:
                    return "多点";
            }
            return "未定义";
        }
    }

    public class SaveResultConverter : IEnumConverter<SaveResult>
    {
        public string GetString(SaveResult enumeration)
        {
            switch (enumeration)
            {
                case SaveResult.NoChanges:
                    return "OGR layer has no changes";
                case SaveResult.AllSaved:
                    return "All changes saved";
                case SaveResult.SomeSaved:
                    return "Some changes saved";
                case SaveResult.NoneSaved:
                    return "Changes aren't saved";
            }
            return "";
        }
    }

    public class InterpolationTypeConverter : IEnumConverter<InterpolationType>
    {
        public string GetString(InterpolationType value)
        {
            switch (value)
            {
                case InterpolationType.Bilinear:
                    return "双线性";
                case InterpolationType.Bicubic:
                    return "三次卷积";
                case InterpolationType.None:
                    return "无";
                case InterpolationType.HighQualityBilinear:
                    return "高质量双线性";
                case InterpolationType.HighQualityBicubic:
                    return "高质量三次卷积";
            }
            return "";
        }
    }

    public class RasterOverviewTypeConverter: IEnumConverter<RasterOverviewType>
    {
        public string GetString(RasterOverviewType value)
        {
            switch (value)
            {
                case RasterOverviewType.External:
                    return "外部文件";
                case RasterOverviewType.Internal:
                    return "内部";
            }
            return "";
        }
    }

    public class RasterOverviewSamplingConverter: IEnumConverter<RasterOverviewSampling>
    {
        public string GetString(RasterOverviewSampling value)
        {
            switch (value)
            {
                case RasterOverviewSampling.None:
                    return "无";
                case RasterOverviewSampling.Nearest:
                    return "最邻近";
                case RasterOverviewSampling.Gauss:
                    return "高斯";
                case RasterOverviewSampling.Bicubic:
                    return "三次卷积";
                case RasterOverviewSampling.Average:
                    return "均值";
            }
            return "";
        }
    }

    public class DynamicVisiblityModeConverter : IEnumConverter<DynamicVisibilityMode>
    {
        public string GetString(DynamicVisibilityMode value)
        {
            switch (value)
            {
                case DynamicVisibilityMode.Scale:
                    return "地图比例尺";
                case DynamicVisibilityMode.Zoom:
                    return "缩放级别";
            }
            return "";
        }
    }

    public class AreaUnitsConverter : IEnumConverter<AreaUnits>
    {
        public string GetString(AreaUnits value)
        {
            switch (value)
            {
                case AreaUnits.SquareFeet:
                    return "平方英尺";
                case AreaUnits.SquareYards:
                    return "平方码";
                case AreaUnits.SquareMeters:
                    return "平方米";
                case AreaUnits.SquareMiles:
                    return "平方英里";
                case AreaUnits.SquareKilometers:
                    return "平方公里";
                case AreaUnits.Hectares:
                    return "公顷";
                case AreaUnits.Acres:
                    return "亩";
            }

            return string.Empty;
        }
    }

    public class SelectionOperationConverter : IEnumConverter<SelectionOperation>
    {
        public string GetString(SelectionOperation value)
        {
            switch (value)
            {
                case SelectionOperation.New:
                    return "创建新选择内容";
                case SelectionOperation.Add:
                    return "添加到当前选择内容";
                case SelectionOperation.Exclude:
                    return "从当前选择内容中移除";
                case SelectionOperation.Invert:
                    return "反转选择内容";
            }

            return string.Empty;
        }
    }
}
