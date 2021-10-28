using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using Prism.Modularity;

namespace Tanker.Mobile.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        private readonly IModuleManager _moduleManager;
        private readonly INavigationService _navigationService;

        private bool _isSampleModuleRegistered;
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        
        public bool IsSampleModuleRegistered
        {
            get => _isSampleModuleRegistered;
            set => SetProperty(ref _isSampleModuleRegistered, value);
        }
        
        public ICommand LoadStationCatalogModuleCommand { get; set; }

        public ICommand NavigateToDetailPageCommand { get; set; }

        public ViewModelBase(IModuleManager moduleManager, INavigationService navigationService)
        {
            _moduleManager = moduleManager;
            _navigationService = navigationService;

            LoadStationCatalogModuleCommand = new DelegateCommand(LoadStationCatalogModule, ()=>!IsSampleModuleRegistered)
                .ObservesProperty(()=>IsSampleModuleRegistered);
            NavigateToDetailPageCommand = new DelegateCommand(NavigateToDetailView, ()=>IsSampleModuleRegistered)
                .ObservesProperty(()=>IsSampleModuleRegistered);
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = parameters.GetValue<string>("title");
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
        
        private void LoadStationCatalogModule()
        {
            _moduleManager.LoadModule("StationCatalogModule");
            IsSampleModuleRegistered = true;
        }
        
        private async void NavigateToDetailView()
        {
            var result = await _navigationService.NavigateAsync("ViewDetail");
            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
