namespace FutbolerosApp
{
    using FutbolerosApp.Helpers;
    using FutbolerosApp.Models;
    using FutbolerosApp.Views;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Xamarin.Forms;
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Settings.IsLoggedIn)
            {
                MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage());
            }
        }

        protected override void OnStart()
        {
           
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
