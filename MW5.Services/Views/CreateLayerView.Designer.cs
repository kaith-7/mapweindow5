namespace MW5.Services.Views
{
    partial class CreateLayerView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLayerView));
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            this.btnChooseCRS = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.label1 = new System.Windows.Forms.Label();
            this._layerNameTextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this._layerTypeComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this._okButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this._cancelButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.opt2D = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.optZ = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.optM = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.chkMemoryLayer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataDict = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonDataDict = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this._layerNameTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._layerTypeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opt2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDict)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseCRS
            // 
            resources.ApplyResources(this.btnChooseCRS, "btnChooseCRS");
            this.btnChooseCRS.BeforeTouchSize = new System.Drawing.Size(319, 23);
            this.btnChooseCRS.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.btnChooseCRS.ForeColor = System.Drawing.Color.Black;
            this.btnChooseCRS.Name = "btnChooseCRS";
            splitButtonRenderer1.SplitButton = this.btnChooseCRS;
            this.btnChooseCRS.Renderer = splitButtonRenderer1;
            this.btnChooseCRS.ShowDropDownOnButtonClick = false;
            this.btnChooseCRS.DropDowItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnChooseCRS_DropDowItemClicked);
            this.btnChooseCRS.Click += new System.EventHandler(this.btnChooseCRS_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // _layerNameTextbox
            // 
            resources.ApplyResources(this._layerNameTextbox, "_layerNameTextbox");
            this._layerNameTextbox.BeforeTouchSize = new System.Drawing.Size(279, 21);
            this._layerNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._layerNameTextbox.Name = "_layerNameTextbox";
            this._layerNameTextbox.ThemeName = "Default";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // _layerTypeComboBox
            // 
            resources.ApplyResources(this._layerTypeComboBox, "_layerTypeComboBox");
            this._layerTypeComboBox.BeforeTouchSize = new System.Drawing.Size(319, 21);
            this._layerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._layerTypeComboBox.Name = "_layerTypeComboBox";
            this._layerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this._layerTypeComboBox_SelectedIndexChanged);
            // 
            // _okButton
            // 
            resources.ApplyResources(this._okButton, "_okButton");
            this._okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this._okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this._okButton.BeforeTouchSize = new System.Drawing.Size(76, 25);
            this._okButton.ForeColor = System.Drawing.Color.White;
            this._okButton.Name = "_okButton";
            this._okButton.ThemeName = "Metro";
            this._okButton.UseVisualStyle = false;
            // 
            // _cancelButton
            // 
            resources.ApplyResources(this._cancelButton, "_cancelButton");
            this._cancelButton.BeforeTouchSize = new System.Drawing.Size(76, 25);
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Name = "_cancelButton";
            // 
            // opt2D
            // 
            resources.ApplyResources(this.opt2D, "opt2D");
            this.opt2D.BeforeTouchSize = new System.Drawing.Size(71, 19);
            this.opt2D.Checked = true;
            this.opt2D.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.opt2D.Name = "opt2D";
            // 
            // optZ
            // 
            resources.ApplyResources(this.optZ, "optZ");
            this.optZ.BeforeTouchSize = new System.Drawing.Size(48, 19);
            this.optZ.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.optZ.Name = "optZ";
            this.optZ.TabStop = false;
            // 
            // optM
            // 
            resources.ApplyResources(this.optM, "optM");
            this.optM.BeforeTouchSize = new System.Drawing.Size(48, 19);
            this.optM.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.optM.Name = "optM";
            this.optM.TabStop = false;
            // 
            // chkMemoryLayer
            // 
            resources.ApplyResources(this.chkMemoryLayer, "chkMemoryLayer");
            this.chkMemoryLayer.Name = "chkMemoryLayer";
            this.chkMemoryLayer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtDataDict
            // 
            resources.ApplyResources(this.txtDataDict, "txtDataDict");
            this.txtDataDict.BeforeTouchSize = new System.Drawing.Size(279, 21);
            this.txtDataDict.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataDict.Name = "txtDataDict";
            this.txtDataDict.ThemeName = "Default";
            // 
            // buttonDataDict
            // 
            resources.ApplyResources(this.buttonDataDict, "buttonDataDict");
            this.buttonDataDict.BeforeTouchSize = new System.Drawing.Size(38, 25);
            this.buttonDataDict.Name = "buttonDataDict";
            this.buttonDataDict.Click += new System.EventHandler(this.buttonDataDict_Click);
            // 
            // CreateLayerView
            // 
            this.AcceptButton = this._okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.buttonDataDict);
            this.Controls.Add(this.txtDataDict);
            this.Controls.Add(this.btnChooseCRS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkMemoryLayer);
            this.Controls.Add(this.optM);
            this.Controls.Add(this.optZ);
            this.Controls.Add(this.opt2D);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._layerTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._layerNameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "CreateLayerView";
            ((System.ComponentModel.ISupportInitialize)(this._layerNameTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._layerTypeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opt2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt _layerNameTextbox;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv _layerTypeComboBox;
        private Syncfusion.Windows.Forms.ButtonAdv _okButton;
        private Syncfusion.Windows.Forms.ButtonAdv _cancelButton;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv opt2D;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv optZ;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv optM;
        private System.Windows.Forms.CheckBox chkMemoryLayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnChooseCRS;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDataDict;
        private Syncfusion.Windows.Forms.ButtonAdv buttonDataDict;
    }
}