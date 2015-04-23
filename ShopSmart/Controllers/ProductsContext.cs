using ShopSmart.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopSmart.Controllers
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("Products") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Place> Places { get; set; }
    }
}