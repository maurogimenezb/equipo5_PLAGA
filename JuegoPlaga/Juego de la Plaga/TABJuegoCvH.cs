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
    public partial class TABJuegoCvH : Form
    {
        bool turno = true; // PARA TRABAJAR CON LOS BOTONES CREADOS

        public TABJuegoCvH()
        {
            InitializeComponent();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();

            /*this.Close();
            th = new Thread(atras);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nivel1 nivel = new Nivel1();
            nivel.Show();

        }

        private void btnReiniciar_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        int cont = 1;
        int x = 1;
        int y = 1;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= x; i++)
            {
                Button b = new Button();
                b.Text = "";
                b.Name = cont.ToString();
                b.Size = new Size(35, 35);
                b.Location = new Point(40 * (i + 1), 40 * y);
                Controls.Add(b);
                b.Click += new EventHandler(this.button_Click);
            }
            if (x == int.Parse(txtX.Text))
            {
                x = 0;
                y++;
            }
            if (cont == int.Parse(txtX.Text) * int.Parse(txtY.Text))
            {
                btnAgregar.Enabled = false;
            }
            cont++;
            x++;
        }

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
            if (txtJug.Text == "" && txtIA.Text == "")
            {
                MessageBox.Show("El nombre de los Jugadores no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtJug.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 1 no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtIA.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 2 no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (txtJug.Text != "" && txtIA.Text != "")
            {
                if (rbtnJR.Checked && rbtnIAA.Checked)
                {
                    jugador1 = txtJug.Text;
                    jugador2 = txtIA.Text;
                    rbtnJA.Enabled = false;
                    rbtnIAR.Enabled = false;
                    PlayGame();

                }
                if (rbtnJA.Checked && rbtnIAR.Checked)
                {
                    jugador1 = txtIA.Text;
                    jugador2 = txtJug.Text;
                    rbtnJR.Enabled = false;
                    rbtnIAA.Enabled = false;
                    PlayGame();
                }
                if (rbtnJR.Checked && rbtnIAR.Checked)
                {
                    MessageBox.Show("Ambos jugadores no pueden escoger la misma opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rbtnJA.Checked && rbtnIAA.Checked)
                {
                    MessageBox.Show("Ambos jugadores no pueden escoger la misma opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (rbtnJR.Checked == false && rbtnJA.Checked == false || rbtnIAR.Checked == false && rbtnIAA.Checked == false)
                {
                    MessageBox.Show("Cada jugador puede escoger solamente una opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void PlayGame()
        {
            lblJug.Text = txtJug.Text;
            lblIA.Text = txtIA.Text;
            groupBox1.Text = "Marcador";
            
        }

    }
}
