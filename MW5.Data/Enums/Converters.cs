using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Shared;

namespace MW5.Data.Enums
{
    public class DriverFilterConverter: IEnumConverter<DriverFilter>
    {
        public string GetString(DriverFilter value)
        {
            switch (value)
            {
                case DriverFilter.All:
                    return "全部";
                case DriverFilter.Create:
                    return "支持创建";
                case DriverFilter.CreateCopy:
                    return "支持拷贝";
                case DriverFilter.VirtualIo:
                    return "支持虚拟输入输出";
                case DriverFilter.HasCreationOptions:
                    return "包含创建选项";
                case DriverFilter.HasOpenOptions:
                    return "包含打开选项";
                case DriverFilter.HasLayerCreationOptions:
                    return "包含图层创建选项";
            }

            return string.Empty;
        }
    }
}
