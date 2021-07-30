using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WSafe.Web.Data;

namespace WSafe.Web.Models
{
    public class SedeView : Sede
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Lessee")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a lessee.")]
        public int TrabajadorID { get; set; }
        public IEnumerable<SelectListItem> Trabajadores { get; set; }

    }
}
