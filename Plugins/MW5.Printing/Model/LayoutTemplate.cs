// -------------------------------------------------------------------------------------------
// <copyright file="LayoutTemplate.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Windows.Forms;
using MW5.Plugins.Printing.Services;
using MW5.Shared;
using MW5.Api.Enums;

namespace MW5.Plugins.Printing.Model
{
    public class LayoutTemplate
    {
        public LayoutTemplate(string filename)
        {
            Filename = filename;

            LoadTemplate();
        }

        public string Filename { get; private set; }

        public string 名称
        {
            get { return Path.GetFileNameWithoutExtension(Filename); }
        }

        public Orientation 方向 { get; private set; }

        public string 页数 { get; private set; }

        public string 纸张格式 { get; set; }

        private void LoadTemplate()
        {
            try
            {
                string xml = File.ReadAllText(Filename);

                var layout = LayoutSerializer.DeserializeLite(xml);

                if (layout != null)
                {
                    纸张格式 = layout.Paper.PaperName;
                    方向 = layout.Paper.Landscape ? Orientation.Horizontal : Orientation.Vertical;
                    页数 = string.Format("{0} × {1}", layout.Paper.PageCountX, layout.Paper.PageCountY);
                }
                else
                {
                    方向 = Orientation.Vertical;
                    纸张格式 = "n/d";
                    页数 = "n/d";
                }
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("Failed to read layout template: " + Filename, ex);
            }
        }
    }
}