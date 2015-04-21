using ShopSmart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopSmart.Controllers
{
    public class CatalogController : ApiController
    {
        private ProductsContext db = new ProductsContext();
        // GET api/Products
        public IEnumerable<Product> GetProducts()
        {
            return db.Products;
        }
 
    }
}
