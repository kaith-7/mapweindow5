﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Mvp;
using MW5.Plugins.TableEditor.Model;

namespace MW5.Plugins.TableEditor.Views.Abstract
{
    public interface IFindReplaceView: IView<FindReplaceModel>
    {
        event Action Find;
        event Action Replace;
        event Action ReplaceAll;

        void UpdateSearchInfo();
        void ForceClose();
    }
}
