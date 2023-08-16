using System.Windows;
using System.IO;
using Microsoft.Win32;
namespace Task2
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

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            openDialog.Filter = "Text files (*.TXT)|*.txt";

            if (openDialog.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(openDialog.FileName);
                textBox.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            saveDialog.Filter = "Text files (*.TXT)|*.txt";

            if (saveDialog.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(saveDialog.FileName);
                writer.WriteLine(textBox.Text);
                writer.Close();
            }
        }
    }
}
