// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderModel.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Legend.Abstract;

namespace MW5.Attributes.Views
{
    public class SpatialQueryBuilderModel : BaseSpatialSelectionBuilderModel
    {
        public SpatialQueryBuilderModel(ILayerCollection<ILegendLayer> layers)
            : base(layers) { }
    }
}