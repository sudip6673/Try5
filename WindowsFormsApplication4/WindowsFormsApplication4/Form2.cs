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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91954\Documents\user123.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO stu123 (userid1,password) values ('"+t1.Text+"','"+t2.Text +"')";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            t2.Text = " ";
            t1.Text = " ";

            this.Hide();
            MessageBox.Show("Successfully Login !!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Form4 f4 = new Form4();
            f4.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
