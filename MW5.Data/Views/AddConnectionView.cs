﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MW5.Data.Db;
using MW5.Data.Views.Abstract;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Services;
using MW5.UI.Forms;

namespace MW5.Data.Views
{
    public partial class AddConnectionView : AddConnectionViewBase, IAddConnectionView
    {
        private readonly IFileDialogService _fileDialog;
        private static int _lastTabPage = -1;
        private readonly Dictionary<GeoDatabaseType, bool> _ignoreList = new Dictionary<GeoDatabaseType, bool>();

        public event Action TestConnection;
        public event Action ConnectionChanged;

        public AddConnectionView(IFileDialogService fileDialog)
        {
            if (fileDialog == null) throw new ArgumentNullException("fileDialog");
            _fileDialog = fileDialog;

            InitializeComponent();

            InitIgnoreList();

            btnTestConnection.Click += (s, e) => Invoke(TestConnection);

            RestoreSettings();

            FormClosed += (s, e) => SaveSettings();

            UpdateView();

            Shown += (s, e) => tabControlAdv1.Focus();
        }

        private void RestoreSettings()
        {
            tabControlAdv1.SelectedIndex = _lastTabPage;

            txtMssqlDatabase.Text = AppConfig.Instance.MsSqlDatabase;
            txtMssqlServer.Text = AppConfig.Instance.MsSqlServer;
            txtMssqlUserName.Text = AppConfig.Instance.MsSqlUser;
            optSqlAuthentication.Checked = AppConfig.Instance.MsSqlUseNativeAuthentication;
        }

        private void SaveSettings()
        {
            _lastTabPage = tabControlAdv1.SelectedIndex;

            switch (DatabaseType)
            {
                case GeoDatabaseType.PostGis:
                    break;
                case GeoDatabaseType.SpatiaLite:
                    break;
                case GeoDatabaseType.MsSql:
                    AppConfig.Instance.MsSqlDatabase = txtMssqlDatabase.Text;
                    AppConfig.Instance.MsSqlServer = txtMssqlServer.Text;
                    AppConfig.Instance.MsSqlUser = txtMssqlUserName.Text;
                    AppConfig.Instance.MsSqlUseNativeAuthentication = optSqlAuthentication.Checked;
                    break;
                case GeoDatabaseType.MySql:
                    break;
            }
        }

        private void InitIgnoreList()
        {
            var values = Enum.GetValues(typeof (GeoDatabaseType));
            foreach (GeoDatabaseType value in values)
            {
                _ignoreList[value] = false;
            }
        }

