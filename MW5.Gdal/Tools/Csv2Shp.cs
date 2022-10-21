using System;
using System.Collections.Generic;
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
    //[GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(GdalConvertPresenter))]
    public partial class Csv2Shp : GdalTool  
    {
        [Input("输入文件", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Excel   )]
        public string InputFilename { get; set; }
        
        [Input("X对应列：",1)]
        [ControlHint(ControlHint.Combo)]
        public DatasourceDriver XField { get; set; }

        [Input("Y对应列：",2, canEmpty: true)]
        [ControlHint(ControlHint.Combo )]
        public DatasourceDriver YField { get; set; }

        
        [Output("输出文件", 1)]
        [OutputLayer("{input}_conv.shp", LayerType.Shapefile, false)]
        public override   OutputLayerInfo Output { get; set; }

       
        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, MW5.Tools.Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var supported = new System.Collections.Generic.List<string>() { "CSV" }; //, "DXF", "GPX", "KML", "SQLITE", "SHP", "DWG", "GDB", "MDB" };
            var drivers0 = GetDrivers().ToList();
            var drivers = drivers0.Where(d => supported.Contains(d.Extension.ToUpper()) || supported.Intersect(d.Extensions.ToUpper().Split(' ')).Count() > 0).ToList();

            var sf = drivers.FirstOrDefault(f => f.Name.ToLower() == GdalFormats.Shapefile );

            //configuration.Get<Csv2Shp>()
            //     .AddComboList(t => t.XField, drivers);

            

            //var X =this. XField.Name;
        }

        /// <summary>
        /// Initializes the command line options.
        /// </summary>
        protected override void InitCommandLine(CommandLineMapping mapping)
        {
            // TODO: implement
            //mapping.Get<Ogr2OgrTool>()
            //    .SetKey(t => t.OutputFormat, "-f");
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
            get { return "Csv转Shp"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "将csv文件转换shp文件。"; }
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
            
            if(!string.IsNullOrEmpty(InputFilename))
            {
                DataTable inputData = GdalUtils.Instance.GetTableFromFile(InputFilename);

            }

            return s;

            //var sb = new StringBuilder();

            //sb.AppendFormat("-f \"{0}\" ", OutputFormat.Name);
            //sb.Append(s);
            //sb.Append("-progress ");

            //if (Output.Overwrite)
            //{
            //    sb.Append("-overwrite ");
            //}

            //if (OutputFormat.IsVector && OutputFormat.Name == "ESRI Shapefile")
            //{
            //    sb.Append("-lco ENCODING=UTF-8");
            //}
            //else if (OutputFormat.IsVector && OutputFormat.Name == "CSV")
            //{
            //    sb.Append("-lco WRITE_BOM=YES");
            //}

            //return sb.ToString();
        }

        public override bool Validate()
        {
            if (!base.Validate())
                return false;

            var exts = new string[] { ".CSV" };
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
                    MessageService.Current.Info("文件已存在，请修改文件名或删除已有文件。");
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
           // string options = GetOptions();
            bool result = false;
            
            var ext = System.IO.Path.GetExtension(Output.Filename).TrimStart(new char[] { '.' }).ToUpper();
            
            switch (ext)
            {
                case "SHP":
                    if (InputFilename.ToLower().EndsWith(".csv"))
                    {
                        DataTable inputData = GdalUtils.Instance.GetTableFromFile(InputFilename);
                        //CsvToShp choose = new CsvToShp(inputData);
                        //choose.Activate();
                        //if (choose.ShowDialog() == DialogResult.OK)
                        //{
                        //    result = GdalUtils.Instance.ConvertPoint(inputData, Output.Filename, choose.XColName, choose.YColName);
                        //}
                        //else
                        //    result = false;

                    }
                    else
                    {
                        //result = GdalUtils.Instance.Ogr2Ogr(InputFilename, Output.Filename, options);
                    }
                    break;
                //case "SQLITE":
                //    var optionArray = options.Split(new string[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);
                //    result = GdalUtils.Instance.VectorTranslate(InputFilename, Output.Filename, optionArray);
                //    break;
                default:
                    //result = GdalUtils.Instance.Ogr2Ogr(InputFilename, Output.Filename, options);
                    break;
            }
            return result;
        }

        /// <summary>
        /// Saves the output.
        /// </summary>
        public override bool AfterRun()
        {
            if (Output.Result == null)
                return false;

            if (!OutputManager.Save(Output.Result, Output))
            {
                Log.Error("输出文件保存失败: {0}", null, Output.Filename);
            }

            // false since there are invalid shapes, i.e. validation failed
            return true;
        }
    }
}
