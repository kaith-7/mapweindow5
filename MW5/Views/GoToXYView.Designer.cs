namespace MW5.Views
{
    partial class GoToXYView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolPanToXY = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton_GoToXY = new System.Windows.Forms.ToolStripButton();
            this.doubleTextBox_Y = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.doubleTextBox_X = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox_X)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // toolPanToXY
            // 
            this.toolPanToXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPanToXY.Image = global::MW5.Properties.Resources.icon_pan;
            this.toolPanToXY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPanToXY.Name = "toolPanToXY";
            this.toolPanToXY.Size = new System.Drawing.Size(23, 22);
            this.toolPanToXY.Text = "定位到坐标";
            this.toolPanToXY.ToolTipText = "定位到坐标";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_GoToXY});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.Size = new System.Drawing.Size(278, 25);
            this.toolStripEx1.TabIndex = 5;
            this.toolStripEx1.Text = "工具";
            // 
            // toolStripButton_GoToXY
            // 
            this.toolStripButton_GoToXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_GoToXY.Image = global::MW5.Properties.Resources.icon_pan;
            this.toolStripButton_GoToXY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_GoToXY.Name = "toolStripButton_GoToXY";
            this.toolStripButton_GoToXY.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_GoToXY.Text = "toolStripButton1";
            // 
            // doubleTextBox_Y
            // 
            this.doubleTextBox_Y.BeforeTouchSize = new System.Drawing.Size(100, 21);
            this.doubleTextBox_Y.DoubleValue = 1D;
            this.doubleTextBox_Y.Location = new System.Drawing.Point(164, 43);
            this.doubleTextBox_Y.Name = "doubleTextBox_Y";
            this.doubleTextBox_Y.Size = new System.Drawing.Size(100, 21);
            this.doubleTextBox_Y.TabIndex = 6;
            this.doubleTextBox_Y.Text = "1.00";
            // 
            // doubleTextBox_X
            // 
            this.doubleTextBox_X.BeforeTouchSize = new System.Drawing.Size(100, 21);
            this.doubleTextBox_X.DoubleValue = 1D;
            this.doubleTextBox_X.Location = new System.Drawing.Point(35, 43);
            this.doubleTextBox_X.Name = "doubleTextBox_X";
            this.doubleTextBox_X.Size = new System.Drawing.Size(100, 21);
            this.doubleTextBox_X.TabIndex = 7;
            this.doubleTextBox_X.Text = "1.00";
            // 
            // GoToXYView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(278, 73);
            this.Controls.Add(this.doubleTextBox_X);
            this.Controls.Add(this.doubleTextBox_Y);
            this.Controls.Add(this.toolStripEx1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "GoToXYView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "坐标定位";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoToXYView_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.GoToXYView_VisibleChanged);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox_X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripButton_GoToXY;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox doubleTextBox_Y;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox doubleTextBox_X;
        private System.Windows.Forms.ToolStripButton toolPanToXY;
    }
}