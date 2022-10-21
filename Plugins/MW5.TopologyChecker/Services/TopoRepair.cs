using MW5.Api.Enums;
using MW5.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.TopologyChecker.Model;
using System.Collections;
using MW5.Plugins.Interfaces;
using MW5.Api.Helpers;

namespace MW5.Plugins.TopologyChecker.Services
{
    static class GeometryHelper
    {
        public static void SnapToGeometry(this IGeometry geom, IGeometry toGeom, double tolerance)
        {
            var closestPoints = geom.ClosestPoints(toGeom);
            for (int idxPt = 0; idxPt < toGeom.Points.Count; idxPt++)
            {
                var pt = toGeom.Points[idxPt];
                var idxGuess = geom.Points.IndexOf(pt);

                if (idxGuess == -1) // insert point to geom
                {
                    var ptNew = new Api.Concrete.Geometry(GeometryType.Point);
                    ptNew.Points.Add(pt);
                    int iptGeom = 0;
                    var pt0 = geom.Points[0];
                    for (iptGeom = 1; iptGeom < geom.Points.Count; iptGeom++)
                    {
                        var pt1 = geom.Points[iptGeom];

                        // calulate pt to segment pt0 pt1
                        var segment = new Api.Concrete.Geometry(GeometryType.Polyline);
                        segment.Points.Add(pt0);
                        segment.Points.Add(pt1);
                        var dist = segment.Distance(ptNew);
                        if (dist > 0 && dist <= tolerance)
                        {
                            geom.Points.Insert(iptGeom, pt);
                            break;
                        }

                        pt0 = pt1;
                    }
                }
            }
        }
    }

    internal class TopoRepair : TopoConfig
    {
        internal static bool PointNotDuplicate(IList dataSource, string ruleDesc, IAppContext appContext, bool remainOne = true) // List TopologyCheckResult
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);

