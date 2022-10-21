// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderModel.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Legend.Abstract;

namespace MW5.Attributes.Views
{
    public abstract class BaseSpatialSelectionBuilderModel : ISpatialSelectionBuilderModel
    {
        protected BaseSpatialSelectionBuilderModel(ILayerCollection<ILegendLayer> layers)
        {
            if (layers == null || layers.Count < 1) throw new ArgumentNullException("layer");

            IsQuery = true;
            allLayers = layers;
            layerSrc = new List<ILayer>();
        }

        public bool IsQuery { get; private set; }
        public ILayer LayerFilter { get; set; }

        public IList<ILayer> layerSrc { get; private set; }
        public SpatialSelectionMode selectionMode { get; set; }
        public ILayerCollection<ILegendLayer> allLayers { get; set; }
        public SelectionOperation selectionType { get; set; }
    }
}