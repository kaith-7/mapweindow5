namespace MW5.Projections.Views
{
    partial class ProjectionMismatchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectionMismatchView));
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnSkip = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnReproject = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDetails = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnIgnore = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkDontShow = new System.Windows.Forms.CheckBox();
            this.chkUseAnswerLater = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblSize
            // 
            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.Name = "lblSize";
            this.toolTip1.SetToolTip(this.lblSize, resources.GetString("lblSize.ToolTip"));
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblFilename
            // 
            resources.ApplyResources(this.lblFilename, "lblFilename");
            this.lblFilename.Name = "lblFilename";
            this.toolTip1.SetToolTip(this.lblFilename, resources.GetString("lblFilename.ToolTip"));
            // 
            // btnSkip
            // 
            resources.ApplyResources(this.btnSkip, "btnSkip");
            this.btnSkip.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnSkip.Name = "btnSkip";
            this.toolTip1.SetToolTip(this.btnSkip, resources.GetString("btnSkip.ToolTip"));
            this.btnSkip.Click += new System.EventHandler(this.OnSkipClick);
            // 
            // btnReproject
            // 
            resources.ApplyResources(this.btnReproject, "btnReproject");
            this.btnReproject.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnReproject.Name = "btnReproject";
            this.toolTip1.SetToolTip(this.btnReproject, resources.GetString("btnReproject.ToolTip"));
            this.btnReproject.Click += new System.EventHandler(this.OnReprojectClick);
            // 
            // btnDetails
            // 
            resources.ApplyResources(this.btnDetails, "btnDetails");
            this.btnDetails.BeforeTouchSize = new System.Drawing.Size(115, 24);
            this.btnDetails.Name = "btnDetails";
            this.toolTip1.SetToolTip(this.btnDetails, resources.GetString("btnDetails.ToolTip"));
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.toolTip1.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIgnore
            // 
            resources.ApplyResources(this.btnIgnore, "btnIgnore");
            this.btnIgnore.BackColor = System.Drawing.Color.White;
            this.btnIgnore.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnIgnore.MetroColor = System.Drawing.Color.White;
            this.btnIgnore.Name = "btnIgnore";
            this.toolTip1.SetToolTip(this.btnIgnore, resources.GetString("btnIgnore.ToolTip"));
            this.btnIgnore.UseVisualStyle = false;
            this.btnIgnore.Click += new System.EventHandler(this.OnIgnoreClick);
            // 
            // chkDontShow
            // 
            resources.ApplyResources(this.chkDontShow, "chkDontShow");
            this.chkDontShow.Name = "chkDontShow";
            this.toolTip1.SetToolTip(this.chkDontShow, resources.GetString("chkDontShow.ToolTip"));
            this.chkDontShow.UseVisualStyleBackColor = true;
            // 
            // chkUseAnswerLater
            // 
            resources.ApplyResources(this.chkUseAnswerLater, "chkUseAnswerLater");
            this.chkUseAnswerLater.Name = "chkUseAnswerLater";
            this.toolTip1.SetToolTip(this.chkUseAnswerLater, resources.GetString("chkUseAnswerLater.ToolTip"));
            this.chkUseAnswerLater.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            this.toolTip1.SetToolTip(this.lblMessage, resources.GetString("lblMessage.ToolTip"));
            // 
            // ProjectionMismatchView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnReproject);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.chkDontShow);
            this.Controls.Add(this.chkUseAnswerLater);
            this.Controls.Add(this.lblMessage);
            this.Name = "ProjectionMismatchView";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFilename;
        private Syncfusion.Windows.Forms.ButtonAdv btnSkip;
        private Syncfusion.Windows.Forms.ButtonAdv btnReproject;
        private Syncfusion.Windows.Forms.ButtonAdv btnDetails;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnIgnore;
        internal System.Windows.Forms.CheckBox chkDontShow;
        internal System.Windows.Forms.CheckBox chkUseAnswerLater;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}