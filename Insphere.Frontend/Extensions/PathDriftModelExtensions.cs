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
