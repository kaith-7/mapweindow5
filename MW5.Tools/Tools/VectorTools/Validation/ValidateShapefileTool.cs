﻿// -------------------------------------------------------------------------------------------
// <copyright file="ValidateShapefileTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Shared;
using MW5.Tools.Helpers;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Validation
{
    [CustomLayout]
    [GisTool(GroupKeys.Validation, parentGroupKey: GroupKeys.VectorTools)]
    public class ValidateShapefileTool: GisTool
    {
        private int _errorCount;

        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Output("输出图层")]
        [OutputLayer("{input}_errors.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        [Output("创建带有错误的矢量文件", 1)]
        public bool CreateOutput { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<ValidateShapefileTool>()
                .SetDefault(t => t.CreateOutput, true);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "检验矢量";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description =>
            "验证矢量图层。 " +
            "将图标添加到地图上，以标记错误的位置。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        public override bool SupportsCancel => true;

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName => "Validating [" + Input.Name + "]: " + (_errorCount == 0 ? "no errors" : _errorCount + " errors");

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var errors = GetErrors(Input.Datasource, task).ToList();

            _errorCount = errors.Count;

            if (CreateOutput && errors.Any())
            {
                CreateOutputDatasource(errors);

                Log.Info("------------------------");
                Log.Info("无效的要素数量: " + errors.Count);
            }

            if (!errors.Any())
            {
                Log.Info("未发现无效的要素。");
            }

            return true;            
        }

        /// <summary>
        /// Validates shapes and returns list of errors.
        /// </summary>
        private IEnumerable<ErrorInfo> GetErrors(IFeatureSet fs, ITaskHandle task)
        {
            var lastPercent = 0;

            for (var i = 0; i < fs.NumFeatures; i++)
            {
                task.CheckPauseAndCancel();
                task.Progress.TryUpdate("计算中...", i, fs.NumFeatures, ref lastPercent);

                var gm = fs.Features[i].Geometry;
                if (gm.IsValid) continue;

                var info = ValidationHelper.GetErrorInfo(fs, i, gm.IsValidReason);

                Log.Info(info.Message);

                yield return info;
            }

            task.Progress.Clear();
        }

        /// <summary>
        /// Creates the output datasource.
        /// </summary>
        private void CreateOutputDatasource(IEnumerable<ErrorInfo> errors)
        {
            var fs = ValidationHelper.CreateErrorFeatureSet(Input.Datasource);

            foreach (var err in errors.Where(e => e.Location != null))
            {
                var gm = new Geometry(GeometryType.Point);
                gm.Points.Add(err.Location);

                var index = fs.Features.EditAdd(gm);
                if (index == -1) continue;

                // MWShapeId has 0 index
                fs.Table.EditCellValue(1, index, (int)err.ErrorType);
                fs.Table.EditCellValue(2, index, err.Message);
            }

            fs.Categories.ApplyExpressions();
            fs.RemoveUnusedCategories();

            Output.Result = fs;
        }

        /// <summary>
        /// Saves the output.
        /// </summary>
        public override bool AfterRun()
        {
            if (Output.Result == null) return true;

            if (!OutputManager.Save(Output.Result, Output))
            {
                Log.Error("输出文件保存失败: {0}", null, Output.Filename);
            }    

            // false since there are invalid shapes, i.e. validation failed
            return false;
        }
    }
}
