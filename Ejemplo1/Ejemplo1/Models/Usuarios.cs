using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ejemplo1.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public virtual IEnumerable<Domicilios> Domicilios { get; set; }
    }
}