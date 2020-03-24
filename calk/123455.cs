using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int a;
        public int f;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Result.Text = "0";
            znak.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            znak.Text = "/";
            a = 4;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            znak.Text = "*";
            a = 3;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            znak.Text = "-";
            a = 2;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            znak.Text = "+";
            a = 1;
        }

    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                Result.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (a == 2)
            {
                Result.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (a == 3)
            {
                Result.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (a == 4)
            {
                Result.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void result_Click(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
