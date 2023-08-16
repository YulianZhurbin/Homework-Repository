using System.ComponentModel;
using System.Windows;

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(Window_Closing);

            Left = Properties.Settings.Default.WindowPosition3.Left;
            Top = Properties.Settings.Default.WindowPosition3.Top;

            Width = Properties.Settings.Default.WindowPosition3.Width;
            Height = Properties.Settings.Default.WindowPosition3.Height;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.WindowPosition3 = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }
    }
}
