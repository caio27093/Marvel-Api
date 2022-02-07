using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Linq;
using Marvel.Classes;
using System.Net;
using System.IO;
using System.Text;

namespace Marvel.View
{
    public class SplashScreen : ContentPage
    {
        Label splashScreen;
        public SplashScreen()
        {

            NavigationPage.SetHasNavigationBar(this, false);
            var layout = new AbsoluteLayout ( );

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

            base.OnAppearing ( );
            await this.ColorTo ( Color.FromRgb ( 255, 23, 41 ), Color.FromRgb ( 34, 34, 34 ), c => BackgroundColor = c, 3000 );
            await splashScreen.FadeTo(0, 1000);


            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
