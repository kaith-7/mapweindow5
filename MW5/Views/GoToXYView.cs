// -------------------------------------------------------------------------------------------
// <copyright file="GoToXYView.cs" company="SUNTOON - www.suntoon.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using MW5.Api.Enums;
using MW5.UI.Forms;
using MW5.UI.Helpers;
using MW5.Views.Abstract;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;

namespace MW5.Views
{
    public partial class GoToXYView : MapWindowView, IGoToXYView
    {
        private readonly IAppContext _context;

        public GoToXYView(IAppContext ctx)
        {
            _context = ctx;

            InitializeComponent();

            this.KeyUp += GoToXYView_KeyUp;
            this.toolStripButton_GoToXY.Click += toolStripButton_GoToXY_Click;
        }

        private void GoToXYView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        public ButtonBase OkButton
        {
            get { return null; } // there is no OK button.
        }

        //public event Action PanTo;
        
        public PointF GetPoint()
        {
            float x, y;
            if (float.TryParse(doubleTextBox_X.Text, out x) && float.TryParse(doubleTextBox_Y.Text, out y))
            {
                return new PointF((float)doubleTextBox_X.DoubleValue, (float)doubleTextBox_Y.DoubleValue);
            }
            return PointF.Empty;
        }

        private void toolStripButton_GoToXY_Click(object sender, EventArgs e)
        {
            var pt = GetPoint();
            var extents = _context.Map.Extents;
            extents.MoveCenterTo(pt.X, pt.Y);
            _context.Map.ZoomToExtents(extents);

            System.Drawing.Graphics g = Graphics.FromHwnd(_context.Map.Handle);
            Rectangle rectCli = new Rectangle(0, 0, _context.Map.Width, _context.Map.Height);

            List<object> args = new List<object>();
            args.Add(g);
            args.Add(rectCli);
            if (backgroundWorker1.WorkerSupportsCancellation && backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                backgroundWorker1.RunWorkerAsync(args);
            }
        }

        delegate void MapRefreshCallback();

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _context.Map.Redraw();
            Graphics g = (Graphics)((List<object>)e.Argument)[0];
            Rectangle rectCli = (Rectangle)((List<object>)e.Argument)[1];
            System.Drawing.Point ptCnt = new System.Drawing.Point(rectCli.X + rectCli.Width / 2, rectCli.Y + rectCli.Height / 2);
            Rectangle rectDraw = new Rectangle(ptCnt.X - 6, ptCnt.Y - 6, 12, 12);
            Pen pen = new Pen(Color.Black, 1);
            Pen penLine = new Pen(Color.Black, 3);
            int width = rectCli.Width / 4;
            int height = rectCli.Height / 4;
            for (int i = 0; i <= 10; i++)
            {
                g.DrawLine(penLine, ptCnt.X, 0, ptCnt.X, height);
                g.DrawLine(penLine, ptCnt.X, rectCli.Height, ptCnt.X, rectCli.Height - height);
                g.DrawLine(penLine, 0, ptCnt.Y, width, ptCnt.Y);
                g.DrawLine(penLine, rectCli.Width, ptCnt.Y, rectCli.Width - width, ptCnt.Y);
                Thread.Sleep(10);
                height += rectCli.Height / 40;
                width += rectCli.Width / 40;
            }
            //if (_context.Map.InvokeRequired)
            {
                MapRefreshCallback d = new MapRefreshCallback(() => { _context.Map.Redraw(); });
                Invoke(d);
            }
            Thread.Sleep(100);
            g.DrawEllipse(pen, rectDraw);
            g.FillEllipse(System.Drawing.Brushes.Green, rectDraw);
            Thread.Sleep(500);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _context.Map.Redraw();
        }

        private void GoToXYView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((GoToXYView)sender).Hide();
            e.Cancel = true;
        }

        private void GoToXYView_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true && System.Diagnostics.Debugger.IsAttached)
            {
                this.doubleTextBox_X.DoubleValue = _context.Map.Extents.Center.X;
                this.doubleTextBox_Y.DoubleValue = _context.Map.Extents.Center.Y;
            }
        }
    }
}