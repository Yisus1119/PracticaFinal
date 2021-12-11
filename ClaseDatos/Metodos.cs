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

        public DataTable MostrarTipoEntidades()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "MostrarTipoEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            BuscarEntidades = comando.ExecuteReader();
            tabla.Load(BuscarEntidades);
            return tabla;
        }
        public void InsertarTipoEntidades(string idTipo, string descripcion, int idGrupo, string comentario, string status, byte eliminable, DateTime date)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into TiposEntidades values ('" + idTipo + "','" + descripcion+ "','" + idGrupo + "','" + comentario + "','" + status + "','" + eliminable + "','" + date + "')";
            comando.ExecuteNonQuery();
        }
        public void IniciarSesion (string UserNameEntidad, string PassworEntidad)
        {
            comando.Connection = Conexion.AbrirConexion();
           comando.CommandText = "IniciarSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UserNameEntidad", UserNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad", PassworEntidad);
            comando.ExecuteScalar();
           


        }


    }
}
