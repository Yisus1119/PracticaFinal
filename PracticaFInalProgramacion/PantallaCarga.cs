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
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            label1.Text = progressBar1.Value.ToString() + "%";

                if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                FormLogin frmLogin = new FormLogin();
                frmLogin.ShowDialog();
            }
        }
    }
}
