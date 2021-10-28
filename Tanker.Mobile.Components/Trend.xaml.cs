using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tanker.Mobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trend : Grid
    {
        public static BindableProperty ChangeProperty = BindableProperty.Create(nameof(Change), typeof(float), typeof(Trend), 0,000);

        public float Change
        {
            get => (float)GetValue(ChangeProperty);
            set => SetValue(ChangeProperty, value);
        }
        
        public Trend()
        {
            InitializeComponent();
        }
    }
}