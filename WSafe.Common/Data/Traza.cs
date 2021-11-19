using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Traza
    {
        public int ID { get; set; }
        public int ControlID { get; set; }
        public int OperacionID { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int CantidadAlto { get; set; }
        public int CantidadMedio { get; set; }
        public int CantidadBajo { get; set; }
        public int Efectividad { get; set; }
        public decimal Presupuesto { get; set; }

    }
}