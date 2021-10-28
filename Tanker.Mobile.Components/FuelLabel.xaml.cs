using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tanker.Mobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuelLabel: Grid
    {
        public static BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(FuelLabel), string.Empty);

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public static BindableProperty PriceProperty = BindableProperty.Create(nameof(Price), typeof(float), typeof(FuelLabel), string.Empty);

        public float Price
        {
            get => (float)GetValue(PriceProperty);
            set => SetValue(PriceProperty, value);
        }
        
        public static BindableProperty PriceChangedValProperty = BindableProperty.Create(nameof(PriceChangedValue), typeof(float), typeof(FuelLabel), 0.000);

        public float PriceChangedValue
        {
            get => (float)GetValue(PriceProperty);
            set => SetValue(PriceProperty, value);
        }
        
        public static BindableProperty CurrencyProperty = BindableProperty.Create(nameof(Currency), typeof(string), typeof(FuelLabel), string.Empty);
        
        public string Currency
        {
            get => (string)GetValue(CurrencyProperty);
            set => SetValue(CurrencyProperty, value);
        }
        
        public FuelLabel()
        {
            InitializeComponent();
        }
    }
}