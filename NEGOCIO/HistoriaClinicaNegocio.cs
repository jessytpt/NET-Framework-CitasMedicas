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
    public class HistoriaClinicaNegocio
    {
        #region DEVOLVER TODA LA INFO DE EMPLEADOS
        public DataSet DevolverListaHistoriasClinicas()
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.DevuelveSqlHistoriaClinica());
        }
        public DataSet DevolverListaHistoriasClinicasPorNumero(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.DevuelveSQLHistoriaClinicaPorNumero(parametro));
        }
        public DataSet DevolverListaHistoriasClinicasPorCedula(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.DevuelveSQLHistoriaClinicaPorCedula(parametro));
        }
        public DataSet DevolverListaHistoriasClinicasPorApellido(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.DevuelveSQLHistoriaClinicaPorApellido(parametro));
        }
        public DataSet DevolverListaHistoriasClinicasPorNombre(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.DevuelveSQLHistoriaClinicaPorNombre(parametro));
        }

        #endregion

        #region DEVOLVER SÓLO UNOS CAMPOZ
        public DataSet BuscarListaHistoriasClinicas()
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.SqlBuscarHistoriaClinica());
        }
        public DataSet BuscarListaHistoriasClinicasPorNumero(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.SQLBuscarHistoriaClinicaPorNumero(parametro));
        }
        public DataSet BuscarListaHistoriasClinicasPorNombre(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.SQLBuscarHistoriaClinicaPorNombre(parametro));
        }
        public DataSet BuscarListaHistoriasClinicasPorCedula(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.SQLBuscarHistoriaClinicaPorCedula(parametro));
        }
        public DataSet BuscarListaHistoriasClinicasPorApellido(string parametro)
        {
            return CargarDatos.CargarListaDatos(HistoriaClinicaDAL.SQLBuscarHistoriaClinicaPorApellido(parametro));
        }

        #endregion

        #region GUARDAR, ACTUALIZAR, ELIMINAR
        public static HistoriaClinica GuardarHistoria(HistoriaClinica nuevaHistoria)
        {
            HistoriaClinica ms = new HistoriaClinica();
            ms = HistoriaClinicaDAL.Guardar(nuevaHistoria);
            return ms;

        }
        public static HistoriaClinica ActualizarPersona(HistoriaClinica persona)
        {
            HistoriaClinica ms = new HistoriaClinica();
            ms = HistoriaClinicaDAL.Actualizar(persona);
            return ms;
        }
        public static HistoriaClinica EliminarPersona(HistoriaClinica persona)
        {
            HistoriaClinica ms = new HistoriaClinica();
            ms = HistoriaClinicaDAL.Eliminar(persona);
            return ms;
        }
        #endregion



    }
}
