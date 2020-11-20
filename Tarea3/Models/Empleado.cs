using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3.Models
{
    public class Empleado
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El nombre debe tener de 5 a 50 caracteres.")]
        public string Nombre { get; set; }

        [Required (ErrorMessage ="El campo Sueldo es obligatorio.")]
        public decimal Sueldo { get; set; }

        [Required (ErrorMessage = "Debe espeficicar la fecha de ingreso.")]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }
    }
}
