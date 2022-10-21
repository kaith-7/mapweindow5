﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Properties;
using MW5.UI.Controls;

namespace MW5.Configuration
{
    public partial class DataFormatsConfigPage : ConfigPageBase, IConfigPage
    {
        public DataFormatsConfigPage()
        {
            InitializeComponent();
        }

        public string Description
        {
            get { return "各种数据格式的常规设置。"; }
        }

        public Bitmap Icon
        {
            get { return Resources.img_layers32; }
        }

        public string PageName
        {
            get { return "数据"; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.DataFormats; }
        }

        /// <summary>
        /// Gets a value indicating whether the page height can be adjusted to fit the the parent.
        /// </summary>
        public bool VariableHeight 
        {
            get { return true; } 
        }

        public void Initialize()
        {
            
        }

        public void Save()
        {

        }
    }
}
