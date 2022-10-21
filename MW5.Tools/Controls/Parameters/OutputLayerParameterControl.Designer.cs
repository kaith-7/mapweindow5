namespace MW5.Tools.Controls.Parameters
{
    partial class OutputLayerParameterControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputLayerParameterControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAddToMap = new System.Windows.Forms.CheckBox();
            this.chkMemoryLayer = new System.Windows.Forms.CheckBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxExt1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxExt1
            // 
            resources.ApplyResources(this.textBoxExt1, "textBoxExt1");
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(292, 21);
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.ThemeName = "Default";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(27, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.chkAddToMap);
            this.panel1.Controls.Add(this.chkMemoryLayer);
            this.panel1.Controls.Add(this.chkOverwrite);
            this.panel1.Name = "panel1";
            // 
            // chkAddToMap
            // 
            resources.ApplyResources(this.chkAddToMap, "chkAddToMap");
            this.chkAddToMap.Name = "chkAddToMap";
            this.chkAddToMap.UseVisualStyleBackColor = true;
            // 
            // chkMemoryLayer
            // 
            resources.ApplyResources(this.chkMemoryLayer, "chkMemoryLayer");
            this.chkMemoryLayer.Checked = true;
            this.chkMemoryLayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMemoryLayer.Name = "chkMemoryLayer";
            this.chkMemoryLayer.UseVisualStyleBackColor = true;
            this.chkMemoryLayer.CheckedChanged += new System.EventHandler(this.MemoryLayerChecked);
            // 
            // chkOverwrite
            // 
            resources.ApplyResources(this.chkOverwrite, "chkOverwrite");
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            this.chkOverwrite.CheckedChanged += new System.EventHandler(this.OnOverwriteCheckedChanged);
            // 
            // OutputLayerParameterControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OutputLayerParameterControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.ButtonAdv btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkMemoryLayer;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.CheckBox chkAddToMap;
    }
}
