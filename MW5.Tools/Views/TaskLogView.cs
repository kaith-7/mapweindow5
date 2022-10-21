﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Enums;
using MW5.Plugins.Events;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Shared;
using MW5.Shared.Log;
using MW5.Tools.Model;
using MW5.Tools.Properties;
using MW5.Tools.Views.Abstract;
using MW5.UI.Forms;

namespace MW5.Tools.Views
{
    /// <summary>
    /// Displays log messages and progress of tool execution.
    /// </summary>
    internal partial class TaskLogView : ToolLogViewBase, ITaskLogView
    {
        private readonly Timer _timer = new Timer();

        public TaskLogView()
        {
            InitializeComponent();
            
            this.MinimumSize = this.Size;

            FormClosed += OnFormClosed;

            btnCancel.Click += (s,e) => Invoke(Cancel);

            btnPause.Click += (s, e) => Invoke(Pause);

            Shown += (s, e) =>
                {
                    textBoxExt1.BorderStyle = BorderStyle.None;
                    Refresh();
                };
        }
        
        public event Action Cancel;

        public event Action Pause;

        private GisTool Tool
        {
            get { return Model.Tool as GisTool; }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            DetachProgressHandlers();

            Model.StatusChanged -= OnTaskStatusChanged;

            Tool.Log.EntryAdded -= OnLogMessageAdded;
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            UpdateView();

            AttachProgressHandlers();

            Model.StatusChanged += OnTaskStatusChanged;

            DisplayExistingLogEntries();

            btnCancel.Enabled = Tool.SupportsCancel;

            if (!Model.IsFinished)
            {
                StartTimer();
            }
        }

        private void DisplayExistingLogEntries()
        {
            var log = Tool.Log;
            
            log.Lock();
            try
            {
                Tool.Log.EntryAdded += OnLogMessageAdded;

                var sb = new StringBuilder();
                foreach (var item in log.Entries)
                {
                    sb.Append(GetEntryLine(item));
                }

                textBoxExt1.Text = sb.ToString();
            }
            finally
            {
                log.UnLock();
            }
        }

        private void OnLogMessageAdded(object sender, LogEventArgs e)
        {
            if (!Visible)
            {
                return;
            }
            
            Action action = () =>
                {
                    // without locking Application.DoEvents produces race condition
                    // resulting in recursive calls once in a while (StackOverflowException);
                    // it appears that sometimes the message, isn't removed from the queue 
                    // before we start processing messages with DoEvents
                    lock (textBoxExt1)
                    {
                        textBoxExt1.AppendText(GetEntryLine(e.Entry));

                        // make sure that we can still react to the user clicks if messages
                        // are reported too often (on each operation step)
                        Application.DoEvents();
                    }
                };

            lock (textBoxExt1)
            {
                textBoxExt1.SafeInvoke(action);
            }
        }

        private string GetEntryLine(ILogEntry entry)
        {
            return entry.GetCompleteDescription(true) + Environment.NewLine;
        }

        private void OnTaskStatusChanged(object sender, TaskStatusChangedEventArgs e)
        {
            this.SafeInvoke(UpdateView);
        }

        public override void UpdateView()
        {
            UpdateDialogCaption();

            if (Model.IsFinished)
            {
                btnClose.Text = "关闭";
                panelProgress.Visible = false;
                panelResults.Visible = true;
                UpdateFinishedTaskStatus();
                ScrollToLogEnd();
            }
            else
            {
                btnClose.Text = "后台运行";
                panelProgress.Visible = true;
                panelResults.Visible = false;
                UpdateRunningTask();
            }
        }

        private void ScrollToLogEnd()
        {
            textBoxExt1.SelectionStart = textBoxExt1.TextLength;
            textBoxExt1.ScrollToCaret();
        }


        private void UpdateRunningTask()
        {
            switch (Model.Status)
            {
                case GisTaskStatus.Running:
                    btnPause.Text = "暂停";
                    panelProgress.Text = "正在运行";
                    break;
                case GisTaskStatus.Paused:
                    btnPause.Text = "恢复";
                    panelProgress.Text = "已暂停";
                    break;
            }
        }

        private void UpdateFinishedTaskStatus()
        {
            lblExecutionTime.Text = "运行时间: " + Model.ExecutionTime;

            switch (Model.Status)
            {
                case GisTaskStatus.Success:
                    lblStatus.Text = "工具运行成功。";
                    pictureBox1.Image = Resources.img_success32;
                    break;
                case GisTaskStatus.Failed:
                    lblStatus.Text = "工具运行失败。";
                    pictureBox1.Image = Resources.img_error32;
                    break;
                case GisTaskStatus.Cancelled:
                    lblStatus.Text = "工具运行取消。";
                    pictureBox1.Image = Resources.img_cancel32;
                    break;
            }
        }

        private void UpdateDialogCaption()
        {
            string msg = Model.IsFinished ? "完成" : "运行中";
            Text = msg + ": " + Model.Tool.Name;
        }

        private void DetachProgressHandlers()
        {
            var progress = Model.Progress;
            progress.ProgressChanged -= OnProgressChanged;
            progress.Hide -= OnProgressHide;
        }

        private void AttachProgressHandlers()
        {
            var progress = Model.Progress;
            progress.ProgressChanged += OnProgressChanged;
            progress.Hide += OnProgressHide;
        }

        public override ViewStyle Style
        {
            get { return new ViewStyle() { Modal = true, Sizable = true, }; }
        }

        public ButtonBase OkButton
        {
            get { return btnClose; }
        }

        private void OnProgressHide(object sender, EventArgs e)
        {
            if (!Visible)
            {
                return;
            }

            Action action = () => { panelProgress.Visible = false; };

            progressBar1.SafeInvoke(action);
        }

        private void OnProgressChanged(object sender, ProgressEventArgs e)
        {
            if (!Visible)
            {
                return;
            }

            Action action = () =>
                {
                    if (progressBar1.Value != e.Percent && e.Percent >= 0 && e.Percent <= 100)
                    {
                        panelProgress.Visible = true;
                        progressBar1.Value = e.Percent;
                        lblPercent.Text = e.Message; // + " " + e.Percent.ToString(CultureInfo.InvariantCulture) + "%";
                        lblPercent.Refresh();
                    }
                };

            // use the same control as the one to report log messages
            // so all the messages are queued in the same order as they arrive
            textBoxExt1.SafeInvoke(action);
        }

        private void StartTimer()
        {
            _timer.Tick += (s, e) =>
            {
                lblElapsed.Text = "耗时: " + Model.ExecutionTime.ToString(@"hh\:mm\:ss");
                if (Model.IsFinished)
                {
                    _timer.Stop();
                }
            };
            _timer.Interval = 1000;
            _timer.Start();
        }
    }

    public class ToolLogViewBase : MapWindowView<IGisTask> { }
}
