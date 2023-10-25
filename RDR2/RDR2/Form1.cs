using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rastgele = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(7,11);
            pictureBox2.Left += rastgele.Next(7,11);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(7,11);


            if (pictureBox1.Left + pictureBox1.Width  >= label6.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 numaralı at yarışı kazandı.");

            }


            if (pictureBox2.Left + pictureBox2.Width >= label6.Left)
            {

                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at yarışı kazandı.");

            }

            if (pictureBox3.Left + pictureBox3.Width >= label6.Left)
            {

                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at yarışı kazandı. ");

            }



            if (pictureBox1.Left > pictureBox2.Left  && pictureBox1.Left > pictureBox3.Left)
            {

                label7.Text = "1 numaralı at önde gidiyor!!!";



            }

            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {



                label7.Text = "2 numaralı at liderliği ele aldı.";


            }

            if (pictureBox3.Left > pictureBox1.Left  && pictureBox3.Left > pictureBox2.Left)
            {

                label7.Text = "3 numaralı at rakiplerini geride bıraktı.";



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(2,25);
            pictureBox2.Location = new Point(2,111);
            pictureBox3.Location = new Point(2,195);
        }
    }
}
