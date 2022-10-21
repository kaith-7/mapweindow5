﻿using System;
using MW5.Api.Interfaces;

namespace MW5.Tools.Model.Layers
{
    public class RasterInput: DatasourceInput, IRasterInput
    {
        public RasterInput(IRasterSource raster)
            : base(raster)
        {
            if (raster == null) throw new ArgumentNullException("raster");
            Datasource = raster;
        }

        public new IRasterSource Datasource
        {
            get { return Datasource as IRasterSource; }
            set { Datasource = value; }
        }
    }
}
