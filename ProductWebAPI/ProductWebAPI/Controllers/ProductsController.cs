using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductWebAPI.Models;

namespace ProductWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            ProductModel productVm = new ProductModel
            {
                prodId = 001,
                productName = "Elwood Jeans",
                productDescription = "Tapered Fit",
                productBrand = "G-Star Raw"
            };
            return Ok(productVm);
        }
    }
}
