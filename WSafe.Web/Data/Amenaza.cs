using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Amenaza
    {
        public int ID { get; set; }
        public int ActividadID { get; set; }
        public string Nombre { get; set; }
        public ICollection<Control> Controles { get; set; }
    }
}