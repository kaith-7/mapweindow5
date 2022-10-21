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
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using System;

namespace MW5.Tools.Tools.TopologyTools
{
    [GisTool(GroupKeys.TopologyTools, Enums.ToolIcon.ToolDefault)]
    public class RepairGap : GisTool
    {
        [Input("输入图层", 0)]
        public IVectorInput InputName { get; set; }

        [Input("检查结果图层", 1)]
        public IVectorInput InputtopoName { get; set; }

        [Input("修复规则", 2)]
        [ControlHint(ControlHint.Combo)]
        public GapOperation InputOperation { get; set; }

        [Output("保存修复结果到")]
        [OutputLayer(@"{input}_repairgap.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }
        
        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var operations = EnumHelper.GetValues<GapOperation>();

            configuration.Get<RepairGap>()
                .AddComboList(t => t.InputOperation, operations)
                .SetDefault(t => t.InputOperation, GapOperation.间隙处创建新要素);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "间隙修复"; }
        }

        /// <summary>
        /// Operations of the rule.
        /// </summary>
        public enum GapOperation
        {
            间隙处创建新要素 = 0,
            间隙融合到面积大的相邻小班中 = 1,
            间隙融合到面积小的相邻小班中 = 2,
            间隙融合到共有最长公共边的相邻小班中 = 3
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "将间隙检查的结果，按选定的规则合并到原始矢量中。"; }
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
        public override bool Run(ITaskHandle task)
        {
            //检查输入要素是否是polygon
            if (InputName.Datasource.IsPolygon == false & InputtopoName.Datasource.IsPolygon == false)
            {
                MessageService.Current.Info("请输入矢量面数据!!!");
                return false;
            }

            //根据已选的规则，分类处理
            IFeatureSet MergeResult = new FeatureSet(GeometryType.Polygon);
            MergeResult.Projection.CopyFrom(InputName.Datasource.Projection);
            switch (InputOperation)
            {
                case GapOperation.间隙处创建新要素:
                    Output.Result = InputName.Datasource.Merge(false, InputtopoName.Datasource, false);
                    Log.Info("Process finished!!!");
                    break;
                case GapOperation.间隙融合到面积大的相邻小班中:
                    //循环遍历两个矢量
                    MergeResult = InputName.Datasource;

                    var fieldslist = MergeResult.Fields;
                    var oldtable = MergeResult.Table;

                    MergeResult.StartEditingTable();
                    MergeResult.StartEditingShapes();
                    MergeResult.Fields.Add("mergefield", AttributeType.Integer, 0, 6);
                    //编辑MergeResult的mergefield属性
                    for (int fsi = 0; fsi < MergeResult.Features.Count; fsi++)
                    {
                        MergeResult.Table.EditCellValue(MergeResult.Fields.IndexByName("mergefield"), fsi, MergeResult.Features[fsi].Index);
                    }
                    //编辑InputtopoName的mergefield属性
                    InputtopoName.Datasource.StartEditingTable();
                    InputtopoName.Datasource.Fields.Add("mergefield", AttributeType.Integer, 0, 6);
                    for (int topoi = 0; topoi < InputtopoName.Datasource.Features.Count; topoi++)
                    {
                        IFeatureSet topoResult = new FeatureSet(GeometryType.Polygon);
                        topoResult.Projection.CopyFrom(InputName.Datasource.Projection);
                        IGeometry atopofeature = InputtopoName.Datasource.Features[topoi].Geometry;
                        topoResult.Features.EditAdd(atopofeature);

                        int areamaxid = 0;
                        double fsarea = 0.0;
                        for (int featurei = 0; featurei < MergeResult.Features.Count; featurei++)
                        {
                            if (atopofeature.Touches(MergeResult.Features[featurei].Geometry) is true)
                            {
                                IFeatureSet TmpResult = new FeatureSet(GeometryType.Polygon);
                                TmpResult.Projection.CopyFrom(InputName.Datasource.Projection);
                                TmpResult.Features.EditAdd(MergeResult.Features[featurei].Geometry);

                                if (CalAreaFeatureSet(TmpResult) > fsarea)
                                {
                                    fsarea = CalAreaFeatureSet(TmpResult);
                                    areamaxid = MergeResult.Features[featurei].Index;
                                }
                            }
                        }
                        //找到面积最大的相邻地块
                        InputtopoName.Datasource.Table.EditCellValue(InputtopoName.Datasource.Fields.IndexByName("mergefield"), topoi, areamaxid);  
                    }
                    var DissResult = MergeResult.Merge(false, InputtopoName.Datasource, false);//缝隙要素添加到地块矢量中

                    InputtopoName.Datasource.Fields.Remove(InputtopoName.Datasource.Fields.IndexByName("mergefield"));
                    InputtopoName.Datasource.StopEditingTable();
                    var DissResultNew = DissResult.Dissolve(DissResult.Fields.IndexByName("mergefield"), false); //缝隙和临近地块融合
                    Log.Info("Shapes process finished!!!");
                    ////编辑属性表，添加属性
                    int fieldi = 0;
                    Log.Info("Table processing...");

                    DissResultNew.StartEditingShapes();
                    foreach (var afield in fieldslist)
                    {
                        DissResultNew.Fields.Add(afield.Name, afield.Type, afield.Precision, afield.Width);
                        for (int rowi = 0; rowi < DissResultNew.Features.Count; rowi++)
                        {
                            for (int editfi = 0; editfi < MergeResult.Features.Count; editfi++)
                            {
                                if (MergeResult.Features[editfi].Index != Convert.ToInt16(DissResultNew.Table.CellValue(0, rowi)))
                                {
                                    continue;
                                }
                                else
                                {
                                    DissResultNew.Table.EditCellValue(DissResultNew.Fields.IndexByName(afield.Name), rowi, oldtable.CellValue(fieldi, editfi));
                                    break;
                                }
                            }

                        }

                        fieldi += 1;
                    }
                    DissResultNew.Fields.Remove(DissResult.Fields.IndexByName("mergefield"));
                    //保存，输出
                    Log.Info("Table process finished!!!");
                    MergeResult.Fields.Remove(MergeResult.Fields.IndexByName("mergefield"));
                    MergeResult.Save();
                    MergeResult.StopEditingShapes();
                    MergeResult.StopEditingTable();
                    DissResultNew.Save();
                    DissResultNew.StopEditingShapes();
                    Output.Result = DissResultNew;
                    break;
                case GapOperation.间隙融合到面积小的相邻小班中:
                    //循环遍历两个矢量
                    MergeResult = InputName.Datasource;

                    fieldslist = MergeResult.Fields;
                    oldtable = MergeResult.Table;

                    MergeResult.StartEditingTable();
                    MergeResult.StartEditingShapes();
                    MergeResult.Fields.Add("mergefield", AttributeType.Integer, 0, 6);
                    //编辑MergeResult的mergefield属性
                    for (int fsi = 0; fsi < MergeResult.Features.Count; fsi++)
                    {
                        MergeResult.Table.EditCellValue(MergeResult.Fields.IndexByName("mergefield"), fsi, MergeResult.Features[fsi].Index);
                    }
                    //编辑InputtopoName的mergefield属性
                    InputtopoName.Datasource.StartEditingTable();
                    InputtopoName.Datasource.Fields.Add("mergefield", AttributeType.Integer, 0, 6);
                    for (int topoi = 0; topoi < InputtopoName.Datasource.Features.Count; topoi++)
                    {
                        IFeatureSet topoResult = new FeatureSet(GeometryType.Polygon);
                        topoResult.Projection.CopyFrom(InputName.Datasource.Projection);
                        IGeometry atopofeature = InputtopoName.Datasource.Features[topoi].Geometry;
                        topoResult.Features.EditAdd(atopofeature);

                        int areamaxid = 0;
                        double fsarea = 10000000000.0;
                        for (int featurei = 0; featurei < MergeResult.Features.Count; featurei++)
                        {
                            if (atopofeature.Touches(MergeResult.Features[featurei].Geometry) is true)
                            {
                                IFeatureSet TmpResult = new FeatureSet(GeometryType.Polygon);
                                TmpResult.Projection.CopyFrom(InputName.Datasource.Projection);
                                TmpResult.Features.EditAdd(MergeResult.Features[featurei].Geometry);

                                if (CalAreaFeatureSet(TmpResult) < fsarea)
                                {
                                    fsarea = CalAreaFeatureSet(TmpResult);
                                    areamaxid = MergeResult.Features[featurei].Index;
                                }
                            }
                        }
                        //找到面积最大的相邻地块
                        InputtopoName.Datasource.Table.EditCellValue(InputtopoName.Datasource.Fields.IndexByName("mergefield"), topoi, areamaxid);
                    }
                    DissResult = MergeResult.Merge(false, InputtopoName.Datasource, false);//缝隙要素添加到地块矢量中

                    InputtopoName.Datasource.Fields.Remove(InputtopoName.Datasource.Fields.IndexByName("mergefield"));
                    InputtopoName.Datasource.StopEditingTable();
                    DissResultNew = DissResult.Dissolve(DissResult.Fields.IndexByName("mergefield"), false); //缝隙和临近地块融合
                    Log.Info("Shapes process finished!!!");
                    ////编辑属性表，添加属性
                    fieldi = 0;
                    Log.Info("Table processing...");

                    DissResultNew.StartEditingShapes();
                    foreach (var afield in fieldslist)
                    {
                        DissResultNew.Fields.Add(afield.Name, afield.Type, afield.Precision, afield.Width);
                        for (int rowi = 0; rowi < DissResultNew.Features.Count; rowi++)
                        {
                            for (int editfi = 0; editfi < MergeResult.Features.Count; editfi++)
                            {
                                if (MergeResult.Features[editfi].Index != Convert.ToInt16(DissResultNew.Table.CellValue(0, rowi)))
                                {
                                    continue;
                                }
                                else
                                {
                                    DissResultNew.Table.EditCellValue(DissResultNew.Fields.IndexByName(afield.Name), rowi, oldtable.CellValue(fieldi, editfi));
                                    break;
                                }
                            }

                        }

                        fieldi += 1;
                    }
                    DissResultNew.Fields.Remove(DissResult.Fields.IndexByName("mergefield"));
                    //保存，输出
                    Log.Info("Table process finished!!!");
                    MergeResult.Fields.Remove(MergeResult.Fields.IndexByName("mergefield"));
                    MergeResult.Save();
                    MergeResult.StopEditingShapes();
                    MergeResult.StopEditingTable();
                    DissResultNew.Save();
                    DissResultNew.StopEditingShapes();
                    Output.Result = DissResultNew;
                    break;
                case GapOperation.间隙融合到共有最长公共边的相邻小班中:
                    //循环遍历两个矢量
                    MergeResult = InputName.Datasource;

                    fieldslist = MergeResult.Fields;
                    oldtable = MergeResult.Table;

                    MergeResult.StartEditingTable();
                    MergeResult.StartEditingShapes();
                    MergeResult.Fields.Add("mergefield", AttributeType.Integer, 0, 6);
                    //编辑MergeResult的mergefield属性
                    for (int fsi = 0; fsi < MergeResult.Features.Count; fsi++)
                    {
                        MergeResult.Table.EditCellValue(MergeResult.Fields.IndexByName("mergefield"), fsi, MergeResult.Features[fsi].Index);
                    }
                    //编辑InputtopoName的mergefield属性
                    InputtopoName.Datasource.StartEditingTable();
                    InputtopoName.Datasource.Fields.Add("mergefield", AttributeType.Integer, 0, 6);
                    for (int topoi = 0; topoi < InputtopoName.Datasource.Features.Count; topoi++)
                    {
                        IFeatureSet topoResult = new FeatureSet(GeometryType.Polygon);
                        topoResult.Projection.CopyFrom(InputName.Datasource.Projection);
                        IGeometry atopofeature = InputtopoName.Datasource.Features[topoi].Geometry;
                        topoResult.Features.EditAdd(atopofeature);

                        IFeatureSet InterResult = new FeatureSet(GeometryType.Polyline);
                        InterResult = topoResult.Intersection(false, MergeResult, false, GeometryType.Polyline);//相交得到公共边
                        if (InterResult == null)
                        {
                            Log.Info("null");
                            continue;
                        }
                        //遍历相交结果，得到公共边最长的小班ID号
                        int firstfieldid = 0;
                        double Linelength = 0.0;

                        for (int interi = 0; interi < InterResult.Features.Count; interi++)
                        {
                            if (InterResult.Features[interi].Geometry.Length > Linelength)
                            {
                                Linelength = InterResult.Features[interi].Geometry.Length;
                                firstfieldid = Convert.ToInt16(InterResult.Table.CellValue(InterResult.Fields.IndexByName("mergefield"), interi));
                            }
                        }
                        //找到公共边最长的相邻地块
                        InputtopoName.Datasource.Table.EditCellValue(InputtopoName.Datasource.Fields.IndexByName("mergefield"), topoi, firstfieldid);
                    }
                    DissResult = MergeResult.Merge(false, InputtopoName.Datasource, false);//缝隙要素添加到地块矢量中

                    InputtopoName.Datasource.Fields.Remove(InputtopoName.Datasource.Fields.IndexByName("mergefield"));
                    InputtopoName.Datasource.StopEditingTable();
                    DissResultNew = DissResult.Dissolve(DissResult.Fields.IndexByName("mergefield"), false); //缝隙和临近地块融合
                    Log.Info("Shapes process finished!!!");
                    ////编辑属性表，添加属性
                    fieldi = 0;
                    Log.Info("Table processing...");

                    DissResultNew.StartEditingShapes();
                    foreach (var afield in fieldslist)
                    {
                        DissResultNew.Fields.Add(afield.Name, afield.Type, afield.Precision, afield.Width);
                        for (int rowi = 0; rowi < DissResultNew.Features.Count; rowi++)
                        {
                            for (int editfi = 0; editfi < MergeResult.Features.Count; editfi++)
                            {
                                if (MergeResult.Features[editfi].Index != Convert.ToInt16(DissResultNew.Table.CellValue(0, rowi)))
                                {
                                    continue;
                                }
                                else
                                {
                                    DissResultNew.Table.EditCellValue(DissResultNew.Fields.IndexByName(afield.Name), rowi, oldtable.CellValue(fieldi, editfi));
                                    break;
                                }
                            }

                        }

                        fieldi += 1;
                    }
                    DissResultNew.Fields.Remove(DissResult.Fields.IndexByName("mergefield"));
                    //保存，输出
                    Log.Info("Table process finished!!!");
                    MergeResult.Fields.Remove(MergeResult.Fields.IndexByName("mergefield"));
                    MergeResult.Save();
                    MergeResult.StopEditingShapes();
                    MergeResult.StopEditingTable();
                    DissResultNew.Save();
                    DissResultNew.StopEditingShapes();
                    Output.Result = DissResultNew;
                    break;
            }
            return true;
        }

        // 计算要素面积
        private double CalAreaFeatureSet(IFeatureSet fs)
        {
            // TODO: to optimize memory usage would be better to reproject shapes one at a time
            var sr = new SpatialReference();
            sr.SetWgs84();

            int count;
            var projfs = fs.Reproject(sr, null, out count);

            double area = Math.Abs(GeodesicUtils.GeodesicArea(projfs.Features[0].Geometry)); //计算面积
            return area;      
        }
    }
}
