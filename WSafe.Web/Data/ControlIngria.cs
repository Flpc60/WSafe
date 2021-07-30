using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class ControlIngria
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public DateTime FechaInicial { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public DateTime FechaFinal { get; set; }
        public bool Efectividad { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Presupuesto { get; set; }
        public string Observaciones { get; set; }
        public string Responsable { get; set; }

    }
}
