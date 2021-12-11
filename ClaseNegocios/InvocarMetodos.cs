using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClaseDatos;

namespace ClaseNegocios
{
    public class InvocarMetodos
    {
        public Metodos objetoMetodos = new Metodos();

        public DataTable GetEntidades()
        {
            DataTable tabla = new DataTable();
            tabla = objetoMetodos.MostrarEntidades();
            return tabla;
        }

        public DataTable GetGrupoEntidades()
        {
            DataTable GrupoEntidades = new DataTable();
            GrupoEntidades = objetoMetodos.MostrarGrupoEntidades();
            return GrupoEntidades;
        }

        public DataTable GetTipoEntidades()
        {
            DataTable TipoEntidades = new DataTable();
            TipoEntidades = objetoMetodos.MostrarTipoEntidades();
            return TipoEntidades;
        }
        public void InsertarTipoEntidad (string idTipo, string descripcion, string idGrupo, string comentario, string status, string eliminable, string date){
            objetoMetodos.InsertarTipoEntidades(idTipo, descripcion,Convert.ToInt32(idGrupo), comentario, status, Convert.ToByte(eliminable),Convert.ToDateTime(date) );

            }
    
        public void Login (string UserNameEntidad, string PassworEntidad)
        {
            objetoMetodos.IniciarSesion(UserNameEntidad, PassworEntidad);
        }



    }
}
