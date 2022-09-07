using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox10.Text = " ";
            textBox9.Text = " ";
            textBox8.Text = " ";
            textBox7.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox4.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox1.Text = " ";

        }
    }
}
