﻿// -------------------------------------------------------------------------------------------
// <copyright file="ChooseProjectionForm.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Interfaces.Projections;
using MW5.Plugins.Services;
using MW5.Projections.BL;
using MW5.UI.Forms;

namespace MW5.Projections.Forms
{
    /// <summary>
    /// Simple GUI fro choosing projection
    /// </summary>
    public partial class ChooseProjectionForm : MapWindowForm
    {
        /// <summary>
        /// Creates a new instance of frmProjectionChooser class. 
        /// It's assumed that database is read already.
        /// </summary>
        public ChooseProjectionForm(IProjectionDatabase database, IAppContext context)
            : base(context)
        {
            InitializeComponent();

            if (_projectionTreeView1.Initialize(database, context))
            {
                _projectionTreeView1.RefreshList();
            }

            btnOk.Click += btnOk_Click;

            txtSearch.Cue = "输入坐标系名称或EPSG代码";

            comboBoxAdv1.SelectedIndex = 0;

            ActiveControl = txtSearch;
        }

        public CoordinateSystem SelectedCoordinateSystem
        {
            get { return _projectionTreeView1.SelectedCoordinateSystem; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_projectionTreeView1.SelectedCoordinateSystem != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageService.Current.Info("没有选择投影。");
            }
        }

        private void ChooseProjectionForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _projectionTreeView1.Filter(txtSearch.Text, true);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked || txtSearch.Text.Length == 0)
            {
                _projectionTreeView1.Filter(txtSearch.Text);
            }
        }
    }
}