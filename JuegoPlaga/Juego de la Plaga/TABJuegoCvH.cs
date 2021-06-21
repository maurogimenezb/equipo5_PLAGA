using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Juego_de_la_Plaga
{
    public partial class TABJuegoCvH : Form
    {
        Button[,] btn = new Button[50, 50];
        int turno = 0;

        string jugador1 = " ";
        string jugador2 = " ";

        //Boolean playerF;

        //Contadores que van guardando la cantidad de piezas de cada jugador, para a partir de eso definir el ganador 
        //int piezasRojas = 0;
        //int piezasAzules = 0;

        public TABJuegoCvH()
        {
            InitializeComponent();
        }


        public void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void btnMP_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();

        }


        public void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modos modo = new Modos();
            modo.Show();
        }

        //Reinicia el tablero 
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            TABJuegoCvH tablero = new TABJuegoCvH();
            tablero.Show();
        }

        //Metodo en el cual ambos jugadores ingresan sus respectivos nombres y turos, y se hace posteriormente las validaciones
        public void btnGO_Click(object sender, EventArgs e)
        {
            
            Iniciar();

        }

        //Hace las validaciones correspondiente, sobre los textboxs y radiobuttons de cada jugador
        public void Iniciar()
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
                    MessageBox.Show("Cada jugador puede escoger una opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        //Inicializa el juego despues de haber ingresado ambos jugadores sus respectivos nombres y fichas 
        public void PlayGame()
        {
            lblJug.Text = txtJug.Text;
            lblIA.Text = txtIA.Text;
            txtJug.Visible = false;
            txtIA.Visible = false;
            gboxMarcador.Text = "Marcador";
            gboxFichas.Visible = true;
            gboxDimensiones.Visible = true;

        }

        //Metodo que agrega los botones en forma de un arreglo bidimensional, segun la cantidad de filas y columnas
        //que el jugador ingresa por teclado 
        public void btnAgregar_Click_1(object sender, EventArgs e)
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
                        btn[i, j].Click += new EventHandler(playerInput_Click);

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
                txtX.Text = "";
                txtY.Text = "";
            }

            //Se hace visible el turno del jugador
            turnoJug();

        }

        //Metodo que va obteniendo la direccion en i y j de la ficha que fue seleccionada por el jugador 
        public void Valores(object sender, ref int x, ref int y) // Agarra los valores del click
        {
            Button b = sender as Button;

            string[] split = b.Name.Split(new Char[] { ' ' });

            x = Convert.ToInt32(split[0]);
            y = Convert.ToInt32(split[1]);
        }

        //Metodo que controla los movimientos del jugador -> Humano
        public void playerInput_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            bool movimiento = false;
            Valores(sender, ref x, ref y);

            //PINTAR ADYACENTE
            if (turno == 0)
            {
                // JUGADOR 1    -> Humano

                if (btn[x, y].BackColor == Color.DarkGray)
                {
                    // BOTON DERECHO
                    if (btn[x + 1, y] == null)
                    {
                    }
                    else if (btn[x + 1, y].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }

                    // BOTON IZQUIERDO

                    if (btn[x - 1, y] == btn[0, y])
                    {
                    }
                    else if (btn[x - 1, y].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }


                    // BOTON ARRIBA
                    if (btn[x, y - 1] == btn[x, 0])
                    {
                    }
                    else if (btn[x, y - 1].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }

                    // BOTON ABAJO
                    if (btn[x, y + 1] == null)
                    {
                    }
                    else if (btn[x, y + 1].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }

                    // BOTON SUPERIOR IZQUIERDO
                    if (btn[x - 1, y - 1] == btn[0, 0])
                    {
                    }
                    else if (btn[x - 1, y - 1].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }
                    // BOTON SUPERIOR DERECHO
                    if (btn[x + 1, y - 1] == btn[x, 0])
                    {
                    }
                    else if (btn[x + 1, y - 1].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }

                    // BOTON INFERIOR IZQUIERDO
                    if (btn[x - 1, y + 1] == btn[0, y])
                    {
                    }
                    else if (btn[x - 1, y + 1].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }

                    // BOTON INFERIOR DERECHO
                    if (btn[x + 1, y + 1] == null)
                    {
                    }
                    else if (btn[x + 1, y + 1].BackColor == Color.Red)
                    {
                        movimiento = true;
                    }
                }
            }
            // JUGADOR 2    -> Computadora IA
            else
            {
                
            }

            //
            if (movimiento == true)
            {
                Jugadas(x, y, ref turno);
            }

        }

        //Metodo que pinta las casillas que se encuentran alrededor de la ficha anteriormente escogida siguiendo las reglas 
        public void PintarAdyacente(int x, int y, int turno)
        {
            //piezasRojas = 0;
            //piezasAzules = 0;

            if (turno == 0)
            {
                // JUGADOR 1    -> Humano

                // PINTA BOTON DERECHO
                if (btn[x + 1, y] == null)
                {
                }
                else if (btn[x + 1, y].BackColor == Color.Blue)
                {
                    btn[x + 1, y].BackColor = Color.Red;
                    
                }

                // PINTA BOTON IZQUIERDO

                if (btn[x - 1, y] == btn[0, y])
                {
                }
                else if (btn[x - 1, y].BackColor == Color.Blue)
                {
                    btn[x - 1, y].BackColor = Color.Red;
                    
                }


                // PINTA BOTON ARRIBA
                if (btn[x, y - 1] == btn[x, 0])
                {
                }
                else if (btn[x, y - 1].BackColor == Color.Blue)
                {
                    btn[x, y - 1].BackColor = Color.Red;
                    
                }

                // PINTA BOTON ABAJO
                if (btn[x, y + 1] == null)
                {
                }
                else if (btn[x, y + 1].BackColor == Color.Blue)
                {
                    btn[x, y + 1].BackColor = Color.Red;
                    
                }

                // PINTA BOTON SUPERIOR IZQUIERDO
                if (btn[x - 1, y - 1] == btn[0, 0])
                {
                }
                else if (btn[x - 1, y - 1].BackColor == Color.Blue)
                {
                    btn[x - 1, y - 1].BackColor = Color.Red;
                    
                }
                // PINTA BOTON SUPERIOR DERECHO
                if (btn[x + 1, y - 1] == btn[x, 0])
                {
                }
                else if (btn[x + 1, y - 1].BackColor == Color.Blue)
                {
                    btn[x + 1, y - 1].BackColor = Color.Red;
                    
                }

                // PINTA BOTON INFERIOR IZQUIERDO
                if (btn[x - 1, y + 1] == btn[0, y])
                {
                }
                else if (btn[x - 1, y + 1].BackColor == Color.Blue)
                {
                    
                }

                // PINTA BOTON INFERIOR DERECHO
                if (btn[x + 1, y + 1] == null)
                {
                }
                else if (btn[x + 1, y + 1].BackColor == Color.Blue)
                {
                    btn[x + 1, y + 1].BackColor = Color.Red;
                    
                }
            }

            else
            {
                // JUGADOR 2    -> Computadora IA

                

            }
        }

        //
        public void Jugadas(int x, int y, ref int turno)
        {
            if (turno == 0)
            {
                btn[x, y].BackColor = Color.Red;
                PintarAdyacente(x, y, turno);
                turno = 1;
            }
            else
            {
                btn[x, y].BackColor = Color.Blue;
                PintarAdyacente(x, y, turno);
                turno = 0;
            }
        }

        //Hace visible en el tablero cual es el turno de cada jugador 
        public void turnoJug()
        {
            if (rbtnJR.Checked && rbtnIAA.Checked)
            {
                lblTurno1.Text = txtJug.Text;
                lblTurno2.Text = txtIA.Text;
            }
            else
            {
                if (rbtnIAR.Checked && rbtnJA.Checked)
                {
                    lblTurno1.Text = txtIA.Text;
                    lblTurno2.Text = txtJug.Text;
                }
            }

        }

        //Valida que lo que se ingrese por teclado sea solo letras y no numeros
        private void txtJug_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Nombre ingresado no válido.\nVuelva a Ingresar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        //Valida que lo que se ingrese por teclado sea solo letras y no numeros
        private void txtIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Nombre ingresado no válido.\nVuelva a Ingresar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        //Detecta cual de los dos jugadores es el ganador 
        public void detectWin()
        {
            //Hacemos las validaciones si ambos tienen la misma cantidad de piezas, seria un empate 
            //Si hay mas  fichas del jugador que escogio el color rojo como ficha, entonces gana ese jugador 
            //Si hay mas fichas del jugador que escogio el color azul como ficha, entonces gana ese jugador

        }

        //Se guardan los datos del jugador y su partida
        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\source\repos\equipo5_PLAGA\jugadasHvC.txt", true);

            try
            {
                //Nombre de ambos jugadores 
                escribir.WriteLine("Nombre Jugador 1: " + txtJug.Text);
                escribir.WriteLine("Nombre Jugador 2: " + txtIA.Text);

                //Turno de cada jugador 
                if (rbtnJR.Checked && rbtnIAA.Checked)
                {
                    escribir.WriteLine("Turno 1: " + rbtnJR.Text);
                    escribir.WriteLine("Turno 2: " + rbtnIAA.Text);
                }
                else
                {
                    if (rbtnIAR.Checked && rbtnJA.Checked)
                    {
                        escribir.WriteLine("Turno 1: " + rbtnIAR.Text);
                        escribir.WriteLine("Turno 2: " + rbtnJA.Text);
                    }
                }

                //Cantidad de fichas Rojas

                //Cantidad de fichas Azules 


                escribir.WriteLine();

                MessageBox.Show("Partida Guardada!");

            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                escribir.Close();
            }
        }

        //
        void playerInput()
        {
            
        }

        
    }
}
