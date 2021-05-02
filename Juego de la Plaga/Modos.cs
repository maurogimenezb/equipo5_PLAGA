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
            this.Close();
            th = new Thread(abrirniveles);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void abrirniveles(object obj)
        {
            Application.Run(new NivelesCvH());
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
            Application.Run(new Principal());
        }
        // ABRIR EL JUEGO HUMANO V HUMANO
        private void btnHvH_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirjuegoHvH);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void abrirjuegoHvH(object obj)
        {
            Application.Run(new JuegoHvH());
        }

        // ABRIR EL JUEGO COMPUTADORA V COMPUTADORA


        private void btnCvC_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirjuegoCvC);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void abrirjuegoCvC(object obj)
        {
            Application.Run(new JuegoCvC());
        }
    }
}
