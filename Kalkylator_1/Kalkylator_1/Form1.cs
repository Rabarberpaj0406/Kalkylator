using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string op;

        

        private void Tal(object sender, MouseEventArgs e)
        {
            kalk_display.Text += ((Button)sender).Text;
        }

      
        private void Operationer(object sender, MouseEventArgs e)
        {
            num1 = Convert.ToDouble(kalk_display.Text);
            kalk_display.Text += ((Button)sender).Text;
            op = ((Button)sender).Text;
            kalk_display.Text = "";
        }
        

        private void CE(object sender, MouseEventArgs e)
        {
            kalk_display.Text = "";
        }

        private void Lika_med(object sender, MouseEventArgs e)
        {   
            num2 = Convert.ToDouble(kalk_display.Text);

            switch(op)
            {
                case "+":
                    num1 = num1 + num2;
                    break;

                case "-":
                    num1 = num1 - num2;
                    break;

                case "*":
                    num1 = num1 * num2;
                    break;

                case "/":
                    num1 = num1 / num2;
                    break;

            }

            kalk_display.Text = num1.ToString();

            if(kalk_display.Text == "0")
            {
                kalk_display.Text = "";
            }
        }
    }

}



