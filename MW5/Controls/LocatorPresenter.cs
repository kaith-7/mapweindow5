﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Enums;
using MW5.Plugins.Events;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;

namespace MW5.Controls
{
    public class LocatorPresenter : ILocator
    {
        private readonly IMap _mainMap;
        private readonly LocatorDockPanel _view;
        private bool _noEvents;

        public LocatorPresenter(IMap map)
        {
            if (map == null) throw new ArgumentNullException("map");

            _mainMap = map;
            _mainMap.ExtentsChanged += MainMapExtentsChanged;

            _view = new LocatorDockPanel();
            _view.UpdateFullExtents += () => UpdatePreview(true);
            _view.UpdateWithCurrentExtents += () => UpdatePreview(false);
            _view.LocatorExtentsChanged += LocatorExtentsChanged;
        }

        private void LocatorExtentsChanged(object sender, ExtentsEventArgs e)
        {
            _noEvents = true;
            _mainMap.ZoomToExtents(e.Extents);
            _noEvents = false;
        }

        private void MainMapExtentsChanged(object sender, EventArgs e)
        {
            if (!_noEvents)
            {
                _view.UpdateLocatorBox(_mainMap.Extents);
            }
        }

        public void RestorePicture(Image image, double dx, double dy, double xllCenter, double yllCenter)
        {
            var bmp = BitmapSource.CreateEmpty();
            bmp.FromGdiPlusBitmap(image);
            bmp.Dx = dx;
            bmp.Dy = dy;
            bmp.XllCenter = xllCenter;
            bmp.YllCenter = yllCenter;

            _view.UpdateImage(bmp);

            _view.UpdateLocatorBox(_mainMap.Extents);
        }

        public Control GetInternalObject()
        {
            return _view;
        }

        public IImageSource Picture
        {
            get { return _view.Image; }
        }

        public void Clear()
        {
            _view.Clear();
        }

        public bool Empty
        {
            get { return _view.Empty; }
        }

        public void Update(PreviewExtents updateExtents)
        {
            UpdatePreview(updateExtents == PreviewExtents.FullExtents);
        }

        private IImageSource GetSnapshot(IEnvelope exts)
        {
            IImageSource img;
            try
            {
                _mainMap.Lock();
                var provider = _mainMap.TileProvider;
                if (!_view.BackgroundVisible)
                {
                    _mainMap.TileProvider = TileProvider.None;
                }

                img = _mainMap.SnapShot(exts, 512);

                _mainMap.TileProvider = provider;
            }
            finally
            {
                _mainMap.Unlock();
            }

            return img;
        }

        private void UpdatePreview(bool fullExtents)
        {
            int layersCount = _mainMap.Layers.Count;

            if (layersCount == 0 &&
                (_mainMap.TileProvider == TileProvider.None || _mainMap.Projection.IsEmpty))
            {
                MessageService.Current.Info("地图是空的，无法创建概览图像。");
                return;
            }

            if (fullExtents && layersCount == 0)
            {
                MessageService.Current.Info("没有加载图层去制作快照。");
                return;
            }

            IEnvelope e = fullExtents ? _mainMap.MaxExtents : _mainMap.Extents;
            e = e.Inflate(e.Width*0.1, e.Height*0.1);       // parameter can be introduced

            double ratio = _view.Width / (double)_view.Height;
            var exts = e.Adjust(ratio);

            var img = GetSnapshot(exts);

            if (img == null)
            {
                MessageService.Current.Warn("截屏失败。");
                return;
            }

            img.Dx = (exts.MaxX - exts.MinX) / img.Width;
            img.Dy = (exts.MaxY - exts.MinY) / img.Height;
            img.XllCenter = exts.MinX + 0.5 * img.Dx;
            img.YllCenter = exts.MinY + 0.5 * img.Dx; // TODO: Shouldn't this be img.Dy?
            img.DownsamplingMode = InterpolationType.HighQualityBicubic;
            img.UpsamplingMode = InterpolationType.HighQualityBicubic;

            _view.UpdateImage(img);

            _view.UpdateLocatorBox(_mainMap.Extents);
        }
    }
}
