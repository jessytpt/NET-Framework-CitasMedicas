using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria_Clases
{
    public class CitaMedica
    {
        public string CedMedico_P { get; set; }
        public string CedPac_P { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public CitaMedica()
        {
                
        }
        public CitaMedica(string _cedMed,string _fecha,string _hora,string _cedPac)
        {
            this.CedPac_P = _cedPac;
            this.Fecha = _fecha;
            this.Hora = _hora;
            this.CedMedico_P = _cedMed;
        }

    }
}
