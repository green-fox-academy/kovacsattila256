using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greeting = new Greeting()
            {
                Content = name
            };

            return View(greeting);
        }

        [Route("helloka")]
        public IActionResult GreetingsInLanguages()
        {
            Helloka helloka = new Helloka();
            return View(helloka);
        }
    }
}
