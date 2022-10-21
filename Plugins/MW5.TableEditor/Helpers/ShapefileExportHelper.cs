using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Interfaces;
using MW5.Plugins.Services;

namespace MW5.Plugins.TableEditor.Helpers
{
    internal static class ShapefileExportHelper
    {
        public static void ExportSelected(this IFeatureSet fs, IFileDialogService dialogService, ILayerService layerService)
        {
            if (fs == null) throw new ArgumentNullException("fs");
            if (dialogService == null) throw new ArgumentNullException("dialogService");
            if (layerService == null) throw new ArgumentNullException("layerService");

            if (fs.NumSelected == 0)
            {
                MessageService.Current.Info("未选择要素。");
                return;
            }

            string filename = string.Empty;

            dialogService.Title = "将选定的要素导出为设定的shapefile名称";
            if (!dialogService.SaveFile(@"Shapefiles (*.shp)|*.shp", ref filename))
            {
                return;
            }

            var fsNew = fs.ExportSelection();
            if (fsNew != null)
            {
                if (!fsNew.SaveAsEx(filename, true))
                {
                    MessageService.Current.Warn("保存shapefile失败: " + filename + ".");
                    return;
                }

                fsNew.Dispose();
            }
            else
            {
                MessageService.Current.Warn("选择要素导出失败。");
                return;
            }

            if (MessageService.Current.Ask("加载新的shapefile?"))
            {
                bool result = layerService.AddLayersFromFilename(filename);
                if (!result)
                {
                    MessageService.Current.Warn("打开导出的shapefile失败: " + filename + ".");
                }
            }
        }
    }
}
