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
    public class CategoriesController : ControllerBase
    {
        private readonly Category[] categories = { new Category(1,"Category1","<p>Description1</p>"),
                                                   new Category(2,"Category2","<p>Description2</p>") };
        [HttpGet]
        public IActionResult GetCategories()
        {
            return new JsonResult(categories);
        }
        [HttpGet("{Id}")]
        public IActionResult GetCategoryDescription(int Id)
        {
            var categoryDescription = from c in categories
                           where c.Id == Id
                           select c.Description;

            if (categoryDescription.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return base.Content(categoryDescription.First());
            }
        }
    }
}
