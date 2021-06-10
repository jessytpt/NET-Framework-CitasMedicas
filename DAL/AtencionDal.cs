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
    public class AtencionDal
    {
        public static Atencion Guardar(Atencion nuevaAtencion)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString =

                         "INSERT INTO[dbo].[ATENCION] ([NUM_ATE] ,[NUM_CIT_MED_P],[HORA_INI_ATE],[HORA_FIN_ATE] ,[TEM_ATE]" +
          " ,[PRES_ATE]   ,[FCARD_ATE]  ,[EST_ATE]  ,[PESO_ATE] ,[IMC_ATE] ,[SIN_ATE] ,[DIAG_ATE] " +
  "   VALUES" +
          " (@numAte,@numCita,@horaInicio,@horaFin,@temperatura,@presion,@frecCardiaca,@estatura,@peso,@imc"
          + ",@sintomas,@diagnostico)  "
           + "            ; SELECT SCOPE_IDENTITY()";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@numAte", nuevaAtencion.NumAtencion);
                    cmd.Parameters.AddWithValue("@numCita", nuevaAtencion.NumCitaMedica);
                    cmd.Parameters.AddWithValue("@horaInicio", nuevaAtencion.HoraInicioAtencion);
                    cmd.Parameters.AddWithValue("@horaFin", nuevaAtencion.HoraFinAtencion);
                    cmd.Parameters.AddWithValue("@temperatura", nuevaAtencion.Temperatura);
                    cmd.Parameters.AddWithValue("@presion", nuevaAtencion.Presion);
                    cmd.Parameters.AddWithValue("@frecCardiaca", nuevaAtencion.FrecuenciaCardiaca);
                    cmd.Parameters.AddWithValue("@estatura", nuevaAtencion.Estatura);
                    cmd.Parameters.AddWithValue("@peso", nuevaAtencion.Peso);
                    cmd.Parameters.AddWithValue("@imc", nuevaAtencion.IMC);
                    cmd.Parameters.AddWithValue("@sintomas", nuevaAtencion.Sintomas);
                    cmd.Parameters.AddWithValue("@diagnostico", nuevaAtencion.Diagnostico);


                    var IdPersonaTest = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return nuevaAtencion;
                }
            }
        }


        public static Tratamiento GuardarTratamiento(Tratamiento nuevoTratamiento)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString =

                         "INSERT INTO[dbo].[TRATAMIENTO] ([NUM_TRA] ,[NUM_ATE_P],[REC_TRA],[IND_TRA] ,[CONTR_TRA]" +          
  "   VALUES" +
          " (@numTrat,@numAtencion,@receta,@indicaciones,@contraInd)  "
           + "            ; SELECT SCOPE_IDENTITY()";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@numTrat", nuevoTratamiento.NumTratamiento);
                    cmd.Parameters.AddWithValue("@numAtencion", nuevoTratamiento.NumAtencion);
                    cmd.Parameters.AddWithValue("@receta", nuevoTratamiento.Receta);
                    cmd.Parameters.AddWithValue("@indicaciones", nuevoTratamiento.Indicaciones);
                    cmd.Parameters.AddWithValue("@contraInd", nuevoTratamiento.ContraIndicaciones);
                    
                    var IdPersonaTest = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return nuevoTratamiento;
                }
            }
        }


    }
}
