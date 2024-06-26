using System.Collections.ObjectModel;

namespace Cookie.Models
{
    public class Basket
    {
        private static Basket _instance; // Static instance for singleton pattern

        public ObservableCollection<Dish> Items { get; set; }

        // Singleton pattern to ensure one instance of Basket
        public static Basket Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Basket();

                return _instance;
            }
        }

        private Basket()
        {
            Items = new ObservableCollection<Dish>(); // Initialize Items list
        }

        public static ObservableCollection<Dish> AddToBasket(Dish _dish)
        {
            Instance.Items.Add(_dish);
            return Instance.Items;
        }

        public static ObservableCollection<Dish> GetAllPurchased()
        {
            ObservableCollection<Dish> Buff = new ObservableCollection<Dish>();

            foreach (Dish dish in Instance.Items)
            {
                if (dish.Pcs > 0)
                    Buff.Add(dish);
            }

            return Instance.Items; //Buff;
        }

        public static ObservableCollection<Dish> ClearBasket()
        {
            Instance.Items.Clear();
            return Instance.Items;
        }
    }
}
