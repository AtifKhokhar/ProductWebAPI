using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http;
using NUnit.Framework;
using ProductWebAPI;
using ProductWebAPI.Controllers;

namespace ProductWebAPI.Tests.Controllers
{
    public class ProductsControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest
                .Create("http://localhost:55199/api/products/1");
            // Act
            var response = (HttpWebResponse)webRequest.GetResponse();
            // Assert status is 200 OK
            Assert.That(response.StatusCode.Equals(HttpStatusCode.OK));

        }
    }
}
