using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajeria_Clases;
using System.Data.SqlClient;
using System.Transactions;

namespace DAL
{
    public static class EmpleadosDAL
    {
        #region SQL SELECT DE EMPLEADOS POR CRITERIO
        public static string DevuelveSQLEmpleados()
        {
            return "SELECT  CED_EMP AS CEDULA,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,FECH_NAC_EMP,CIUDAD.NOM_CIU,"
                + "DIR_EMP,TEL_EMP,ETNIA.NOM_ETN,ESTADO_CIVIL.NOM_EST,TIPO_USUARIO.NOM_USU,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
                "TIPO_USUARIO,CIUDAD,GENERO,ETNIA,ESTADO_CIVIL,CARGO_EMPLEADO " +
                "WHERE GEN_EMP_P =GENERO.COD_GEN AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                "COD_ETN_P=ETNIA.COD_ETN AND COD_EST_CIV_P=ESTADO_CIVIL.COD_EST AND " +
                "TIPO_USU_P = TIPO_USUARIO.COD_USU AND COD_CAR_P=CARGO_EMPLEADO.COD_CAR";
        }
        public static string DevuelveSQLEmpleadoPorCedula(string parametro)
        {

            return "SELECT  CED_EMP AS CEDULA,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,FECH_NAC_EMP,CIUDAD.NOM_CIU,"
                + "DIR_EMP,TEL_EMP,ETNIA.NOM_ETN,ESTADO_CIVIL.NOM_EST,TIPO_USUARIO.NOM_USU,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
                "TIPO_USUARIO,CIUDAD,GENERO,ETNIA,ESTADO_CIVIL,CARGO_EMPLEADO " +
                "WHERE GEN_EMP_P =GENERO.COD_GEN AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                "COD_ETN_P=ETNIA.COD_ETN AND COD_EST_CIV_P=ESTADO_CIVIL.COD_EST AND " +
                "TIPO_USU_P = TIPO_USUARIO.COD_USU AND COD_CAR_P=CARGO_EMPLEADO.COD_CAR AND " +
                "CED_EMP LIKE'" + parametro + "%'";
        }
        public static string DevuelveSQLEmpleadoPorApellido(string parametro)
        {
            return "SELECT  CED_EMP AS CEDULA,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,FECH_NAC_EMP,CIUDAD.NOM_CIU,"
                + "DIR_EMP,TEL_EMP,ETNIA.NOM_ETN,ESTADO_CIVIL.NOM_EST,TIPO_USUARIO.NOM_USU,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
                "TIPO_USUARIO,CIUDAD,GENERO,ETNIA,ESTADO_CIVIL,CARGO_EMPLEADO " +
                "WHERE GEN_EMP_P =GENERO.COD_GEN AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                "COD_ETN_P=ETNIA.COD_ETN AND COD_EST_CIV_P=ESTADO_CIVIL.COD_EST AND " +
                "TIPO_USU_P = TIPO_USUARIO.COD_USU AND COD_CAR_P=CARGO_EMPLEADO.COD_CAR AND " +
                "APE1_EMP LIKE'" + parametro + "%'";
        }
        public static string DevuelveSQLEmpleadoPorNombre(string parametro)
        {
            return "SELECT  CED_EMP AS CEDULA,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,FECH_NAC_EMP,CIUDAD.NOM_CIU,"
                         + "DIR_EMP,TEL_EMP,ETNIA.NOM_ETN,ESTADO_CIVIL.NOM_EST,TIPO_USUARIO.NOM_USU,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
                         "TIPO_USUARIO,CIUDAD,GENERO,ETNIA,ESTADO_CIVIL,CARGO_EMPLEADO " +
                         "WHERE GEN_EMP_P =GENERO.COD_GEN AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                         "COD_ETN_P=ETNIA.COD_ETN AND COD_EST_CIV_P=ESTADO_CIVIL.COD_EST AND " +
                         "TIPO_USU_P = TIPO_USUARIO.COD_USU AND COD_CAR_P=CARGO_EMPLEADO.COD_CAR AND " +
                         "NOM1_EMP LIKE'" + parametro + "%'";
        }
        
