// -------------------------------------------------------------------------------------------
// <copyright file="AddConnectionPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using MW5.Api.Concrete;
using MW5.Data.Db;
using MW5.Data.Views.Abstract;
using MW5.Plugins.Concrete;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Shared;

namespace MW5.Data.Views
{
    public class AddConnectionPresenter : BasePresenter<IAddConnectionView, AddConnectionModel>
    {
        private readonly IFileDialogService _fileDialog;
        private readonly PostGisConnection _postGis = new PostGisConnection();

        public AddConnectionPresenter(IAddConnectionView view, IFileDialogService fileDialog)
            : base(view)
        {
            Logger.Current.Trace("开始连接显示");
            if (fileDialog == null) throw new ArgumentNullException("文件对话框");
            
            // PM 20160302 Added:
            if (view == null) throw new ArgumentNullException("窗口");
            
            _fileDialog = fileDialog;

            view.Init(_postGis);

            view.TestConnection += TestConnection;

            view.ConnectionChanged += OnConnectionChanged;
            Logger.Current.Trace("结束连接显示");
        }

        public override bool ViewOkClicked()
        {
            var connection = View.GetConnection();
            if (connection == null)
            {
                MessageService.Current.Info("恢复连接参数失败。");
                return false;
            }

            if (!connection.Validate())
            {
                return false;
            }

            Model.Connection = new DatabaseConnection(View.DatabaseType, connection.Name, connection.GetConnection(),
                connection.GetConnection(true));

            return true;
        }

        private void OnConnectionChanged()
        {
            var cn = View.GetConnection();
            var cs = cn.BuildConnection();
            View.SetRawConnection(cs);
        }

        private void TestConnection()
        {
            var info = View.GetConnection();
            if (!info.Validate())
            {
                return;
            }

            string cs = info.GetConnection();
            string errorMessage = string.Empty;

            View.StartWait();

            Task<bool>.Factory.StartNew(() => TestConnectionCore(cs, ref errorMessage)).ContinueWith(t =>
                {
                    View.StopWait();

                    if (!t.Result)
                    {
                        MessageService.Current.Warn("打开连接失败。");
                    }
                    else
                    {
                        MessageService.Current.Info("连接成功");
                    }

                    Logger.Current.Info("测试连接: {0}\n{1}", cs, t.Result ? "成功" : "失败");
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private bool TestConnectionCore(string cs, ref string errorMessage)
        {
            using (var ds = new VectorDatasource())
            {
                bool result = ds.Open(cs);
                if (!result)
                {
                    errorMessage = ds.GdalLastErrorMsg;
                }

                return result;
            }
        }
    }
}