﻿// -------------------------------------------------------------------------------------------
// <copyright file="ToolboxDockPanel.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Concrete;
using MW5.Api.Static;
using MW5.Gdal.Model;
using MW5.Gdal.Views;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Tools.Enums;
using MW5.Tools.Model;
using MW5.Tools.Services;

namespace MW5.Gdal.Tools
{
    [GisTool(GroupKeys.GdalTools, groupName: "GDAL / OGR tools", groupDescription: "GDAL / OGR tools", icon: ToolIcon.Hammer, presenter: typeof(GdalPresenter))]
    public class AddOverviewsTool : GdalTool
    {
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Raster)]
        [Input("输入文件", 0)]
        public string InputFilename { get; set; }

        [Input("波段", 1)]
        public string BandIndex { get; set; }

        [Input("仅读", 2)]
        public bool ReadOnly { get; set; }

        [Input("删除现有概述", 3)]
        public bool Clean { get; set; }

        [Input("重采样", 0, true)]
        [ControlHint(ControlHint.Combo)]
        public string Resampling { get; set; }

        [Output("概述级别", 1)]
        public string Levels { get; set; }

        /// <summary>
        /// Initializes the command line options.
        /// </summary>
        protected override void InitCommandLine(CommandLineMapping mapping)
        {
            mapping.Get<AddOverviewsTool>()
                .SetKey(t => t.Resampling, "-r")
                .SetKey(t => t.BandIndex, "-b")
                .SetKey(t => t.ReadOnly, "-ro")
                .SetKey(t => t.Clean, "-clean");
        }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="configuration"></param>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var resampling = new[]  { "", "最邻近", "均值", "高斯", "三次卷积", "三次样条", "lanczos", "average_mp",
                               "average_magphase", "mode" };

            configuration.Get<AddOverviewsTool>()
                .AddComboList(t => t.Resampling, resampling);
        }

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected override bool DriverFilter(DatasourceDriver driver)
        {
            return driver.IsRaster;
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "添加栅格概述";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "构建或重建栅格数据源的概述图像。";

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName => "Overviews: " + InputFilename;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var options = GetOptions();

            return GdalUtils.Instance.GdalAddOverviews(InputFilename, options, Levels);
        }

        public override bool AfterRun()
        {
            // do nothing
            return true;
        }
    }
}
