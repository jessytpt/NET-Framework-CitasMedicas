using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Mensajeria_Clases;
using System.Data;

namespace NEGOCIO
{
    public  class EmpleadosNegocio
    {
        #region Listas por criterio 
        //Las listas muestran todos los datos del empleado

        public DataSet DevolverListaEmpleados()
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.DevuelveSQLEmpleados());

        }
        public DataSet DevolverListEmpleadorPorCedula(string id)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.DevuelveSQLEmpleadoPorCedula(id));

        }
        public DataSet DevolverListaEmpleadosPorApellido(string apellido)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.DevuelveSQLEmpleadoPorApellido(apellido));

        }
        public DataSet DevolverListaEmpleadosPorNombre(string nombre)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.DevuelveSQLEmpleadoPorNombre(nombre));

        }
        public DataSet DevolverListaEmpleadosPorTipoUsuario(string tipo)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.DevuelveSQLEmpleadoPorTipoUsuario(tipo));

        }
        public DataSet DevolverListaEmpleadosPorCargo(string cargo)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.DevuelveSQLEmpleadoPorCargo(cargo));
        }

        #endregion
        
        public static List<Usuario> DevolverUsuarioInicioSesion(string usuario, string clave)
        {

            return CargarDatos.DevolverUsuario(EmpleadosDAL.DevuelveSQLUsuario(usuario, clave));
            
        }

        public static Empleado GuardarEmpleado(Empleado nuevoEmpleado)
        {
            Empleado ms = new Empleado();
            ms = EmpleadosDAL.Guardar(nuevoEmpleado);
            return ms;
        }

        //public DataSet DevolverLsitaUsuarios()
        //{
            
        //}

        #region Buscar por Criterios
        //restringe la visualización de ciertos campos, sólo se muestran los más importantes

        public DataSet BuscarListaEmpleados()
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.DevuelveBusquedaSQLEmpleados());
        }
        public DataSet BuscarListaEmpleadoPorCedula(string parametro)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.SQLBuscarEmpleadoPorCedula(parametro));
        }
        public DataSet BuscarListaEmpleadosPorApellido(string parametro)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.SQLBuscarEmpleadoPorApellido(parametro));
        }
        public DataSet BuscarListaEmpleadosPorNombre(string parametro)
        {
            return CargarDatos.CargarListaDatos(EmpleadosDAL.SQLBuscarEmpleadoPorNombre(parametro));
        }

        public static Empleado ActualizarPersona(Empleado persona)
        {
            Empleado ms = new Empleado();
            ms = EmpleadosDAL.Actualizar(persona);
            return ms;
        }

        public static Empleado EliminarPersona(Empleado persona)
        {
            Empleado ms = new Empleado();
            ms = EmpleadosDAL.Eliminar(persona);
            return ms;
        }

        #endregion


    }
}
