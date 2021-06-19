using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
        }

        private void salirAA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarAA_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnATR_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
    }
}
