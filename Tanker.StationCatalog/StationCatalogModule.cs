using Prism.Ioc;
using Prism.Modularity;
using Tanker.StationCatalog.ViewModels;
using Tanker.StationCatalog.Views;

namespace Tanker.StationCatalog
{
    public class StationCatalogModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<StationSearchView, StationSearchViewModel>();
        }
    }
}
