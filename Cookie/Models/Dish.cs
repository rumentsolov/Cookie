// Models/Dishes.cs
using CommunityToolkit.Mvvm.ComponentModel;
using MongoDB.Bson;
using Realms;

namespace Cookie.Models
{
    public partial class Dish : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        [Required]
        [MapTo("Name")]
        public string Name { get; set; }

        [MapTo("Pcs")]
        public int Pcs { get; set; }
        [MapTo("Price")]
        public double Price { get; set; }
        [MapTo("Description")]
        public string Description { get; set; }

        [MapTo("TimeForCooking")]
        public int TimeForCooking { get; set; }

        [MapTo("Picture")]
        public string Picture { get; set; }

        public Dish() { }
        public Dish(string _name, int _Pcs, double _Price, string _Description, int _TimeForCooking, string _Picture)
        {
            Name = _name;
            Pcs = _Pcs;
            Price = _Price;
            Description = _Description;
            TimeForCooking = _TimeForCooking;
            Picture = _Picture;
        }
    }

}
