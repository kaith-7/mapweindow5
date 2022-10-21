﻿using MW5.Api.Enums;
using MW5.Api.Map;

namespace MW5.Controls
{
    partial class LocatorDockPanel
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
            MW5.Api.Concrete.Envelope envelope1 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference1 = new MW5.Api.Concrete.SpatialReference();
            this.mapControl1 = new MW5.Api.Map.MapControl();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.btnDisplayBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpdateFull = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.AllowDrop = true;
            this.mapControl1.AnimationOnZooming = MW5.Api.Enums.AutoToggle.Auto;
            this.mapControl1.BackColor = System.Drawing.Color.White;
            this.mapControl1.BackgroundColor = System.Drawing.Color.White;
            this.mapControl1.ContextMenuStrip = this.contextMenuStripEx1;
            this.mapControl1.CurrentScale = 21.133078334935735D;
            this.mapControl1.CurrentZoom = -1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.ExpandLayersOnAdding = true;
            this.mapControl1.ExtentHistory = 20;
            this.mapControl1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this.mapControl1.Extents = envelope1;
            this.mapControl1.GrabProjectionFromData = true;
            this.mapControl1.InertiaOnPanning = MW5.Api.Enums.AutoToggle.Auto;
            this.mapControl1.KnownExtents = MW5.Api.Enums.KnownExtents.None;
            this.mapControl1.Latitude = 0F;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Longitude = 0F;
            this.mapControl1.MapCursor = MW5.Api.Enums.MapCursor.ZoomIn;
            this.mapControl1.MapProjection = MW5.Api.Enums.MapProjection.None;
            this.mapControl1.MapUnits = MW5.Api.Enums.LengthUnits.Meters;
            this.mapControl1.MouseWheelSpeed = 0.5D;
            this.mapControl1.Name = "mapControl1";
            spatialReference1.Tag = "";
            this.mapControl1.Projection = spatialReference1;
            this.mapControl1.ResizeBehavior = MW5.Api.Enums.ResizeBehavior.Classic;
            this.mapControl1.ReuseTileBuffer = true;
            this.mapControl1.ScalebarUnits = MW5.Api.Enums.ScalebarUnits.GoogleStyle;
            this.mapControl1.ScalebarVisible = true;
            this.mapControl1.ShowCoordinates = MW5.Api.Enums.CoordinatesDisplay.Auto;
            this.mapControl1.ShowCoordinatesFormat = MW5.Api.Enums.AngleFormat.Degrees;
            this.mapControl1.ShowRedrawTime = false;
            this.mapControl1.ShowVersionNumber = false;
            this.mapControl1.Size = new System.Drawing.Size(293, 301);
            this.mapControl1.SystemCursor = MW5.Api.Enums.SystemCursor.MapDefault;
            this.mapControl1.TabIndex = 0;
            this.mapControl1.Tag = "";
            this.mapControl1.TileProvider = MW5.Api.Enums.TileProvider.None;
            this.mapControl1.UdCursorHandle = 0;
            this.mapControl1.UseSeamlessPan = false;
            this.mapControl1.ZoomBehavior = MW5.Api.Enums.ZoomBehavior.UseTileLevels;
            this.mapControl1.ZoomBoxStyle = MW5.Api.Enums.ZoomBoxStyle.Blue;
            this.mapControl1.ZoomPercent = 0.3D;
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.DropShadowEnabled = false;
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDisplayBackground,
            this.toolStripSeparator2,
            this.btnUpdateFull,
            this.btnUpdateCurrent,
            this.toolStripSeparator1,
            this.btnClear});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(217, 104);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            // 
            // btnDisplayBackground
            // 
            this.btnDisplayBackground.Name = "btnDisplayBackground";
            this.btnDisplayBackground.Size = new System.Drawing.Size(216, 22);
            this.btnDisplayBackground.Text = "背景可见";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // btnUpdateFull
            // 
            this.btnUpdateFull.Name = "btnUpdateFull";
            this.btnUpdateFull.Size = new System.Drawing.Size(216, 22);
            this.btnUpdateFull.Text = "全范围更新显示";
            // 
            // btnUpdateCurrent
            // 
            this.btnUpdateCurrent.Name = "btnUpdateCurrent";
            this.btnUpdateCurrent.Size = new System.Drawing.Size(216, 22);
            this.btnUpdateCurrent.Text = "当前视图更新显示";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // btnClear
            // 
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(216, 22);
            this.btnClear.Text = "清除";
            // 
            // LocatorDockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl1);
            this.Name = "LocatorDockPanel";
            this.Size = new System.Drawing.Size(293, 301);
            this.contextMenuStripEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MapControl mapControl1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateFull;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateCurrent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnClear;
        private System.Windows.Forms.ToolStripMenuItem btnDisplayBackground;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
