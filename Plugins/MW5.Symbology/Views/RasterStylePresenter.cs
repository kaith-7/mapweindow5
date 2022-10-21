﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Api.Legend;
using MW5.Api.Legend.Abstract;
using MW5.Data.Views;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.Symbology.Views.Abstract;
using MW5.Projections.Helpers;
using MW5.Services.Serialization;
using MW5.Shared;

namespace MW5.Plugins.Symbology.Views
{
    public class RasterStylePresenter: ComplexPresenter<IRasterStyleView, RasterCommand, ILegendLayer>
    {
        private readonly IAppContext _context;
        private readonly IBroadcasterService _broadcaster;
        private IRasterSource _raster;

        public RasterStylePresenter(IAppContext context, IRasterStyleView view, IBroadcasterService broadcaster) : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (broadcaster == null) throw new ArgumentNullException("broadcaster");
            _context = context;
            _broadcaster = broadcaster;
        }

        public override void RunCommand(RasterCommand command)
        {
            switch (command)
            {
                case RasterCommand.OpenFolder:
                    string filename = Model.Filename;
                    if (!string.IsNullOrWhiteSpace(filename))
                    {
                        PathHelper.OpenFolderWithExplorer(filename);
                    }
                    else
                    {
                        MessageService.Current.Info("Can't find the datasource.");
                    }
                    break;
                case RasterCommand.ProjectionDetails:
                    _context.ShowProjectionProperties(Model.Projection, View as IWin32Window);
                    break;
                case RasterCommand.ClearColorAdjustments:
                    View.ClearColorAdjustments();
                    break;
                case RasterCommand.Apply:
                    Apply();
                    break;
                case RasterCommand.RemoveStyle:
                    LayerSerializationHelper.RemoveSettings(Model, false);
                    break;
                case RasterCommand.LoadStyle:
                    {
                        bool result = LayerSerializationHelper.LoadSettings(Model, _broadcaster, false);
                        
                        if (result)
                        {
                            View.Initialize();
                            Apply();
                        }

                        MessageService.Current.Info(result ? "Layer options are loaded." : "Failed to load layer options.");
                    }
                    break;
                case RasterCommand.SaveStyle:
                    LayerSerializationHelper.SaveSettings(Model);
                    break;
                case RasterCommand.ShowDriverInfo:
                    if (_raster == null) return;
                    var manager = new DriverManager {SelectedDriver = _raster.Driver};
                    _context.Container.Run<DriversPresenter, DriverManager>(manager);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("command");
            }
        }

        private bool Apply()
        {
            if (!View.RenderingPresenter.ValidateUserInput())
            {
                return false;
            }
            
            View.UiToModel();

            ApplyRenderingMode();

            _context.Legend.Redraw(LegendRedraw.LegendAndMap);

            return true;
        }

        private void ApplyRenderingMode()
        {
            if (_raster == null)
            {
                return;
            }
            
            var colors = View.RenderingPresenter.View;
            _raster.ForceSingleBandRendering = false;
            _raster.UseRgbBandMapping = false;
            _raster.IgnoreColorTable = true;

            switch (colors.Rendering)
            {
                case RasterRendering.SingleBand:
                    _raster.AllowGridRendering = GridRendering.Never;
                    _raster.ForceSingleBandRendering = true;
                    _raster.ActiveBandIndex = colors.ActiveBandIndex;
                    _raster.SetBandMinMax(colors.ActiveBandIndex, colors.BandMinValue, colors.BandMaxValue);
                    break;
                case RasterRendering.Rgb:
                    _raster.AllowGridRendering = GridRendering.Never;
                    _raster.UseRgbBandMapping = true;
                    break;
                case RasterRendering.BuiltInColorTable:
                    _raster.AllowGridRendering = GridRendering.Never;
                    _raster.IgnoreColorTable = false;
                    break;
                case RasterRendering.ColorScheme:
                    _raster.AllowGridRendering = GridRendering.ForceForAllFormats;
                    if (colors.ColorScheme != null && _raster != null)
                    {
                        _raster.ActiveBandIndex = colors.ActiveBandIndex;
                        _raster.CustomColorScheme = colors.ColorScheme;
                    }
                    break;
                default:
                    Logger.Current.Warn("Unexpected RasterRendering enum value: " + colors.Rendering);
                    break;
            }
        }

        public override bool ViewOkClicked()
        {
            return Apply();
        }

        protected override void Initialize()
        {
            _raster = Model.ImageSource as IRasterSource;
        }
    }
}
