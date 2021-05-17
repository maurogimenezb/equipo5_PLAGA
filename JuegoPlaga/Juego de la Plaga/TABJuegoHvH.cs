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
    public partial class TABJuegoHvH : Form
    {
        bool turno = true; // PARA TRABAJAR CON LOS BOTONES CREADOS
        Thread th; // NUEVO
        public TABJuegoHvH()
        {
            InitializeComponent();
        }



        // PARA TRABAJAR CON LOS BOTONES CREADOS
        void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            /*
             if (turno)
             {
                 btn.BackColor = Color.Red;
                 btn.BackColor = Color.Red;
             }
             else
                 btn.BackColor = Color.Black;

             turno = !turno;
             btn.Enabled = false;
            */

            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Elije una celda vacia");
            }
            else
            {
                btn.BackColor = Color.Red;
            }
        }

        // PARA VOLVER AL MENU PRINCIPAL

        private void btnMP_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();

            /*this.Close();
            th = new Thread(atras);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/

        }
        private void atras(object obj)
        {
            Application.Run(new MenuPrincipal());
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nivel1 nivel = new Nivel1();
            nivel.Show();

        }

        string jugX = " ";
        string jugY = " ";

        private void btnGO_Click(object sender, EventArgs e)
        {
            if (txtJ1.Text == " ")
            {
                MessageBox.Show("El nombre de los jugadores no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtJ2.Text == " ")
                {
                    MessageBox.Show("El nombre de los jugadores no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtJ1.Text != " " && txtJ2.Text != " ")
                    {
                        if (rbtnJ1X.Checked && rbtnJ1O.Checked)
                        {
                            jugX = txtJ1.Text;
                            jugY = txtJ2.Text;
                            rbtnJ1O.Enabled = false;
                            rbtnJ1X.Enabled = false;
                        }
                        if (rbtnJ1O.Checked && rbtnJ1X.Checked)
                        {
                            jugX = txtJ2.Text;
                            jugY = txtJ1.Text;
                            rbtnJ1X.Enabled = false;
                            rbtnJ1O.Enabled = false;
                        }
                        if (rbtnJ1X.Checked && rbtnJ1X.Checked)
                        {
                            MessageBox.Show("Solo un jugador puede seleccionar la letra X", " Vuelva a escoger la letra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (rbtnJ1O.Checked && rbtnJ1O.Checked)
                        {
                            MessageBox.Show("Solo un jugador puede seleccionar la letra X", " Vuelva a escoger la letra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (rbtnJ1X.Checked == false && rbtnJ1O.Checked == false || rbtnJ2X.Checked == false && rbtnJ2O.Checked == false)
                        {
                            MessageBox.Show("Cada jugador puede seleccionar unicamente una letra", " Vuelva a escoger la letra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                }
            }
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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
