using MauiApp1.Services;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

            try
            {
                MainPage = new MainPage();
            }
            catch (Exception)
            {

                throw;
            }

            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            //TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
        }
        private void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            Debug.WriteLine($"***** Handling Unhandled Exception *****: {e.Exception.Message}");
            // YourLogger.LogError($"***** Handling Unhandled Exception *****: {e.Exception.Message}");
        }
    }
}
