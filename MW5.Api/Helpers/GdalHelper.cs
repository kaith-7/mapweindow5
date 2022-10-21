using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Api.Helpers
{
    public static class GdalHelper
    {
        /// <summary>
        /// Gets the list of supported GDAL raster data types.
        /// </summary>
        public static IList<string> GetRasterDataTypes()
        {
            return new List<string>()
            {
                "Byte",
                "Int16",
                "UInt16",
                "UInt32",
                "Int32",
                "Float32",
                "Float64",
                "CInt16",
                "CInt32",
                "CFloat32",
                "CFloat64"
            };
        }

        public static IList<string> GetRasterResampling()
        {
            return new List<string>
                       {
                           "", 
                           "最邻近", 
                           "双线性", 
                           "三次卷积", 
                           "三次样条",
                           "均值",
                           "最大",
                           "最小",
                           "lanczos", 
                           "mode", 
                           "med", 
                           "q1", 
                           "q3"
                       };
        }
    }
}
