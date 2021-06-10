using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace NEGOCIO
{
    public class EstadoCivilNegocio
    {
        public  DataSet DevolverListaEstadoCivil() 
        {
            return CargarDatos.CargarListaDatos(EstadoCivilDAL.DevuelveSQLListaEstadoCivil());
        }
    }
}
