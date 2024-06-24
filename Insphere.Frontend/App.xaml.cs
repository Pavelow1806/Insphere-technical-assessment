using Insphere.Frontend.Services.API;
using Insphere.Frontend.ViewModels;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;
using Unity;

namespace Insphere.Frontend
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPathDriftViewModel, PathDriftViewModel>();
            container.RegisterType<IApiService, ApiService>();
            Current.MainWindow = container.Resolve<PathDriftWindow>();
            Current.MainWindow.Show();
        }
    }

}
