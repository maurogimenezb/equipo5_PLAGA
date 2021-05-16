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
        Thread th; // NUEVO

        public TABJuegoCvH()
        {
            InitializeComponent();
        }

        // PARA TRABAJAR CON LOS BOTONES CREADOS

        void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.Text = " ";

            if (turno)
            {
                btn.BackColor = Color.Red;
                btn.BackColor = Color.Red;
            }
            else
                btn.BackColor = Color.Black;

            turno = !turno;
            btn.Enabled = false; 

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

        private void atras(object obj)
        {
            Application.Run(new Nivel1());
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nivel1 nivel = new Nivel1();
            nivel.Show();

        }

        private void TABJuegoCvH_Load(object sender, EventArgs e)
        {

        }

        private void txtFILA_TextChanged(object sender, EventArgs e)
        {

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
    }
}
