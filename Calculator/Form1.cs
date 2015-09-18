using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double value = 0; //Result value of a calculation
        String operation = ""; //Operation to be performed
        bool operationperformed = false; //Boolean to check if an operation is performed

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        //Method to capture numeric values

        private void btn_click(object sender, EventArgs e)
        {
            //Clearing the 0 default value in the screen
            if ((screen.Text == "0") || (operationperformed))
                screen.Clear();

            operationperformed = false;
            Button button = (Button)sender;

            //Making sure that . is not entered more than once in a number
            if (button.Text == ".")
            {
                if (!screen.Text.Contains("."))
                    screen.Text = screen.Text + button.Text;
            }
            else
            {
                screen.Text = screen.Text + button.Text;
            }

            
            
        }

        /*Method for all operators. We store the operator buttons in the variable operation */
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (value != 0)
            {
                equal.PerformClick();
                operation = button.Text;
                operationperformed = true;
            }
            else
            {
                operation = button.Text;
                value = Double.Parse(screen.Text);
                operationperformed = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void c_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            value = 0;
        }

        //Method for equal button
        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    screen.Text= (value+Double.Parse(screen.Text)).ToString();
                    break;
                case "-":
                    screen.Text = (value - Double.Parse(screen.Text)).ToString();
                    break;
                case "*":
                    screen.Text = (value * Double.Parse(screen.Text)).ToString();
                    break;
                case "/":
                    screen.Text = (value / Double.Parse(screen.Text)).ToString();
                    break;
                default:
                    break;

            }
            value = Double.Parse(screen.Text);
            operation = "";
        }

        //Method for +/- button
        private void button2_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationperformed))
                screen.Clear();

            operationperformed = false;
            Button button = (Button)sender;
            
            screen.Text = screen.Text + "-";

        }

      

        

       
    }
}
