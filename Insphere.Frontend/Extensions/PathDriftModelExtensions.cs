using Insphere.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Insphere.Frontend.Extensions
{
    public static class PathDriftModelExtensions
    {
        /// <summary>
        /// Convert a Path Drift model into a Windows.Media.Media3D.Point3D for visual representation using the Felix WPF Toolkit.
        /// </summary>
        /// <param name="model">The model to be converted to a 3D point</param>
        /// <returns>The 3D point</returns>
        public static Point3D ToPoint3D(this PathDriftModel model)
        {
            return new Point3D
            {
                X = model.X,
                Y = model.Y,
                Z = model.Z
            };
        }
    }
}
