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
