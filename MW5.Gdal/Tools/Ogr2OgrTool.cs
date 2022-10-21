using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Static;
using MW5.Gdal.Model;
using MW5.Gdal.Views;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Tools.Enums;
using MW5.Tools.Model;

namespace MW5.Gdal.Tools
{
    [GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(GdalConvertPresenter))]
    public partial class Ogr2OgrTool : GdalTool
    {
        [Input("输入文件", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Vector)]
        public string InputFilename { get; set; }

        [Output("输出格式")]
        [ControlHint(ControlHint.Combo)]
        public DatasourceDriver OutputFormat { get; set; }

        [Output("输出文件", 1)]
        [OutputLayer("{input}_conv.shp", LayerType.Shapefile, false)]
        public override OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Initializes the command line options.
        /// </summary>
        protected override void InitCommandLine(CommandLineMapping mapping)
        {
            // TODO: implement
            mapping.Get<Ogr2OgrTool>()
                .SetKey(t => t.OutputFormat, "-f");
        }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, MW5.Tools.Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var supported = new System.Collections.Generic.List<string>() { "CSV", "DXF", "GPX", "KML", "SQLITE", "SHP" }; //, "DWG", "GDB", "MDB" };
            var drivers0 = GetDrivers().ToList();
            var drivers = drivers0.Where(d => supported.Contains(d.Extension.ToUpper()) || supported.Intersect(d.Extensions.ToUpper().Split(' ')).Count() > 0).ToList();

            var sf = drivers.FirstOrDefault(f => f.Name.ToLower() == GdalFormats.Shapefile);

            configuration.Get<Ogr2OgrTool>()
                 .AddComboList(t => t.OutputFormat, drivers)
                 .SetDefault(t => t.OutputFormat, sf);
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "矢量格式转换"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "将简单要素数据转换为其它格式的矢量数据。"; }
        }

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected override bool DriverFilter(DatasourceDriver driver)
        {
            return driver.IsVector && driver.MatchesFilter(Api.Enums.DriverFilter.Create);
        }

        /// <summary>
        /// Gets command line options.
        /// </summary>
        public override string CompileOptions(bool mainOnly = false)
        {
            string s = base.CompileOptions(mainOnly);

            var sb = new StringBuilder();

            sb.AppendFormat("-f \"{0}\" ", OutputFormat.Name);
            sb.Append(s);
            sb.Append("-progress ");

            if (Output.Overwrite)
            {
                sb.Append("-overwrite ");
            }

            if (OutputFormat.IsVector && OutputFormat.Name == "ESRI Shapefile")
            {
                sb.Append("-lco ENCODING=UTF-8");
            }
            else if (OutputFormat.IsVector && OutputFormat.Name == "CSV")
            {
                sb.Append("-lco WRITE_BOM=YES");
            }

            return sb.ToString();
        }

        public override bool Validate()
        {
            if (!base.Validate())
                return false;

            var exts = new string[] { ".DXF", ".CSV" };
            var outputExt = System.IO.Path.GetExtension(Output.Filename);
            if (exts.Contains(outputExt.ToUpper()))
            {
                try
                {
                    System.IO.File.Delete(Output.Filename);
                }
                catch (System.Exception ex)
                {
                }
                finally
                {
                }
                if (System.IO.File.Exists(Output.Filename))
                {
                    MessageService.Current.Info("DXF文件已存在，请修改文件名或删除已有文件。");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            string options = GetOptions();
            bool result = false;
            
            var ext = System.IO.Path.GetExtension(Output.Filename).TrimStart(new char[] { '.' }).ToUpper();
            
            switch (ext)
            {
                case "SHP":
                        result = GdalUtils.Instance.Ogr2Ogr(InputFilename, Output.Filename, options);
                   
                    break;
                //case "SQLITE":
                //    var optionArray = options.Split(new string[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);
                //    result = GdalUtils.Instance.VectorTranslate(InputFilename, Output.Filename, optionArray);
                //    break;
                default:
                    result = GdalUtils.Instance.Ogr2Ogr(InputFilename, Output.Filename, options);
                    break;
            }
            return result;
        }
    }
}
