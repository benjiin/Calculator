using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string input;
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        private string number1;
        public string Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        private string number2;
        public string Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
        private char opearatorSign = 'c';
        public char OperatorSign
        {
            get { return opearatorSign; }
            set { opearatorSign = value; }
        }
        private double result;
        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        


        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            //0
            if (textbox2.Text != "0")
            {
                textbox2.Inlines.Add("0");
                input += 0;
                //if (textbox2.Text[0] == 0)
                //{
                //    textbox2.Text.Remove(0);
                //}
                // WIE KEINE NULL VOR DER ZAHL SCHREIBEN
            }

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            //1
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            //2
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            //3
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //4
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //5
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //6
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //7
            textbox2.Inlines.Add("7");
            input += 7;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //8
            textbox2.Inlines.Add("8");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //9
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            //C
            textbox2.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //+
            number1 = input;
            opearatorSign = '+';
            input = string.Empty;
            textbox2.Text = string.Empty;

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            //-
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            ///
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            //X
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //=
            number2 = input;
            double num1, num2;
            double.TryParse(number1, out num1);
            double.TryParse(number2, out num2);

            if (opearatorSign == '+')
            {
                result = num1 + num2;
                textbox2.Text = result.ToString();
            }

        }

    }
}
