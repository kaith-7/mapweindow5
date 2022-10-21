﻿using System;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Concrete;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.ShapeEditor.Menu;
using System.Drawing;

namespace MW5.Plugins.ShapeEditor.Context
{
    public class ContextMenuPresenter : CommandDispatcher<ContextMenuView, EditorCommand>
    {
        private readonly IAppContext _context;
        private readonly ILayerService _layerService;
        private readonly IGeoprocessingService _geoService;
        private readonly ShapeEditor _plugin;
        private System.Drawing.Point mouse_position;

        public ContextMenuPresenter(IAppContext context, ShapeEditor plugin, ILayerService layerService, 
                        IGeoprocessingService geoService, ContextMenuView view)
            :base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (layerService == null) throw new ArgumentNullException("layerService");
            if (geoService == null) throw new ArgumentNullException("geoService");
            _context = context;
            _layerService = layerService;
            _geoService = geoService;
            _plugin = plugin;
        }

        public ContextMenuStrip DigitizingMenu
        {
            get { return View.DigitizingMenu; }
        }

        public ContextMenuStrip SelectionMenu
        {
            get { return View.SelectionMenu; }
        }

        public ContextMenuStrip VertexMenu
        {
            get { return View.VertexMenu; }
        }

        public Point Mouse_position { get => mouse_position; set => mouse_position = value; }

        public override void RunCommand(EditorCommand command)
        {
            if (HandleGroupOperation(command)) return;

            if (HandleChangeTool(command)) return;

            if (HandleVertexEditor(command)) return;

            if (HandleSnappingAndHighlighting(command)) return;

            var map = _context.Map;
            switch (command)
            {
                case EditorCommand.Undo:
                case EditorCommand.UndoPoint:
                    map.Undo();
                    map.Redraw(RedrawType.SkipDataLayers);
                    break;
                case EditorCommand.Redo:
                    map.History.Redo();
                    map.Redraw(RedrawType.SkipDataLayers);
                    break;
                case EditorCommand.ClearSelection:
                    _layerService.ClearSelection();
                    break;
            }

            _context.View.Update();
        }

        public bool HandleSnappingAndHighlighting(EditorCommand command)
        {
            var editor = _context.Map.GeometryEditor;

            var handled = false;
            switch (command)
            {
                case EditorCommand.SnapToVertices:
                    editor.SnapMode = SnapMode.Vertices;
                    handled = true;
                    break;
                case EditorCommand.SnapToLinesAndVertices:
                    editor.SnapMode = SnapMode.VerticesAndLines;
                    handled = true;
                    break;
                case EditorCommand.SnapToLines:
                    editor.SnapMode = SnapMode.Lines;
                    handled = true;
                    break;
                case EditorCommand.SnappingNone:
                    editor.SnapBehavior = LayerSelectionMode.NoLayer;
                    handled = true;
                    break;
                case EditorCommand.SnappingCurrent:
                    editor.SnapBehavior = LayerSelectionMode.ActiveLayer;
                    handled = true;
                    break;
                case EditorCommand.SnappingAll:
                    editor.SnapBehavior = LayerSelectionMode.AllLayers;
                    handled = true;
                    break;
                case EditorCommand.HighlightNone:
                    editor.HighlightVertices = LayerSelectionMode.NoLayer;
                    handled = true;
                    break;
                case EditorCommand.HighlightCurrent:
                    editor.HighlightVertices = LayerSelectionMode.ActiveLayer;
                    handled = true;
                    break;
                case EditorCommand.HighlightAll:
                    editor.HighlightVertices = LayerSelectionMode.AllLayers;
                    handled = true;
                    break;
            }

            _plugin._menuUpdater.UpdateSnapStates();

            return handled;
        }

