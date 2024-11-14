using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5___MiPrimerMenuGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(text1.Text);
            int num2 = Convert.ToInt32(text2.Text);
            resultado.Text = (num1 / num2).ToString();
        }
    }
}
