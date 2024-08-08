using Realms;
using MongoDB.Bson;
using MongoDB.Driver;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Cookie.Models
{
    public class Account : RealmObject
    {
        [PrimaryKey]
        public string Email { get; set; }

        public string PhoneNo { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string Address { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public DateTimeOffset LastLogin { get; set; }

        public bool EmailVerified { get; set; }

        public DateTimeOffset BasketUpdatedAt { get; set; }

        public DateTimeOffset BasketPurchasedAt { get; set; }

        public double TotalBasketPrice { get; set; }

        // Use IList<Dish> for compatibility with Realm
        public IList<Dish> BasketList { get; }

        public Account()
        {
            Email = "example@example.com";
            PhoneNo = "-";
            GivenName = "-";
            FamilyName = "-";
            Address = "-";
            CreatedAt = DateTimeOffset.Now;
            UpdatedAt = DateTimeOffset.Now;
            LastLogin = DateTimeOffset.Now;
            EmailVerified = false;
            BasketUpdatedAt = DateTimeOffset.Now;
            BasketPurchasedAt = DateTimeOffset.Now;
            TotalBasketPrice = 0;
            BasketList = new List<Dish>();
        }

        public void Initialize(string _email)
        {
            Email = _email;
            PhoneNo = "0";
            GivenName = "0";
            FamilyName = "0";
            Address = "0";
            CreatedAt = DateTimeOffset.Now;
            UpdatedAt = DateTimeOffset.Now;
            LastLogin = DateTimeOffset.Now;
            EmailVerified = false;
            BasketUpdatedAt = DateTimeOffset.Now;
            BasketPurchasedAt = DateTimeOffset.Now;
            TotalBasketPrice = 0;
        }
    }
}
