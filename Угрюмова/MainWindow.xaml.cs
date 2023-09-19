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

namespace Угрюмова
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

        private void Button_click(object sender, RoutedEventArgs e)
        {
            try
            {
                string rezault;
                double a = double.Parse(a_txt.Text);
                double b = double.Parse(b_txt.Text);
                double c = double.Parse(c_txt.Text);
                double d = Math.Pow(b, 2) - 4 * a * c;
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                rezault = "x 1 = " + x1.ToString() + "; x 2 = " + x2.ToString();
                rezault_lbl.Content = rezault;
            }
            catch
            {
                MessageBox.Show("числа введены неверно\nдля написания числа используются только арабские цифры");
            }
        }
        private void ButtonGoToWindow1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Hide();
            window1.Show();
        }
    }
}
