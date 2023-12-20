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

namespace WindowsFormsApplication31
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            registration rg = new registration();
            rg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(Local);Initial Catalog=CUET;Integrated Security=True");
            con.Open();
            string str = "Select emaild_id from personaldetails WHERE emaild_id='" + textBox1.Text + "' and choose_password='" + textBox2.Text + "' ";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                classten ct = new classten();
                ct.Show();
               
            }
            else
            {
                MessageBox.Show("invalid user application and password");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
