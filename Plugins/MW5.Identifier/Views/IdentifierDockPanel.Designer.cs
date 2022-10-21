using MW5.Plugins.Identifier.Controls;
using MW5.UI.Controls;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.Identifier.Views
{
    partial class IdentifierDockPanel
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
            this._cboIdentifierMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolZoomToShape = new System.Windows.Forms.ToolStripButton();
            this.toolClear = new System.Windows.Forms.ToolStripButton();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this._treeView = new MW5.Plugins.Identifier.Controls.IdentifierTreeView();
            ((System.ComponentModel.ISupportInitialize)(this._cboIdentifierMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cboIdentifierMode
            // 
            this._cboIdentifierMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cboIdentifierMode.BeforeTouchSize = new System.Drawing.Size(213, 21);
            this._cboIdentifierMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboIdentifierMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cboIdentifierMode.Location = new System.Drawing.Point(45, 9);
            this._cboIdentifierMode.Name = "_cboIdentifierMode";
            this._cboIdentifierMode.Size = new System.Drawing.Size(213, 21);
            this._cboIdentifierMode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "模式";
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.Gray;
            this.panel1.BorderSides = System.Windows.Forms.Border3DSide.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._cboIdentifierMode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 35);
            this.panel1.TabIndex = 5;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolZoomToShape,
            this.toolClear});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ShowItemToolTips = true;
            this.toolStripEx1.Size = new System.Drawing.Size(268, 35);
            this.toolStripEx1.TabIndex = 45;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // toolZoomToShape
            // 
            this.toolZoomToShape.Checked = true;
            this.toolZoomToShape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolZoomToShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToShape.Image = global::MW5.Plugins.Identifier.Properties.Resources.icon_zoom_to_layer;
            this.toolZoomToShape.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolZoomToShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToShape.Name = "toolZoomToShape";
            this.toolZoomToShape.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolZoomToShape.Size = new System.Drawing.Size(38, 32);
            this.toolZoomToShape.Text = "Zoom to Shape";
            // 
            // toolClear
            // 
            this.toolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolClear.Image = global::MW5.Plugins.Identifier.Properties.Resources.img_clear24;
            this.toolClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClear.Name = "toolClear";
            this.toolClear.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolClear.Size = new System.Drawing.Size(38, 32);
            this.toolClear.Text = "Clear";
            // 
            // lblEmpty
            // 
            this.lblEmpty.BackColor = System.Drawing.Color.White;
            this.lblEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpty.Location = new System.Drawing.Point(0, 0);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(264, 227);
            this.lblEmpty.TabIndex = 47;
            this.lblEmpty.Text = "No items are identified.";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.CausesValidation = false;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.CausesValidation = false;
            this.splitContainer1.Panel1.Controls.Add(this._treeView);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmpty);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(268, 439);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 48;
            this.splitContainer1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 200);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // _treeView
            // 
            this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeView.HideSelection = false;
            this._treeView.Location = new System.Drawing.Point(0, 0);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(264, 227);
            this._treeView.TabIndex = 48;
            // 
            // IdentifierDockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEx1);
            this.Name = "IdentifierDockPanel";
            this.Size = new System.Drawing.Size(268, 509);
            ((System.ComponentModel.ISupportInitialize)(this._cboIdentifierMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv _cboIdentifierMode;
        private System.Windows.Forms.Label label1;
        private GradientPanel panel1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolClear;
        private System.Windows.Forms.ToolStripButton toolZoomToShape;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private IdentifierTreeView _treeView;
    }
}
