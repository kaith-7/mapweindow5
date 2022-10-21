namespace MW5.Menu
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
            this.contextMeasuring = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.ctxUndoPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxShowLength = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxShowBearing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMetric = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxAmerican = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxAngleFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDegrees = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMinutes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSeconds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMeasuringProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.contextZooming = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.ctxZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxZoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxZoomToMaxExtents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxScale = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMeasuring.SuspendLayout();
            this.contextZooming.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMeasuring
            // 
            this.contextMeasuring.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxUndoPoint,
            this.toolStripSeparator4,
            this.ctxShowLength,
            this.ctxShowBearing,
            this.toolStripSeparator2,
            this.ctxUnits,
            this.ctxAngleFormat,
            this.toolStripSeparator3,
            this.ctxMeasuringProperties});
            this.contextMeasuring.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMeasuring.Name = "contextMeasuring";
            this.contextMeasuring.Size = new System.Drawing.Size(176, 154);
            this.contextMeasuring.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            // 
            // ctxUndoPoint
            // 
            this.ctxUndoPoint.Name = "ctxUndoPoint";
            this.ctxUndoPoint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ctxUndoPoint.Size = new System.Drawing.Size(175, 22);
            this.ctxUndoPoint.Text = "撤销点";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // ctxShowLength
            // 
            this.ctxShowLength.Name = "ctxShowLength";
            this.ctxShowLength.Size = new System.Drawing.Size(175, 22);
            this.ctxShowLength.Text = "显示距离";
            // 
            // ctxShowBearing
            // 
            this.ctxShowBearing.Name = "ctxShowBearing";
            this.ctxShowBearing.Size = new System.Drawing.Size(175, 22);
            this.ctxShowBearing.Text = "显示方位角";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // ctxUnits
            // 
            this.ctxUnits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMetric,
            this.ctxAmerican});
            this.ctxUnits.Name = "ctxUnits";
            this.ctxUnits.Size = new System.Drawing.Size(175, 22);
            this.ctxUnits.Text = "单位";
            // 
            // ctxMetric
            // 
            this.ctxMetric.Name = "ctxMetric";
            this.ctxMetric.Size = new System.Drawing.Size(152, 22);
            this.ctxMetric.Text = "通用";
            // 
            // ctxAmerican
            // 
            this.ctxAmerican.Name = "ctxAmerican";
            this.ctxAmerican.Size = new System.Drawing.Size(152, 22);
            this.ctxAmerican.Text = "美式";
            // 
            // ctxAngleFormat
            // 
            this.ctxAngleFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDegrees,
            this.ctxMinutes,
            this.ctxSeconds});
            this.ctxAngleFormat.Name = "ctxAngleFormat";
            this.ctxAngleFormat.Size = new System.Drawing.Size(175, 22);
            this.ctxAngleFormat.Text = "角度格式";
            // 
            // ctxDegrees
            // 
            this.ctxDegrees.Name = "ctxDegrees";
            this.ctxDegrees.Size = new System.Drawing.Size(152, 22);
            this.ctxDegrees.Text = "度";
            // 
            // ctxMinutes
            // 
            this.ctxMinutes.Name = "ctxMinutes";
            this.ctxMinutes.Size = new System.Drawing.Size(152, 22);
            this.ctxMinutes.Text = "分";
            // 
            // ctxSeconds
            // 
            this.ctxSeconds.Name = "ctxSeconds";
            this.ctxSeconds.Size = new System.Drawing.Size(152, 22);
            this.ctxSeconds.Text = "秒";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // ctxMeasuringProperties
            // 
            this.ctxMeasuringProperties.Name = "ctxMeasuringProperties";
            this.ctxMeasuringProperties.Size = new System.Drawing.Size(175, 22);
            this.ctxMeasuringProperties.Text = "属性";
            // 
            // contextZooming
            // 
            this.contextZooming.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxZoomIn,
            this.ctxZoomOut,
            this.toolStripSeparator5,
            this.ctxZoomToLayer,
            this.ctxZoomToMaxExtents,
            this.toolStripSeparator1,
            this.ctxScale});
            this.contextZooming.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextZooming.Name = "contextMeasuring";
            this.contextZooming.Size = new System.Drawing.Size(186, 148);
            this.contextZooming.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            // 
            // ctxZoomIn
            // 
            this.ctxZoomIn.Name = "ctxZoomIn";
            this.ctxZoomIn.Size = new System.Drawing.Size(185, 22);
            this.ctxZoomIn.Text = "放大";
            // 
            // ctxZoomOut
            // 
            this.ctxZoomOut.Name = "ctxZoomOut";
            this.ctxZoomOut.Size = new System.Drawing.Size(185, 22);
            this.ctxZoomOut.Text = "缩小";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(182, 6);
            // 
            // ctxZoomToLayer
            // 
            this.ctxZoomToLayer.Name = "ctxZoomToLayer";
            this.ctxZoomToLayer.Size = new System.Drawing.Size(185, 22);
            this.ctxZoomToLayer.Text = "缩放到图层";
            // 
            // ctxZoomToMaxExtents
            // 
            this.ctxZoomToMaxExtents.Name = "ctxZoomToMaxExtents";
            this.ctxZoomToMaxExtents.Size = new System.Drawing.Size(185, 22);
            this.ctxZoomToMaxExtents.Text = "缩放到最大范围";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // ctxScale
            // 
            this.ctxScale.Name = "ctxScale";
            this.ctxScale.Size = new System.Drawing.Size(185, 22);
            this.ctxScale.Text = "比例尺";
            // 
            // ContextMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ContextMenuView";
            this.contextMeasuring.ResumeLayout(false);
            this.contextZooming.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMeasuring;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextZooming;
        private System.Windows.Forms.ToolStripMenuItem ctxUndoPoint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ctxShowLength;
        private System.Windows.Forms.ToolStripMenuItem ctxUnits;
        private System.Windows.Forms.ToolStripMenuItem ctxMetric;
        private System.Windows.Forms.ToolStripMenuItem ctxAmerican;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxShowBearing;
        private System.Windows.Forms.ToolStripMenuItem ctxAngleFormat;
        private System.Windows.Forms.ToolStripMenuItem ctxDegrees;
        private System.Windows.Forms.ToolStripMenuItem ctxMinutes;
        private System.Windows.Forms.ToolStripMenuItem ctxSeconds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ctxMeasuringProperties;
        private System.Windows.Forms.ToolStripMenuItem ctxScale;
        private System.Windows.Forms.ToolStripMenuItem ctxZoomIn;
        private System.Windows.Forms.ToolStripMenuItem ctxZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ctxZoomToLayer;
        private System.Windows.Forms.ToolStripMenuItem ctxZoomToMaxExtents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}
