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

namespace _001_IntroductionAndXAML
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(loginBoxName.Text == string.Empty)
            {
                MessageBox.Show("You've not entered your login");
            }
            else if(passwordBoxName.Text == string.Empty)
            {
                MessageBox.Show("You've not entered the password");
            }
            else if(loginBoxName.Text != "Julian")
            {
                MessageBox.Show("Wrong login");
            }
            else if(passwordBoxName.Text != "12345")
            {
                MessageBox.Show("Wrong password");
            }
            else
            {
                MessageBox.Show($"Hello, {loginBoxName.Text}");
            }
        }
    }
}
