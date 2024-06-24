using HelixToolkit.Wpf;
using Insphere.Frontend.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Unity;

namespace Insphere.Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PathDriftWindow : Window
    {
        private readonly IUnityContainer _container;
        public PathDriftWindow(IUnityContainer container)
        {
            InitializeComponent();
            _container = container;
            var context = _container.Resolve<IPathDriftViewModel>() as IPathDriftViewModel;
            DataContext = context;
            Configure3dViewer();
            context.Viewport = viewport;
        }

        private void Configure3dViewer()
        {
            viewport.RotateGesture = new MouseGesture(MouseAction.LeftClick);
        }
    }
}