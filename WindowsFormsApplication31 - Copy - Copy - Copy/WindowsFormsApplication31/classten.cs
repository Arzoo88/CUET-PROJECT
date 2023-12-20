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
    public partial class classten : Form
    {
        public classten()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(Local);Initial Catalog=CUET;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO ten (board_name,school_name,roll_no,total_marks,obtained_marks,datetimepicker1,datetimepicker2) VALUES('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker1.Value.Date + "')";
            SqlCommand command = new SqlCommand(query, connection);
            //try
            //{
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Records Inserted Successfully");
                this.Hide();
                classtwelve cw = new classtwelve();
                cw.Show();

            //}
            //catch ()
            //{
            //   // Console.WriteLine("Error Generated. Details: " + e.ToString());
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
    }
}
