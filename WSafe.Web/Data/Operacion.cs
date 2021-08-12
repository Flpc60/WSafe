using System;
using System.ComponentModel.DataAnnotations;

namespace WSafe.Web.Data
{
    public class Operacion
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int ID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int TrabajadorID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int TrazaID { get; set; }
        [Display(Name = "Fecha inicial")]
        public DateTime FechaInicial { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Fecha final")]
        public DateTime FechaFinal { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int ControlID { get; set; }
        public decimal Presupuesto { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int CategoriaEfectividad { get; set; }
        public string Observaciones { get; set; }
    }
}