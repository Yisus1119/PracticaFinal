using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using ClaseDatos;
using ClaseNegocios;

namespace PracticaFInalProgramacion
{
    public partial class FormLogin : Form
    {
        ClaseDatos.Conexion Conexion = new Conexion();

     
        public FormLogin()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            InvocarMetodos objetoNegocio = new InvocarMetodos();
            try
            {
                
                objetoNegocio.Login(txtUserEntidad.Text, txtPasswdEntidad.Text);
                MessageBox.Show("Registro correcto, bienvenido al sistema");
                this.Close();
                Form1 verForm = new Form1();
                verForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Datos Incorrectos, error: " + ex);
            }


        }
    }
}
