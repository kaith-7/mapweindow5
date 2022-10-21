// -------------------------------------------------------------------------------------------
// <copyright file="LogEntryDataGridView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Drawing;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using MW5.Api.Concrete;
using MW5.Plugins.TopologyChecker.Properties;
using MW5.Shared;
using MW5.Shared.CheckResult;
using MW5.Shared.Log;
using MW5.UI.Controls;

namespace MW5.Plugins.TopologyChecker.Controls
{
    public partial class CheckAttributesDataGridView : StronglyTypedDataGridView<ITopologyCheckResult>, IItemFilter<ITopologyCheckResult>
    {
        private string _searchToken;

        public CheckAttributesDataGridView()
        {
            InitializeComponent();

            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            BackgroundColor = Color.White;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.DoubleBuffered(true);
        }

        /// <summary>
        /// Tests if the item should be included.
        /// </summary>
        public bool Include(ITopologyCheckResult item)
        {
            //if (_logLevel != LogLevel.All && item.Level != _logLevel)
            //{
            //    return false;
            //}

            if (!string.IsNullOrWhiteSpace(_searchToken))
            {
                return item.Rule.ContainsIgnoreCase(_searchToken);
            }

            return true;
        }

        public void SetDatasource(BindingListView<ITopologyCheckResult> entries)
        {
            Adapter.SetDatasource(entries);

            // it seems that column generation is performed once again on adding first object,
            // but we are quite content to to have columns generated from the type of list
            AutoGenerateColumns = false;

            UpdateColumns();
        }

        public void UpdateFilter(string filterToken)
        {
            var bs = Adapter.BindingSource;
            if (bs == null) return;

            _searchToken = filterToken;

            if (string.IsNullOrWhiteSpace(filterToken))
            {
                bs.RemoveFilter();
                return;
            }

            bs.ApplyFilter(Include);
        }

        private void UpdateColumns()
        {
            //var cmn1 = Adapter.GetColumn(e => e.FeatureIndex);
            //cmn1.DisplayIndex = 0;
            //cmn1.Width = 100;

            var cmn2 = Adapter.GetColumn(e => e.Rule);
            //cmn2.DisplayIndex = 1;
            //cmn2.Width = this.Width - 100;
            cmn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}