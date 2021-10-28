using Prism.Ioc;
using Prism.Modularity;
using Tanker.Mobile.Core.ViewModels;

namespace Tanker.Mobile.Core
{
    public class CoreModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterScoped<BaseViewModel>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
    }
}