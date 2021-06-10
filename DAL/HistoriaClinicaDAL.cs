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
    public static class HistoriaClinicaDAL
    {
        #region SELECT INFORMACION COMPLETA
        public static string DevuelveSqlHistoriaClinica()
        {
            return "SELECT [NUM_HIST_CLI],[CED_PAC] AS CEDULA,[NOM1_PAC],[NOM2_PAC]" +
                " , [APE1_PAC],[APE2_PAC]" + ",GENERO.NOM_GEN " + ",[OCU_PAC],[FECH_NAC_PAC]" +
               ",ESTADO_CIVIL.NOM_EST ,ETNIA.NOM_ETN,[DIR_PAC],CIUDAD.NOM_CIU ,[TELF_PAC]" +
                " ,PATOLOGIA,[TRAUMAS],[MED_USU],[QUIROFANO],[HABITOS]" +
               " ,[ALERGIA_MED] ,[OTRAS_ALE]  FROM [dbo].[HISTORIA_CLINICA],GENERO, " +
                 "ESTADO_CIVIL ,ETNIA,CIUDAD " +
                "WHERE " +
                "ESTADO_CIVIL.COD_EST = COD_EST_P AND " +
                " ETNIA.COD_ETN=COD_ETN_P " +
               "AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                "GEN_PAC = GENERO.COD_GEN"
                ;
        }
        public static string DevuelveSQLHistoriaClinicaPorNumero(string parametro)

        {

            if (!parametro.Equals("")) //cuando el criterio de búsqueda es una cadena vacía, saldrá un error porque el número de la historia clínica es int y el parámetro es string
            {                           //por lo tanto se optó por colocar un if para controlar cada vez que la cadena sea vacía
                return "SELECT [NUM_HIST_CLI],[CED_PAC] AS CEDULA,[NOM1_PAC],[NOM2_PAC]" +
                " , [APE1_PAC],[APE2_PAC]" + ",GENERO.NOM_GEN " + ",[OCU_PAC],[FECH_NAC_PAC]" +
               ",ESTADO_CIVIL.NOM_EST ,ETNIA.NOM_ETN,[DIR_PAC],CIUDAD.NOM_CIU ,[TELF_PAC]" +
                " ,PATOLOGIA,[TRAUMAS],[MED_USU],[QUIROFANO],[HABITOS]" +
               " ,[ALERGIA_MED] ,[OTRAS_ALE]  FROM [dbo].[HISTORIA_CLINICA],GENERO, " +
                 "ESTADO_CIVIL ,ETNIA,CIUDAD " +
                "WHERE " +
                "ESTADO_CIVIL.COD_EST = COD_EST_P AND " +
                " ETNIA.COD_ETN=COD_ETN_P " +
               "AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                "GEN_PAC = GENERO.COD_GEN AND NUM_HIST_CLI LIKE'" + Convert.ToInt32(parametro) + "%'";

            }
            else
            {
                return "SELECT [NUM_HIST_CLI],[CED_PAC],[NOM1_PAC],[NOM2_PAC]" +
               " , [APE1_PAC],[APE2_PAC]" + ",GENERO.NOM_GEN " + ",[OCU_PAC],[FECH_NAC_PAC]" +
              ",ESTADO_CIVIL.NOM_EST ,ETNIA.NOM_ETN,[DIR_PAC],CIUDAD.NOM_CIU ,[TELF_PAC]" +
               " ,PATOLOGIA,[TRAUMAS],[MED_USU],[QUIROFANO],[HABITOS]" +
              " ,[ALERGIA_MED] ,[OTRAS_ALE]  FROM [dbo].[HISTORIA_CLINICA],GENERO, " +
                "ESTADO_CIVIL ,ETNIA,CIUDAD " +
               "WHERE " +
               "ESTADO_CIVIL.COD_EST = COD_EST_P AND " +
               " ETNIA.COD_ETN=COD_ETN_P " +
              "AND COD_CIU_P=CIUDAD.COD_CIU AND " +
               "GEN_PAC = GENERO.COD_GEN"
               ;

            }




        }
        public static string DevuelveSQLHistoriaClinicaPorCedula(string parametro)
        {
            return "SELECT [NUM_HIST_CLI],[CED_PAC] AS CEDULA,[NOM1_PAC],[NOM2_PAC]" +
                " , [APE1_PAC],[APE2_PAC]" + ",GENERO.NOM_GEN " + ",[OCU_PAC],[FECH_NAC_PAC]" +
               ",ESTADO_CIVIL.NOM_EST ,ETNIA.NOM_ETN,[DIR_PAC],CIUDAD.NOM_CIU ,[TELF_PAC]" +
                " ,PATOLOGIA,[TRAUMAS],[MED_USU],[QUIROFANO],[HABITOS]" +
               " ,[ALERGIA_MED] ,[OTRAS_ALE]  FROM [dbo].[HISTORIA_CLINICA],GENERO, " +
                 "ESTADO_CIVIL ,ETNIA,CIUDAD " +
                "WHERE " +
                "ESTADO_CIVIL.COD_EST = COD_EST_P AND " +
                " ETNIA.COD_ETN=COD_ETN_P " +
               "AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                "GEN_PAC = GENERO.COD_GEN AND CED_PAC LIKE'" + parametro + "%'";
        }

      

        public static string DevuelveSQLHistoriaClinicaPorApellido(string parametro)
        {
            return "SELECT [NUM_HIST_CLI],[CED_PAC] AS CEDULA,[NOM1_PAC],[NOM2_PAC]" +
               " , [APE1_PAC],[APE2_PAC]" + ",GENERO.NOM_GEN " + ",[OCU_PAC],[FECH_NAC_PAC]" +
              ",ESTADO_CIVIL.NOM_EST ,ETNIA.NOM_ETN,[DIR_PAC],CIUDAD.NOM_CIU ,[TELF_PAC]" +
               " ,PATOLOGIA,[TRAUMAS],[MED_USU],[QUIROFANO],[HABITOS]" +
              " ,[ALERGIA_MED] ,[OTRAS_ALE]  FROM [dbo].[HISTORIA_CLINICA],GENERO, " +
                "ESTADO_CIVIL ,ETNIA,CIUDAD " +
               "WHERE " +
               "ESTADO_CIVIL.COD_EST = COD_EST_P AND " +
               " ETNIA.COD_ETN=COD_ETN_P " +
              "AND COD_CIU_P=CIUDAD.COD_CIU AND " +
               "GEN_PAC = GENERO.COD_GEN AND APE1_PAC LIKE'" + parametro + "%'";
        }
        public static string DevuelveSQLHistoriaClinicaPorNombre(string parametro)
        {
            return "SELECT [NUM_HIST_CLI],[CED_PAC] AS CEDULA,[NOM1_PAC],[NOM2_PAC]" +
                  " , [APE1_PAC],[APE2_PAC]" + ",GENERO.NOM_GEN " + ",[OCU_PAC],[FECH_NAC_PAC]" +
                 ",ESTADO_CIVIL.NOM_EST ,ETNIA.NOM_ETN,[DIR_PAC],CIUDAD.NOM_CIU ,[TELF_PAC]" +
                  " ,PATOLOGIA,[TRAUMAS],[MED_USU],[QUIROFANO],[HABITOS]" +
                 " ,[ALERGIA_MED] ,[OTRAS_ALE]  FROM [dbo].[HISTORIA_CLINICA],GENERO, " +
                   "ESTADO_CIVIL ,ETNIA,CIUDAD " +
                  "WHERE " +
                  "ESTADO_CIVIL.COD_EST = COD_EST_P AND " +
                  " ETNIA.COD_ETN=COD_ETN_P " +
                 "AND COD_CIU_P=CIUDAD.COD_CIU AND " +
                  "GEN_PAC = GENERO.COD_GEN AND NOM1_PAC LIKE'" + parametro + "%'";
        }
        #endregion

        #region SLECT INFORMACION PARCIAL
        public static string SqlBuscarHistoriaClinica()
        {
            return "SELECT [NUM_HIST_CLI] AS Nº_HISTORIA,[CED_PAC] AS CEDULA,[NOM1_PAC] AS NOMBRE1,[NOM2_PAC] AS NOMBRE2" +
                   ",[APE1_PAC] AS APELLIDO1,[APE2_PAC] AS APELLIDO2,GENERO.NOM_GEN AS GENERO,[OCU_PAC] AS OCUPACION,CIUDAD.NOM_CIU AS CIUDAD ,[TELF_PAC] AS TELEFONO " +
                   "FROM [dbo].[HISTORIA_CLINICA],GENERO,CIUDAD " +
                   "WHERE " +
                   "COD_CIU_P=CIUDAD.COD_CIU AND " +
                   "GEN_PAC = GENERO.COD_GEN"
                 ;
        }
        public static string SQLBuscarHistoriaClinicaPorNumero(string parametro)
        {
            if (!parametro.Equals(""))
            {
                return "SELECT [NUM_HIST_CLI] AS Nº_HISTORIA,[CED_PAC] AS CEDULA,[NOM1_PAC] AS NOMBRE1,[NOM2_PAC] AS NOMBRE2" +
                  ",[APE1_PAC] AS APELLIDO1,[APE2_PAC] AS APELLIDO2,GENERO.NOM_GEN AS GENERO,[OCU_PAC] AS OCUPACION,CIUDAD.NOM_CIU AS CIUDAD ,[TELF_PAC] AS TELEFONO " +
                  "FROM [dbo].[HISTORIA_CLINICA],GENERO,CIUDAD " +
                  "WHERE " +
                  "COD_CIU_P=CIUDAD.COD_CIU AND " +
                  "GEN_PAC = GENERO.COD_GEN AND NUM_HIST_CLI LIKE '" + Convert.ToInt32(parametro) + "%'"
                ;
            }
            else
            {
                //return "SELECT [NUM_HIST_CLI] AS Nº_HISTORIA,[CED_PAC] AS CEDULA,[NOM1_PAC] AS NOMBRE1,[NOM2_PAC] AS NOMBRE2" +
                //                  ",[APE1_PAC] AS APELLIDO1,[APE2_PAC] AS APELLIDO2,GENERO.NOM_GEN AS GENERO,[OCU_PAC] AS OCUPACION,CIUDAD.NOM_CIU AS CIUDAD ,[TELF_PAC] AS TELEFONO " +
                //                  "FROM [dbo].[HISTORIA_CLINICA],GENERO,CIUDAD " +
                //                  "WHERE " +
                //                  "COD_CIU_P=CIUDAD.COD_CIU AND " +
                //                  "GEN_PAC = GENERO.COD_GEN AND NUM_HIST_CLI LIKE '" + parametro + "%'"
                //                ;
                return SqlBuscarHistoriaClinica();
            }

        }
        public static string SQLBuscarHistoriaClinicaPorCedula(string parametro)
        {
            return "SELECT [NUM_HIST_CLI] AS Nº_HISTORIA,[CED_PAC] AS CEDULA,[NOM1_PAC] AS NOMBRE1,[NOM2_PAC] AS NOMBRE2" +
                  ",[APE1_PAC] AS APELLIDO1,[APE2_PAC] AS APELLIDO2,GENERO.NOM_GEN AS GENERO,[OCU_PAC] AS OCUPACION,CIUDAD.NOM_CIU AS CIUDAD ,[TELF_PAC] AS TELEFONO " +
                  "FROM [dbo].[HISTORIA_CLINICA],GENERO,CIUDAD " +
                  "WHERE " +
                  "COD_CIU_P=CIUDAD.COD_CIU AND " +
                  "GEN_PAC = GENERO.COD_GEN AND CED_PAC LIKE '" + parametro + "%'"
                ;
        }
        public static string SQLBuscarHistoriaClinicaPorApellido(string parametro)
        {
            return "SELECT [NUM_HIST_CLI] AS Nº_HISTORIA,[CED_PAC] AS CEDULA,[NOM1_PAC] AS NOMBRE1,[NOM2_PAC] AS NOMBRE2" +
                 ",[APE1_PAC] AS APELLIDO1,[APE2_PAC] AS APELLIDO2,GENERO.NOM_GEN AS GENERO,[OCU_PAC] AS OCUPACION,CIUDAD.NOM_CIU AS CIUDAD ,[TELF_PAC] AS TELEFONO " +
                 "FROM [dbo].[HISTORIA_CLINICA],GENERO,CIUDAD " +
                 "WHERE " +
                 "COD_CIU_P=CIUDAD.COD_CIU AND " +
                 "GEN_PAC = GENERO.COD_GEN AND APE1_PAC LIKE '" + parametro + "%'"
               ;
        }
        public static string SQLBuscarHistoriaClinicaPorNombre(string parametro)
        {
            return "SELECT [NUM_HIST_CLI] AS Nº_HISTORIA,[CED_PAC] AS CEDULA,[NOM1_PAC] AS NOMBRE1,[NOM2_PAC] AS NOMBRE2" +
                  ",[APE1_PAC] AS APELLIDO1,[APE2_PAC] AS APELLIDO2,GENERO.NOM_GEN AS GENERO,[OCU_PAC] AS OCUPACION,CIUDAD.NOM_CIU AS CIUDAD ,[TELF_PAC] AS TELEFONO " +
                  "FROM [dbo].[HISTORIA_CLINICA],GENERO,CIUDAD " +
                  "WHERE " +
                  "COD_CIU_P=CIUDAD.COD_CIU AND " +
                  "GEN_PAC = GENERO.COD_GEN AND NOM1_PAC LIKE '" + parametro + "%'"
                ;
        }
        #endregion

        #region MÉTODOS INSERT,UPDATE,DELETE
        public static HistoriaClinica Guardar(HistoriaClinica nuevaHistoria)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString =

                         "INSERT INTO[dbo].[HISTORIA_CLINICA] ([CED_PAC] ,[NOM1_PAC],[NOM2_PAC],[APE1_PAC] ,[APE2_PAC]" +
          " ,[GEN_PAC]   ,[OCU_PAC]  ,[FECH_NAC_PAC]  ,[COD_EST_P] ,[COD_ETN_P] ,[DIR_PAC] ,[COD_CIU_P] ,[TELF_PAC]" +
          " ,[PATOLOGIA]  ,[TRAUMAS]     ,[MED_USU] ,[QUIROFANO]   ,[HABITOS]  ,[ALERGIA_MED]   ,[OTRAS_ALE])" +
  "   VALUES" +
          " (@cedula,@nombre1,@nombre2,@apellido1,@apellido2,@genero,@ocupacion,@fechaNacimiento,@estadoCivil,@etnia"
          + ",@direccion,@ciudad,@telefono,@patologia,@traumas,@medUsa,@quirofano,@habitos,@alergiaMed,@otraAlergia)  "
           + "            ; SELECT SCOPE_IDENTITY()";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedula", nuevaHistoria.Cedula);
                    cmd.Parameters.AddWithValue("@nombre1", nuevaHistoria.Nombre1);
                    cmd.Parameters.AddWithValue("@nombre2", nuevaHistoria.Nombre2);
                    cmd.Parameters.AddWithValue("@apellido1", nuevaHistoria.Apellido1);
                    cmd.Parameters.AddWithValue("@apellido2", nuevaHistoria.Apellido2);
                    cmd.Parameters.AddWithValue("@genero", nuevaHistoria.Genero);
                    cmd.Parameters.AddWithValue("@ocupacion", nuevaHistoria.Ocupacion);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", nuevaHistoria.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@estadoCivil", nuevaHistoria.EstadoCivil);
                    cmd.Parameters.AddWithValue("@etnia", nuevaHistoria.Etnia);
                    cmd.Parameters.AddWithValue("@direccion", nuevaHistoria.Direccion);
                    cmd.Parameters.AddWithValue("@ciudad", nuevaHistoria.Cod_Ciudad);
                    cmd.Parameters.AddWithValue("@telefono", nuevaHistoria.Telefono);
                    cmd.Parameters.AddWithValue("@patologia", nuevaHistoria.Patologias);
                    cmd.Parameters.AddWithValue("@traumas", nuevaHistoria.Traumatismos);
                    cmd.Parameters.AddWithValue("@medUsa", nuevaHistoria.MedicamentosQueUsa);
                    cmd.Parameters.AddWithValue("@quirofano", nuevaHistoria.Quirurgicos);
                    cmd.Parameters.AddWithValue("@habitos", nuevaHistoria.Habitos);
                    cmd.Parameters.AddWithValue("@alergiaMed", nuevaHistoria.AlergiaMedicamentos);
                    cmd.Parameters.AddWithValue("@otraAlergia", nuevaHistoria.OtrasAlergias);


                    var IdPersonaTest = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return nuevaHistoria;
                }
            }
        }
        public static HistoriaClinica Actualizar(HistoriaClinica persona)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString = "UPDATE[dbo].[HISTORIA_CLINICA]  "
                       + " SET[NOM1_PAC] = @nombre1"
                       + " ,[NOM2_PAC] = @nombre2"
                       + " ,[APE1_PAC] = @apellido1"
                       + " ,[APE2_PAC] = @apellido2"
                       + " ,[GEN_PAC] = @genero"
                       + " ,[OCU_PAC] = @ocupacion"
                       + " ,[FECH_NAC_PAC] = @fechaNacimiento"
                       + " ,[COD_EST_P] = @estadoCivil"
                       + " ,[COD_ETN_P] = @etnia"
                       + " ,[DIR_PAC] = @direccion"
                       + " ,[COD_CIU_P] = @ciudad"
                       + " ,[TELF_PAC] = @telefono WHERE [CED_PAC] ='" + persona.Cedula + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombre1", persona.Nombre1);
                    cmd.Parameters.AddWithValue("@nombre2", persona.Nombre2);
                    cmd.Parameters.AddWithValue("@apellido1", persona.Apellido1);
                    cmd.Parameters.AddWithValue("@apellido2", persona.Apellido2);
                    cmd.Parameters.AddWithValue("@genero", persona.Genero);
                    cmd.Parameters.AddWithValue("@ocupacion", persona.Ocupacion);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", persona.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@estadoCivil", persona.EstadoCivil);
                    cmd.Parameters.AddWithValue("@etnia", persona.Etnia);
                    cmd.Parameters.AddWithValue("@direccion", persona.Direccion);
                    cmd.Parameters.AddWithValue("@ciudad", persona.Cod_Ciudad);
                    cmd.Parameters.AddWithValue("@telefono", persona.Telefono);

                    var IdPersonaTest = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return persona;
                }
            }
        }
        public static HistoriaClinica Eliminar(HistoriaClinica persona)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString = "DELETE FROM [dbo].[HISTORIA_CLINICA] WHERE CED_PAC='" + persona.Cedula + "'";
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


    }
}
