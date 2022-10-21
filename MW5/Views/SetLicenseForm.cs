using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW5.Views
{
    public partial class SetLicenseForm : Form
    {
        public SetLicenseForm(string serial, string msg)
        {
            InitializeComponent();

            this.textBoxSerial.Text = serial;
            this.label4.Text = msg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "授权文件(*.lic)|*.lic";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.textBoxLicFile.Text = dlg.FileName;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var srcFile = this.textBoxLicFile.Text;
            if (!System.IO.File.Exists(srcFile))
            {
                MessageBox.Show("请输入正确的文件路径");
                DialogResult = DialogResult.None;
                return;
            }

            var destPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "verifyLic");
            var startInfo = new System.Diagnostics.ProcessStartInfo("xcopy", string.Format($"/Y \"{srcFile}\" \"{destPath}\""));
            startInfo.UseShellExecute = true;
            startInfo.Verb = "runas";
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            var process = System.Diagnostics.Process.Start(startInfo);
            process.WaitForExit();
        }
    }
}
