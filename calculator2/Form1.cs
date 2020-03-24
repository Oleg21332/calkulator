﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public int count;
        public int x;
        public bool zna = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            znak.Text = "";
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            znak.Text = a.ToString() + "+";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            znak.Text = a.ToString() + "*";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            znak.Text = a.ToString() + "-";
        }

        private void division_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            znak.Text = a.ToString() + "/";
        }

        private void enter_Click(object sender, EventArgs e)
        {
            calculate();
            znak.Text = "";
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    int delzero;
                    delzero = int.Parse(textBox1.Text);
                    if (delzero == 0.0)
                        MessageBox.Show("Деление на ноль!");
                    else
                    {
                        b = a / delzero;
                        textBox1.Text = b.ToString();
                    }
                    break;
                case 5:
                    b = Math.Sin(a);
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Cos(a);
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Tan(a);
                    textBox1.Text = b.ToString();
                    break;
                case 8:
                    b = 1 / Math.Tan(a);
                    textBox1.Text = b.ToString();
                    break;
                case 9:
                    b = Math.Pow(a, 2);
                    textBox1.Text = b.ToString();
                    break;
                case 10:
                    b = Math.Exp(a);
                    textBox1.Text = b.ToString();
                    break;
                case 11:
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text)).ToString();

        }

        private void ctg_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Math.Tan(Convert.ToDouble(textBox1.Text))).ToString();

        }

        private void cos_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text)).ToString();

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void exp_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Exp(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();
        }

       

        private void log_Click(object sender, EventArgs e)
        {
         textBox1.Text = Math.Log(Convert.ToDouble(textBox1.Text)).ToString();
        }
    }
}
