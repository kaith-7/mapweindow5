using MW5.Shared.Log;
using MW5.Shared.CheckResult;

namespace MW5.Shared
{
    public class Logger
    {
        public static ILoggingService Current { get; internal set; }
    }

    public class AttributeChecker
    {
        public static ICheckAttrService Current { get; internal set; }
    }
}
