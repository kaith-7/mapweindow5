using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MapWinGIS;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Api.Legend;
using MW5.Api.Legend.Abstract;
using MW5.Shared;

namespace MW5.Api.Map
{
    public class BoundMapControl : MapControl, IMap
    {
        private ILayerCollection<ILayer> _layers;
        private CustomCursor _customCursor;

        public BoundMapControl()
        {
            //Logger.Current.Trace("In BoundMapControl");
            MapCursorChanged += BoundMapControl_MapCursorChanged;
        }

        void BoundMapControl_MapCursorChanged(object sender, EventArgs e)
        {
            if (MapCursor != MapCursor.None)
            {
                _customCursor = null;
                _map.MapCursor = tkCursor.crsrMapDefault;
            }
        }

        [Browsable(false)]
        public IMuteLegend Legend { get; set; }

        [Browsable(false)]
        public new ILayerCollection<ILayer> Layers
        {
            get
            {
                if (Legend == null)
                {
                    throw new NullReferenceException(
                        "MapControl.Legend property should be set before acceccing layers collection.");
                }

                return _layers ?? (_layers = new LayerCollection<ILayer>(this, Legend));
            }
        }

        public ILayer GetLayer(int layerHandle)
        {
            return Layers.ItemByHandle(layerHandle);
        }

        public IFeatureSet GetFeatureSet(int layerHandle)
        {
            var layer = GetLayer(layerHandle);
            if (layer != null)
            {
                return layer.FeatureSet;
            }
            return null;
        }

        public IImageSource GetImage(int layerHandle)
        {
            var layer = GetLayer(layerHandle);
            if (layer != null)
            {
                return layer.ImageSource;
            }
            return null;
        }

        public CustomCursor CustomCursor
        {
            get
            {
                return _customCursor;
            }
            set
            {
                _customCursor = value;

                if (value != null && value.Guid != default(Guid))
                {
                    if (_customCursor.Cursor == null)
                    {
                        _map.MapCursor = tkCursor.crsrArrow;
                    }
                    else
                    {
                        _map.UDCursorHandle = (int)_customCursor.Cursor.Handle;
                        _map.MapCursor = tkCursor.crsrUserDefined;
                    }

                    MapCursor = MapCursor.None;
                }
            }
        }

        public bool SnapShotToDC2(
            IntPtr hDC,
            IEnvelope extents,
            int width,
            float offsetX,
            float offsetY,
            float clipX,
            float clipY,
            float clipWidth,
            float clipHeight)
        {
            return _map.SnapShotToDC2(hDC, extents.GetInternal(), width, offsetX, offsetY, clipX, clipY, clipWidth, clipHeight);
        }

        public bool StartNewBoundShape(double xScreen, double yScreen)
        {
            return _map.StartNewBoundShape(xScreen, yScreen);
        }

        public bool StartNewBoundShape(int layerHandle)
        {
            return _map.StartNewBoundShapeEx(layerHandle);
        }

        public IEnumerable<IGeometry> GetSnapCandidateGeometriesFromLayers(ICoordinate original, double tolerance)
        {
            IGeometry pointGeom = new Geometry(GeometryType.Point);
            pointGeom.Points.Add(original.Clone());
            pointGeom = pointGeom.Buffer(tolerance * 2, 6);

            IList<IGeometry> geometriesToTest = new List<IGeometry>();
            foreach (var layer in Layers.Where(l => l.IsVector && l.Visible && l.LayerVisibleAtCurrentScale))
            {
                var results = new int[] { };
                if (layer.FeatureSet.GetRelatedShapes(pointGeom, SpatialRelation.Intersects, ref results))
                {
                    try
                    {
                        foreach (var index in results)
                        {
                            var feature = layer.FeatureSet.Features[index];
                            geometriesToTest.Add(feature.Geometry.Clone());
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        // ignore
                    }
                }
            }

            return geometriesToTest;
        }

        [Browsable(false)]
        public IFeatureSet SelectedFeatureSet
        {
            get
            {
                var layer = Layers.Current;
                if (layer != null)
                {
                    return layer.FeatureSet;
                }
                return null;
            }
        }

        [Browsable(false)]
        public IImageSource SelectedImage
        {
            get
            {
                var layer = Layers.Current;
                if (layer != null)
                {
                    return layer.ImageSource;
                }
                return null;
            }
        }

        [Browsable(false)]
        public IVectorLayer SelectedVectorLayer
        {
            get
            {
                var layer = Layers.Current;
                if (layer != null)
                {
                    return layer.VectorSource;
                }
                return null;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoundMapControl));
            MW5.Api.Concrete.Envelope envelope1 = new MW5.Api.Concrete.Envelope();
            MW5.Api.Concrete.SpatialReference spatialReference1 = new MW5.Api.Concrete.SpatialReference();
            ((System.ComponentModel.ISupportInitialize)(this._map)).BeginInit();
            this.SuspendLayout();
            // 
            // _map
            // 
            this._map.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("_map.OcxState")));
            this._map.Size = new System.Drawing.Size(308, 174);
            // 
            // BoundMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.CurrentScale = 21.721422731034483D;
            envelope1.Tag = "";
            this.Extents = envelope1;
            this.Name = "BoundMapControl";
            spatialReference1.Tag = "";
            this.Projection = spatialReference1;
            ((System.ComponentModel.ISupportInitialize)(this._map)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
