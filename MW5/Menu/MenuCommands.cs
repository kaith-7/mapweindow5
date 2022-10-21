using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Concrete;
using MW5.Plugins.Interfaces;
using MW5.Properties;

namespace MW5.Menu
{
    /// <summary>
    /// Holds list of commands for the core app. 
    /// </summary>
    internal class MenuCommands : CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        protected override void AssignShortcutKeys()
        {
            Commands[MenuKeys.FindLocation].ShortcutKeys = Keys.Control | Keys.F;

            Commands[MenuKeys.NewMap].ShortcutKeys = Keys.Control | Keys.N;

            Commands[MenuKeys.SaveProject].ShortcutKeys = Keys.Control | Keys.S;

            Commands[MenuKeys.OpenProject].ShortcutKeys = Keys.Control | Keys.O;

            Commands[MenuKeys.AddLayer].ShortcutKeys = Keys.Control | Keys.L;

            Commands[MenuKeys.Settings].ShortcutKeys = Keys.Shift | Keys.Alt | Keys.S;

            Commands[MenuKeys.SetScale].ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;

            Commands[MenuKeys.ShowRepository].ShortcutKeys = Keys.Control | Keys.R;

            Commands[MenuKeys.ShowToolbox].ShortcutKeys = Keys.Control | Keys.T;
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                // file menu
                new MenuCommand(Resources.NewMap, MenuKeys.NewMap, Resources.icon_new_map, 
                "创建新的地图文档。"),

                new MenuCommand(Resources.AddLayer, MenuKeys.AddLayer, Resources.icon_layer_add,
                "将新数据添加到当前地图文档, 数据类型包括矢量、栅格和空间数据库。"),

                new MenuCommand(Resources.AddVectorLayer, MenuKeys.AddVectorLayer, Resources.icon_layer_vector_add,
                "将矢量数据添加到当前地图文档。"),

                new MenuCommand(Resources.AddRasterLayer, MenuKeys.AddRasterLayer, Resources.icon_layer_raster_add,
                "将栅格数据添加到当前地图文档。"),

                new MenuCommand(Resources.AddWmsLayer, MenuKeys.AddWmsLayer, Resources.img_wms_add24,
                "将WMS数据服务添加到当前地图文档。"),

                new MenuCommand(Resources.AddDatabaseLayer, MenuKeys.AddDatabaseLayer, Resources.icon_layer_database_add,
                "将空间数据库中的数据添加到当前地图文档。"),

                new MenuCommand(Resources.OpenProject, MenuKeys.OpenProject, Resources.icon_folder,
                "打开现有的地图文档。"),

                new MenuCommand(Resources.SaveProject, MenuKeys.SaveProject, Resources.icon_save,
                "保存当前地图文档。"),

                new MenuCommand(Resources.SaveProjectAs, MenuKeys.SaveProjectAs, Resources.icon_save_as,
                "以新名称保存当前地图文档，保存到其他位置。"),

                new MenuCommand(Resources.Exit, Plugins.Menu.MenuKeys.Quit, Resources.icon_quit, 
                "关闭当前地图文档。"),

                new MenuCommand(Resources.Test, MenuKeys.Test, Resources.img_test24,
                "提供了一种快速运行测试代码的方法。"),
                
                // file toolbar
                new MenuCommand(Resources.RemoveLayer, MenuKeys.RemoveLayer, Resources.icon_layer_remove,
                "从内容类表中移除所选图层。"),

                new MenuCommand(Resources.Settings, MenuKeys.Settings, Resources.icon_settings,
                "设置应用程序和插件。"),

                // map toolbar
                new MenuCommand(Resources.ZoomToBaseLayer, MenuKeys.ZoomToBaseLayer, Resources.icon_zoom_to_layer,
                "缩放至全屏显示TMS底图。"),

                new MenuCommand(Resources.ZoomIn, MenuKeys.ZoomIn, Resources.icon_zoom_in,
                "通过在地图上单击一次或拖拽框的形式放大。"),

                new MenuCommand(Resources.ZoomOut, MenuKeys.ZoomOut, Resources.icon_zoom_out,
                "通过在地图上单击一次的形式缩小。"),

                new MenuCommand(Resources.ZoomPrev, MenuKeys.ZoomPrev, Resources.img_zoom_prev24,
                "返回到地图的上一范围。"),

