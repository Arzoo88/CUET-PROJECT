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
    public partial class bachelor : Form
    {
        public bachelor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(Local);Initial Catalog=CUET;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO bachelors (course_name,university_name,college_name,roll_no,total_marks,obtained_marks,datetimepicker1,datetimepicker2) VALUES('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Records Inserted Successfully");
            this.Hide();


     
            documents dc = new documents();
            dc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classtwelve cw = new classtwelve();
            cw.Show();
        }
    }
}
