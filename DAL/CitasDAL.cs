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
    public static class CitasDAL
    {
        public static string DevuelveSQLCitas()
        {
            return "SELECT NUM_CIT_MED,HORA_CIT FROM CITAS_MEDICAS ;";
        }
        public static string DevuelveSQLCitasPorFecha(string fecha)
        {
            //  return "SELECT NUM_CIT_MED,HORA_CIT FROM CITAS_MEDICAS WHERE FECH_CIT = '" + fecha + "';";
            return "  SELECT HORA_CIT, EMPLEADO.NOM1_EMP,EMPLEADO.APE1_EMP" +
               " FROM CITAS_MEDICAS,EMPLEADO WHERE FECH_CIT = '" + fecha + "' AND CED_PAC_P = EMPLEADO.CED_EMP";
        }
        public static string SQLCitasPorFechaSinRepeticion()
        {
           return "SELECT DISTINCT FECH_CIT FROM CITAS_MEDICAS"; 
        }



        public static string DevuelveSQLCitasPorFecha01(string fecha)
        {
            return "  SELECT NUM_CIT_MED, HORA_CIT, HISTORIA_CLINICA.NOM1_PAC,HISTORIA_CLINICA.APE1_PAC" +
                  " FROM CITAS_MEDICAS,HISTORIA_CLINICA WHERE FECH_CIT like '%" + fecha + "%' AND CED_PAC_P = HISTORIA_CLINICA.CED_PAC;";
        }

        public static string DevuelveSQLCitasPorCedulaPaciente(string cedula)
        {
            return "  SELECT NUM_CIT_MED, HORA_CIT, HISTORIA_CLINICA.NOM1_PAC,HISTORIA_CLINICA.APE1_PAC" +
                  " FROM CITAS_MEDICAS,HISTORIA_CLINICA WHERE CED_PAC_P like '%" + cedula + "%' ;";
        }

        public static Cita Guardar(Cita nuevaCita)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
                {
                    connection.Open();
                    string queryString =
                    "  INSERT INTO[dbo].[CITAS_MEDICAS]" +
                    "([CED_PAC_P]" +
                    ",[FECH_CIT]" +
                    ",[HORA_CIT]" +
                    ",[CED_EMP_P])" +
                    "VALUES" +
                    "(@cedulaPaciente" +
                    ",@fecha" +
                    ",@hora" +
                    ",@cedulaEmpleado)";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedulaPaciente", nuevaCita.CedulaPaciente);
                    cmd.Parameters.AddWithValue("@fecha", nuevaCita.Fecha);
                    cmd.Parameters.AddWithValue("@hora", nuevaCita.Hora);
                    cmd.Parameters.AddWithValue("@cedulaEmpleado", nuevaCita.CedulaEmpleado);
                    var NumCita = cmd.ExecuteScalar();
                    // cmd.ExecuteScalar();
                    //  cmd.ExecuteNonQuery();
                    connection.Close();
                    scope.Complete();
                    return nuevaCita;
                }
            }
        }
    }
}
