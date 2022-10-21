// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015 - 2019
// </copyright>
// <summary>
//   The composition root.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MW5.Plugins.PictureView
{
    #region

    using MW5.Plugins.Mvp;
    using MW5.Plugins.PictureView.Views;
    using MW5.Plugins.PictureView.Views.Abstract;

    #endregion

    /// <summary>
    /// The composition root.
    /// </summary>
    internal static class CompositionRoot
    {
        #region Public Methods and Operators

        /// <summary>
        /// Composing the container
        /// </summary>
        /// <param name="container">The container.</param>
        public static void Compose(IApplicationContainer container)
        {
            container
                .RegisterService<PolygonPictureView>()
                .RegisterService<LookPicture>();
        }

        #endregion
    }
}