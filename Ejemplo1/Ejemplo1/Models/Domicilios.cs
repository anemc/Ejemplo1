using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ejemplo1.Models
{
    [Table("Domicilios")]
    public class Domicilios
    {
        [Key]
        public int DomicilioId { get; set; }
        public string Domicilio { get; set; }
        public int Numero { get; set; }
        public int Cp { get; set; }

        [Display(Name ="Usuario")]
        public int UsuarioId { get; set; }

        public virtual IEnumerable<Usuarios> Usuarios { get; set; }
    }
}