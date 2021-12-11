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
using System.Data;
using System.Data.SqlClient;

namespace PracticaFInalProgramacion
{
 
    public partial class CRUD : Form
    {
        ClaseDatos.Conexion ConexionBD = new Conexion();
        ClaseDatos.Metodos MetodosBD = new Metodos();


        public CRUD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEntidades();
        }

        private void MostrarEntidades()
        {
            Conexion.AbrirConexion();
            Metodos objetoTabla = new Metodos();
            dataGridView1.DataSource = objetoTabla.MostrarEntidades();
            Conexion.CerrarConexion();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = System.DateTime.Now.ToString("F");
        }
    }
}
