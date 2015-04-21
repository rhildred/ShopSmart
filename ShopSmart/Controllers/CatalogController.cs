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
        // GET api/Products/5
        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        // POST api/Products
        public IHttpActionResult PostProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                var uri = new Uri(
                Url.Link(
                "DefaultApi",
                new { id = product.id }));
                return Created(uri, product);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
