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
                new Dish { Name = "Pizza", Pcs = 0, Price = 9.99m, Description = "Delicious cheese pizza", TimeForCooking = "20 minutes", Picture = "pizza.png" },
                new Dish { Name = "Burger", Pcs = 0,Price = 5.99m, Description = "Juicy beef burger", TimeForCooking = "15 minutes", Picture = "burger.png" },
                new Dish { Name = "Sallad", Pcs = 0,Price = 7.99m, Description = "Fresh sallad", TimeForCooking = "5 minutes", Picture = "sallad.png" },
                new Dish { Name = "Soup", Pcs = 0,Price = 2.99m, Description = "Incredible hot soup", TimeForCooking = "18 minutes", Picture = "soup.png" },
                new Dish { Name = "Cake", Pcs = 0,Price = 1.99m, Description = "Sweekt cake", TimeForCooking = "12 minutes", Picture = "cake.png" },
                new Dish { Name = "Fish", Pcs = 0,Price = 2.99m, Description = "Incredible baked fish", TimeForCooking = "26 minutes", Picture = "fish.png" },
                // Add more dishes as needed
            };
        }
    }
}
