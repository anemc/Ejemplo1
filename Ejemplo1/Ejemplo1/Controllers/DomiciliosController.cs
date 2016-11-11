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
            var usuarios = Utils.Ejemplo1Context.Usuarios.Select(c => new SelectListItem()
            {
                Value = c.UsuarioId.ToString(),
                Text = c.Usuario
            }).ToList();

            ViewBag.Categorias = new SelectList(usuarios, "Value", "Text");

            return View();
        }

        public ActionResult Guardar()
        {
            return Content("Guardado");
        }
    }
}