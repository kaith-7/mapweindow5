// -------------------------------------------------------------------------------------------
// <copyright file="CreateGridProxyTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using System.IO;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Static;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using MW5.Tools.Services;

namespace MW5.Tools.Tools.Raster
{
    [CustomLayout]
    [GisTool(GroupKeys.Raster)]
    public class CreateGridProxyTool: GisTool
    {
        [Input("输入栅格数据", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Raster)]
        public string Input { get; set; }               // probably grid filename will be more appropriate

        [Input("缓存格式", 1)]
        [ControlHint(ControlHint.Combo)]
        public GridProxyFormat ProxyFormat { get; set; }

        [Input("颜色方案", 2)]
        [ControlHint(ControlHint.Combo)]
        public PredefinedColors ColorScheme { get; set; }

        [Input("使用已有的颜色方案", 3)]
        public bool UseBuiltInColorScheme { get; set; }

        [Output("添加到当前地图", 0)]
        public bool AddToMap { get; set; }

        [Output("输出", -1)]
        public OutputLayerInfo Output { get; set; }
        

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            Output = new OutputLayerInfo() { SkipValidation = true };

            var formats = EnumHelper.GetValues<GridProxyFormat>();
            var colors = EnumHelper.GetValues<PredefinedColors>();

            configuration.Get<CreateGridProxyTool>()
                .AddComboList(t => t.ProxyFormat, formats)
                .AddComboList(t => t.ColorScheme, colors);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "构建栅格显示缓存";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "创建一个RGB图像文件，用于快速可视化栅格。";

        public override string TaskName => "Proxy: " + Path.GetFileName(Input);

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            using (var grid = new GridSource(Input))
            {
                RasterColorScheme rcs;

                if (UseBuiltInColorScheme)
                {
                    rcs = grid.RetrieveColorScheme(GridSchemeRetrieval.Auto);
                    if (rcs == null)
                    {
                        Log.Error("找不到预设的配色方案。", null);
                        return false;
                    }
                }
                else
                {
                    rcs = grid.GenerateColorScheme(GridSchemeGeneration.Gradient, ColorScheme);
                }

                MapConfig.GridProxyFormat = ProxyFormat;

                Output.Result = grid.CreateImageProxy(rcs);
            }

            return Output.Result != null;
        }

        /// <summary>
        /// Can be used to save results of the processing or display messages.
        /// Default implementation automatically handles values assigned to OutputLayerInfo.Result.
        /// </summary>
        public override bool AfterRun()
        {
            if (AddToMap)
            {
                var img = Output.Result as IImageSource;
                if (OutputManager.AddToMap(img))
                {
                    if (img == null) return false;

                    Output.Filename = img.Filename;
                    Output.DatasourcePointer = new DatasourcePointer(img.Filename);

                    return true;
                }
            }

            Output.Result.Dispose();

            return true;
        }
    }
}
