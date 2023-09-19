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
using System.Windows.Shapes;

namespace Угрюмова
{
    /// <summary>
    /// Логика взаимодействия для Navigation.xaml
    /// </summary>
    public partial class Navigation : Window
    {
        public Navigation()
        {
            InitializeComponent();
        }
        private void ButtonGoToRegistrationPage_Click(object sender, RoutedEventArgs e)
        {
            Page1 page = new Page1();
            MainFrame.Navigate(page);

        }
        private void ButtonGoToCatsPage_Click(object sender, RoutedEventArgs e)
        {
            Page2 page = new Page2();
            MainFrame.Navigate(page);
        }
        private void ButtonGoBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainFrame.GoBack();
            }
            catch
            {

            }
        }
        private void ButtonGoogle_Click(object sender, RoutedEventArgs e)
        {
            Uri google = new Uri("https://google.com");
            MainFrame.Navigate(google);
        }
    }
}
