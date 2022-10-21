﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Helpers;
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
    public partial class MapConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _configService;

        public MapConfigPage(IConfigService configService)
        {
            if (configService == null) throw new ArgumentNullException("configService");

            _configService = configService;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        private void InitControls()
        {
            cboAnimationOnZooming.AddItemsFromEnum<AutoToggle>();
            cboInertiaOnPanning.AddItemsFromEnum<AutoToggle>();
            cboMapResizeBehavior.AddItemsFromEnum<ResizeBehavior>();
            
            cboZoomBoxStyle.AddItemsFromEnum<ZoomBoxStyle>();
            cboZoomBehavior.AddItemsFromEnum<ZoomBehavior>();
            cboMouseWheelDirection.AddItemsFromEnum<MouseWheelDirection>();
        }

        public void Initialize()
        {
            var config = _configService.Config;
            
            cboAnimationOnZooming.SetValue(config.AnimationOnZooming);
            cboMapResizeBehavior.SetValue(config.ResizeBehavior);
           
            cboZoomBoxStyle.SetValue(config.ZoomBoxStyle);
            cboInertiaOnPanning.SetValue(config.InnertiaOnPanning);
            cboZoomBehavior.SetValue(config.ZoomBehavior);
            cboMouseWheelDirection.SetValue(config.MouseWheelDirection);
            txtMouseTolerance.IntegerValue = config.MouseTolerance;

            chkReuseTileBuffer.Checked = config.ReuseTileBuffer;

            clpBackground.Color = config.MapBackgroundColor;
        }

        public string PageName
        {
            get { return "布局"; }
        }

        public void Save()
        {
            var config = _configService.Config;

            config.AnimationOnZooming = cboAnimationOnZooming.GetValue<AutoToggle>();
            config.ResizeBehavior = cboMapResizeBehavior.GetValue<ResizeBehavior>();
            
            config.ZoomBoxStyle = cboZoomBoxStyle.GetValue<ZoomBoxStyle>();
            config.InnertiaOnPanning = cboInertiaOnPanning.GetValue<AutoToggle>();
            config.ZoomBehavior = cboZoomBehavior.GetValue<ZoomBehavior>();
            config.MouseWheelDirection = cboMouseWheelDirection.GetValue<MouseWheelDirection>();

            config.ReuseTileBuffer = chkReuseTileBuffer.Checked;

            config.MapBackgroundColor = clpBackground.Color;
            config.MouseTolerance = Convert.ToInt32(txtMouseTolerance.IntegerValue);
        }

        public Bitmap Icon
        {
            get { return Resources.img_globe32; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.General; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Map; }
        }

        public string Description
        {
            get { return "关于外观、布局和使用习惯的设置。"; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
