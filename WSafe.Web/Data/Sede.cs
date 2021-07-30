using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Sede
    {
        public int ID { get; set; }
        [MaxLength(50,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        [Required]
        public string Nombre { get; set; }
        public ICollection<Trabajador> Trabajadores { get; set; }

    }
}
