using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator_11_30_21
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int f = 0;
        char opt = ' ';
        double firstNumber = 0;
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void bp_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1;
            opt = '+';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bs_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1; 
            opt = '-';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bml_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1;
            opt = '*';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bd_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1;
            opt = '/';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text = "";
        }

        private void bac_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            numberInput.Text = "";
            result.Text = "0";
            f = 0;
        }

        private void bdot_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += bdot.Content;
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b1.Content; 
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b2.Content;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b3.Content;

        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b4.Content;

        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b5.Content;

        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b6.Content;

        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b7.Content;

        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b8.Content;

        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b9.Content;

        }

        private void bee_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += bee.Content;

        }

        private void be_Click(object sender, RoutedEventArgs e)
        {
            double secondNumber = 0, answer = 0;

            secondNumber = Convert.ToDouble(numberInput.Text);

            switch (opt)
            {
                case '+':
                    answer = (firstNumber + secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                case '-':
                    answer = (firstNumber - secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                case '*':
                    answer = (firstNumber * secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                case '/':
                    answer = (firstNumber / secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                default:
                    break;
            }
            numberInput.Text = "";

        }

       
    }
}
