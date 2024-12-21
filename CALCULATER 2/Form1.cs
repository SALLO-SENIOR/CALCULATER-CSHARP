using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATER_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        // variables = memory location 
        double num1;
        double num2;
        double Total_result;
        string option;
        

        private void btn1_Click(object sender, EventArgs e)
        {
            Result.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Result.Text += "2"; // string
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Result.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Result.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Result.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Result.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Result.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Result.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Result.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Result.Text += "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            Result.Text += ".";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            
            num1 += double.Parse(Result.Text);
            Result.Text = "";
            option = "+";
            

                // string => double
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Result.Text);

            if (option == "+")
            {
                Total_result = num1 + num2;
                Result.Text = Total_result.ToString();
                // string <= double
            }

            if (option == "-")
            {
                Total_result = num1 - num2;
                Result.Text = Total_result.ToString();
            }

            if (option == "/")
            {
                Total_result = num1 / num2;
                Result.Text = Total_result.ToString();

            }
            if (option == "*")
            {
                Total_result = num1 * num2;
                Result.Text = Total_result.ToString();
            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(Result.Text);
                Result.Text = "";
                option = "-";
                
            }
            else
            {
                num1 -= double.Parse(Result.Text);
                Result.Text = "";
                option = "-";
                
            }
            
            
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(Result.Text);
                Result.Text = "";
                option = "/";
                
            }
            else
            {
                num1 /= double.Parse(Result.Text);
                Result.Text = "";
                option = "/";
               
            }
           
        }

        private void multip_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(Result.Text);
                Result.Text = "";
                option = "*";
                
            }
            else
            {
                num1 *= double.Parse(Result.Text);
                Result.Text = "";
                option = "*";
               
            }
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            num1=(0);
            num2 = (0);
            option = "";
        }
    }
}
