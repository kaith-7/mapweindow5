﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using MW5.Api.Concrete;
using MW5.Api.Helpers;
using MW5.Api.Legend;
using MW5.Plugins.Interfaces;
using MW5.Services.Concrete;

namespace MW5.Services.Serialization
{
    /// <summary>
    /// Represents a data contract for MapWindow project file. 
    /// Before serialization the instance is populated from ISerializedContext.
    /// After deserialization RestoreState method should be called.
    /// </summary>
    [DataContract(Name="MapWindow5")]
    public class XmlProject
    {
        public XmlProject(ISecureContext context, string filename)
        {
            int selectedHandle = context.Legend.SelectedLayerHandle;

            Layers = context.Legend.Layers.Select(lyr => {
                var xmlLayer = new XmlLayer(lyr, lyr.Handle == selectedHandle);
                if (lyr.IsVector && lyr.LayerSource is MW5.Api.Interfaces.IFeatureSet fs && !string.IsNullOrEmpty(fs.UnProjectedFilename))
                {
                    xmlLayer.Identity.Filename = fs.UnProjectedFilename;
                }
                return xmlLayer;
            }).ToList();
    
            Groups = context.Legend.Groups.Select(g => new XmlGroup(g)).ToList();

            Plugins = context.PluginManager.ActivePlugins.Select(p => new XmlPlugin()
            {
                Name = p.Identity.Name,
                Guid = p.Identity.Guid,
                Settings = p.GetSettings()
            }).ToList();

            Map = new XmlMap
            {
                Projection = context.Map.Projection.ExportToWkt(),
                Envelope = new XmlEnvelope(context.Map.Extents),
                TileProviderId = context.Map.Tiles.ProviderId
            };

            Settings = new XmlProjectSettings {SavedAsFilename = filename};

            if (!context.Locator.Empty)
            {
                var service = context.Container.GetInstance<ImageSerializationService>();
                Locator = new XmlMapLocator(context.Locator, service);
            }
        }

        [DataMember] public XmlMap Map { get; set; }
        [DataMember] public XmlMapLocator Locator { get; set; }
        [DataMember] public XmlProjectSettings Settings { get; set; }
        [DataMember] public List<XmlGroup> Groups { get; set; }
        [DataMember] public List<XmlLayer> Layers { get; set; }
        [DataMember] public List<XmlPlugin> Plugins { get; set; }
        
    }
}
