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

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (txtDescripcion.Text == "" || txtComentario.Text == "" || comboStatus.Text == "")
            {
                MessageBox.Show("Fallo al editar, verifique que no haya campos vacios.");

            }
            else
            {

                Conexion.AbrirConexion();
                string ActualizarEntidades = "UPDATE TiposEntidades SET Descripcion=@Descripcion, Comentario=@Comentario, Status=@Status,NoEliminable=@NoEliminable WHERE IdTipoEntidad=@IdTipoEntidad";

                SqlCommand comandoActualizar = new SqlCommand(ActualizarEntidades, Conexion.AbrirConexion());
                comandoActualizar.Parameters.AddWithValue("@IdTipoEntidad", txtIdTipoEntidad.Text);
                comandoActualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                comandoActualizar.Parameters.AddWithValue("@Comentario", txtComentario.Text);
                comandoActualizar.Parameters.AddWithValue("@Status", comboStatus.Text);
                comandoActualizar.Parameters.AddWithValue("@NoEliminable", checkBoxEliminable.Checked.ToString());

                comandoActualizar.ExecuteNonQuery();
                MessageBox.Show("Se han actualizado los registros seleccionados");
                txtIdTipoEntidad.ResetText();
                txtDescripcion.ResetText();
                txtComentario.ResetText();
                comboStatus.ResetText();
                checkBoxEliminable.ResetText();
                MostrarTipoEntidad();
                Conexion.CerrarConexion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.AbrirConexion();
            string BorrarEntidad = "DELETE FROM TiposEntidades WHERE IdTipoEntidad=@IdTipoEntidad";

            SqlCommand comandoBorrar = new SqlCommand(BorrarEntidad, Conexion.AbrirConexion());
            comandoBorrar.Parameters.AddWithValue("@IdTipoEntidad", txtIdTipoEntidad.Text);

            comandoBorrar.ExecuteNonQuery();
            MessageBox.Show("Se ha borrado el registro seleccionado.");
            txtIdTipoEntidad.ResetText();
            txtDescripcion.ResetText();
            txtComentario.ResetText();
            comboStatus.ResetText();
            checkBoxEliminable.ResetText();
            MostrarTipoEntidad();
            Conexion.CerrarConexion();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTipoEntidad.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtID.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtComentario.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            comboStatus.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            checkBoxEliminable.Checked = (bool)dataGridView2.CurrentRow.Cells[5].Value;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
