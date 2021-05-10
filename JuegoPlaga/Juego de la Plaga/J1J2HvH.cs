using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class J1J2HvH : Form
    {
        public J1J2HvH()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modos mod = new Modos();
            mod.Show();
        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            this.Hide();
            TABJuegoHvH tab = new TABJuegoHvH();
            Niveles nivel = new Niveles();
            nivel.Show();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
