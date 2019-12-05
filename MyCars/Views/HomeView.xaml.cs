using System;
using System.Collections.Generic;
using MyCars.ViewModels;
using Xamarin.Forms;

namespace MyCars.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
        }
    }
}
