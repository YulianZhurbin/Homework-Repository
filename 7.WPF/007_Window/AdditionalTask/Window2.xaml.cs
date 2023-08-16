using System.ComponentModel;
using System.Windows;

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(Window_Closing);

            Left = Properties.Settings.Default.WindowPosition2.Left;
            Top = Properties.Settings.Default.WindowPosition2.Top;

            Width = Properties.Settings.Default.WindowPosition2.Width;
            Height = Properties.Settings.Default.WindowPosition2.Height;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.WindowPosition2 = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }
    }
}
