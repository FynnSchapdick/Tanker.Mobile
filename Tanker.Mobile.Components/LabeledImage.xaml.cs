using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tanker.Mobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabeledImage : Grid
    {
        public static BindableProperty ImageSourceProperty =
            BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(LabeledImage), null, BindingMode.TwoWay);

        public ImageSource ImageSource
        {
            get => (ImageSource) GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }
        
        public static BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(LabeledImage), string.Empty, BindingMode.TwoWay);
        
        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public LabeledImage()
        {
            InitializeComponent();
        }
    }
}