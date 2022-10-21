using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Services.Controls;
using MW5.Services.Views.Abstract;

namespace MW5.Services.Views
{
    public class MissingLayersPresenter: BasePresenter<IMissingLayersView, List<MissingLayer>>
    {
        public MissingLayersPresenter(IMissingLayersView view) : base(view)
        {
        }

        public bool ValidateModel()
        {
            if (Model.Exists(l => !File.Exists(l.Filename)))
            {
                return MessageService.Current.Ask("某些图层的数据源仍然缺失。 " + Environment.NewLine +
                                                  "在没有这些图层的情况下打开?");
                
            }

            return true;
        }

        public override bool ViewOkClicked()
        {
            return ValidateModel();
        }
    }
}
