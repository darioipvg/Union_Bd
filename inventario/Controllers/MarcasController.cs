using inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inventario.Controllers
{
    public class MarcasController : Controller
    {
        //Se instancia la clase como conexión a la bd
        private inventariodbEntities db = new inventariodbEntities();

        // GET: Marcas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //Se le pasa la clase completamente
        public ActionResult Create(Marca marca)
        {

            //Validaciones
            if (ModelState.IsValid)
            {
                //Guardamos en base de datos
                db.Marca.Add(marca); //esto es lo mismo que un insert en sql
                db.SaveChanges();
            }

            //Se reenvian los datos para que recaegue con los datos
            return View(marca);
        }
    }
}