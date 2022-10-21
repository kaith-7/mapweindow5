namespace MW5.Controls
{
    partial class LegendDockPanel
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
            this.legendControl1 = new MW5.Api.Legend.LegendControl(this.components);
            this.contextMenuLayer = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.mnuZoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTableEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCheckLayerAttributes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLabels = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaveStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuGroup = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.mnuAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuZoomToGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGroupProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuLayer.SuspendLayout();
            this.contextMenuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // legendControl1
            // 
            this.legendControl1.BackColor = System.Drawing.Color.White;
            this.legendControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legendControl1.DrawLines = true;
            this.legendControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.legendControl1.Location = new System.Drawing.Point(0, 0);
            this.legendControl1.Map = null;
            this.legendControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.legendControl1.Name = "legendControl1";
            this.legendControl1.SelectedGroupHandle = -1;
            this.legendControl1.SelectedLayer = null;
            this.legendControl1.SelectedLayerHandle = -1;
            this.legendControl1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.legendControl1.ShowGroupIcons = true;
            this.legendControl1.ShowLabels = false;
            this.legendControl1.Size = new System.Drawing.Size(272, 425);
            this.legendControl1.TabIndex = 0;
            // 
            // contextMenuLayer
            // 
            this.contextMenuLayer.DropShadowEnabled = false;
            this.contextMenuLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuZoomToLayer,
            this.toolStripSeparator1,
            this.toolTableEditor,
            this.toolCheckLayerAttributes,
            this.toolLabels,
            this.toolStripSeparator6,
            this.mnuSaveStyle,
            this.mnuLoadStyle,
            this.toolStripSeparator2,
            this.mnuExportLayer,
            this.mnuOpenFileLocation,
            this.mnuRemoveLayer,
            this.toolStripSeparator3,
            this.mnuProperties});
            this.contextMenuLayer.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuLayer.Name = "contextMenuStripEx1";
            this.contextMenuLayer.Size = new System.Drawing.Size(173, 248);
            this.contextMenuLayer.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
            this.contextMenuLayer.ThemeName = "Metro";
            this.contextMenuLayer.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuLayerOpening);
            // 
            // mnuZoomToLayer
            // 
            this.mnuZoomToLayer.Name = "mnuZoomToLayer";
            this.mnuZoomToLayer.Size = new System.Drawing.Size(180, 22);
            this.mnuZoomToLayer.Text = "缩放至图层";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolTableEditor
            // 
            this.toolTableEditor.Name = "toolTableEditor";
            this.toolTableEditor.Size = new System.Drawing.Size(180, 22);
            this.toolTableEditor.Text = "编辑属性表...";
            // 
            // toolCheckLayerAttributes
            // 
            this.toolCheckLayerAttributes.Name = "toolCheckLayerAttributes";
            this.toolCheckLayerAttributes.Size = new System.Drawing.Size(180, 22);
            this.toolCheckLayerAttributes.Text = "属性表检查";
            // 
            // toolLabels
            // 
            this.toolLabels.Name = "toolLabels";
            this.toolLabels.Size = new System.Drawing.Size(180, 22);
            this.toolLabels.Text = "标注...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuSaveStyle
            // 
            this.mnuSaveStyle.Name = "mnuSaveStyle";
            this.mnuSaveStyle.Size = new System.Drawing.Size(180, 22);
            this.mnuSaveStyle.Text = "保存图层样式";
            // 
            // mnuLoadStyle
            // 
            this.mnuLoadStyle.Name = "mnuLoadStyle";
            this.mnuLoadStyle.Size = new System.Drawing.Size(180, 22);
            this.mnuLoadStyle.Text = "加载图层样式";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuOpenFileLocation
            // 
            this.mnuOpenFileLocation.Name = "mnuOpenFileLocation";
            this.mnuOpenFileLocation.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenFileLocation.Text = "打开图层文件位置";
            // 
            // mnuRemoveLayer
            // 
            this.mnuRemoveLayer.Name = "mnuRemoveLayer";
            this.mnuRemoveLayer.Size = new System.Drawing.Size(180, 22);
            this.mnuRemoveLayer.Text = "移除图层";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuProperties
            // 
            this.mnuProperties.Name = "mnuProperties";
            this.mnuProperties.Size = new System.Drawing.Size(180, 22);
            this.mnuProperties.Text = "属性";
            // 
            // contextMenuGroup
            // 
            this.contextMenuGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddGroup,
            this.mnuAddLayer,
            this.toolStripSeparator5,
            this.mnuZoomToGroup,
            this.mnuRemoveGroup,
            this.toolStripSeparator4,
            this.mnuGroupProperties});
            this.contextMenuGroup.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuGroup.Name = "contextMenuGroup";
            this.contextMenuGroup.Size = new System.Drawing.Size(149, 126);
            this.contextMenuGroup.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            this.contextMenuGroup.ThemeName = "Default";
            this.contextMenuGroup.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuGroupOpening);
            // 
            // mnuAddGroup
            // 
            this.mnuAddGroup.Name = "mnuAddGroup";
            this.mnuAddGroup.Size = new System.Drawing.Size(148, 22);
            this.mnuAddGroup.Text = "新建图层组";
            // 
            // mnuAddLayer
            // 
            this.mnuAddLayer.Name = "mnuAddLayer";
            this.mnuAddLayer.Size = new System.Drawing.Size(148, 22);
            this.mnuAddLayer.Text = "添加图层";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(145, 6);
            // 
            // mnuZoomToGroup
            // 
            this.mnuZoomToGroup.Name = "mnuZoomToGroup";
            this.mnuZoomToGroup.Size = new System.Drawing.Size(148, 22);
            this.mnuZoomToGroup.Text = "缩放到图层组";
            // 
            // mnuRemoveGroup
            // 
            this.mnuRemoveGroup.Name = "mnuRemoveGroup";
            this.mnuRemoveGroup.Size = new System.Drawing.Size(148, 22);
            this.mnuRemoveGroup.Text = "移除图层组";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(145, 6);
            // 
            // mnuGroupProperties
            // 
            this.mnuGroupProperties.Name = "mnuGroupProperties";
            this.mnuGroupProperties.Size = new System.Drawing.Size(148, 22);
            this.mnuGroupProperties.Text = "属性";
            // 
            // mnuExportLayer
            // 
            this.mnuExportLayer.Name = "mnuExportLayer";
            this.mnuExportLayer.Size = new System.Drawing.Size(172, 22);
            this.mnuExportLayer.Text = "导出";
            // 
            // LegendDockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.legendControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LegendDockPanel";
            this.Size = new System.Drawing.Size(272, 425);
            this.contextMenuLayer.ResumeLayout(false);
            this.contextMenuGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Api.Legend.LegendControl legendControl1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuLayer;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomToLayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveStyle;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenFileLocation;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveLayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuProperties;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuGroupProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomToGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuAddGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuAddLayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolTableEditor;
        private System.Windows.Forms.ToolStripMenuItem toolLabels;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolCheckLayerAttributes;
        private System.Windows.Forms.ToolStripMenuItem mnuExportLayer;
    }
}
