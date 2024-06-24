using Cookie.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Cookie.Views
{
    public partial class BasketPage : ContentPage
    {
        private ObservableCollection<Dish> _basketItems;

        public BasketPage(ObservableCollection<Dish> basketItems)
        {
            InitializeComponent();
            _basketItems = basketItems;
            basketCollectionView.ItemsSource = _basketItems;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = _basketItems.Sum(dish => dish.Price);
            totalLabel.Text = $"Total: ${total:F2}";
        }
    }
}
