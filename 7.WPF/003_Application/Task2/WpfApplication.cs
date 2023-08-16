using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task2
{
    class WpfApplication : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();
            this.MainWindow = window;
            window.Show();

            if (e.Args.Length > 0)
                ShowDocument(e.Args[0]);
        }

        private void ShowDocument(string path)
        {
            (MainWindow as MainWindow).ShowFileText(path);
        }
    }
}
