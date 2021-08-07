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
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Finalidad { get; set; }
        [Display(Name = "Descripción Url")]
        public string DescripcionUrl { get; set; }
        public string DescripcionPath => string.IsNullOrEmpty(DescripcionUrl)
            ? null
            : $"https://wsafe.azurewebsites.net{DescripcionUrl.Substring(1)}";

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Categoria { get; set; }
        public int Efectividad { get; set; }
        public ICollection<Trazabilidad> Performance { get; set; }
    }
}
