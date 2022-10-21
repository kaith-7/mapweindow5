﻿// -------------------------------------------------------------------------------------------
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
    public class PolyToLineTool : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Output("输出图层")]
        [OutputLayer("{input}_线.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, MW5.Tools.Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<PolyToLineTool>();
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "面转线";

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
            if (!Input.Datasource.IsPolygon)
            {
                MessageService.Current.Info("请输入面数据!!!");
                return false;
            }

            var featureSet = new FeatureSet(GeometryType.Polyline, Input.Datasource.ZValueType, false);

            var fsInput = Input.Datasource;
            featureSet.AssignProjection(Input.Datasource.Projection);

            foreach (var fld in Input.Datasource.Fields)
            {
                featureSet.Fields.Add(fld);
            }

            int step = 0;
            foreach (var feat in fsInput.Features)
            {
                if (task.IsCancelled)
                    return false;

                this.Log.Info(feat.Index.ToString());
                step++;
                var log = $"运行中...{step}/{fsInput.Features.Count}";
                GlobalListeners.ReportProgress("", step * 100 / fsInput.Features.Count, log);
                IGeometry result = null;
                int idxNew = -1;
                result = new Geometry(GeometryType.Polyline, Input.Datasource.ZValueType);
                if (feat.Geometry.Parts.Count == 1)
                {
                    foreach (var pt in feat.Geometry.Points)
                    {
                        result.Points.Add(pt);
                    }
                }
                else
                {
                    int ipt = 0;
                    foreach (var part in feat.Geometry.Parts)
                    {
                        foreach (var pt in part.Points)
                        {
                            result.Points.Add(pt);
                        }

                        if (ipt > 0) 
                            result.Parts.AddPart(ipt);
                        ipt = part.Points.Count;
                    }
                }
                idxNew = featureSet.Features.EditAdd(result);
                for (int i = 0; idxNew > 0 && i < featureSet.Fields.Count; i++)
                {
                    featureSet.Features[idxNew].SetValue(i, feat.GetValue(i));
                }
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
