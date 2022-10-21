// -------------------------------------------------------------------------------------------
// <copyright file="DebugDockView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using MW5.Api.Concrete;
using MW5.Plugins.AttributeChecker.Views.Abstract;
using MW5.Plugins.Interfaces;
using MW5.Services.Concrete;
using MW5.Shared;
using MW5.Shared.CheckResult;
using MW5.Shared.Log;
using MW5.UI.Controls;
using MW5.UI.Helpers;

namespace MW5.Plugins.AttributeChecker.Views
{
    public partial class CheckResultView : DockPanelControlBase, ICheckerView
    {
        private readonly IAppContext _context;
        private readonly BindingListView<ILayerCheckResult> _entries;

        //public event Action<object, DataGridViewCellEventArgs> RowSelected;

        ICheckAttrService logger;


        /// <summary>
        /// Initializes a new instance of the <see cref="CheckResultView"/> class.
        /// </summary>
        public CheckResultView(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            InitializeComponent();

            _entries = new BindingListView<ILayerCheckResult>(new SortableBindingList<ILayerCheckResult>());

            InitGrid();

            InitCombo();

            txtFilter.TextChanged += UpdateFilter;

            VisibleChanged += OnVisibleChanged;
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get { yield return toolStripEx1.Items; }
        }

        public IEnumerable<Control> Buttons
        {
            get { yield break; }
        }

        public void Clear()
        {
            _entries.DataSource.Clear();
        }

        private void InitCombo()
        {
            //comboBoxAdv1.Items.Clear();
            //comboBoxAdv1.AddItemsFromEnum<LogLevel>();
            //comboBoxAdv1.SetValue(LogLevel.All);
            //comboBoxAdv1.SelectedIndexChanged += UpdateFilter;
        }

        private void InitGrid()
        {
            grid.SetDatasource(_entries);
            grid.CellDoubleClick += Grid_CellDoubleClick;
            MW5.Shared.AttributeChecker.Current.EntryAdded += OnEntryAdded;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var st = new System.Diagnostics.StackTrace();
            //Console.WriteLine(st.GetFrame(0).GetMethod().Name);

            if (e.RowIndex >= 0)
            {
                var line = _entries.DataSource[e.RowIndex] as ILayerCheckResult;
                Console.WriteLine(line.ErrorMessage);
                //RowSelected?.Invoke(sender, e);
                _context.Layers.Current?.UpdateSelection(new int[] { line.FeatureIndex }, Api.Enums.SelectionOperation.New);
            }
        }

        private void OnEntryAdded(object sender, AttributeCheckResultEntryAddArgs e)
        {
            if (!IsDockVisible || !grid.IsHandleCreated)
            {
                // do nothing records will be added on the next display of the panel
                return;
            }

            lock (grid)
            {
                Action action = () =>
                {
                    if (e.Entrys is IList<ILayerCheckResult> resList)
                    {
                        if (resList is List<ILayerCheckResult> listOld)
                        {
                            var iter = _entries.DataSource as IList<ILayerCheckResult>;
                            if (iter != null)
                                listOld.AddRange(iter);
                        }
                        _entries.DataSource = new SortableBindingList<ILayerCheckResult>(resList);
                    }
                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[1];
                };
                grid.SafeInvoke(action);

            }
        }

        public void EntryAdd(ILayerCheckResult res)
        {
            _entries.DataSource.Add(res);
        }

        public void EntryAddRange(IList<ILayerCheckResult> range)
        {
            foreach (var item in range)
            {
                _entries.DataSource.Add(item);
            }
        }

        /// <summary>
        /// Adds all undisplayed records to the grid.
        /// </summary>
        private void OnVisibleChanged(object sender, EventArgs e)
        {
            if (Visible && Logger.Current.Entries.Any(item => !item.Displayed))
            {
                var list = Logger.Current.Entries.Where(item => !item.Displayed).ToList();

                var target = _entries.DataSource as BindingList<ILogEntry>;
                if (target != null)
                {
                    target.RaiseListChangedEvents = false;

                    foreach (var item in list)
                    {
                        target.Add(item);
                        item.Displayed = true;
                    }

                    target.RaiseListChangedEvents = true;

                    target.ResetBindings();
                }
            }
        }

        private void UpdateFilter(object sender, EventArgs e)
        {
            grid.UpdateFilter(txtFilter.Text);
        }
    }
}