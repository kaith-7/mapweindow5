﻿// -------------------------------------------------------------------------------------------
// <copyright file="SimplifyLinesTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Geoprocessing
{
    [GisTool(GroupKeys.Geoprocessing, parentGroupKey: GroupKeys.VectorTools)]
    public class SimplifyLinesTool: GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Input("容差", 1)]
        public Distance Tolerance { get; set; }

        [Output("输出图层", 0)]
        [OutputLayer("{input}_simplify.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<SimplifyLinesTool>()
                .SetDefault(t => t.Tolerance, 0.1);     // km
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "简化线";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "基于设定的容差，删除过多的顶点来简化折线。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            if (Input.Datasource.GeometryType == GeometryType.Polyline ||
                Input.Datasource.GeometryType == GeometryType.Polygon) return true;

            MessageService.Current.Info("该工具仅适用于线或面数据。");
            return false;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var units = Input.Datasource.GetLengthUnits();
            var tolerance = UnitConversionHelper.Convert(Tolerance.Units, units, Tolerance.Value);

            Log.Info("数据单位的容差: {0} {1}", tolerance, units.EnumToString());

            var fs = Input.Datasource.SimplifyLines(tolerance, Input.SelectedOnly);
            Output.Result = fs;

            return true;
        }
    }
}
