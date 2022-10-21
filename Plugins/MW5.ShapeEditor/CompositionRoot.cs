﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Concrete;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.ShapeEditor.Context;
using MW5.Plugins.ShapeEditor.Helpers;
using MW5.Plugins.ShapeEditor.Menu;
using MW5.Plugins.ShapeEditor.Services;
using MW5.Plugins.ShapeEditor.Views;
using MW5.Plugins.ShapeEditor.Views.Abstract;
using MW5.Services;

namespace MW5.Plugins.ShapeEditor
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<IGeoprocessingService, GeoprocessingService>()
                .RegisterSingleton<ILayerEditingService, LayerEditingService>()
                .RegisterService<ContextMenuView>()
                .RegisterSingleton<ContextMenuPresenter>()
                .RegisterService<IAttributeView, AttributeView>();
        }
    }
}


