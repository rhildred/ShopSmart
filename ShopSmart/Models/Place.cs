using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopSmart.Models
{
    /// <summary>
    /// A place has people and products, People can only edit products and places to which they belong
    /// </summary>
    public class Place
    {
        public int id { get; set; }
        public string name { get; set; }
        public string formatted_address { get; set; }
        public string formatted_phone_number { get; set; }
        public string image { get; set; }
        public ICollection<Person> People { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}