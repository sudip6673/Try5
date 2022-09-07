using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace WindowsFormsApplication4
{
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91954\Documents\user123.mdf;Integrated Security=True;Connect Timeout=30");
        public Form8()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO stock (date,price,pieces) values ('" +dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            //dateTimePicker1.Text = " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
             this.Hide();
            MessageBox.Show("Successfully added !!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Form8 f8 = new Form8();
            f8.Show();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
