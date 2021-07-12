using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiTech.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        
        }

        //Con el metodo IActionResult, puede llamar al Index, y que me retorne a la misma 
        //vista, esto es debido al que parentesis esta vacio.
        public IActionResult Index()
        {
         
            return View();
        }

        public IActionResult NuestrosProductos()
        {

            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Contactanos()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Tecnologia()
        {
            return View();
        }

        public IActionResult Tienda()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
