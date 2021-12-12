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

        public void InsertarGrupoEntidades(string Descripcion, string Comentario, string Status, bool NoEliminable)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insertarGruposEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Status", Status);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

        }
        public void InsertarTipoEntidades( string descripcion, int idGrupo, string comentario, string status, bool NoEliminable, string FechaRegistro)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into TiposEntidades values ('" + descripcion + "','" + idGrupo + "','" + comentario + "','" + status + "','" + NoEliminable + "','" + FechaRegistro + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            //comando.Connection = Conexion.AbrirConexion();
            //comando.CommandText = "InsertarTipoEntidades";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@Descripcion", descripcion);
            //comando.Parameters.AddWithValue("@idGrupoEntidad", idGrupo);
            //comando.Parameters.AddWithValue("@Comentario", comentario);
            //comando.Parameters.AddWithValue("@Status", status);
            //comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            //comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            //comando.ExecuteNonQuery();
            //Conexion.AbrirConexion();
        }
        public void EditarTipoEntidades(int tipoEntidad,string descripcion, int idGrupo, string comentario, string status, bool NoEliminable, string FechaRegistro)
        {

        }


    }
}
