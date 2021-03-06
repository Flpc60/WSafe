using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WSafe.Web.Data;

namespace WSafe.Web.Models
{
    public class ProcesoViewModel : Proceso
    {
        public int ActividadID { get; set; }
        public IEnumerable<SelectListItem> Actividades { get; set; }
    }
}