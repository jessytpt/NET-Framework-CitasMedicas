using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Mensajeria_Clases;

namespace NEGOCIO
{
    public class UsuariosNegocio
    {
        #region MÉTODOS DATA SET
        
        public DataSet DevolverListaUsuarios()
        {
            return CargarDatos.CargarListaDatos(UsuariosDAL.DevuelveSQLUsuarios());
        }
        public DataSet DevolverListaUsuarioPorNombre(string nombre)
        {
            return CargarDatos.CargarListaDatos(UsuariosDAL.DevuelveSQLUsuariosPorNombre(nombre));

        }
        public DataSet DevolverListaUsuariosPorTipo(string tipo)
        {
            return CargarDatos.CargarListaDatos(UsuariosDAL.DevuelveSQLUsuariosPorTipo(tipo));
        }

        #endregion

        public static Empleado ActualizarUsuario(Empleado usuario)
        {
            Empleado ms = new Empleado();
            ms = EmpleadosDAL.ActualizarUSuario(usuario);
            return ms;
        }
    }
}
