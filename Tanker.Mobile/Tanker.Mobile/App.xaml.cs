using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Tanker.Mobile.Core.ViewModels;
using Tanker.Mobile.ViewModels;
using Tanker.Mobile.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Tanker.Mobile
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            string navigationPage = "NavigationPage/MenuPage";
            var result = await NavigationService.NavigateAsync($"{navigationPage}?title=Menu&icon=menu.png");
            
            if(!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<MenuView, MenuViewModel>("MenuPage");
            containerRegistry.RegisterForNavigation<NavigationPage>();
        }
        
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<StationCatalog.StationCatalogModule>(InitializationMode.OnDemand);
            moduleCatalog.AddModule<Core.CoreModule>(InitializationMode.OnDemand);
        }
    }
}
