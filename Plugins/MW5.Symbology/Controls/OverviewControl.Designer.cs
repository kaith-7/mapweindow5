namespace MW5.Plugins.Symbology.Controls
{
    partial class OverviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewControl));
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.cboCompression = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this._overviewGrid1 = new MW5.Plugins.Symbology.Controls.OverviewGrid();
            this.btnClearOverviews = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuildOverviews = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboOverviewType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboOverviewSampling = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._overviewGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewSampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // configPanelControl1
            // 
            resources.ApplyResources(this.configPanelControl1, "configPanelControl1");
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.cboCompression);
            this.configPanelControl1.Controls.Add(this.label1);
            this.configPanelControl1.Controls.Add(this._overviewGrid1);
            this.configPanelControl1.Controls.Add(this.btnClearOverviews);
            this.configPanelControl1.Controls.Add(this.label8);
            this.configPanelControl1.Controls.Add(this.btnBuildOverviews);
            this.configPanelControl1.Controls.Add(this.cboOverviewType);
            this.configPanelControl1.Controls.Add(this.label6);
            this.configPanelControl1.Controls.Add(this.label10);
            this.configPanelControl1.Controls.Add(this.cboOverviewSampling);
            this.configPanelControl1.HeaderText = "生成金字塔";
            this.configPanelControl1.Name = "configPanelControl1";
            // 
            // cboCompression
            // 
            this.cboCompression.BeforeTouchSize = new System.Drawing.Size(224, 21);
            this.cboCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboCompression, "cboCompression");
            this.cboCompression.Name = "cboCompression";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // _overviewGrid1
            // 
            this._overviewGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this._overviewGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            resources.ApplyResources(this._overviewGrid1, "_overviewGrid1");
            this._overviewGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._overviewGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._overviewGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._overviewGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this._overviewGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this._overviewGrid1.BackColor = System.Drawing.SystemColors.Window;
            this._overviewGrid1.GridLineColor = System.Drawing.Color.White;
            this._overviewGrid1.Name = "_overviewGrid1";
            this._overviewGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this._overviewGrid1.ShowRowHeaders = false;
            this._overviewGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this._overviewGrid1.TableOptions.AllowDropDownCell = true;
            this._overviewGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this._overviewGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this._overviewGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this._overviewGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this._overviewGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this._overviewGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this._overviewGrid1.TopLevelGroupOptions.ShowCaption = false;
            this._overviewGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this._overviewGrid1.UseRightToLeftCompatibleTextBox = true;
            this._overviewGrid1.VersionInfo = "0.0.1.0";
            this._overviewGrid1.WrapWithPanel = true;
            // 
            // btnClearOverviews
            // 
            this.btnClearOverviews.BeforeTouchSize = new System.Drawing.Size(75, 21);
            resources.ApplyResources(this.btnClearOverviews, "btnClearOverviews");
            this.btnClearOverviews.Name = "btnClearOverviews";
            this.btnClearOverviews.Click += new System.EventHandler(this.btnClearOverviews_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnBuildOverviews
            // 
            this.btnBuildOverviews.BeforeTouchSize = new System.Drawing.Size(75, 21);
            resources.ApplyResources(this.btnBuildOverviews, "btnBuildOverviews");
            this.btnBuildOverviews.Name = "btnBuildOverviews";
            this.btnBuildOverviews.Click += new System.EventHandler(this.btnBuildOverviews_Click);
            // 
            // cboOverviewType
            // 
            this.cboOverviewType.BeforeTouchSize = new System.Drawing.Size(223, 21);
            this.cboOverviewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboOverviewType, "cboOverviewType");
            this.cboOverviewType.Name = "cboOverviewType";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cboOverviewSampling
            // 
            this.cboOverviewSampling.BeforeTouchSize = new System.Drawing.Size(224, 21);
            this.cboOverviewSampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboOverviewSampling, "cboOverviewSampling");
            this.cboOverviewSampling.Name = "cboOverviewSampling";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.configPanelControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // OverviewControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OverviewControl";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            this.configPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._overviewGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewSampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ConfigPanelControl configPanelControl1;
        private Syncfusion.Windows.Forms.ButtonAdv btnClearOverviews;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.ButtonAdv btnBuildOverviews;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboOverviewType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboOverviewSampling;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboCompression;
        private System.Windows.Forms.Label label1;
        private OverviewGrid _overviewGrid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
