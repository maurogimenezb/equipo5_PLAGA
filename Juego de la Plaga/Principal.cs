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

namespace Juego_de_la_Plaga
{
    public partial class Principal : Form
    {
        Thread th;
        
        public Principal()
        {
            InitializeComponent();
        }

        private void btnNJ_Click(object sender, EventArgs e)
        {


        }

        private void btnNJ_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirmodos);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void abrirmodos (object obj)
        {
            Application.Run(new Modos());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
