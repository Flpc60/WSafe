using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class InspeccionEPP
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Sede { get; set; }
        public string Centro { get; set; }
        public string Lugar { get; set; }
        public string Responsable { get; set; }
        public List<EPPEntregado> Entregado { get; set; }
        public List<EPPFaltante> Faltante { get; set; }
        public string Observaciones { get; set; }

    }
}
