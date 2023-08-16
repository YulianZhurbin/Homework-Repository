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

namespace AdditionalTask
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

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //short value;

            //if (Int16.TryParse(e.Text, out value))
            //    e.Handled = true;

            //const string pattern = @"[A-Z]";

            //Regex regex = new Regex(pattern);

            //if(regex.IsMatch(e.Text))
            //{
            //    e.Handled = true;
            //}

            const string pattern = @"[a-z]";

            Regex regex = new Regex(pattern);

            if(!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }
    }
}
