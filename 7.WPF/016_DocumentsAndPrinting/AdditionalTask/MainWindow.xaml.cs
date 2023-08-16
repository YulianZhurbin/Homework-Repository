using Microsoft.Win32;
using System.IO;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdNew_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Document = new FlowDocument();
        }
        
        private void cmdOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XAML Files (*.xaml)|*.xaml|RichText Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (openFile.ShowDialog() == true)
            {
                TextRange documentTextRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                using (FileStream fs = File.Open(openFile.FileName, FileMode.Open))
                {
                    if(System.IO.Path.GetExtension(openFile.FileName).ToLower() == ".rtf")
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
        
        private void cmdSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XAML Files (*.xaml)|*.xaml|RichText Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (saveFile.ShowDialog() == true)
            {
                TextRange documentTextRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

                using (FileStream fs = File.Create(saveFile.FileName))
                {
                    if (System.IO.Path.GetExtension(saveFile.FileName).ToLower() == ".rtf")
                    {
                        documentTextRange.Save(fs, DataFormats.Rtf);
                    }
                    else
                    {
                        documentTextRange.Save(fs, DataFormats.Xaml);
                    }
                }
            }
        }

        private void cmdPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if(printDialog.ShowDialog() == true)
            {
                printDialog.PrintDocument(((IDocumentPaginatorSource)richTextBox.Document).DocumentPaginator, "A Flow Document");
            }
        }
    }
}
