using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WSafe.Web.Data
{
    public class Acontecimiento
    {
        public int ID { get; set; }
        public Sede Sede { get; set; }
        public Centro Centro { get; set; }
        public Lugar Lugar { get; set; }
        public Cargo Cargo { get; set; }
        public Proceso Proceso { get; set; }
        public Actividad Actividad { get; set; }
        public Tarea Tarea { get; set; }
        public bool Rutinaria { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatotio")]
        public string Descripcion { get; set; }
        public string ClasePeligro { get; set; }
        public string TipoPelogro { get; set; }
        public string EfectosPosibles { get; set; }
        public string TiempoExposicion { get; set; }
        public string ActoInseguro { get; set; }
        public string CondicionInsegura { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public ICollection<ImagenActo> Imagenes { get; set; }
        public string FactoresPersonales { get; set; }
        public string FactoresTrabajo { get; set; }
        public string Recomendaciones { get; set; }
        public string DocumentoIdentificaEvento { get; set; }
        public string DocumentoReporteEvento { get; set; }
    }

}
