using Cookie.Models;
using System.Collections.ObjectModel;


namespace Cookie.Views
{
    public partial class BasketPage : ContentPage
    {
        public ObservableCollection<Dish> BasketDishes { get; set; }

        public BasketPage()
        {
            InitializeComponent();

            // Initialize ObservableCollection and set as BindingContext
            BasketDishes = new ObservableCollection<Dish>(DishRepository.GetAllDishes());// new ObservableCollection<Dish>(Basket.GetAllPurchased());
            BindingContext = this;

        }


        private async void OnClearBasketClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", $"{Basket.Instance.Items.Count} items cleared.", "OK");
            Basket.ClearBasket();
        }
    }
}
