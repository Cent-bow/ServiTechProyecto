using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Controllers
{
    public class DireccionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
