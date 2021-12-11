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
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdGrupoEntidad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtComentario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboStatus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            checkBoxEliminable.Checked = (bool)dataGridView1.CurrentRow.Cells[4].Value;
            dateFechaRegistro.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
