using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tanker.Mobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuItem : Frame
    {
        public static BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(MenuItem), string.Empty);

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        
        public static BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(MenuItem), string.Empty);

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        } 
        
        public MenuItem()
        {
            InitializeComponent();
        }
    }
}