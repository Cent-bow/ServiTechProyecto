using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdministradorController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult IndexAdmi()
        {
            
            return View();
        }


        //[Authorize(Roles = "Admin")]
        public IActionResult CrearRole()
        {
            return View();
        }


        //Un código síncrono es aquel código donde cada instrucción espera a la anterior 
        //para ejecutarse mientras que un código asíncrono no
        // espera a las instrucciones diferidas y continúa con su ejecución.

        //Estoy haciendo una tarea asincrona y quiero que esta tarea o metodo me regrese
        //una accion que en este caso es <IActionResult> del metodo CrearRole, pero
        //en realidad quiero que complete
        //una tarea y luego pase a la otra, en lugar de  NO ESPERAR E IR AL FINAL. Con el await
        //le estoy diciendo que hasta que no cree el rol
        //de la clase RoleManager que contiene el <IdentityRole>
        //entonces no me retornes la vista. Es decir hasta que no termines la tarea No.1,
        //no me hagas la tarea No.2 Si el programa no tuviese el await, se fuera volado
        //hasta al final, y no esperaria a cumplir la tarea que tarda mas tiempo,
        //es decir me retornaria la vista y ya porque la vista es la accion a cumplir mas rapida.

        [HttpPost]
        public async Task<IActionResult> CrearRole(string Nombre)
        {
            //No. 1
            await _roleManager.CreateAsync(new IdentityRole(Nombre));

            //No.2
            return View();
        }

        //El metodo POST me devuelve todo al cuerpo de la peticion. Osea me va a retornar
        //todo lo que le pedi en el body, en vez de la URL que es ya con el metodo GET


    }
}
