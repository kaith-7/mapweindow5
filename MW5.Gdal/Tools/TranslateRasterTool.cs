// -------------------------------------------------------------------------------------------
// <copyright file="TranslateRasterTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MW5.Api.Concrete;
using MW5.Api.Static;
using MW5.Gdal.Model;
using MW5.Gdal.Views;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Tools.Enums;
using MW5.Tools.Model;

namespace MW5.Gdal.Tools
{
    [GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(GdalConvertPresenter))]
    public class TranslateRasterTool : GdalRasterTool
    {
        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "转换栅格数据格式。"; }
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "栅格格式转换"; }
        }

        [Input("NoData值", 3, true)]
        public string NoData { get; set; }

        [Input("导出的类型", 1, true)]
        [ControlHint(ControlHint.Combo)]
        public override string OutputType { get; set; }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        [Input("空间参考", 8, true)]
        public bool SpatialReference { get; set; }

        [Input("统计", 5, true)]
        public bool Stats { get; set; }

        [Input("紧凑", 6, true)]
        public bool Strict { get; set; }

        [Input("子数据集", 4, true)]
        public bool SubDatasets { get; set; }

        /// <summary>
        /// Gets a value indicating whether current tool can specify driver creation options.
        /// </summary>
        public override bool SupportDriverCreationOptions
        {
            get { return true; }
        }

        public override string TaskName
        {
            get { return "转换: " + Path.GetFileName(Output.Filename); }
        }

        [Input("无比例", 7, true)]
        public bool Unscale { get; set; }

        /// <summary>
        /// Gets command line options.
        /// </summary>
        public override string CompileOptions(bool mainOnly = false)
        {
            var s = base.CompileOptions(mainOnly);

            var sb = new StringBuilder(s);

            sb.AppendFormat("-of {0} ", OutputFormat.Name);

            switch (OutputFormat.Name)
            {
                case "USGSDEM":
                    sb.Append(" -b 1 ");
                    break;
                case "BMP":
                    //OutputType = "Byte";
                    //this.DriverOptions = "-co WORLDFILE=True";
                    sb.Append(" -ot Byte ");
                    goto case "JPEG";
                case "PNG":
                case "JPEG":
                    sb.Append("-co WORLDFILE=True");
                    break;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            string options = GetOptions();

            bool result = GdalUtils.Instance.TranslateRaster(InputFilename, Output.Filename, options);

            if (!result)
            {
                Log.Error(@"未成功完成。", null);
                return false;
            }

            if (!File.Exists(Output.Filename))
            {
                Log.Info(@"已成功完成，但未创建输出结果。");
                return false;
            }

            return true;
        }

        private static IList<string> supported = new List<string> { "TIF", "BMP", "IMG", "JPEG", "JP2", "PDF", "PNG", "DEM"}; // , "WMS/WTMS", "DAT" 

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected override bool DriverFilter(DatasourceDriver driver)
        {
            return driver.IsRaster
                && (driver.MatchesFilter(Api.Enums.DriverFilter.Create) || driver.MatchesFilter(Api.Enums.DriverFilter.CreateCopy))
                && (supported.Contains(driver.Extension.ToUpper()) || supported.Intersect(driver.Extensions.ToUpper().Split(' ')).Count() > 0)
                ;
        }

        protected override void InitCommandLine(CommandLineMapping mapping)
        {
            _commandLine.Get<TranslateRasterTool>()
                .SetKey(t => t.OutputType, "-ot")
                .SetKey(t => t.NoData, "-a_nodata")
                .SetKey(t => t.SubDatasets, "-sds")
                .SetKey(t => t.Stats, "-stats")
                .SetKey(t => t.Strict, "-strict")
                .SetKey(t => t.SpatialReference, "-a-srs")
                .SetKey(t => t.Unscale, "-unscale");
        }
    }
}