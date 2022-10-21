using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Interfaces;

namespace MW5.Views.Abstract
{
    internal interface IGoToXYView: IView
    {
        //event Action PanTo;
        PointF GetPoint();
    }
}
