using Cookie.Models;
using System;
using System.Collections.ObjectModel;
using Cookie.Models;

namespace Cookie.Views
{
    public partial class BasketPage : ContentPage
    {
        public ObservableCollection<Dish> BasketDishes { get; set; }

        public BasketPage()
        {
            InitializeComponent();
            //BasketDishes = new ObservableCollection<Dish>(Basket.Instance.Items);
        }
    }
}
