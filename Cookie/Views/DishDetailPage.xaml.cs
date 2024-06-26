using Cookie.Models;
using Microsoft.Maui.Controls;

namespace Cookie.Views
{
    public partial class DishDetailPage : ContentPage
    {
        private Dish _dish;

        public DishDetailPage(Dish dish)
        {
            InitializeComponent();
            _dish = dish;
            BindingContext = _dish;
        }

        private async void OnAddToBasketClicked(object sender, EventArgs e)
        {
            Basket.AddToBasket(_dish);
            await DisplayAlert("Success", $"{_dish.Name} has been added to your basket.", "OK");
            await Navigation.PopAsync();
        }
    }
}
