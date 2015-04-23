using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSmart.Models
{
    /// <summary>
    /// A person can edit places and add/edit products
    /// </summary>
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Place Place { get; set; }

    }
}