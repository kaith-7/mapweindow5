using System;
using MW5.Api.Enums;
using MW5.Shared;

namespace MW5.Plugins.Identifier.Enums
{
    internal class IdentifierModeConverter : IEnumConverter<IdentifierMode>
    {
        public string GetString(IdentifierMode value)
        {
            switch (value)
            {
                case IdentifierMode.CurrentLayer:
                    return "当前图层";
                case IdentifierMode.AllLayers:
                    return "所有图层";
                case IdentifierMode.AllLayersStopOnFirst:
                    return "最顶部的图层";
            }
            throw new ApplicationException("Invalid IdentifierMode mode");
        }
    }
}
