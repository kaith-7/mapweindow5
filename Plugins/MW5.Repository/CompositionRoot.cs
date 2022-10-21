// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The composition root.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using MW5.Plugins.Mvp;
using MW5.Plugins.Repository.Views;
using MW5.Plugins.Repository.Views.Abstract;

namespace MW5.Plugins.Repository
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<Views.RepositoryDockPanel>()
                .RegisterService<ICreateLayerView, CreateLayerView>();
        }
    }
}