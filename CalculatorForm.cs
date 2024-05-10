using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {

        private double currentNumber = 0;
        private double previousNumber = 0;
        private char operation = '\0';
        private bool isNewNumber = true;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        //Added methods
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text;

            if (DisplayNumTextBox.Text == "0" || isNewNumber)
            {
                DisplayNumTextBox.Text = buttonText;
                isNewNumber = false;
            }
            else
            {
                DisplayNumTextBox.Text += buttonText;
            }
        }


        private void PerformOperation()
        {
            double current = double.Parse(DisplayNumTextBox.Text);

            switch (operation)
            {
                case '+':
                    currentNumber += current;
                    break;
                case '-':
                    currentNumber -= current;
                    break;
                case '*':
                    currentNumber *= current;
                    break;
                case '/':
                    if (current != 0)
                    {
                        currentNumber /= current;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return; // Exit the method if dividing by zero is attempted
                    }
                    break;
                default:
                    currentNumber = current; 
                    break;
            }

            DisplayNumTextBox.Text = currentNumber.ToString(); // Update the display with the result
            isNewNumber = true; // Reset isNewNumber 
            operation = '\0'; // Clear the operation after performing the calculation


        }



        private void OperationButton_Click(object sender, EventArgs e)
            {
                Button button = sender as Button;
                char newOperation = button.Text[0];

                if (!isNewNumber)
                {
                    PerformOperation();
                }

                isNewNumber = true;
                operation = newOperation;
                previousNumber = double.Parse(DisplayNumTextBox.Text);
            }




            private void Addbtn_Click(object sender, EventArgs e)
            {
                    OperationButton_Click(sender, e);
            }

            private void Subtractbtn_Click(object sender, EventArgs e)
            {
                OperationButton_Click(sender, e);
            }

            private void Multiplybtn_Click(object sender, EventArgs e)
            {
                OperationButton_Click(sender, e);
            }

            private void DivideBtn_Click(object sender, EventArgs e)
            {
                OperationButton_Click(sender, e);
            }

            private void Equalbtn_Click(object sender, EventArgs e)
            {
                 PerformOperation();
                isNewNumber = true;

        }

            private void Periodbtn_Click(object sender, EventArgs e)
            {
                     if (!DisplayNumTextBox.Text.Contains("."))
                     {
                            DisplayNumTextBox.Text += ".";
                     }
            }

            private void Zerobtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void Threebtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void Twobtn_Click(object sender, EventArgs e)
            {
                NumberButton_Click(sender, e);
            }

            private void Onebtn_Click(object sender, EventArgs e)
            {
               NumberButton_Click(sender, e);

            }

            private void Fourbtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void Fivebtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void Sixbtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void Sevenbtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void Eightbtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void Ninebtn_Click(object sender, EventArgs e)
            {
                    NumberButton_Click(sender, e);
            }

            private void DisplayNumTextBox_TextChanged(object sender, EventArgs e)
            {

            }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            DisplayNumTextBox.Text = "0";
            currentNumber = 0;
            previousNumber = 0;
            operation = '\0';
            isNewNumber = true;
        }
    }
}
