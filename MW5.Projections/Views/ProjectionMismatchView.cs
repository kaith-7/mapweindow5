// -------------------------------------------------------------------------------------------
// <copyright file="ProjectionMismatchView.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Windows.Forms;
using MW5.Plugins.Enums;
using MW5.Projections.Views.Abstract;
using MW5.Shared;
using MW5.UI.Forms;

namespace MW5.Projections.Views
{
    public partial class ProjectionMismatchView : ProjectionMismatchViewBase, IProjectionMismatchView
    {
        public ProjectionMismatchView()
        {
            InitializeComponent();

            btnDetails.Click += (s, e) => Invoke(DetailsClicked);

            this.btnReproject.Visible = false;
            this.btnIgnore.Visible = false;
            this.btnSkip.Visible = false;

            this.btnCancel.Text = "关闭";
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            if (Model.IsMismatch)
            {
                Text = "投影不匹配";
                lblMessage.Text = "图层的坐标系或投影与工程的坐标系不同。为了确保图层的正确显示，可能需要重新投影。";
            }
            else
            {
                btnReproject.Text = "分配";
                //btnReproject.Visible = true;
                //this.btnCancel.Text = "取消";
                Text = "缺少投影信息";
                lblMessage.Text = "图层的坐标系和投影是未知的。 将项目的坐标系分配给该图层。";
            }

            btnDetails.Visible = Model.IsMismatch;

            DisplayDatasourceInfo();
        }

        private void DisplayDatasourceInfo()
        {
            string filename = Model.LayerSource.Filename;
            lblFilename.Text = "文件: " + filename;

            if (File.Exists(filename))
            {
                var info = new FileInfo(filename);
                lblSize.Text = "大小: " + NumericHelper.FormatFileSize(info.Length);
            }
            else
            {
                lblSize.Text = "Size: not defined";
            }
        }

        public ButtonBase OkButton
        {
            get { return null; }
        }

        public event Action DetailsClicked;

        private void OnIgnoreClick(object sender, EventArgs e)
        {
            if (Model.IsMismatch)
            {
                Model.MismatchBehavior = ProjectionMismatch.IgnoreMismatch;
            }
            else
            {
                Model.AbsenceBehavior = ProjectionAbsence.IgnoreAbsence;
            }

            SaveCheckboxes();

            DialogResult = DialogResult.OK;
        }

        private void OnReprojectClick(object sender, EventArgs e)
        {
            if (Model.IsMismatch)
            {
                Model.MismatchBehavior = ProjectionMismatch.Reproject;
            }
            else
            {
                Model.AbsenceBehavior = ProjectionAbsence.AssignFromProject;
            }

            SaveCheckboxes();

            DialogResult = DialogResult.OK;
        }

        private void OnSkipClick(object sender, EventArgs e)
        {
            if (Model.IsMismatch)
            {
                Model.MismatchBehavior = ProjectionMismatch.SkipFile;
            }
            else
            {
                Model.AbsenceBehavior = ProjectionAbsence.SkipFile;
            }

            SaveCheckboxes();

            
            DialogResult = DialogResult.OK;
        }

        private void SaveCheckboxes()
        {
            Model.DontShow = chkDontShow.Checked;
            Model.UseAnswerLater = chkUseAnswerLater.Checked;
        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }

    public class ProjectionMismatchViewBase : MapWindowView<ProjectionMismatchModel>
    {
    }
}