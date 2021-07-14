using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Product[] products = { new Product(1,1,"Caption1", "https://ibb.co/dLRqcp3"),
                                                new Product(2,1,"Caption2", "https://ibb.co/dLRqcp3"),
                                                new Product(3,2,"Caption3", "https://ibb.co/dLRqcp3"),
                                                new Product(4,2,"Caption4", "https://ibb.co/dLRqcp3") };
        [HttpGet]
        public JsonResult GetProducts()
        {
            return new JsonResult(products);
        }
    }
}
