using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.ViewModels
{
    /// <summary>
    /// Primarily used for Unity dependency injection, not actually necessary
    /// </summary>
    public interface IPathDriftViewModel
    {
        public HelixViewport3D Viewport { get; set; }
    }
}
