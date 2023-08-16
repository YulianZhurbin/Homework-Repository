using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Task2
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

        private void StringText_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;
            textBox.Foreground = Regex.Match(textBox.Text, @"[A-Za-z ]").Success ? Brushes.Black : Brushes.Red;
        }

        private void NumberText_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;
            int.TryParse(textBox.Text, out int num);
            textBox.Foreground = ((num > 17) && (num < 140)) ? Brushes.Black : Brushes.Red;
           
        }
    }
}
