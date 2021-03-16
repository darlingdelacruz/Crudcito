using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiCrudCito.Models
{
    public class Empleados
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio"), StringLength(50, ErrorMessage = "Mio es hasta 50 caracteres", MinimumLength = 1)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio"), StringLength(50, ErrorMessage = "Mio es hasta 50 caracteres", MinimumLength = 1)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio"), StringLength(50, ErrorMessage = "Mio es hasta 50 caracteres", MinimumLength = 1)]
        public string Cargo { get; set; }

        public int Salario { get; set; }

    }
    public class EmpleadoDBContext : DbContext
    {
        
        public DbSet<Empleados> Empleados { get; set; }
    }
}
