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

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FontFamily inconsolataFontFamily, openSansFontFamily, playFairDisplayFontFamily;

        public MainWindow()
        {
            InitializeComponent();

            inconsolataFontFamily = new FontFamily("Arial");
            openSansFontFamily = new FontFamily("Times New Roman");
            playFairDisplayFontFamily = new FontFamily("Ink Free");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = String.Empty;
        }

        private void InconsolataRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = inconsolataFontFamily;
        }

        private void OpenSansRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = openSansFontFamily;
        }

        private void PlayFairDisplayRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = playFairDisplayFontFamily;
        }
    }
}
