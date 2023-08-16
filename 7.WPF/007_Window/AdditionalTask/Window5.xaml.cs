using System.ComponentModel;
using System.Windows;

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(Window_Closing);

            Left = Properties.Settings.Default.WindowPosition5.Left;
            Top = Properties.Settings.Default.WindowPosition5.Top;

            Width = Properties.Settings.Default.WindowPosition5.Width;
            Height = Properties.Settings.Default.WindowPosition5.Height;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.WindowPosition5 = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }
    }
}
