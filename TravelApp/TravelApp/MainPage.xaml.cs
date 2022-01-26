using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SimulateInternet();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            LoginButton.Text = "Peter";
            bool EmailEmpty = string.IsNullOrEmpty(EmailEntry.Text);
            bool PasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

            if (EmailEmpty || PasswordEmpty)
            {
                // Do not navigate
            }
            else
            {
                // Navigate
                Navigation.PushAsync(new HomePage());

            }
        }

        public static async Task<string> GetData()
        {
            Thread.Sleep(2000);   // Simulation of Internet access
            return "completed";
        }

        public async void SimulateInternet()
        {
            Console.WriteLine("before");
            var result = await GetData();
            Console.WriteLine("after " + result); 
        }
    }
}
