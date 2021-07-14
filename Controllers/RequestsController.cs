using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    [Route("")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private static readonly Dictionary<string, Tuple<string, string>> CommandControllerActionPairs = new Dictionary<string, Tuple<string, string>>()
        {
            { "GET_PRODUCTS", new Tuple<string, string>("Products","GetProducts") },
            { "GET_CATEGORIES", new Tuple<string, string>("Categories","GetCategories") },
            { "GET_CATEGORY_DESCRIPTION", new Tuple<string, string>("Categories","GetCategoryDescription") },
            { "GET_ORDERS", new Tuple<string, string>("Orders","GetOrders") },
            { "GET_STAGES", new Tuple<string, string>("OrderStages","GetOrderStages") }
        };
        [HttpPost]
        public IActionResult Post(Request request)
        {
            if (CommandControllerActionPairs.ContainsKey(request.CalcId))
            { 
                string command = request.CalcId;
                string args = request.Args;
                string controllerName = CommandControllerActionPairs[command].Item1;
                string actionName = CommandControllerActionPairs[command].Item2;

                return Redirect(Url.Link("", new { controller = controllerName, action = actionName, id = args }));
            }   
            else
                return NotFound();
        }
        /* public IActionResult Post(Request request)
         {
             if (request.CalcId == "GET_PRODUCTS")
                 return Redirect(Url.Link("", new { controller = "Products", action = "GetProducts" }));
             else if (request.CalcId == "GET_CATEGORIES")
                 return Redirect(Url.Link("", new { controller = "Categories", action = "GetCategories" }));
             else if (request.CalcId == "GET_CATEGORY_DESCRIPTION")
                 return Redirect(Url.Link("", new { controller = "Categories", action = "GetCategoryDescription", id = request.Args }));
             else if (request.CalcId == "GET_ORDERS")
                 return Redirect(Url.Link("", new { controller = "Orders", action = "GetOrders" }));
             else if (request.CalcId == "GET_STAGES")
                 return Redirect(Url.Link("", new { controller = "OrderStages", action = "GetOrderStages" }));
             else
                 return NotFound();
         }*/
    }
}
