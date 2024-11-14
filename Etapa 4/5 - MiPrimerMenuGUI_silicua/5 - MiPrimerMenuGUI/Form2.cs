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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void Sumar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            resultado.Text = (num1 + num2).ToString();
           
        }
    }
}
