using MW5.UI.Controls;
using Syncfusion.Windows.Forms;

namespace MW5.Plugins.Printing.Views
{
    partial class TableView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableView));
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabData = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabColumns = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.udRelWidth = new System.Windows.Forms.NumericUpDown();
            this.optRelative = new System.Windows.Forms.RadioButton();
            this.optAuto = new System.Windows.Forms.RadioButton();
            this.optFixed = new System.Windows.Forms.RadioButton();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.listBoxColumns = new MW5.UI.Controls.ListBoxEx();
            this.btnRemoveField = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAddField = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnApply = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabColumns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRelWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(81, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ThemeName = "Metro";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(84, 24);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(580, 350);
            this.tabControlAdv1.Controls.Add(this.tabData);
            this.tabControlAdv1.Controls.Add(this.tabColumns);
            this.tabControlAdv1.Name = "tabControlAdv1";
            // 
            // tabData
            // 
            resources.ApplyResources(this.tabData, "tabData");
            this.tabData.Controls.Add(this.dataGridView1);
            this.tabData.Image = null;
            this.tabData.ImageSize = new System.Drawing.Size(16, 16);
            this.tabData.Name = "tabData";
            this.tabData.ShowCloseButton = true;
            this.tabData.ThemesEnabled = false;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            // 
            // tabColumns
            // 
            resources.ApplyResources(this.tabColumns, "tabColumns");
            this.tabColumns.Controls.Add(this.groupBox1);
            this.tabColumns.Controls.Add(this.listBoxColumns);
            this.tabColumns.Controls.Add(this.btnRemoveField);
            this.tabColumns.Controls.Add(this.btnAddField);
            this.tabColumns.Image = null;
            this.tabColumns.ImageSize = new System.Drawing.Size(16, 16);
            this.tabColumns.Name = "tabColumns";
            this.tabColumns.ShowCloseButton = true;
            this.tabColumns.ThemesEnabled = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lblPercent);
            this.groupBox1.Controls.Add(this.udRelWidth);
            this.groupBox1.Controls.Add(this.optRelative);
            this.groupBox1.Controls.Add(this.optAuto);
            this.groupBox1.Controls.Add(this.optFixed);
            this.groupBox1.Controls.Add(this.udWidth);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblPercent
            // 
            resources.ApplyResources(this.lblPercent, "lblPercent");
            this.lblPercent.Name = "lblPercent";
            // 
            // udRelWidth
            // 
            resources.ApplyResources(this.udRelWidth, "udRelWidth");
            this.udRelWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRelWidth.Name = "udRelWidth";
            this.udRelWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // optRelative
            // 
            resources.ApplyResources(this.optRelative, "optRelative");
            this.optRelative.Name = "optRelative";
            this.optRelative.UseVisualStyleBackColor = true;
            // 
            // optAuto
            // 
            resources.ApplyResources(this.optAuto, "optAuto");
            this.optAuto.Checked = true;
            this.optAuto.Name = "optAuto";
            this.optAuto.TabStop = true;
            this.optAuto.UseVisualStyleBackColor = true;
            // 
            // optFixed
            // 
            resources.ApplyResources(this.optFixed, "optFixed");
            this.optFixed.Name = "optFixed";
            this.optFixed.UseVisualStyleBackColor = true;
            // 
            // udWidth
            // 
            resources.ApplyResources(this.udWidth, "udWidth");
            this.udWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.udWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udWidth.Name = "udWidth";
            this.udWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxColumns
            // 
            resources.ApplyResources(this.listBoxColumns, "listBoxColumns");
            this.listBoxColumns.Alignment = System.Drawing.StringAlignment.Center;
            this.listBoxColumns.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxColumns.FormattingEnabled = true;
            this.listBoxColumns.Name = "listBoxColumns";
            this.listBoxColumns.SelectedIndexChanged += new System.EventHandler(this.OnSelectedColumnChanged);
            // 
            // btnRemoveField
            // 
            resources.ApplyResources(this.btnRemoveField, "btnRemoveField");
            this.btnRemoveField.BeforeTouchSize = new System.Drawing.Size(90, 22);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.UseVisualStyleBackColor = true;
            this.btnRemoveField.Click += new System.EventHandler(this.OnRemoveField);
            // 
            // btnAddField
            // 
            resources.ApplyResources(this.btnAddField, "btnAddField");
            this.btnAddField.BeforeTouchSize = new System.Drawing.Size(90, 22);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.OnAddField);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnApply.BeforeTouchSize = new System.Drawing.Size(84, 24);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Name = "btnApply";
            this.btnApply.ThemeName = "Metro";
            // 
            // TableView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "TableView";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabColumns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRelWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabData;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabColumns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.NumericUpDown udRelWidth;
        private System.Windows.Forms.RadioButton optRelative;
        private System.Windows.Forms.RadioButton optAuto;
        private System.Windows.Forms.RadioButton optFixed;
        private System.Windows.Forms.NumericUpDown udWidth;
        private ListBoxEx listBoxColumns;
        private ButtonAdv btnRemoveField;
        private ButtonAdv btnAddField;
        private Syncfusion.Windows.Forms.ButtonAdv btnApply;
    }
}