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
    public partial class NivelesCvH : Form
    {
        Thread th;
        public NivelesCvH()
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
            Application.Run(new JuegoCvH());
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
    }
}
