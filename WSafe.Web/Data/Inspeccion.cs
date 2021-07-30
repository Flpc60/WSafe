using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSafe.Web.Data
{
    public class Inspeccion
    {
        public int ID { get; set; }
        public int SedeID { get; set; }
        public List<InspeccionLocativa> Locativas { get; set; }
        public List<InspeccionHerramienta> Herramientas { get; set; }
        public List<InspeccionBPA> BPA { get; set; }
        public List<InspeccionEPP> EPP { get; set; }
        public List<InspeccionExtintor> Extintores { get; set; }
        public List<VerificacionEmergencia> Emergencias { get; set; }

    }
}
