using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using System.Data;

namespace NEGOCIO
{
    public class CargoNegocio
    {
        public DataSet DevolverListaCargos()
        {
            return CargarDatos.CargarListaDatos(CargoDAL.DevuelveSQLCargos());
        }
    }
}
