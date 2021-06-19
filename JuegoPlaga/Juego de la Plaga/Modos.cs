using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Juego_de_la_Plaga
{
    public partial class Modos : Form
    {
        Thread th;

        public Modos()
        {
            InitializeComponent();
        }

        private void btnCvH_Click(object sender, EventArgs e)
        {
            this.Hide();
            TABJuegoCvH tablero = new TABJuegoCvH();
            tablero.Show();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(atras);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void atras(object obj)
        {
            Application.Run(new MenuPrincipal());
        }

        private void btnHvH_Click(object sender, EventArgs e)
        {
            this.Hide();
            TABJuegoHvH tablero = new TABJuegoHvH();
            tablero.Show();
        }

        private void abrirjuegoHvH(object obj)
        {
            Application.Run(new TABJuegoHvH());
        }

        private void btnCvC_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TABJuegoCvC tablero = new TABJuegoCvC();
            tablero.Show();
        }
        private void abrirjuegoCvC(object obj)
        {
            Application.Run(new TABJuegoCvC());
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnATR_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();

        }
    }
}
