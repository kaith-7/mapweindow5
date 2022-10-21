// -------------------------------------------------------------------------------------------
// <copyright file="WarpRasterToolParameters.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Tools.Enums;
using MW5.Tools.Model;

namespace MW5.Gdal.Tools
{
    public partial class WarpRasterTool
    {
        private const string GroupSize = "范围";
        private const string GroupOutput = "输出";
        private const string GroupSource = "源数据";
        private const string GroupAdvanced = "高级";

        [Input("目标投影（输入投影EPSG代号，例如： EPSG:3857）", 0, GroupSize)]
        public string TargetProjection { get; set; }

        [Input("目标范围", 1, GroupSize)]
        public string TargetExtents { get; set; }

        [Input("目标范围的投影", 2, GroupSize)]
        public string TargetExtentsProjection { get; set; }

        [Input("目标分辨率", 3, GroupSize)]
        public string TargetResolution { get; set; }

        [Input("目标尺寸（以像素为单位）", 4, GroupSize)]
        public string TargetSize { get; set; }

        [Input("使像素一致，以达到目标分辨率", 5, GroupSize)]
        public bool AlignPixelsToResolution { get; set; }


        [Input("输出类型", 0, GroupOutput)]
        [ControlHint(ControlHint.Combo)]
        public override string OutputType { get; set; }

        [Input("重采样方法", 1, GroupOutput)]
        [ControlHint(ControlHint.Combo)]
        public string DstResampling { get; set; }

        [Input("目标NoData值", 2, GroupOutput)]
        public string DstNoDataValue { get; set; }

        [Input("给NoData添加透明度", 3, GroupOutput)]
        public bool DstAlpha { get; set; }

        [Input("不复制元数据", 4, GroupOutput)]
        public bool DstNoMetadata { get; set; }

        [Input("复制颜色说明", 5, GroupOutput)]
        public bool CopyColorIntepretation { get; set; }


        [Input("源数据投影", 0, GroupSource)]
        public string SourceProjection { get; set; }

        [Input("源数据NoData值", 1, GroupSource)]
        public string SourceNoDataValue { get; set; }

        [Input("源数据缩放级别", 2, GroupSource)]
        public string SourceOverviewLevel { get; set; }


        [Input("处理耗费最大内存(MB)", 0, GroupAdvanced)]
        public string MemoryLimitMb { get; set; }

        [Input("工作像素类型", 1, GroupAdvanced)]
        [ControlHint(ControlHint.Combo)]
        public string WorkingPixelsType { get; set; }

        [Input("仿射变换", 2, GroupAdvanced)]
        public bool TpsTransformer { get; set; }

        [Input("有理多项式系数", 3, GroupAdvanced)]
        public bool RpcCoefficients { get; set; }

        [Input("地理位置矩阵", 4, GroupAdvanced)]
        public bool GeolocationArrays { get; set; }

        [Input("误差阈值", 5, GroupAdvanced)]
        public bool ErrorThreshhold { get; set; }

        [Input("完善控制点", 6, GroupAdvanced)]
        public bool RefineGcp { get; set; }

        [Input("使用多线程", 7, GroupAdvanced)]
        public bool UseMultithreading { get; set; }
    }
}