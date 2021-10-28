using Prism.Mvvm;

namespace Tanker.StationCatalog.ViewModels
{
    public class StationDetailViewModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public StationDetailViewModel()
        {
            Title = "Detail Page";
        }
        
    }
}
