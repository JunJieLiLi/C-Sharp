using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************************************************************
 * This is a calculator application using C#. It contains the sdandard version and the scienctific version
 * author: Pablo Li (JunJie Li)
***************************************************************************************************************/

namespace ca
{
    public partial class Form1 : Form
    {
        double result_value = 0;              // stores the result value
        String Operand = "";                  // stores the operand sign
        bool Is_enter_value = false;          // check if the operand is clicked
       
        public Form1()
        {
            InitializeComponent();
        }

        /*this method is the size for the standard screen*/
        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 271;
            textBox1.Width = 230;

        }

        /*this method is the size for scientific screen*/
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 523;
            textBox1.Width = 482;
        }

        /*this method shows the initial load screen*/
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 271;
            textBox1.Width = 230;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0")|| (Is_enter_value)){              //check if 0 is presented, if it does, then clear 0
                textBox1.Text = "";                                    // Result is the textbox of the culculator
            }

            Is_enter_value = false;                                    // make the operand false so that we know the a number has been clicked
            Button button_num = (Button)sender;                        // cast the sender to Button button object to get the info

            if (button_num.Text == ".")                                // check if number cotain a decimal
            {
                if (!textBox1.Text.Contains("."))                      // if the result contains no decimal , then show the result
                {
                    textBox1.Text = textBox1.Text + button_num.Text;
                }
            }
            else {
                textBox1.Text = textBox1.Text + button_num.Text;
            }
        }

        /*this method clear the content to 0 for CE button*/
        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        /*this method clear the content to 0 for C button*/
        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        /*this method reduce one digit back for < button*/
        private void Shieft_Left_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)                                               // check if the length of textBox1.Text is greater than 0
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);      // if length if greater than o, then reduce reduce one digit to the right
            }
            else if (textBox1.Text=="") {                                               // if the textBox1.Text is nothing ,then prints 0 
                textBox1.Text = "0";
            }
        }

        /*this method is the click event for "+ - * and /" operation */
        private void Arithmitic_click(object sender, EventArgs e)                        
        {
            Button button_num = (Button)sender;

            if (result_value != 0)
            {
                Equal.PerformClick();
                Operand = button_num.Text;
                result_value = double.Parse(textBox1.Text);
                label1.Text = result_value + " " + Operand;
                Is_enter_value = true;
            }

            else
            {
                Operand = button_num.Text;
                result_value = double.Parse(textBox1.Text);
                Is_enter_value = true;
                label1.Text = result_value + " " + Operand;
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            if (Operand == "+") {
                textBox1.Text = (result_value + double.Parse(textBox1.Text)).ToString();
            }

            else if (Operand == "-") {
                textBox1.Text = (result_value + double.Parse(textBox1.Text)).ToString();
            }

            else if (Operand == "*")
            {
                textBox1.Text = (result_value * double.Parse(textBox1.Text)).ToString();
            }

            else if (Operand == "/")
            {
                textBox1.Text = (result_value /double.Parse(textBox1.Text)).ToString();
            }
            result_value = double.Parse(textBox1.Text);
            label1.Text = "";
        }

        /*this method is the click event for "Pie" operation */
        private void Pie_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159";
        }

        /*this method is the click event for "LOG" operation */
        private void Log_Click(object sender, EventArgs e)
        {
            double temp = Math.Log10(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
            
        }

        /*this method is the click event for "Square root" operation */
        private void Sqrt_Click(object sender, EventArgs e)
        {
            double temp = Math.Sqrt(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("Sqrt" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
        }

        /*this method is the click event for Sinh" operation */
        private void SinH_Click(object sender, EventArgs e)
        {
            double temp = Math.Sinh(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("sinh" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
        }

        /*this method is the click event for "Cosh" operation */
        private void Cosh_Click(object sender, EventArgs e)
        {
            double temp = Math.Cosh(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("cosh" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
        }

        /*this method is the click event for "Tanh" operation */
        private void Tanh_Click(object sender, EventArgs e)
        {
            double temp = Math.Tanh(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("tanh" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
        }

        /*this method is the click event for "Sin" operation */
        private void Sin_Click(object sender, EventArgs e)
        {
            double temp = Math.Sin(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
        }

        /*this method is the click event for "Cos" operation */
        private void Cos_Click(object sender, EventArgs e)
        {
            double temp = Math.Cos(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("cos" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
        }

        /*this method is the click event for "Tan" operation */
        private void Tan_Click(object sender, EventArgs e)
        {
            double temp = Math.Tan(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("tan" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);
        }

        /*this method is the click event for "Bin" operation */
        private void Bin_Click(object sender, EventArgs e)
        {
            label1.Text = System.Convert.ToString("bin" + "("+textBox1.Text+")");
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text), 2);
        }

        /*this method is the click event for "Hex" operation */
        private void Hex_Click(object sender, EventArgs e)
        {
            label1.Text = System.Convert.ToString("hex" + "(" + textBox1.Text + ")");
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text), 16);
        }

        /*this method is the click event for "Oct" operation */
        private void Oct_Click(object sender, EventArgs e)
        {
            label1.Text = System.Convert.ToString("oct" + "(" + textBox1.Text + ")");
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text), 8);
        }

        /*this method is the click event for "Dec" operation */
        private void Dec_Click(object sender, EventArgs e)
        {
            label1.Text = System.Convert.ToString("oct" + "(" + textBox1.Text + ")");
            textBox1.Text = System.Convert.ToString(int.Parse(textBox1.Text));
        }

        /*this method is the click event for "to power of 2" operation */
        private void Square_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            label1.Text = Convert.ToString(textBox1.Text + "^2");
            textBox1.Text = Convert.ToString(temp * temp); 
        }

        /*this method is the click event for "to power of 3" operation */
        private void Cube_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            label1.Text = Convert.ToString(textBox1.Text + "^3");
            textBox1.Text = Convert.ToString(temp * temp*temp);
        }

        /*this method is the click event for "1/x" operation */
        private void OneOverX_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            double temp2 = 1 / temp;
            label1.Text = Convert.ToString("1/" + textBox1.Text);
            textBox1.Text = Convert.ToString(temp2);
        }

        /*this method is the click event for "ln" operation */
        private void Nature_Log_Click(object sender, EventArgs e)
        {
            double temp = Math.Log(double.Parse(textBox1.Text));
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            textBox1.Text = System.Convert.ToString(temp);

        }

        /*this method is the click event for "ln" operation */
        private void module_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text)/100;
            label1.Text = System.Convert.ToString(textBox1.Text+"%");
            textBox1.Text = Convert.ToString(temp);
        }

        /*this method is the click event for "Mod" operation */
        private void Mod_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            label1.Text = System.Convert.ToString(textBox1.Text+"mod "); 
            textBox1.Text = (result_value % double.Parse(textBox1.Text)).ToString();
        }

        /*this method is the click event for "EXP" operation */
        private void EXP_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString((textBox1.Text) + " exp");
            textBox1.Text = Math.Exp(temp * Math.Log(result_value * 4)).ToString();
        }

      
    }
}
