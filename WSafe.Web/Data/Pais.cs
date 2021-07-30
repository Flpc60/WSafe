using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Pais
    {
        public int ID { get; set; }
        [MaxLength(50,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Nombre { get; set; }
        public List<Departamento> Departamentos { get; set; }

    }
}
