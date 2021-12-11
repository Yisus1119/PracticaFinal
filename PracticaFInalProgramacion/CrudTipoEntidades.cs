using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseNegocios;
namespace PracticaFInalProgramacion
{
    public partial class CrudTipoEntidades : Form
    {
        public CrudTipoEntidades()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrudTipoEntidades_Load(object sender, EventArgs e)
        {
            MostrarTipoEntidad();
        }

        private void MostrarTipoEntidad()
        {
            InvocarMetodos objetoNegocios = new InvocarMetodos();
            dataGridView2.DataSource = objetoNegocios.GetTipoEntidades();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
