// Models/Dishes.cs
using CommunityToolkit.Mvvm.ComponentModel;
using MongoDB.Bson;
using Realms;

namespace Cookie.Models
{
    public partial class Baskets : IRealmObject
    {
        [PrimaryKey]
        public ObjectId _id { get; set; }
        public IList<Dish> Basket { get; set; }

    }
}
