using System;
using System.Collections.Generic;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;

namespace Tanker.Mobile.Core.ViewModels
{
    public abstract class BaseViewModel : BindableBase, IInitialize, IDestructible, IModuleManager
    {

        public IEnumerable<IModuleInfo> Modules { get; }
        public virtual event EventHandler<ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;
        public virtual event EventHandler<LoadModuleCompletedEventArgs> LoadModuleCompleted;
        
        private readonly IModuleManager _moduleManager;
        
        protected BaseViewModel(IModuleManager moduleManager)
        {
            _moduleManager = moduleManager;
        }
        
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }
        
        private string _statusText;
        public string StatusText
        {
            get => _statusText;
            set => SetProperty(ref _statusText, value);
        }
        
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        
        private bool _isCoreModuleRegistered;
        public bool IsCoreModuleRegistered
        {
            get => _isCoreModuleRegistered;
            set => SetProperty(ref _isCoreModuleRegistered, value);
        }

        public void SetState<T>(Action<T> action) where T : class
        {
            action(this as T);
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = parameters.GetValue<string>("title");
            
            _moduleManager.LoadModule(nameof(CoreModule));
        }
        
        public virtual void LoadModule(string moduleName)
        {
            if (!IsCoreModuleRegistered)
            {
                _moduleManager.LoadModule(nameof(CoreModule));
            }
            
            _moduleManager.LoadModule(moduleName);
        }

        public virtual void Destroy()
        {

        }

        public virtual void Run()
        {
            throw new NotImplementedException();
        }
    }
}