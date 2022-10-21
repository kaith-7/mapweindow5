using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Data.Views
{
    partial class AddConnectionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddConnectionView));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPostGis = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPostGisHost = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPostGisPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPostGisUserName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPostGisDatabase = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPostGisPort = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMsSql = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMssqlConnection = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMssqlServer = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMssqlDatabase = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optSqlAuthentication = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.optWindowsAuthentication = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.txtMssqlUserName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMssqlPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabSqlite = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnChooseSpatialLite = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSpatiaLiteDatabase = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabMySql = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMySqlPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtMySqlUser = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtMySqlDatabase = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtMySqlPort = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMySqlHost = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label16 = new System.Windows.Forms.Label();
            this.tabFileGDB = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnChooseFlieGDB = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFileGeoDatabase = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tabPersonalGDB = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnChoosePersonalGDB = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPersonalGDB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnTestConnection = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPostGis.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisPort)).BeginInit();
            this.tabMsSql.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlDatabase)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optSqlAuthentication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optWindowsAuthentication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlPassword)).BeginInit();
            this.tabSqlite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpatiaLiteDatabase)).BeginInit();
            this.tabMySql.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlHost)).BeginInit();
            this.tabFileGDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileGeoDatabase)).BeginInit();
            this.tabPersonalGDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalGDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            resources.ApplyResources(this.tabControlAdv1, "tabControlAdv1");
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(488, 339);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.BorderWidth = 0;
            this.tabControlAdv1.Controls.Add(this.tabPostGis);
            this.tabControlAdv1.Controls.Add(this.tabMsSql);
            this.tabControlAdv1.Controls.Add(this.tabSqlite);
            this.tabControlAdv1.Controls.Add(this.tabMySql);
            this.tabControlAdv1.Controls.Add(this.tabFileGDB);
            this.tabControlAdv1.Controls.Add(this.tabPersonalGDB);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.Silver;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendLight);
            this.tabControlAdv1.ThemeName = "TabRendererBlendLight";
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.OnTabControlSelectedIndexChanged);
            // 
            // tabPostGis
            // 
            resources.ApplyResources(this.tabPostGis, "tabPostGis");
            this.tabPostGis.Controls.Add(this.panel2);
            this.tabPostGis.Image = global::MW5.Data.Properties.Resources.img_postgis;
            this.tabPostGis.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPostGis.Name = "tabPostGis";
            this.tabPostGis.ShowCloseButton = true;
            this.tabPostGis.ThemesEnabled = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.txtPostGisHost);
            this.panel2.Controls.Add(this.txtPostGisPassword);
            this.panel2.Controls.Add(this.txtPostGisUserName);
            this.panel2.Controls.Add(this.txtPostGisDatabase);
            this.panel2.Controls.Add(this.txtPostGisPort);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Name = "panel2";
            this.panel2.TabStop = true;
            // 
            // txtPostGisHost
            // 
            resources.ApplyResources(this.txtPostGisHost, "txtPostGisHost");
            this.txtPostGisHost.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtPostGisHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostGisHost.Name = "txtPostGisHost";
            this.txtPostGisHost.ThemeName = "Default";
            // 
            // txtPostGisPassword
            // 
            resources.ApplyResources(this.txtPostGisPassword, "txtPostGisPassword");
            this.txtPostGisPassword.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtPostGisPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostGisPassword.Name = "txtPostGisPassword";
            this.txtPostGisPassword.ThemeName = "Default";
            this.txtPostGisPassword.UseSystemPasswordChar = true;
            // 
            // txtPostGisUserName
            // 
            resources.ApplyResources(this.txtPostGisUserName, "txtPostGisUserName");
            this.txtPostGisUserName.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtPostGisUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostGisUserName.Name = "txtPostGisUserName";
            this.txtPostGisUserName.ThemeName = "Default";
            // 
            // txtPostGisDatabase
            // 
            resources.ApplyResources(this.txtPostGisDatabase, "txtPostGisDatabase");
            this.txtPostGisDatabase.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtPostGisDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostGisDatabase.Name = "txtPostGisDatabase";
            this.txtPostGisDatabase.ThemeName = "Default";
            // 
            // txtPostGisPort
            // 
            resources.ApplyResources(this.txtPostGisPort, "txtPostGisPort");
            this.txtPostGisPort.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtPostGisPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostGisPort.Name = "txtPostGisPort";
            this.txtPostGisPort.ThemeName = "Default";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabMsSql
            // 
            resources.ApplyResources(this.tabMsSql, "tabMsSql");
            this.tabMsSql.Controls.Add(this.groupBox3);
            this.tabMsSql.Controls.Add(this.groupBox2);
            this.tabMsSql.Controls.Add(this.groupBox1);
            this.tabMsSql.Image = global::MW5.Data.Properties.Resources.img_mssql24;
            this.tabMsSql.ImageSize = new System.Drawing.Size(24, 24);
            this.tabMsSql.Name = "tabMsSql";
            this.tabMsSql.ShowCloseButton = true;
            this.tabMsSql.ThemesEnabled = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.txtMssqlConnection);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtMssqlConnection
            // 
            resources.ApplyResources(this.txtMssqlConnection, "txtMssqlConnection");
            this.txtMssqlConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMssqlConnection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMssqlConnection.Name = "txtMssqlConnection";
            this.txtMssqlConnection.TextChanged += new System.EventHandler(this.RawConnectionChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txtMssqlServer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMssqlDatabase);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtMssqlServer
            // 
            resources.ApplyResources(this.txtMssqlServer, "txtMssqlServer");
            this.txtMssqlServer.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMssqlServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMssqlServer.Name = "txtMssqlServer";
            this.txtMssqlServer.ThemeName = "Default";
            this.txtMssqlServer.TextChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtMssqlDatabase
            // 
            resources.ApplyResources(this.txtMssqlDatabase, "txtMssqlDatabase");
            this.txtMssqlDatabase.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMssqlDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMssqlDatabase.Name = "txtMssqlDatabase";
            this.txtMssqlDatabase.ThemeName = "Default";
            this.txtMssqlDatabase.TextChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.optSqlAuthentication);
            this.groupBox1.Controls.Add(this.optWindowsAuthentication);
            this.groupBox1.Controls.Add(this.txtMssqlUserName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMssqlPassword);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // optSqlAuthentication
            // 
            resources.ApplyResources(this.optSqlAuthentication, "optSqlAuthentication");
            this.optSqlAuthentication.BeforeTouchSize = new System.Drawing.Size(107, 19);
            this.optSqlAuthentication.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.optSqlAuthentication.Name = "optSqlAuthentication";
            this.optSqlAuthentication.TabStop = false;
            this.optSqlAuthentication.CheckChanged += new System.EventHandler(this.optSqlAuthentication_CheckChanged);
            // 
            // optWindowsAuthentication
            // 
            resources.ApplyResources(this.optWindowsAuthentication, "optWindowsAuthentication");
            this.optWindowsAuthentication.BeforeTouchSize = new System.Drawing.Size(75, 19);
            this.optWindowsAuthentication.Checked = true;
            this.optWindowsAuthentication.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.optWindowsAuthentication.Name = "optWindowsAuthentication";
            // 
            // txtMssqlUserName
            // 
            resources.ApplyResources(this.txtMssqlUserName, "txtMssqlUserName");
            this.txtMssqlUserName.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMssqlUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMssqlUserName.Name = "txtMssqlUserName";
            this.txtMssqlUserName.ThemeName = "Default";
            this.txtMssqlUserName.TextChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtMssqlPassword
            // 
            resources.ApplyResources(this.txtMssqlPassword, "txtMssqlPassword");
            this.txtMssqlPassword.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMssqlPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMssqlPassword.Name = "txtMssqlPassword";
            this.txtMssqlPassword.ThemeName = "Default";
            this.txtMssqlPassword.UseSystemPasswordChar = true;
            this.txtMssqlPassword.TextChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // tabSqlite
            // 
            resources.ApplyResources(this.tabSqlite, "tabSqlite");
            this.tabSqlite.Controls.Add(this.btnChooseSpatialLite);
            this.tabSqlite.Controls.Add(this.label11);
            this.tabSqlite.Controls.Add(this.txtSpatiaLiteDatabase);
            this.tabSqlite.Image = global::MW5.Data.Properties.Resources.img_sqlite24;
            this.tabSqlite.ImageSize = new System.Drawing.Size(24, 24);
            this.tabSqlite.Name = "tabSqlite";
            this.tabSqlite.ShowCloseButton = true;
            this.tabSqlite.ThemesEnabled = false;
            // 
            // btnChooseSpatialLite
            // 
            resources.ApplyResources(this.btnChooseSpatialLite, "btnChooseSpatialLite");
            this.btnChooseSpatialLite.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnChooseSpatialLite.Name = "btnChooseSpatialLite";
            this.btnChooseSpatialLite.Click += new System.EventHandler(this.btnChooseSpatialLite_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtSpatiaLiteDatabase
            // 
            resources.ApplyResources(this.txtSpatiaLiteDatabase, "txtSpatiaLiteDatabase");
            this.txtSpatiaLiteDatabase.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtSpatiaLiteDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpatiaLiteDatabase.Name = "txtSpatiaLiteDatabase";
            this.txtSpatiaLiteDatabase.ThemeName = "Default";
            // 
            // tabMySql
            // 
            resources.ApplyResources(this.tabMySql, "tabMySql");
            this.tabMySql.Controls.Add(this.panel1);
            this.tabMySql.Image = global::MW5.Data.Properties.Resources.img_mysql2_24;
            this.tabMySql.ImageSize = new System.Drawing.Size(24, 24);
            this.tabMySql.Name = "tabMySql";
            this.tabMySql.ShowCloseButton = true;
            this.tabMySql.ThemesEnabled = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.txtMySqlPassword);
            this.panel1.Controls.Add(this.txtMySqlUser);
            this.panel1.Controls.Add(this.txtMySqlDatabase);
            this.panel1.Controls.Add(this.txtMySqlPort);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtMySqlHost);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Name = "panel1";
            // 
            // txtMySqlPassword
            // 
            resources.ApplyResources(this.txtMySqlPassword, "txtMySqlPassword");
            this.txtMySqlPassword.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMySqlPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMySqlPassword.Name = "txtMySqlPassword";
            this.txtMySqlPassword.ThemeName = "Default";
            this.txtMySqlPassword.UseSystemPasswordChar = true;
            // 
            // txtMySqlUser
            // 
            resources.ApplyResources(this.txtMySqlUser, "txtMySqlUser");
            this.txtMySqlUser.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMySqlUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMySqlUser.Name = "txtMySqlUser";
            this.txtMySqlUser.ThemeName = "Default";
            // 
            // txtMySqlDatabase
            // 
            resources.ApplyResources(this.txtMySqlDatabase, "txtMySqlDatabase");
            this.txtMySqlDatabase.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMySqlDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMySqlDatabase.Name = "txtMySqlDatabase";
            this.txtMySqlDatabase.ThemeName = "Default";
            // 
            // txtMySqlPort
            // 
            resources.ApplyResources(this.txtMySqlPort, "txtMySqlPort");
            this.txtMySqlPort.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMySqlPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMySqlPort.Name = "txtMySqlPort";
            this.txtMySqlPort.ThemeName = "Default";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // txtMySqlHost
            // 
            resources.ApplyResources(this.txtMySqlHost, "txtMySqlHost");
            this.txtMySqlHost.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtMySqlHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMySqlHost.Name = "txtMySqlHost";
            this.txtMySqlHost.ThemeName = "Default";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // tabFileGDB
            // 
            resources.ApplyResources(this.tabFileGDB, "tabFileGDB");
            this.tabFileGDB.Controls.Add(this.btnChooseFlieGDB);
            this.tabFileGDB.Controls.Add(this.label10);
            this.tabFileGDB.Controls.Add(this.txtFileGeoDatabase);
            this.tabFileGDB.Image = global::MW5.Data.Properties.Resources.img_GeodatabaseConnectionNew32;
            this.tabFileGDB.ImageSize = new System.Drawing.Size(24, 24);
            this.tabFileGDB.Name = "tabFileGDB";
            this.tabFileGDB.ShowCloseButton = true;
            this.tabFileGDB.ThemesEnabled = false;
            // 
            // btnChooseFlieGDB
            // 
            resources.ApplyResources(this.btnChooseFlieGDB, "btnChooseFlieGDB");
            this.btnChooseFlieGDB.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnChooseFlieGDB.Name = "btnChooseFlieGDB";
            this.btnChooseFlieGDB.Click += new System.EventHandler(this.btnChooseFlieGDB_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtFileGeoDatabase
            // 
            resources.ApplyResources(this.txtFileGeoDatabase, "txtFileGeoDatabase");
            this.txtFileGeoDatabase.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtFileGeoDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileGeoDatabase.Name = "txtFileGeoDatabase";
            this.txtFileGeoDatabase.ThemeName = "Default";
            // 
            // tabPersonalGDB
            // 
            resources.ApplyResources(this.tabPersonalGDB, "tabPersonalGDB");
            this.tabPersonalGDB.Controls.Add(this.btnChoosePersonalGDB);
            this.tabPersonalGDB.Controls.Add(this.label17);
            this.tabPersonalGDB.Controls.Add(this.txtPersonalGDB);
            this.tabPersonalGDB.Image = global::MW5.Data.Properties.Resources.img_GeodatabaseConnectionNew32;
            this.tabPersonalGDB.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPersonalGDB.Name = "tabPersonalGDB";
            this.tabPersonalGDB.ShowCloseButton = true;
            this.tabPersonalGDB.ThemesEnabled = false;
            // 
            // btnChoosePersonalGDB
            // 
            resources.ApplyResources(this.btnChoosePersonalGDB, "btnChoosePersonalGDB");
            this.btnChoosePersonalGDB.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btnChoosePersonalGDB.Name = "btnChoosePersonalGDB";
            this.btnChoosePersonalGDB.Click += new System.EventHandler(this.btnChoosePersonalGDB_Click);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // txtPersonalGDB
            // 
            resources.ApplyResources(this.txtPersonalGDB, "txtPersonalGDB");
            this.txtPersonalGDB.BeforeTouchSize = new System.Drawing.Size(330, 21);
            this.txtPersonalGDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonalGDB.Name = "txtPersonalGDB";
            this.txtPersonalGDB.ThemeName = "Default";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 24);
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
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 24);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Name = "btnOk";
            this.btnOk.ThemeName = "Metro";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnTestConnection
            // 
            resources.ApplyResources(this.btnTestConnection, "btnTestConnection");
            this.btnTestConnection.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnTestConnection.BeforeTouchSize = new System.Drawing.Size(104, 24);
            this.btnTestConnection.ForeColor = System.Drawing.Color.White;
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.ThemeName = "Metro";
            // 
            // AddConnectionView
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "AddConnectionView";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPostGis.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostGisPort)).EndInit();
            this.tabMsSql.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlDatabase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optSqlAuthentication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optWindowsAuthentication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMssqlPassword)).EndInit();
            this.tabSqlite.ResumeLayout(false);
            this.tabSqlite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpatiaLiteDatabase)).EndInit();
            this.tabMySql.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMySqlHost)).EndInit();
            this.tabFileGDB.ResumeLayout(false);
            this.tabFileGDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileGeoDatabase)).EndInit();
            this.tabPersonalGDB.ResumeLayout(false);
            this.tabPersonalGDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalGDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPostGis;
        private TextBoxExt txtPostGisPassword;
        private TextBoxExt txtPostGisUserName;
        private TextBoxExt txtPostGisDatabase;
        private TextBoxExt txtPostGisPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TextBoxExt txtPostGisHost;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabMsSql;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabSqlite;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.ButtonAdv btnTestConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextBoxExt txtMssqlUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private TextBoxExt txtMssqlPassword;
        private TextBox txtMssqlConnection;
        private TextBoxExt txtMssqlDatabase;
        private TextBoxExt txtMssqlServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private RadioButtonAdv optSqlAuthentication;
        private RadioButtonAdv optWindowsAuthentication;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.ButtonAdv btnChooseSpatialLite;
        private System.Windows.Forms.Label label11;
        private TextBoxExt txtSpatiaLiteDatabase;
        private TabPageAdv tabMySql;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private TextBoxExt txtMySqlPassword;
        private TextBoxExt txtMySqlUser;
        private TextBoxExt txtMySqlDatabase;
        private TextBoxExt txtMySqlPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private TextBoxExt txtMySqlHost;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private TabPageAdv tabFileGDB;
        private Syncfusion.Windows.Forms.ButtonAdv btnChooseFlieGDB;
        private Label label10;
        private TextBoxExt txtFileGeoDatabase;
        private TabPageAdv tabPersonalGDB;
        private Syncfusion.Windows.Forms.ButtonAdv btnChoosePersonalGDB;
        private Label label17;
        private TextBoxExt txtPersonalGDB;
    }
}