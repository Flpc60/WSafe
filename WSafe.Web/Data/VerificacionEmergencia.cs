using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class VerificacionEmergencia
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Sede { get; set; }
        public string Centro { get; set; }
        public string Lugar { get; set; }
        public string Responsable { get; set; }
        public SystemVerificacion System1 { get; set; }
        public SystemVerificacion System2 { get; set; }
        public SystemVerificacion System3 { get; set; }
        public SystemVerificacion System4 { get; set; }
        public SystemVerificacion System5 { get; set; }
        public SystemVerificacion System6 { get; set; }
        public SystemVerificacion System7 { get; set; }
        public SystemVerificacion System8 { get; set; }
        public SystemVerificacion System9 { get; set; }
        public SystemVerificacion System10 { get; set; }

    }
}
