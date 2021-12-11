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


        public void Login (string UserNameEntidad, string PassworEntidad)
        {
            objetoMetodos.IniciarSesion(UserNameEntidad, PassworEntidad);
        }

    }
}
