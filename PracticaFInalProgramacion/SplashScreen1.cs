using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFInalProgramacion
{
    public partial class SplashScreen1 : Form
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //INCREMENTAMOS LA BARRA
            progressBar1.Increment(2);
            label1.Text = progressBar1.Value.ToString() + "%";

            //Si llega al maximo paramos el timer
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                FormLogin frmlogin = new FormLogin();
                frmlogin.ShowDialog();
            }
        }
    }
}
