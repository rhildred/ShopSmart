using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ShopSmart.Models;


namespace ShopSmart.Controllers
{
    /// <summary>
    /// we used the example https://msdn.microsoft.com/en-ca/data/jj193542.aspx to do this project
    /// </summary>
    /// 

    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("Products") { }
        public DbSet<Product> Products { get; set; }
    }

    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Show()
        {
            var db = new ProductsContext();
            return View(db.Products.ToList());
        }

    }
}
