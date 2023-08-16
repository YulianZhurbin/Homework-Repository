using System.ComponentModel;
using System.Windows;

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

            Closing += new CancelEventHandler(MainWindow_Closing);

            Left = Properties.Settings.Default.WindowPosition.Left;
            Top = Properties.Settings.Default.WindowPosition.Top;

            Width = Properties.Settings.Default.WindowPosition.Width;
            Height = Properties.Settings.Default.WindowPosition.Height;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.WindowPosition = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window = new Window3();
            window.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            window.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Window5 window = new Window5();
            window.Show();
        }
    }
}
