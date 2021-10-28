using System.Collections.Generic;
using Tanker.Mobile.Core.Domain.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tanker.Mobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderedScrollableFuels : Grid
    {
        public static BindableProperty FuelsProperty = BindableProperty.Create(nameof(Fuels), typeof(List<Fuel>), typeof(HeaderedScrollableFuels));
        
        public List<Fuel> Fuels
        {
            get => (List<Fuel>)GetValue(FuelsProperty);
            set => SetValue(FuelsProperty, value);
        }
        
        public HeaderedScrollableFuels()
        {
            InitializeComponent();
        }
    }
}