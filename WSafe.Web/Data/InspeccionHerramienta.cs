using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class InspeccionHerramienta
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public int SedeID { get; set; }
        public int CentroID { get; set; }
        public int LugarID { get; set; }
        public string Responsable { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item1 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item2 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item3 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item4 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item5 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item6 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item7 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item8 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item9 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item10 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item11 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item12 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item13 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item14 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item15 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item16 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item17 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item18 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item90 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item20 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item21 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item22 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item23 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item24 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item25 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item26 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item27 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item28 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item29 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item30 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item31 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item32 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item33 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item34 { get; set; }
        [MaxLength(10,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Item35 { get; set; }
        [MaxLength(50,ErrorMessage ="La longitud máxima del campo {0}, es {1}")]
        public string Observaciones { get; set; }

    }
}
