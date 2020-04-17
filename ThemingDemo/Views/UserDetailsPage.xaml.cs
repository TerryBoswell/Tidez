﻿using System;
using Xamarin.Forms;

namespace Tidez
{
    public partial class UserDetailsPage : ContentPage
    {
        public UserDetailsPage()
        {
            InitializeComponent();
        }

        async void OnThemeToolbarItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ThemeSelectionPage()));
        }
    }
}
