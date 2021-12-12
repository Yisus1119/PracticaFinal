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



        }

        private void button6_Click(object sender, EventArgs e)
        {
               
            try
            {
                objetoNegocios.GetInsertarGruposEntidades
                       (txtDescripcion.Text, txtComentario.Text, comboStatus.Text, checkBoxEliminable.Checked.ToString());
                MessageBox.Show("Datos ingresados correctamente.");
                MostrarGrupoEntidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo ingresar la mercancia, Verifique que no haya cmapos vacios.  " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtDescripcion.Text == "" || txtComentario.Text == "" || comboStatus.Text == "")
            {
                MessageBox.Show("Fallo al editar, verifique que no haya campos vacios.");

            }
            else {  

                Conexion.AbrirConexion();
            string ActualizarEntidades = "UPDATE GruposEntidades SET Descripcion=@Descripcion, Comentario=@Comentario, Status=@Status,NoEliminable=@NoEliminable WHERE IdGrupoEntidad=@IdGrupoEntidad";

            SqlCommand comandoActualizar = new SqlCommand(ActualizarEntidades,Conexion.AbrirConexion());
            comandoActualizar.Parameters.AddWithValue("@IdGrupoEntidad", txtIdGrupoEntidad.Text);
            comandoActualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            comandoActualizar.Parameters.AddWithValue("@Comentario", txtComentario.Text);
            comandoActualizar.Parameters.AddWithValue("@Status", comboStatus.Text);
            comandoActualizar.Parameters.AddWithValue("@NoEliminable", checkBoxEliminable.Checked.ToString());

            comandoActualizar.ExecuteNonQuery();
            MessageBox.Show("Se han actualizado los registros seleccionados");
            txtIdGrupoEntidad.ResetText();
            txtDescripcion.ResetText();
            txtComentario.ResetText();
            comboStatus.ResetText();
            checkBoxEliminable.ResetText();
            MostrarGrupoEntidad();
            Conexion.CerrarConexion();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Conexion.AbrirConexion();
            string BorrarEntidad = "DELETE FROM GruposEntidades WHERE IdGrupoEntidad=@IdGrupoEntidad";

            SqlCommand comandoBorrar = new SqlCommand(BorrarEntidad, Conexion.AbrirConexion());
            comandoBorrar.Parameters.AddWithValue("@IdGrupoEntidad", txtIdGrupoEntidad.Text);

            comandoBorrar.ExecuteNonQuery();
            MessageBox.Show("Se ha borrado el registro seleccionado.");
            txtIdGrupoEntidad.ResetText();
            txtDescripcion.ResetText();
            txtComentario.ResetText();
            comboStatus.ResetText();
            checkBoxEliminable.ResetText();
            MostrarGrupoEntidad();
            Conexion.CerrarConexion();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
