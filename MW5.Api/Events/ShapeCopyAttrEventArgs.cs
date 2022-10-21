using System;
using AxMapWinGIS;

namespace MW5.Api.Events
{
    public class ShapeCopyAttrEventArgs : EventArgs
    {
        public ShapeCopyAttrEventArgs(int layerHandle)
        {
            LayerHandle = layerHandle;
        }

        public int LayerHandle
        {
            get; private set;
        }
    }
}
