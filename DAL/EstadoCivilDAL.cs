using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajeria_Clases;

namespace DAL
{
   public static class EstadoCivilDAL
    {
        public static string DevuelveSQLListaEstadoCivil()
        {
            return "SELECT * FROM ESTADO_CIVIL";
        }
    }
}
