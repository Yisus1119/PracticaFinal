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

        public bool Login (string UserNameEntidad, string PassworEntidad)
        {
            return objetoMetodos.IniciarSesion(UserNameEntidad, PassworEntidad);
        }

        public void GetInsertarGruposEntidades(string Descripcion, string Comentario, string Status, string NoEliminable)
        {
            objetoMetodos.InsertarGrupoEntidades(Descripcion, Comentario, Status, Convert.ToBoolean(NoEliminable));
        }
        public void InsertarTipoEntidad( string descripcion, string idGrupo, string comentario, string status, string NoEliminable, string FechaRegistro)
        {
            DateTime dt = Convert.ToDateTime(FechaRegistro);
            string fecha = dt.ToString("yyyy-M-dd");
            objetoMetodos.InsertarTipoEntidades(descripcion, Convert.ToInt32(idGrupo), comentario, status, Convert.ToBoolean(NoEliminable), fecha);

        }

    }
}
