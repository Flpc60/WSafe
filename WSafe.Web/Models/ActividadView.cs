using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WSafe.Web.Data;

namespace WSafe.Web.Models
{
    public class ActividadView : Actividad
    {
        public int TareaID { get; set; }
        public IEnumerable<SelectListItem> Tareas { get; set; }

    }
}
