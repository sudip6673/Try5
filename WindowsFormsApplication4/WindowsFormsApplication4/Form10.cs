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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\91954\Documents\user123.mdf;Integrated Security=True;Connect Timeout=30");
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user123DataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.user123DataSet.customer);
            /*con.Open();
            SqlCommand cmdname = new SqlCommand("SELECT cname FROM customer ", con);
            SqlDataReader dr = cmdname.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text.Add(dr["cname"]);
                 textBox2.Text.Add(dr["cname"]);
                 textBox3.Text.Add(dr["mobile"]);
                 textBox4.Text.Add(dr["address"]);
                 textBox5.Text.Add(dr["dpayment"]);

            }
            con.Close();*/
        }
    }
}
