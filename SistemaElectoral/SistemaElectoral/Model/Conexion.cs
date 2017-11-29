using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*imports*/
using System.Data;
using System.Data.SqlClient;
/*imports*/

namespace SistemaElectoral.Model
{
    public class Conexion
    {
        private SqlConnection con; // Connection
        private SqlCommand sen; // Statement
        public SqlDataReader rs; // ResultSet

        public Conexion(String bd)
        {
            con = new SqlConnection(
                    "Data Source=DESKTOP-K8OE7UF;" +
                    "Initial Catalog=" + bd + "; " +
                    "User id=sa; " +
                    "Password=1234;"
                    //"Data Source=DESKTOP-T8QQK9J;" +
                    //"Initial Catalog=eleciones2018;" +
                    //"Integrated Security=SSPI;"
                );

            /*
            Autenticación de windows

            "Data Source=ServerName;" +
            "Initial Catalog=DataBaseName;" +
            "Integrated Security=SSPI;";
            */

            // url de conexión
        }

        public void Ejecutar(String query)
        {
            Console.WriteLine("QUERY=" + query);

            con.Open();
            sen = new SqlCommand(query, con);

            if (query.ToLower().Contains("select"))
            {
                rs = sen.ExecuteReader();
            }
            else
            { //insert, update, delete
                sen.ExecuteNonQuery();
                Cerrar();
            }
        }

        public void Cerrar()
        {
            con.Close();
        }
    }
}