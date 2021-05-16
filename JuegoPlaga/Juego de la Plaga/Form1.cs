using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Blue;
        }
    }
}
