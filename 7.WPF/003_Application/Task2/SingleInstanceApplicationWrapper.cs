using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows;

namespace Task2
{
    public class SingleInstanceApplicationWrapper : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase 
    {
        private WpfApplication app;

        public SingleInstanceApplicationWrapper()
        {
            IsSingleInstance = true;
        }

        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
        {
            try
            {
                string extension = ".test";
                string title = "SingleInstanceApplication";
                string extensionDescription = "A Test Document";
                ExtensionRegisterHelper.SetFileAssociation(extension, title + "." + extensionDescription);
            }
            catch
            {
                MessageBox.Show("The extension .test cannot be registered");
            }

            app = new WpfApplication();
            app.Run();

            return false;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            if(eventArgs.CommandLine.Count > 0)
            {
                (Application.Current.MainWindow as MainWindow).ShowFileText(eventArgs.CommandLine[0]);
            }

            Application.Current.MainWindow.Activate();
        }
    }
}