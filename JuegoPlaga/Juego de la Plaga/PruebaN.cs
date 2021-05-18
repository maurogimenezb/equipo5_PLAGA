using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class PruebaN : Form
    {
        public PruebaN()
        {
            InitializeComponent();
        }

        string jugador1 = "";
        string jugador2 = "";

        private void Iniciar()
        {
            if (txtJ1.Text == "" && txtJ2.Text == "")
            {
                MessageBox.Show("El nombre de los Jugadores no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtJ1.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 1 no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtJ2.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 2 no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (txtJ1.Text != "" && txtJ2.Text != "")
            {
                if (rbtnJ1R.Checked && rbtnJ2A.Checked)
                {
                    jugador1 = txtJ1.Text;
                    jugador2 = txtJ2.Text;
                    rbtnJ1A.Enabled = false;
                    rbtnJ2R.Enabled = false;

                }
                if (rbtnJ1A.Checked && rbtnJ2R.Checked)
                {
                    jugador1 = txtJ2.Text;
                    jugador2 = txtJ1.Text;
                    rbtnJ1R.Enabled = false;
                    rbtnJ2A.Enabled = false;

                }
                if (rbtnJ1R.Checked && rbtnJ2R.Checked)
                {
                    MessageBox.Show("Ambos jugadores no pueden escoger la misma opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rbtnJ1A.Checked && rbtnJ2A.Checked)
                {
                    MessageBox.Show("Ambos jugadores no pueden escoger la misma opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rbtnJ1R.Checked == false && rbtnJ1A.Checked == false || rbtnJ2R.Checked == false && rbtnJ2A.Checked == false)
                {
                    MessageBox.Show("Cada jugador puede escoger solamente una opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void PruebaN_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
