using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string FirstNumber, SecondNumber;
        char action = ' ';
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button_7(object sender, EventArgs e)
        {
            MathematicalOperations(7);
        }
        private void Button_8(object sender, EventArgs e)
        {
            MathematicalOperations(8);
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            MathematicalOperations(9);
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            MathematicalOperations(6);
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            MathematicalOperations(5);
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            MathematicalOperations(4);
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            MathematicalOperations(3);
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            MathematicalOperations(2);
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            MathematicalOperations(1);
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            MathematicalOperations(0);
        }
        private void button_division_Click(object sender, EventArgs e)
        {
            action = '/';
            textBox1.Text = "";
        }
        private void button_multiplication_Click(object sender, EventArgs e)
        {
            action = '*';
            textBox1.Text = "";
        }
        private void button_addition_Click(object sender, EventArgs e)
        {
            action = '+';
            textBox1.Text = "";
        }
        private void button_subtraction_Click(object sender, EventArgs e)
        {
            action = '-';
            textBox1.Text = "";
        }
        private void button_results_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case('+'):
                    textBox1.Text = (int.Parse(FirstNumber) + int.Parse(SecondNumber)).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (int.Parse(FirstNumber) - int.Parse(SecondNumber)).ToString();
                    break;
                case ('*'):
                    textBox1.Text = (int.Parse(FirstNumber) * int.Parse(SecondNumber)).ToString();
                    break;
                case ('/'):
                    textBox1.Text = (int.Parse(FirstNumber) / int.Parse(SecondNumber)).ToString();
                    break;
            }

            FirstNumber = "";
            SecondNumber = "";
            action = ' ';
        }

        private void MathematicalOperations(int number)
        {
            if (action == ' ')
            {
                FirstNumber += number;
                textBox1.Text = FirstNumber;
            }
            else
            {
                SecondNumber += number;
                textBox1.Text = SecondNumber;
            }
        }

        
    }
}
