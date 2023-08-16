using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openDialog = new OpenFileDialog();
        SaveFileDialog saveDialog = new SaveFileDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow newMainWindow = new MainWindow();
            newMainWindow.Show();
        }

        private void OpenCommand(object sender, ExecutedRoutedEventArgs e)
        {
            openDialog.Filter = "Text files (*.TXT)|*.txt";

            if (openDialog.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(openDialog.FileName);
                textBox.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void SaveCommand(object sender, ExecutedRoutedEventArgs e)
        {
            saveDialog.Filter = "Text files (*.TXT)|*.txt";

            if (saveDialog.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(saveDialog.FileName);
                writer.WriteLine(textBox.Text);
                writer.Close();
            }
        }

        private void CloseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();

            //this.Close();
        }
    }
}
