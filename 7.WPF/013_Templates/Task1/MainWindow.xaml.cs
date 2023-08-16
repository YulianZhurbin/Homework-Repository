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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<UserEntry> userBase;
        public MainWindow()
        {
            InitializeComponent();

            CreateUserBase();
        }

        private void CreateUserBase()
        {
            UserEntry premiumUser = new UserEntry("John", "1111", Status.Premium);
            UserEntry simpleUser1 = new UserEntry("Mike", "2222", Status.Simple);
            UserEntry simpleUser2 = new UserEntry("Rob", "3333");

            userBase = new List<UserEntry>();
            userBase.Add(premiumUser);
            userBase.Add(simpleUser1);
            userBase.Add(simpleUser2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var userEntry in userBase)
            {
                if(loginTextBox.Text == userEntry.Login && PasswordTextBox.Text == userEntry.Password)
                {
                    CalculatorWindow calculatorWindow = new CalculatorWindow(userEntry.Status);
                    calculatorWindow.Show();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("There is no such user. Try again!");
        }
    }
}
