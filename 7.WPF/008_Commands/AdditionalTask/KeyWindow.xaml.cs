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

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for KeyWindow.xaml
    /// </summary>
    public partial class KeyWindow : Window
    {
        private string[] keys = { "11111", "22222", "33333"};

        public KeyWindow()
        {
            InitializeComponent();
        }

        private void laterButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            string keyEntered = keyTxtBox.Text;
            bool isKeyValid = false;

            foreach(string key in keys)
            {
                if(keyEntered == key)
                {
                    MessageBox.Show("You've got a pro version!");

                    (Owner as MainWindow).UpgradeToPro();
                    isKeyValid = true;
                }
            }

            if(isKeyValid)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("You've entered a wrong key. Try again.");
            }
        }
    }
}