        public static string DevuelveSQLEmpleadoPorTipoUsuario(string parametro)
        {
            return "SELECT  CED_EMP AS CEDULA,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,FECH_NAC_EMP,CIUDAD.NOM_CIU,"
                         + "DIR_EMP,TEL_EMP,ETNIA.NOM_ETN,ESTADO_CIVIL.NOM_EST,TIPO_USUARIO.NOM_USU,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
                         "TIPO_USUARIO,CIUDAD,GENERO,ETNIA,ESTADO_CIVIL,CARGO_EMPLEADO " +
                         "WHERE GEN_EMP_P =GENERO.COD_GEN AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                         "COD_ETN_P=ETNIA.COD_ETN AND COD_EST_CIV_P=ESTADO_CIVIL.COD_EST AND " +
                         "TIPO_USU_P = TIPO_USUARIO.COD_USU AND COD_CAR_P=CARGO_EMPLEADO.COD_CAR AND " +
                         "TIPO_USUARIO.NOM_USU LIKE'" + parametro + "%'";
        }
        public static string DevuelveSQLEmpleadoPorCargo(string parametro)
        {
            return "SELECT  CED_EMP AS CEDULA,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,FECH_NAC_EMP,CIUDAD.NOM_CIU,"
                         + "DIR_EMP,TEL_EMP,ETNIA.NOM_ETN,ESTADO_CIVIL.NOM_EST,TIPO_USUARIO.NOM_USU,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
                         "TIPO_USUARIO,CIUDAD,GENERO,ETNIA,ESTADO_CIVIL,CARGO_EMPLEADO " +
                         "WHERE GEN_EMP_P =GENERO.COD_GEN AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                         "COD_ETN_P=ETNIA.COD_ETN AND COD_EST_CIV_P=ESTADO_CIVIL.COD_EST AND " +
                         "TIPO_USU_P = TIPO_USUARIO.COD_USU AND COD_CAR_P=CARGO_EMPLEADO.COD_CAR AND " +
                         "CARGO_EMPLEADO.NOM_CAR LIKE'" + parametro + "%'";
        }
        public static string DevuelveSQLEmpleadoInicioSesion(string usuario, string clave)
        {
            return "SELECT  EMPLEADO.CED_EMP,EMPLEADO.NOM1_EMP,"
                + "EMPLEADO.NOM2_EMP, EMPLEADO.APE1_EMP,"
                + "EMPLEADO.APE2_EMP, GENERO.NOM_GEN,"
                + "EMPLEADO.FECH_NAC_EMP, CIUDAD.NOM_CIU,"
                + "EMPLEADO.DIR_EMP, EMPLEADO.TEL_EMP,"
                + "ETNIA.NOM_ETN, ESTADO_CIVIL.NOM_EST,"
                + "EMPLEADO.NOM_USU,EMPLEADO.CLAVE_USU,"
                + "TIPO_USUARIO.NOM_USU, CARGO_EMPLEADO.NOM_CAR "
                + "FROM EMPLEADO,CIUDAD, GENERO, ESTADO_CIVIL, ETNIA, TIPO_USUARIO, CARGO_EMPLEADO"
                + " WHERE EMPLEADO.NOM_USU = '" + usuario + "'"
                + " AND EMPLEADO.CLAVE_USU= '" + clave + "'"
                + " AND EMPLEADO.COD_CIU_P=CIUDAD.COD_CIU"
                + " AND EMPLEADO.COD_ETN_P=ETNIA.COD_ETN"
                + " AND EMPLEADO.COD_CAR_P=CARGO_EMPLEADO.COD_CAR"
                + " AND EMPLEADO.TIPO_USU_P=TIPO_USUARIO.COD_USU"
                + " AND EMPLEADO.GEN_EMP_P=GENERO.COD_GEN"
                + " AND EMPLEADO.COD_EST_CIV_P=ESTADO_CIVIL.COD_EST ;";
        }
        public static string DevuelveSQLUsuario(string usuario, string clave)
        {
            return "SELECT  EMPLEADO.CED_EMP,EMPLEADO.NOM1_EMP,"
                + "EMPLEADO.APE1_EMP,"
                + "EMPLEADO.NOM_USU,EMPLEADO.CLAVE_USU,"
                + "TIPO_USUARIO.NOM_USU, CARGO_EMPLEADO.NOM_CAR "
                + "FROM EMPLEADO, TIPO_USUARIO, CARGO_EMPLEADO"
                + " WHERE EMPLEADO.NOM_USU = '" + usuario + "'"
                + " AND EMPLEADO.CLAVE_USU= '" + clave + "'"
                + " AND EMPLEADO.COD_CAR_P=CARGO_EMPLEADO.COD_CAR"
                + " AND EMPLEADO.TIPO_USU_P=TIPO_USUARIO.COD_USU;";

        }

