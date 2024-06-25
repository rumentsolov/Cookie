// Services/BasketService.cs

using System.Collections.Generic;
using System.Linq;
using Cookie.Models;

namespace Cookie.Services
{
    public class BasketService
    {
        private List<Dish> _basketItems;

        private static BasketService _instance;
        public static BasketService Instance => _instance ??= new BasketService();

        private BasketService()
        {
            _basketItems = new List<Dish>();
        }

        public void AddToBasket(Dish dish)
        {
            _basketItems.Add(dish);
        }

        public List<Dish> GetBasketItems()
        {
            return _basketItems.ToList(); // Return a copy to prevent direct modification
        }

        public void ClearBasket()
        {
            _basketItems.Clear();
        }
    }
}
