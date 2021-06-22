using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading; // NUEVO
using System.IO;
using System.Media;

namespace Juego_de_la_Plaga
{
    public partial class TABJuegoHvH : Form
    {
        //Crea el arreglo Bidimensional de botones 
        Button[,] btn = new Button[50, 50];

        // PARA TRABAJAR CON LOS BOTONES CREADOS
        //Designa un turno a cada jugador
        int turno = 0; 

        string jugador1 = " ";
        string jugador2 = " ";

        public TABJuegoHvH()
        { 
            InitializeComponent(); 
        }
   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnMP_Click_1(object sender, EventArgs e)
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

        //Reinicia el tablero 
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            TABJuegoHvH tablero = new TABJuegoHvH();
            tablero.Show();
        }

        //Guarda la partida que el jugador estuvo jugando
        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\source\repos\equipo5_PLAGA\jugadasHvH.txt", true);

            try
            {
                //Nombre de ambos jugadores 
                escribir.WriteLine("Nombre Jugador 1: " + txtJ1.Text);
                escribir.WriteLine("Nombre Jugador 2: " + txtJ2.Text);

                //Turno de cada jugador 
                if (rbtnJ1R.Checked && rbtnJ2A.Checked)
                {
                    escribir.WriteLine("Turno 1: " + rbtnJ1R.Text);
                    escribir.WriteLine("Turno 2: " + rbtnJ2A.Text);
                }
                else
                {
                    if (rbtnJ2R.Checked && rbtnJ1A.Checked)
                    {
                        escribir.WriteLine("Turno 1: " + rbtnJ2R.Text);
                        escribir.WriteLine("Turno 2: " + rbtnJ1A.Text);
                    }
                }

                //Tablero

                /*int Xtxt = int.Parse(txtX.Text);
                int Ytxt = int.Parse(txtY.Text);

                for (int i =0; i<= Xtxt; i++)
                {
                    for(int j=0; i<= Ytxt; j++)
                    {
                        escribir.WriteLine("Tablero: " + btn[i, j]);
                    }
                }*/


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
        
        //Metodo en el cual ambos jugadores ingresan sus respectivos nombres y turos, y se hace posteriormente las validaciones
        private void btnGO_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        //Metodo que valida los txt de cada jugador y los radiobuttons de seleccion de color 
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
                if (txtJ1.Text == txtJ2.Text)
                {
                    MessageBox.Show("Ambos jugadores no pueden llamarse igual!", "Vuelva a Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if ((txtJ1.Text != "") && (txtJ2.Text != "") && (txtJ1.Text != txtJ2.Text))
            {
                if (rbtnJ1R.Checked && rbtnJ2A.Checked)
                {
                    jugador1 = txtJ1.Text;
                    jugador2 = txtJ2.Text;
                    rbtnJ1A.Enabled = false;
                    rbtnJ2R.Enabled = false;
                    PlayGame();
                }
                if (rbtnJ1A.Checked && rbtnJ2R.Checked)
                {
                    jugador1 = txtJ2.Text;
                    jugador2 = txtJ1.Text;
                    rbtnJ1R.Enabled = false;
                    rbtnJ2A.Enabled = false;
                    PlayGame();
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
                    MessageBox.Show("Cada jugador puede escoger una opción", "Vuelva a escoger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Metodo que hace visible el nombre de los jugadores, el marcador, el gboxDimensiones y el gboxFichas 
        private void PlayGame()
        {
            lblJ1.Text = txtJ1.Text;
            lblJ2.Text = txtJ2.Text;
            txtJ1.Visible = false;
            txtJ2.Visible = false;
            gboxMarcador.Text = "Marcador";
            gboxFichas.Visible = true;
            gboxDimensiones.Visible = true;
        }

        //Metodo que agrega botones en forma de un arreglo bidimensional
        private void btnAgregar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Los rangos introducidos para las dimensiones del tablero de juego no son aceptables.\nVuelva a introducir de vuelta","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Se hace visible el turno del jugador
            turnoJug();

            //Hacemos visible el turno del jugador 1
            lblJuega.Text = txtJ1.Text;

        }

        // PARA TRABAJAR CON LOS BOTONES CREADOS
        void Valores(object sender, ref int x, ref int y) // Agarra los valores del click
        {
            //Obtenemos la posicion del boton en el cual se ha echo click, para posteriormente poder trabajar con esas posiciones
            Button b = sender as Button;

            string[] split = b.Name.Split(new Char[] { ' ' });

            x = Convert.ToInt32(split[0]);
            y = Convert.ToInt32(split[1]);
        }

        //Metodo que hace las verificaciones correspondientes acerca de las posiciones en donde el jugador puede pintar su celda,
        //Arriba,Abajo,Derecha,Izquierda,Btn Superior Derecho,Btn Superior Izquierdo,Btn Inferior Derecho,Btn Inferior Izquierdo
        void button_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            bool movimiento = false;

           Valores(sender, ref x, ref y);

            //Columna ->    X , Fila ->    Y

            //PINTAR ADYACENTE

            // JUGADOR 1
            if (turno == 0)
            {

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

                    //Hacemos visible el turno del jugador 2
                    lblJuega.Text = txtJ2.Text;
                }
                else
                {
                    
                   if (btn[x, y].BackColor == Color.Red || btn[x, y].BackColor == Color.Blue)
                   {
                        SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son2.wav");
                        sonido.Play();

                        //SystemSounds.Exclamation.Play();
                        MessageBox.Show("La celda seleccionada ya está ocupada!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
                }

            }
            // JUGADOR 2
            else
            {

               if (btn[x, y].BackColor == Color.DarkGray)
               {
                  // BOTON DERECHO
                  if (btn[x + 1, y] == null)
                  {
                  }
                  else if (btn[x + 1, y].BackColor == Color.Blue)
                  {
                    movimiento = true;
                  }

                  // BOTON IZQUIERDO
                  if (btn[x - 1, y] == btn[0, y])
                  {
                  }
                  else if (btn[x - 1, y].BackColor == Color.Blue)
                  {
                     movimiento = true;
                  }

                  // BOTON ARRIBA
                  if (btn[x, y - 1] == btn[x, 0])
                  {
                  }
                  else if (btn[x, y - 1].BackColor == Color.Blue)
                  {
                    movimiento = true;
                  }

                  // BOTON ABAJO
                  if (btn[x, y + 1] == null)
                  {
                  }
                  else if (btn[x, y + 1].BackColor == Color.Blue)
                  {
                    movimiento = true;
                  }

                  // BOTON SUPERIOR IZQUIERDO
                  if (btn[x - 1, y - 1] == btn[0, 0])
                  {
                  }
                  else if (btn[x - 1, y - 1].BackColor == Color.Blue)
                  {
                    movimiento = true;
                  }

                  // BOTON SUPERIOR DERECHO
                  if (btn[x + 1, y - 1] == btn[x, 0])
                  {
                  }
                  else if (btn[x + 1, y - 1].BackColor == Color.Blue)
                  {
                    movimiento = true;
                  }

                  // BOTON INFERIOR IZQUIERDO
                  if (btn[x - 1, y + 1] == btn[0, y])
                  {
                  }
                  else if (btn[x - 1, y + 1].BackColor == Color.Blue)
                  {
                    movimiento = true;
                  }

                  // BOTON INFERIOR DERECHO
                  if (btn[x + 1, y + 1] == null)
                  {
                  }
                  else if (btn[x + 1, y + 1].BackColor == Color.Blue)
                  {
                    movimiento = true;
                  }

                    //Hacemos visible el turno del jugador 1
                    lblJuega.Text = txtJ1.Text;
                }
               else
               {
                   if(btn[x , y].BackColor == Color.Red || btn[x , y].BackColor == Color.Blue)
                   {
                      SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son2.wav");
                      sonido.Play();

                      //SystemSounds.Exclamation.Play();
                      MessageBox.Show("La celda seleccionada ya está ocupada!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
               }
            }
           
                //Si movimiento es igual a "true" entonces llamamos al metodo "Jugadas"
                if (movimiento == true)
                {
                    Jugadas(x, y, ref turno);
                }
                else
                {

                    //Contadores que van guardando la cantidad de piezas de cada jugador, para a partir de eso definir el ganador 
                    int piezasRojas = 0;
                    int piezasAzules = 0;

                    if (movimiento == false)
                    {
                        SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/game-over-1-gameover.wav");
                        sonido.Play();

                        MessageBox.Show("Se acabaron tus movimientos!","Oh Ohhh", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        int Xtxt = int.Parse(txtX.Text);
                        int Ytxt = int.Parse(txtY.Text);

                        // Recorremos la matriz y vamos recolectando la cantidad de fichas rojas y azules  
                        for (int i = 1; i <= Xtxt; i++)
                        {
                            for (int j = 1; j <= Ytxt; j++)
                            {
                                if(btn[x,y].BackColor == Color.Red)
                                {
                                    piezasRojas = piezasRojas+1;
                                }
                                else
                                {
                                if (btn[x, y].BackColor == Color.Blue)
                                    {
                                        piezasAzules = piezasAzules+1;
                                    }
                                }

                            }

                        }

                        MessageBox.Show("Piezas Rojas:"+piezasRojas);
                        MessageBox.Show("Piezas Azules:" + piezasAzules);

                        //Vamos verificando cual es el jugador con mayor piezas 
                        /*for (int i = 1; i <= Xtxt; i++)
                        {
                            for (int j = 1; j <= Ytxt; j++)
                            {
                                if(piezasRojas == piezasAzules)
                                {
                                    //Empate
                                    MessageBox.Show("¡Es un empate!");
                                }
                                else
                                {
                                    if (piezasRojas > piezasAzules)
                                    {
                                        //Gana el Jugador con Fichas Rojas 
                                        MessageBox.Show("¡ !");
                                    }
                                    else
                                    {
                                        if(piezasAzules > piezasRojas)
                                        {
                                            //Gana el jugador con Fichas Azules
                                            MessageBox.Show("¡ !");
                                        }
                                    }
                                }

                            }

                        }*/

                    }
                }

            /*if ((btn[x + 1, y].BackColor != Color.Red) && (btn[x - 1, y].BackColor != Color.Red) && (btn[x, y - 1].BackColor != Color.Red) && (btn[x, y + 1].BackColor != Color.Red) && (btn[x - 1, y - 1].BackColor == Color.Red) && (btn[x + 1, y - 1].BackColor == Color.Red) && (btn[x - 1, y + 1].BackColor == Color.Red) && (btn[x + 1, y + 1].BackColor == Color.Red))
            {

            }*/
        }

        //Metodo que come fichas del contrario si estan a su alcance
        void PintarAdyacente(int x, int y, int turno)
        {
            // JUGADOR 1
            if (turno == 0)
            {

                // PINTA BOTON DERECHO
                if (btn[x + 1, y] == null)
                {
                }
                else if (btn[x + 1, y].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x + 1, y].BackColor = Color.Red;
                }

                // PINTA BOTON IZQUIERDO
                if (btn[x - 1, y] == btn[0, y])
                {
                }
                else if (btn[x - 1, y].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x - 1, y].BackColor = Color.Red;
                }

                // PINTA BOTON ARRIBA
                if (btn[x, y - 1] == btn[x, 0])
                {
                }
                else if (btn[x, y - 1].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x, y - 1].BackColor = Color.Red;
                }

                // PINTA BOTON ABAJO
                if (btn[x, y + 1] == null)
                {
                }
                else if (btn[x, y + 1].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x, y + 1].BackColor = Color.Red;
                }

                // PINTA BOTON SUPERIOR IZQUIERDO
                if (btn[x - 1, y - 1] == btn[0, 0])
                {
                }
                else if (btn[x - 1, y - 1].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x - 1, y - 1].BackColor = Color.Red;
                }

                // PINTA BOTON SUPERIOR DERECHO
                if (btn[x + 1, y - 1] == btn[x, 0])
                {
                }
                else if (btn[x + 1, y - 1].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x + 1, y - 1].BackColor = Color.Red;
                }

                // PINTA BOTON INFERIOR IZQUIERDO
                if (btn[x - 1, y + 1] == btn[0, y])
                {
                }
                else if (btn[x - 1, y + 1].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x - 1, y + 1].BackColor = Color.Red;
                }

                // PINTA BOTON INFERIOR DERECHO
                if (btn[x + 1, y + 1] == null)
                {
                }
                else if (btn[x + 1, y + 1].BackColor == Color.Blue)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x + 1, y + 1].BackColor = Color.Red;
                }
            }
            // JUGADOR 2
            else
            {

                // PINTA BOTON DERECHO
                if (btn[x + 1, y] == null)
                {
                }
                else if (btn[x + 1, y].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x + 1, y].BackColor = Color.Blue;
                }

