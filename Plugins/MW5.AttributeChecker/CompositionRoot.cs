// -------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Plugins.AttributeChecker.Views.Abstract;
using MW5.Plugins.AttributeChecker.Views;
using MW5.Plugins.Mvp;

namespace MW5.Plugins.AttributeChecker
{
    /// <summary>
    /// The composition root.
    /// </summary>
    internal static class CompositionRoot
    {
        /// <summary>
        /// Composing the container
        /// </summary>
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<CheckResultPresenter>()
                .RegisterService<ICheckerView, CheckResultView>();
        }
    }
}