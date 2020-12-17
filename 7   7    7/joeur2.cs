using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7___7____7
{
    public partial class joeur2 : Form
    {
        public joeur2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                if (progressBar1.Value == 30)
                {
                    textBox1.Clear();
                    Random x1 = new Random();
                    textBox1.Text = x1.Next(5, 7).ToString();
                }
                if (progressBar1.Value == 60)
                {
                    textBox2.Clear();
                    Random x2 = new Random();
                    textBox2.Text = x2.Next(5, 7).ToString();
                }
                if (progressBar1.Value == 90)
                {
                    textBox3.Clear();
                    Random x3 = new Random();
                    textBox3.Text = x3.Next(5, 7).ToString();
                }
                progressBar1.Value += 30;
            }
            else
            {
                timer1.Stop();
                if (textBox1.Text == textBox2.Text && textBox1.Text == textBox3.Text)
                {
                    Winner x = new Winner();
                    this.Hide();
                    x.Show();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Joeur1 x = new Joeur1();
            x.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void joeur2_Load(object sender, EventArgs e)
        {
            label1.Text = Program.joeur2;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
