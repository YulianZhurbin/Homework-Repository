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

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label lbl = sender as Label;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);
        }

        private void Label_Drop(object sender, DragEventArgs e)
        {
            ((Label)sender).Content = e.Data.GetData(typeof(Image));
        }
    }
}
