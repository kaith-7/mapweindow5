using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Shared;
using MW5.UI.Controls;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;

namespace MW5.Plugins.Symbology.Controls
{
    public partial class RasterInfoTreeView : TwoColumnTreeView
    {
        public RasterInfoTreeView()
        {
            InitializeComponent();

        }

        public void Initialize(IRasterSource raster)
        {
            if (raster == null) return;

            Nodes.Clear();

            var root = PopulateTree(raster);

            var node = AddSubItems(Nodes, root);

            node.ExpandAll();
        }

        private NodeData PopulateTree(IRasterSource raster)
        {
            var root = new NodeData(" ");

            var general = new NodeData("常规");
            general.AddSubItem("大小", string.Format("{0}×{1}", raster.Width, raster.Height));
            general.AddSubItem("渲染", raster.PaletteInterpretation.ToString());
            general.AddSubItem("波段数", raster.NumBands);
            general.AddSubItem("驱动", raster.Driver.Name);

            root.AddSubItem(general);

            var bandsData = GetBandsInfo(raster);
            root.AddSubItem(bandsData);

            AddBounds(root, raster);

            return root;
        }

        private void AddBounds(NodeData root, IRasterSource raster)
        {
            var bounds = new NodeData("范围");
            bounds.AddSubItem("单位像元分辨率", string.Format("{0}×{1}", raster.Dx, raster.Dy));
            bounds.AddSubItem("左下角坐标", string.Format("{0};{1}", raster.XllCenter, raster.YllCenter));
            root.AddSubItem(bounds);

            var buffer = new NodeData("Buffer");
            buffer.AddSubItem("宽", raster.BufferWidth);
            buffer.AddSubItem("高", raster.BufferHeight);
            buffer.AddSubItem("单位像元分辨率", string.Format("{0}×{1}", raster.BufferDx, raster.BufferDy));
            buffer.AddSubItem("左下角坐标", string.Format("{0};{1}", raster.BufferXllCenter, raster.BufferYllCenter));
            
            root.AddSubItem(buffer);
        }

        private NodeData GetBandsInfo(IRasterSource raster)
        {
            var root = new NodeData("波段");

            var bands = raster.Bands;
            for (int i = 1; i <= bands.Count; i++)
            {
                var band = bands[i];

                var bandNode = new NodeData("波段 " + i);
                bandNode.AddSubItem("数据类型", band.DataType.ToString());
                bandNode.AddSubItem("单位类型", band.UnitType);
                
                // TODO: restore; temporarily commented
                //bandNode.AddSubItem("Minimum", band.Minimum);
                //bandNode.AddSubItem("Maximum", band.Maximum);

                bandNode.AddSubItem("NoData值", band.NoDataValue.ToString(CultureInfo.InvariantCulture));
                bandNode.AddSubItem("渲染说明", band.ColorInterpretation.ToString());
                bandNode.AddSubItem("金字塔级别", band.Overviews.Count);

                var metadata = GetMetadata(band);
                if (metadata != null)
                {
                    bandNode.AddSubItem(metadata);
                }

                root.AddSubItem(bandNode);
            }

            return root;
        }

        private NodeData GetMetadata(RasterBand band)
        {
            if (band.MetadataCount > 0)
            {
                var metadata = new NodeData("元数据");
                for (int j = 0; j < band.MetadataCount; j++)
                {
                    string s = band.get_MetadataItem(j);
                    var parts = s.Split('=');
                    if (parts.Length == 2)
                    {
                        metadata.AddSubItem(parts[0], parts[1]);
                    }
                }

                return metadata;
            }

            return null;
        }
    }
}
