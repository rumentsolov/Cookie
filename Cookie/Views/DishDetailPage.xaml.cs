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
            BindDishData();
        }

        private void BindDishData()
        {
            titleLabel.Text = _dish.Name;
            descriptionLabel.Text = _dish.Description;
            priceLabel.Text = $"Price: ${_dish.Price:F2}";
        }

        private async void OnBuyClicked(object sender, EventArgs e)
        {
            // Handle the purchase logic here (e.g., process payment, save order to database, etc.)
            await DisplayAlert("Success", $"You have purchased {_dish.Name} for ${_dish.Price:F2}.", "OK");

            // Navigate back to the previous page
            await Navigation.PopAsync();
        }
    }
}
