using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading; // NUEVO

namespace Juego_de_la_Plaga
{
    public partial class TABJuegoCvC : Form
    {
        bool turno = true; // PARA TRABAJAR CON LOS BOTONES CREADOS

        public TABJuegoCvC()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nivel3 nivel = new Nivel3();
            nivel.Show();
        }

        private void btnReiniciar_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        int count = 1;
        int fila = 1;
        int columna = 1;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= fila; i++)
            {
                Button b = new Button();
                b.Text = "";
                b.Name = count.ToString();
                b.Size = new Size(35, 35);
                b.Location = new Point(40 * (i + 1), 40 * columna);
                Controls.Add(b);
                b.Click += new EventHandler(this.button_Click); // NUEVO

            }
            if (fila == int.Parse(txtX.Text))
            {
                fila = 0;
                columna++;
            }

            if (count == int.Parse(txtX.Text) * int.Parse(txtY.Text))
            {
                btnAgregar.Enabled = false;

            }

            count++;
            fila++;
        }

        // PARA TRABAJAR CON LOS BOTONES CREADOS
        void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (turno)
            {
                btn.BackColor = Color.Red;

            }
            else
                btn.BackColor = Color.Blue;

            turno = !turno;
            btn.Enabled = false; 

            /*if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Elije una celda vacia");
            }
            else
            {
                btn.BackColor = Color.Red;
            }*/
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        string jugador1 = " ";
        string jugador2 = " ";

        private void Iniciar()
        {
            if (txtIA1.Text == "" && txtIA2.Text == "")
            {
                MessageBox.Show("El nombre de los Jugadores no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtIA1.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 1 no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtIA2.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 2 no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (txtIA1.Text != "" && txtIA2.Text != "")
            {
                if (rbtnIA1R.Checked && rbtnIA2A.Checked)
                {
                    jugador1 = txtIA1.Text;
                    jugador2 = txtIA2.Text;
                    rbtnIA1A.Enabled = false;
                    rbtnIA2R.Enabled = false;
                    PlayGame();

                }
                if (rbtnIA1A.Checked && rbtnIA2R.Checked)
                {
                    jugador1 = txtIA2.Text;
                    jugador2 = txtIA1.Text;
                    rbtnIA1R.Enabled = false;
                    rbtnIA2A.Enabled = false;
                    PlayGame();
                }
                if (rbtnIA1R.Checked && rbtnIA2R.Checked)
                {
                    MessageBox.Show("Ambos jugadores no pueden escoger la misma opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rbtnIA1A.Checked && rbtnIA2A.Checked)
                {
                    MessageBox.Show("Ambos jugadores no pueden escoger la misma opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rbtnIA1R.Checked == false && rbtnIA1A.Checked == false || rbtnIA2R.Checked == false && rbtnIA2A.Checked == false)
                {
                    MessageBox.Show("Cada jugador puede escoger solamente una opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void PlayGame()
        {
            lblIA1.Text = txtIA1.Text;
            lblIA2.Text = txtIA2.Text;
            txtIA1.Visible = false;
            txtIA2.Visible = false;
            gboxMarcador.Text = "Marcador";
            gboxFichas.Visible = true;
            gboxDimensiones.Visible = true;

        }
    }
}
