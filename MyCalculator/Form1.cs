using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        double numToOperate = 0.0;
        double result = 0.0;

        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number0.Text;
        }

        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number1.Text;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number2.Text;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number3.Text;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number4.Text;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number5.Text;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number6.Text;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number7.Text;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number8.Text;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + number9.Text;
        }
        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + dot.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        string Operator;
        private void equalSign_Click(object sender, EventArgs e)
        {
            if (Operator == "+")
            {
                result = numToOperate + double.Parse(textBox1.Text);
            }
            else if (Operator == "-")
            {
                result = numToOperate - double.Parse(textBox1.Text);
            }
            else if (Operator == "*")
            {
                result = numToOperate * double.Parse(textBox1.Text);
            }
            else if (Operator == "/")
            {
                result = numToOperate / double.Parse(textBox1.Text);
            }

            textBox1.Text = result.ToString();
        }
        private void plus_Click(object sender, EventArgs e)
        {
            numToOperate = double.Parse(textBox1.Text);
            Operator = "+";
            textBox1.Clear();
        }
        private void minus_Click(object sender, EventArgs e)
        {
            numToOperate = double.Parse(textBox1.Text);
            Operator = "-";
            textBox1.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            numToOperate = double.Parse(textBox1.Text);
            Operator = "*";
            textBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            numToOperate = double.Parse(textBox1.Text);
            Operator = "/";
            textBox1.Clear();
        }

        private void BinaryToInt_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            double resultNum = 0;

            for (int a = 0; a < text.Length; a++)
            {
                if (text[a] == '1')
                {
                    resultNum += Math.Pow(2, text.Length - 1 - a);
                }
            }

            textBox1.Text = resultNum.ToString();
        }

        private void DemicalToBinary_Click(object sender, EventArgs e)
        {
            double numberToTrans = double.Parse(textBox1.Text);
            List<int> returnNumber = new List<int>();

            while (numberToTrans > 1)
            {
                if (numberToTrans % 2 == 0)
                {
                    returnNumber.Insert(0, 0);
                    numberToTrans /= 2;
                }
                else if (numberToTrans % 2 == 1)
                {
                    returnNumber.Insert(0, 1);
                    numberToTrans = Math.Floor((numberToTrans) / 2);
                }
            }
            if (numberToTrans == 1)
            {
                returnNumber.Insert(0, 1);
            }
            textBox1.Text = string.Join("", returnNumber);
        }

        private void LocationNumerals_Click(object sender, EventArgs e)
        {
            double numberToTrans = double.Parse(textBox1.Text);
            List<int> returnNumber = new List<int>();
            string binaryResult;
            List<char> locationNum = new List<char>();

            while (numberToTrans > 1)
            {
                if (numberToTrans % 2 == 0)
                {
                    returnNumber.Insert(0, 0);
                    numberToTrans /= 2;
                }
                else if (numberToTrans % 2 == 1)
                {
                    returnNumber.Insert(0, 1);
                    numberToTrans = Math.Floor((numberToTrans) / 2);
                }
            }
            if (numberToTrans == 1)
            {
                returnNumber.Insert(0, 1);
            }
            binaryResult = string.Join("", returnNumber);

            for (int i = 0; i < binaryResult.Length; i++)
            {
                if (binaryResult[i] == '1')
                {
                    locationNum.Insert(0, (char)(97 + binaryResult.Length - i - 1));
                }
            }
            textBox1.Text = string.Join("", locationNum);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
