using System;
using System.Windows;
using System.Windows.Controls;

namespace zadanie4
{
    public partial class MainWindow : Window
    {
        private double leftOperand = 0;
        private double lastOperand = 0;

        private string currentOperation = "";
        private bool waitingForNextNumber = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (Display.Text == "0" || waitingForNextNumber)
            {
                Display.Text = button.Content.ToString();
                waitingForNextNumber = false;
            }
            else
            {
                Display.Text += button.Content.ToString();
            }
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
            }
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            leftOperand = double.Parse(Display.Text);
            currentOperation = button.Content.ToString();

            waitingForNextNumber = true;
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            leftOperand = double.Parse(Display.Text);
            currentOperation = "^";

            waitingForNextNumber = true;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double rightOperand;

            if (waitingForNextNumber)
            {
                rightOperand = lastOperand;
            }
            else
            {
                rightOperand = double.Parse(Display.Text);
                lastOperand = rightOperand;
            }

            double result = leftOperand;

            switch (currentOperation)
            {
                case "+":
                    result = leftOperand + rightOperand;
                    break;

                case "-":
                    result = leftOperand - rightOperand;
                    break;

                case "*":
                    result = leftOperand * rightOperand;
                    break;

                case "/":
                    result = leftOperand / rightOperand;
                    break;

                case "^":
                    result = Math.Pow(leftOperand, rightOperand);
                    break;
            }

            Display.Text = result.ToString();

            leftOperand = result;
            waitingForNextNumber = true;
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            double number;

            if (waitingForNextNumber)
                number = lastOperand;
            else
                number = double.Parse(Display.Text);

            double result = Math.Sqrt(number);

            Display.Text = result.ToString();

            lastOperand = number;
            leftOperand = result;

            waitingForNextNumber = true;
        }

        private void Inverse_Click(object sender, RoutedEventArgs e)
        {
            double number;

            if (waitingForNextNumber)
                number = lastOperand;
            else
                number = double.Parse(Display.Text);

            double result = 1.0 / number;

            Display.Text = result.ToString();

            lastOperand = number;
            leftOperand = result;

            waitingForNextNumber = true;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";

            leftOperand = 0;
            lastOperand = 0;

            currentOperation = "";

            waitingForNextNumber = false;
        }
    }
}