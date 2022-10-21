namespace MW5.Tools.Views
{
    partial class TasksDockPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksDockPanel));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.tasksTreeView1 = new MW5.Tools.Views.TasksTreeView();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.toolOpenLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRerun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRunAnother = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCancelTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPauseTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOpenLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRemoveTask = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolClear = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeView1)).BeginInit();
            this.contextMenuStripEx1.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            resources.ApplyResources(this.splitContainerAdv1, "splitContainerAdv1");
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            resources.ApplyResources(this.splitContainerAdv1.Panel1, "splitContainerAdv1.Panel1");
            this.splitContainerAdv1.Panel1.Controls.Add(this.tasksTreeView1);
            // 
            // splitContainerAdv1.Panel2
            // 
            resources.ApplyResources(this.splitContainerAdv1.Panel2, "splitContainerAdv1.Panel2");
            this.splitContainerAdv1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainerAdv1.SplitterDistance = 217;
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // tasksTreeView1
            // 
            resources.ApplyResources(this.tasksTreeView1, "tasksTreeView1");
            this.tasksTreeView1.ApplyStyle = true;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.tasksTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tasksTreeView1.BeforeTouchSize = new System.Drawing.Size(329, 217);
            this.tasksTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tasksTreeView1.ContextMenuStrip = this.contextMenuStripEx1;
            // 
            // 
            // 
            this.tasksTreeView1.HelpTextControl.AccessibleDescription = resources.GetString("tasksTreeView1.HelpTextControl.AccessibleDescription");
            this.tasksTreeView1.HelpTextControl.AccessibleName = resources.GetString("tasksTreeView1.HelpTextControl.AccessibleName");
            this.tasksTreeView1.HelpTextControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tasksTreeView1.HelpTextControl.Anchor")));
            this.tasksTreeView1.HelpTextControl.AutoScroll = ((bool)(resources.GetObject("tasksTreeView1.HelpTextControl.AutoScroll")));
            this.tasksTreeView1.HelpTextControl.AutoSize = ((bool)(resources.GetObject("tasksTreeView1.HelpTextControl.AutoSize")));
            this.tasksTreeView1.HelpTextControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("tasksTreeView1.HelpTextControl.AutoSizeMode")));
            this.tasksTreeView1.HelpTextControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tasksTreeView1.HelpTextControl.BackgroundImage")));
            this.tasksTreeView1.HelpTextControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("tasksTreeView1.HelpTextControl.BackgroundImageLayout")));
            this.tasksTreeView1.HelpTextControl.BaseThemeName = null;
            this.tasksTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasksTreeView1.HelpTextControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tasksTreeView1.HelpTextControl.Dock")));
            this.tasksTreeView1.HelpTextControl.Font = ((System.Drawing.Font)(resources.GetObject("tasksTreeView1.HelpTextControl.Font")));
            this.tasksTreeView1.HelpTextControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tasksTreeView1.HelpTextControl.ImeMode")));
            this.tasksTreeView1.HelpTextControl.Location = ((System.Drawing.Point)(resources.GetObject("tasksTreeView1.HelpTextControl.Location")));
            this.tasksTreeView1.HelpTextControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("tasksTreeView1.HelpTextControl.MaximumSize")));
            this.tasksTreeView1.HelpTextControl.Name = "helpText";
            this.tasksTreeView1.HelpTextControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tasksTreeView1.HelpTextControl.RightToLeft")));
            this.tasksTreeView1.HelpTextControl.Size = ((System.Drawing.Size)(resources.GetObject("tasksTreeView1.HelpTextControl.Size")));
            this.tasksTreeView1.HelpTextControl.TabIndex = ((int)(resources.GetObject("tasksTreeView1.HelpTextControl.TabIndex")));
            this.tasksTreeView1.HelpTextControl.Text = resources.GetString("tasksTreeView1.HelpTextControl.Text");
            this.tasksTreeView1.HelpTextControl.Visible = ((bool)(resources.GetObject("tasksTreeView1.HelpTextControl.Visible")));
            this.tasksTreeView1.HideSelection = false;
            this.tasksTreeView1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tasksTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tasksTreeView1.Name = "tasksTreeView1";
            this.tasksTreeView1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            ((Syncfusion.Windows.Forms.Tools.TreeNodeAdv)(resources.GetObject("tasksTreeView1.Nodes")))});
            this.tasksTreeView1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tasksTreeView1.ShowSuperTooltip = false;
            this.tasksTreeView1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.tasksTreeView1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.tasksTreeView1.ToolTipControl.AccessibleDescription = resources.GetString("tasksTreeView1.ToolTipControl.AccessibleDescription");
            this.tasksTreeView1.ToolTipControl.AccessibleName = resources.GetString("tasksTreeView1.ToolTipControl.AccessibleName");
            this.tasksTreeView1.ToolTipControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tasksTreeView1.ToolTipControl.Anchor")));
            this.tasksTreeView1.ToolTipControl.AutoScroll = ((bool)(resources.GetObject("tasksTreeView1.ToolTipControl.AutoScroll")));
            this.tasksTreeView1.ToolTipControl.AutoSize = ((bool)(resources.GetObject("tasksTreeView1.ToolTipControl.AutoSize")));
            this.tasksTreeView1.ToolTipControl.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("tasksTreeView1.ToolTipControl.AutoSizeMode")));
            this.tasksTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.tasksTreeView1.ToolTipControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tasksTreeView1.ToolTipControl.BackgroundImage")));
            this.tasksTreeView1.ToolTipControl.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("tasksTreeView1.ToolTipControl.BackgroundImageLayout")));
            this.tasksTreeView1.ToolTipControl.BaseThemeName = null;
            this.tasksTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasksTreeView1.ToolTipControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tasksTreeView1.ToolTipControl.Dock")));
            this.tasksTreeView1.ToolTipControl.Font = ((System.Drawing.Font)(resources.GetObject("tasksTreeView1.ToolTipControl.Font")));
            this.tasksTreeView1.ToolTipControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tasksTreeView1.ToolTipControl.ImeMode")));
            this.tasksTreeView1.ToolTipControl.Location = ((System.Drawing.Point)(resources.GetObject("tasksTreeView1.ToolTipControl.Location")));
            this.tasksTreeView1.ToolTipControl.MaximumSize = ((System.Drawing.Size)(resources.GetObject("tasksTreeView1.ToolTipControl.MaximumSize")));
            this.tasksTreeView1.ToolTipControl.Name = "toolTip";
            this.tasksTreeView1.ToolTipControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tasksTreeView1.ToolTipControl.RightToLeft")));
            this.tasksTreeView1.ToolTipControl.Size = ((System.Drawing.Size)(resources.GetObject("tasksTreeView1.ToolTipControl.Size")));
            this.tasksTreeView1.ToolTipControl.TabIndex = ((int)(resources.GetObject("tasksTreeView1.ToolTipControl.TabIndex")));
            this.tasksTreeView1.ToolTipControl.Text = resources.GetString("tasksTreeView1.ToolTipControl.Text");
            this.tasksTreeView1.ToolTipControl.Visible = ((bool)(resources.GetObject("tasksTreeView1.ToolTipControl.Visible")));
            this.tasksTreeView1.ToolTipDuration = 0;
            // 
            // contextMenuStripEx1
            // 
            resources.ApplyResources(this.contextMenuStripEx1, "contextMenuStripEx1");
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpenLog,
            this.toolRerun,
            this.toolRunAnother,
            this.toolStripSeparator2,
            this.toolCancelTask,
            this.toolPauseTask,
            this.toolStripSeparator1,
            this.mnuOpenLocation,
            this.toolStripSeparator3,
            this.toolRemoveTask,
            this.mnuRemoveOutput});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            this.contextMenuStripEx1.ThemeName = "Default";
            // 
            // toolOpenLog
            // 
            resources.ApplyResources(this.toolOpenLog, "toolOpenLog");
            this.toolOpenLog.Name = "toolOpenLog";
            // 
            // toolRerun
            // 
            resources.ApplyResources(this.toolRerun, "toolRerun");
            this.toolRerun.Name = "toolRerun";
            // 
            // toolRunAnother
            // 
            resources.ApplyResources(this.toolRunAnother, "toolRunAnother");
            this.toolRunAnother.Name = "toolRunAnother";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolCancelTask
            // 
            resources.ApplyResources(this.toolCancelTask, "toolCancelTask");
            this.toolCancelTask.Name = "toolCancelTask";
            // 
            // toolPauseTask
            // 
            resources.ApplyResources(this.toolPauseTask, "toolPauseTask");
            this.toolPauseTask.Name = "toolPauseTask";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // mnuOpenLocation
            // 
            resources.ApplyResources(this.mnuOpenLocation, "mnuOpenLocation");
            this.mnuOpenLocation.Name = "mnuOpenLocation";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolRemoveTask
            // 
            resources.ApplyResources(this.toolRemoveTask, "toolRemoveTask");
            this.toolRemoveTask.Name = "toolRemoveTask";
            // 
            // mnuRemoveOutput
            // 
            resources.ApplyResources(this.mnuRemoveOutput, "mnuRemoveOutput");
            this.mnuRemoveOutput.Name = "mnuRemoveOutput";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Name = "richTextBox1";
            // 
            // toolStripEx1
            // 
            resources.ApplyResources(this.toolStripEx1, "toolStripEx1");
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolClear});
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ShowItemToolTips = true;
            // 
            // toolClear
            // 
            resources.ApplyResources(this.toolClear, "toolClear");
            this.toolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolClear.Image = global::MW5.Tools.Properties.Resources.img_clear24;
            this.toolClear.Name = "toolClear";
            this.toolClear.Padding = new System.Windows.Forms.Padding(3);
            // 
            // TasksDockPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.toolStripEx1);
            this.Name = "TasksDockPanel";
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeView1)).EndInit();
            this.contextMenuStripEx1.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolClear;
        private TasksTreeView tasksTreeView1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private System.Windows.Forms.ToolStripMenuItem toolOpenLog;
        private System.Windows.Forms.ToolStripMenuItem toolCancelTask;
        private System.Windows.Forms.ToolStripMenuItem toolPauseTask;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolRemoveTask;
        private System.Windows.Forms.ToolStripMenuItem toolRerun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolRunAnother;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveOutput;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenLocation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
