﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Interfaces;
using MW5.Api.Legend.Abstract;
using MW5.Plugins.Concrete;
using MW5.Plugins.Events;
using MW5.Plugins.Mvp;

namespace MW5.Plugins.Interfaces
{
    public interface IMainView : IView
    {
        object DockingManager { get; }
        object MenuManager { get; }
        object StatusBar { get; }
        IMap Map { get; }
        IView View { get; }
        event EventHandler<CancelEventArgs> ViewClosing;
        event EventHandler<RenderedEventArgs> ViewUpdating;
        event Action BeforeShow;
        void Lock();
        void Unlock();
        void DoUpdateView(bool focusMap = true);
    }
}
