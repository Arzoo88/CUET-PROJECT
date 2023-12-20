using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication31
{
    public partial class documents : Form
    {
        public documents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                // textBox1.Text = open.FileName; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox2.Image = new Bitmap(open.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\STUDENT\Desktop\amrita\dd.wav");
           // player.Play();
            //this.Hide();
            MessageBox.Show("YOUR APPLICATION FORM SUBMITTED SUCCESSFULLY");
            Final fn = new Final();
            fn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}