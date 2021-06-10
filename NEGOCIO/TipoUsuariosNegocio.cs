using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NEGOCIO
{
   public class TipoUsuariosNegocio
    {
        public DataSet DevolverListaTiposUsuarios()
        {
            return CargarDatos.CargarListaDatos(TipoUsuarioDAL.DevuelveSQLTiposUsuarios());
        }
    }
}
