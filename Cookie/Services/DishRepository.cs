// Models/DishRepository.cs

using System.Collections.Generic;

namespace Cookie.Models
{
    public static class DishRepository
    {
        public static List<Dish> GetAllDishes()
        {
            return new List<Dish>
            {
                new Dish { Name = "Pizza", Price = 9.99m, Description = "Delicious cheese pizza", TimeForCooking = "20 minutes", Picture = "pizza.jpg" },
                new Dish { Name = "Burger", Price = 5.99m, Description = "Juicy beef burger", TimeForCooking = "15 minutes", Picture = "burger.jpg" },
                // Add more dishes as needed
            };
        }
    }
}
