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
    public class AreaMergeTool : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Input("分组字段", 1)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndex { get; set; }

        [Output("输出图层")]
        [OutputLayer("{input}_融合.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, MW5.Tools.Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<AreaMergeTool>()
                .AddField(t => t.Input, t => t.FieldIndex);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "面融合";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description =>
            "将面图层根据指定的字段进行融合。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        public override bool SupportsCancel => true;

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName => "面融合 [" + Input.Name + "]";

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            if (!Input.Datasource.IsPolygon)
            {
                MessageService.Current.Info("请输入面数据!!!");
                return false;
            }

            var field = Input.Datasource.Fields[FieldIndex];
            if (field != null)
            {
                var fs = Input.Datasource;
                var values = new HashSet<object>();
                foreach (var ft in fs.Features)
                {
                    values.Add(ft.GetValue(FieldIndex));
                }

                var nums = values.Count;

                var featureSet = new FeatureSet(GeometryType.Polygon, Input.Datasource.ZValueType, false);
                featureSet.AssignProjection(Input.Datasource.Projection);

                foreach (var fld in Input.Datasource.Fields)
                {
                    featureSet.Fields.Add(fld);
                }

                int step = 0;
                foreach (var value in values)
                {
                    if (task.IsCancelled)
                        return false;

                    this.Log.Info(value.ToString());
                    step++;
                    var log = $"运行中...{step}/{values.Count}";
                    GlobalListeners.ReportProgress("", step * 100 / values.Count, log);
                    IGeometry result = null;
                    int idxNew = -1;
                    var fts = fs.Features.Where(ft => ft.GetValue(FieldIndex).Equals(value));
                    foreach (var ft in fts)
                    {
                        if (task.IsCancelled)
                            return false;

                        if (result == null)
                        {
                            result = ft.Geometry.Clone();
                            idxNew = featureSet.Features.EditAdd(result);
                            // Copy fileds value
                            for (int i = 0; i < featureSet.Fields.Count; i++)
                            {
                                featureSet.Features[idxNew].SetValue(i, ft.GetValue(i));
                            }
                        }
                        else
                        {
                            result = result.Clip(ft.Geometry, ClipOperation.Union); // TODO: Try to use UnionCascaded for optimization
                        }
                    }
                    if (idxNew >= 0)
                        featureSet.Features.EditUpdate(idxNew, result);

                }
                Output.Result = featureSet;
            }

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
