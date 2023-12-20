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
    public partial class Report : Form
    {
        string cs = "Data Source=(local);Initial Catalog=anjali;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select*from personaldetails", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();  
        }
    }
}
