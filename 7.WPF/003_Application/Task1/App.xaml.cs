using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Diagnostics;

namespace Task1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private List<string> eventCollection;

        public List<string> EventCollection
        {
            get { return eventCollection; }
        }

        public App()
        {
            Startup += new StartupEventHandler(App_Startup);
            Exit += new ExitEventHandler(App_Exit);
            SessionEnding += new SessionEndingCancelEventHandler(App_SessionEnding);
            Activated += new EventHandler(App_Activated);
            Deactivated += new EventHandler(App_Deactivated);
            DispatcherUnhandledException += new DispatcherUnhandledExceptionEventHandler(App_DispatcherUngandledException);

            eventCollection = new List<string>();
        }

        private void App_DispatcherUngandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            eventCollection.Add("DispatcherUnhandledException");
        }

        private void App_Deactivated(object sender, EventArgs e)
        {
            eventCollection.Add("Deactivated");
        }

        private void App_Activated(object sender, EventArgs e)
        {
            eventCollection.Add("Activated");
        }

        private void App_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            eventCollection.Add("SessionEnding");
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            eventCollection.Add("Startup");
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            eventCollection.Add("Exit");
        }


    }

}
