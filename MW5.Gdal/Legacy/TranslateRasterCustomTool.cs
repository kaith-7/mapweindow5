﻿// -------------------------------------------------------------------------------------------
// <copyright file="TranslateRasterCustomTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.IO;
using MW5.Api.Static;
using MW5.Gdal.Legacy.Views;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Tools.Enums;
using MW5.Tools.Model;

namespace MW5.Gdal.Legacy
{
    //[GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(TranslateRasterCustomPresenter))]
    public class TranslateRasterCustomTool : GisTool
    {
        [Input("输入文件", 0)]
        public string InputFilename { get; set; }

        [Input("输出文件", 1)]
        public OutputLayerInfo Output { get; set; }

        [Input("选项", 2)]
        public string Options { get; set; }

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
            get { return "转换栅格"; }
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
            get { return "GDAL 转换: " + Path.GetFileName(Output.Filename); }
        }

        public override bool AfterRun()
        {
            return OutputManager.HandleGdalOutput(Output);
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            bool result = GdalUtils.Instance.TranslateRaster(InputFilename, Output.Filename, Options);

            if (!result)
            {
                Log.Error(@"未处理成功。", null);
                return false;
            }

            if (!File.Exists(Output.Filename))
            {
                Log.Info(@"已处理完成，但未生成结果文件。");
                return false;
            }

            return true;
        }
    }
}