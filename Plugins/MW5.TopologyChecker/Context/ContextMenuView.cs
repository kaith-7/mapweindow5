using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.TopologyChecker.Services;

namespace MW5.Plugins.TopologyChecker.Context
{
    public partial class ContextMenuView : UserControl, IMenuProvider
    {
        private readonly IAppContext _context;
        private readonly IGeoprocessingService _geoService;

        public ContextMenuView(IAppContext context, IGeoprocessingService geoService)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (geoService == null) throw new ArgumentNullException("geoService");

            _context = context;
            _geoService = geoService;

            InitializeComponent();

            contextDigitizing.Opening += DigitizingMenuOpening;
        }

        public ContextMenuStrip DigitizingMenu
        {
            get { return contextDigitizing; }
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get
            {
                yield return contextDigitizing.Items;
            }
        }

        public IEnumerable<Control> Buttons
        {
            get { yield break; }
        }

        private void DigitizingMenuOpening(object sender, CancelEventArgs e)
        {
            var editor = _context.Map.GeometryEditor;

            bool notEmpty = !editor.IsEmpty;
            ctxCancelShape.Enabled = notEmpty;
            ctxFinishShape.Enabled = notEmpty;
            ctxUndoPoint.Enabled = notEmpty;

            SetupSnapping(editor);

            SetupHighlighting(editor);
        }

        private void SetupSnapping(IGeometryEditor editor)
        {
            ctxSnapAll.Checked = editor.SnapBehavior == LayerSelectionMode.AllLayers;
            ctxSnapNone.Checked = editor.SnapBehavior == LayerSelectionMode.NoLayer;
            ctxSnapCurrent.Checked = editor.SnapBehavior == LayerSelectionMode.ActiveLayer;
        }

        private void SetupHighlighting(IGeometryEditor editor)
        {
        }

        private void DisableAll(ContextMenuStrip menu)
        {
            foreach (var item in menu.Items.OfType<ToolStripMenuItem>())
            {
                item.Enabled = false;
            }
        }
    }
}
