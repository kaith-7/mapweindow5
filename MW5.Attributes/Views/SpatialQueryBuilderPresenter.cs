// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Attributes.Views.Abstract;
using MW5.Plugins.Concrete;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.UI.Helpers;

namespace MW5.Attributes.Views
{
    public class SpatialQueryBuilderPresenter : BasePresenter<ISpatialSelectionBuilderView, ISpatialSelectionBuilderModel>
    {
        private readonly IAppContext _context;
        private string _lastQuery = string.Empty;

        public SpatialQueryBuilderPresenter(ISpatialSelectionBuilderView view, IAppContext context)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            view.RunClicked += OnRunClicked;
            View.Style.Modal = false;
        }

        public override bool ViewOkClicked()
        {
            if (Model.IsQuery)
            {
                // run the query on hitting OK button
                // if the query has not been executed yet
                OnRunClicked();
            }

            return true;
        }

        private void OnRunClicked()
        {
            View.UpdateModel();

            var results = new Dictionary<ILayer, IList<int>>();
            if (!Query(results)) return;

            // Open extra form with selection options:
            var list = new List<SelectionOperation>
                           {
                               SelectionOperation.New,
                               SelectionOperation.Add,
                               SelectionOperation.Exclude,
                               SelectionOperation.Invert,
                           };

            var operation = Model.selectionType;
            if (Model.LayerFilter == null)
                return;
            var selectedColor = Model.LayerFilter.FeatureSet.SelectionColor;
            foreach (var layer in Model.layerSrc)
            {
                layer.UpdateSelection(results[layer], operation, selectedColor);
            }                
            _context.Map.Redraw();
        }
        private bool Query(Dictionary<ILayer, IList<int>> results)
        {
            results.Clear();

            if (Model.LayerFilter == null)
                return false;

            var selectedFilter = Model.LayerFilter.FeatureSet.ExportSelection();
            foreach (var layer in Model.layerSrc)
            {
                var relation = SpatialRelation.Intersects;
                switch (Model.selectionMode)
                {
                    case SpatialSelectionMode.Intersection:
                        relation = SpatialRelation.Intersects;
                        break;
                    case SpatialSelectionMode.Contains:
                        relation = SpatialRelation.Contains;
                        break;
                    case SpatialSelectionMode.Within:
                        relation = SpatialRelation.Within;
                        break;
                    default:
                        break;
                }
                int[] result;
                layer.FeatureSet.SelectByShapefile(selectedFilter, relation, true, out result);
                results.Add(layer, result);
            }

            return true;
        }
    }
}