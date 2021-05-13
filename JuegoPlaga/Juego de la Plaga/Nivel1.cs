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
    public partial class Nivel1 : Form
    {
        Thread th;
        public Nivel1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirniveles);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void abrirniveles(object obj)
        {
            Application.Run(new TABJuegoCvH());
        }


        private void btnatras_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(atras);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void atras(object obj)
        {
            Application.Run(new Modos());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnATR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modos mod = new Modos();
            mod.Show();

        }

        private void btnFACIL_Click(object sender, EventArgs e)
        {
            this.Hide();
            TABJuegoCvH game = new TABJuegoCvH();
            game.Show();

        }

        private void btnNORMAL_Click(object sender, EventArgs e)
        {
            this.Hide();
            TABJuegoCvH game = new TABJuegoCvH();
            game.Show();
        }

        private void btnDIFICIL_Click(object sender, EventArgs e)
        {
            this.Hide();
            TABJuegoCvH game = new TABJuegoCvH();
            game.Show();
        }
    }
}
