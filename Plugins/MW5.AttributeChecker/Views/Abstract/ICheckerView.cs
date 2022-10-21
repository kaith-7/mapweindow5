using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Plugins.Mvp;
using MW5.Shared.CheckResult;

namespace MW5.Plugins.AttributeChecker.Views.Abstract
{
    public interface ICheckerView : IMenuProvider
    {
        void Clear();
        //event Action<object, DataGridViewCellEventArgs> RowSelected;

        void EntryAdd(ILayerCheckResult res);
        void EntryAddRange(IList<ILayerCheckResult> res);
    }
}
