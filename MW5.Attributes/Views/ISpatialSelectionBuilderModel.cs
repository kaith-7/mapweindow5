// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderModel.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Legend.Abstract;
using System.Collections.Generic;

namespace MW5.Attributes.Views
{
    public interface ISpatialSelectionBuilderModel
    {
        ILayerCollection<ILegendLayer> allLayers { get; }
        bool IsQuery { get; }
        ILayer LayerFilter { get; set; }
        IList<ILayer> layerSrc { get; }
        SpatialSelectionMode selectionMode { get; set; }
        SelectionOperation selectionType { get; set; }
    }
}