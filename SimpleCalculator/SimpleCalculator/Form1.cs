using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string currentInput = ""; // Variable to store the current input
        private double result = 0; // Variable to store the result
        private char operation; // Variable to store the current operation

        public Form1()
        {
            InitializeComponent();
        }

        // Button click event handlers for numbers (0-9) and dot
        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text; // Append the clicked button's text to the current input
            textBox1.Text = currentInput; // Update the textbox
        }

        // Button click event handler for clear (AC)
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = ""; // Clear the current input
            result = 0; // Reset the result
            textBox1.Text = ""; // Clear the textbox
        }

        // Button click event handler for operators (+, -, *, /)
        private void OperatorButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            operation = button.Text[0]; // Get the operation (+, -, *, /)
            result = double.Parse(currentInput); // Store the current input as the first operand
            currentInput = ""; // Clear the current input
        }

        // Button click event handler for equals (=)
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondOperand = double.Parse(currentInput); // Get the second operand
            switch (operation)
            {
                case '+':
                    result += secondOperand; // Addition
                    break;
                case '-':
                    result -= secondOperand; // Subtraction
                    break;
                case '*':
                    result *= secondOperand; // Multiplication
                    break;
                case '/':
                    // Check for division by zero
                    if (secondOperand == 0)
                    {
                        MessageBox.Show("Error: Division by zero.");
                        return;
                    }
                    result /= secondOperand; // Division
                    break;
            }
            textBox1.Text = result.ToString(); // Display the result in the textbox
            currentInput = result.ToString(); // Store the result as the current input
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberButtonClick(sender, e);
        }

        private void dot_Click(object sender, EventArgs e)
        {
            // Check if a dot has already been added to the current input
            if (!currentInput.Contains("."))
            {
                currentInput += "."; // Append a dot to the current input
                textBox1.Text = currentInput; // Update the textbox
            }

        }

        private void equals_Click(object sender, EventArgs e)
        {
            btnEquals_Click(sender, e);
        }

        private void devide_Click(object sender, EventArgs e)
        {
            OperatorButtonClick(sender, e);
        }

        private void times_Click(object sender, EventArgs e)
        {
            OperatorButtonClick(sender, e);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            OperatorButtonClick(sender, e);
        }
        

        private void plus_Click(object sender, EventArgs e)
        {
            OperatorButtonClick(sender, e);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }
    }
}
