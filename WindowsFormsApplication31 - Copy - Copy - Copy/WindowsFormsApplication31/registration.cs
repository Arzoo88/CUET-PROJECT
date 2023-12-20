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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          Form1 fm= new Form1();
            fm.Show();
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                string gender = "";
                if (radioButton1.Checked == true)
                {
                    gender = "M";
                }
                else if (radioButton2.Checked == true)
                {
                    gender = "F";
                }
                else
                {
                    gender = "";
                }
                string connectionString = "Data Source=(Local);Initial Catalog=CUET;Integrated Security=True";
                SqlConnection connection = new SqlConnection(@connectionString);
                string query = "INSERT INTO personaldetails (candiadte_name,father_name,mother_name,datetimepicker1,gender,contact_no ,emaild_id,adhar_no,address ,choose_password ) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.Date + "','" + gender + "','" + textBox10.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + textBox8.Text + "')";
                string query1 = "INSERT INTO login1 (application_no,password) VALUES('" + textBox4.Text + "','" + textBox8.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command1 = new SqlCommand(query1, connection);
                connection.Open();

                command1.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                MessageBox.Show(" Successfull Registered");
                MessageBox.Show("your user_id '" + textBox4.Text + "' and password '" + textBox8.Text + "'");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select Your Gender");
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
