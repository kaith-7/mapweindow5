using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Api.Events;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Api.Legend.Events;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Plugins.ShapeEditor.Operations;
using MW5.Plugins.ShapeEditor.Views;

namespace MW5.Plugins.ShapeEditor.Services
{
    public class GeoprocessingService : IGeoprocessingService
    {
        private readonly IAppContext _context;
        private readonly IBroadcasterService _broadcaster;
        private readonly CopyOperation _copyOperation;
        private ILayer layerSelected;
        private int indexShapeSelected;
        private IList<int> copyFields = new List<int>();

        public GeoprocessingService(IAppContext context, IBroadcasterService broadcaster)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (broadcaster == null) throw new ArgumentNullException("broadcaster");

            _context = context;
            _broadcaster = broadcaster;
            _copyOperation = new CopyOperation(context.Map, this);
        }

        /// <summary>
        /// Merges selected shapes
        /// </summary>
        public void MergeShapes()
        {
            var result = MergeOperation.Run(_context);
            switch (result)
            {
                case MergeResult.Ok:
                    _context.Map.Redraw(RedrawType.SkipDataLayers);
                    MessageService.Current.Info("要素已合并成功。");
                    //App.RefreshUI();
                    break;
                case MergeResult.TooManyShapes:
                    MessageService.Current.Info("形状太多，同时操作的要素数不能超过50。");
                    break;
                case MergeResult.Failed:
                    MessageService.Current.Info("合并失败。");
                    break;
                case MergeResult.NoInput:
                    MessageService.Current.Info("找不到输入操作。");
                    break;
            }
        }

        /// <summary>
        /// Splits selected multipart shapes
        /// </summary>
        public void ExplodeShapes()
        {
            var result = ExplodeOperation.Run(_context);
            switch (result)
            {
                case ExplodeResult.Ok:
                    _context.Map.Redraw(RedrawType.SkipDataLayers);
                    MessageService.Current.Info("要素分离成功");
                    break;
                case ExplodeResult.NoMultiPart:
                    MessageService.Current.Info("已选择的要素中，没有多个要素。");
                    break;
                case ExplodeResult.Failed:
                    MessageService.Current.Info("合并失败");
                    break;
                case ExplodeResult.NoInput:
                    MessageService.Current.Info("找不到输入操作。");
                    break;
            }
        }

        public bool BufferIsEmpty
        {
            get { return _copyOperation.IsEmpty; }
        }

        public void CopyShapes()
        {
            var layer = _context.Map.Layers.Current;
            if (layer != null && layer.IsVector)
            {
                _copyOperation.Copy(layer.Handle, layer.FeatureSet);
            }

        }
        public void SetAttributesCopy()
        {
            layerSelected = _context.Legend.SelectedLayer;
            indexShapeSelected = -1;
            if (layerSelected.FeatureSet.SelectedIndices.Count == 1)
            {
                indexShapeSelected = layerSelected.FeatureSet.SelectedIndices[0];
            }

            // show fields select form and return fields index selected.
            var fieldsSelection = FieldsSelection.GetInstance(layerSelected.FeatureSet);
            fieldsSelection.StartPosition = FormStartPosition.CenterParent;
            if (fieldsSelection.ShowDialog(_context.View.MainForm) == DialogResult.OK)
            {
                foreach (var item in fieldsSelection.FieldsIndecies)
                {
                    this.copyFields.Add(item);
                }
            }
        }

        public bool HasAttributesCopy()
        {
            if (layerSelected != null)
            {
                var layer = _context.Layers[layerSelected.Handle];
                if (layer != null)
                    if (layer.LayerType == LayerType.Shapefile || layer.LayerType == LayerType.VectorLayer)
                        return indexShapeSelected != -1;
            }
            return false;
        }

