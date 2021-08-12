using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Control
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int ID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int ActividadID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int AmenazaID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int MitigadorID { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Finalidad { get; set; }
        [Display(Name = "Descripción Url")]
        public string DescripcionUrl { get; set; }
        public string DescripcionPath => string.IsNullOrEmpty(DescripcionUrl)
            ? null
            : $"https://wsafe.azurewebsites.net{DescripcionUrl.Substring(1)}";

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Categoria { get; set; }
        public decimal Presupuesto { get; set; }
        public ICollection<Operacion> Operaciones { get; set; }
        public ICollection<Traza> Trazabilidad { get; set; }

    }
}