        #endregion

        #region SELECT INFO PARCAIL
        public static string DevuelveBusquedaSQLEmpleados()
        {
            return "SELECT  CED_EMP AS CEDULA,NOM1_EMP  ,NOM2_EMP ,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,CIUDAD.NOM_CIU," +
            " TEL_EMP,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
             " CIUDAD,GENERO,CARGO_EMPLEADO" +
              " WHERE GEN_EMP_P = GENERO.COD_GEN AND COD_CIU_P = CIUDAD.COD_CIU AND " +
               "       COD_CAR_P = CARGO_EMPLEADO.COD_CAR AND CARGO_EMPLEADO.NOM_CAR = 'MEDICO'; ";
        }
        public static string SQLBuscarEmpleadoPorCedula(string parametro)
        {
            return "SELECT  CED_EMP AS ID,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,CIUDAD.NOM_CIU," +
              " TEL_EMP,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
               " CIUDAD,GENERO,CARGO_EMPLEADO" +
                " WHERE GEN_EMP_P = GENERO.COD_GEN AND COD_CIU_P = CIUDAD.COD_CIU AND " +
                 "       COD_CAR_P = CARGO_EMPLEADO.COD_CAR AND CARGO_EMPLEADO.NOM_CAR = 'MEDICO' AND CED_EMP LIKE '" + parametro + "%'; ";
        }
        public static string SQLBuscarEmpleadoPorApellido(string parametro)
        {
            return "SELECT  CED_EMP AS ID,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,CIUDAD.NOM_CIU," +
       " TEL_EMP,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
        " CIUDAD,GENERO,CARGO_EMPLEADO" +
         " WHERE GEN_EMP_P = GENERO.COD_GEN AND COD_CIU_P = CIUDAD.COD_CIU AND " +
          "       COD_CAR_P = CARGO_EMPLEADO.COD_CAR AND CARGO_EMPLEADO.NOM_CAR = 'MEDICO' AND APE1_EMP  LIKE '" + parametro + "%'; ";
        }
        public static string SQLBuscarEmpleadoPorNombre(string parametro)
        {
            return "SELECT  CED_EMP AS ID,NOM1_EMP ,NOM2_EMP,APE1_EMP ,APE2_EMP,GENERO.NOM_GEN,CIUDAD.NOM_CIU," +
       " TEL_EMP,CARGO_EMPLEADO.NOM_CAR FROM EMPLEADO," +
        " CIUDAD,GENERO,CARGO_EMPLEADO" +
         " WHERE GEN_EMP_P = GENERO.COD_GEN AND COD_CIU_P = CIUDAD.COD_CIU AND " +
          "       COD_CAR_P = CARGO_EMPLEADO.COD_CAR AND CARGO_EMPLEADO.NOM_CAR = 'MEDICO' AND NOM1_EMP  LIKE '" + parametro + "%'; ";
        }
        #endregion

        #region INSERT,UPDATE,DELETE
        public static Empleado Guardar(Empleado nuevoEmpleado)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();

