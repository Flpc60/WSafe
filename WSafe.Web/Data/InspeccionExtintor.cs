using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class InspeccionExtintor
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Sede { get; set; }
        public string Centro { get; set; }
        public string Lugar { get; set; }
        public string responsable { get; set; }
        public Extintor  Concept1 { get; set; }
        public Extintor  Concept2 { get; set; }
        public Extintor  Concept3 { get; set; }
        public Extintor  Concept4{ get; set; }
        public Extintor  Concept5 { get; set; }
        public Extintor  Concept6 { get; set; }
        public Extintor  Concept7 { get; set; }
        public Extintor  Concept8 { get; set; }
        public Extintor  Concept9 { get; set; }
        public Extintor  Concept10 { get; set; }
        public Extintor  Concept11 { get; set; }
        public Extintor  Concept12 { get; set; }
        public Extintor  Concept13 { get; set; }
        public Extintor  Concept14 { get; set; }
        public Extintor Concept15 { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public string Class3 { get; set; }
        public string Class4 { get; set; }
        public string Class5 { get; set; }
        public DateTime FechaVence1 { get; set; }
        public DateTime FechaVence2 { get; set; }
        public DateTime FechaVence3 { get; set; }
        public DateTime FechaVence4 { get; set; }
        public DateTime FechaVence5 { get; set; }

    }
}
