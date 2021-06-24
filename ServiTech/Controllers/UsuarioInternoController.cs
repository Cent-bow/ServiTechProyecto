using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Controllers
{
    public class UsuarioInternoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult loginPrueba()
        {
            return View();
        }
    }
}
