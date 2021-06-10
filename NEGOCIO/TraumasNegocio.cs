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
    public class TraumasNegocio
    {
        public DataSet DevolverListaTraumas()
        {
            return CargarDatos.CargarListaDatos(TraumasDAL.DevuelveSQLListaTraumas());
        }
    }
}
