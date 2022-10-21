using System;
using System.IO;
using System.ComponentModel;
using MW5.Api.Interfaces;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;


namespace MW5.Tools.Tools.TopologyTools
{
    [GisTool(GroupKeys.TopologyTools, Enums.ToolIcon.ToolDefault)]
    public class CheckGap : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput InputName { get; set; }

        [Output("保存检查结果到")]
        [OutputLayer(@"{input}_checkgap.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }
        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "间隙检查"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "相邻的两个面中间若有间隙，将最宽处宽度小于容差的间隙提取出来，生成新的图层。"; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Gets a value indicating whether the tool supports batch execution.
        /// </summary>
        public override bool SupportsBatchExecution => true;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        /// 
        public override bool Run(ITaskHandle task)
        {
            //检查输入要素是否是polygon, 容差值是否合适
            if (InputName.Datasource.IsPolygon == false)
            {
                MessageService.Current.Info("请输入矢量面数据!!!");
                return false;
            }

            //合并要素 // NOTE: What is diffrence between Dissolve and Union
            var dissolveresult = InputName.Datasource.Dissolve(-1, false);
            System.Diagnostics.Debug.Assert(dissolveresult != null);

            ////创建要素最小外接多边形
            var lowhull = new FeatureSet(GeometryType.Polygon);
            lowhull.AssignProjection(InputName.Datasource.Projection);
            lowhull.StartEditingShapes();
            foreach (var feat in dissolveresult.Features)
            {
                var geom = feat.Geometry;
                foreach (var part in geom.Parts)
                {
                    if (!part.IsValid)
                    {
                        lowhull.Features.EditAdd(part);
                    }
                }
            }
            lowhull.StopEditingShapes();

            if (lowhull.NumFeatures > 0)
                Output.Result = lowhull;

            return Output.Result != null;
        }

        private IFeatureSet GetWgs84FeatureSet(IFeatureSet fs)
        {
            // TODO: to optimize memory usage would be better to reproject shapes one at a time
            var sr = new SpatialReference();
            sr.SetWgs84();

            if (!fs.Projection.IsSameExt(sr, fs.Envelope))
            {
                int count;
                return fs.Reproject(sr, null, out count);
            }
            return fs;
        }
    }
}
