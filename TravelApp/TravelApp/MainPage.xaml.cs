using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
    }
}
