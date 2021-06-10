using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Mensajeria_Clases;
using System.Data;

namespace NEGOCIO
{
    public class CitaNegocio
    {
        public static Cita GuardarCita(Cita nuevaCita)
        {
            Cita ms = new Cita();
            ms = CitasDAL.Guardar(nuevaCita);
            return ms;
        }

        public DataSet DevolverListaCitasPorFecha(string cita)
        {
        
            return CargarDatos.CargarListaDatos(CitasDAL.DevuelveSQLCitasPorFecha(cita));

        
    }
    }
}
