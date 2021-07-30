using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Actividad
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatotio")]
        [MaxLength(50,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Descripcion { get; set; }
        public int  ProcesoID { get; set; }
        public List<Tarea> Tareas { get; set; }

    }
}
