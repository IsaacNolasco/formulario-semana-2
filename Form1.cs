using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2_semana2_escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Carin Sanchez";
            label2.Text = "Xiomara Machado";
            label3.Text = "Patricia Hernandez";
            label4.Text = "Elias Gevarra";
            label5.Text = " Isaac Nolasco";
            label6.Text = " Cindy Romero ";
            label7.Text = "Farid Claros";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
