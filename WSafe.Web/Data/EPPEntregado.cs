using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class EPPEntregado
    {
        public int ID { get; set; }
        public string Documento { get; set; }
        public List<EPPDebeUsar> DebeUsar { get; set; }

    }
}
