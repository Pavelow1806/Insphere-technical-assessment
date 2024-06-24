using Insphere.Frontend.Services;
using Insphere.Frontend.Services.API;
using Insphere.Frontend.ViewModels;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Net.Http;
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
            container.RegisterType<ILogger<IApiService>, Logger<ApiService>>();
            container.RegisterType<ILoggerFactory, LoggerFactory>();
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(Insphere.Frontend.Properties.Settings.Default.API),
                Timeout = TimeSpan.FromSeconds(30.0)
            };
            container.RegisterInstance(httpClient);
            Current.MainWindow = container.Resolve<PathDriftWindow>();
            Current.MainWindow.Show();
        }
    }

}
