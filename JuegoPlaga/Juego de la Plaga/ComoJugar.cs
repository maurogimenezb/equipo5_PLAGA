using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class ComoJugar : Form
    {
        public ComoJugar()
        {
            InitializeComponent();
        }

        private void salirCJ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarCJ_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnNJ_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal princ = new MenuPrincipal();
            princ.Show();
        }

        private void ComoJugar_Load(object sender, EventArgs e)
        {

        }
    }
}
