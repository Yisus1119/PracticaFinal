using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseDatos;
using ClaseNegocios;
using System.Data;
using System.Data.SqlClient;

namespace PracticaFInalProgramacion
{
 
    public partial class CrudGrupoEntidades : Form
    {
        ClaseDatos.Conexion ConexionBD = new Conexion();
        ClaseNegocios.InvocarMetodos objetoNegocios = new InvocarMetodos();


        public CrudGrupoEntidades()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarGrupoEntidad();
        }

        private void MostrarGrupoEntidad()
        {
            InvocarMetodos objetoNegocios = new InvocarMetodos();
            dataGridView1.DataSource = objetoNegocios.GetGrupoEntidades();

        }


    }
}
