using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.AttributeChecker.Views.Abstract;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Shared;

namespace MW5.Plugins.AttributeChecker.Views
{
    public class CheckResultPresenter: CommandDispatcher<ICheckerView, CheckerCommand>, IDockPanelPresenter
    {
        private readonly IBroadcasterService _broadcaster;
        private readonly ICheckerView _dockView;

        public CheckResultPresenter(IBroadcasterService broadcaster, ICheckerView dockView)
            :base(dockView)
        {
            _dockView = dockView ?? throw new ArgumentNullException("dockView");
            _broadcaster = broadcaster ?? throw new ArgumentNullException("broadcaster");

            //View.RowSelected += View_RowSelected;
            //var broadcaster = context.Container.Resolve<IBroadcasterService>();
        }

        private void View_RowSelected(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public Control GetInternalObject()
        {
            return _dockView as Control;
        }

        public override void RunCommand(CheckerCommand command)
        {
            switch (command)
            {
                case CheckerCommand.ClearLog:
                    View.Clear();
                    break;
                case CheckerCommand.ClearFilter:
                    MessageService.Current.Info("Not implemented");
                    break;
            }
        }
    }
}
