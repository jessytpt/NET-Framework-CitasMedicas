using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class UsuariosDAL
    {
        #region MyRegion
        public static string DevuelveSQLUsuarios()
        {
            return "SELECT CED_EMP AS CEDULA, NOM1_EMP,NOM2_EMP,APE1_EMP,APE2_EMP, EMPLEADO.NOM_USU,CLAVE_USU,TIPO_USUARIO.NOM_USU AS TIPO_USUARIO "+
             "FROM EMPLEADO, TIPO_USUARIO WHERE TIPO_USU_P = TIPO_USUARIO.COD_USU  ";
        }
        public static string DevuelveSQLUsuariosPorNombre(string parametro)
        {
            return "SELECT CED_EMP AS CEDULA, NOM1_EMP,NOM2_EMP,APE1_EMP,APE2_EMP, EMPLEADO.NOM_USU,CLAVE_USU,TIPO_USUARIO.NOM_USU AS TIPO_USUARIO " +
              "FROM EMPLEADO, TIPO_USUARIO WHERE TIPO_USU_P = TIPO_USUARIO.COD_USU"+
              " AND  EMPLEADO.NOM_USU LIKE '" + parametro+"%'";
        }
        public static string DevuelveSQLUsuariosPorTipo(string parametro)
        {
            return "SELECT CED_EMP AS CEDULA, NOM1_EMP,NOM2_EMP,APE1_EMP,APE2_EMP, EMPLEADO.NOM_USU,CLAVE_USU,TIPO_USUARIO.NOM_USU AS TIPO_USUARIO " +
             "FROM EMPLEADO, TIPO_USUARIO WHERE TIPO_USU_P = TIPO_USUARIO.COD_USU" +
             " AND  TIPO_USUARIO.NOM_USU LIKE '" + parametro + "%'";


        }
        #endregion
    }
}
