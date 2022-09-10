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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static void ConvertCurrency(TextBox rate, TextBox sum, TextBox res)
        {
            bool isNumberRate = Double.TryParse(rate.Text, out double numberRate);
            bool isNumberSum = Double.TryParse(sum.Text, out double numberSum);
            if (isNumberRate && isNumberSum)
            {
                res.Text = (numberRate * numberSum).ToString();
            }
            else if (rate.Text.Trim() != "" && sum.Text.Trim() != "")
            {
                res.Text = "Ошибка! Некорректный формат данных!";
            }
        }
        static void ConvertLength(TextBox value, double coeff, TextBox res)
        {
            bool isNumberValue = Double.TryParse(value.Text, out double numberValue);
            if (isNumberValue)
            {
                res.Text = (numberValue * coeff).ToString();
            }
            else if (value.Text.Trim() != "")
            {
                res.Text = "Ошибка! Некорректный формат данных!";
            }
            else
            {
                res.Text = "";
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConvertCurrency(rateDollar, sumDollar, resDollar);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ConvertCurrency(rateEuro, sumEuro, resEuro);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ConvertCurrency(rateHryvn, sumHryvn, resHryvn);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ConvertCurrency(rateDramas, sumDramas, resDramas);
        }

        private void Inch_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertLength(inch, 0.0254, resInch);
        }

        private void ft_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertLength(ft, 0.3048, resFt);
        }

        private void mil_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertLength(mil, 1609.344, resMil);
        }

        private void verst_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertLength(verst, 1066.8, resVerst);
        }
    }
}
