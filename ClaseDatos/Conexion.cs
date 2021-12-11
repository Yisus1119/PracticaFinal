using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace ClaseDatos
{
    public class Conexion
    {
        public static SqlConnection AbrirConexion()
        {
           
            
                SqlConnection connection = new SqlConnection
                (
                "SERVER=localhost; DATABASE=SellPoint; integrated security=true;"
                );

                connection.Open();
                return connection;
        }

        public static SqlConnection CerrarConexion()
        {
            SqlConnection connection = new SqlConnection
                (
            "SERVER=localhost; DATABASE=SellPoint; integrated security=true;"
                );

            connection.Close();
            return connection;
        }

 
    }
}
