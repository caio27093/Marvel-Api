﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Marvel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.SplashScreen();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}