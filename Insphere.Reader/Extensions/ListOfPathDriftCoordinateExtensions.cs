using Insphere.Protos;
using System.Collections.Concurrent;

namespace Insphere.Reader.Extensions
{
    public static class ListOfPathDriftCoordinateExtensions
    {
        public static (double AverageX, double AverageY, double AverageZ) CalculateCentrePoint(this List<PathDriftCoordinate> coordinates)
        {
            var x = new ConcurrentBag<double>();
            var y = new ConcurrentBag<double>();
            var z = new ConcurrentBag<double>();
            Parallel.ForEach(coordinates, coordinate =>
            {
                x.Add(coordinate.X);
                y.Add(coordinate.Y);
                z.Add(coordinate.Z);
            });
            return (x.Average(), y.Average(), z.Average());
        }
    }
}
