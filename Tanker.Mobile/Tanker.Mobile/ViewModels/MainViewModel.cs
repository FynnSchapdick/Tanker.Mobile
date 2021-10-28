using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Modularity;
using Prism.Navigation;
using Tanker.Mobile.Core.ViewModels;

namespace Tanker.Mobile.ViewModels
{
    public class MainViewModel : BaseViewModel, INavigationService
    {
        private readonly IModuleManager _moduleManager;

        public DelegateCommand NavigateToStationSearchView;

        public MainViewModel(IModuleManager moduleManager) : base(moduleManager)
        {
            _moduleManager = moduleManager;

            NavigateToStationSearchView = new DelegateCommand(() =>
            {
            });
        }

        public Task<INavigationResult> GoBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> GoBackAsync(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> GoBackAsync(INavigationParameters parameters, bool? useModalNavigation, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> GoBackToRootAsync(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(Uri uri)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(Uri uri, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(string name, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(string name, INavigationParameters parameters, bool? useModalNavigation, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(Uri uri, INavigationParameters parameters, bool? useModalNavigation, bool animated)
        {
            throw new NotImplementedException();
        }
    }
}