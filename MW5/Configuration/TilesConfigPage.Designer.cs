using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Configuration
{
    partial class TilesConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TilesConfigPage));
            this.configPanelControl3 = new MW5.UI.Controls.ConfigPanelControl();
            this.label9 = new System.Windows.Forms.Label();
            this.chkUseDiskCache = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpen = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxDiskSize = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.btnCreate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.txtDiskSize = new System.Windows.Forms.TextBox();
            this.cboMaxAge = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnClear = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.configPanelControl2 = new MW5.UI.Controls.ConfigPanelControl();
            this.txtProxyUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkAutodetectProxy = new System.Windows.Forms.CheckBox();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.txtProxyPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtProxyAddress = new MW5.UI.Controls.WatermarkTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.chkWmsCaching = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBingAPIKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).BeginInit();
            this.configPanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxDiskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).BeginInit();
            this.configPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // configPanelControl3
            // 
            resources.ApplyResources(this.configPanelControl3, "configPanelControl3");
            this.configPanelControl3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl3.Controls.Add(this.label9);
            this.configPanelControl3.Controls.Add(this.chkUseDiskCache);
            this.configPanelControl3.Controls.Add(this.label4);
            this.configPanelControl3.Controls.Add(this.btnOpen);
            this.configPanelControl3.Controls.Add(this.label2);
            this.configPanelControl3.Controls.Add(this.txtMaxDiskSize);
            this.configPanelControl3.Controls.Add(this.btnCreate);
            this.configPanelControl3.Controls.Add(this.label3);
            this.configPanelControl3.Controls.Add(this.txtFilename);
            this.configPanelControl3.Controls.Add(this.txtDiskSize);
            this.configPanelControl3.Controls.Add(this.cboMaxAge);
            this.configPanelControl3.Controls.Add(this.btnClear);
            this.configPanelControl3.Controls.Add(this.label5);
            this.configPanelControl3.HeaderText = "磁盘缓存";
            this.configPanelControl3.Name = "configPanelControl3";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // chkUseDiskCache
            // 
            resources.ApplyResources(this.chkUseDiskCache, "chkUseDiskCache");
            this.chkUseDiskCache.Name = "chkUseDiskCache";
            this.chkUseDiskCache.UseVisualStyleBackColor = true;
            this.chkUseDiskCache.CheckedChanged += new System.EventHandler(this.RefreshControls);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.BeforeTouchSize = new System.Drawing.Size(65, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtMaxDiskSize
            // 
            resources.ApplyResources(this.txtMaxDiskSize, "txtMaxDiskSize");
            this.txtMaxDiskSize.BeforeTouchSize = new System.Drawing.Size(100, 21);
            this.txtMaxDiskSize.BorderColor = System.Drawing.Color.LightGray;
            this.txtMaxDiskSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxDiskSize.DoubleValue = 1D;
            this.txtMaxDiskSize.Name = "txtMaxDiskSize";
            this.txtMaxDiskSize.NumberDecimalDigits = 1;
            this.txtMaxDiskSize.ThemeName = "Default";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.BeforeTouchSize = new System.Drawing.Size(65, 23);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.OnCreateClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtFilename
            // 
            resources.ApplyResources(this.txtFilename, "txtFilename");
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.TextChanged += new System.EventHandler(this.OnFilenameChanged);
            // 
            // txtDiskSize
            // 
            resources.ApplyResources(this.txtDiskSize, "txtDiskSize");
            this.txtDiskSize.Name = "txtDiskSize";
            this.txtDiskSize.ReadOnly = true;
            // 
            // cboMaxAge
            // 
            resources.ApplyResources(this.cboMaxAge, "cboMaxAge");
            this.cboMaxAge.BeforeTouchSize = new System.Drawing.Size(275, 21);
            this.cboMaxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxAge.Name = "cboMaxAge";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BeforeTouchSize = new System.Drawing.Size(65, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.OnClearClick);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // configPanelControl2
            // 
            resources.ApplyResources(this.configPanelControl2, "configPanelControl2");
            this.configPanelControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl2.Controls.Add(this.txtProxyUserName);
            this.configPanelControl2.Controls.Add(this.label11);
            this.configPanelControl2.Controls.Add(this.chkAutodetectProxy);
            this.configPanelControl2.Controls.Add(this.chkUseProxy);
            this.configPanelControl2.Controls.Add(this.txtProxyPassword);
            this.configPanelControl2.Controls.Add(this.txtProxyAddress);
            this.configPanelControl2.Controls.Add(this.label10);
            this.configPanelControl2.Controls.Add(this.label1);
            this.configPanelControl2.HeaderText = "代理设置";
            this.configPanelControl2.Name = "configPanelControl2";
            // 
            // txtProxyUserName
            // 
            resources.ApplyResources(this.txtProxyUserName, "txtProxyUserName");
            this.txtProxyUserName.Name = "txtProxyUserName";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // chkAutodetectProxy
            // 
            resources.ApplyResources(this.chkAutodetectProxy, "chkAutodetectProxy");
            this.chkAutodetectProxy.Name = "chkAutodetectProxy";
            this.chkAutodetectProxy.UseVisualStyleBackColor = true;
            this.chkAutodetectProxy.CheckedChanged += new System.EventHandler(this.RefreshControls);
            // 
            // chkUseProxy
            // 
            resources.ApplyResources(this.chkUseProxy, "chkUseProxy");
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.RefreshControls);
            // 
            // txtProxyPassword
            // 
            resources.ApplyResources(this.txtProxyPassword, "txtProxyPassword");
            this.txtProxyPassword.Name = "txtProxyPassword";
            // 
            // txtProxyAddress
            // 
            resources.ApplyResources(this.txtProxyAddress, "txtProxyAddress");
            this.txtProxyAddress.BeforeTouchSize = new System.Drawing.Size(100, 21);
            this.txtProxyAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtProxyAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.ShowClearButton = false;
            this.txtProxyAddress.ThemeName = "Default";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // configPanelControl1
            // 
            resources.ApplyResources(this.configPanelControl1, "configPanelControl1");
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.chkWmsCaching);
            this.configPanelControl1.HeaderText = "WMS 图层";
            this.configPanelControl1.Name = "configPanelControl1";
            // 
            // chkWmsCaching
            // 
            resources.ApplyResources(this.chkWmsCaching, "chkWmsCaching");
            this.chkWmsCaching.Name = "chkWmsCaching";
            this.chkWmsCaching.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtBingAPIKey
            // 
            resources.ApplyResources(this.txtBingAPIKey, "txtBingAPIKey");
            this.txtBingAPIKey.Name = "txtBingAPIKey";
            // 
            // TilesConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBingAPIKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.configPanelControl1);
            this.Controls.Add(this.configPanelControl3);
            this.Controls.Add(this.configPanelControl2);
            this.Name = "TilesConfigPage";
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl3)).EndInit();
            this.configPanelControl3.ResumeLayout(false);
            this.configPanelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxDiskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl2)).EndInit();
            this.configPanelControl2.ResumeLayout(false);
            this.configPanelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProxyAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            this.configPanelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiskSize;
        private System.Windows.Forms.Label label5;
        private ComboBoxAdv cboMaxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ButtonAdv btnCreate;
        private ButtonAdv btnOpen;
        private System.Windows.Forms.TextBox txtFilename;
        private UI.Controls.ConfigPanelControl configPanelControl3;
        private System.Windows.Forms.CheckBox chkUseDiskCache;
        private ButtonAdv btnClear;
        private DoubleTextBox txtMaxDiskSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private UI.Controls.ConfigPanelControl configPanelControl2;
        private System.Windows.Forms.CheckBox chkAutodetectProxy;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.MaskedTextBox txtProxyPassword;
        private UI.Controls.WatermarkTextbox txtProxyAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProxyUserName;
        private System.Windows.Forms.Label label11;
        private UI.Controls.ConfigPanelControl configPanelControl1;
        private System.Windows.Forms.CheckBox chkWmsCaching;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBingAPIKey;
    }
}
