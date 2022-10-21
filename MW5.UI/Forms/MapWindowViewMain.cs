using System;
using System.Drawing;
using System.Windows.Forms;
using MW5.Plugins.Mvp;
using MW5.Shared;
using MW5.UI.Properties;
using Syncfusion.Windows.Forms;
using SyncWinFormTools = Syncfusion.Windows.Forms.Tools;

namespace MW5.UI.Forms
{
#if STYLE2010
    public partial class MapWindowViewMain : Office2010Form, IViewInternal
#else
    public partial class MapWindowViewMain : SyncWinFormTools.RibbonForm, IViewInternal
#endif
    {
        public event Action OkClicked;

        public Font CaptionFont { get{return Font;} set{ Font = value; }}
        protected MapWindowViewMain()
        {
            Logger.Current?.Trace("Start MapWindowView");
            Logger.Current?.Trace("Start MapWindowView.InitializeComponent()");
            InitializeComponent();
            Logger.Current?.Trace("End MapWindowView.InitializeComponent()");
            Icon = Resources.Icon_STGIS;
#if STYLE2010
            ApplyAeroTheme = false;
            UseOffice2010SchemeBackColor = true;
#endif
            Logger.Current?.Trace("End MapWindowView");
        }

        protected void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }

        public virtual void ShowView(IWin32Window parent = null)
        {
            if (!Visible)
            {
                AppViewFactory.Instance.ShowChildView(this, parent);
            }
        }

        private ViewStyle _style;
        public virtual ViewStyle Style
        {
            get
            {
                if (_style == null)
                {
                    _style = new ViewStyle()
                    {
                        Modal = true,
                        Sizable = false,
                    };
                }
                return _style;
            }
        }

        public virtual void BeforeClose()
        {
            // default implementation; can be overriden in child classes
        }

        public virtual void UpdateView()
        {
            // default implementation; can be overriden in child classes
        }

        public virtual void UpdateUI()
        {
            // default implementation; can be overriden in child classes
        }

        protected void FireOkClicked()
        {
            Invoke(OkClicked);
        }

        public void StartWait()
        {
            Cursor = Cursors.WaitCursor;

            EnableControls(false);

            Application.DoEvents();
        }

        public void StopWait()
        {
            Cursor = Cursors.Default;

            EnableControls(true);

            Application.DoEvents();
        }

        private void EnableControls(bool state)
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Enabled = state;
            }
        }

        public Form AsForm
        {
            get { return this; }
        }

        private void MapWindowView_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}
