using System;
using System.Windows.Forms;

namespace MW5.Plugins.DevicesManager
{
    public partial class CreateFolderForm : Form
    {
        public delegate void TextEventHandler(string strText);

        public TextEventHandler TextHandler;

        public CreateFolderForm()
        {
            InitializeComponent();
            this.btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (null != TextHandler)
            {
                TextHandler.Invoke(txtString.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnOK.Enabled && Keys.Enter == (Keys)e.KeyChar)
            {
                if (null != TextHandler)
                {
                    TextHandler.Invoke(txtString.Text);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = !string.IsNullOrEmpty(txtString.Text.Trim());
        }
    }
}
