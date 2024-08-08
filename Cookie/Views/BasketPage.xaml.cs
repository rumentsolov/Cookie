using Cookie.Models;
using System;
using System.Collections.ObjectModel;
using Cookie.Models;
using Realms;

namespace Cookie.Views
{
    public partial class BasketPage : ContentPage
    {
        public ObservableCollection<Dish> BasketItems { get; set; }

        public BasketPage()
        {
            InitializeComponent();
            BasketItems = new ObservableCollection<Dish>();
            BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadBasket(); // Reload the basket items every time the page appears
        }

        private void LoadBasket()
        {
            try
            {
                BasketItems.Clear(); // Clear existing items

                var basketList = App.loggedInAccount.CurrentAccount.BasketList.ToList();
                if (basketList.Count > 0)
                {
                    foreach (var dish in basketList)
                    {
                        BasketItems.Add(dish);
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Basket is empty.");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to load basket items: {ex.Message}");
            }
        }

        private async void OnClearBasketClicked(object sender, EventArgs e)
        {
            var realm = Realm.GetInstance();
            var loggedInAccount = App.loggedInAccount;
            var accountInRealmDb = realm.All<Account>().FirstOrDefault(a => a.Email == loggedInAccount.CurrentAccount.Email);

            if (accountInRealmDb != null)
            {
                realm.Write(() =>
                {
                    accountInRealmDb.BasketList.Clear();
                });
                BasketItems.Clear();
                await DisplayAlert("Success", "Your basket has been cleared.", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Could not find your account.", "OK");
            }
        }
    }
}