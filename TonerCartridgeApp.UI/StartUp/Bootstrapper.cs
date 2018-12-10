using Autofac;
using TonerCartridgeApp.UI.Data;
using TonerCartridgeApp.UI.ViewModel;

namespace TonerCartridgeApp.UI.StartUp
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<AppUserDataService>().As<IAppUserDataService>();
            return builder.Build();
        }
    }
}
