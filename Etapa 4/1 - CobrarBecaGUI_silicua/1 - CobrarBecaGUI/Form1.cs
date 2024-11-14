using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1___CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            year = int.Parse(Edad.Text);
            if (year >= 19)
            {
                if(Ingresos.Text == "Entre 0 - 50,000")
                {
                    MessageBox.Show("No cumples con los requisitos para cobrar la beca");
                }
                else if((Ingresos.Text == "50,001 - 100,000") || (Ingresos.Text == "100,001 - 200,000") ||(Ingresos.Text == "Más de 200,000"))
                {
                    MessageBox.Show("¡Felicidades! Puedes cobrar la beca");
                }
                else
                {
                    MessageBox.Show("seleccione unas de las opciones");
                }
            }
            else
            {
                MessageBox.Show("el usuario no cumple con la edad requerida");
            }

        }
        
    }
}
