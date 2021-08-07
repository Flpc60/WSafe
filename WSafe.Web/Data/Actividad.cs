using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WSafe.Web.Data
{
    public class Actividad
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatotio")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0}, es {1}")]
        public string Descripcion { get; set; }
        public int ProcesoID { get; set; }
        public ICollection<Amenaza> Amenazas { get; set; }
        public ICollection<Consecuencia> Consecuencias { get; set; }
        public ICollection<Incidente> Incidentes { get; set; }
        public ICollection<Riesgo> Riesgos { get; set; }
        public ICollection<Acontecimiento> Acontecimientos { get; set; }


    }
}