using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            var db = Utils.Ejemplo1Context;

            db.Domicilios.Add(new Models.Domicilios() {DomicilioId=0, Domicilio="2 de Abril", Cp=91910, Numero=41, UsuarioId=1 });
            db.SaveChanges();

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}