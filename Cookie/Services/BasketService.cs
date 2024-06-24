using Cookie.Models;
using System.Collections.ObjectModel;

namespace Cookie.Services
{
    public class BasketService
    {
        private static BasketService _instance;
        private readonly ObservableCollection<Dish> _basketItems;

        private BasketService()
        {
            _basketItems = new ObservableCollection<Dish>();
        }

        public static BasketService Instance => _instance ??= new BasketService();

        public ObservableCollection<Dish> BasketItems => _basketItems;

        public void AddToBasket(Dish dish)
        {
            _basketItems.Add(dish);
        }

        public void ClearBasket()
        {
            _basketItems.Clear();
        }
    }
}
