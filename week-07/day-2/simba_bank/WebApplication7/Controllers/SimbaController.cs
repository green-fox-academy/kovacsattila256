using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class BankAccountController : Controller
    {
        [Route("simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount() { Name = "Simba", Balance = 2000, AnimalType = "Lion" };
            return View(account);
        }

        [Route("accounts")]
        public IActionResult Accounts()
        {
            List<BankAccount> accounts = new List<BankAccount>(){
            new BankAccount(){Id= 1, Name = "Toki", Balance = 3000, AnimalType = "dawg" },
            new BankAccount(){Id= 2, Name = "Negro", Balance = 1400, AnimalType = "cock" },
            new BankAccount(){Id= 3, Name = "Cuncus", Balance = 720, AnimalType = "whale" },
            new BankAccount(){Id= 4, Name = "Killer", Balance = 10, AnimalType = "rabbit" }
            };

            return View(accounts);
        }
    }
}