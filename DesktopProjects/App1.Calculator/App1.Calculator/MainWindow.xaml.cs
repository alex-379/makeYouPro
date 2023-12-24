using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace App1.Calculator
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private double _previusNumber = 0;
        private string _operation ="";

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            _previusNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = $"{((Button)sender).Content}";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            _previusNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = $"{((Button)sender).Content}";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            _previusNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = $"{((Button)sender).Content}";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            _previusNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = $"{((Button)sender).Content}";
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            if (_operation == "+")
            {
                result = _previusNumber + Convert.ToDouble(TextBoxMain.Text);
                TextBoxMain.Text = $"{result}";
            }
            else if (_operation == "-")
            {
                result = _previusNumber - Convert.ToDouble(TextBoxMain.Text);
                TextBoxMain.Text = $"{result}";
            }
            else if (_operation == "*")
            {
                result = _previusNumber * Convert.ToDouble(TextBoxMain.Text);
                TextBoxMain.Text = $"{result}";
            }
            else
            {
                if (Convert.ToDouble(TextBoxMain.Text) == 0)
                {
                    //throw new ArgumentException("Деление на ноль невозможно");
                    TextBoxMain.Text = "Деление на ноль невозможно";
                    TextBoxMain.FontSize = 40;
                }
                else
                {
                    result = _previusNumber / Convert.ToDouble(TextBoxMain.Text);
                    TextBoxMain.Text = $"{result}";
                }
            }
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMain.Text = "";
        }

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMain.Text += ((Button)sender).Content;
        }

        //private double _result;
        //private bool _isOperation;

        //private void ButtonOperation_Click(object sender, RoutedEventArgs e)
        //{
        //    string operation = $"{((Button)sender).Content}";
        //    if (operation == "+")
        //    {
        //        _result += Convert.ToDouble(TextBoxMain.Text);
        //    }
        //    else if (operation == "-")
        //    {
        //        _result -= Convert.ToDouble(TextBoxMain.Text);
        //    }
        //    else if (operation == "*")
        //    {
        //        _result *= Convert.ToDouble(TextBoxMain.Text);
        //    }
        //    else if (operation == ":")
        //    {
        //        _result /= Convert.ToDouble(TextBoxMain.Text);
        //    }
        //    else
        //    {
        //        _result
        //    }
        //    TextBoxMain.Text = $"{_result}";
        //    _isOperation = true;
        //}

        //private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        //{
        //    string operation = $"{((Button)sender).Content}";
        //    double result = _previusNumber + Convert.ToDouble(TextBoxMain.Text);
        //    TextBoxMain.Text = $"{result}";
        //    _isOperation = true;
        //}

        //private void ButtonReset_Click(object sender, RoutedEventArgs e)
        //{
        //    TextBoxMain.Text = "";
        //}

        //private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        //{
        //    if (_isOperation)
        //    {
        //        TextBoxMain.Clear();
        //        TextBoxMain.Text += ((Button)sender).Content;
        //        _isOperation = false;
        //    }
        //    else
        //    {
        //        TextBoxMain.Text += ((Button)sender).Content;
        //    }
        //}
    }
}