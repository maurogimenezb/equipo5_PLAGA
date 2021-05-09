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
        Thread th; // NUEVO
        public TABJuegoCvC()
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
            if (fila == int.Parse(label1.Text))
            {
                fila = 0;
                columna++;
            }

            if (count == int.Parse(label1.Text) * int.Parse(label2.Text))
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
            btn.Text = "0";
        }

        // PARA VOLVER AL MENU PRINCIPAL

        private void btnMP_Click_1(object sender, EventArgs e)
        {
                this.Close();
                th = new Thread(atras);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        private void atras(object obj)
        {
            Application.Run(new MenuPrincipal());
        }

    }
}
