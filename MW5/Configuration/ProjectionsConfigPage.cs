using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Properties;
using MW5.Services.Config;
using MW5.Shared;
using MW5.UI.Controls;
using MW5.UI.Helpers;

namespace MW5.Configuration
{
    public partial class ProjectionsConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _configService;

        public ProjectionsConfigPage(IConfigService configService)
        {
            if (configService == null) throw new ArgumentNullException("configService");
            _configService = configService;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        private  void InitControls()
        {
            cboProjectionAbsence.AddItemsFromEnum<ProjectionAbsence>();
            cboProjectionMismatch.AddItemsFromEnum<ProjectionMismatch>();
        }

        public void Initialize()
        {
            var config = _configService.Config;
            
            chkProjectionDialog.Checked = config.ShowProjectionMismatchDialog;

            cboProjectionAbsence.SetValue(config.ProjectionAbsence);
            cboProjectionMismatch.SetValue(config.ProjectionMismatch);
        }

        public string PageName
        {
            get { return "投影"; }
        }

        public void Save()
        {
            var config = _configService.Config;

            config.ShowProjectionMismatchDialog = chkProjectionDialog.Checked;

            config.ProjectionAbsence = cboProjectionAbsence.GetValue<ProjectionAbsence>();
            config.ProjectionMismatch = cboProjectionMismatch.GetValue<ProjectionMismatch>();
        }

        public Bitmap Icon
        {
            get { return Resources.img_coordinates32; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.General; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Projections; }
        }

        public string Description
        {
            get { return "关于投影坐标系的设置。"; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chkProjectionDialog_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
