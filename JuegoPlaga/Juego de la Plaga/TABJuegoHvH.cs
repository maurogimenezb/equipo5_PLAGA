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

        Button[,] btn = new Button[50, 50];
        bool turno = true; // PARA TRABAJAR CON LOS BOTONES CREADOS
        Thread th; // NUEVO
        public TABJuegoHvH()
        {
            InitializeComponent();
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

        private void btnGO_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        string jugador1 = " ";
        string jugador2 = " ";

        private void Iniciar()
        {
            if (txtJ1.Text == "" && txtJ2.Text == "")
            {
                MessageBox.Show("El nombre de los Jugadores no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtJ1.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 1 no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtJ2.Text == "")
                {
                    MessageBox.Show("El nombre del jugador 2 no debe estar vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        int cont = 1;
        int x = 1;
        int y = 1;

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int i = int.Parse(txtX.Text);
            int j = int.Parse(txtY.Text);

            for (int y = 0; y < j; y++)
            {
                for (int x = 0; x < i; x++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].Size = new Size(50, 50);
                    btn[x, y].Name = "btn" + x + "" + y;
                    btn[x, y].Location = new Point(60 * x, 60 * y);
                    btn[x, y].Click += new EventHandler(button_Click);
                    Controls.Add(btn[x, y]);
                }
            }
            btnAgregar.Enabled = false;
            /* for (int i = 1; i <= x; i++)
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
            */
        }

        // PARA TRABAJAR CON LOS BOTONES CREADOS
        int a = 0;
        void button_Click(object sender, EventArgs e)
        {
            int y = 0;
            int x = 0;
            Button b = (Button)sender;
            //btn.Text = "0";
            if (a == 0)
            {
                b.BackColor = Color.Red;

                a = 1;
            }
            else
            {
                b.BackColor = Color.Blue;
                a = 0;
            }


            // REGLAS

            if (btn [x,y].BackColor == btn[x+1, y+1].BackColor)
            {
                MessageBox.Show("Gano");
            }


            /* Button btn = sender as Button;
            
             if (turno)
             {
                 btn.BackColor = Color.Red;
             }
             else
                 btn.BackColor = Color.Blue;

             turno = !turno;
             btn.Enabled = false;
            

            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Elije una celda vacia");
            }
            else
            {
                btn.BackColor = Color.Red;
            } */
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
