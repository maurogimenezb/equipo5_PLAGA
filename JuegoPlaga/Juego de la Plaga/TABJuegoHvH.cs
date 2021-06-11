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
        int turno = 0; // PARA TRABAJAR CON LOS BOTONES CREADOS
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

            int Xtxt = int.Parse(txtX.Text);
            int Ytxt = int.Parse(txtY.Text);

            for (int i = 1; i <= Xtxt; i++)
            {
                for (int j = 1; j <= Ytxt; j++)
                {
                    btn[i, j] = new Button()
                    {
                        Name = i + " " + j
                    };
                    btn[i, j].Size = new Size(50, 50);
                    btn [i,j].BackColor = Color.Gray;
                    btn[i, j].Location = new Point(60 * i, 60 * j);
                    btn[i, j].Click += new EventHandler(button_Click);

                    Controls.Add(btn[i, j]);
                    //btn[x,y].Click += (sender1, ex) => this.button_Click(index + 1);
                }
            }
            btnAgregar.Enabled = false;

            // PINTO MIS BOTONES DE INICIALIZAR (ROJO Y AZUL)
            btn[1, 1].BackColor = Color.Red;
            btn[Xtxt, Ytxt].BackColor = Color.Blue;

        }

        // PARA TRABAJAR CON LOS BOTONES CREADOS
        // int a = 0;
        void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            string[] split = b.Name.Split(new Char[] { ' ' });

            int x = Convert.ToInt32(split[0]);
            int y = Convert.ToInt32(split[1]);

            //PINTAR ADYACENTE
            if (turno == 0)
            {
                // JUGADOR 1
                btn[x, y].BackColor = Color.Red;

                // PINTA BOTON DERECHO
                if (btn[x + 1, y] == null)
                {
                    turno = 1;
                }
                else if (btn[x + 1, y].BackColor == Color.Blue)
                {
                    btn[x + 1, y].BackColor = Color.Red;
                }

                // PINTA BOTON IZQUIERDO

                if (btn[x - 1, y] == btn[0, y])
                {
                    turno = 1;
                }
                else if (btn[x - 1, y].BackColor == Color.Blue)
                {
                    btn[x - 1, y].BackColor = Color.Red;
                }


                // PINTA BOTON ARRIBA
                if (btn[x, y - 1] == btn[x, 0])
                {
                    turno = 1;
                }
                else if (btn[x, y - 1].BackColor == Color.Blue)
                {
                    btn[x, y - 1].BackColor = Color.Red;
                }

                // PINTA BOTON ABAJO
                if (btn[x, y + 1] == null)
                {
                    turno = 1;
                }
                else if (btn[x, y + 1].BackColor == Color.Blue)
                {
                    btn[x, y + 1].BackColor = Color.Red;
                }

                // PINTA BOTON SUPERIOR IZQUIERDO
                if (btn[x - 1, y - 1] == btn[0, 0])
                {
                    turno = 1;
                }
                else if (btn[x - 1, y - 1].BackColor == Color.Blue)
                {
                    btn[x - 1, y - 1].BackColor = Color.Red;
                }
                // PINTA BOTON SUPERIOR DERECHO
                if (btn[x + 1, y - 1] == btn[x, 0])
                {
                    turno = 1;
                }
                else if (btn[x + 1, y - 1].BackColor == Color.Blue)
                {
                    btn[x + 1, y - 1].BackColor = Color.Red;
                }

                // PINTA BOTON INFERIOR IZQUIERDO
                if (btn[x - 1, y + 1] == btn[0, y])
                {
                    turno = 0;
                }
                else if (btn[x - 1, y + 1].BackColor == Color.Blue)
                {
                    btn[x - 1, y + 1].BackColor = Color.Red;
                }

                // PINTA BOTON INFERIOR DERECHO
                if (btn[x + 1, y + 1] == null)
                {
                    turno = 1;
                }
                else if (btn[x + 1, y + 1].BackColor == Color.Blue)
                {
                    btn[x + 1, y + 1].BackColor = Color.Red;
                }

                turno = 1;
            }
            // JUGADOR 2
            else
            {
                btn[x, y].BackColor = Color.Blue;

                // PINTA BOTON DERECHO
                if (btn[x + 1, y] == null)
                {
                    turno = 0;
                }
                else if (btn[x + 1, y].BackColor == Color.Red)
                {
                    btn[x + 1, y].BackColor = Color.Blue;
                }
                // PINTA BOTON IZQUIERDO
                if (btn[x - 1, y] == btn[0, y])
                {
                    turno = 0;
                }
                else if (btn[x - 1, y].BackColor == Color.Red)
                {
                    btn[x - 1, y].BackColor = Color.Blue;
                }

                // PINTA BOTON ARRIBA
                if (btn[x, y - 1] == btn[x, 0])
                {
                    turno = 1;
                }
                else if (btn[x, y - 1].BackColor == Color.Red)
                {
                    btn[x, y - 1].BackColor = Color.Blue;
                }

                // PINTA BOTON ABAJO
                if (btn[x, y + 1] == null)
                {
                    turno = 1;
                }
                else if (btn[x, y + 1].BackColor == Color.Red)
                {
                    btn[x, y + 1].BackColor = Color.Blue;
                }

                // PINTA BOTON SUPERIOR IZQUIERDO
                if (btn[x - 1, y - 1] == btn[0, 0])
                {
                    turno = 0;
                }
                else if (btn[x - 1, y - 1].BackColor == Color.Red)
                {
                    btn[x - 1, y - 1].BackColor = Color.Blue;
                }

                // PINTA BOTON SUPERIOR DERECHO
                if (btn[x + 1, y - 1] == btn[x, 0])
                {
                    turno = 1;
                }
                else if (btn[x + 1, y - 1].BackColor == Color.Red)
                {
                    btn[x + 1, y - 1].BackColor = Color.Blue;
                }

                // PINTA BOTON INFERIOR IZQUIERDO
                if (btn[x - 1, y + 1] == btn[0, y])
                {
                    turno = 0;
                }
                else if (btn[x - 1, y + 1].BackColor == Color.Red)
                {
                    btn[x - 1, y + 1].BackColor = Color.Blue;
                }

                // PINTA BOTON INFERIOR DERECHO
                if (btn[x + 1, y + 1] == null)
                {
                    turno = 1;
                }
                else if (btn[x + 1, y + 1].BackColor == Color.Red)
                {
                    btn[x + 1, y + 1].BackColor = Color.Blue;
                }

                turno = 0;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
