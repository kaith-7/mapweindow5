using MW5.UI.Controls;

namespace MW5.Views
{
    partial class WelcomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeView));
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.picureLogo = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lbProject3 = new MW5.UI.Controls.LinkLabelEx();
            this.lbProject2 = new MW5.UI.Controls.LinkLabelEx();
            this.lbProject1 = new MW5.UI.Controls.LinkLabelEx();
            this.chkShowDlg = new System.Windows.Forms.CheckBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbOpenProject = new MW5.UI.Controls.LinkLabelEx();
            this.lbAddData = new MW5.UI.Controls.LinkLabelEx();
            ((System.ComponentModel.ISupportInitialize)(this.picureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(93, 27);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.ThemeName = "Metro";
            // 
            // picureLogo
            // 
            resources.ApplyResources(this.picureLogo, "picureLogo");
            this.picureLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picureLogo.Image = global::MW5.Properties.Resources.img_suntoongis_view;
            this.picureLogo.Name = "picureLogo";
            this.picureLogo.TabStop = false;
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // lbProject3
            // 
            resources.ApplyResources(this.lbProject3, "lbProject3");
            this.lbProject3.Name = "lbProject3";
            this.lbProject3.TabStop = true;
            this.lbProject3.Tag = "2";
            this.lbProject3.Click += new System.EventHandler(this.OnRecentProjectClick);
            // 
            // lbProject2
            // 
            resources.ApplyResources(this.lbProject2, "lbProject2");
            this.lbProject2.Name = "lbProject2";
            this.lbProject2.TabStop = true;
            this.lbProject2.Tag = "1";
            this.lbProject2.Click += new System.EventHandler(this.OnRecentProjectClick);
            // 
            // lbProject1
            // 
            resources.ApplyResources(this.lbProject1, "lbProject1");
            this.lbProject1.Name = "lbProject1";
            this.lbProject1.TabStop = true;
            this.lbProject1.Tag = "0";
            this.lbProject1.Click += new System.EventHandler(this.OnRecentProjectClick);
            // 
            // chkShowDlg
            // 
            resources.ApplyResources(this.chkShowDlg, "chkShowDlg");
            this.chkShowDlg.Checked = true;
            this.chkShowDlg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDlg.Name = "chkShowDlg";
            this.chkShowDlg.CheckedChanged += new System.EventHandler(this.cbShowDlg_CheckedChanged);
            // 
            // PictureBox3
            // 
            resources.ApplyResources(this.PictureBox3, "PictureBox3");
            this.PictureBox3.Image = global::MW5.Properties.Resources.icon_folder;
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            resources.ApplyResources(this.PictureBox2, "PictureBox2");
            this.PictureBox2.Image = global::MW5.Properties.Resources.icon_layer_add;
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.TabStop = false;
            // 
            // lbOpenProject
            // 
            resources.ApplyResources(this.lbOpenProject, "lbOpenProject");
            this.lbOpenProject.Name = "lbOpenProject";
            this.lbOpenProject.TabStop = true;
            this.lbOpenProject.UseCompatibleTextRendering = true;
            // 
            // lbAddData
            // 
            resources.ApplyResources(this.lbAddData, "lbAddData");
            this.lbAddData.Name = "lbAddData";
            this.lbAddData.TabStop = true;
            // 
            // WelcomeView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.picureLogo);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lbProject3);
            this.Controls.Add(this.lbProject2);
            this.Controls.Add(this.lbProject1);
            this.Controls.Add(this.chkShowDlg);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.lbOpenProject);
            this.Controls.Add(this.lbAddData);
            this.Controls.Add(this.btnClose);
            this.Name = "WelcomeView";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WelcomeView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        internal System.Windows.Forms.PictureBox picureLogo;
        internal System.Windows.Forms.Label lblVersion;
        internal LinkLabelEx lbProject3;
        internal LinkLabelEx lbProject2;
        internal LinkLabelEx lbProject1;
        internal System.Windows.Forms.CheckBox chkShowDlg;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal LinkLabelEx lbOpenProject;
        internal LinkLabelEx lbAddData;
    }
}