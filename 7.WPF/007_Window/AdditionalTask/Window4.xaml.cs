using System.ComponentModel;
using System.Windows;

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(Window_Closing);

            Left = Properties.Settings.Default.WindowPosition4.Left;
            Top = Properties.Settings.Default.WindowPosition4.Top;

            Width = Properties.Settings.Default.WindowPosition4.Width;
            Height = Properties.Settings.Default.WindowPosition4.Height;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.WindowPosition4 = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }
    }
}
