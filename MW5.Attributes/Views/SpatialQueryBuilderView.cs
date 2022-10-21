// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Attributes.Views.Abstract;
using MW5.Plugins.Interfaces;
using MW5.UI.Forms;
using MW5.UI.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MW5.Attributes.Views
{
    public partial class SpatialQueryBuilderView : SpatialQueryBuilderViewBase, ISpatialSelectionBuilderView
    {
        private readonly IAppContext _context;

        public SpatialQueryBuilderView(IAppContext ctx) : base()
        {
            _context = ctx;

            InitializeComponent();

            btnRun.Click += (s, e) => Invoke(RunClicked);

            ((IMap)_context.Map).SelectionChanged += SpatialQueryBuilderView_SelectionChanged;
        }

        private void SpatialQueryBuilderView_SelectionChanged(object sender, Api.Events.SelectionChangedEventArgs e)
        {
            if (comboBox_FilterLayer.Items.Count == 0)
                InitFilterLayer();
            FilterLayerSelectChanged();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.R):
                    Invoke(RunClicked);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public event Action RunClicked;

        public void UpdateModel()
        {
            Model.layerSrc.Clear();
            foreach (var item in clb_Layers.CheckedItems)
            {
                var lyr = _context.Legend.Layers.Where(l => l.Name == item.ToString()).FirstOrDefault();
                if (lyr != null)
                {
                    Model.layerSrc.Add(lyr);
                }
            }

            Model.LayerFilter = _context.Legend.Layers.Where(l => l.Name == this.comboBox_FilterLayer.SelectedItem.ToString()).FirstOrDefault();

            Model.selectionMode = this.cbo_FilterCondition.GetValue<SpatialSelectionMode>();
            Model.selectionType = this.cbo_Result.GetValue<SelectionOperation>();
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            //_table = Model.Layer.FeatureSet.Table;
            //lblSelect.Text = string.Format("SELECT * FROM [{0}] WHERE ", Model.Layer.Name);

            InitLayersGrid();

            InitFilterLayer();

            FilterLayerSelectChanged();

            InitFilterCondition();
            
            InitResultType();

            if (Model.allLayers.Count == 1)
            {
                cbx_UseSelection.Checked = true;
            }

            btnRun.Enabled = Model.IsQuery;
        }

        private void InitResultType()
        {
            cbo_Result.Items.Clear();
            cbo_Result.AddItemsFromEnum<SelectionOperation>();
            if (cbo_Result.Items.Count > 0)
                cbo_Result.SelectedIndex = 0;
        }

        private void InitFilterCondition()
        {
            cbo_FilterCondition.Items.Clear();
            this.cbo_FilterCondition.AddItemsFromEnum<SpatialSelectionMode>();
            if (this.cbo_FilterCondition.Items.Count > 0)
                this.cbo_FilterCondition.SelectedIndex = 0;
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        private void InitLayersGrid()
        {
            clb_Layers.Items.Clear();
            foreach (var item in Model.allLayers)
            {
                if(item.FeatureSet != null)
                    clb_Layers.Items.Add(item.Name);
            }
        }

        private void InitFilterLayer()
        {
            comboBox_FilterLayer.Items.Clear();
            cbx_UseSelection.Enabled = true;
            cbx_UseSelection.Checked = false;
            cbx_UseSelection.Text = cbx_UseSelection.Tag.ToString();
            if (Model.allLayers.Count > 0)
            {
                for (int i = 0; i < clb_Layers.Items.Count; i++)
                {
                    var layer = Model.allLayers.Where(l => l.Name == clb_Layers.Items[i].ToString()).FirstOrDefault();
                    if(clb_Layers.GetItemCheckState(i) == CheckState.Unchecked && (layer != null && layer.FeatureSet != null))
                    {
                        this.comboBox_FilterLayer.Items.Add(layer);
                    }
                }
                if (this.comboBox_FilterLayer.Items.Count > 0)
                {
                    this.comboBox_FilterLayer.SelectedIndex = 0;
                }
                if (Model.allLayers.Count <= 1)
                    cbx_UseSelection.Enabled = false;
            }
        }

        private void comboBox_FilterLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLayerSelectChanged();
        }

        private void FilterLayerSelectChanged()
        {
            if (comboBox_FilterLayer.SelectedItem == null)
                return;
            var layer = Model.allLayers.Where(l => l.Name == comboBox_FilterLayer.SelectedItem.ToString()).FirstOrDefault();
            if (layer != null && layer.IsVector)
            {
                var txt = cbx_UseSelection.Tag.ToString().Replace("0", layer.FeatureSet.NumSelected.ToString());
                cbx_UseSelection.Text = txt;
                if (layer.FeatureSet.NumSelected > 0)
                    cbx_UseSelection.Checked = true;
            }
        }

        private void clb_Layers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var control = (CheckedListBox)sender;
            control.ItemCheck -= clb_Layers_ItemCheck;
            control.SetItemCheckState(e.Index, e.NewValue);
            control.ItemCheck += clb_Layers_ItemCheck;
            //var checkedIndiecs = control.CheckedIndices.Cast<int>().ToList();
            //if (e.NewValue == CheckState.Checked)
            //    checkedIndiecs.Add(e.Index);
            //else if (checkedIndiecs.Contains(e.Index))
            //    checkedIndiecs.Remove(e.Index);
                       
            InitFilterLayer();
        }

        private void SpatialQueryBuilderView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

    public class SpatialQueryBuilderViewBase : MapWindowView<ISpatialSelectionBuilderModel>
    {
    }
}