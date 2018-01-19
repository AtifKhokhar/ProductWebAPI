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
            return Ok(ReturnProductModel());
        }

        private ProductModel ReturnProductModel()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return new ProductModel
            {
                prodId = randomNumber,
                productName = "Elwood Shirt",
                productDescription = "Muscle Fit",
                productBrand = "G-Star Raw"
            };
        }
    }
}
