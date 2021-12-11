using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClaseDatos
{
    public class Metodos
    {


        SqlDataReader BuscarEntidades;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable MostrarEntidades()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "MostrarEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            BuscarEntidades = comando.ExecuteReader();
            tabla.Load(BuscarEntidades);
            return tabla;

        }

        public DataTable MostrarGrupoEntidades()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "MostrarGruposEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            BuscarEntidades = comando.ExecuteReader();
            tabla.Load(BuscarEntidades);
            return tabla;
        }

        public bool IniciarSesion (string UserNameEntidad, string PassworEntidad)
        {
            string BuscarRegistro=null;
            comando.Connection = Conexion.AbrirConexion();
           comando.CommandText = "IniciarSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UserNameEntidad", UserNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad", PassworEntidad);
            BuscarRegistro =  comando.ExecuteScalar().ToString();
            if (BuscarRegistro == "0") 
            {
                return false;
            }

            return true;
        }

        public void InsertarGrupoEntidades(string Descripcion, string Comentario, string Status, bool NoEliminable, DateTime FechaRegistro)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insertarGrupoEntidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Status", Status);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            comando.ExecuteNonQuery();
            Conexion.AbrirConexion();

        }


    }
}