        public void CopyAttributes()
        {
            var layer = _context.Legend.SelectedLayer;
            if (MessageBox.Show(_context.View.MainForm, string.Format($"粘贴到{layer.FeatureSet.SelectedIndices.Count}个要素"), "SunToonGIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            if (layerSelected == layer && indexShapeSelected >= 0)
            {
                int count = 0;
                var featSel = layerSelected.FeatureSet.Features[indexShapeSelected];
                foreach (var idx in layer.FeatureSet.SelectedIndices)
                {
                    if (layer == layerSelected && idx == indexShapeSelected)
                        continue;
                    var featDst = layer.FeatureSet.Features[idx];
                    bool modified = false;
                    foreach (int i in this.copyFields)
                    {
                        var field = featSel.GetField(i);
                        featDst.SetValue(i, featSel.GetValue(i));
                        modified = true;
                    }
                    featDst.Modified = modified;
                    count += modified ? 1 : 0;

                }

                MessageBox.Show(_context.View.MainForm, string.Format($"已粘贴到{count}个要素"), "SunToonGIS");

                _broadcaster.BroadcastEvent(p => p.SelectionChanged_, _context.Map, new SelectionChangedEventArgs(layer.Handle));
            }

            _context.Map.MapCursor = MapCursor.Selection;
            layerSelected = null;
            indexShapeSelected = -1;
        }

        public void PasteShapes()
        {
            var layer = _context.Legend.SelectedLayer;
            // TRY: 添加粘贴图层选择,目前可以通过在Legend中选择目标层，目标层几何类型一致并启动编辑且被选中即可粘贴
            //if (_context.Legend.Layers.Count > 1)
            //{
            //    LayerSelectView layerSelectView = new LayerSelectView(_context.Legend.Layers);
            //    var res = layerSelectView.ShowDialog();
            //    if (res == DialogResult.OK)
            //    {
            //        layer = layerSelectView.SelectedLayer;
            //    }
            //}

            if (layer != null && layer.IsVector && layer.FeatureSet.InteractiveEditing)
            {
                var result = _copyOperation.Paste(layer.Handle, layer.FeatureSet);
                switch (result)
                {
                    case PasteResult.Ok:
                        _context.Map.Redraw();
                        MessageService.Current.Info("要素已拷贝。");
                        //App.RefreshUI();
                        break;
                    case PasteResult.NoInput:
                        MessageService.Current.Info("未输入");
                        break;
                    case PasteResult.ShapeTypeMismatch:
                        MessageService.Current.Info("源数据和目标数据的类型不匹配。");
                        break;
                }
            }
        }

        public void CutShapes()
        {
            var layer = _context.Legend.SelectedLayer;
            if (layer != null && layer.IsVector && layer.FeatureSet.InteractiveEditing)
            {
                try
                {
                    _copyOperation.Cut(layer.Handle, layer.FeatureSet);
                }
                catch (Exception ex)
                {
                    MessageService.Current.Warn("Fail," + ex.Message);
                }
                _context.Map.Redraw();
            }
        }

        public void ReplaceShape(int layerHandle, int shapeIndex, IGeometry newGeometry)
        {
            var layer = _context.Layers.GetVectorLayer(layerHandle);
            if (layer == null)
            {
                MessageService.Current.Info("找不到指定图层。");
                return;
            }

            BeforeShapeEditEventArgs beforeargs = new BeforeShapeEditEventArgs(layerHandle, shapeIndex, false);
            _broadcaster.BroadcastEvent(p => p.BeforeShapeEdit_, _context.Map, beforeargs);

            if (beforeargs.Cancel == true)
                return;

            _context.Map.History.Add(UndoOperation.EditShape, layerHandle, shapeIndex);
            layer.Data.Features.EditUpdate(shapeIndex, newGeometry);

            AfterShapeEditEventArgs afterargs = new AfterShapeEditEventArgs(UndoOperation.EditShape, layerHandle, shapeIndex);
            _broadcaster.BroadcastEvent(p => p.AfterShapeEdit_, _context.Map, afterargs);
        }

        void IGeoprocessingService.EditLineInvert()
        {
            var layer = _context.Legend.SelectedLayer;
            if (layer != null && layer.IsVector && layer.FeatureSet.InteractiveEditing)
            {
                var undoList = _context.Map.History;
                try
                {
                    undoList.BeginBatch();

                    var selectIndices = layer.FeatureSet.SelectedIndices;
                    foreach (var idx in selectIndices)
                    {
                        var ft = layer.FeatureSet.Features[idx];
                        if (ft.Geometry.GeometryType != GeometryType.Polyline)
                            continue;

                        undoList.Add(UndoOperation.EditShape, layer.Handle, idx);

                        var newGeom = ft.Geometry.Clone();
                        var count = newGeom.Points.Count;
                        for (int i = 0, j = count - 1; i < j; i++, j--)
                        {
                            var ptI = newGeom.Points[i];
                            var ptJ = newGeom.Points[j];
                            newGeom.MovePoint(i, ptJ.X, ptJ.Y);
                            newGeom.MovePoint(j, ptI.X, ptI.Y);
                        }

                        layer.FeatureSet.Features.EditUpdate(idx, newGeom);
                    }
                }
                catch (Exception ex)
                {
                    MessageService.Current.Warn("Fail," + ex.Message);
                }
                finally
                {
                    undoList.EndBatch();
                }
                _context.Map.Redraw();
            }
            _broadcaster.BroadcastEvent(p => p.LayerFeatureCountChanged_, null, new LayerEventArgs(layer.Handle));
        }
        void IGeoprocessingService.EditLineJoin()
        {
            var layer = _context.Legend.SelectedLayer;
            if (layer != null && layer.IsVector && layer.FeatureSet.InteractiveEditing)
            {
                var undoList = _context.Map.History;
                try
                {
                    var fs = layer.FeatureSet.Features;

                    var selectIndices = layer.FeatureSet.SelectedIndices;
                    if (selectIndices.Count != 1)
                        return;

                    var ft = fs[selectIndices[0]];
                    if (ft.Geometry.GeometryType != GeometryType.Polyline)
                        return;
                    var ft1 = fs[fs.Count - 1];
                    if (ft1.Geometry.GeometryType != GeometryType.Polyline)
                        return;
                    if (ft.Geometry.Distance(ft1.Geometry) > 0.00001)
                        return;

                    IGeometry newGeom = JoinPolyline(ft, ft1);
                    if (newGeom != null)
                    {
                        undoList.BeginBatch(_context.Map.MapCursor != MapCursor.EditLineExpand);
                        //undoList.BeginBatch();
                        int idxAttr = selectIndices[0];
                        if (_context.Map.MapCursor != MapCursor.EditLineExpand)
                        {
                            ; // TODO: 选择合并的主要素
                        }
                        int shapeIndex = fs.EditAdd(newGeom);
                        layer.FeatureSet.Table.CopyAttributes(idxAttr, shapeIndex);
                        undoList.Add(UndoOperation.AddShape, layer.Handle, shapeIndex);
                        fs[shapeIndex].Selected = true;

                        for (int i = fs.Count - 1; i >= 0; i--)
                        {
                            if (!fs[i].Selected || i == shapeIndex) continue;

                            if (undoList.Add(UndoOperation.RemoveShape, layer.Handle, i))
                            {
                                fs.EditDelete(i);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageService.Current.Warn("Fail," + ex.Message);
                }
                finally
                {
                    undoList.EndBatch();
                }

                _context.Map.Redraw();
            }
            _broadcaster.BroadcastEvent(p => p.LayerFeatureCountChanged_, null, new LayerEventArgs(layer.Handle));
        }

        private static IGeometry JoinPolyline(IFeature ft, IFeature ft1)
        {
            var newGeom = ft.Geometry.Clone();
            var tolerance = 0.00001;
            if (newGeom.Points[0].Distance(ft1.Geometry.Points[0]) < tolerance)
            {
                //ft1.Geometry.MovePoint(0, newGeom.Points[0].X, newGeom.Points[0].Y);
                for (int i = 0; i < ft1.Geometry.Points.Count; i++)
                {
                    newGeom.Points.Insert(0, ft1.Geometry.Points[i]);
                }
            }
            else if (newGeom.Points[0].Distance(ft1.Geometry.Points[ft1.Geometry.Points.Count - 1]) < tolerance)
            {
                //ft1.Geometry.MovePoint(ft1.Geometry.Points.Count - 1, newGeom.Points[0].X, newGeom.Points[0].Y);
                for (int i = ft1.Geometry.Points.Count - 1; i >= 0; i--)
                {
                    newGeom.Points.Insert(0, ft1.Geometry.Points[i]);
                }
            }
            else if (newGeom.Points[newGeom.Points.Count - 1].Distance(ft1.Geometry.Points[0]) < tolerance)
            {
                //ICoordinate pt = newGeom.Points[newGeom.Points.Count - 1];
                //ft1.Geometry.MovePoint(0, pt.X, pt.Y);
                for (int i = 0; i < ft1.Geometry.Points.Count; i++)
                {
                    newGeom.Points.Add(ft1.Geometry.Points[i]);
                }
            }
            else if (newGeom.Points[newGeom.Points.Count - 1].Distance(ft1.Geometry.Points[ft1.Geometry.Points.Count - 1]) < tolerance)
            {
                //ICoordinate pt = newGeom.Points[newGeom.Points.Count - 1];
                //ft1.Geometry.MovePoint(ft1.Geometry.Points.Count - 1, pt.X, pt.Y);
                for (int i = ft1.Geometry.Points.Count - 1; i >= 0; i--)
                {
                    newGeom.Points.Add(ft1.Geometry.Points[i]);
                }
            }
            else
            {
                return null;
            }

            return newGeom; //ft.Geometry.Clip(ft1.Geometry, ClipOperation.Union);
        }

        /// <summary>
        /// Removes selected shapes
        /// </summary>
        public void RemoveSelectedShapes(bool prompt)
        {
            var layer = _context.Layers.Current;

            RemoveSelectedShapesCore(layer, prompt);
        }

        public void RemoveSelectedShapes(int layerHandle, bool prompt)
        {
            var layer = _context.Layers.ItemByHandle(layerHandle);

            RemoveSelectedShapesCore(layer, prompt);
        }

        private void RemoveSelectedShapesCore(ILayer layer, bool prompt)
        {
            if (prompt)
            {
                RemoveSelectedShapesWithPrompt(layer);
            }
            else
            {
                RemoveSelectedShapesWithPrompt(layer);
                _context.Map.Redraw();
            }
        }

        private void RemoveSelectedShapesWithPrompt(ILayer layer)
        {
            if (layer == null || layer.FeatureSet == null) return;

            var fs = layer.FeatureSet;

            if (!fs.InteractiveEditing)
            {
                MessageService.Current.Info("请对图层启动编辑模式 (编辑矢量工具栏)。");
                return;
            }

            if (fs.NumSelected == 0)
            {
                MessageService.Current.Info("本图层未选择要素。");
                return;
            }

            if (MessageService.Current.Ask("删除已选择要素: " + fs.NumSelected + "?"))
            {
                RemoveSelectedShapesNoPrompt(_context.Map, layer.FeatureSet, layer.Handle);
                _context.Map.Redraw();
            }
        }

        private void RemoveSelectedShapesNoPrompt(IMuteMap map, IFeatureSet fs, int layerHandle)
        {
            var features = fs.Features;
            var list = map.History;
            var actualDeletes = new List<int>();

            try
            {
                list.BeginBatch();
                for (int i = features.Count - 1; i >= 0; i--)
                {
                    if (!features[i].Selected) continue;

                    var args = new BeforeDeleteShapeEventArgs(DeleteTarget.Shape, false, true);
                    _broadcaster.BroadcastEvent(p => p.BeforeDeleteShape_, _context.Map, args);
                    if (!args.Cancel && list.Add(UndoOperation.RemoveShape, layerHandle, i))
                    {
                        features.EditDelete(i);
                    }
                }
            }
            finally
            {
                list.EndBatch();
            }
            _broadcaster.BroadcastEvent(p => p.LayerFeatureCountChanged_, fs, new LayerEventArgs(layerHandle));
        }

    }
}
