using System.Windows;
using System.Windows.Controls;
//Very Simple Integer Calculator--- For Learning the WPF graphical subsystem and C#
namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        bool runningTotalMode = false;
        bool alreadyCalculated = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            appendNumber(sender);
        }


        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            operate(sender);
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            operate(sender);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operate(sender);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operate(sender);
        }

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
            calculateValue();
            alreadyCalculated = true;
        }

        private void appendNumber(object sender)
        {
            string content = (sender as Button).Content.ToString();
            if (alreadyCalculated) reset();
            if (!runningTotalMode)
            {
                number1 = (number1 * 10) + long.Parse(content);
                btnTxtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + long.Parse(content);
                btnTxtBox.Text = number2.ToString();
            }
        }

        private void operate(object sender) 
        {
            if (!runningTotalMode)
            {
                runningTotalMode = true;
            }
            else if (alreadyCalculated)
            {
                alreadyCalculated = false;
            }
            else
            {
                calculateValue();
            }

            operation = (sender as Button).Content.ToString();
        }

        private void calculateValue()
        {
            switch (operation)
            {
                case "*": number1 = number1 * number2; break;
                case "+": number1 = number1 + number2; break;
                case "-": number1 = number1 - number2; break;
                case "/": number1 = number1 / number2; break;

            }
            btnTxtBox.Text = number1.ToString();
            number2 = 0;
        }

        private void reset()
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            runningTotalMode = false;
            alreadyCalculated = false;
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (!runningTotalMode)
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            btnTxtBox.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            reset();
            btnTxtBox.Text = "0";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (!runningTotalMode)
            {
                number1 = number1 / 10;
                btnTxtBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 / 10;
                btnTxtBox.Text = number2.ToString();
            }
        }

        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (!runningTotalMode || alreadyCalculated)
            {
                number1 = number1 * -1;
                btnTxtBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * -1;
                btnTxtBox.Text = number2.ToString();
            }

        }
    }
}
