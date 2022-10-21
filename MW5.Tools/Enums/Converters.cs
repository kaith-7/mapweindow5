using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Shared;

namespace MW5.Tools.Enums
{
    internal class FieldOperationValidityConverter : IEnumConverter<MW5.Api.Enums.FieldOperationValidity>
    {
        public string GetString(FieldOperationValidity value)
        {
            switch (value)
            {
                case FieldOperationValidity.Valid:
                    return "Valid";
                case FieldOperationValidity.FieldNotFound:
                    return "Field wasn't found";
                case FieldOperationValidity.NotSupported:
                    return "Operations isn't supported for the given field type.";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    internal class PolygonCenterValidityConverter : IEnumConverter<PolygonCenter>
    {
        public string GetString(PolygonCenter value)
        {
            switch (value)
            {
                case PolygonCenter.Center:
                    return "中心点";
                case PolygonCenter.Centroid:
                    return "质心";
                case PolygonCenter.InteriorPoint:
                    return "内部点";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    // CoordinatesDisplay
    internal class CoordinatesDisplayValidityConverter : IEnumConverter<CoordinatesDisplay>
    {
        public string GetString(CoordinatesDisplay value)
        {
            switch (value)
            {
                case CoordinatesDisplay.None:
                    return "无";
                case CoordinatesDisplay.Auto:
                    return "自动";
                case CoordinatesDisplay.Degrees:
                    return "度";
                case CoordinatesDisplay.MapUnits:
                    return "地图单位";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    internal class TopologyRuleValidityConverter : IEnumConverter<TopologyRule>
    {
        public string GetString(TopologyRule value)
        {
            switch (value)
            {
                case TopologyRule.PointNotDuplicate:
                    return "点不重复";
                case TopologyRule.PointPointNotDuplicate:
                    return "点与点不重复(点-点)";
                case TopologyRule.PointOverlapLineEnds:
                    return "点与线端点重合(点-线)";
                case TopologyRule.PointOverlapLine:
                    return "点与线重合(点-线)";
                case TopologyRule.PointOnPolygonBoundary:
                    return "点与面边界重合(点-面)";
                case TopologyRule.PointInPolygonNotBoundary:
                    return "点在面内-不包括边界(点-面)";
                case TopologyRule.PointInPolygonAndBoundary:
                    return "点在面内-包括边界(点-面)";
                case TopologyRule.LineNotOverlaps:
                    return "线不重叠";
                case TopologyRule.LineNotSelfOverlaps:
                    return "线不自重叠";
                case TopologyRule.LineNotIntersect:
                    return "线不相交";
                case TopologyRule.LineNotSelfIntersect:
                    return "线不自相交";
                case TopologyRule.LineLineNotOverlaps:
                    return "线与线不重叠(线-线)";
                case TopologyRule.LineLineNotIntersect:
                    return "线与线不相交(线-线)";
                case TopologyRule.LineInPolygon:
                    return "线在面内(线-面)";
                case TopologyRule.PolygonNotOverlaps:
                    return "面不相交";
                case TopologyRule.PolygonNoGaps:
                    return "面不存在缝隙";
                case TopologyRule.PolygonBoundaryMustOverlapsByLines:
                    return "面边界与线重合(面-线)";
                case TopologyRule.PolygonMustBeCovredBy:
                    return "面被面覆盖(面-面)";
                case TopologyRule.PolygonMustNotOverlapWith:
                    return "面不重叠(面-面)";
                case TopologyRule.PolygonMustPartOverlapWith:
                    return "面部分重叠(面-面)";
                case TopologyRule.PolygonNoMultiParts:
                    return "不存在多部分要素";
                case TopologyRule.PolygonNoSmallArea:
                    return "不存在微小面";
                case TopologyRule.PolygonNoSharpAngle:
                    return "不存在尖锐角";
                case TopologyRule.None:
                default:
                    return "";
                    //throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    //SpatialRelation
    internal class SpatialRelationValidityConverter : IEnumConverter<SpatialRelation>
    {
        public string GetString(SpatialRelation value)
        {
            switch (value)
            {
                case SpatialRelation.Contains:
                    return "包含";
                case SpatialRelation.Crosses:
                    return "穿过";
                case SpatialRelation.Disjoint:
                    return "相离";
                case SpatialRelation.Equals:
                    return "相等";
                case SpatialRelation.Intersects:
                    return "相交";
                case SpatialRelation.Overlaps:
                    return "重叠";
                case SpatialRelation.Touches:
                    return "相接";
                case SpatialRelation.Within:
                    return "被包含";
                case SpatialRelation.Covers:
                    return "包含";
                case SpatialRelation.CoveredBy:
                    return "被覆盖";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }
}
