using Ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1.Controllers
{
    public class DomiciliosController : Controller
    {
        // GET: Domicilios
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Nueva()
        {
            var users = Utils.Ejemplo1Context.Usuarios.Select(c => new SelectListItem()
            {
                Value = c.UsuarioId.ToString(),
                Text = c.Usuario
            }).ToList();

            ViewBag.Usuarios = new SelectList(users, "Value", "Text");

            return View();
        }

        public ActionResult Guardar(Domicilios Domicilios)
        {
            var db = Utils.Ejemplo1Context;
            db.Domicilios.Add(Domicilios);
            db.SaveChanges();
            return Content("Guardado");
        }
    }
}