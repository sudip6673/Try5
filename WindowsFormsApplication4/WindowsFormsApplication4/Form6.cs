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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91954\Documents\user123.mdf;Integrated Security=True;Connect Timeout=30");
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
              textBox4.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO customer (nname,cname,mobile,address,dpayment) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox5.Text = " ";
            textBox4.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
 

            this.Hide();
            MessageBox.Show("Successfully saved !!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand cmdname = new SqlCommand("SELECT nname FROM customer ", con);
            SqlDataReader dr = cmdname.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr["nname"].ToString();
               /* textBox2.Text.Add(dr["cname"]);
                textBox3.Text.Add(dr["mobile"]);
                textBox4.Text.Add(dr["address"]);
                textBox5.Text.Add(dr["dpayment"]);*/

          /*  }
            con.Close();*/
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }
    }
}
