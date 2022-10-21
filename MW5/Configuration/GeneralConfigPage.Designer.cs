using System.Windows.Forms;

namespace MW5.Configuration
{
    partial class GeneralConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralConfigPage));
            this.configPanelControl3 = new MW5.UI.Controls.ConfigPanelControl();
            this.chkLocalDocumentation = new System.Windows.Forms.CheckBox();
            this.chkShowMenuToolTips = new System.Windows.Forms.CheckBox();
            this.chkShowPluginInToolTip = new System.Windows.Forms.CheckBox();
            this.chkDynamicVisibilityWarnings = new System.Windows.Forms.CheckBox();
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSymbologyStorage = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkLoadSymbology = new System.Windows.Forms.CheckBox();
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            this.chkNewVersion = new System.Windows.Forms.CheckBox();
            this.chkShowWelcomeDialog = new System.Windows.Forms.CheckBox();
            this.chkLoadLastProject = new System.Windows.Forms.CheckBox();
            this.configPanelControl4 = new MW5.UI.Controls.ConfigPanelControl();
            this.chkLegendExpanded = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).BeginInit();
            this.configPanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSymbologyStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl4)).BeginInit();
            this.configPanelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // configPanelControl3
            // 
            resources.ApplyResources(this.configPanelControl3, "configPanelControl3");
            this.configPanelControl3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl3.Controls.Add(this.chkLocalDocumentation);
            this.configPanelControl3.Controls.Add(this.chkShowMenuToolTips);
            this.configPanelControl3.Controls.Add(this.chkShowPluginInToolTip);
            this.configPanelControl3.HeaderText = "其它选项";
            this.configPanelControl3.Name = "configPanelControl3";
            // 
            // chkLocalDocumentation
            // 
            resources.ApplyResources(this.chkLocalDocumentation, "chkLocalDocumentation");
            this.chkLocalDocumentation.Name = "chkLocalDocumentation";
            // 
            // chkShowMenuToolTips
            // 
            resources.ApplyResources(this.chkShowMenuToolTips, "chkShowMenuToolTips");
            this.chkShowMenuToolTips.Name = "chkShowMenuToolTips";
            // 
            // chkShowPluginInToolTip
            // 
            resources.ApplyResources(this.chkShowPluginInToolTip, "chkShowPluginInToolTip");
            this.chkShowPluginInToolTip.Name = "chkShowPluginInToolTip";
            // 
            // chkDynamicVisibilityWarnings
            // 
            resources.ApplyResources(this.chkDynamicVisibilityWarnings, "chkDynamicVisibilityWarnings");
            this.chkDynamicVisibilityWarnings.Name = "chkDynamicVisibilityWarnings";
            // 
            // configPanelControl1
            // 
            resources.ApplyResources(this.configPanelControl1, "configPanelControl1");
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.label1);
            this.configPanelControl1.Controls.Add(this.cboSymbologyStorage);
            this.configPanelControl1.Controls.Add(this.chkLoadSymbology);
            this.configPanelControl1.HeaderText = "符号";
            this.configPanelControl1.Name = "configPanelControl1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboSymbologyStorage
            // 
            resources.ApplyResources(this.cboSymbologyStorage, "cboSymbologyStorage");
            this.cboSymbologyStorage.BeforeTouchSize = new System.Drawing.Size(189, 21);
            this.cboSymbologyStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymbologyStorage.Name = "cboSymbologyStorage";
            // 
            // chkLoadSymbology
            // 
            resources.ApplyResources(this.chkLoadSymbology, "chkLoadSymbology");
            this.chkLoadSymbology.Name = "chkLoadSymbology";
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.chkNewVersion);
            this.configPanelControl2.Controls.Add(this.chkShowWelcomeDialog);
            this.configPanelControl2.Controls.Add(this.chkLoadLastProject);
            this.configPanelControl2.HeaderText = "启动";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // chkNewVersion
            // 
            resources.ApplyResources(this.chkNewVersion, "chkNewVersion");
            this.chkNewVersion.Name = "chkNewVersion";
            // 
            // chkShowWelcomeDialog
            // 
            resources.ApplyResources(this.chkShowWelcomeDialog, "chkShowWelcomeDialog");
            this.chkShowWelcomeDialog.Name = "chkShowWelcomeDialog";
            // 
            // chkLoadLastProject
            // 
            resources.ApplyResources(this.chkLoadLastProject, "chkLoadLastProject");
            this.chkLoadLastProject.Name = "chkLoadLastProject";
            // 
            // configPanelControl4
            // 
            resources.ApplyResources(this.configPanelControl4, "configPanelControl4");
            this.configPanelControl4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl4.Controls.Add(this.chkLegendExpanded);
            this.configPanelControl4.Controls.Add(this.chkDynamicVisibilityWarnings);
            this.configPanelControl4.HeaderText = "显示选项";
            this.configPanelControl4.Name = "configPanelControl4";
            // 
            // chkLegendExpanded
            // 
            resources.ApplyResources(this.chkLegendExpanded, "chkLegendExpanded");
            this.chkLegendExpanded.Name = "chkLegendExpanded";
            // 
            // GeneralConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.configPanelControl3);
            this.Controls.Add(this.configPanelControl4);
            this.Controls.Add(this.configPanelControl1);
            this.Controls.Add(this.configPanelControl2);
            this.Name = "GeneralConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).EndInit();
            this.configPanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            this.configPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSymbologyStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl4)).EndInit();
            this.configPanelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.ConfigPanelControl configPanelControl2;
        private CheckBox chkLoadSymbology;
        private CheckBox chkLoadLastProject;
        private CheckBox chkShowWelcomeDialog;
        private UI.Controls.ConfigPanelControl configPanelControl1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboSymbologyStorage;
        private UI.Controls.ConfigPanelControl configPanelControl3;
        private CheckBox chkShowPluginInToolTip;
        private CheckBox chkShowMenuToolTips;
        private CheckBox chkDynamicVisibilityWarnings;
        private CheckBox chkLocalDocumentation;
        private CheckBox chkNewVersion;
        private UI.Controls.ConfigPanelControl configPanelControl4;
        private CheckBox chkLegendExpanded;

    }
}
