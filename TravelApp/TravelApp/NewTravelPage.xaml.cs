using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            using (SQLiteConnection Connection = new SQLiteConnection(App.DatabaseLocation))
            {
                Connection.CreateTable<Post>();
                int rows = Connection.Insert(post);
                Connection.Close();

                // rows shows, how many rows are inserted

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience has been added", "Ok");
                }
            }
            
        }
    }
}