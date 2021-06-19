using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading; // NUEVO
using System.IO;

namespace Juego_de_la_Plaga
{
    public partial class TABJuegoCvC : Form
    {
        Button[,] btn = new Button[50, 50];
        bool turno = true; // PARA TRABAJAR CON LOS BOTONES CREADOS

        string jugador1 = " ";
        string jugador2 = " ";

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
            Modos modo = new Modos();
            modo.Show();
        }

        //Reinicia el Tablero 
        private void btnReiniciar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            TABJuegoCvC tablero = new TABJuegoCvC();
            tablero.Show();
        }

        //Metodo en el cual ambos jugadores ingresan sus respectivos nombres y turos, y se hace posteriormente las validaciones
        private void btnGO_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        //Metodo que valida los txt de cada jugador y los radiobuttons de seleccion de color 
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
                    MessageBox.Show("Cada jugador puede escoger una opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        //Metodo que hace visible el nombre de los jugadores, el marcador, el gboxDimensiones y el gboxFichas
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

        //Metodo que agrega botones en forma de un arreglo bidimensional
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int Xtxt = int.Parse(txtX.Text);
            int Ytxt = int.Parse(txtY.Text);

            //Se valida que las dimensiones del tablero introducidas por el jugador sean las adecuadas 
            if ((Xtxt >= 3 && Xtxt <= 10) && (Ytxt >= 3 && Ytxt <= 10))
            {
                for (int i = 1; i <= Xtxt; i++)
                {
                    for (int j = 1; j <= Ytxt; j++)
                    {
                        btn[i, j] = new Button()
                        {
                            Name = i + " " + j
                        };
                        btn[i, j].Size = new Size(35, 35);
                        btn[i, j].BackColor = Color.DarkGray;
                        btn[i, j].Location = new Point(35 * i, 35 * j);
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
            else
            {
                MessageBox.Show("Los rangos introducidos para las dimensiones del tablero de juego no son aceptables.\n Vuelva a introducir de vuelta", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Se hace visible el turno del jugador
            turnoJug();

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

        private void turnoJug()
        {
            if (rbtnIA1R.Checked && rbtnIA2A.Checked)
            {
                lblTurno1.Text = txtIA1.Text;
                lblTurno2.Text = txtIA2.Text;
            }
            else
            {
                if (rbtnIA2R.Checked && rbtnIA1A.Checked)
                {
                    lblTurno1.Text = txtIA2.Text;
                    lblTurno2.Text = txtIA1.Text;
                }
            }

        }


        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\source\repos\equipo5_PLAGA\jugadas.txt",true);

            try
            {
                escribir.WriteLine("Nombre Jugador 1: " + txtIA1);
                escribir.WriteLine("Nombre Jugador 2: " + txtIA2);
                
                if(rbtnIA1R.Checked && rbtnIA2A.Checked)
                {
                    escribir.WriteLine("Ficha Jugador 1: " + rbtnIA1R.Text);
                    escribir.WriteLine("Ficha Jigador 2: " + rbtnIA2A.Checked);
                }
                else
                {
                    if(rbtnIA2R.Checked && rbtnIA1A.Checked)
                    {
                        escribir.WriteLine("Ficha Jugador 1: " + rbtnIA2R.Text);
                        escribir.WriteLine("Ficha Jigador 2: " + rbtnIA1A.Checked);
                    }
                }

                //Turno
                //Cant Fichas Rojas
                //Cant Fichas Azules
            }
            catch
            {

            }
        }

        //Valida que lo ingresado en el campo del texbox sean letras y no numeros
        private void txtIA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Nombre ingresado no válido.\nVuelva a Ingresar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        //Valida que lo ingresado en el campo del texbox sean letras y no numeros 
        private void txtIA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Nombre ingresado no válido.\nVuelva a Ingresar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
