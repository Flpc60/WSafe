using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WSafe.Web.Data;

namespace WSafe.Web.Models
{
    public class OrganizacionViewModel : Organizacion
    {
        public int SedeID { get; set; }
        public IEnumerable<SelectListItem> Sedes { get; set; }
        public int ProcesoID { get; set; }
        public IEnumerable<SelectListItem> Procesos { get; set; }
    }
}