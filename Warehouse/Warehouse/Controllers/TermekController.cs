using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class TermekController : Controller
    {
        public IActionResult Index()
        {
            var termek = new Termek()
            {
                Nev = "Szekreny"
            };
            return View(termek);
        }
    }
}
