using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using ServiTech.Data;
using ServiTech.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        //En el metodo index a la clase ProductoIndexViewMode le estoy pasando el parametro input
        //IEnumerable, setencia una  es la interfaz base para todas las colecciones no genéricas
        //que se pueden enumerar. Estoy pasando el Ienumerable de la clase Producto, tambien
        //se declara que productos es igual a la tabla productos que esta en la base de datos,
        //Si el parametro input que es igual a Tipo Producto es igual a nulom entonces, 
        //traeme el parametro o variable producto, que es igual a la tabla producto.

        //Sino, traeme la variable o parametro productos  que va a ser igual, a la tabla tabla 
        //producto, donde el lambda a, es igual a a.tipo(enum) y eso a su vez sera igual
        //a TipoProducto.

        //En el otro if, le estoy diciendo que me traiga el Nombre de la persona que especifique
        //en la tabla.
        public IActionResult Index(ProductoIndexViewModel input)
        {
            IEnumerable<Producto> productos = _db.Productos;

            if (input.TipoProducto == null)
            {
                productos = _db.Productos;
            }
            else
            {
                productos = _db.Productos.Where(a => a.Tipo == input.TipoProducto.Value);
            }

            if(!string.IsNullOrEmpty(input.Nombres))
            {
                productos = _db.Productos.Where(a => a.Nombre.ToUpper().Contains(input.Nombres.ToUpper()));
            }

           
            return View(productos);
        }

      
        public IActionResult Agregar()
        {
            return View();
              
        }

        //Con autirizacion, podemos especificar que el unico usuario que puede ver eso, es el que
        //tenga el rol de administrador.

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

        public IActionResult Modificar(int id)
        {
            var output = _db.Productos.Find(id);
            return View(output);
        }



        // Via POST los datos circulan en el cuerpo de la petición y no son visibles en la URL.
        //El metodo de modiciar, funciona como el "enum = 3" de la entityState. Basicamente a la 
        //clase Producto le estoy pasando el parametro input, y le estoy diciendo que los datos
        //de la clase producto que voy a editar en la vista modificar, que los guarde y los 
        //muestre en el index.

        [HttpPost]

        public IActionResult Modificar(Producto input)
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
            var output = _db.Productos.Find(id);
            return View(output);
        }

        //Este metodo sirve para poder colocar los foreach, ya que estoy diciendo:
        //la variable producto es igual a mi pase tabla productos en la base de datos.
        //Con este metodo tengo que usar un Ienumerable y llamar a la clase Producto.
        //Los IEnumerable pueden ser recorridos o enumerados con la sentencia foreach.

        public IActionResult NuestrosProductos()
        {
            var productos = _db.Productos;
            return View(productos);
        }


        //Este metodo me ayuda a llamar practicamente al foreach que yo he creado ya. 
        //El Find me ayuda a buscar los registros con el id, en la tabla producto.
        public IActionResult DetalleUsuario(int id)
        {
            var output = _db.Productos.Find(id);
            return View(output);
        }







    }


}
