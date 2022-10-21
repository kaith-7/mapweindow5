// -------------------------------------------------------------------------------------------
// <copyright file="ValidateShapefileTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Tools.Enums;
using MW5.Tools.Helpers;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using System.Collections.Generic;
using System.Linq;

namespace MW5.Plugins.ShapeEditor.Tools.VectorTools.DataProcess
{
    [CustomLayout]
    [GisTool(GroupKeys.DataProcess, parentGroupKey: GroupKeys.VectorTools)]
    public class LineToPolygonTool : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Output("输出图层")]
        [OutputLayer("{input}_面.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, MW5.Tools.Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<LineToPolygonTool>();
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "线构面";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description =>
            "面图层转为线图层。 ";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        public override bool SupportsCancel => true;

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName => $"转换 {Input.Name} 图层为线图层.";

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            if (!Input.Datasource.IsPolyline)
            {
                MessageService.Current.Info("请输入线数据!!!");
                return false;
            }

            var featureSet = new FeatureSet(GeometryType.Polygon, Input.Datasource.ZValueType, false);

            var fsInput = Input.Datasource;
            featureSet.AssignProjection(Input.Datasource.Projection);

            foreach (var fld in Input.Datasource.Fields)
            {
                featureSet.Fields.Add(fld);
            }

            string log;
            int step = 0;
            IGeometry result = new Geometry(GeometryType.Polygon, Input.Datasource.ZValueType);
            int count = Input.SelectedOnly ? fsInput.NumSelected : fsInput.Features.Count;
            foreach (var feat in fsInput.Features)
            {
                if (task.IsCancelled)
                    return false;

                if (!Input.SelectedOnly || feat.Selected)
                {
                    this.Log.Info(feat.Index.ToString());
                    log = $"数据处理...{step}/{count}";
                    GlobalListeners.ReportProgress("", (step++ * 50) / count, log);

                    foreach (var part in feat.Geometry.Parts)
                    {
                        result.Clip(part, ClipOperation.AddColl); // TODO:这个还是用其它方法传递，不要加枚举值
                    }
                }
            }

            log = $"生成多边形...{step}/{count}";
            GlobalListeners.ReportProgress(log, (step * 50) / count, log);
            var results = result.GenPolygonByLines();
            var geoms = new List<IGeometry>();
            foreach (var geom in results)
            {
                geoms.Add(geom);
            }
            count = geoms.Count;
            step = count / 2;
            foreach (var geom in geoms)
            {
                if (task.IsCancelled)
                    return false;

                if (step < count) step++;
                log = $"生成多边形...{step}/{count}";
                GlobalListeners.ReportProgress(log, (step * 100) / count, log);
                featureSet.Features.EditAdd(geom);
            }

            Output.Result = featureSet;

            return true;
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
