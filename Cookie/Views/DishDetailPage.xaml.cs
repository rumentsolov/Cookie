using Cookie.Models;
using Cookie.Services;
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
            BindDishData();
        }

        private void BindDishData()
        {
            pictureImage.Source = _dish.Picture;
            titleLabel.Text = _dish.Name;
            descriptionLabel.Text = _dish.Description;
            timeLabel.Text = $"Time for cooking: {_dish.TimeForCooking}";
            priceLabel.Text = $"Price: ${_dish.Price:F2}";
        }

        private async void OnAddToBasketClicked(object sender, EventArgs e)
        {
            BasketService.Instance.AddToBasket(_dish);
            await DisplayAlert("Success", $"{_dish.Name} has been added to your basket.", "OK");
            await Navigation.PopAsync();
        }
    }
}
