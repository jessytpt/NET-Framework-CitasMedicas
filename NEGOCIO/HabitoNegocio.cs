using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using NEGOCIO;
using System.Data;

namespace NEGOCIO
{
    public class HabitoNegocio
    {
        public DataSet DevolverListaHabitos()
        {
            return CargarDatos.CargarListaDatos(HabitoDAL.DevuelveSQLListaHabitos()); 
        }
    }
}
