using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace NEGOCIO
{
    public class EtniasNegocio
    {
        public DataSet DevolverListaEtnias()
        {
            return CargarDatos.CargarListaDatos(EtniaDAL.DevuelveSQLListaEtnias());
        }
      
    }
}
