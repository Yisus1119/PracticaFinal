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
    public partial class TipoEntidades : Form
    {
        ClaseDatos.Conexion ConexionBD = new Conexion();
        ClaseNegocios.InvocarMetodos objetoNegocios = new InvocarMetodos();
        public TipoEntidades()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoNegocios.InsertarTipoEntidad
                       (txtDescripcion.Text,txtID.Text, txtComentario.Text, comboStatus.Text, checkBoxEliminable.Checked.ToString(), dateFechaRegistro.CustomFormat);
                MessageBox.Show("Datos ingresados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo ingresar la mercancia, error no.  " + ex);
            }
        }
       

        private void TipoEntidades_Load(object sender, EventArgs e)
        {
            MostrarTipoEntidad();
            
        }

        private void MostrarTipoEntidad()
        {
            InvocarMetodos objetoNegocios = new InvocarMetodos();
            dataGridView2.DataSource = objetoNegocios.GetTipoEntidades();

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
