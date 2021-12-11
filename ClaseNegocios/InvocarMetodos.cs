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


        public bool Login (string UserNameEntidad, string PassworEntidad)
        {
            return objetoMetodos.IniciarSesion(UserNameEntidad, PassworEntidad);
        }



    }
}
