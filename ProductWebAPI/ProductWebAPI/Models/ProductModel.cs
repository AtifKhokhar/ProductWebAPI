using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebAPI.Models
{
    public class ProductModel
    {
        public int prodId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productBrand { get; set; }
    }
}