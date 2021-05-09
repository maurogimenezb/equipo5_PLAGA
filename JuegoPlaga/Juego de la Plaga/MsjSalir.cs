using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class MsjSalir : Form
    {
        public MsjSalir()
        {
            InitializeComponent();
        }

        private void btnSalirSI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalirNO_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();

        }
    }
}
