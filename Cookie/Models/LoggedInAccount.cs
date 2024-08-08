using Realms;
using Realms.Sync;
using System;
using System.Linq;
using System.Net;

namespace Cookie.Models
{
    public class LoggedInAccount
    {
        private Account currentAccount;

        private static readonly Lazy<LoggedInAccount> instance = new Lazy<LoggedInAccount>(() =>
        {
            var loggedInAccount = new LoggedInAccount();
            loggedInAccount.InitializeCurrentAccount();
            return loggedInAccount;
        });

        public static LoggedInAccount Instance => instance.Value;

        private LoggedInAccount() { }

        public Account CurrentAccount
        {
            get => currentAccount;
            private set
            {
                if (currentAccount != value)
                {
                    currentAccount = value;
                    SyncAccountWithRealm();
                }
            }
        }

        private void InitializeCurrentAccount()
        {
            // Load the account from the Realm database if exists, otherwise initialize with default values
            var realm = Realm.GetInstance();
            currentAccount = realm.All<Account>().FirstOrDefault(a => a.Email == "example@example.com");

            if (currentAccount == null)
            {
                currentAccount = new Account
                {
                    Email = "example@example.com",
                    PhoneNo = "0000",
                    GivenName = "0000",
                    FamilyName = "00000",
                    Address = "0000",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    LastLogin = DateTime.Now,
                    EmailVerified = false,
                    BasketUpdatedAt = DateTime.Now,
                    BasketPurchasedAt = DateTime.Now,
                    TotalBasketPrice = 0
                };

                realm.Write(() => realm.Add(currentAccount));
            }
        }

        public int GetTotalBasketItems() => LoggedInAccount.Instance.CurrentAccount.BasketList.Count();

        public void SyncAccountWithRealm()
        {
            var realm = Realm.GetInstance();
            realm.Write(() =>
            {
                realm.Add(currentAccount, update: true);
            });
        }

        public void AddDishToBasket(Dish dish)
        {
            var realm = Realm.GetInstance();
            realm.Write(() =>
            {
                // Ensure currentAccount is not null
                if (currentAccount != null)
                {
                    // Add the dish to the basket list
                    currentAccount.BasketList.Add(dish);
                }
            });
        }

        public void RemoveDishFromBasket(Dish dish)
        {
            if (LoggedInAccount.Instance.CurrentAccount != null)
            {
                var realm = Realm.GetInstance();
                realm.Write(() =>
                {
                    LoggedInAccount.Instance.CurrentAccount.BasketList.Remove(dish);
                    SyncAccountWithRealm();
                });
            }
        }

        public void SetLoggedInAccount(string _email)
        {
            if (_email != null)
            {
                var realm = Realm.GetInstance();
                Account accountInRealm = realm.All<Account>().FirstOrDefault(a => a.Email == _email); // Searches for such an account

                if (accountInRealm != null)
                {
                    realm.Write(() =>
                    {
                        accountInRealm.LastLogin = DateTime.Now;
                    });

                    App.loggedInAccount.CurrentAccount = accountInRealm;
                    foreach (var dish in accountInRealm.BasketList)
                    {
                        App.loggedInAccount.AddDishToBasket(dish);
                    }
                    SyncAccountWithRealm();
                    return;
                }
                else if (accountInRealm == null)
                {
                    accountInRealm = new Account();
                    accountInRealm.Email = _email;
                    accountInRealm.CreatedAt = DateTime.Now;
                    accountInRealm.LastLogin = DateTime.Now;
                    accountInRealm.UpdatedAt = DateTime.Now;
                    accountInRealm.BasketUpdatedAt = DateTime.Now;
                    accountInRealm.BasketPurchasedAt = DateTime.Now;
                    App.loggedInAccount.CurrentAccount = accountInRealm;
                    realm.Write(() => realm.Add(accountInRealm));

                    SyncAccountWithRealm();
                    return;
                }
            }

        }
    }
}