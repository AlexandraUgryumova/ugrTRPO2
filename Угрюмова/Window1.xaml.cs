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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ButtonGoToWindow2_Click(object sender,RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            if (CheckBox1_ch.IsChecked == true)
            {
                window2.ShowDialog();
            }
            else {

                this.Hide();
                window2.Show();
            }
        }
        private void ButtonGoToWindow3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            if (CheckBox1_ch.IsChecked == true)
            {
                window3.ShowDialog();
            }
            else
            {
                this.Hide();
                window3.Show();
            }
        }
        private void ButtonGoToWindow4_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            if (CheckBox1_ch.IsChecked == true)
            {
                window4.ShowDialog();
            }
            else
            {
                this.Hide();
                window4.Show();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Navigation navigation = new Navigation();
            this.Hide();
            navigation.Show();
        }
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
