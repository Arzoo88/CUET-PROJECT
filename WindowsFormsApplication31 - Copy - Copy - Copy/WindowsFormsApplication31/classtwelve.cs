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
    public partial class classtwelve : Form
    {
        public classtwelve()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(Local);Initial Catalog=CUET;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO classtwelve (board_name,school_name,stream,roll_no,total_marks,obtained_marks,datetimepicker1,datetimepicker2) VALUES('" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker1.Value.Date + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Records Inserted Successfully");
            this.Hide();

            bachelor bl = new bachelor();
             bl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classten ct = new classten();
            ct.Show();
        }
    }
}