                new MenuCommand(Resources.ZoomNext, MenuKeys.ZoomNext, Resources.img_zoom_next24,
                "按照查看地图的范围顺序再次前进。"),

                new MenuCommand(Resources.ZoomMax, MenuKeys.ZoomMax, Resources.icon_zoom_max_extents,
                "缩放到最大范围。"),

                new MenuCommand(Resources.ZoomToLayer, MenuKeys.ZoomToLayer, Resources.icon_zoom_to_layer, 
                "缩放到当前选定的图层。"),

                new MenuCommand(Resources.Pan, MenuKeys.Pan, Resources.icon_pan,
                "使用鼠标拖动来平移地图。"),

                new MenuCommand(Resources.Swipe, MenuKeys.SwipeTool, Resources.img_Swipe32,
                "影像卷帘。"),

                new MenuCommand(Resources.GoToXY, MenuKeys.GoToXY, Resources.img_GoToXY32,
                "定位到坐标。"),

                new MenuCommand(Resources.SwitchFill, MenuKeys.SwitchFill, Resources.red_no_fill,
                "切换面填充"),

                new MenuCommand(Resources.ShowZoombar, MenuKeys.ShowZoombar, null, ""),

                new MenuCommand(Resources.ShowScalebar, MenuKeys.ShowScalebar, null, ""),

                new MenuCommand(Resources.ShowCoordinates, MenuKeys.ShowCoordinates, null, ""),

                new MenuCommand(Resources.ShowRedrawTime, MenuKeys.ShowRedrawTime, null, ""),

                new MenuCommand(Resources.SetScale, MenuKeys.SetScale, Resources.img_scale24, ""),

                new MenuCommand(Resources.SetProjection, MenuKeys.SetProjection, Resources.icon_crs_change,
                "显示地图投影信息。"),

                new MenuCommand(Resources.FindLocation, MenuKeys.FindLocation, Resources.icon_search,
                "通过名称搜索定位位置。"),

                new MenuCommand(Resources.MeasureDistance, MenuKeys.MeasureDistance, Resources.icon_measure_distance,
                "测量地图上的距离。"),

                new MenuCommand(Resources.MeasureArea, MenuKeys.MeasureArea, Resources.icon_measure_area,
                "测量地图上的面积。"),

                new MenuCommand(Resources.SelectByRectangle, MenuKeys.SelectByRectangle, null, 
                "通过拖拽出矩形，从矢量图层中选择要素。"),

                new MenuCommand(Resources.SelectByPolygon, MenuKeys.SelectByPolygon, null,
                "通过拖拽出多边形，从矢量图层中选择要素。"),

                new MenuCommand(Resources.AttributesTool, MenuKeys.AttributesTool, Resources.icon_identify, 
                "通过单击显示地理要素属性。"),

                new MenuCommand(Resources.ZoomToSelected, MenuKeys.ZoomToSelected, Resources.icon_zoom_to_selection,
                "缩放至已选择要素的范围。"),

                new MenuCommand(Resources.ClearSelection, MenuKeys.ClearSelection, Resources.icon_clear_selection,
                "取消选择地图文档中选择的要素。"), 

                new MenuCommand(Resources.ClearSelection, MenuKeys.LayerClearSelection, Resources.icon_clear_selection, "取消选择图层中选择的要素。"),

                new MenuCommand(Resources.SelectionByAttribute, MenuKeys.SelectionByAttribute, Resources.img_SelectionByAttributes32, "按属性选择要素。"),
                new MenuCommand(Resources.SelectionSelectByLocation, MenuKeys.SelectionByLocation, Resources.img_SelectionSelectByLocation32, "按位置关系选择要素。"),

                new MenuCommand(Resources.ClearLayers, MenuKeys.ClearLayers, Resources.icon_layer_clear,
                "移除地图文档中所有图层。"), 

                new MenuCommand(Resources.ShowRepository, MenuKeys.ShowRepository, Resources.icon_folder,
                "打开并定位到存储库窗口。"), 

                new MenuCommand(Resources.ShowToolbox, MenuKeys.ShowToolbox, Resources.img_toolbox24,
                "打开并定位到工具箱窗口。"),

                //new MenuCommand("展示小班对应图片", "ShowPolygonPicture", Resources.img_FindLocation,
                //"用于查看面图层小班中对应拍摄的图片。"),
            };
        }
    }
}
