namespace MW5.Tools.Controls.Parameters
{
    partial class BatchOutputParameterControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchOutputParameterControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAddToMap = new System.Windows.Forms.CheckBox();
            this.chkMemoryLayer = new System.Windows.Forms.CheckBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTemplate = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPath = new MW5.UI.Controls.WatermarkTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.chkAddToMap);
            this.panel1.Controls.Add(this.chkMemoryLayer);
            this.panel1.Controls.Add(this.chkOverwrite);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // chkAddToMap
            // 
            resources.ApplyResources(this.chkAddToMap, "chkAddToMap");
            this.chkAddToMap.Name = "chkAddToMap";
            this.toolTip1.SetToolTip(this.chkAddToMap, resources.GetString("chkAddToMap.ToolTip"));
            this.chkAddToMap.UseVisualStyleBackColor = true;
            // 
            // chkMemoryLayer
            // 
            resources.ApplyResources(this.chkMemoryLayer, "chkMemoryLayer");
            this.chkMemoryLayer.Checked = true;
            this.chkMemoryLayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMemoryLayer.Name = "chkMemoryLayer";
            this.toolTip1.SetToolTip(this.chkMemoryLayer, resources.GetString("chkMemoryLayer.ToolTip"));
            this.chkMemoryLayer.UseVisualStyleBackColor = true;
            this.chkMemoryLayer.CheckedChanged += new System.EventHandler(this.MemoryLayerChecked);
            // 
            // chkOverwrite
            // 
            resources.ApplyResources(this.chkOverwrite, "chkOverwrite");
            this.chkOverwrite.Name = "chkOverwrite";
            this.toolTip1.SetToolTip(this.chkOverwrite, resources.GetString("chkOverwrite.ToolTip"));
            this.chkOverwrite.UseVisualStyleBackColor = true;
            this.chkOverwrite.CheckedChanged += new System.EventHandler(this.OnOverwriteCheckedChanged);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(27, 18);
            this.btnSave.Name = "btnSave";
            this.toolTip1.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
            this.btnSave.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.txtTemplate);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // txtTemplate
            // 
            resources.ApplyResources(this.txtTemplate, "txtTemplate");
            this.txtTemplate.BeforeTouchSize = new System.Drawing.Size(268, 21);
            this.txtTemplate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ThemeName = "Default";
            this.toolTip1.SetToolTip(this.txtTemplate, resources.GetString("txtTemplate.ToolTip"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::MW5.Tools.Properties.Resources.img_info20;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.txtPath);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Name = "panel3";
            this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // txtPath
            // 
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.BeforeTouchSize = new System.Drawing.Size(268, 21);
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.Name = "txtPath";
            this.txtPath.ShowClearButton = false;
            this.txtPath.ThemeName = "Default";
            this.toolTip1.SetToolTip(this.txtPath, resources.GetString("txtPath.ToolTip"));
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::MW5.Tools.Properties.Resources.img_info20;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // BatchOutputParameterControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BatchOutputParameterControl";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTemplate;
        private Syncfusion.Windows.Forms.ButtonAdv btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAddToMap;
        private System.Windows.Forms.CheckBox chkMemoryLayer;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UI.Controls.WatermarkTextbox txtPath;
    }
}
