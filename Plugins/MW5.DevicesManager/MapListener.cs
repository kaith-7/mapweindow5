// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapListener.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015 - 2019
// </copyright>
// <summary>
//   The map listener.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MW5.Plugins.DevicesManager
{
    #region

    using System;
    using System.Diagnostics;
    using System.IO;

    using MW5.Api.Events;
    using MW5.Api.Interfaces;
    using MW5.Api.Legend.Abstract;
    using MW5.Api.Legend.Events;
    using MW5.Plugins.Interfaces;

    #endregion

    /// <summary>
    /// The map listener.
    /// </summary>
    public class MapListener
    {
        #region Fields

        /// <summary>
        /// The context of the application, holding the menu, layers, project, etc.
        /// </summary>
        private readonly IAppContext _context;

        /// <summary>
        /// The _sample dock window.
        /// </summary>
        private readonly DevicesForm _deviceForm;

        /// <summary>
        /// The _sample dock window.
        /// </summary>
        private readonly CsvToShp _csvToShp ;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapListener" /> class.
        /// </summary>
        /// <param name="context">The application context.</param>
        /// <param name="plugin">The plugin.</param>
        /// <param name="sampleDockWindow">Reference to the sample dock window</param>
        public MapListener(IAppContext context, DevicesManagerPlugin plugin, DevicesForm deviceForm, CsvToShp csvToShp)
        {
            // Check input:
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");
            if (deviceForm == null) throw new ArgumentNullException("sampleDockWindow");

            // Save local references:
            _context = context;
            _deviceForm = deviceForm;
            _csvToShp = csvToShp;

            // As show case:
            Debug.WriteLine("Number of loaded layers; " + _context.Layers.Count);
        }

        #endregion

    }
}