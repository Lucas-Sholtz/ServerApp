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
    public class OrdersController : ControllerBase
    {
        private readonly Order[] orders = { new Order(1,1,12.5,5),
                                            new Order(2,2,5.3,6),
                                            new Order(3,3,2.2,11),
                                            new Order(4,4,0.95,10) };
        [HttpGet]
        public IActionResult GetOrders()
        {
            return new JsonResult(orders);
        }
    }
}
