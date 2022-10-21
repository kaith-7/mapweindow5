using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Concrete;
using MW5.Plugins.ShapeEditor.Properties;

namespace MW5.Plugins.ShapeEditor.Menu
{
    public class MenuCommands: CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        protected override void AssignShortcutKeys()
        {
            // it overrides copy command in panels, Debug window for example
            // so let's comment for the time being
            //Commands[MenuKeys.Copy].ShortcutKeys = Keys.Control | Keys.C;

            Commands[MenuKeys.Paste].ShortcutKeys = Keys.Control | Keys.V;
            Commands[MenuKeys.Cut].ShortcutKeys = Keys.Control | Keys.X;

            // see MapControl.OnMapPreviewKeyDown for details
            Commands[MenuKeys.Undo].ShortcutKeys = Keys.Control | Keys.Z;
        }

        public override IEnumerable<MenuCommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                new MenuCommand(Resources.CreateLayer, MenuKeys.CreateLayer, Resources.icon_layer_create,
                "创建点、线、面等受支持的几何类型的Shapefile。"),

                new MenuCommand(Resources.LayerEdit, MenuKeys.LayerEdit, Resources.icon_layer_edit,
                "开始编辑会话以编辑要素或属性。"),
                new MenuCommand(Resources.GeometryCreate, MenuKeys.GeometryCreate, Resources.icon_geometry_create,
                "在编辑会话中编辑要素。"),
                new MenuCommand(Resources.VertexEditor, MenuKeys.VertexEditor, Resources.icon_vertex_editor,
                "查看、选择及修改组成可编辑要素形状的折点。"),
                new MenuCommand(Resources.MoveShapes, MenuKeys.MoveShapes, Resources.icon_geometry_move,
                "拖动选中的要素平移，改变要素位置。"),
                new MenuCommand(Resources.RotateShapes, MenuKeys.RotateShapes, Resources.icon_geometry_rotate,
                "拖动选中的要素，围绕中心位置做任意角度旋转。"),
                new MenuCommand(Resources.SplitShapes, MenuKeys.SplitShapes, Resources.icon_geometry_split,
                "将一个要素拆分为多个要素。"),
                new MenuCommand(Resources.MergeShapes, MenuKeys.MergeShapes, Resources.icon_geometry_merge,
                "将多个要素合并为一个要素。"),
                new MenuCommand(Resources.CopyAttributes, MenuKeys.CopyAttributes, Resources.icon_edit_copy_Attr, "复制所选要素的属性。"),
                new MenuCommand(Resources.PasteAttributes, MenuKeys.PasteAttributes, Resources.icon_edit_paste, "属性粘贴。"),
                new MenuCommand(Resources.Copy, MenuKeys.Copy, Resources.icon_edit_copy, "复制所选要素。"),
                new MenuCommand(Resources.Paste, MenuKeys.Paste, Resources.icon_edit_paste,
                "将剪贴板内容粘贴到地图中。"),
                new MenuCommand(Resources.Cut, MenuKeys.Cut, Resources.icon_edit_cut,
                "剪切所选要素。"),
                new MenuCommand(Resources.Undo, MenuKeys.Undo, Resources.icon_edit_undo,
                "撤销上次操作。"),
                new MenuCommand(Resources.Redo, MenuKeys.Redo, Resources.icon_edit_redo,
                "恢复先前撤销的操作。"),

                new MenuCommand(Resources.EraseByPolygon, MenuKeys.EraseByPolygon, null),
                new MenuCommand(Resources.ClipByPolygon, MenuKeys.ClipByPolygon, null),
                new MenuCommand(Resources.SplitByPolygon, MenuKeys.SplitByPolygon, null),
                new MenuCommand(Resources.SplitByPolyline, MenuKeys.SplitByPolyline, Resources.icon_geometry_split_by_polyline,
                "通过绘制线段,将一个要素分割为多个要素。"),

                new MenuCommand(Resources.DeleteSelected, MenuKeys.DeleteSelected, Resources.img_delete_selected),

                new MenuCommand(Resources.SnaptoActiveLayer, MenuKeys.SnapToActiveLayer, Resources.img_snap_active_layer,
                "捕捉当前编辑的图层的要素。"),
                new MenuCommand(Resources.SnaptoAllLayers, MenuKeys.SnapToAlLayers, Resources.img_snap_all_layers,
                "捕捉当前地图文档所加载的所有任意图层的要素。"),

                new MenuCommand(Resources.SnapToVertices, MenuKeys.SnapToVertices, Resources.img_snap_to_vertices,
                "在编辑操作时，捕捉到线或面边界的起点、终点、折点。"),
                new MenuCommand(Resources.SnaptoSegments, MenuKeys.SnapToSegments, Resources.img_snap_to_segments,
                "在编辑操作时，捕捉到线或面边界的间断点。"),
            };
        }
    }
}
