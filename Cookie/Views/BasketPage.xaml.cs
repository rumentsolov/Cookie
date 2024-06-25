using Cookie.Models;
using Cookie.Services;
using Microsoft.Maui.Controls;
using System.Linq;

namespace Cookie.Views
{
    public partial class BasketPage : ContentPage
    {
        public BasketPage()
        {
            InitializeComponent();
            basketCollectionView.ItemsSource = BasketService.Instance.BasketItems;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = BasketService.Instance.BasketItems.Sum(dish => dish.Price);
            totalLabel.Text = $"Total: ${total:F2}";
        }
    }
}
