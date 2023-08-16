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
        private Queue<SolidColorBrush> colors;

        public MainWindow()
        {
            InitializeComponent();

            MakeColorQueue();
        }

        private void ExtraButton_MyButtonClick(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (colors.Count == 0)
            {
                MakeColorQueue();
            }

            //MessageBox.Show((sender as Button).Name);
            if (senderButton.Name != "button10")
                senderButton.Background = colors.Dequeue();
        }

        private void MakeColorQueue()
        {
            colors = new Queue<SolidColorBrush>();
            colors.Enqueue(Brushes.Red);
            colors.Enqueue(Brushes.Green);
            colors.Enqueue(Brushes.Yellow);
            colors.Enqueue(Brushes.Blue);
            colors.Enqueue(Brushes.Brown);
            colors.Enqueue(Brushes.Cyan);
            colors.Enqueue(Brushes.Gray);
            colors.Enqueue(Brushes.Orange);
            colors.Enqueue(Brushes.Purple);
            colors.Enqueue(Brushes.Snow);
        }
    }
}
