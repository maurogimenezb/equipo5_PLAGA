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

        int count = 1;
        int fila = 1;
        int columna = 1;

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= fila; i++)
            {
                Button b = new Button();
                b.Text = count.ToString();
                b.Name = count.ToString();
                b.Size = new Size(35, 35);
                b.Location = new Point(40 * (i + 1), 40 * columna);
                Controls.Add(b);
                b.Click += new EventHandler(this.button_Click); // NUEVO

            }
            if (fila == int.Parse(txtFILA.Text))
            {
                fila = 0;
                columna++;
            }

            if (count == int.Parse(txtFILA.Text) * int.Parse(txtCOLUMNA.Text))
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
    }
}
