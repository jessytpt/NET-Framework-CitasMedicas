using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class TipoUsuarioDAL
    {
        public static string DevuelveSQLTiposUsuarios()
        {
            return "SELECT * FROM TIPO_USUARIO ";
        }

        public static string DevuelveSQLCargos()
        {
            throw new NotImplementedException();
        }
    }
}
