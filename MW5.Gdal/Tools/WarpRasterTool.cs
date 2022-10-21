﻿// -------------------------------------------------------------------------------------------
// <copyright file="WarpRasterTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Static;
using MW5.Gdal.Helpers;
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
    [GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(GdalConvertPresenter))]
    public partial class WarpRasterTool : GdalRasterTool
    {
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var dataTypes = GdalHelper.GetRasterDataTypes().ToList();
            dataTypes.Insert(0, "<autodetect>");

            configuration.Get<WarpRasterTool>()
                .AddComboList(t => t.DstResampling, GdalHelper.GetRasterResampling())
                .AddComboList(t => t.WorkingPixelsType, dataTypes);
        }

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected override bool DriverFilter(DatasourceDriver driver)
        {
            return driver.IsRaster && driver.MatchesFilter(Api.Enums.DriverFilter.Create);
        }

        protected override void InitCommandLine(CommandLineMapping mapping)
        {
            _commandLine.Get<WarpRasterTool>()
                .SetKey(t => t.AlignPixelsToResolution, "-tap")
                .SetKey(t => t.CopyColorIntepretation, "-setci")
                .SetKey(t => t.DstAlpha, "-dstalpha")
                .SetKey(t => t.DstNoDataValue, "-dstnodata")
                .SetKey(t => t.DstNoMetadata, "-nomd")
                .SetKey(t => t.DstResampling, "-r")
                .SetKey(t => t.ErrorThreshhold, "-et")
                .SetKey(t => t.GeolocationArrays, "-geoloc")
                .SetKey(t => t.MemoryLimitMb, "-mw")
                .SetKey(t => t.OutputType, "-ot")
                .SetKey(t => t.RefineGcp, "-refine_gcps")
                .SetKey(t => t.RpcCoefficients, "-rpc")
                .SetKey(t => t.SourceNoDataValue, "-srcnodata")
                .SetKey(t => t.SourceOverviewLevel, "-ovr")
                .SetKey(t => t.SourceProjection, "-s_srs")
                .SetKey(t => t.TargetExtents, "-te")
                .SetKey(t => t.TargetExtentsProjection, "-te_srs")
                .SetKey(t => t.TargetProjection, "-t_srs")
                .SetKey(t => t.TargetResolution, "-tr")
                .SetKey(t => t.TargetSize, "-ts")
                .SetKey(t => t.TpsTransformer, "-tps")
                .SetKey(t => t.UseMultithreading, "-multi")
                .SetKey(t => t.WorkingPixelsType, "-wt");
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "影像重投影和几何纠正。"; }
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "影像重投影和几何纠正"; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        public override string TaskName
        {
            get { return "Warp: " + Path.GetFileName(Output.Filename); }
        }

        public override bool SupportDriverCreationOptions
        {
            get { return true; }
        }

        public override string CompileOptions(bool mainOnly = false)
        {
            var s = base.CompileOptions(mainOnly);

            var sb = new StringBuilder(s);

            sb.AppendFormat("-of {0} ", OutputFormat.Name);

            if (Output.Overwrite)
            {
                sb.Append("-overwrite ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            string[] options = GetOptions().Split(new char[] { ' '});

            bool result = GdalUtils.Instance.WarpRaster(InputFilename, Output.Filename, options);

            if (!result)
            {
                string s = string.Format("栅格数据重投影失败 {0}. 选项: {1}", InputFilename, options);
                Log.Error(s, null);
                return false;
            }

            if (!File.Exists(Output.Filename))
            {
                Log.Info(@"已成功完成，但未创建结果文件。");
                return false;
            }

            Log.Info("栅格数据已重投影: " + Output.Filename);

            return true;
        }
    }
}