        public GeoDatabaseType DatabaseType
        {
            get
            {
                switch (tabControlAdv1.SelectedIndex)
                {
                    case 0:
                        return GeoDatabaseType.PostGis;
                    case 1:
                        return GeoDatabaseType.MsSql;
                    case 2:
                        return GeoDatabaseType.SpatiaLite;
                    case 3:
                        return GeoDatabaseType.MySql;
                    case 4:
                        return GeoDatabaseType.FileGDB;
                    case 5:
                        return GeoDatabaseType.PersonalGDB;
                }

                throw new IndexOutOfRangeException("tabControlAdv1.SelectedIndex");
            }

            set
            {
                switch (value)
                {
                    case GeoDatabaseType.PostGis:
                        tabControlAdv1.SelectedIndex = 0;
                        break;
                    case GeoDatabaseType.MsSql:
                        tabControlAdv1.SelectedIndex = 1;
                        break;
                    case GeoDatabaseType.SpatiaLite:
                        tabControlAdv1.SelectedIndex = 2;
                        break;
                    case GeoDatabaseType.MySql:
                        tabControlAdv1.SelectedIndex = 3;
                        break;
                    case GeoDatabaseType.FileGDB:
                        tabControlAdv1.SelectedIndex = 4;
                        break;
                    case GeoDatabaseType.PersonalGDB:
                        tabControlAdv1.SelectedIndex = 5;
                        break;
                }
            }
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public void Init(ConnectionBase info)
        {
            switch (info.DatabaseType)
            {
                case GeoDatabaseType.PostGis:
                    var pg = info as PostGisConnection;
                    if (pg != null)
                    {
                        txtPostGisHost.Text = pg.Host;
                        txtPostGisPort.Text = pg.Port.ToString();
                        txtPostGisDatabase.Text = pg.Database;
                        txtPostGisUserName.Text = pg.UserName;
                        txtPostGisPassword.Text = pg.Password;
                    }
                    break;
                case GeoDatabaseType.SpatiaLite:
                    break;
                case GeoDatabaseType.MsSql:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public ConnectionBase GetConnection()
        {
            var conn = GetConnectionCore();
            conn.IgnoreParams = _ignoreList[DatabaseType];
            return conn;
        }

        public ConnectionBase GetConnectionCore()
        {
            switch (DatabaseType)
            {
                case GeoDatabaseType.PostGis:
                    return new PostGisConnection {
                        Host = txtPostGisHost.Text,
                        PortString = txtPostGisPort.Text,
                        Database = txtPostGisDatabase.Text,
                        UserName = txtPostGisUserName.Text,
                        Password = txtPostGisPassword.Text,
                        RawConnection = ""
                    };
                case GeoDatabaseType.SpatiaLite:
                    return new SpatiaLiteConnection()
                    {
                        Filename = txtSpatiaLiteDatabase.Text
                    };
                case GeoDatabaseType.MsSql:
                    return new MssqlConnection()
                    {
                        Server = txtMssqlServer.Text,
                        Database = txtMssqlDatabase.Text,
                        UserName = txtMssqlUserName.Text,
                        Password = txtMssqlPassword.Text,
                        WindowsAuthentication = optWindowsAuthentication.Checked,
                        RawConnection = txtMssqlConnection.Text
                    };
                case GeoDatabaseType.MySql:
                    return new MySqlConnection()
                    {
                        Host = txtMySqlHost.Text,
                        PortString = txtMySqlPort.Text,
                        Database = txtMySqlDatabase.Text,
                        UserName = txtMySqlUser.Text,
                        Password = txtMySqlPassword.Text,
                        RawConnection = ""
                    };

                case GeoDatabaseType.FileGDB:
                    return new FileGDBConnection()
                    {
                        Filename = txtFileGeoDatabase.Text
                    };
                case GeoDatabaseType.PersonalGDB:
                    return new PersonalGDBConnection()
                    {
                        Filename = txtPersonalGDB.Text
                    };
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Initialize()
        {
            if (Model.DatabaseType.HasValue)
            {
                DatabaseType = Model.DatabaseType.Value;
            }
        }

        public override void UpdateView()
        {
            txtMssqlUserName.Enabled = optSqlAuthentication.Checked;
            txtMssqlPassword.Enabled = optSqlAuthentication.Checked;
        }

        private void ParametersChanged(object sender, EventArgs e)
        {
            _ignoreList[DatabaseType] = false;
            Invoke(ConnectionChanged);
        }

        private void RawConnectionChanged(object sender, EventArgs e)
        {
            _ignoreList[DatabaseType] = true;
        }

        public void SetRawConnection(string cs)
        {
            switch (DatabaseType)
            {
                case GeoDatabaseType.MySql:
                    break;
                case GeoDatabaseType.PostGis:
                    break;
                case GeoDatabaseType.SpatiaLite:
                    break;
                case GeoDatabaseType.MsSql:
                    txtMssqlConnection.Text = cs;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void optSqlAuthentication_CheckChanged(object sender, EventArgs e)
        {
           RefreshConnectionString();
        }

        private void RefreshConnectionString()
        {
            UpdateView();
            ParametersChanged(null, null);
        }

        private void btnChooseSpatialLite_Click(object sender, EventArgs e)
        {
            string filename;
            if (_fileDialog.OpenFile(DataSourceType.SpatiaLite, out filename))
            {
                txtSpatiaLiteDatabase.Text = filename;
            }
        }

        private void OnTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdv1.SelectedTab == tabMsSql)
            {
                RefreshConnectionString();
            }
        }

        private void btnChooseFlieGDB_Click(object sender, EventArgs e)
        {
            string filename = txtFileGeoDatabase.Text;
            if (_fileDialog.ChooseFolder(filename, out filename))
            {
                txtFileGeoDatabase.Text = filename;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnChoosePersonalGDB_Click(object sender, EventArgs e)
        {
            string filename;
            if (_fileDialog.OpenFile(DataSourceType.PersonalGDB, out filename))
            {
                txtPersonalGDB.Text = filename;
            }
        }
    }

    public class AddConnectionViewBase : MapWindowView<AddConnectionModel> { }
}
