namespace MW5.UI.Forms
{
    partial class CheckBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBoxForm));
            this.lblText = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cmnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkToggleAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            resources.ApplyResources(this.lblText, "lblText");
            this.lblText.Name = "lblText";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            resources.ApplyResources(this.grid, "grid");
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnChecked,
            this.cmnText});
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grid_CellBeginEdit);
            this.grid.CurrentCellDirtyStateChanged += new System.EventHandler(this.grid_CurrentCellDirtyStateChanged);
            // 
            // cmnChecked
            // 
            resources.ApplyResources(this.cmnChecked, "cmnChecked");
            this.cmnChecked.Name = "cmnChecked";
            this.cmnChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmnChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmnText
            // 
            resources.ApplyResources(this.cmnText, "cmnText");
            this.cmnText.Name = "cmnText";
            // 
            // chkToggleAll
            // 
            resources.ApplyResources(this.chkToggleAll, "chkToggleAll");
            this.chkToggleAll.Name = "chkToggleAll";
            this.chkToggleAll.UseVisualStyleBackColor = true;
            this.chkToggleAll.CheckedChanged += new System.EventHandler(this.chkToggleAll_CheckedChanged);
            // 
            // CheckBoxForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.chkToggleAll);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckBoxForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.CheckBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmnChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnText;
        private System.Windows.Forms.CheckBox chkToggleAll;
    }
}