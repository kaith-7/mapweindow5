using MW5.Api;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Mvp;
using System;
using System.Windows.Forms;

namespace MW5.Services.Views.Abstract
{
    public interface ICreateLayerView : IView<CreateLayerModel>
    {
        string LayerName { get; }
        GeometryType GeometryType { get; }
        ZValueType ZValueType { get; }
        bool MemoryLayer { get; }

        Control ChooseButton { get; }
        event Action ChooseProjection;
        event Action<object, EventArgs> ChooseDataDictionary;
        ISpatialReference SR { get; set; }
        string DataDictionaryName { get; set; }
    }
}
