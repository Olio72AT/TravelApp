﻿using SQLite;
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
    public partial class PostDetailPage : ContentPage
    {
        Post selectedPost;
        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();
            this.selectedPost = selectedPost;
            experienceEntry.Text = selectedPost.Experience;
        }

        private void updateButton_Clicked(object sender, EventArgs e)
        {
            selectedPost.Experience = experienceEntry.Text;

            using (SQLiteConnection Connection = new SQLiteConnection(App.DatabaseLocation))
            {
                Connection.CreateTable<Post>();
                int rows = Connection.Update(selectedPost);
                Connection.Close();

                // rows shows, how many rows are inserted

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience has been updated", "Ok");
                }
            }

        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection Connection = new SQLiteConnection(App.DatabaseLocation))
            {
                Connection.CreateTable<Post>();
                int rows = Connection.Delete(selectedPost);
                Connection.Close();

                // rows shows, how many rows are inserted

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience has been deleted", "Ok");
                }
            }
        }
    }
}