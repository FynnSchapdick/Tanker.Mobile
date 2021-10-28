using Prism.Modularity;
using Prism.Navigation;
using Tanker.Mobile.Core.ViewModels;

namespace Tanker.StationCatalog.ViewModels
{
    public class StationSearchViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public StationSearchViewModel(IModuleManager moduleManager, INavigationService navigationService)
            : base(moduleManager)
        {
            _navigationService = navigationService;
        }
        
        public override async void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }
    }
}