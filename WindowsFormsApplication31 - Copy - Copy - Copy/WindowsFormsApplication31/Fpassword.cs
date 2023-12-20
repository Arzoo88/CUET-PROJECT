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
    public partial class Fpassword : Form
    {
        public Fpassword()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration rg = new registration();
            rg.Show(); 
            string connectionString = "Data Source=(Local);Initial Catalog=anjali;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "update personaldetails set choose_password='"+textBox3.Text+"' where emaild_id='"+textBox1.Text+"'";
             SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            command.ExecuteNonQuery();
             MessageBox.Show(" Update Successfully");
             textBox1.Text = "";
             textBox2.Text = "";
             textBox3.Text = "";
        }
    }
}
