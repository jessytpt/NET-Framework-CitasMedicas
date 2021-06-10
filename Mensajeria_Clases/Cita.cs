using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria_Clases
{
    public class Cita
    {
        public int NumCita { get; set; }
        public string CedulaPaciente { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string CedulaEmpleado { get; set; }

        public Cita()
        {

        }
        public Cita(int numCita, string cedulaPaciente, string fecha,string hora,string cedEmpleado)
        {
            this.NumCita = numCita;
            this.CedulaPaciente = cedulaPaciente;
            this.Fecha = fecha;
            this.Hora = hora;
            this.CedulaEmpleado = cedEmpleado;

        }

    }
}
