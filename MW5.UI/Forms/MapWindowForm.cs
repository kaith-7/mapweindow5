﻿// -------------------------------------------------------------------------------------------
// <copyright file="MapWindowForm.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;
using MW5.Plugins.Interfaces;
using MW5.UI.Properties;
using Syncfusion.Windows.Forms;

namespace MW5.UI.Forms
{
#if STYLE2010
    public partial class MapWindowForm : Office2010Form
#else
    public class MapWindowForm : MetroForm
#endif
    {
        protected readonly IAppContext _context;
        public static bool IsLoaded;

        public MapWindowForm()
        {
            Icon = Resources.Icon_STGIS;
#if STYLE2010
            ApplyAeroTheme = false;
            UseOffice2010SchemeBackColor = true;
#endif
        }

        public MapWindowForm(IAppContext context)
            : this()
        {
            _context = context;
            InitializeComponent();
        }

        public IAppContext AppContext => _context;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MapWindowForm
            // 
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "MapWindowForm";
            this.ResumeLayout(false);

        }

        private void MapWindowForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            
            // To prevent loading multiple instances:
            IsLoaded = true;
        }

        private void MapWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsLoaded = false;
        }
    }
}