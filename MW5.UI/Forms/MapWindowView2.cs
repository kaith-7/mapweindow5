using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using Syncfusion.Windows.Forms;

namespace MW5.UI.Forms
{
    public class MapWindowView<TModel> : MapWindowView, IViewInternal<TModel>
    {
        protected TModel _model;

        public void InitInternal(TModel model)
        {
            _model = model;
        }

        public TModel Model
        {
            get { return _model; }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapWindowView));
            this.SuspendLayout();
            // 
            // MapWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapWindowView";
            this.ResumeLayout(false);

        }
    }
}
