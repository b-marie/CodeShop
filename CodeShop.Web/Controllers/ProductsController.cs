using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodeShop.Web.Controllers
{
    [Route("/[controller]")]
    public class ProductsController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }

    }
}
