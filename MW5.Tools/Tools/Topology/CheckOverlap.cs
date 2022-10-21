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
using System.Threading.Tasks;

namespace MW5.Tools.Tools.TopologyTools
{
    [GisTool(GroupKeys.TopologyTools, Enums.ToolIcon.ToolDefault)]
    public class CheckOverlap : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput InputName { get; set; }

        [Output("保存检查结果到")]
        [OutputLayer(@"{input}_checkoverlap.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "重叠检查"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "相邻的两个面中间若有重叠部分，将最宽处宽度小于容差的重叠区域提取出来，生成新的图层。"; }
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
            //检查输入要素是否是polygon
            if (InputName.Datasource.IsPolygon == false)
            {
                MessageService.Current.Info("请输入矢量面数据!!!");
                return false;
            }

            //合并要素
            InputName.Datasource.StartEditingTable();
            InputName.Datasource.StartEditingShapes();
            InputName.Datasource.Fields.Add("Dissolvefield", AttributeType.String, 0, 1);
            var dissolveresult = InputName.Datasource.Dissolve(InputName.Datasource.Fields.IndexByName("Dissolvefield"), false);
            InputName.Datasource.Fields.Remove(InputName.Datasource.Fields.IndexByName("Dissolvefield"));
            InputName.Datasource.Save();
            InputName.Datasource.StopEditingTable();
            InputName.Datasource.StopEditingShapes();

            //原始图层的所有要素,循环对合并后的要素做交集取反

            var outputResult = new FeatureSet(GeometryType.Polygon);
            outputResult.Projection.CopyFrom(InputName.Datasource.Projection);

            for (int fsi = 0; fsi < InputName.Datasource.Features.Count; fsi++)
            {
                var afs = new FeatureSet(GeometryType.Polygon);
                afs.Projection.CopyFrom(InputName.Datasource.Projection);
                afs.Features.EditAdd(InputName.Datasource.Features[fsi].Geometry);

                var InterFeature = copyfaetures(InputName.Datasource); //复制输入矢量数据
                InterFeature.Features.EditDelete(fsi);

                IFeatureSet aResulrFeature = afs.Intersection(false, InterFeature, false, GeometryType.Polygon);
                if (aResulrFeature != null)
                {
                    for (int rfsi = 0; rfsi < aResulrFeature.Features.Count; rfsi++)
                    {
                        outputResult.Features.EditAdd(aResulrFeature.Features[rfsi].Geometry);
                    }
                }
                else
                {
                    continue;
                }
                
            }
            // union合并相交提取的结果
            IFeatureSet unionfs1 = new FeatureSet(GeometryType.Polygon);
            unionfs1.Projection.CopyFrom(InputName.Datasource.Projection);
            unionfs1.Features.EditAdd(outputResult.Features[0].Geometry);

            for (int uni = 0; uni < outputResult.Features.Count - 1; uni++)
            {
                IFeatureSet unionfs2 = new FeatureSet(GeometryType.Polygon);
                unionfs2.Projection.CopyFrom(InputName.Datasource.Projection);
                unionfs2.Features.EditAdd(outputResult.Features[uni+1].Geometry);

                IFeatureSet unionres = unionfs1.Union(false, unionfs2, false);

                unionfs1 = new FeatureSet(GeometryType.Polygon);
                unionfs1.Projection.CopyFrom(InputName.Datasource.Projection);
                unionfs1 = unionres;
            }

            Output.Result = unionfs1;
            return true;
        }

        private IFeatureSet copyfaetures(IFeatureSet fs)
        {
            var copytoResult = new FeatureSet(GeometryType.Polygon);
            copytoResult.Projection.CopyFrom(fs.Projection);

            for (int copyi = 0; copyi < fs.Features.Count; copyi++)
            {
                copytoResult.Features.EditAdd(fs.Features[copyi].Geometry);
            }

            return copytoResult;
        }
    }
}
