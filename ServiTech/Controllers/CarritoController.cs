using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ServiTech.Data;
using ServiTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiTech.Controllers;
using ServiTech.Areas.Identity;


namespace ServiTech.Controllers
{


    public class CarritoController : Controller
    {


        private readonly ILogger<CarritoController> _logger;
        private readonly ApplicationDbContext _db;

        //private static Producto pruebaProducto;
        public CarritoController(ILogger<CarritoController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var producto = _db.Productos;
            return View(producto);
        }




        //public IActionResult Modificar(int id)
        //{
        //    var output = _db.Productos.Find(id);
        //    return View(output);
        //}


        //[HttpPost]

        //public IActionResult Modificar(Producto input)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //        _db.Productos.Where(a => a.Cantidad == a.Cantidad);

        //        _db.SaveChanges();

        //        return RedirectToAction("Index");
        //    }

        //    return View(input);
        //}

        //[HttpPost]
        //public IActionResult Editar(int id)
        //{
        //    var output = _db.Productos.Find(id);
        //    return View(output);
        //}

        //public IActionResult Editar(int? id)
        //{

        //    if (ModelState.IsValid) { 

        //    Producto productos = _db.Productos.Find(id);
        //    ViewBag.IdPedido = new SelectList(_db.Productos, "Id", "Detalle", productos.Id);

        //    }

        //    return RedirectToAction("Index");
        //}



        //public IActionResult Detalle(int id)
        //{
        //    var output = _db.Productos.Find(id);
        //    return View(output);
        //}


        //public IActionResult Eliminar(int id)
        //{
        //    var output = _db.Productos.Find(id);
        //    return View(output);
        //}


        //[HttpPost]

        //public IActionResult Eliminar(Producto input)
        //{
        //    _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        //    _db.SaveChanges();

        //    return RedirectToAction("Index");
        //}

       


        public IActionResult AgregarAlCarrito(CarritoModelo input)
        {

            IEnumerable<Producto> productoPrueba = _db.Productos;

            var producto = _db.Productos.Find(input.Id);

            input.PrecioUnitario = producto.Precio;
            input.Id = producto.Id;
            input.UserName = User.Identity.Name;
            input.Cantidad = 1;

            _db.Carritos.Add(input);
            _db.SaveChanges();

            return Json(new { Result = true });

        }

    }
}
