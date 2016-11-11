using Ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1.DAL
{
    public class MyDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            context.Usuarios.Add(new Usuarios() { Usuario = "anemc", Contrasena = "12345"});
            base.Seed(context);
        }
    }
}