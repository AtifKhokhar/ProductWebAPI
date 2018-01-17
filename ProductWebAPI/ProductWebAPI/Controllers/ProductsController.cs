using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using ProductWebAPI.Models;

namespace ProductWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        //GET api/values
        [Route("api/productsSync")]
        public IHttpActionResult Get()
        {
            DelayAsync().Wait();
            var product = ReturnProductModel();
            return Ok(product);
        }

        // GET with delay api/values
        [Route("Api/productsAsync")]
        public async Task<IHttpActionResult> GetAsync()
        {
            await DelayAsync().ConfigureAwait(false);
            var product = ReturnProductModel();
            return Ok(product);
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
                productBrand = "async products"
            };
        }

        private async Task DelayAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
        }
        private Task DelaySync()
        {
            return Task.Delay(TimeSpan.FromSeconds(4));
        }

    }
}