            var ret = true;
            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res)
                {
                    if (res.Rule == ruleDesc)
                    {
                        var layer = appContext.Layers[res.LayerName];
                        var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                        System.Diagnostics.Debug.Assert(layer == layerH);
                        if (!layer.FeatureSet.EditingShapes)
                        {
                            layer.FeatureSet.StartEditingShapes();
                            dictFeats.Add(layer, new List<int>());
                        }
                        dictFeats[layer].Add(res.FeatureIndex);
                        if (res.LayerHandle2 == -1 && res.FeatureIndex2 >= 0)
                            dictFeats[layer].Add(res.FeatureIndex2);
                    }
                }
            }

            foreach (var l in appContext.Layers)
            {
                if (l.FeatureSet.EditingShapes && dictFeats.ContainsKey(l))
                {
                    var indeces = dictFeats[l];
                    indeces.Sort();
                    var deleted = new List<int>();
                    for (int i = indeces.Count - 1; i >= 0; i--)
                    {
                        int[] resualtArray = null;
                        var geomBuffer = l.FeatureSet.Features[indeces[i]].Geometry.Buffer(tolerance, 30);
                        if (remainOne &&
                            l.FeatureSet.GetRelatedShapes(geomBuffer, SpatialRelation.Intersects, ref resualtArray))
                        {
                            if (resualtArray.Length == 1)
                            {
                                //dataSource.RemoveAt(i); // TODO：同步
                                continue;
                            }
                        }

                        var isDelete = l.FeatureSet.Features.EditDelete(indeces[i]);
                        if (!isDelete)
                        {
                            ret = false;
                        }
                        else
                        {
                            deleted.Add(indeces[i]);
                            //dataSource.RemoveAt(i); // TODO：同步
                        }
                    }

                    // delete id form records
                    for (int i = dataSource.Count - 1; i >= 0; i--)
                    {
                        if (dataSource[i] is TopologyCheckResult res)
                        {
                            if (res.Rule == ruleDesc && res.LayerHandle == l.Handle && res.LayerName == l.Name)
                            {
                                foreach (var idx in deleted)
                                {
                                    if (idx == res.FeatureIndex)
                                    {
                                        dataSource.RemoveAt(i);
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    // modify id in other rules
                    foreach (var item in dataSource)
                    {
                        if (item is TopologyCheckResult res)
                        {
                            if (res.LayerHandle == l.Handle && res.LayerName == l.Name)
                            {
                                foreach (var idx in deleted)
                                {
                                    if (res.FeatureIndex > idx)
                                    {
                                        res.FeatureIndex--;
                                    }
                                    if (res.LayerName2 == "" && res.FeatureIndex2 > idx)
                                    {
                                        res.FeatureIndex2--;
                                    }
                                }
                            }
                        }
                    }

                    // delete geometry from topology err layer
                    // TODO:
                    var errLayers = new ILayer[] { appContext.Layers[TopologyCheckService.pointLayerName],
                        //appContext.Layers[TopologyCheckService.lineLayerName],
                        //appContext.Layers[TopologyCheckService.polyLayerName],
                    };

                    foreach (var errLayer in errLayers)
                    {
                        var fieldLayer = errLayer.FeatureSet.Fields.FirstOrDefault(fld => fld.Name == "层1");
                        var fieldFID = errLayer.FeatureSet.Fields.FirstOrDefault(fld => fld.Name == "要素ID1");
                        var fieldLayer2 = errLayer.FeatureSet.Fields.FirstOrDefault(fld => fld.Name == "层2");
                        var fieldFID2 = errLayer.FeatureSet.Fields.FirstOrDefault(fld => fld.Name == "要素ID2");
                        var fieldRule = errLayer.FeatureSet.Fields.FirstOrDefault(fld => fld.Name == "拓扑规则");

                        try
                        {
                            errLayer.FeatureSet.StartEditingShapes();
                            for (int i = errLayer.FeatureSet.NumFeatures - 1; i >= 0; i--)
                            {
                                var feat = errLayer.FeatureSet.Features[i];
                                var index = feat.GetAsInteger(fieldFID.Index);
                                var layerName = feat.GetAsString(fieldLayer.Index);
                                var rule = feat.GetAsString(fieldRule.Index);
                                if (feat.GetAsString(fieldLayer.Index) == l.Name
                                    && deleted.Contains(index)
                                    && feat.GetAsString(fieldRule.Index) == ruleDesc)
                                {
                                    errLayer.FeatureSet.Features.EditDelete(i);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            errLayer.FeatureSet.StopEditingShapes();
                        }

                        try
                        {
                            //errLayer.FeatureSet.StartEditingTable();
                            // TODO : others index must change 
                            foreach (var feat in errLayer.FeatureSet.Features)
                            {
                                var FeatureIndex = feat.GetAsInteger(fieldFID.Index);
                                if (feat.GetAsString(fieldLayer.Index) == l.Name
                                    && deleted.Contains(FeatureIndex)
                                    && feat.GetAsString(fieldRule.Index) == ruleDesc)
                                {
                                    foreach (var idx in deleted)
                                    {
                                        if (FeatureIndex > idx)
                                        {
                                            feat.SetInteger(fieldFID.Index, FeatureIndex - 1);
                                        }
                                        if (feat.GetAsString(fieldLayer2.Index) == "")
                                        {
                                            var index2 = feat.GetAsInteger(fieldFID2.Index);
                                            if (index2 > idx)
                                                feat.SetInteger(fieldFID2.Index, index2 - 1);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            //errLayer.FeatureSet.StopEditingTable();
                        }
                    }

                    l.FeatureSet.StopEditingShapes();

                    appContext.Map.Redraw(Api.Enums.RedrawType.Minimal);
                }
            }

            return ret;
        }

        internal static bool PointPointNotDuplicate(IList dataSource, string ruleDesc, IAppContext appContext, bool remainOne = true) // List TopologyCheckResult
        {
            return PointNotDuplicate(dataSource, ruleDesc, appContext, remainOne);
        }

        internal static bool PointOverlapLineEnds(IList dataSource, string ruleDesc, IAppContext context)
        {
            return PointNotDuplicate(dataSource, ruleDesc, context, false);
        }

        internal static bool LineNotOverlaps(IList dataSource, string ruleDesc, IAppContext context, string repairMethod)
        {
            Console.WriteLine(ruleDesc);
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res)
                {
                    if (res.Rule == ruleDesc)
                        Console.WriteLine(res.Rule, res.LayerName, res.FeatureIndex);
                }
            }

            switch (repairMethod)
            {
                case "合并到长的线":
                    break;
                case "合并到短的线":
                    break;
                case "解散到单独的线":
                    break;
                default:
                    break;
            }

            return false;
        }

        internal static bool LineNotIntersect(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            bool ret = true;
            var errLayer = appContext.Layers[TopologyCheckService.pointLayerName];
            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res && res.Rule == ruleDesc)
                {
                    var baseLayer = appContext.Layers[res.LayerName2];
                    var layer = appContext.Layers[res.LayerName];
                    var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                    System.Diagnostics.Debug.Assert(layer == layerH);
                    if (!layer.FeatureSet.EditingShapes)
                    {
                        layer.FeatureSet.StartEditingShapes();
                    }
                    if (!dictFeats.ContainsKey(layer))
                    {
                        dictFeats.Add(layer, new List<int>());
                    }
                    if (!errLayer.FeatureSet.EditingShapes)
                    {
                        errLayer.FeatureSet.StartEditingShapes();
                    }
                    if (!dictFeats.ContainsKey(errLayer))
                    {
                        dictFeats.Add(errLayer, new List<int>());
                    }
                    int[] resultArray = null;
                    if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Equals, ref resultArray))
                    {
                        for (int k = resultArray.Length - 1; k >= 0; k--)
                        {
                            dictFeats[errLayer].Add(resultArray[k]);
                        }
                    }

                    if (layer.FeatureSet.GetRelatedShapes(res.ErrGeom.Buffer(Tolerance, 4), SpatialRelation.Intersects, ref resultArray))
                    {
                        foreach (var id in resultArray)
                        {
                            //layer.FeatureSet.Features.EditAdd()
                            //layer.FeatureSet.Features.EditUpdate()
                            var line = layer.FeatureSet.Features[id].Geometry;
                            if (line.GeometryType == GeometryType.Polyline)
                            {
                                //line.SplitByPolyline()
                            }
                        }
                    }

                    dataSource.RemoveAt(i);
                }
            }

            switch (repairMethod)
            {
                case "打断长的线":
                    break;
                case "打断短的线":
                    break;
                case "打断所有相交的线":
                    break;
                default:
                    break;
            }

            foreach (var layer in appContext.Layers)
            {
                if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                {
                    foreach (var idx in dictFeats[layer].Distinct())
                    {
                        if (!layer.FeatureSet.Features.EditDelete(idx))
                        {
                            ret = false;
                        }
                    }
                    layer.FeatureSet.StopEditingShapes();
                }
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);
            return ret;
        }

        /// <summary>
        /// 线与线相交
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="ruleDesc"></param>
        /// <param name="appContext"></param>
        /// <param name="repairMethod"></param>
        internal static bool LineLineNotIntersect(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);
            var errLayer = appContext.Layers[TopologyCheckService.pointLayerName];
            if (errLayer == null)
                return false;

            switch (repairMethod)
            {
                case "删除线要素":
                case "删除相交的线":
                case "打断线要素":
                    var ret = true;
                    var dictFeats = new Dictionary<ILayer, List<int>>();
                    for (int i = dataSource.Count - 1; i >= 0; i--)
                    {
                        if (dataSource[i] is TopologyCheckResult res && res.Rule == ruleDesc)
                        {
                            var baseLayer = appContext.Layers[res.LayerName2];
                            var layer = appContext.Layers[res.LayerName];
                            var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                            System.Diagnostics.Debug.Assert(layer == layerH);

                            if (!layer.FeatureSet.EditingShapes)
                            {
                                layer.FeatureSet.StartEditingShapes();
                            }
                            if (!dictFeats.ContainsKey(layer))
                            {
                                dictFeats.Add(layer, new List<int>());
                            }
                            if (!errLayer.FeatureSet.EditingShapes)
                            {
                                errLayer.FeatureSet.StartEditingShapes();
                            }
                            if (!dictFeats.ContainsKey(errLayer))
                            {
                                dictFeats.Add(errLayer, new List<int>());
                            }
                            int[] resultArray = null;
                            if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Equals, ref resultArray) && resultArray.Length > 0)
                            {
                                for (int k = resultArray.Length - 1; k >= 0; k--)
                                {
                                    dictFeats[errLayer].Add(resultArray[k]);
                                }
                            }
                            var filterGeom = res.ErrGeom.Buffer(tolerance * 10, 5);
                            resultArray = null;
                            var related = layer.FeatureSet.GetRelatedShapes(filterGeom, SpatialRelation.Intersects, ref resultArray);
                            if (related && resultArray?.Length > 0)
                            {
                                for (int k = resultArray.Length - 1; k >= 0; k--)
                                {
                                    var id = resultArray[k];
                                    int[] idsArray = null;
                                    if (repairMethod == "打断线要素" &&
                                        baseLayer.FeatureSet.GetRelatedShapes(filterGeom, SpatialRelation.Intersects, ref idsArray))
                                    {
                                        var featLine = layer.FeatureSet.Features[id];
                                        foreach (var baseIdx in idsArray)
                                        {
                                            var featBaseLine = baseLayer.FeatureSet.Features[baseIdx];
                                            var intersection = featLine.Geometry.Clip(featBaseLine.Geometry, ClipOperation.Intersection);
                                            var splitedLines = featLine.Geometry.SplitByPolyline(featBaseLine.Geometry);
                                            bool isNew = true;
                                            foreach (var newLine in splitedLines)
                                            {
                                                if (newLine.GeometryType == GeometryType.Polyline)
                                                {
                                                    if (isNew)
                                                    {
                                                        layer.FeatureSet.Features.EditUpdate(id, newLine);
                                                        isNew = false;
                                                    }
                                                    else
                                                    {
                                                        var idxNew = layer.FeatureSet.Features.EditAdd(newLine);
                                                        for (int idxField = 0; idxField < featLine.NumFields; idxField++)
                                                        {
                                                            layer.FeatureSet.Features[idxNew].SetValue(idxField, featLine.GetValue(idxField));
                                                        }
                                                    }
                                                }
                                            }
                                            break; // Just one intersection point
                                        }
                                    }
                                    else
                                    {
                                        dictFeats[layer].Add(id);
                                    }
                                }
                            }
                            else
                            {

                            }
                            dataSource.RemoveAt(i);
                        }
                    }

                    foreach (var layer in appContext.Layers)
                    {
                        if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                        {
                            foreach (var idx in dictFeats[layer].Distinct())
                            {
                                if (!layer.FeatureSet.Features.EditDelete(idx))
                                {
                                    ret = false;
                                }
                            }
                            layer.FeatureSet.StopEditingShapes();
                        }
                    }
                    if (dictFeats.Count > 0)
                        appContext.Map.Redraw(Api.Enums.RedrawType.All);
                    return ret;
            }

            return false;
        }

        /// <summary>
        /// 线在面内
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="ruleDesc"></param>
        /// <param name="context"></param>
        /// <param name="repairMethod"></param>
        internal static bool LineInPolygon(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);

            switch (repairMethod)
            {
                case "删除错误线":
                case "截断并保留在面内的部分":
                    {
                        var errLayer = appContext.Layers[TopologyCheckService.lineLayerName];
                        var ret = true;
                        var dictFeats = new Dictionary<ILayer, List<int>>();
                        for (int i = dataSource.Count - 1; i >= 0; i--)
                        {
                            if (dataSource[i] is TopologyCheckResult res && res.Rule == ruleDesc)
                            {
                                var baseLayer = appContext.Layers[res.LayerName2];
                                var layer = appContext.Layers[res.LayerName];
                                var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                                System.Diagnostics.Debug.Assert(layer == layerH);
                                if (!layer.FeatureSet.EditingShapes)
                                {
                                    layer.FeatureSet.StartEditingShapes();
                                }
                                if (!dictFeats.ContainsKey(layer))
                                {
                                    dictFeats.Add(layer, new List<int>());
                                }
                                if (!errLayer.FeatureSet.EditingShapes)
                                {
                                    errLayer.FeatureSet.StartEditingShapes();
                                }
                                if (!dictFeats.ContainsKey(errLayer))
                                {
                                    dictFeats.Add(errLayer, new List<int>());
                                }
                                var relation = SpatialRelation.Equals;
                                int[] resultArray = null;
                                if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, relation, ref resultArray) && resultArray.Length > 0)
                                {
                                    for (int k = resultArray.Length - 1; k >= 0; k--)
                                    {
                                        dictFeats[errLayer].Add(resultArray[k]);
                                    }
                                }
                                if (layer.FeatureSet.GetRelatedShapes(res.ErrGeom, relation, ref resultArray) && resultArray.Length > 0)
                                {
                                    for (int k = resultArray.Length - 1; k >= 0; k--)
                                    {
                                        var id = resultArray[k];
                                        int[] idsArray = null;
                                        if (repairMethod == "截断并保留在面内的部分" &&
                                            baseLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Intersects, ref idsArray))
                                        {
                                            var feat = layer.FeatureSet.Features[id];
                                            foreach (var baseIdx in idsArray)
                                            {
                                                var featPolygon = baseLayer.FeatureSet.Features[baseIdx];
                                                var intersection = feat.Geometry.Clip(featPolygon.Geometry, Api.Enums.ClipOperation.Intersection);
                                                if (intersection.Parts.Count == 1)
                                                {
                                                    layer.FeatureSet.Features.EditUpdate(id, intersection);
                                                }
                                                else if (intersection.Parts.Count > 1)
                                                {
                                                    layer.FeatureSet.Features.EditUpdate(id, intersection.Parts[0]);
                                                    for (int idxPart = 1; idxPart < intersection.Parts.Count; idxPart++)
                                                    {
                                                        int idxNew = layer.FeatureSet.Features.EditAdd(intersection.Parts[idxPart]);
                                                        for (int idxField = 0; idxField < feat.NumFields; idxField++)
                                                        {
                                                            layer.FeatureSet.Features[idxNew].SetValue(idxField, feat.GetValue(idxField));
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            dictFeats[layer].Add(id);
                                        }
                                    }
                                }
                                else
                                {

                                }

                                dataSource.RemoveAt(i);
                            }
                        }

                        foreach (var layer in appContext.Layers)
                        {
                            if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                            {
                                foreach (var idx in dictFeats[layer].Distinct())
                                {
                                    if (!layer.FeatureSet.Features.EditDelete(idx))
                                    {
                                        ret = false;
                                    }
                                }
                                layer.FeatureSet.StopEditingShapes();
                            }
                        }
                        if (dictFeats.Count > 0)
                            appContext.Map.Redraw(Api.Enums.RedrawType.All);
                        return ret;
                    }
            }
            return false;
        }

        /* ********************************************** POLYGON ********************************************* */

        private static bool Explode(IFeatureSet fs, int FeatureIndex)
        {
            var dict = new Dictionary<int, IGeometry[]>();
            var feat = fs.Features[FeatureIndex];
            // exploding
            var arr = feat.Geometry.Explode().ToArray();
            if (arr.Length > 0)
            {
                dict[feat.Index] = arr;
            }
            else
            {
                return false;
            }

            // add new shapes
            foreach (var item in dict.ToList())
            {
                foreach (var shp in item.Value.ToList())
                {
                    int shapeIndex = fs.Features.EditAdd(shp);
                    fs.Table.CopyAttributes(item.Key, shapeIndex);
                }
            }

            return true;
        }

        internal static bool PolygonNotOverlaps(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);
            var ret = true;
            var errLayer = appContext.Layers[TopologyCheckService.polyLayerName];
            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res)
                {
                    if (res.Rule == ruleDesc)
                    {
                        var layer = appContext.Layers[res.LayerName];
                        var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                        System.Diagnostics.Debug.Assert(layer == layerH);
                        if (!layer.FeatureSet.EditingShapes)
                        {
                            layer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(layer))
                        {
                            dictFeats.Add(layer, new List<int>());
                        }
                        if (!errLayer.FeatureSet.EditingShapes)
                        {
                            errLayer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(errLayer))
                        {
                            dictFeats.Add(errLayer, new List<int>());
                        }
                        var relation = SpatialRelation.Equals;
                        int[] resultArray = null;
                        if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, relation, ref resultArray) && resultArray.Length > 0)
                        {
                            for (int k = resultArray.Length - 1; k >= 0; k--)
                            {
                                dictFeats[errLayer].Add(resultArray[k]);
                            }
                        }
                        int[] idsOverlaps = null;
                        var fs = layer.FeatureSet;
                        // 最大和最小面容易选择到相邻的面，需要注意
                        if (fs.GetRelatedShapes(res.ErrGeom.Buffer(tolerance * -1, 4), SpatialRelation.Intersects, ref idsOverlaps))
                        {
                            int clipingPolyIndex = -1;
                            double maxArea = double.MinValue;
                            double minArea = double.MaxValue;
                            var added = false;
                            foreach (var id in idsOverlaps)
                            {
                                var feat = fs.Features[id];
                                var geom = feat.Geometry;
                                var intersections = geom.Intersection(res.ErrGeom);
                                if (intersections.Count() == 0)
                                    continue;

                                // 认为是多边形，不检查面积，拓扑检查的时候已经检查过了
                                foreach (var interes in intersections)
                                {
                                    // TEMP TEST: 相交处加点，否则求差后多边形会有一些尖锐的边角
                                    // TODO: 测试效果消除了毛刺，看来需要进行一些处理，这个功能可以作为一个接口提供，可以在Map控件中实现
                                    geom.SnapToGeometry(interes, tolerance);

                                    switch (repairMethod)
                                    {
                                        case "删除重叠部分，新增多边形填充空白":
                                            if (!added)
                                            {
                                                var idxNew = layer.FeatureSet.Features.EditAdd(res.ErrGeom);
                                                added = true;
                                            }
                                            goto case "删除重叠的部分,留空白";
                                        case "删除重叠的部分,留空白":
                                            // 求差
                                            var geomDiff = geom.Clip(interes, ClipOperation.Difference);
                                            fs.Features.EditUpdate(feat.Index, geomDiff);
                                            break;
                                        case "从面积大的多边形中删除重叠部分":
                                            if (maxArea < geom.Area)
                                            {
                                                maxArea = geom.Area;
                                                clipingPolyIndex = id;
                                            }
                                            break;
                                        case "从面积小的多边形中删除重叠部分":
                                            if (minArea > geom.Area)
                                            {
                                                minArea = geom.Area;
                                                clipingPolyIndex = id;
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            if (clipingPolyIndex >= 0)
                            {
                                var featMax = fs.Features[clipingPolyIndex];
                                var geom = featMax.Geometry;
                                var geomDiff = geom.Clip(res.ErrGeom, ClipOperation.Difference);
                                if (geomDiff.InternalObject != null)
                                    fs.Features.EditUpdate(clipingPolyIndex, geomDiff);
                            }
                        }

                        dataSource.RemoveAt(i);
                    }
                }
            }

            foreach (var layer in appContext.Layers)
            {
                if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                {
                    foreach (var idx in dictFeats[layer].Distinct())
                    {
                        if (!layer.FeatureSet.Features.EditDelete(idx))
                        {
                            ret = false;
                        }
                    }
                    layer.FeatureSet.StopEditingShapes();
                }
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);

            return ret;
        }

        internal static bool PolygonNoMultiParts(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            //var tolerance = CalcTolarance(appContext.Map.Projection);
            var errLayer = appContext.Layers[TopologyCheckService.polyLayerName];
            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res && res.Rule == ruleDesc)
                {
                    var baseLayer = appContext.Layers[res.LayerName2];
                    var layer = appContext.Layers[res.LayerName];
                    var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                    System.Diagnostics.Debug.Assert(layer == layerH);
                    if (!layer.FeatureSet.EditingShapes)
                    {
                        layer.FeatureSet.StartEditingShapes();
                    }
                    if (!dictFeats.ContainsKey(layer))
                    {
                        dictFeats.Add(layer, new List<int>());
                    }
                    if (!errLayer.FeatureSet.EditingShapes)
                    {
                        errLayer.FeatureSet.StartEditingShapes();
                    }
                    if (!dictFeats.ContainsKey(errLayer))
                    {
                        dictFeats.Add(errLayer, new List<int>());
                    }
                    int[] indeces = null;
                    if (layer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Equals, ref indeces) && indeces.Length > 0)
                    {
                        System.Diagnostics.Debug.Assert(indeces.Length == 1);
                        var idx = indeces[0];
                        if (!Explode(layer.FeatureSet, idx))
                            return false;
                        dataSource.RemoveAt(i);
                        var relation = SpatialRelation.Equals;
                        int[] resultArray = null;
                        if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, relation, ref resultArray) && resultArray.Length > 0)
                        {
                            for (int k = resultArray.Length - 1; k >= 0; k--)
                            {
                                dictFeats[errLayer].Add(resultArray[k]);
                            }
                        }
                    }
                }
            }

            bool ret = false;
            foreach (var layer in appContext.Layers)
            {
                if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                {
                    foreach (var idx in dictFeats[layer].Distinct())
                    {
                        if (!layer.FeatureSet.Features.EditDelete(idx))
                        {
                            ret = false;
                        }
                    }
                }
                if (layer.FeatureSet.EditingShapes)
                    layer.FeatureSet.StopEditingShapes();
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);
            return ret;
        }

        internal static bool PolygonBoundaryMustOverlapsByLines(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);
            var ret = true;
            var errLayer = appContext.Layers[TopologyCheckService.lineLayerName];
            var dictFeats = new Dictionary<ILayer, IList<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res)
                {
                    if (res.Rule == ruleDesc
                        && res.ErrGeom.GeometryType == GeometryType.Polyline)
                    {
                        var layer = appContext.Layers[res.LayerName];
                        var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                        System.Diagnostics.Debug.Assert(layer == layerH);
                        if (!dictFeats.ContainsKey(layer))
                        {
                            dictFeats.Add(layer, new List<int>());
                        }
                        if (!dictFeats.ContainsKey(errLayer))
                        {
                            dictFeats.Add(errLayer, new List<int>());
                        }
                        var relation = SpatialRelation.Equals;
                        int[] resultArray = null;
                        if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, relation, ref resultArray) && resultArray.Length > 0)
                        {
                            for (int k = resultArray.Length - 1; k >= 0; k--)
                            {
                                dictFeats[errLayer].Add(resultArray[k]);
                            }
                        }
                        int[] idsOverlaps = null;
                        var fs = layer.FeatureSet;
                        var selector = res.ErrGeom.Buffer(tolerance, 5);
                        var selRes = fs.GetRelatedShapes(selector, SpatialRelation.Intersects, ref idsOverlaps);
                        if (selRes)
                        {
                            foreach (var id in idsOverlaps)
                            {
                                var feat = fs.Features[id];
                                var geom = feat.Geometry;

                                var boundLine = geom.Boundary();

                                var boundBuff = boundLine.Buffer(tolerance, 5);

                                var within = boundBuff.Contains(res.ErrGeom);

                                if (within)
                                {
                                    dictFeats[layer].Add(id);
                                }
                            }
                        }

                        dataSource.RemoveAt(i);
                    }
                }
            }

            foreach (var layer in appContext.Layers)
            {
                if (dictFeats.ContainsKey(layer))
                {
                    var ids = dictFeats[layer].Distinct();
                    layer.FeatureSet.StartEditingShapes();
                    foreach (var idx in ids)
                    {
                        if (!layer.FeatureSet.Features.EditDelete(idx))
                        {
                            ret = false;
                        }
                    }
                    layer.FeatureSet.StopEditingShapes();
                }
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);

            return ret;
        }

        internal static bool PolygonMustBeCovredBy(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);
            var errLayer = appContext.Layers[TopologyCheckService.polyLayerName];
            if (errLayer == null)
                return false;

            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res && res.Rule == ruleDesc)
                {
                    if (res.Rule == ruleDesc)
                    {
                        var baseLayer = appContext.Layers[res.LayerName2];
                        var layer = appContext.Layers[res.LayerName];
                        var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                        System.Diagnostics.Debug.Assert(layer == layerH);

                        if (!layer.FeatureSet.EditingShapes)
                        {
                            layer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(layer))
                        {
                            dictFeats.Add(layer, new List<int>());
                        }
                        if (!errLayer.FeatureSet.EditingShapes)
                        {
                            errLayer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(errLayer))
                        {
                            dictFeats.Add(errLayer, new List<int>());
                        }
                        int[] resultArray = null;
                        if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Equals, ref resultArray) && resultArray.Length > 0)
                        {
                            for (int k = resultArray.Length - 1; k >= 0; k--)
                            {
                                dictFeats[errLayer].Add(resultArray[k]);
                            }
                        }

                        int[] indeces = null;
                        var fs = layer.FeatureSet;
                        if (fs.GetRelatedShapes(res.ErrGeom, SpatialRelation.Intersects, ref indeces))
                        {
                            foreach (var id in indeces)
                            {
                                var feat = fs.Features[id];
                                int[] baseIndeces = null;
                                if (baseLayer.FeatureSet.GetRelatedShapes(feat.Geometry, SpatialRelation.Intersects, ref baseIndeces))
                                {
                                    var geomIntersection = feat.Geometry;
                                    var base_fs = baseLayer.FeatureSet;
                                    var hasCoverd = false;
                                    foreach (var base_id in baseIndeces)
                                    {
                                        var geomSel = base_fs.GetGeometry(base_id);
                                        if (geomSel.Buffer(Tolerance, 3).Contains(feat.Geometry))
                                        {
                                            hasCoverd = true;
                                            break;
                                        }
                                        if (geomIntersection.InternalObject != null)
                                        {
                                            var geomIntersect = feat.Geometry.Clip(geomSel, ClipOperation.Intersection);
                                            if (geomIntersection.InternalObject == feat.Geometry.InternalObject)
                                                geomIntersection = geomIntersect;
                                            else
                                                geomIntersection.Clip(geomIntersect, ClipOperation.Union);
                                        }
                                    }
                                    if (!hasCoverd)
                                    {
                                        switch (repairMethod)
                                        {
                                            case "删除错误多边形":
                                                dictFeats[layer].Add(id);
                                                break;
                                            case "删除边形未被覆盖的部分":
                                                if (geomIntersection.InternalObject != null)
                                                {
                                                    fs.Features.EditUpdate(id, geomIntersection);
                                                }
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    dictFeats[layer].Add(id);
                                }
                            }
                        }
                        dataSource.RemoveAt(i);
                    }
                }
            }

            var ret = true;
            foreach (var layer in appContext.Layers)
            {
                if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                {
                    foreach (var idx in dictFeats[layer].Distinct())
                    {
                        if (!layer.FeatureSet.Features.EditDelete(idx))
                        {
                            ret = false;
                        }
                    }
                    layer.FeatureSet.StopEditingShapes();
                }
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);

            return ret;
        }

        internal static bool PolygonMustNotOverlapWith(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);
            var errLayer = appContext.Layers[TopologyCheckService.polyLayerName];
            if (errLayer == null)
                return false;

            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res && res.Rule == ruleDesc)
                {
                    if (res.Rule == ruleDesc)
                    {
                        var baseLayer = appContext.Layers[res.LayerName2];
                        var layer = appContext.Layers[res.LayerName];
                        var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                        System.Diagnostics.Debug.Assert(layer == layerH);

                        if (!layer.FeatureSet.EditingShapes)
                        {
                            layer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(layer))
                        {
                            dictFeats.Add(layer, new List<int>());
                        }
                        if (!errLayer.FeatureSet.EditingShapes)
                        {
                            errLayer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(errLayer))
                        {
                            dictFeats.Add(errLayer, new List<int>());
                        }
                        int[] resultArray = null;
                        if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Equals, ref resultArray) && resultArray.Length > 0)
                        {
                            for (int k = resultArray.Length - 1; k >= 0; k--)
                            {
                                dictFeats[errLayer].Add(resultArray[k]);
                            }
                        }

                        int[] indeces = null;
                        var fs = layer.FeatureSet;
                        if (fs.GetRelatedShapes(res.ErrGeom, SpatialRelation.Intersects, ref indeces))
                        {
                            foreach (var id in indeces)
                            {
                                var feat = fs.Features[id];
                                int[] baseIndeces = null;
                                if (baseLayer.FeatureSet.GetRelatedShapes(feat.Geometry, SpatialRelation.Intersects, ref baseIndeces))
                                {
                                    var geomIntersection = feat.Geometry;
                                    var base_fs = baseLayer.FeatureSet;
                                    var isIntersect = false;
                                    foreach (var base_id in baseIndeces)
                                    {
                                        var geomSel = base_fs.GetGeometry(base_id);
                                        var intersections = geomSel.Intersection(feat.Geometry);
                                        if (intersections.Sum(g => g.Area) > 0)
                                        {
                                            isIntersect = true;

                                            if (geomIntersection.InternalObject != null)
                                            {
                                                var geomIntersect = feat.Geometry.Clip(geomSel, ClipOperation.Difference);
                                                if (geomIntersection.InternalObject == feat.Geometry.InternalObject)
                                                    geomIntersection = geomIntersect;
                                                else
                                                    geomIntersection.Clip(geomIntersect, ClipOperation.Difference);
                                            }
                                        }
                                    }
                                    if (isIntersect)
                                    {
                                        switch (repairMethod)
                                        {
                                            case "删除错误多边形":
                                                dictFeats[layer].Add(id);
                                                break;
                                            case "删除多边形重叠的部分":
                                                if (geomIntersection.InternalObject != null)
                                                {
                                                    fs.Features.EditUpdate(id, geomIntersection);
                                                }
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        dataSource.RemoveAt(i);
                    }
                }
            }

            var ret = true;
            foreach (var layer in appContext.Layers)
            {
                if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                {
                    foreach (var idx in dictFeats[layer].Distinct())
                    {
                        if (!layer.FeatureSet.Features.EditDelete(idx))
                        {
                            ret = false;
                        }
                    }
                    layer.FeatureSet.StopEditingShapes();
                }
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);

            return ret;
        }

        internal static bool PolygonMustPartOverlapWith(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            double tolerance = CalcTolarance(appContext.Map.Projection);
            var errLayer = appContext.Layers[TopologyCheckService.polyLayerName];
            if (errLayer == null)
                return false;
            if (!(new string[] { "删除错误多边形" }.Contains(repairMethod)))
                return false;

            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res && res.Rule == ruleDesc)
                {
                    if (res.Rule == ruleDesc)
                    {
                        var baseLayer = appContext.Layers[res.LayerName2];
                        var layer = appContext.Layers[res.LayerName];
                        var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                        System.Diagnostics.Debug.Assert(layer == layerH);

                        if (!dictFeats.ContainsKey(layer))
                        {
                            dictFeats.Add(layer, new List<int>());
                        }
                        if (!dictFeats.ContainsKey(errLayer))
                        {
                            dictFeats.Add(errLayer, new List<int>());
                        }
                        int[] resultArray = null;
                        if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Equals, ref resultArray) && resultArray.Length > 0)
                        {
                            for (int k = resultArray.Length - 1; k >= 0; k--)
                            {
                                dictFeats[errLayer].Add(resultArray[k]);
                            }
                        }

                        int[] indeces = null;
                        var fs = layer.FeatureSet;
                        if (fs.GetRelatedShapes(res.ErrGeom, SpatialRelation.Intersects, ref indeces))
                        {
                            foreach (var id in indeces)
                            {
                                var hasCoverd = false;
                                var feat = fs.Features[id];
                                var geom = feat.Geometry;
                                int[] baseIndeces = null;
                                if (baseLayer.FeatureSet.GetRelatedShapes(feat.Geometry, SpatialRelation.Intersects, ref baseIndeces))
                                {
                                    var base_fs = baseLayer.FeatureSet;
                                    foreach (var base_id in baseIndeces)
                                    {
                                        var geomSel = baseLayer.FeatureSet.GetGeometry(base_id);
                                        var geomIntersection = feat.Geometry.Intersection(geomSel);
                                        var areaIntersection = geomIntersection.Sum(g => g.Area);
                                        if (areaIntersection > 0 && areaIntersection < geomSel.Area && areaIntersection < geom.Area)
                                        {
                                            hasCoverd = true;
                                            break;
                                        }
                                    }
                                }
                                if (!hasCoverd)
                                {
                                    dictFeats[layer].Add(id);
                                }
                            }
                        }
                        dataSource.RemoveAt(i);
                    }
                }
            }

            var ret = true;
            foreach (var layer in appContext.Layers)
            {
                if (dictFeats.ContainsKey(layer))
                {
                    layer.FeatureSet.StartEditingShapes();
                    try
                    {
                        foreach (var idx in dictFeats[layer].Distinct())
                        {
                            if (!layer.FeatureSet.Features.EditDelete(idx))
                            {
                                ret = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        layer.FeatureSet.StopEditingShapes();
                    }
                }
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);

            return ret;
        }

        internal static bool PolygonNoGaps(IList dataSource, string ruleDesc, IAppContext appContext, string repairMethod)
        {
            var ret = true;
            var errLayer = appContext.Layers[TopologyCheckService.polyLayerName];
            var dictFeats = new Dictionary<ILayer, List<int>>();
            for (int i = dataSource.Count - 1; i >= 0; i--)
            {
                if (dataSource[i] is TopologyCheckResult res)
                {
                    if (res.Rule == ruleDesc)
                    {
                        var layer = appContext.Layers[res.LayerName];
                        var layerH = appContext.Layers.ItemByHandle(res.LayerHandle);
                        System.Diagnostics.Debug.Assert(layer == layerH);
                        if (!layer.FeatureSet.EditingShapes)
                        {
                            layer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(layer))
                        {
                            dictFeats.Add(layer, new List<int>());
                        }
                        if (!errLayer.FeatureSet.EditingShapes)
                        {
                            errLayer.FeatureSet.StartEditingShapes();
                        }
                        if (!dictFeats.ContainsKey(errLayer))
                        {
                            dictFeats.Add(errLayer, new List<int>());
                        }
                        var relation = SpatialRelation.Equals;
                        int[] resultArray = null;
                        if (errLayer.FeatureSet.GetRelatedShapes(res.ErrGeom, relation, ref resultArray) && resultArray.Length > 0)
                        {
                            for (int k = resultArray.Length - 1; k >= 0; k--)
                            {
                                dictFeats[errLayer].Add(resultArray[k]);
                            }
                        }
                        bool MergeToLarge = false;
                        switch (repairMethod)
                        {
                            case "缝隙添加新面":
                                var idxNew = layer.FeatureSet.Features.EditAdd(res.ErrGeom);
                                break;
                            case "添加新面合并到大面":
                                MergeToLarge = true;
                                goto case "添加新面合并到小面";
                            case "添加新面合并到小面":
                                if (layer.FeatureSet.GetRelatedShapes(res.ErrGeom, SpatialRelation.Intersects, ref resultArray) && resultArray.Length > 0)
                                {
                                    IFeature mergeToFeat = null;
                                    for (int k = resultArray.Length - 1; k >= 0; k--)
                                    {
                                        var id = resultArray[k];
                                        var feat = layer.FeatureSet.Features[id];
                                        if (MergeToLarge)
                                        {
                                            if (mergeToFeat == null || mergeToFeat.Geometry.Area < feat.Geometry.Area)
                                            {
                                                mergeToFeat = feat;
                                            }
                                        }
                                        else if (mergeToFeat == null || mergeToFeat.Geometry.Area > feat.Geometry.Area)
                                        {
                                            mergeToFeat = feat;
                                        }
                                    }

                                    var mergedGeom = mergeToFeat.Geometry.Clip(res.ErrGeom, ClipOperation.Union);
                                    layer.FeatureSet.Features.EditUpdate(mergeToFeat.Index, mergedGeom);
                                }
                                break;
                            default:
                                break;
                        }

                        dataSource.RemoveAt(i);
                    }
                }
            }

            foreach (var layer in appContext.Layers)
            {
                if (layer.FeatureSet.EditingShapes && dictFeats.ContainsKey(layer))
                {
                    foreach (var idx in dictFeats[layer].Distinct())
                    {
                        if (!layer.FeatureSet.Features.EditDelete(idx))
                        {
                            ret = false;
                        }
                    }
                    layer.FeatureSet.StopEditingShapes();
                }
            }
            if (dictFeats.Count > 0)
                appContext.Map.Redraw(Api.Enums.RedrawType.All);

            return ret;
        }
    }

    //class IntDecrease : IComparer<T>
    //{
    //    public int Compare(T x, T y)
    //    {
    //        if (x < y)
    //        {
    //            return 1;
    //        }
    //        return 0;
    //    }
    //}
}
