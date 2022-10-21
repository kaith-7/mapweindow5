using MW5.Api.Concrete;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Projections.Forms;
using MW5.Services.Views.Abstract;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MW5.Services.Views
{
    public class CreateLayerPresenter: BasePresenter<ICreateLayerView, CreateLayerModel>
    {
        private readonly IAppContext _context;
        private readonly ICreateLayerView _view;
        private readonly IFileDialogService _fileDialogService;

        public CreateLayerPresenter(IAppContext context, ICreateLayerView view, IFileDialogService fileDialogService) : base(view)
        {
            _context = context;
            _view = view ?? throw new ArgumentNullException("view");
            _fileDialogService = fileDialogService ?? throw new ArgumentNullException("fileDialogService");
            view.ChooseProjection += View_ChooseProjection;
            View.ChooseDataDictionary += View_ChooseDataDictionary;
            if (View.ChooseButton is Syncfusion.Windows.Forms.Tools.SplitButton btnChooseCRS)
            {
                foreach (var projCode in context.Config.LastChooseProjections)
                {
                    var sr = new SpatialReference();
                    if (sr.ImportFromEpsg(projCode))
                    {
                        var item = new Syncfusion.Windows.Forms.Tools.toolstripitem();
                        item.Tag = sr;
                        item.Text = sr.Name;
                        btnChooseCRS.DropDownItems.Add(item);
                    }
                }
            }
        }

        private void View_ChooseDataDictionary(object sender, EventArgs e)
        {
            if (sender is ComboBox box)
            {
                if (box.Items.Count == 0)
                {
                    using (var openDlg = new OpenFileDialog())
                    {
                        if(openDlg.ShowDialog() == DialogResult.OK)
                        {
                            Model.DataDictionaryName = openDlg.FileName;

                            // TODO: 这里调用数据字典的接口获取表名
                        }
                    }
                }
            }
        }

        private void View_ChooseProjection()
        {
            using (var form = new ChooseProjectionForm(_context.Projections, _context))
            {
                if (_context.View.ShowChildView(form))
                {
                    var cs = form.SelectedCoordinateSystem;
                    View.SR = new SpatialReference();
                    if (!View.SR.ImportFromEpsg(cs.Code))
                    {
                        MessageService.Current.Warn("Failed to initialize projection: " + cs.Code);
                        return;
                    }

                    if (View.ChooseButton is Syncfusion.Windows.Forms.Tools.SplitButton btnChooseCRS)
                    {
                        btnChooseCRS.Text = View.SR.Name;

                        if (!_context.Config.LastChooseProjections.Contains(View.SR.GetEpsgCode()))
                        {
                            if (btnChooseCRS.DropDownItems.Count > 9)
                            {
                                btnChooseCRS.DropDownItems.RemoveAt(9);
                                _context.Config.LastChooseProjections.RemoveAt(9);
                            }

                            var item = new Syncfusion.Windows.Forms.Tools.toolstripitem();
                            item.Tag = View.SR;
                            item.Text = View.SR.Name;
                            btnChooseCRS.DropDownItems.Add(item);
                            _context.Config.LastChooseProjections.Add(View.SR.GetEpsgCode());
                        }
                    }
                }
            }
        }

        public override bool ViewOkClicked()
        {
            string layerName = _view.LayerName;
            if (string.IsNullOrWhiteSpace(layerName))
            {
                MessageService.Current.Info("请输入层名.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(_view.DataDictionaryName)
                || !(File.Exists(_view.DataDictionaryName) || File.Exists(
                    System.IO.Path.Combine(AppContext.BaseDirectory, @"SDT\"+_view.DataDictionaryName))))
            {
                MessageService.Current.Info("找不到数据字典.");
                return false;
            }
            if (_view.SR == null || _view.SR.IsEmpty)
            {
                MessageService.Current.Info("请选择坐标系统.");
                return false;
            }

            if (!View.MemoryLayer)
            {
                string path = Directory.GetDirectoryRoot(Assembly.GetExecutingAssembly().Location);
                if (!_fileDialogService.ChooseFolder(path, out path))
                {
                    return false;
                }

                Model.Filename = GetFilename(path);
            }
            else
            {
                Model.Filename = View.LayerName;
            }

            Model.GeometryType = View.GeometryType;
            Model.ZValueType = View.ZValueType;
            Model.MemoryLayer = View.MemoryLayer;
            Model.SR = View.SR;
            Model.DataDictionaryName = View.DataDictionaryName;
            if (!System.IO.Path.IsPathRooted(Model.DataDictionaryName))
            {
                Model.DataDictionaryName = System.IO.Path.Combine(AppContext.BaseDirectory, @"SDT\" + _view.DataDictionaryName);
            }
            
            return true;
        }

        private string GetFilename(string path)
        {
            const string shpExt = ".shp";

            string filename = Path.Combine(path, _view.LayerName.ToLower());
            if (!filename.EndsWith(shpExt))
            {
                filename += shpExt;
            }

            return filename;
        }
    }
}
