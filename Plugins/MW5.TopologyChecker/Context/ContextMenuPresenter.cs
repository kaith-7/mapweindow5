using System;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Concrete;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.TopologyChecker.Menu;
using System.Drawing;

namespace MW5.Plugins.TopologyChecker.Context
{
    public class ContextMenuPresenter : CommandDispatcher<ContextMenuView, EditorCommand>
    {
        private readonly IAppContext _context;
        private readonly ILayerService _layerService;
        private readonly IGeoprocessingService _geoService;
        private readonly TopologyCheckerPlugin _plugin;
        private System.Drawing.Point mouse_position;

        public ContextMenuPresenter(IAppContext context, TopologyCheckerPlugin plugin, ILayerService layerService, 
                        IGeoprocessingService geoService, ContextMenuView view)
            :base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (layerService == null) throw new ArgumentNullException("layerService");
            if (geoService == null) throw new ArgumentNullException("geoService");
            _context = context;
            _layerService = layerService;
            _geoService = geoService;
            _plugin = plugin;
        }

        public ContextMenuStrip DigitizingMenu
        {
            get { return View.DigitizingMenu; }
        }

        public Point Mouse_position { get => mouse_position; set => mouse_position = value; }

        public override void RunCommand(EditorCommand command)
        {
            if (HandleGroupOperation(command)) return;

            if (HandleChangeTool(command)) return;

            if (HandleVertexEditor(command)) return;

            if (HandleSnappingAndHighlighting(command)) return;

            var map = _context.Map;

            _context.View.Update();
        }

        public bool HandleSnappingAndHighlighting(EditorCommand command)
        {
            var editor = _context.Map.GeometryEditor;

            var handled = false;
            
            return handled;
        }

        public bool HandleVertexEditor(EditorCommand command)
        {
            var editor = _context.Map.GeometryEditor;
            
            return false;
        }

        public bool HandleChangeTool(EditorCommand command)
        {
            var map = _context.Map;
            
            return false;
        }

        public bool HandleGroupOperation(EditorCommand command)
        {
            return false;
        }
    }
}