                    string queryString =
                    "INSERT INTO[dbo].[EMPLEADO]" +
          " ([CED_EMP]" +
          " ,[NOM1_EMP]" +
          " ,[NOM2_EMP]" +
          " ,[APE1_EMP]" +
          " ,[APE2_EMP]" +
          " ,[GEN_EMP_P]" +
          " ,[FECH_NAC_EMP]" +
          " ,[COD_CIU_P]" +
          " ,[DIR_EMP]" +
          " ,[TEL_EMP]" +
          " ,[COD_ETN_P]" +
          " ,[COD_EST_CIV_P]" +
          " ,[NOM_USU]" +
          " ,[CLAVE_USU]" +
          " ,[TIPO_USU_P]" +
           ",[COD_CAR_P])" +
  "   VALUES" +
          " (@cedula" +
           ",@nombre1" +
           ",@nombre2" +
           ",@apellido1" +
           ",@apellido2" +
           ",@genero" +
           ",@fechaNacimiento" +
           ",@ciudad" +
           ",@direccion" +
           ",@telefono" +
           ",@etnia" +
           ",@estadoCivil" +
           ",@nombreUsuario" +
           ",@clave" +
           ",@tipoUsuario" +
           ",@cargo)  " + "            ; SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedula", nuevoEmpleado.Cedula);
                    cmd.Parameters.AddWithValue("@nombre1", nuevoEmpleado.Nombre1);
                    cmd.Parameters.AddWithValue("@nombre2", nuevoEmpleado.Nombre2);
                    cmd.Parameters.AddWithValue("@apellido1", nuevoEmpleado.Apellido1);
                    cmd.Parameters.AddWithValue("@apellido2", nuevoEmpleado.Apellido2);
                    cmd.Parameters.AddWithValue("@genero", nuevoEmpleado.Genero);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", nuevoEmpleado.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@ciudad", nuevoEmpleado.Cod_Ciudad);
                    cmd.Parameters.AddWithValue("@direccion", nuevoEmpleado.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", nuevoEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@etnia", nuevoEmpleado.Etnia);
                    cmd.Parameters.AddWithValue("@estadoCivil", nuevoEmpleado.EstadoCivil);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nuevoEmpleado.NomUsuario);
                    cmd.Parameters.AddWithValue("@clave", nuevoEmpleado.Clave);
                    cmd.Parameters.AddWithValue("@tipoUsuario", nuevoEmpleado.TipoUsuario);
                    cmd.Parameters.AddWithValue("@cargo", nuevoEmpleado.Cargo);
                    Console.Write(nuevoEmpleado.Genero + nuevoEmpleado.TipoUsuario);
                    var IdEmpleado = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return nuevoEmpleado;
                }
            }
        }
        public static Empleado Actualizar(Empleado persona)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString = " UPDATE[dbo].[EMPLEADO]" +
                    "SET [NOM1_EMP] = @nombre1" +
                    ",[NOM2_EMP] = @nombre2" +
                    ",[APE1_EMP] = @apellido1" +
                    ",[APE2_EMP] = @apellido2" +
                    ",[TEL_EMP] = @telefono " +
                    ",[COD_EST_CIV_P] =  @estadoCivil" +
                    ",[DIR_EMP] = @direccion" +
                    ",[COD_CIU_P] = @ciudad   WHERE[CED_EMP] = '" + persona.Cedula + "'";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombre1", persona.Nombre1);
                    cmd.Parameters.AddWithValue("@nombre2", persona.Nombre2);
                    cmd.Parameters.AddWithValue("@apellido1", persona.Apellido1);
                    cmd.Parameters.AddWithValue("@apellido2", persona.Apellido2);
                    cmd.Parameters.AddWithValue("@telefono", persona.Telefono);
                    cmd.Parameters.AddWithValue("@estadoCivil", persona.EstadoCivil);
                    cmd.Parameters.AddWithValue("@direccion", persona.Direccion);
                    cmd.Parameters.AddWithValue("@ciudad", persona.Cod_Ciudad);
                    var IdPersonaTest = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return persona;
                }
            }
        }
        public static Empleado Eliminar(Empleado persona)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString = "DELETE FROM [dbo].[EMPLEADO] WHERE CED_EMP='" + persona.Cedula + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);

                    var IdPersonaTest = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return persona;
                }
            }
        }
        #endregion

        #region MÉTODOS USUARIO
        public static string DevuelveSQLUsuarios()
        {
            return "SELECT CED_EMP, NOM1_EMP,APE1_EMP, EMPLEADO.NOM_USU,CLAVE_USU,TIPO_USUARIO.NOM_USU AS TIPO_USUARIO " +
             "FROM EMPLEADO, TIPO_USUARIO WHERE TIPO_USU_P = TIPO_USUARIO.COD_USU  ";
        }
        public static Empleado ActualizarUSuario(Empleado usuario)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString = " UPDATE[dbo].[EMPLEADO] " +
                    "SET EMPLEADO.NOM_USU =@nombreUsuario,CLAVE_USU=@claveNueva   WHERE[CED_EMP] = '" + usuario.Cedula + "'";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombreUsuario", usuario.NomUsuario);
                    cmd.Parameters.AddWithValue("@claveNueva", usuario.Clave);

                    var IdPersonaTest = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return usuario;
                }
            }
        }
        #endregion



    }
}
