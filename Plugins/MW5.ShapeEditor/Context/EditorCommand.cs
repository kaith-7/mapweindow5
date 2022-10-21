﻿namespace MW5.Plugins.ShapeEditor.Context
{
    public enum EditorCommand
    {
        None = 0,
        AddShape = 1,
        EditShape = 2,
        AddPart = 3,
        RemovePart = 4,
        EditLayer = 5,
        CreateLayer = 6,
        Undo = 7,
        Redo = 8,
        SplitShapes = 9,
        MergeShapes = 10,
        RotateShapes = 11,
        MoveShapes = 12,
        RemoveShapes = 13,
        Copy = 14,
        Paste = 15,
        Cut = 16,
        SplitByPolyline = 17,
        EraseByPolygon = 18,
        ClipByPolygon = 19,
        SplitByPolygon = 20,
        VertexEditor = 21,
        PartEditor = 22,
        ClearEditor = 23,
        SaveShape = 24,
        SelectByRectangle = 25,
        ClearSelection = 26,
        SnappingNone = 27,
        SnappingCurrent = 28,
        SnappingAll = 29,
        HighlightNone = 30,
        HighlightCurrent = 31,
        HighlightAll = 32,
        UndoPoint = 33,
        FinishShape = 34,
        CancelShape = 35,

        SnapToVertices = 63,
        SnapToLinesAndVertices = 64,
        SnapToLines = 65,

        EditLineInvert = 100,
        EditLineJoin = 101,
        EditLineExpand = 102
    }
}
