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
    public partial class MenuPrincipal : Form
    {
        Thread th;
        
        public MenuPrincipal()
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
            this.Hide();
            MsjSalir salir = new MsjSalir();
            salir.Show();
        }

        private void btnAdeA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acerca a = new Acerca();

            a.Show(); 

        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnCJ_Click(object sender, EventArgs e)
        {
            this.Hide();

            ComoJugar cj = new ComoJugar();
            cj.Show();

        }

        private void btnRJ_Click(object sender, EventArgs e)
        {
            this.Hide();



        }

        private void btnRdeJ_Click(object sender, EventArgs e)
        {
            this.Hide();

            Registro reg = new Registro();
            reg.Show();

        }
    }
}
