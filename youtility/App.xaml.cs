﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace youtility
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Tabbed();
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
