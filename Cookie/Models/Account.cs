using Realms;
using MongoDB.Bson;
using MongoDB.Driver;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Cookie.Models
{
    public partial class Account : IRealmObject
    {
        [PrimaryKey]
        public ObjectId _id { get; set; }
        public string user_id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string nickname { get; set; }
        public string last_ip { get; set; }
        public int logins_count { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string last_login { get; set; }
        public bool email_verified { get; set; }
        public string address { get; set; }
        public string phone_no { get; set; }


    }
}
