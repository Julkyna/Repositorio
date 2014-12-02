using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabajadores.Models;


namespace Trabajadores.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Tabla tra)
        {

            Call lugares = new Call(
@"C:\Users\1040094\Documents\Visual Studio 2013\Projects\Trabajadores\Trabajadores\Models\Trabajadores.csv");


            var usuario = lugares.GetEmployeeById(tra.NumTrabajador);



            return View("Datos", usuario);
        }

    }
}
