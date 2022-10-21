using System;
using MW5.Plugins.Mvp;

namespace MW5.Attributes.Views.Abstract
{
    public interface ISpatialSelectionBuilderView : IView<ISpatialSelectionBuilderModel>
    {
        event Action RunClicked;

        void UpdateModel();
    }
}
