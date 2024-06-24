using System.Collections.Generic;

namespace Cookie.Models
{
    public class DishRepository
    {
        private readonly List<Dish> _dishes;

        public DishRepository()
        {
            _dishes = new List<Dish>
            {
                new Dish("Spaghetti Carbonara", "A classic Italian pasta dish with eggs, cheese, pancetta, and pepper.", 12.99m),
                new Dish("Margherita Pizza", "A simple pizza with tomato sauce, mozzarella cheese, and fresh basil.", 9.99m)
                // Add more dishes as needed
            };
        }

        public List<Dish> GetDishes()
        {
            return _dishes;
        }

        public void AddDish(Dish dish)
        {
            _dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            _dishes.Remove(dish);
        }
    }
}
