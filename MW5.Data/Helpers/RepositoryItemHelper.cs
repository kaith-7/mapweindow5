// -------------------------------------------------------------------------------------------
// <copyright file="RepositoryItemHelper.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Text;
using MW5.Api.Static;
using MW5.Data.Enums;
using MW5.Data.Repository;
using MW5.Plugins.Model;
using MW5.Shared;

namespace MW5.Data.Helpers
{
    /// <summary>
    /// Extension methods for IRepositoryItem.
    /// </summary>
    public static class RepositoryItemHelper
    {
        /// <summary>
        /// Gets the description of the item to be displayed in the UI.
        /// </summary>
        public static string GetDescription(this IRepositoryItem item)
        {
            switch (item.Type)
            {
                case RepositoryItemType.TmsSource:
                    var tmsItem = item as ITmsItem;
                    return GetDescription(tmsItem);
                case RepositoryItemType.Image:
                case RepositoryItemType.Vector:
                    var fileItem = item as IFileItem;
                    if (fileItem != null)
                    {
                        return GetDescription(fileItem.Filename);
                    }
                    break;
                case RepositoryItemType.DatabaseLayer:
                    var layerItem = item as IDatabaseLayerItem;
                    return GetDescription(layerItem);
                case RepositoryItemType.Database:
                    var dbItem = item as IDatabaseItem;
                    return GetDescription(dbItem);
            }

            return string.Empty;
        }

        private static string GetDescription(IDatabaseItem dbItem)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Type: " + dbItem.Connection.DatabaseType);
            sb.AppendLine("Connection: " + dbItem.Connection.GetUIConnection());
            return sb.ToString();
        }

        private static string GetDescription(ITmsItem tms)
        {
            if (tms == null || tms.Provider == null) return string.Empty;

            var provider = tms.Provider;

            var sb = new StringBuilder();
            if (provider.Name != "无地图切片")
            {
                sb.AppendLine("服务地址: " + provider.Url);
                sb.AppendLine("地图投影: " + provider.Projection);
            }

            if (!string.IsNullOrWhiteSpace(provider.Description))
            {
                sb.AppendLine("说明: " + provider.Description);
            }

            var bounds = provider.Bounds;
            if (provider.Name != "无地图切片")
            {
                sb.AppendFormat("纬度范围: {0} to {1}" + Environment.NewLine, bounds.MinY, bounds.MaxY);
                sb.AppendFormat("经度范围: {0} to {1}" + Environment.NewLine, bounds.MinX, bounds.MaxX);
            }

            return sb.ToString();
        }

        private static string GetDescription(IDatabaseLayerItem item)
        {
            if (item == null)
            {
                return string.Empty;
            }

            var s = "数据几何类型: " + item.GeometryType.EnumToString() + Environment.NewLine;
            s += "数据包含要素数量: " + item.NumFeatures + Environment.NewLine;
            // s += "Projection: " + item.Projection.ExportToProj4();
            s += "投影: " + item.Projection.Name;
            return s;
        }

        private static string GetDescription(string filename)
        {
            using (var ds = GeoSource.Open(filename))
            {
                if (ds != null)
                {
                    return ds.ToolTipText;
                }
            }

            return string.Empty;
        }
    }
}