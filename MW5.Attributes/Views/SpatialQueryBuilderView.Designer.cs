using MW5.Attributes.Controls;

namespace MW5.Attributes.Views
{
    partial class SpatialQueryBuilderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpatialQueryBuilderView));
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clb_Layers = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_UseSelection = new System.Windows.Forms.CheckBox();
            this.cbo_FilterCondition = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cbo_Result = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox_FilterLayer = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_FilterCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_FilterLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRun.Location = new System.Drawing.Point(111, 335);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(88, 28);
            this.btnRun.TabIndex = 64;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "在下面图层中选取";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(199, 335);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 28);
            this.btnOk.TabIndex = 50;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(287, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clb_Layers
            // 
            this.clb_Layers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_Layers.FormattingEnabled = true;
            this.clb_Layers.Location = new System.Drawing.Point(10, 20);
            this.clb_Layers.Name = "clb_Layers";
            this.clb_Layers.Size = new System.Drawing.Size(366, 148);
            this.clb_Layers.TabIndex = 66;
            this.clb_Layers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Layers_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 68;
            this.label2.Text = "使用";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 70;
            this.label3.Text = "条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 72;
            this.label4.Text = "结果";
            // 
            // cbx_UseSelection
            // 
            this.cbx_UseSelection.AutoSize = true;
            this.cbx_UseSelection.Location = new System.Drawing.Point(10, 217);
            this.cbx_UseSelection.Name = "cbx_UseSelection";
            this.cbx_UseSelection.Size = new System.Drawing.Size(186, 16);
            this.cbx_UseSelection.TabIndex = 73;
            this.cbx_UseSelection.Tag = "使用选中要素(已选中0个要素)";
            this.cbx_UseSelection.Text = "使用选中要素(已选中0个要素)";
            this.cbx_UseSelection.UseVisualStyleBackColor = true;
            // 
            // cbo_FilterCondition
            // 
            this.cbo_FilterCondition.BeforeTouchSize = new System.Drawing.Size(366, 21);
            this.cbo_FilterCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_FilterCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbo_FilterCondition.Location = new System.Drawing.Point(10, 254);
            this.cbo_FilterCondition.Name = "cbo_FilterCondition";
            this.cbo_FilterCondition.Size = new System.Drawing.Size(366, 21);
            this.cbo_FilterCondition.TabIndex = 74;
            // 
            // cbo_Result
            // 
            this.cbo_Result.BeforeTouchSize = new System.Drawing.Size(366, 21);
            this.cbo_Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbo_Result.Location = new System.Drawing.Point(10, 292);
            this.cbo_Result.Name = "cbo_Result";
            this.cbo_Result.Size = new System.Drawing.Size(366, 21);
            this.cbo_Result.TabIndex = 75;
            // 
            // comboBox_FilterLayer
            // 
            this.comboBox_FilterLayer.BeforeTouchSize = new System.Drawing.Size(366, 21);
            this.comboBox_FilterLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FilterLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBox_FilterLayer.Location = new System.Drawing.Point(10, 191);
            this.comboBox_FilterLayer.Name = "comboBox_FilterLayer";
            this.comboBox_FilterLayer.Size = new System.Drawing.Size(366, 21);
            this.comboBox_FilterLayer.TabIndex = 76;
            this.comboBox_FilterLayer.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterLayer_SelectedIndexChanged);
            // 
            // SpatialQueryBuilderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(385, 374);
            this.Controls.Add(this.comboBox_FilterLayer);
            this.Controls.Add(this.cbo_Result);
            this.Controls.Add(this.cbo_FilterCondition);
            this.Controls.Add(this.cbx_UseSelection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clb_Layers);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpatialQueryBuilderView";
            this.Text = "生成查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpatialQueryBuilderView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_FilterCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_FilterLayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckedListBox clb_Layers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbx_UseSelection;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbo_FilterCondition;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbo_Result;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox_FilterLayer;
    }
}