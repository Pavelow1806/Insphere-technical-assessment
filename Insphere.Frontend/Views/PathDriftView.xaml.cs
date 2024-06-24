﻿using Insphere.Frontend.ViewModels;
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
            DataContext = _container.Resolve<IPathDriftViewModel>();
        }
    }
}