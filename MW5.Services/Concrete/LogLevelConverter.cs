using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Shared;

namespace MW5.Services.Concrete
{
    public class LogLevelConverter : IEnumConverter<LogLevel>
    {
        public string GetString(LogLevel value)
        {
            switch (value)
            {
                case LogLevel.Info:
                    return "信息";
                case LogLevel.Debug:
                    return "调试";
                case LogLevel.Warn:
                    return "警告";
                case LogLevel.Error:
                    return "错误";
                case LogLevel.Fatal:
                    return "异常";
                case LogLevel.All:
                    return "全部";
            }

            throw new IndexOutOfRangeException("Invalid enum value");
        }
    }
}
