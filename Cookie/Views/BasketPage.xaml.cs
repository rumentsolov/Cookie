// Views/BasketPage.xaml.cs

using Cookie.Models;
using Cookie.Services;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace Cookie.Views
{
    public partial class BasketPage : ContentPage
    {
        public ObservableCollection<Dish> BasketItems { get; set; }

        public BasketPage()
        {
            InitializeComponent();
            BasketItems = new ObservableCollection<Dish>(BasketService.Instance.GetBasketItems());
            BindingContext = this;
        }

        private void OnClearBasketClicked(object sender, EventArgs e)
        {
            BasketService.Instance.ClearBasket();
            BasketItems.Clear();
        }
    }
}
