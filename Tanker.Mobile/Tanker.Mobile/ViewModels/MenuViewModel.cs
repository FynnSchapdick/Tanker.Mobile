using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Modularity;
using Prism.Navigation;
using Tanker.Mobile.Core.Domain.Entities;
using Tanker.Mobile.Core.ViewModels;
using Tanker.StationCatalog;
using Tanker.StationCatalog.Views;
using Xamarin.Forms;

namespace Tanker.Mobile.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private INavigationService _navigationService;
        public ObservableCollection<MenuPageItem> MenuPageItems { get; set; }

        private MenuPageItem _selected;
        
        public MenuPageItem Selected
        {
            get => _selected;
            set => SetProperty(ref _selected, value);
        }

        private ImageSource _menuImage;
        public ImageSource MenuImage
        {
            get =>  _menuImage;
            set => SetProperty(ref _menuImage, value, nameof(MenuImage));
        }

        public DelegateCommand NavigateCommand { get; }
        
        public MenuViewModel(IModuleManager moduleManager, INavigationService navigationService) : base(moduleManager)
        {
            _navigationService = navigationService;

            MenuPageItems = new ObservableCollection<MenuPageItem>()
            {
                new MenuPageItem()
                {
                    Icon = "gas.png",
                    TargetType = typeof(StationSearchView),
                    Title = "Tankstellen"
                },
            };

            NavigateCommand = new DelegateCommand(Navigate);
        }
        
        public override void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("icon"))
                MenuImage = ImageSource.FromFile(parameters.GetValue<string>("icon"));
            
            base.LoadModule(nameof(StationCatalogModule));
            
            base.Initialize(parameters);
        }

        async void Navigate()
        {
            var result = await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + Selected.TargetType.Name);
            
            if(!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}