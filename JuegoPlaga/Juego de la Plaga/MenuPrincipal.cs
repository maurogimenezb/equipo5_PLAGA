using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Juego_de_la_Plaga
{
    public partial class MenuPrincipal : Form
    {
        
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNJ_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Modos modo = new Modos();
            modo.Show();
        }

        private void btnCJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComoJugar cj = new ComoJugar();
            cj.Show();
        }

        private void btnAdeA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acerca a = new Acerca();
            a.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            this.Hide();
            //SystemSounds.Question.Play();
            //Console.Beep();

            SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/windows-exclamacion.wav");
            sonido.Play();

            MsjSalir salir = new MsjSalir();
            salir.Show();
        }

    }
}
