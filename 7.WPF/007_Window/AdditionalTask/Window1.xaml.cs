using System.ComponentModel;
using System.Windows;

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(Window_Closing);

            Left = Properties.Settings.Default.WindowPosition1.Left;
            Top = Properties.Settings.Default.WindowPosition1.Top;

            Width = Properties.Settings.Default.WindowPosition1.Width;
            Height = Properties.Settings.Default.WindowPosition1.Height;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.WindowPosition1 = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }
    }
}
