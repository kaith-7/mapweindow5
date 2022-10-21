using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using MW5.Attributes.Views;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;

namespace MW5.Attributes.Helpers
{
    public static class JoinHelper
    {
        /// <summary>
        /// Stops all joins of the table.
        /// </summary>
        public static bool StopAllJoins(IAttributeTable table)
        {
            if (table == null) throw new ArgumentNullException("table");

            if (!table.Joins.Any())
            {
                MessageService.Current.Info("此表未关联。");
                return false;
            }

            if (MessageService.Current.Ask("移除所有关联?"))
            {
                table.StopAllJoins();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Open dialog to choose a single datasource and join it.
        /// </summary>
        public static bool AddJoin(IAppContext context, IAttributeTable table)
        {
            var model = new JoinViewModel(table);

            if (context.Container.Run<JoinTablePresenter, JoinViewModel>(model))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Opens dialog to edit currently selected join.
        /// </summary>
        public static bool EditJoin(IAppContext context, IAttributeTable table, FieldJoin join)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (table == null) throw new ArgumentNullException("table");

            if (join == null)
            {
                MessageService.Current.Info("未选择关联。");
                return false;
            }

            var model = new JoinViewModel(table, join);

            return context.Container.Run<JoinTablePresenter, JoinViewModel>(model);
        }

        /// <summary>
        /// Stops currently selected join.
        /// </summary>
        public static bool StopJoin(IAttributeTable table, FieldJoin join)
        {
            if (table == null) throw new ArgumentNullException("table");

            if (join == null)
            {
                MessageService.Current.Info("未选择关联。");
                return false;
            }

            string filename = join.Filename;

            if (!MessageService.Current.Ask("停止关联: " + filename + "?"))
            {
                return false;
            }

            if (table.StopJoin(join.JoinIndex))
            {
                filename = Path.GetFileName(filename);
                MessageService.Current.Info("关联已停止: " +  filename);
                return true;
            }
            
            return false;
        }
    }
}
