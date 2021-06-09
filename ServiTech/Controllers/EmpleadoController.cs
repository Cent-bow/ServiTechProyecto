using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ServiTech.Data;
using ServiTech.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Controllers
{


    public class EmpleadoController : Controller
    {
        private readonly ILogger<EmpleadoController> _logger;
        private readonly ApplicationDbContext _db;

        public EmpleadoController(ILogger<EmpleadoController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}


        public ActionResult Index()
        {
            var empleadoes = _db.Empleadoes.Include(e => e.Tipoempleado);
            return View(empleadoes.ToList());
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Empleado input)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                // _db.Contactos.Add (input); //
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(input);
        }

        public IActionResult Modificar(int id)
        {
            var output = _db.Empleadoes.Find(id);
            return View(output);
        }

        [HttpPost]

        public IActionResult Modificar(Empleado input)
        {

            if (ModelState.IsValid)
            {
                _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(input);
        }

        public IActionResult Detalle(int id)
        {
            var output = _db.Empleadoes.Find(id);
            return View(output);
        }


        public IActionResult Eliminar(int id)
        {
            var output = _db.Empleadoes.Find(id);
            return View(output);
        }




        [HttpPost]

        public IActionResult Eliminar(Empleado input)
        {
            _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




    }
}
