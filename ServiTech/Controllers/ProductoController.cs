using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiTech.Data;
using ServiTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly ApplicationDbContext _db;
        public ProductoController(ILogger<ProductoController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var Productos = _db.Productos;
            return View(Productos);
        }

      
        public IActionResult Agregar()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Agregar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                // _db.Producto.Add (producto); //
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(producto);
        }

        public IActionResult Eliminar(int id)
        {
            var producto = _db.Productos.Find(id);
            return View(producto);
        }


        [HttpPost]


        public IActionResult Eliminar(Producto producto)
        {

            _db.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
