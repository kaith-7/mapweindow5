// -------------------------------------------------------------------------------------------
// <copyright file="GeoLocationPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Interfaces;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Shared;
using MW5.Views.Abstract;

namespace MW5.Views
{
    internal class GoToXYPresenter : BasePresenter<IGoToXYView>
    {
        private readonly IAppContext _context;
        private readonly IGeoLocationService _geolocationService;

        public GoToXYPresenter(IGoToXYView view, IAppContext context, IGeoLocationService geolocationService)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (geolocationService == null) throw new ArgumentNullException("geolocationService");
            _context = context;
            _geolocationService = geolocationService;

            //View.PanTo += toolStripButton_GoToXY_Click;
            View.Style.Modal = false;
        }

        public override bool ViewOkClicked()
        {
            return true; // there is no OK button.
        }
    }
}