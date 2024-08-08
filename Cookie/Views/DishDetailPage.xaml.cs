using Cookie.Models;
using Realms;

namespace Cookie.Views
{

    public partial class DishDetailPage : ContentPage
    {
        private readonly Dish _dish;

        public DishDetailPage(Dish dish)
        {
            InitializeComponent();
            _dish = dish;
            BindingContext = _dish;
        }

        private async void OnAddToBasketClicked(object sender, EventArgs e)
        {
            try
            {
                App.loggedInAccount.AddDishToBasket(_dish);
                var realm = Realm.GetInstance();
                Account currentAccount = realm.All<Account>().FirstOrDefault(a => a.Email == App.loggedInAccount.CurrentAccount.Email);
                if(currentAccount != null)
                await Application.Current.MainPage.DisplayAlert("Success", $"{_dish.Name} was added to your basket | Total dishes {App.loggedInAccount.GetTotalBasketItems()} / {currentAccount.BasketList.Count} ", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error 38 : " + ex.Message, "OK");
            }
        }

    }
}