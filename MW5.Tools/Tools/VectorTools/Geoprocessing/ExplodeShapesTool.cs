// -------------------------------------------------------------------------------------------
// <copyright file="ExplodeShapesTool.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2019
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Api.Static;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;

namespace MW5.Tools.Tools.VectorTools.Geoprocessing
{
    [GisTool(GroupKeys.Geoprocessing, parentGroupKey: GroupKeys.VectorTools)]
    public class ExplodeShapesTool: AppendModeGisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput Input { get; set; }

        [Output("输出图层", 0)]
        [OutputLayer("{input}_explode.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }
        
        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "拆分矢量";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description => "将多部件要素拆分为单部件要素。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentity.Default;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var success = false;

            if (Output.MemoryLayer)
            {
                var fs = Input.Datasource.ExplodeShapes(Input.SelectedOnly);

                if (fs != null)
                {
                    Log.Info("初始要素数量: " + Input.Datasource.NumFeatures);
                    Log.Info("拆分后: " + fs.NumFeatures);
                }

                Output.Result = fs;
            }
            else
            {
                success = GisUtils.Instance.ExplodeShapes(Input.Datasource, Input.SelectedOnly, Output.Filename, Output.Overwrite);
            }

            return Output.Result != null || success;
        }
    }
}
