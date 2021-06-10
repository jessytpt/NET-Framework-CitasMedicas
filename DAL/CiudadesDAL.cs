using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class CiudadesDAL
    {

        public static string DevuelveSQLCiudades()
        {
            return "SELECT * FROM CIUDAD ";
        }
        public static string DevuelveSQLCiudadesPorNombre(string parametro)
        {
            return "SELECT NOM_CIU FROM CIUDAD WHERE NOM_CIU LIKE '" + parametro + "%'";
        }
    }
}
