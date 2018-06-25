using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting/{name}")]
        public IActionResult Greeting(string name)
        {
            Greeting hiSayer = new Greeting()
            {                
                Content=name
            };
            return new JsonResult(hiSayer);
        }
    }
}