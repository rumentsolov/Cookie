// Models/Dishes.cs
using CommunityToolkit.Mvvm.ComponentModel;
using MongoDB.Bson;
using Realms;

namespace Cookie.Models
{
    public partial class Dish : IRealmObject
    {
        [PrimaryKey]
        public ObjectId _id { get; set; }
        public string DishName { get; set; }
        public Int32 Pcs { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string TimeForCooking { get; set; }
        public string Picture { get; set; }

    }
}
