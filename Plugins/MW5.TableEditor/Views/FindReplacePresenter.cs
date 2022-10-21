using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.TableEditor.Helpers;
using MW5.Plugins.TableEditor.Model;
using MW5.Plugins.TableEditor.Views.Abstract;

namespace MW5.Plugins.TableEditor.Views
{
    public class FindReplacePresenter: BasePresenter<IFindReplaceView, FindReplaceModel>
    {
        public FindReplacePresenter(IFindReplaceView view) : base(view)
        {
            view.Find += OnFind;
            view.ReplaceAll += OnReplaceAll;
            view.Replace += OnReplace;
        }

        private bool ValidateSearchString()
        {
            if (string.IsNullOrWhiteSpace(Model.SearchInfo.Token))
            {
                MessageService.Current.Info("搜索字符串为空。");
                return false;
            }

            return true;
        }

        private void OnReplace()
        {
            View.UpdateSearchInfo();

            if (!ValidateSearchString()) return;

            if (!Model.Grid.Replace(Model.SearchInfo))
            {
                MessageService.Current.Info("没有发现更多替换的字符串。");
            }
        }

        private void OnReplaceAll()
        {
            View.UpdateSearchInfo();

            if (!ValidateSearchString()) return;
            
            int count = Model.Grid.ReplaceAll(Model.SearchInfo);

            if (count == 0)
            {
                MessageService.Current.Info("找不到替换的搜索实例。");
            }
            else
            {
                MessageService.Current.Info("替换值的数量: " + count);
            }
        }

        private void OnFind()
        {
            View.UpdateSearchInfo();

            if (!ValidateSearchString()) return;

            var info = Model.SearchInfo;

            if (!Model.Grid.FindNext(info))
            {
                if (info.Count == 1)
                {
                    MessageService.Current.Info("仅找到搜索字符串的一个实例。");
                }
                else if (info.Count > 1)
                {
                    if (MessageService.Current.Ask("所有已搜索的实例。" + Environment.NewLine +
                                                    "您要重新开始搜索吗?"))
                    {
                        info.RestartSearch = true;
                        Model.Grid.FindNext(info);
                    }
                }
                else
                {
                    MessageService.Current.Info("找不到符合条件的记录。");
                }
            }
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
