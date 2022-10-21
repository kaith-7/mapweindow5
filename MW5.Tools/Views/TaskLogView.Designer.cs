using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Tools.Views
{
    partial class TaskLogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskLogView));
            this.panelLog = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxExt1 = new System.Windows.Forms.TextBox();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.panelProgress = new System.Windows.Forms.GroupBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.btnPause = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.progressBar1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.panelResults = new System.Windows.Forms.Panel();
            this.lblExecutionTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panelLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).BeginInit();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLog
            // 
            resources.ApplyResources(this.panelLog, "panelLog");
            this.panelLog.Controls.Add(this.groupBox1);
            this.panelLog.Controls.Add(this.panelSeparator);
            this.panelLog.Controls.Add(this.panelProgress);
            this.panelLog.Controls.Add(this.panelResults);
            this.panelLog.Name = "panelLog";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.textBoxExt1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBoxExt1
            // 
            resources.ApplyResources(this.textBoxExt1, "textBoxExt1");
            this.textBoxExt1.BackColor = System.Drawing.Color.White;
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.ReadOnly = true;
            // 
            // panelSeparator
            // 
            resources.ApplyResources(this.panelSeparator, "panelSeparator");
            this.panelSeparator.Name = "panelSeparator";
            // 
            // panelProgress
            // 
            resources.ApplyResources(this.panelProgress, "panelProgress");
            this.panelProgress.Controls.Add(this.lblPercent);
            this.panelProgress.Controls.Add(this.lblElapsed);
            this.panelProgress.Controls.Add(this.btnPause);
            this.panelProgress.Controls.Add(this.btnCancel);
            this.panelProgress.Controls.Add(this.progressBar1);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.TabStop = false;
            // 
            // lblPercent
            // 
            resources.ApplyResources(this.lblPercent, "lblPercent");
            this.lblPercent.Name = "lblPercent";
            // 
            // lblElapsed
            // 
            resources.ApplyResources(this.lblElapsed, "lblElapsed");
            this.lblElapsed.Name = "lblElapsed";
            // 
            // btnPause
            // 
            resources.ApplyResources(this.btnPause, "btnPause");
            this.btnPause.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnPause.BeforeTouchSize = new System.Drawing.Size(82, 24);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Name = "btnPause";
            this.btnPause.ThemeName = "Metro";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(82, 24);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ThemeName = "Metro";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.progressBar1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBar1.BackSegments = false;
            this.progressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.progressBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar1.CustomText = null;
            this.progressBar1.CustomWaitingRender = false;
            this.progressBar1.ForegroundImage = null;
            this.progressBar1.ForeSegments = false;
            this.progressBar1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.SegmentWidth = 12;
            this.progressBar1.Value = 0;
            this.progressBar1.WaitingGradientWidth = 400;
            // 
            // panelResults
            // 
            resources.ApplyResources(this.panelResults, "panelResults");
            this.panelResults.Controls.Add(this.lblExecutionTime);
            this.panelResults.Controls.Add(this.lblStatus);
            this.panelResults.Controls.Add(this.pictureBox1);
            this.panelResults.Name = "panelResults";
            // 
            // lblExecutionTime
            // 
            resources.ApplyResources(this.lblExecutionTime, "lblExecutionTime");
            this.lblExecutionTime.Name = "lblExecutionTime";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.ThemeName = "Metro";
            // 
            // TaskLogView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelLog);
            this.Name = "TaskLogView";
            this.panelLog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).EndInit();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLog;
        private ProgressBarAdv progressBar1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExecutionTime;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.GroupBox panelProgress;
        private GroupBox groupBox1;
        private TextBox textBoxExt1;
        private Syncfusion.Windows.Forms.ButtonAdv btnPause;
        private Label lblPercent;
        private Label lblElapsed;
    }
}