                // PINTA BOTON IZQUIERDO
                if (btn[x - 1, y] == btn[0, y])
                {
                }
                else if (btn[x - 1, y].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x - 1, y].BackColor = Color.Blue;
                }

                // PINTA BOTON ARRIBA
                if (btn[x, y - 1] == btn[x, 0])
                {
                }
                else if (btn[x, y - 1].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x, y - 1].BackColor = Color.Blue;
                }

                // PINTA BOTON ABAJO
                if (btn[x, y + 1] == null)
                {
                }
                else if (btn[x, y + 1].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x, y + 1].BackColor = Color.Blue;
                }

                // PINTA BOTON SUPERIOR IZQUIERDO
                if (btn[x - 1, y - 1] == btn[0, 0])
                {
                }
                else if (btn[x - 1, y - 1].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x - 1, y - 1].BackColor = Color.Blue;
                }

                // PINTA BOTON SUPERIOR DERECHO
                if (btn[x + 1, y - 1] == btn[x, 0])
                {
                }
                else if (btn[x + 1, y - 1].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x + 1, y - 1].BackColor = Color.Blue;
                }

                // PINTA BOTON INFERIOR IZQUIERDO
                if (btn[x - 1, y + 1] == btn[0, y])
                {
                }
                else if (btn[x - 1, y + 1].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x - 1, y + 1].BackColor = Color.Blue;
                }

                // PINTA BOTON INFERIOR DERECHO
                if (btn[x + 1, y + 1] == null)
                {
                }
                else if (btn[x + 1, y + 1].BackColor == Color.Red)
                {
                    SoundPlayer sonido = new SoundPlayer("C:/Users/User/source/repos/equipo5_PLAGA/JuegoPlaga/Juego de la Plaga/bin/Debug/Sonidos/son3.wav");
                    sonido.Play();

                    btn[x + 1, y + 1].BackColor = Color.Blue;
                }
            }
        }

        //
        void Jugadas(int x, int y, ref int turno)
        {
            if (turno == 0)
            {
                //Jugador fichas Rojas
                btn[x, y].BackColor = Color.Red;
                PintarAdyacente(x, y, turno);
                turno = 1;
            }
            else
            {
                //Jugador fichas Azul
                btn[x, y].BackColor = Color.Blue;
                PintarAdyacente(x, y, turno);
                turno = 0;
            }
        }

        //Metodo que hace visible el nombre del jugador que juega en el tablero 
        void quienJuega()
        {
            //Hacemos visible el turno del jugador 1
            lblJuega.Text = txtJ2.Text;

            if (turno == 0)
            {
                //Hacemos visible el turno del jugador 1
                lblJuega.Text = txtJ1.Text;
                turno = 1;
            }
            else
            {
                //Hacemos visible el turno del jugador 1
                lblJuega.Text = txtJ2.Text;
                turno = 0;
            }

        }

        //A traves de este metodo se hace visible el turno respectivo de cada jugador 
        private void turnoJug()
        {
            if (rbtnJ1R.Checked && rbtnJ2A.Checked)
            {
                lblTurno1.Text = txtJ1.Text;
                lblTurno2.Text = txtJ2.Text;
            }
            else
            {
                if (rbtnJ2R.Checked && rbtnJ1A.Checked)
                {
                    lblTurno1.Text = txtJ2.Text;
                    lblTurno2.Text = txtJ1.Text;
                }
            }

        }

        //Metodo que detecta cual de los dos jugadores es el ganador
        public void detectWin()
        {
            //Hacemos las validaciones si ambos tienen la misma cantidad de piezas, seria un empate 
            //Si hay mas fichas del jugador que escogio el color rojo como ficha, entonces gana ese jugador 
            //Si hay mas fichas del jugador que escogio el color azul como ficha, entonces gana ese jugador
        }

        //
        void jugadores()
        {
            
        }

        // Metodo que da una condicion de stop al juego
        void stopGame()
        {
            /*if ((btn[x + 1, y] == null))
            {
                
            }*/
        }

        // Inicializa el juego
        public void startGame()
        {
            
        }

        //Valida que lo que se ingrese por teclado sea solo letras y no numeros
        private void txtJ1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Nombre ingresado no válido.\n Vuelva a Ingresar", "Atención!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        //Valida que lo que se ingrese por teclado sea solo letras y no numeros
        private void txtJ2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Nombre ingresado no válido.\n Vuelva a Ingresar", "Atención!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        //Valida que lo que se ingrese por teclado sea solo numeros y no letras
        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No ha ingresado un número!\n Vuelva a Ingresar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        //Valida que lo que se ingrese por teclado sea solo numeros y no letras
        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No ha ingresado un número!\n Vuelva a Ingresar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
