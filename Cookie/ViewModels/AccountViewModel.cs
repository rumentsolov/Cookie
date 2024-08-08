using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Realms;
using System;

namespace Cookie.ViewModels
{
    public partial class AccountViewModel : ObservableObject
    {
        public AccountViewModel()
        {
            LoadAccountInfo();
        }

        [ObservableProperty]
        private bool isEditing;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string phoneNo;

        [ObservableProperty]
        private string givenName;

        [ObservableProperty]
        private string familyName;

        [ObservableProperty]
        private string address;

        [ObservableProperty]
        private DateTimeOffset createdAt;

        [ObservableProperty]
        private DateTimeOffset updatedAt;

        [ObservableProperty]
        private DateTimeOffset lastLogin;

        [ObservableProperty]
        private bool emailVerified;

        [ObservableProperty]
        private DateTimeOffset latestBasketUpdate;

        [ObservableProperty]
        private int totalBasketItems;

        private void LoadAccountInfo()
        {
            try
            {
                var currentAccount = App.loggedInAccount.CurrentAccount;
                Email = currentAccount.Email;
                PhoneNo = currentAccount.PhoneNo;
                GivenName = currentAccount.GivenName;
                FamilyName = currentAccount.FamilyName;
                Address = currentAccount.Address;
                CreatedAt = currentAccount.CreatedAt;
                UpdatedAt = currentAccount.UpdatedAt;
                LastLogin = currentAccount.LastLogin;
                EmailVerified = currentAccount.EmailVerified;
                LatestBasketUpdate = currentAccount.BasketUpdatedAt;
                TotalBasketItems = App.loggedInAccount.GetTotalBasketItems();
                IsEditing = false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Account load failed: {ex.Message}");
            }
        }

        [RelayCommand]
        private async void SaveEdit()
        {
            var realm = Realm.GetInstance();
            realm.Write(() =>
            {
                App.loggedInAccount.CurrentAccount.PhoneNo = PhoneNo;
                App.loggedInAccount.CurrentAccount.GivenName = GivenName;
                App.loggedInAccount.CurrentAccount.FamilyName = FamilyName;
                App.loggedInAccount.CurrentAccount.Address = Address;
                App.loggedInAccount.CurrentAccount.UpdatedAt = DateTimeOffset.Now;

                // Notify property change
                UpdatedAt = App.loggedInAccount.CurrentAccount.UpdatedAt;
            });

            string buff = UpdatedAt.ToString();
            SemanticScreenReader.Announce(buff);
        }
    }
}