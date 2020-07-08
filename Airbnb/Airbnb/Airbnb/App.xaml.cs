﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Airbnb
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SearchPage();
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
