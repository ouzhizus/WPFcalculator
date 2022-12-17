using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace newWPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOne_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "1";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}1";
            }
        }
        public static double Evaluate(string expression)
        {
            return (double)new System.Xml.XPath.XPathDocument
                (new StringReader("<r/>")).CreateNavigator().Evaluate
            ($"number({new
                    System.Text.RegularExpressions.Regex(@"([\+\-\*])")
                .Replace(expression, " ${1} ")
                .Replace("/", " div ")
                .Replace("%", " mod ")})");
        }
        private void ButtonTwo_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "2";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}2";
            }
        }

        private void ButtonThree_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "3";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}3";
            }
        }

        private void ButtonFour_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "4";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}4";
            }
        }

        private void ButtonFive_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "5";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}5";
            }
        }

        private void ButtonSix_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "6";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}6";
            }
        }

        private void ButtonSeven_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "7";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}7";
            }
        }

        private void ButtonEight_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "8";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}8";
            }
        }

        private void ButtonNine_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "9")
            {
                ResultLabel.Content = "1";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}9";
            }
        }

        private void ButtonZero_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}0";
            }
        }

        private void Finalize_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString()!.Contains(','))
            {
                double result = Evaluate(ResultLabel.Content.ToString()!);
                ResultLabel.Content = "hello";
            }
            else if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "Wrong input";
            }
            else if (ResultLabel.Content.ToString() != String.Empty)
            {
                double result = Evaluate(ResultLabel.Content.ToString()!);
                ResultLabel.Content = $"{result}";
            }
        }

        private void ButtonAC_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0" || ResultLabel.Content.ToString() == String.Empty)
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = "0";
            }
        }

        private void ButtonPlus_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}+";
            }
        }

        private void ButtonMinus_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}-";
            }
        }

        private void ButtonMultiply_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}*";
            }
        }

        private void ButtonDivide_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}/";
            }
        }

        private void LeftBracket_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "(";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}(";
            }
        }

        private void RightBracket_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content})";
            }
        }

        private void ButtonKoma_OnClick(object sender, RoutedEventArgs e)
        {
            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = "0";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}.";
            }
        }
    }
}