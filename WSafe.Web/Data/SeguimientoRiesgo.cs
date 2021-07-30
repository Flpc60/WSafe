using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class SeguimientoRiesgo
    {
        public int ID { get; set; }
        public DateTime Fecha{ get; set; }
        public string EstadoIntervencion { get; set; }
        public string Observaciobnes { get; set; }
        public string Responsable { get; set; }

    }
}
