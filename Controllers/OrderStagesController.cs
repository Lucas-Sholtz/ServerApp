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
    public class OrderStagesController : ControllerBase
    {
        private readonly OrderStage[] orderStages = { new OrderStage(1,"acepted"),
                                                      new OrderStage(2,"processing"),
                                                      new OrderStage(3,"delivering"),
                                                      new OrderStage(4,"completed") };
        [HttpGet]
        public IActionResult GetOrderStages()
        {
            return new JsonResult(orderStages);
        }
    }
}
