namespace Cookie.Models
{
    public class Basket
    {
        private static Basket _instance; // Static instance for singleton pattern

        public List<Dish> Items { get; set; }

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
            Items = new List<Dish>(); // Initialize Items list
        }

        public static List<Dish> AddToBasket(Dish _dish)
        {
            Instance.Items.Add(_dish);
            return Instance.Items;
        }

        public static List<Dish> GetAllPurchased()
        {
            List<Dish> Buff = new List<Dish>();

            foreach (Dish dish in Instance.Items)
            {
                if (dish.Pcs > 0)
                    Buff.Add(dish);
            }

            return Buff;
        }

        public static List<Dish> ClearBasket()
        {
            Instance.Items.Clear();
            return Instance.Items;
        }
    }
}
