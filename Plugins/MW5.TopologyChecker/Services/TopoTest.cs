using System;
using System.Linq;
using System.Collections.Generic;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Concrete;

namespace MW5.Plugins.TopologyChecker.Services
{
    internal class TopoTest : TopoConfig
    {
        internal static IEnumerable<TopologyCheckRuleResult> PointNotDuplicate(IFeatureSet fsPoint)
        {
            var errList = new List<int>();
            var errList2 = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsPoint.Projection);

            fsPoint.ClearSelection();
            try
            {
                foreach (var feat in fsPoint.Features)
                {
                    if (errList.Contains(feat.Index) || errList2.Contains(feat.Index))
                        continue;
                    //bool hasDuplicate = false;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Point)
                    {
                        // TODO： fsArea.SelectByShape
                        int[] resultIds = null;
                        var geomBuffer = geom.Buffer(tolerance, 30);
                        if (fsPoint.GetRelatedShapes(geomBuffer, SpatialRelation.Intersects, ref resultIds))
                            foreach (var id in resultIds)
                            {
                                if (id == feat.Index || errList.Contains(id) || errList2.Contains(id))
                                    continue;
                                var geomA = fsPoint.GetGeometry(id);
                                if (geom.Distance(geomA) < tolerance)
                                {
                                    errList2.Add(id);
                                    //hasDuplicate = true;
                                    errList.Add(feat.Index);
                                    errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, feat.Geometry));
                                }
                            }

                        //if (hasDuplicate)
                        //{
                        //    errList.Add(feat.Index);
                        //    feat.Selected = true;
                        //    Console.WriteLine($"Point {feat.Index} has duplicate with.");
                        //}
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PointPointNotDuplicate(IFeatureSet fsPoint, IFeatureSet fsPoint2)
        {
            var errList = new List<int>();
            var errList2 = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsPoint.Projection);

            fsPoint.ClearSelection();
            try
            {
                foreach (var feat in fsPoint.Features)
                {
                    //bool hasDuplicate = false;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Point)
                    {
                        // TODO： fsArea.SelectByShape
                        int[] resultIds = null;
                        var geomBuffer = geom.Buffer(tolerance, 30);
                        if (fsPoint2.GetRelatedShapes(geomBuffer, SpatialRelation.Intersects, ref resultIds))
                        {
                            foreach (var id in resultIds)
                            {
                                var geomA = fsPoint2.GetGeometry(id);
                                if (geom.Distance(geomA) < tolerance)
                                {
                                    //hasDuplicate = true;
                                    //break;
                                    errList.Add(feat.Index);
                                    errList2.Add(id);
                                    errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, feat.Geometry));
                                }
                            }
                            //if (hasDuplicate)
                            //{
                            //    errList.Add(feat.Index);
                            //    feat.Selected = true;
                            //    Console.WriteLine($"Point {feat.Index} has duplicate with.");
                            //}
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PointOverlapLineEnds(IFeatureSet fsPoint, IFeatureSet fsLine)
        {
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsPoint.Projection);

            fsPoint.ClearSelection();
            try
            {
                foreach (var feat in fsPoint.Features)
                {
                    bool hasOverlap = false;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Point)
                    {
                        int[] resultIds = null;
                        var geomBuffer = geom.Buffer(tolerance * 10, 30);
                        if (fsLine.GetRelatedShapes(geomBuffer, SpatialRelation.Intersects, ref resultIds))
                        {
                            var pt = geom.Points[0];
                            foreach (var id in resultIds)
                            {
                                var line = fsLine.GetGeometry(id);
                                foreach (var part in line.Parts)
                                {
                                    var ptStart = part.Points[0];
                                    var ptEnd = part.Points[part.Points.Count - 1];
                                    if (pt.Distance(ptStart) < tolerance
                                        || pt.Distance(ptEnd) < tolerance)
                                    {
                                        hasOverlap = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (!hasOverlap)
                        {
                            errList.Add(feat.Index);
                            errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, feat.Geometry));
                            //feat.Selected = true;
                            //Console.WriteLine($"Point {feat.Index} has not overlap with line ends.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PointOverlapLine(IFeatureSet fsPoint, IFeatureSet fsLine)
        {
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsPoint.Projection);

            fsPoint.ClearSelection();
            try
            {
                foreach (var feat in fsPoint.Features)
                {
                    bool hasOverlap = false;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Point)
                    {
                        int[] resultIds = null;
                        var buff = geom.Buffer(tolerance * 10, 4);
                        if (fsLine.GetRelatedShapes(buff, SpatialRelation.Intersects, ref resultIds))
                        {
                            var pt = geom.Points[0];
                            foreach (var id in resultIds)
                            {
                                var line = fsLine.GetGeometry(id);
                                foreach (var part in line.Parts)
                                {
                                    if (geom.Distance(line) < tolerance)
                                    {
                                        hasOverlap = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (!hasOverlap)
                        {
                            errList.Add(feat.Index);
                            feat.Selected = true;
                            Console.WriteLine($"Point {feat.Index} has not overlap with line ends.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PolygonNoMultiParts(IFeatureSet featureSet)
        {
            var errResultList = new List<TopologyCheckRuleResult>();
            foreach (var feat in featureSet.Features)
            {
                if (feat.Geometry.Parts.Count > 1)
                {
                    var multiPart = 0;
                    foreach (var part in feat.Geometry.Parts)
                    {
                        if (part.IsValid && part.IsValidReason == "")
                            multiPart++;
                    }
                    if (multiPart > 1)
                        errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, feat.Geometry));
                }
            }
            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PointOnPolygonBoundary(IFeatureSet featureSet1, IFeatureSet featureSet2)
        {
            var fsPoint = featureSet1;
            var fsArea = featureSet2;

            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsPoint.Projection);

            try
            {
                var pointIds = fsPoint.Features.Select(f => f.Index).ToList();
                foreach (var feat in fsArea.Features)
                {
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polygon)
                    {
                        foreach (var part in feat.Geometry.Parts)
                        {
                            var line = new Geometry(GeometryType.Polyline);
                            foreach (var pt in part.Points)
                            {
                                line.Points.Add(pt);
                            }

                            int[] resultIds = null;
                            var buff = line.Buffer(tolerance * 10, 2);
                            if (fsPoint.GetRelatedShapes(buff, SpatialRelation.Intersects, ref resultIds))
                            {
                                foreach (var id in resultIds)
                                {
                                    var point = fsPoint.GetGeometry(id);
                                    if (line.Distance(point) < tolerance)
                                    {
                                        pointIds.Remove(id);
                                        //Console.WriteLine($"Point {id} has >>> overlap with polygon boundary.");
                                    }
                                }
                            }
                        }
                    }
                }

                foreach (var id in pointIds)
                {
                    //Console.WriteLine($"Point {id} has not overlap with polygon boundary.");
                    errResultList.Add(new TopologyCheckRuleResult(id, -1, fsPoint.Features[id].Geometry));
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PointInPolygonNotBoundary(IFeatureSet fsPoint, IFeatureSet fsArea)
        {
            return PointInPolygon(fsPoint, fsArea, false);
        }

        internal static IEnumerable<TopologyCheckRuleResult> PointInPolygonAndBoundary(IFeatureSet fsPoint, IFeatureSet fsArea)
        {
            return PointInPolygon(fsPoint, fsArea, true);
        }

        internal static IEnumerable<TopologyCheckRuleResult> PointInPolygon(IFeatureSet fsPoint, IFeatureSet fsArea, bool IncludeBoundary = false)
        {
            var errList = new System.Collections.Generic.List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsPoint.Projection);
            double bufferSize = tolerance * (IncludeBoundary ? 1 : -1);
            try
            {
                var pointIds = fsPoint.Features.Select(f => f.Index).ToList();
                foreach (var feat in fsPoint.Features)
                {
                    if (!pointIds.Contains(feat.Index))
                        continue;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Point)
                    {
                        int[] resultIds = null;
                        if (fsArea.GetRelatedShapes(geom, SpatialRelation.Intersects, ref resultIds))
                        {
                            foreach (var id in resultIds)
                            {
                                var geomA = fsArea.GetGeometry(id);
                                var geomBufferA = geomA.Buffer(bufferSize, 10);
                                if (geomBufferA.Contains(geom))
                                {
                                    pointIds.Remove(feat.Index);
                                }
                                int[] resPointArray = null;
                                if (fsPoint.GetRelatedShapes(geomBufferA, SpatialRelation.Contains, ref resPointArray))
                                {
                                    foreach (var ptid in resPointArray)
                                    {
                                        pointIds.Remove(ptid);
                                    }
                                }
                            }
                        }
                    }
                }

                //string format = IncludeBoundary ? "Point {0} not within polygon include boundary." : "Point {0} not within polygon exclude boundary.";
                foreach (var id in pointIds)
                {
                    //fsPoint.Features[id].Selected = true;
                    //Console.WriteLine(string.Format(format, id));
                    errResultList.Add(new TopologyCheckRuleResult(id, -1, fsPoint.Features[id].Geometry));
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        /// <summary>
        /// 检查线重叠错误
        /// 遍历线
        /// 做buffer
        /// 选择的线与buffer相交
        /// 相交的线长度大于tolerance则视为有重叠
        /// </summary>
        /// <param name="fsLine"></param>
        /// <returns></returns>
        internal static IEnumerable<TopologyCheckRuleResult> LineNotOverlaps(IFeatureSet fsLine)
        {
            var errList = new System.Collections.Generic.List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsLine.Projection);
            try
            {
                var doneIds = new List<int>();
                foreach (var feat in fsLine.Features)
                {
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polyline)
                    {
                        int[] resultIds = null;
                        var filter = geom.Buffer(tolerance, 4);
                        if (fsLine.GetRelatedShapes(filter, SpatialRelation.Intersects, ref resultIds))
                        {
                            doneIds.Add(feat.Index);
                            foreach (var id in resultIds)
                            {
                                if (doneIds.Contains(id))
                                    continue;

                                var line = fsLine.GetGeometry(id);
                                var intersections = filter.Intersection(line);
                                if (intersections.Count() > 0)
                                {
                                    foreach (var interLine in intersections)
                                    {
                                        if (interLine.GeometryType == GeometryType.Polyline
                                            && (interLine.Length > tolerance * 10))
                                        {
                                            errList.Add(feat.Index);
                                            errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, interLine));
#if DEBUG
                                            fsLine.Features[id].Selected = feat.Selected = true;
#endif
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> LineNotIntersect(IFeatureSet featureSet)
        {
            var fsLine = featureSet;
            var errList = new System.Collections.Generic.List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();
            double tolerance = CalcTolarance(fsLine.Projection);
            try
            {
                var doneIds = new List<int>();
                foreach (var feat in fsLine.Features)
                {
                    var geom = feat.Geometry;

                    if (geom.GeometryType == GeometryType.Polyline)
                    {
                        int[] resultIds = null;
                        var filter = geom;
                        if (fsLine.GetRelatedShapes(filter, SpatialRelation.Intersects, ref resultIds))
                        {
                            doneIds.Add(feat.Index);
                            foreach (var id in resultIds)
                            {
                                if (doneIds.Contains(id))
                                    continue;

                                var line = fsLine.GetGeometry(id);
                                var intersections = filter.Intersection(line);
                                if (intersections.Count() > 0)
                                {
                                    errList.Add(feat.Index);
                                    foreach (var interGeom in intersections)
                                    {
                                        if (interGeom.GeometryType == GeometryType.Point || interGeom.GeometryType == GeometryType.MultiPoint)
                                        {
                                            for (int ipt = 0; ipt < interGeom.Points.Count; ipt++)
                                            {
                                                var point = interGeom.Points[ipt];
                                                if (point.Distance(line.Points[0]) > tolerance
                                                    && point.Distance(line.Points[line.Points.Count - 1]) > tolerance)
                                                {
                                                    errList.Add(feat.Index);
                                                    errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, interGeom));
#if DEBUG
                                                    fsLine.Features[id].Selected = feat.Selected = true;
#endif
                                                }
                                            }
                                        }
                                        else if (interGeom.GeometryType == GeometryType.Polyline && (interGeom.Length > tolerance * 10))
                                        {

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> LineLineNotOverlaps(IFeatureSet featureSet1, IFeatureSet featureSet2)
        {
            /* 遍历线
             * 做buffer
             * 选择的线与buffer相交
             * 相交的线长度大于tolerance则视为有重叠
             */
            // TODO: 需要保存重叠的部分，每个要素对应的重叠部分可能不止一个

            var fsLine = featureSet1;
            var fsLine2 = featureSet2;
            var errList = new System.Collections.Generic.List<int>();
            var errLines = new List<IGeometry>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsLine.Projection);
            try
            {
                foreach (var feat in fsLine.Features)
                {
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polyline)
                    {
                        int[] resultIds = null;
                        var filter = geom.Buffer(tolerance, 4);
                        if (fsLine2.GetRelatedShapes(filter, SpatialRelation.Intersects, ref resultIds))
                        {
                            foreach (var id in resultIds)
                            {
                                var line = fsLine2.GetGeometry(id);
                                var intersections = filter.Intersection(line);
                                if (intersections.Count() > 0)
                                {
                                    foreach (var interGeom in intersections)
                                    {
                                        if (interGeom.GeometryType == GeometryType.Polyline
                                            && (interGeom.Length > tolerance * 10))
                                        {
                                            errList.Add(feat.Index);
                                            errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, interGeom));
                                            // TODO: Must return Overlaps part of lines
#if DEBUG
                                            fsLine2.Features[id].Selected = feat.Selected = true;
#endif
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> LineLineNotIntersect(IFeatureSet featureSet1, IFeatureSet featureSet2)
        {
            var fsLine = featureSet1;
            var fsLine2 = featureSet2;
            var errList = new System.Collections.Generic.List<int>();
            //var errLines = new List<IGeometry>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsLine.Projection);
            try
            {
                GlobalListeners.ClearProgress();
                int i = 0;
                int num = fsLine.NumFeatures;
                var msg = "线线相交";
                GlobalListeners.ReportProgress("", i, msg);
                foreach (var feat in fsLine.Features)
                {
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polyline)
                    {
                        int[] resultIds = null;
                        var filter = geom;
                        if (fsLine2.GetRelatedShapes(filter, SpatialRelation.Intersects, ref resultIds))
                        {
                            foreach (var id in resultIds)
                            {
                                var line = fsLine2.GetGeometry(id);
                                var intersections = filter.Intersection(line);
                                if (intersections.Count() > 0)
                                {
                                    errList.Add(feat.Index);
                                    foreach (var interGeom in intersections)
                                    {
                                        if (interGeom.GeometryType == GeometryType.Point || interGeom.GeometryType == GeometryType.MultiPoint)
                                        {
                                            if (geom.Points[0].Distance(interGeom.Points[0]) <= tolerance
                                                || geom.Points[geom.Points.Count - 1].Distance(interGeom.Points[0]) <= tolerance)
                                                continue;

                                            errList.Add(feat.Index);
                                            //errLines.Add(interGeom);
                                            errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, interGeom));
#if DEBUG
                                            feat.Selected = true;
                                            fsLine2.Features[id].Selected = true;
#endif
                                        }
                                    }
                                }
                            }
                        }
                        GlobalListeners.ReportProgress("", i++ * 100 / num, msg);
                        System.Threading.Thread.Sleep(1);
                    }
                }
                GlobalListeners.ReportProgress(string.Empty, 100, msg);
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> LineInPolygon(IFeatureSet fsLine, IFeatureSet fsArea)
        {
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            double tolerance = CalcTolarance(fsLine.Projection);

            try
            {
                var doneIds = new List<int>();
                //var doneIds = System.Collections.Generic.HashSet // TODO：consider use hash set or some other collection have better performance than List.
                foreach (var feat in fsLine.Features)
                {
                    if (doneIds.Contains(feat.Index))
                        continue;
                    var geom = feat.Geometry;
                    bool InPolygon = false;
                    if (geom.GeometryType == GeometryType.Polyline)
                    {
                        int[] resultIds = null;
                        var filter = geom;
                        if (fsArea.GetRelatedShapes(filter, SpatialRelation.Within, ref resultIds))
                        {
                            InPolygon = true;
                            doneIds.Add(feat.Index);
                            foreach (var id in resultIds)
                            {
                                var poly = fsArea.GetGeometry(id);
                                int[] resLineIds = null;
                                if (fsLine.GetRelatedShapes(poly, SpatialRelation.Contains, ref resLineIds))
                                {
                                    foreach (var lineid in resLineIds)
                                    {
                                        if (lineid != feat.Index)
                                        {
                                            doneIds.Add(lineid);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!InPolygon)
                    {
                        errList.Add(feat.Index);
                        errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, feat.Geometry));
                        // TODO; calculate and return part of line not in polygon
#if DEBUG
                        feat.Selected = true;
                        Console.WriteLine($"Line {feat.Index} not within any polygon.");
#endif
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PolygonNotOverlaps(IFeatureSet fsArea)
        {
            // Geometries in one layer must not have any intersection area
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();
            var tolarance = CalcTolarance(fsArea.Projection);

            try
            {
                foreach (var feat in fsArea.Features)
                {
                    if (errList.Contains(feat.Index))
                        continue;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polygon)
                    {
                        int[] resultIds = null;
                        if (fsArea.GetRelatedShapes(geom, SpatialRelation.Intersects, ref resultIds))
                        {
                            if (resultIds.Length > 1)
                            {
                                foreach (var id in resultIds)
                                {
                                    if (id != feat.Index)
                                    {
                                        if (errList.Contains(id))
                                            continue;
                                        var selGeom = fsArea.GetGeometry(id);
                                        if (selGeom.Overlaps(geom))
                                        {
                                            var intersections = selGeom.Intersection(geom);
                                            var isOverlaps = false;
                                            foreach (var intersectionItem in intersections)
                                            {
                                                if (intersectionItem.Area > 0)
                                                {
                                                    isOverlaps = true;
                                                }
                                            }
                                            if (isOverlaps)
                                            {
                                                errList.Add(feat.Index);
                                                errList.Add(id);
                                                var overShp = selGeom.Clip(geom, ClipOperation.Intersection);
                                                errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, overShp));
                                                // TODO: Must return overpaps area
#if DEBUG
                                                feat.Selected = true;
                                                fsArea.Features[id].Selected = true;
                                                Console.WriteLine($"Polygon {feat.Index} overlap with.");
                                                Console.WriteLine($"Polygon {id} overlap with.");
#endif
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        // No gaps in one layer
        internal static IEnumerable<TopologyCheckRuleResult> PolygonNoGaps(IFeatureSet fsArea)
        {
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();

            var tolarance = CalcTolarance(fsArea.Projection);

            var resDissolve = fsArea.Dissolve(-1, false);
            var lowhull = new FeatureSet(GeometryType.Polygon);
            lowhull.Projection.CopyFrom(fsArea.Projection);
            lowhull.StartEditingShapes();
            foreach (var feat in resDissolve.Features)
            {
                var geom = feat.Geometry;
                foreach (var part in geom.Parts)
                {
                    if (!part.IsValid && part.IsValidReason.Contains("clockwise"))
                    {
                        int[] resIds = null;
                        if (fsArea.GetRelatedShapes(part, SpatialRelation.Intersects, ref resIds))
                        {
                            errList.AddRange(resIds);
                            var gap = part.FixUp();
                            errResultList.Add(new TopologyCheckRuleResult(resIds[0], -1, gap));
                            // TODO : return gaps area as a result
#if DEBUG
                            foreach (var id in resIds)
                            {
                                fsArea.Features[id].Selected = true;
                            }
#endif
                        }
                    }
                }
            }
            lowhull.StopEditingShapes();

            return errResultList;
        }

        /// <summary>
        /// Polygon boundary must overlaps by lines
        /// We can use lines that polygon boundar overlaps to erase boundary, the result of last boundary cannot erased is error
        /// </summary>
        /// <param name="fsArea"></param>
        /// <param name="fsLine"></param>
        /// <returns></returns>
        internal static IEnumerable<TopologyCheckRuleResult> PolygonBoundaryMustOverlapsByLines(IFeatureSet fsArea, IFeatureSet fsLine)
        {
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();
            var tolarance = CalcTolarance(fsArea.Projection);

            GlobalListeners.ClearProgress();
            var msg = "拓扑检查(面线重合)";
            int i = 0;
            GlobalListeners.ReportProgress("", 0, msg);
            foreach (var feat in fsArea.Features)
            {
                var geom = feat.Geometry;
                if (geom.GeometryType == GeometryType.Polygon)
                {
                    bool isCovered = false;
                    int[] resultIds = null;
                    IGeometry boundLine = geom.Boundary();
                    var filter = geom.Buffer(Tolerance * 2, 15);
                    if (fsLine.GetRelatedShapes(filter, SpatialRelation.Intersects, ref resultIds))
                    {
                        foreach (var id in resultIds)
                        {
                            var geomLine = fsLine.GetGeometry(id);
                            var lineBuffer = geomLine.BufferWithParams(Tolerance, 2, capStyle: BufferCap.Flat);

                            try
                            {
                                if (boundLine.InternalObject != null)
                                {
                                    boundLine = boundLine.Clip(lineBuffer, ClipOperation.Difference);
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }

                        if (boundLine.InternalObject == null || boundLine.Length == 0)
                        {
                            isCovered = true;
                        }
                    }

                    if (!isCovered)
                    {
                        errList.Add(feat.Index);
                        errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, boundLine));
#if DEBUG
                        //if (resultIds == null || resultIds.Length == 0)
                        //    errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, filter));
                        //feat.Selected = true;
#endif
                    }
                }

                GlobalListeners.ReportProgress("", i++ * 100 / fsArea.NumFeatures , msg);
            }

            return errResultList;
        }

        /// <summary>
        /// PolygonMustBeCoverdBy 
        /// Covered means goemetry of layer1 must within or equel atleast one of geometry of layer2
        /// Same with ArcGIS topology rule: Must Be Covered By
        /// </summary>
        /// <param name="fsArea"></param>
        /// <param name="fsArea2"></param>
        /// <returns></returns>
        internal static IEnumerable<TopologyCheckRuleResult> PolygonMustBeCoverdBy(IFeatureSet fsArea, IFeatureSet fsArea2)
        {
            if (fsArea.GeometryType != GeometryType.Polygon || fsArea2.GeometryType != GeometryType.Polygon)
                return null;

            //var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();
            var tolarance = CalcTolarance(fsArea.Projection);
            try
            {
                foreach (var feat in fsArea.Features)
                {
                    var hasCoverd = false;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polygon)
                    {
                        int[] resultIds = null;
                        if (fsArea2.GetRelatedShapes(geom, SpatialRelation.Intersects, ref resultIds))
                        {
                            var geomDiff = geom;
                            foreach (var selId in resultIds)
                            {
                                var geomSel = fsArea2.GetGeometry(selId);
                                if (geomSel.Buffer(Tolerance, 3).Contains(geom))
                                {
                                    hasCoverd = true;
                                    break;
                                }
                                if (geomDiff.InternalObject != null)
                                    geomDiff = geomDiff.Clip(geomSel, ClipOperation.Difference);
                            }
                            if (!hasCoverd && geomDiff.InternalObject != null)
                            {
                                // TODO: Return geomDiff geometry as a result?
                                errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, geomDiff));
                                hasCoverd = true;
                            }
                        }
                    }

                    if (!hasCoverd)
                    {
                        //errList.Add(feat.Index);
                        errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, feat.Geometry));
#if DEBUG
                        feat.Selected = true;
#endif
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        /// <summary>
        /// 待检查的面图层的要素不能被参考图层的要素覆盖
        /// </summary>
        /// <param name="fsArea">输入面图层，待检查的图层</param>
        /// <param name="fsArea2">输入面图层，作为参考图层</param>
        /// <returns></returns>
        internal static IEnumerable<TopologyCheckRuleResult> PolygonMustNotOverlapWith(IFeatureSet fsArea, IFeatureSet fsArea2)
        {
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();
            var tolarance = CalcTolarance(fsArea.Projection);
            try
            {
                foreach (var feat in fsArea.Features)
                {
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polygon)
                    {
                        int[] resultIds = null;
                        if (fsArea2.GetRelatedShapes(geom, SpatialRelation.Intersects, ref resultIds))
                        {
                            if (resultIds.Length > 0)
                            {
                                foreach (var id in resultIds)
                                {
                                    var geomSel = fsArea2.GetGeometry(id);
                                    if (geom.Relates(geomSel, SpatialRelation.Intersects))
                                    {
                                        var areaOver = geom.Intersection(geomSel);
                                        var area = areaOver.Sum(a => a.Area);
                                        if (area > 0)
                                        {
                                            errList.Add(feat.Index);
                                            // TODO: return overlaps parts of polygons
                                            foreach (var g in areaOver)
                                            {
                                                errResultList.Add(new TopologyCheckRuleResult(feat.Index, id, g));
                                            }
#if DEBUG
                                            feat.Selected = true;
#endif
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

        internal static IEnumerable<TopologyCheckRuleResult> PolygonMustPartOverlapWith(IFeatureSet fsArea, IFeatureSet fsArea2)
        {
            var errList = new List<int>();
            var errResultList = new List<TopologyCheckRuleResult>();
            var tolarance = CalcTolarance(fsArea.Projection);
            try
            {
                foreach (var feat in fsArea.Features)
                {
                    var hasCoverd = false;
                    var geom = feat.Geometry;
                    if (geom.GeometryType == GeometryType.Polygon)
                    {
                        int[] resultIds = null;
                        if (fsArea2.GetRelatedShapes(geom, SpatialRelation.Intersects, ref resultIds))
                        {
                            foreach (var id in resultIds)
                            {
                                var geomSel = fsArea2.GetGeometry(id);
                                //if (geom.Intersects(geomSel) && !(geom.Within(geomSel) || geom.Contains(geomSel) || geom.Equals(geomSel)))
                                var geomIntersection = geom.Intersection(geomSel);
                                var areaIntersection = geomIntersection.Sum(g => g.Area);
                                if (areaIntersection > 0 && areaIntersection < geomSel.Area && areaIntersection < geom.Area)
                                {
                                    hasCoverd = true;
                                    break;
                                }
                            }

                            // TODO: Return 
                        }
                    }
                    if (!hasCoverd)
                    {
                        errList.Add(feat.Index);
                        errResultList.Add(new TopologyCheckRuleResult(feat.Index, -1, feat.Geometry));
#if DEBUG
                        feat.Selected = true;
#endif
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return errResultList;
        }

    }
}