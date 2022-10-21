using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Tools.Enums;
using MW5.Tools.Model;

namespace MW5.Gdal.Tools
{
    public partial class BuildVrtTool
    {
        [Input("瓦片索引", 0, true)]
        public string TileIndex { get; set; }

        [Input("分辨率", 1, true)]
        [ControlHint(ControlHint.Combo)]
        public string Resolution { get; set; }

        [Input("目标分辨率", 2, true)]
        public string TartetResolution { get; set; }

        [Input("目标范围", 3, true)]
        public string TargetExtents { get; set; }

        [Input("数据源无效值", 4, true)]
        public string SrcNoData { get; set; }

        [Input("波段索引", 5, true)]
        public string BandIndex { get; set; }

        [Input("子数据集索引", 6, true)]
        public string SubdatasetIndex { get; set; }

        [Input("输出结果无效值", 7, true)]
        public string VrtNoDataValue { get; set; }

        [Input("覆盖输出文件的投影", 8, true)]
        public string TargetProjection { get; set; }

        [Input("重采样", 9, true)]
        [ControlHint(ControlHint.Combo)]
        public string Resampling { get; set; }

        [Input("添加alpha通道", 10, true)]
        public bool AddAlpha { get; set; }

        [Input("隐藏无效值", 11, true)]
        public bool HideNoData { get; set; }

        [Input("对齐像素以达到目标分辨率", 12, true)]
        public bool AlignPixelsToResolution { get; set; }

        [Input("每个文件的单独堆栈波段", 13, true)]
        public bool Separate { get; set; }

        [Input("允许投影不同", 14, true)]
        public bool AllowProjectionDifference { get; set; }
    }
}
