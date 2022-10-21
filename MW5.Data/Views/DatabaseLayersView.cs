// -------------------------------------------------------------------------------------------
// <copyright file="DatabaseLayersView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Data.Model;
using MW5.Data.Views.Abstract;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.UI.Forms;
using MW5.UI.Helpers;

namespace MW5.Data.Views
{
    public partial class DatabaseLayersView : DatabaseLayersViewBase, IDatabaseLayersView
    {
        private readonly BindingList<VectorLayerGridAdapter> _layers = new BindingList<VectorLayerGridAdapter>();
        private SynchronizationContext _syncContext;

        public DatabaseLayersView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            Text = @"Database Layers: " + Model.Connection.Name;

            _syncContext = SynchronizationContext.Current;

            StartWait();

            InitGrid();

            LoadLayersAsync();
        }

        public override ViewStyle Style
        {
            get { return new ViewStyle(true); }
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public IEnumerable<VectorLayerGridAdapter> Layers
        {
            get { return _layers; }
        }

        private int GetIcon(VectorLayerGridAdapter info)
        {
            switch (info.GeometryType)
            {
                case GeometryType.Point:
                case GeometryType.MultiPoint:
                    return 0;
                case GeometryType.Polyline:
                    return 1;
                case GeometryType.Polygon:
                    return 2;
                case GeometryType.None:
                    return 3;
            }

            return -1;
        }

        private void InitGrid()
        {
            databaseLayersGrid1.DataSource = _layers;

            var style = databaseLayersGrid1.Adapter.GetColumnStyle(r => r.Name);
            style.ImageList = imageList1;
            style.ImageIndex = 0;

            databaseLayersGrid1.Adapter.SetColumnIcon(r => r.Name, GetIcon);
            databaseLayersGrid1.Adapter.HotTracking = true;
        }

        private void LoadLayers()
        {
            var enumerator = Model.Datasource.GetFastEnumerator();

            while (enumerator.MoveNext())
            {
                var layer = enumerator.Current;

                if (Model.Connection.DatabaseType == Plugins.Enums.GeoDatabaseType.MySql &&
                    string.IsNullOrWhiteSpace(enumerator.Current.GeometryColumnName))
                {
                    // MySQL driver lists all tables as layers even if they don't have geometry column
                    continue;
                }

                void LoadLayer(Api.Concrete.VectorLayer l)
                {
                    // TODO: right now it will list only the geometry type of the layer
                    var layerAdapter = new VectorLayerGridAdapter(l);
                    _syncContext.Post(o =>
                    {
                        _layers.Add(o as VectorLayerGridAdapter);
                        databaseLayersGrid1.AdjustColumnWidths();
                    }, layerAdapter);
                }

                if (layer.GeometryType == GeometryType.None)
                {
                    var types = layer.AvailableGeometryTypes.ToList();

                    bool multipleGeometries = types.Count > 1;

                    foreach (var type in types)
                    {
                        // layer reference doesn't stay opened,
                        // so spare adding another parameter to AddDatabaseLayer when it can be read from property
                        layer.SetActiveGeometryType(type.GeometryType, type.ZValueType);
                        LoadLayer(layer);
                    }
                }
                else
                {
                    LoadLayer(layer);
                }
            }
        }

        private void LoadLayersAsync()
        {
            Task<bool>.Factory.StartNew(() =>
                {
                    if (Model.Datasource.Open(Model.Connection.ConnectionString))
                    {
                        LoadLayers();
                        return true;
                    }
                    const string msg = "Failed to open database connection.";
                    Logger.Current.Warn(msg + ": " + Model.Datasource.GdalLastErrorMsg);
                    MessageService.Current.Info(msg);
                    return false;
                }).ContinueWith(t =>
                    {
                        StopWait();
                        databaseLayersGrid1.Enabled = true;
                    }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void OnSelectAllChecked(object sender, EventArgs e)
        {
            databaseLayersGrid1.Adapter.SetPropertyForEach(item => item.Selected, chkSelectAll.Checked);
        }
    }

    public class DatabaseLayersViewBase : MapWindowView<DatabaseLayersModel>
    {
    }
}