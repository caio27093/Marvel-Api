using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Linq;

namespace Marvel.View
{
    public class SplashScreen : ContentPage
    {
        Label splashScreen;
        public SplashScreen()
        {

            BackgroundColor = Color.FromHex ( "#E8121D" );


            NavigationPage.SetHasNavigationBar(this, false);

            var layout = new AbsoluteLayout();
            splashScreen = new Label
            {
                Text = "MARVELOUS",
                TextColor = Color.FromHex("fff"),
                Style = (Style)Application.Current.Resources["BebasBoldLabelStyle"],
                FontSize=64
            };

            AbsoluteLayout.SetLayoutFlags(splashScreen, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashScreen, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            layout.Children.Add(splashScreen);
            Content = layout;
        }

        protected override async void OnAppearing()
        {
                base.OnAppearing();
                await splashScreen.ScaleTo(1, 5000);
                Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
