using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.UI.Controls;

namespace MW5.Plugins.Symbology.Helpers
{
    public static class VectorInfoHelper
    {
        public static NodeData GetFeatureSetInfo(IFeatureSet featureSet)
        {
            var ext = featureSet.Envelope;
            string type = featureSet.GeometryType.ToString();

            var root = new NodeData("矢量图层");

            root.AddSubItem("几何类型", type);
            root.AddSubItem("要素数量", featureSet.NumFeatures);
            root.AddSubItem("已选择要素", featureSet.NumSelected);
            root.AddSubItem("数据源", featureSet.Filename);
            root.AddSubItem("X范围", String.Format("{0:F2}", ext.MaxX) + " to " + String.Format("{0:F2}", ext.MaxX));
            root.AddSubItem("Y范围", String.Format("{0:F2}", ext.MinY) + " to " + String.Format("{0:F2}", ext.MaxY));
            root.AddSubItem("投影信息", featureSet.Projection.ExportToProj4());

            return root;
        }

        public static NodeData GetVectorLayerInfo(IVectorLayer ogr)
        {
            if (ogr == null)
            {
                return new NodeData("OGR datasourc", "ESRI Shapefile");
            }

            var root = new NodeData("OGR datasource");
            root.AddSubItem("Datasource type", "OGR layer");
            root.AddSubItem("Driver name", ogr.DriverName);
            root.AddSubItem("Connection string", ogr.ConnectionString);
            root.AddSubItem("Layer type", ogr.SourceType.ToString());
            root.AddSubItem("Name or query", ogr.SourceQuery);
            root.AddSubItem("Supports editing", ogr.get_SupportsEditing(SaveType.SaveAll).ToString());
            root.AddSubItem("Dynamic loading", ogr.DynamicLoading.ToString());

            return root;
        }
    }
}
