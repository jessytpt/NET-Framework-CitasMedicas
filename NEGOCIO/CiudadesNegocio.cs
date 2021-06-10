using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace NEGOCIO
{
    public class CiudadesNegocio
    {
        public DataSet DevolverListaCiudades()
        {
            return CargarDatos.CargarListaDatos(CiudadesDAL.DevuelveSQLCiudades());

        }
        public DataSet DevolverListaCiudadesPorNombre(string nombre)
        {
            return CargarDatos.CargarListaDatos(CiudadesDAL.DevuelveSQLCiudadesPorNombre(nombre));

        }
    }
}