        public bool HandleVertexEditor(EditorCommand command)
        {
            var editor = _context.Map.GeometryEditor;

            switch (command)
            {
                case EditorCommand.ClearEditor:
                case EditorCommand.CancelShape:
                    editor.Clear();
                    _context.Map.Redraw(RedrawType.SkipDataLayers);
                    return true;
                case EditorCommand.SaveShape:
                case EditorCommand.FinishShape:
                    var WithinBatch = _context.Map.MapCursor == MapCursor.EditLineExpand;
                    editor.SaveChanges(WithinBatch); 
                    if (_context.Map.MapCursor == MapCursor.EditLineExpand)
                    {
                        _geoService.EditLineJoin();
                        _context.Map.MapCursor = MapCursor.Selection;
                    }
                    _context.Map.Redraw(RedrawType.SkipDataLayers);
                    return true;
                case EditorCommand.AddPart:
                    editor.StartOverlay(EditorOverlay.AddPart);
                    return true;
                case EditorCommand.RemovePart:
                    editor.StartOverlay(EditorOverlay.RemovePart);
                    return true;
                case EditorCommand.VertexEditor:
                    editor.EditorBehavior = EditorBehavior.VertexEditor;
                    _context.Map.Redraw(RedrawType.SkipDataLayers);
                    return true;
                case EditorCommand.PartEditor:
                    editor.EditorBehavior = EditorBehavior.PartEditor;
                    _context.Map.Redraw(RedrawType.SkipDataLayers);
                    return true;
            }
            return false;
        }

        public bool HandleChangeTool(EditorCommand command)
        {
            var map = _context.Map;

            switch (command)
            {
                case EditorCommand.SelectByRectangle:
                    map.MapCursor = MapCursor.Selection;
                    return true;
                case EditorCommand.SplitByPolygon:
                     map.MapCursor = MapCursor.SplitByPolygon;
                    return true;
                case EditorCommand.EraseByPolygon:
                     map.MapCursor = MapCursor.EraseByPolygon;
                    return true;
                case EditorCommand.ClipByPolygon:
                     map.MapCursor = MapCursor.ClipByPolygon;
                    return true;
                case EditorCommand.SplitByPolyline:
                     map.MapCursor = MapCursor.SplitByPolyline;
                    return true;
                case EditorCommand.RotateShapes:
                     map.MapCursor = MapCursor.RotateShapes;
                    return true;
                case EditorCommand.MoveShapes:
                     map.MapCursor = MapCursor.MoveShapes;
                    return true;
                case EditorCommand.AddShape:
                     map.MapCursor = MapCursor.AddShape;
                    return true;
                case EditorCommand.EditShape:
                     map.MapCursor = MapCursor.EditShape;
                    return true;
                case EditorCommand.EditLineExpand:
                    map.MapCursor = MapCursor.EditLineExpand;
                    var fs = _context.Layers.Current.FeatureSet;
                    var editor = _context.Map.GeometryEditor;
                    foreach (var ft in fs.Features)
                    {
                        if (ft.Selected)
                        {
                            var ptS = ft.Geometry.Points[0];
                            var ptE = ft.Geometry.Points[ft.Geometry.Points.Count - 1];
                            var posS = _context.Map.ProjToPixel(new Coordinate(ptS.X, ptS.Y));
                            var posE = _context.Map.ProjToPixel(new Coordinate(ptE.X, ptE.Y));
                            var pos = new Coordinate(mouse_position.X, mouse_position.Y);
                            var distS = posS.Distance(pos);
                            var distE = posE.Distance(pos);
                            if (distS < 50 || distE < 50)
                            {
                                if (distS > distE)
                                    editor.AddPoint(ptE);
                                else
                                    editor.AddPoint(ptS);
                            }
                        }
                    }

                    return true;
            }
            return false;
        }

        public bool HandleGroupOperation(EditorCommand command)
        {
            switch (command)
            {
                case EditorCommand.Copy:
                    _geoService.CopyShapes();
                    return true;
                case EditorCommand.Paste:
                    _geoService.PasteShapes();
                    return true;
                case EditorCommand.Cut:
                    _geoService.CutShapes();
                    return true;
                case EditorCommand.SplitShapes:
                    _geoService.ExplodeShapes();
                    return true;
                case EditorCommand.MergeShapes:
                    _geoService.MergeShapes();
                    return true;
                case EditorCommand.RemoveShapes:
                    _geoService.RemoveSelectedShapes(true);
                    return true;
                case EditorCommand.EditLineInvert:
                    _geoService.EditLineInvert();
                    return true;
                case EditorCommand.EditLineJoin:
                    _geoService.EditLineJoin();
                    return true;
            }
            return false;
        }
    }
}
