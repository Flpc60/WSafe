using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSafe.Web.Data;

namespace WSafe.Web.Models
{
    public class TrabajadorView : Trabajador
    {
        public int SedeID { get; set; }
        public int CentroID { get; set; }
        public int CargoID { get; set; }
    }
}
