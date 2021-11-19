using System;

namespace WSafe.Common.Data.Entities
{
    public class SeguimientoRiesgo
    {
        public int ID { get; set; }
        public int RiesgoID { get; set; }
        public DateTime Fecha { get; set; }
        public string EstadoIntervencion { get; set; }
        public string Observaciobnes { get; set; }
        public int TrabajadorID { get; set; }
    }
}