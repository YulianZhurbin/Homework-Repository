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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XAML Files (*.xaml)|*.xaml|RichText Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (openFile.ShowDialog() == true)
            {
                TextRange documentTextRange = new TextRange(docReader.Document.ContentStart, docReader.Document.ContentEnd);

                using (FileStream fs = File.Open(openFile.FileName, FileMode.Open))
                {
                    if (System.IO.Path.GetExtension(openFile.FileName).ToLower() == ".rtf")
                    {
                        documentTextRange.Load(fs, DataFormats.Rtf);
                    }
                    else
                    {
                        documentTextRange.Load(fs, DataFormats.Xaml);
                    }
                }
            }
        }
    }
}
