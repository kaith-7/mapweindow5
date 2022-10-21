using System;
using MW5.Plugins.Mvp;



namespace MW5.Plugins.PictureView.Views.Abstract
{
    interface IPolygonPictureView: IView
    {
        event Action Search;
        string Picpath { get; }
    }
}
