using Autofac;
using System.Windows;
using TonerCartridgeApp.UI.StartUp;

namespace TonerCartridgeApp.UI
{
    public partial class App : Application
    {
        private void Application_StartUp(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
