using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tanker.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPage
    {
        private bool _collapsed;
        
        public MenuView()
        {
            InitializeComponent();
        }
        
        private void ShowMenu(object sender, EventArgs e)
        {
            _collapsed = !_collapsed;
            ShowOrHide(_collapsed);
        }

        private async void ShowOrHide(bool isShow)
        {
            if (isShow)
            {
                _ = TitleTxt.FadeTo(0);
                _ = MenuItemsView.FadeTo(1);
                await MainMenuView.RotateTo(0, 300, Easing.BounceOut);
            }
            else
            {
                _ = TitleTxt.FadeTo(1);
                _ = MenuItemsView.FadeTo(0);
                await MainMenuView.RotateTo(-90, 300, Easing.BounceOut);
            }
        }
    }
}