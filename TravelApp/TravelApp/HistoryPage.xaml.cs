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
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();               // If Table exists, the command will be internally ignored.
                var posts = conn.Table<Post>().ToList();
                postListView.ItemsSource = posts;
            }
                
            // conn.Close();    <---- replaced by using ... calls dispose() after close of using area


        }

        private void postListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPost = postListView.SelectedItem as Post;
            
            if (selectedPost != null)
            {
                Navigation.PushAsync(new PostDetailPage(selectedPost));
            }

        }
    }
}