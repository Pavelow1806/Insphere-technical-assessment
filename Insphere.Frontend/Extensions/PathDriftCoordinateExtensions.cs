using Insphere.Frontend.Models;
using Insphere.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.Extensions
{
    public static class PathDriftCoordinateExtensions
    {
        /// <summary>
        /// Convert Path Drift coordinate from the API into a simpler usable model.
        /// </summary>
        /// <param name="coordinate">The coordinate being converted</param>
        /// <returns>The model that's been simplified</returns>
        public static PathDriftModel ConvertToModel(this PathDriftCoordinate coordinate)
        {
            return new PathDriftModel
            {
                ID = coordinate.ID,
                Index = coordinate.Index,
                X = coordinate.X,
                Y = coordinate.Y,
                Z = coordinate.Z
            };
        }
    }
}
