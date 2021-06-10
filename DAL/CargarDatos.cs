using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajeria_Clases;

namespace DAL
{
    public static class CargarDatos
    {

        public static DataSet CargarListaDatos(string command)

        {
            using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }

        }
                
        public static DataSet CargarListaDatosConStoreProcedure(string nombreProcedimiento)

        {
            using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }

        }

        public static List<Usuario> DevolverUsuario(string command)
        {
            
            List<Usuario> ListaUsua = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(SettingsDAL.Default.CadenaConexion))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Usuario nuevoUsuario = new Usuario();
                    nuevoUsuario.Cedula = dr.GetString(0);
                    nuevoUsuario.Nombre = dr.GetString(1);
                    nuevoUsuario.Apellido = dr.GetString(2);
                    nuevoUsuario.NomUsuario = dr.GetString(3);
                    nuevoUsuario.Clave = dr.GetString(4);
                    nuevoUsuario.TipoUsuario = dr.GetString(5);
                    nuevoUsuario.Cargo = dr.GetString(6);
                    ListaUsua.Add(nuevoUsuario);

                }

                return ListaUsua;
            }
        }

    }
}
