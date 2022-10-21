using System;
using MW5.Api.Helpers;
using MW5.Data.Enums;
using MW5.Shared;

namespace MW5.Data.Repository
{
    public class RepositoryItemTypeConverter : IEnumConverter<RepositoryItemType>
    {
        public string GetString(RepositoryItemType value)
        {
            switch (value)
            {
                case RepositoryItemType.FileSystem:
                    return "文件夹连接";
                case RepositoryItemType.Folder:
                    return "文件夹";
                case RepositoryItemType.Vector:
                    return "矢量图层";
                case RepositoryItemType.Databases:
                    return "空间数据库";
                case RepositoryItemType.Server:
                    return "服务";
                case RepositoryItemType.Database:
                    return "数据库";
                case RepositoryItemType.TmsRoot:
                    return "TMS服务";
                case RepositoryItemType.TmsSource:
                    return "TMS添加向导";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }
}
