﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Concrete;
using MW5.Plugins.Mvp;

namespace MW5.Plugins.Symbology.Views.Abstract
{
    public interface IRasterColorSchemeView: IView<RasterColorScheme>, IMenuProvider
    {
        BindingList<RasterInterval> Intervals { get; }
        RasterInterval SelectedInterval { get; }
    }
}
