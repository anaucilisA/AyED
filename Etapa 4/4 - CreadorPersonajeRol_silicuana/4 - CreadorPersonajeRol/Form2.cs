using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4___CreadorPersonajeRol
{
    public partial class Form2 : Form
    {
        public Form2(string recepcionTexto1, string recepcionTexto2, string recepcionTexto3, bool checkeadoBox1, bool checkeadoBox2, bool checkeadoBox3)
        {
            InitializeComponent();
            texto1.Text = recepcionTexto1;
            texto2.Text = recepcionTexto2;
            texto3.Text = recepcionTexto3;
            checkBox1.Checked = checkeadoBox1;
            checkBox2.Checked = checkeadoBox2;
            checkBox3.Checked = checkeadoBox3;

            // Hacer los CheckBox no editables
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            // hacer que los texbox no sean editables
            texto1.ReadOnly = true;
            texto2.ReadOnly = true;
            texto3.ReadOnly = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
