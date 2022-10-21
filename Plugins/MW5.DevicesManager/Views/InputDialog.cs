using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MW5.Plugins.DevicesManager
{
    public static class InputDialog
    {
        public static DialogResult Show(Form parent, out string strText)
        {
            string strTemp = string.Empty;

            CreateFolderForm inputDialog = new CreateFolderForm();
            inputDialog.StartPosition = FormStartPosition.CenterScreen;
            inputDialog.TopMost = true;
            inputDialog.TextHandler = (str) => { strTemp = str; };

            DialogResult result = inputDialog.ShowDialog();
            strText = strTemp;

            return result;
        }
    }
}
