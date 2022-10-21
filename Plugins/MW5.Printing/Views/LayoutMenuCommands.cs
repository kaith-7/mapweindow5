// -------------------------------------------------------------------------------------------
// <copyright file="LayoutMenuCommands.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MW5.Plugins.Concrete;
using MW5.Plugins.Printing.Properties;

namespace MW5.Plugins.Printing.Views
{
    public class LayoutMenuCommands : CommandProviderBase
    {
        public LayoutMenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>
                       {
                           // file
                           new MenuCommand(Resources.NewLayout, LayoutMenuKeys.NewLayout,
                               Resources.img_create24, "新建一个空白的布局版面。"),
                           new MenuCommand(Resources.SaveLayout, LayoutMenuKeys.SaveLayout,
                               Resources.img_save24, "将当前布局版面保存。"),
                           new MenuCommand(Resources.SaveLayoutAs, LayoutMenuKeys.SaveLayoutAs,
                               Resources.img_save_as24, "以新命名保存当前布局版面，保存到其他位置。"),
                           new MenuCommand(Resources.LoadLayout, LayoutMenuKeys.LoadLayout,
                               Resources.img_open24, "打开现有的布局版面。"),
                           new MenuCommand(Resources.Print, LayoutMenuKeys.Print, Resources.img_printer24, "连接打印机，打印。"),
                           new MenuCommand(Resources.PrinterSetup, LayoutMenuKeys.PrinterSetup, null, "选择并设置打印参数。"),
                           new MenuCommand(Resources.PageSetup, LayoutMenuKeys.PageSetup,
                               Resources.img_page_setup24, "设置纸张大小、方向和页边距等。"),
                           new MenuCommand(Resources.ExportToBitmap, LayoutMenuKeys.ExportToBitmap,
                               Resources.img_export24, "将地图导出为图片文件，如PNG、JPEG等。"),
                           new MenuCommand(Resources.ExportToPdf, LayoutMenuKeys.ExportToPdf,
                               Resources.img_export_pdf24, "将地图导出为PDF文档。"),
                           new MenuCommand(Resources.Close, LayoutMenuKeys.Close, Resources.img_close24),
                           new MenuCommand(Resources.AdjustPages, LayoutMenuKeys.AdjustPages, Resources.img_refresh24, "将当前布局版面调整到最适合屏幕大小的布局。"),

                           // zooming
                           new MenuCommand(Resources.ZoomIn, LayoutMenuKeys.ZoomIn, Resources.img_zoom_in24, "放大整体的布局版面。"),
                           new MenuCommand(Resources.ZoomOut, LayoutMenuKeys.ZoomOut,
                               Resources.img_zoom_out24, "缩小整体的布局版面。"),
                           new MenuCommand(Resources.ZoomFitScreen, LayoutMenuKeys.ZoomFitScreen,
                               Resources.img_zoom_region24, "缩放至布局版面的全图范围。"),
                           new MenuCommand(Resources.ZoomOriginal, LayoutMenuKeys.ZoomOriginal, Resources.img_zoom_original24, "缩放布局版面至100%。"),
                           new MenuCommand(Resources.ShowPageNumbers, LayoutMenuKeys.ShowPageNumbers, Resources.img_page_number24, "显示出布局版面的页码，页码不会出现在最终导出或打印的结果中。"),
                           new MenuCommand(Resources.ShowMargins, LayoutMenuKeys.ShowMargins, null),
                           new MenuCommand(Resources.ShowRulers, LayoutMenuKeys.ShowRulers, null),
                           new MenuCommand(Resources.RestorePanels, LayoutMenuKeys.RestorePanels, null),
                           new MenuCommand(Resources.RestoreToolbars, LayoutMenuKeys.RestoreToolbars, null),

                           // selection
                           new MenuCommand(Resources.SelectAll, LayoutMenuKeys.SelectAll, null),
                           new MenuCommand(Resources.SelectNone, LayoutMenuKeys.SelectNone, null),
                           new MenuCommand(Resources.InvertSelection, LayoutMenuKeys.InvertSelection, null),
                           new MenuCommand(Resources.ConvertToBitmap, LayoutMenuKeys.ConvertToBitmap, null),
                           new MenuCommand(Resources.MoveUp, LayoutMenuKeys.MoveUp, null),
                           new MenuCommand(Resources.MoveDown, LayoutMenuKeys.MoveDown, null),
                           new MenuCommand(Resources.DeleteElement, LayoutMenuKeys.DeleteElement, null),

                           // map
                           new MenuCommand(Resources.MapZoomIn, LayoutMenuKeys.MapZoomIn,
                               Resources.img_map_zoom_in24, "放大图框中的地图要素。"),
                           new MenuCommand(Resources.ZoomToOriginalExtents, LayoutMenuKeys.ZoomToOriginalExtents,
                               Resources.img_zoom_layer24, "缩放到能完全包含图层要素的最小范围。"),
                           new MenuCommand(Resources.ZoomToMaximum, LayoutMenuKeys.ZoomToMaximum,
                               Resources.img_map_zoom_max24, "缩放到最大范围。"),
                           new MenuCommand(Resources.MapZoomOut, LayoutMenuKeys.MapZoomOut,
                               Resources.img_map_zoom_out24, "缩小图框中的地图要素。"),
                           new MenuCommand(Resources.MapPan, LayoutMenuKeys.MapPan, Resources.img_pan24, "使用鼠标移动来平移地图。"),

                           // insert
                           new MenuCommand(Resources.AddMap, LayoutMenuKeys.AddMap,
                               Resources.img_insert_map24, "通过鼠标拖拽出一个新的图框，来增加地图图层。"),
                           new MenuCommand(Resources.AddLegend, LayoutMenuKeys.AddLegend,
                               Resources.img_insert_legend24, "通过鼠标拖拽出图框，来添加图例。"),
                           new MenuCommand(Resources.AddScaleBar, LayoutMenuKeys.AddScaleBar,
                               Resources.img_scalebar24, "通过鼠标拖拽出图框，来添加比例尺。"),
                           new MenuCommand(Resources.AddNorthArrow, LayoutMenuKeys.AddNorthArrow,
                               Resources.img_insert_compass24, "通过鼠标拖拽出图框，来添加指北针。"),
                           new MenuCommand(Resources.AddTable, LayoutMenuKeys.AddTable,
                               Resources.img_insert_table24, "通过鼠标拖拽出图框，将图层属性表加入地图中。"),
                           new MenuCommand(Resources.AddLabel, LayoutMenuKeys.AddLabel,
                               Resources.img_insert_text24, "通过鼠标拖拽出文本框，向地图中添加标签、文字注记等。"),
                           new MenuCommand(Resources.AddRectangle, LayoutMenuKeys.AddRectangle,
                               Resources.img_rectangle24, "通过鼠标拖拽出矩形框，加入地图中。"),
                           new MenuCommand(Resources.AddBitmap, LayoutMenuKeys.AddBitmap,
                               Resources.img_insert_picture24, "加本机已有的图片加入地图中。"),
                       };
        }
    }
}