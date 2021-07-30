using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class SystemVerificacion
    {
        public int ID { get; set; }
        public bool Mantenimiento { get; set; }
        public string Documento { get; set; }
        public string Observaciones { get; set; }

    }
}
