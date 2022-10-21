namespace MW5.Plugins.ShapeEditor.Context
{
    partial class ContextMenuView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextDigitizing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxUndoPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSnapNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnapCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnapAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxHighlightNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxHighlightCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxHighlightAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxFinishShape = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCancelShape = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSelection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxSelectByRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSplitShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMergeShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRotateShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMoveShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxEditLineInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxEditLineJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxEditLineExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxRemoveShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.contextVertex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.digitizerSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ctxVertexEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPartEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.editorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxAddPart = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRemovePart = new System.Windows.Forms.ToolStripMenuItem();
            this.editorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSnapping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSnapMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnapToVertices = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnapToLines = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnapToLinesAndVertices = new System.Windows.Forms.ToolStripMenuItem();
            this.snapSourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnappingAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnappingCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSnappingNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxHighlighting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHighlightNone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHighlightCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHighlightAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSaveShape = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxClearEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDigitizing.SuspendLayout();
            this.contextSelection.SuspendLayout();
            this.contextVertex.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextDigitizing
            // 
            this.contextDigitizing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxUndoPoint,
            this.toolStripSeparator2,
            this.ctxSnapNone,
            this.ctxSnapCurrent,
            this.ctxSnapAll,
            this.toolStripSeparator1,
            this.ctxHighlightNone,
            this.ctxHighlightCurrent,
            this.ctxHighlightAll,
            this.toolStripSeparator3,
            this.ctxFinishShape,
            this.ctxCancelShape});
            this.contextDigitizing.Name = "contextMenuStrip1";
            this.contextDigitizing.Size = new System.Drawing.Size(157, 220);
            // 
            // ctxUndoPoint
            // 
            this.ctxUndoPoint.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_edit_undo;
            this.ctxUndoPoint.Name = "ctxUndoPoint";
            this.ctxUndoPoint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ctxUndoPoint.Size = new System.Drawing.Size(156, 22);
            this.ctxUndoPoint.Text = "撤销点";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // ctxSnapNone
            // 
            this.ctxSnapNone.Name = "ctxSnapNone";
            this.ctxSnapNone.Size = new System.Drawing.Size(156, 22);
            this.ctxSnapNone.Text = "没有捕捉";
            // 
            // ctxSnapCurrent
            // 
            this.ctxSnapCurrent.Name = "ctxSnapCurrent";
            this.ctxSnapCurrent.Size = new System.Drawing.Size(156, 22);
            this.ctxSnapCurrent.Text = "当前图层";
            // 
            // ctxSnapAll
            // 
            this.ctxSnapAll.Name = "ctxSnapAll";
            this.ctxSnapAll.Size = new System.Drawing.Size(156, 22);
            this.ctxSnapAll.Text = "所有图层";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // ctxHighlightNone
            // 
            this.ctxHighlightNone.Name = "ctxHighlightNone";
            this.ctxHighlightNone.Size = new System.Drawing.Size(156, 22);
            this.ctxHighlightNone.Text = "没有高亮显示";
            // 
            // ctxHighlightCurrent
            // 
            this.ctxHighlightCurrent.Name = "ctxHighlightCurrent";
            this.ctxHighlightCurrent.Size = new System.Drawing.Size(156, 22);
            this.ctxHighlightCurrent.Text = "当前图层";
            // 
            // ctxHighlightAll
            // 
            this.ctxHighlightAll.Name = "ctxHighlightAll";
            this.ctxHighlightAll.Size = new System.Drawing.Size(156, 22);
            this.ctxHighlightAll.Text = "所有图层";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // ctxFinishShape
            // 
            this.ctxFinishShape.Name = "ctxFinishShape";
            this.ctxFinishShape.Size = new System.Drawing.Size(156, 22);
            this.ctxFinishShape.Text = "完成编辑";
            // 
            // ctxCancelShape
            // 
            this.ctxCancelShape.Name = "ctxCancelShape";
            this.ctxCancelShape.Size = new System.Drawing.Size(156, 22);
            this.ctxCancelShape.Text = "取消编辑";
            // 
            // contextSelection
            // 
            this.contextSelection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSelectByRectangle,
            this.ctxClearSelection,
            this.toolStripSeparator4,
            this.ctxSplitShapes,
            this.ctxMergeShapes,
            this.ctxRotateShapes,
            this.ctxMoveShapes,
            this.ctxEditLineInvert,
            this.ctxEditLineJoin,
            this.ctxEditLineExpand,
            this.toolStripSeparator5,
            this.ctxCopy,
            this.ctxCut,
            this.ctxPaste,
            this.toolStripSeparator6,
            this.ctxRemoveShapes});
            this.contextSelection.Name = "contextMenuStrip1";
            this.contextSelection.Size = new System.Drawing.Size(185, 382);
            // 
            // ctxSelectByRectangle
            // 
            this.ctxSelectByRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxSelectByRectangle.Name = "ctxSelectByRectangle";
            this.ctxSelectByRectangle.Size = new System.Drawing.Size(184, 26);
            this.ctxSelectByRectangle.Text = "按矩形选择";
            // 
            // ctxClearSelection
            // 
            this.ctxClearSelection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxClearSelection.Name = "ctxClearSelection";
            this.ctxClearSelection.Size = new System.Drawing.Size(184, 26);
            this.ctxClearSelection.Text = "清除选择";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // ctxSplitShapes
            // 
            this.ctxSplitShapes.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_geometry_split;
            this.ctxSplitShapes.Name = "ctxSplitShapes";
            this.ctxSplitShapes.Size = new System.Drawing.Size(184, 26);
            this.ctxSplitShapes.Text = "拆分";
            // 
            // ctxMergeShapes
            // 
            this.ctxMergeShapes.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_geometry_merge;
            this.ctxMergeShapes.Name = "ctxMergeShapes";
            this.ctxMergeShapes.Size = new System.Drawing.Size(184, 26);
            this.ctxMergeShapes.Text = "合并";
            // 
            // ctxRotateShapes
            // 
            this.ctxRotateShapes.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_geometry_rotate;
            this.ctxRotateShapes.Name = "ctxRotateShapes";
            this.ctxRotateShapes.Size = new System.Drawing.Size(184, 26);
            this.ctxRotateShapes.Text = "旋转";
            // 
            // ctxMoveShapes
            // 
            this.ctxMoveShapes.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_geometry_move;
            this.ctxMoveShapes.Name = "ctxMoveShapes";
            this.ctxMoveShapes.Size = new System.Drawing.Size(184, 26);
            this.ctxMoveShapes.Text = "移动";
            // 
            // ctxEditLineInvert
            // 
            this.ctxEditLineInvert.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_invert_line;
            this.ctxEditLineInvert.Name = "ctxEditLineInvert";
            this.ctxEditLineInvert.Size = new System.Drawing.Size(184, 26);
            this.ctxEditLineInvert.Text = "线反向";
            // 
            // ctxEditLineJoin
            // 
            this.ctxEditLineJoin.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_invert_line;
            this.ctxEditLineJoin.Name = "ctxEditLineJoin";
            this.ctxEditLineJoin.Size = new System.Drawing.Size(184, 26);
            this.ctxEditLineJoin.Text = "线连接";
            // 
            // ctxEditLineExpand
            // 
            this.ctxEditLineExpand.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_invert_line;
            this.ctxEditLineExpand.Name = "ctxEditLineExpand";
            this.ctxEditLineExpand.Size = new System.Drawing.Size(184, 26);
            this.ctxEditLineExpand.Text = "线延伸";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // ctxCopy
            // 
            this.ctxCopy.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_edit_copy;
            this.ctxCopy.Name = "ctxCopy";
            this.ctxCopy.Size = new System.Drawing.Size(184, 26);
            this.ctxCopy.Text = "复制";
            // 
            // ctxCut
            // 
            this.ctxCut.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_edit_cut;
            this.ctxCut.Name = "ctxCut";
            this.ctxCut.Size = new System.Drawing.Size(184, 26);
            this.ctxCut.Text = "剪切";
            // 
            // ctxPaste
            // 
            this.ctxPaste.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_edit_paste;
            this.ctxPaste.Name = "ctxPaste";
            this.ctxPaste.Size = new System.Drawing.Size(184, 26);
            this.ctxPaste.Text = "粘贴";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // ctxRemoveShapes
            // 
            this.ctxRemoveShapes.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.img_delete_selected;
            this.ctxRemoveShapes.Name = "ctxRemoveShapes";
            this.ctxRemoveShapes.Size = new System.Drawing.Size(184, 26);
            this.ctxRemoveShapes.Text = "删除";
            // 
            // contextVertex
            // 
            this.contextVertex.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextVertex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxUndo,
            this.digitizerSeparator,
            this.ctxVertexEditor,
            this.ctxPartEditor,
            this.editorSeparator1,
            this.ctxAddPart,
            this.ctxRemovePart,
            this.editorSeparator2,
            this.ctxSnapping,
            this.ctxHighlighting,
            this.toolStripSeparator7,
            this.ctxSaveShape,
            this.ctxClearEditor});
            this.contextVertex.Name = "contextMenuStrip1";
            this.contextVertex.Size = new System.Drawing.Size(161, 262);
            // 
            // ctxUndo
            // 
            this.ctxUndo.Image = global::MW5.Plugins.ShapeEditor.Properties.Resources.icon_edit_undo;
            this.ctxUndo.Name = "ctxUndo";
            this.ctxUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ctxUndo.Size = new System.Drawing.Size(160, 26);
            this.ctxUndo.Text = "撤销点";
            // 
            // digitizerSeparator
            // 
            this.digitizerSeparator.Name = "digitizerSeparator";
            this.digitizerSeparator.Size = new System.Drawing.Size(157, 6);
            // 
            // ctxVertexEditor
            // 
            this.ctxVertexEditor.Name = "ctxVertexEditor";
            this.ctxVertexEditor.Size = new System.Drawing.Size(160, 26);
            this.ctxVertexEditor.Text = "顶点编辑器";
            // 
            // ctxPartEditor
            // 
            this.ctxPartEditor.Name = "ctxPartEditor";
            this.ctxPartEditor.Size = new System.Drawing.Size(160, 26);
            this.ctxPartEditor.Text = "要素编辑器";
            // 
            // editorSeparator1
            // 
            this.editorSeparator1.Name = "editorSeparator1";
            this.editorSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // ctxAddPart
            // 
            this.ctxAddPart.Name = "ctxAddPart";
            this.ctxAddPart.Size = new System.Drawing.Size(160, 26);
            this.ctxAddPart.Text = "添加要素";
            // 
            // ctxRemovePart
            // 
            this.ctxRemovePart.Name = "ctxRemovePart";
            this.ctxRemovePart.Size = new System.Drawing.Size(160, 26);
            this.ctxRemovePart.Text = "按多边形删除";
            // 
            // editorSeparator2
            // 
            this.editorSeparator2.Name = "editorSeparator2";
            this.editorSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // ctxSnapping
            // 
            this.ctxSnapping.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSnapMode,
            this.snapSourcesToolStripMenuItem});
            this.ctxSnapping.Name = "ctxSnapping";
            this.ctxSnapping.Size = new System.Drawing.Size(160, 26);
            this.ctxSnapping.Text = "捕捉";
            // 
            // tsmSnapMode
            // 
            this.tsmSnapMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSnapToVertices,
            this.ctxSnapToLines,
            this.ctxSnapToLinesAndVertices});
            this.tsmSnapMode.Name = "tsmSnapMode";
            this.tsmSnapMode.Size = new System.Drawing.Size(124, 22);
            this.tsmSnapMode.Text = "捕捉目标";
            // 
            // ctxSnapToVertices
            // 
            this.ctxSnapToVertices.Name = "ctxSnapToVertices";
            this.ctxSnapToVertices.Size = new System.Drawing.Size(124, 22);
            this.ctxSnapToVertices.Text = "顶点";
            // 
            // ctxSnapToLines
            // 
            this.ctxSnapToLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctxSnapToLines.Name = "ctxSnapToLines";
            this.ctxSnapToLines.Size = new System.Drawing.Size(124, 22);
            this.ctxSnapToLines.Text = "线段";
            // 
            // ctxSnapToLinesAndVertices
            // 
            this.ctxSnapToLinesAndVertices.Name = "ctxSnapToLinesAndVertices";
            this.ctxSnapToLinesAndVertices.Size = new System.Drawing.Size(124, 22);
            this.ctxSnapToLinesAndVertices.Text = "线和顶点";
            // 
            // snapSourcesToolStripMenuItem
            // 
            this.snapSourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSnappingAll,
            this.ctxSnappingCurrent,
            this.ctxSnappingNone});
            this.snapSourcesToolStripMenuItem.Name = "snapSourcesToolStripMenuItem";
            this.snapSourcesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.snapSourcesToolStripMenuItem.Text = "捕捉源";
            // 
            // ctxSnappingAll
            // 
            this.ctxSnappingAll.Name = "ctxSnappingAll";
            this.ctxSnappingAll.Size = new System.Drawing.Size(124, 22);
            this.ctxSnappingAll.Text = "所有图层";
            // 
            // ctxSnappingCurrent
            // 
            this.ctxSnappingCurrent.Name = "ctxSnappingCurrent";
            this.ctxSnappingCurrent.Size = new System.Drawing.Size(124, 22);
            this.ctxSnappingCurrent.Text = "当前图层";
            // 
            // ctxSnappingNone
            // 
            this.ctxSnappingNone.Name = "ctxSnappingNone";
            this.ctxSnappingNone.Size = new System.Drawing.Size(124, 22);
            this.ctxSnappingNone.Text = "没有图层";
            // 
            // ctxHighlighting
            // 
            this.ctxHighlighting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHighlightNone,
            this.mnuHighlightCurrent,
            this.mnuHighlightAll});
            this.ctxHighlighting.Name = "ctxHighlighting";
            this.ctxHighlighting.Size = new System.Drawing.Size(160, 26);
            this.ctxHighlighting.Text = "高亮";
            // 
            // mnuHighlightNone
            // 
            this.mnuHighlightNone.Name = "mnuHighlightNone";
            this.mnuHighlightNone.Size = new System.Drawing.Size(124, 22);
            this.mnuHighlightNone.Text = "没有图层";
            // 
            // mnuHighlightCurrent
            // 
            this.mnuHighlightCurrent.Name = "mnuHighlightCurrent";
            this.mnuHighlightCurrent.Size = new System.Drawing.Size(124, 22);
            this.mnuHighlightCurrent.Text = "当前图层";
            // 
            // mnuHighlightAll
            // 
            this.mnuHighlightAll.Name = "mnuHighlightAll";
            this.mnuHighlightAll.Size = new System.Drawing.Size(124, 22);
            this.mnuHighlightAll.Text = "所有图层";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(157, 6);
            // 
            // ctxSaveShape
            // 
            this.ctxSaveShape.Name = "ctxSaveShape";
            this.ctxSaveShape.Size = new System.Drawing.Size(160, 26);
            this.ctxSaveShape.Text = "保存更改";
            // 
            // ctxClearEditor
            // 
            this.ctxClearEditor.Name = "ctxClearEditor";
            this.ctxClearEditor.Size = new System.Drawing.Size(160, 26);
            this.ctxClearEditor.Text = "放弃更改";
            // 
            // ContextMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ContextMenuView";
            this.Size = new System.Drawing.Size(150, 138);
            this.contextDigitizing.ResumeLayout(false);
            this.contextSelection.ResumeLayout(false);
            this.contextVertex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextDigitizing;
        private System.Windows.Forms.ToolStripMenuItem ctxSnapNone;
        private System.Windows.Forms.ToolStripMenuItem ctxSnapCurrent;
        private System.Windows.Forms.ToolStripMenuItem ctxSnapAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctxHighlightNone;
        private System.Windows.Forms.ToolStripMenuItem ctxHighlightCurrent;
        private System.Windows.Forms.ToolStripMenuItem ctxHighlightAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxFinishShape;
        private System.Windows.Forms.ToolStripMenuItem ctxCancelShape;
        private System.Windows.Forms.ToolStripMenuItem ctxUndoPoint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip contextSelection;
        private System.Windows.Forms.ToolStripMenuItem ctxSelectByRectangle;
        private System.Windows.Forms.ToolStripMenuItem ctxClearSelection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ctxSplitShapes;
        private System.Windows.Forms.ToolStripMenuItem ctxMergeShapes;
        private System.Windows.Forms.ToolStripMenuItem ctxRotateShapes;
        private System.Windows.Forms.ToolStripMenuItem ctxMoveShapes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxCut;
        private System.Windows.Forms.ToolStripMenuItem ctxPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ctxRemoveShapes;
        private System.Windows.Forms.ContextMenuStrip contextVertex;
        private System.Windows.Forms.ToolStripMenuItem ctxUndo;
        private System.Windows.Forms.ToolStripSeparator digitizerSeparator;
        private System.Windows.Forms.ToolStripMenuItem ctxVertexEditor;
        private System.Windows.Forms.ToolStripMenuItem ctxPartEditor;
        private System.Windows.Forms.ToolStripSeparator editorSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctxAddPart;
        private System.Windows.Forms.ToolStripMenuItem ctxRemovePart;
        private System.Windows.Forms.ToolStripSeparator editorSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxSnapping;
        private System.Windows.Forms.ToolStripMenuItem ctxHighlighting;
        private System.Windows.Forms.ToolStripMenuItem mnuHighlightNone;
        private System.Windows.Forms.ToolStripMenuItem mnuHighlightCurrent;
        private System.Windows.Forms.ToolStripMenuItem mnuHighlightAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveShape;
        private System.Windows.Forms.ToolStripMenuItem ctxClearEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmSnapMode;
        private System.Windows.Forms.ToolStripMenuItem ctxSnapToVertices;
        private System.Windows.Forms.ToolStripMenuItem ctxSnapToLines;
        private System.Windows.Forms.ToolStripMenuItem ctxSnapToLinesAndVertices;
        private System.Windows.Forms.ToolStripMenuItem snapSourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctxSnappingAll;
        private System.Windows.Forms.ToolStripMenuItem ctxSnappingCurrent;
        private System.Windows.Forms.ToolStripMenuItem ctxSnappingNone;
        private System.Windows.Forms.ToolStripMenuItem ctxEditLineJoin;
        private System.Windows.Forms.ToolStripMenuItem ctxEditLineInvert;
        private System.Windows.Forms.ToolStripMenuItem ctxEditLineExpand;
    }
}
