using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string dbLocation )
        {
            InitializeComponent();

            // MainPage = new MainPage();

            MainPage = new NavigationPage(new MainPage());
            DatabaseLocation = dbLocation;
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
