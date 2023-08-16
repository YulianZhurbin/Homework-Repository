using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
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

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            
            Thread th = new Thread(ConnectDatabase);
            th.Start();

            //MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString());
        }

        private void ConnectDatabase()
        {
            //Database connecting 
            Thread.Sleep(TimeSpan.FromSeconds(5));

            ThreadStart threadStart = new ThreadStart(ShowConnectionTryResult);
            Dispatcher.BeginInvoke(DispatcherPriority.Normal, threadStart);
        }

        private void ShowConnectionTryResult()
        {
            textBoxName.Text = "Connection is set";
        }
    }
}
