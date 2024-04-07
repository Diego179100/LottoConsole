//Diego Tordoya
// Calculator form
//2023-04-18

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Calculator : Form
    {
        private string filePath = "Calculator.txt";


        decimal currentValue;
        string op;

        decimal Operand1;
        decimal Operand2;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            currentValue = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = " ";
            op = "+";
            textBox1.ReadOnly = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            currentValue = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            op = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            currentValue = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            op = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            currentValue = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            op = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDecimal(textBox1.Text);

            if (op == "+")
            {
                Operand2 = (currentValue + Operand1);
                textBox1.Text = Convert.ToString(Operand2);
                //currentValue = Operand2;
            }
            if (op == "-")
            {
                Operand2 = (currentValue - Operand1);
                textBox1.Text = Convert.ToString(Operand2);
                //currentValue = Operand2;
            }
            if (op == "*")
            {
                Operand2 = (currentValue * Operand1);
                textBox1.Text = Convert.ToString(Operand2);
                //currentValue = Operand2;
            }
            if (op == "/")
            {
                if (Operand1 == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Operand2 = (currentValue / Operand1);
                    textBox1.Text = Convert.ToString(Operand2);
                    //currentValue = Operand2;

                }



            }
            try
            {
                using (StreamWriter sw = new StreamWriter("Calculator.txt", true))
                {
                    sw.WriteLine(DateTime.Now + ": " + Operand2 + " = " + currentValue + op + Operand1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }
    }
}
