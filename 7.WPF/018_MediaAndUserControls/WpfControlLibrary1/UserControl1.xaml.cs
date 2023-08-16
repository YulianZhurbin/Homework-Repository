using Microsoft.Win32;
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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void cmdPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }
        private void cmdStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
        private void cmdPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void cmdOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Video files(*.mpg)|*.mpg|Audio files(*.mp3)|*.mp3|All Files (*.*)|*.*";

            if (openFile.ShowDialog() == true)
            {
                mediaPlayer.Source = new Uri(openFile.FileName);
                mediaPlayer.Play();
            }
        }
    }
}
