using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW5.Plugins.DevicesManager
{
    public partial class FormProgress : Form
    {
        public int MaxValue
        {
            get { return progressBarAdv1.Maximum; }
            set
            {
                progressBarAdv1.Value = 0;
                progressBarAdv1.Maximum = value;
            }
        }

        public System.Threading.Thread WorkThrad = null;

        public FormProgress(int maxVal = 100)
        {
            InitializeComponent();

            MaxValue = maxVal;
        }

        public void Increment(string text = "")
        {
            if (this.InvokeRequired)
            {
                System.Action act = () =>
                {
                    autoLabel1.Text = text;
                    progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
                    progressBarAdv1.Increment();
                    this.Invalidate();
                };
                this.Invoke(act);
            }
            else
            {
                autoLabel1.Text = text;
                progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
                progressBarAdv1.Increment();
                autoLabel1.Invalidate();
            }
        }

        private void FormProgress_Load(object sender, EventArgs e)
        {
            progressBarAdv1.Value = 0;
            progressBarAdv1.Step = 1;

            WorkThrad?.Start();

            new System.Threading.Thread(() =>
            {
                int lastVal = 0;
                while (!this.IsDisposed)
                {
                    System.Threading.Thread.Sleep(1000);
                    progressBarAdv1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        if (lastVal == progressBarAdv1.Value)
                            progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
                        else
                            progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
                        lastVal = progressBarAdv1.Value;
                    });
                }
            }).Start();
        }
    }
}
