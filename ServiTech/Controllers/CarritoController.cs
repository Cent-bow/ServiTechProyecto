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
using System.Net;

namespace ServiTech.Controllers
{


    public class CarritoController : Controller
    {


        private readonly ILogger<CarritoController> _logger;
        private readonly ApplicationDbContext _db;

    
        public CarritoController(ILogger<CarritoController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult AgregarAlCarrito()
        {
            return View();

        }

        //le estoy diciendo que la variable carritos, sera igual a la tabla carritos
        //asi que retorname los registros o datos de la tabla en la base de datos a la vista.
        //todo esto lo logro con un foreach. Y para hacer esto tengo que loguearme obligado.

        [Authorize]
        public IActionResult IndexCarrito()
        {
            var carritos = _db.Carritos;
            return View(carritos);

        }


        //var producto = _db.Productos.Find(input.ProductoId), la variable producto
        //sera igual a la tabla productos de la db, asi que le digo al parametro input del
        // carritoModelo: encuentrame el productoId. que es el Id del producto.


        //El método FirstOrDefault
        //Devuelve el primer elemento de una secuencia o un valor
        // predeterminado si la secuencia no contiene elementos.

        //Estoy declarando la variable productoCarrito, que va a ser igual
        //a la tabla carritos, de mi db. Entonces le estoy diciendo en pocas palabras
        //que me encuentre el nombre del usuario que esta en el User.Identity.Name
        //y el productoId.

        //SI producto carrito es nulo, llamame a ProductoName de la clase carrito,
        //que sera igual a Nombre de la clase producto, llamame PrecioUnitario de  la clase
        // o tabla Carrito que sera igual a precio de la clase producto, etc.
        //La canridad de la clase carrito sera igual a 1, por producto y todo esto de clase
        //carrito, agregamelo a la tabla carritos.

        //ENTONCES SI ESTA CONDICION SE CUMPLE, producto carrito.cantidad tendra que ser
        //mas de uno o igual a uno. Entonces llamo a productoCarrito y le digo que si agrego
        //al carrito, que todo esto me lo guarde en db.Entry(productoCarrito)
        //del enum modificar de la entityState.

        //y que se guarden los cambios y me retorne el Json si todo la condicion se cumple.


        [HttpPost]

        public IActionResult AgregarAlCarrito(CarritoModelo input)
        {

            var producto = _db.Productos.Find(input.ProductoId);
            var productoCarrito = _db.Carritos.FirstOrDefault(a => a.UserName == User.Identity.Name && a.ProductoId == input.ProductoId);

            if (productoCarrito == null)
            {

                input.ProductoName = producto.Nombre;
                input.PrecioUnitario = producto.Precio;
                input.UserName = User.Identity.Name;
                input.Cantidad = 1;
                _db.Carritos.Add(input);

            }
            else
            {
                productoCarrito.Cantidad += 1;
                _db.Entry(productoCarrito).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            }

            _db.SaveChanges();

            return Json(new { Result = true });
        }



        //Lo de abajo no va  --------------------------------------------------------


        //public IActionResult Eliminar()
        //{
        //    return View();

        //}


        //public IActionResult Eliminar(int id)
        //{
        //    var output = _db.Carritos.Find(id);
        //    return View(output);
        //}


        //public IActionResult EliminarCarrito(CarritoModelo input)
        //{
        //    var producto = _db.Productos.Find(input.ProductoId);
        //    var productoCarrito = _db.Carritos.FirstOrDefault(a => a.UserName == User.Identity.Name && a.ProductoId == input.ProductoId);

        //    if (ModelState.IsValid) {

        //        _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        //        _db.SaveChanges();

        //    }

        //    return RedirectToAction("Index");
        //}



        //public IActionResult Eliminar(CarritoModelo input)
        //{

        //    var producto = _db.Productos.Find(input.ProductoId);
        //    var productoCarrito = _db.Carritos.FirstOrDefault(a => a.UserName == User.Identity.Name && a.ProductoId == input.ProductoId);

        //    if (productoCarrito == null)
        //    {
        //        _db.Entry(productoCarrito).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;


        //    }

        //    _db.SaveChanges();

        //}



        //public IActionResult AgregarAlCarrito(CarritoModelo input)
        //{

        //    IEnumerable<Producto> productoPrueba = _db.Productos;

        //    var producto = _db.Productos.Find(input.Id);

        //    input.PrecioUnitario = producto.Precio;
        //    input.Id = producto.Id;
        //    input.UserName = User.Identity.Name;
        //    input.Cantidad = 1;

        //    _db.Carritos.Add(input);
        //    _db.SaveChanges();

        //    return Json(new { Result = true });

        //}

    }
}
