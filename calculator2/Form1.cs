using System;
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
        public int c;
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
            textBox1.Text = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(2)).ToString();
        }



        private void log_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void hex_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 16);
        }

        private void oct_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 8);
        }

        private void bin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 2);
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 10);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void three_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void one_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void two_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void four_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void eight_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void squart_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(2)).ToString();
        }

        private void nine_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void zero_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            znak.Text = "";
        }

        private void enter_Click_1(object sender, EventArgs e)
        {
            calculate();
            znak.Text = "";
        }

        private void cos_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void tg_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void ctg_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Math.Tan(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void log_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void division_Click_1(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            znak.Text = a.ToString() + "/";
        }

        private void plus_Click_1(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            znak.Text = a.ToString() + "+";
        }

        private void multiplication_Click_1(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            znak.Text = a.ToString() + "*";
        }

        private void minus_Click_1(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            znak.Text = a.ToString() + "-";
        }

        private void exp_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Math.Exp(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void sqrt_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text.ToLower().ToString();
            textBox3.Text = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text.ToUpper().ToString();
            textBox3.Text = a;
        }

        private void checksim_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text.Length.ToString();
            stroka.Text = $"Длина строки:{a}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text.Replace("чю", "чу");

            textBox3.Text = textBox2.Text.Replace("щю", "щу");

            textBox3.Text = textBox2.Text.Replace("чя", "ча");

            textBox3.Text = textBox2.Text.Replace("щя", "ща");

            textBox3.Text = textBox2.Text.Replace("жы", "жи");

            textBox3.Text = textBox2.Text.Replace("шы", "ши");

            textBox3.Text = textBox2.Text.Replace("чьн", "чн");

            textBox3.Text = textBox2.Text.Replace("чьк", "чк");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //  string a = textBox2.Text;
            // a = textBox2.Text.Substring(7);
            //textBox3.Text = a;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double i = int.Parse(tb4.Text);
                double conver = i * 38;
            double conver1 = conver * 5;
                tb5.Text = " " + conver;
            metr.Text = "Это " + conver1 + " метров ";

            }
        }

       
    }

