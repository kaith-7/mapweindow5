﻿using System;
using System.Drawing;
using MW5.Api.Static;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Properties;
using MW5.Shared;
using MW5.UI.Controls;
using MW5.UI.Helpers;

namespace MW5.Configuration
{
    public partial class VectorConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _configService;

        public VectorConfigPage(IConfigService configService)
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
            
            chkCreateSpatialIndex.Checked = config.CreateSpatialIndexOnOpening;
            chkSpatialIndexDialog.Checked = config.ShowSpatialIndexDialog;

            chkFastMode.Checked = MapConfig.ShapefileFastMode;
            chkCacheDbfRecords.Checked = config.CacheDbfRecords;
            chkCacheRenderingData.Checked = config.CacheRenderingData;
            chkShareConnection.Checked = config.OgrShareConnection;

            txtMaxOgrCount.IntegerValue = config.OgrMaxFeatureCount;

            udSpatialIndexCount.SetValue(config.SpatialIndexFeatureCount);
        }

        public string PageName
        {
            get { return "矢量"; }
        }

        public void Save()
        {
            var config = _configService.Config;

            config.CreateSpatialIndexOnOpening = chkCreateSpatialIndex.Checked;
            config.ShowSpatialIndexDialog = chkSpatialIndexDialog.Checked;

            config.CacheDbfRecords = chkCacheDbfRecords.Checked;
            config.CacheRenderingData = chkCacheRenderingData.Checked;

            config.OgrMaxFeatureCount = (int)txtMaxOgrCount.IntegerValue;
            config.OgrShareConnection = chkShareConnection.Checked;

            config.SpatialIndexFeatureCount = (int)udSpatialIndexCount.Value;
        }

        public Bitmap Icon
        {
            get { return Resources.img_vector32_1; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.DataFormats; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Projections; }
        }

        public string Description
        {
            get { return "与矢量数据源相关的设置。"; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }
    }
}
