using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSmart.Models
{
    /// <summary>
    /// follows the semantics of a product https://developers.google.com/structured-data/rich-snippets/products
    /// </summary>
    public class Product
    {
        public int id { get; set; }
        public string gtin13 { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        /// <summary>
        /// the image is actually a url
        /// </summary>
        public string image { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public virtual Place Place { get; set; }

    }
}