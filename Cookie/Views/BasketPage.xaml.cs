using Cookie.Models;
using System;
using System.Collections.ObjectModel;

namespace Cookie.Views
{
    public partial class BasketPage : ContentPage
    {
        public ObservableCollection<Dish> BasketDishes { get; set; }

        public BasketPage()
        {
            InitializeComponent();
            BasketDishes = new ObservableCollection<Dish>(Basket.Instance.Items);
            dishesCollectionView.ItemsSource = BasketDishes;
        }

        public void RefreshPage()
        {
            BasketDishes.Clear();
            foreach (var item in Basket.Instance.Items)
            {
                BasketDishes.Add(item);
            }
            dishesCollectionView.ItemsSource = BasketDishes;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BasketDishes.Clear();
            foreach (var item in Basket.Instance.Items)
            {
                BasketDishes.Add(item);
            }
            dishesCollectionView.ItemsSource = BasketDishes;
        }

        private void OnClearBasketClicked(object sender, EventArgs e)
        {
            Basket.Instance.Items.Clear();
            RefreshPage(); // Refresh the page after clearing the basket
        }

    }
}
