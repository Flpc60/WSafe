using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Trazabilidad
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int ID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int TrabajadorID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Fecha inicial")]
        public DateTime FechaInicial { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Fecha final")]
        public DateTime FechaFinal { get; set; }
        public decimal Presupuesto { get; set; }


    }
}
